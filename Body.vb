Imports System.IO
Imports System.Text

Public Class Body
    Friend timerCount As Integer = 0

    Friend currentUser As String
    Friend displayUser As String

    Friend currentHashCode As String
    Private currentStelleCode As String

    Private textHelper As New TextHelper()
    Private securityHelper As New SecurityHelperAdvanced()
    Private passwordHelper As New Passwords()
    Private listViewHelper As New ListViewHelper()
    Friend currentFlowLayoutPanel As FlowLayoutPanel

    Private random As New Random()

    Private stelleData() As String =
        {"Every journey needs a map, and every account needs a secure password.",
        "Your passwords are like stars—each one unique and important.",
        "Ready to unlock the next level of security?",
        "Let’s make this quick. Your passwords are safe with me.",
        "Your security is my top priority. Let’s keep those passwords safe!",
        "Unlocking your accounts securely feels like solving a cosmic puzzle.",
        "No more forgotten passwords. I’ve got you covered.",
        "Here comes something special—two-factor authentication!",
        "Let’s stick together and secure everything!",
        "I’ve got your back! Let’s keep your accounts safe."}

    ' Form Controls
    Private Sub Body_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowForm(Home)
        ResizeForm(Home.flpHome)

        tmrStelle.Start()
    End Sub

    Private Sub Body_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        LaunchPad.Show()
    End Sub
    Private Sub ShowForm(childForm As Form)
        ' Hide specific panels or forms if necessary
        pnlMigrationOptions.Visible = False
        Home.Hide()
        Passwords.Hide()

        ' Set up the new child form
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.TopLevel = False
        childForm.Dock = DockStyle.Fill

        ' Add the new child form to the parent form's controls
        Controls.Add(childForm)
        Controls.SetChildIndex(childForm, 0) ' Ensure the child form is behind the dashboard

        ' Show the new child form
        childForm.Show()
    End Sub
    Friend Sub ResizeForm(mainFlowLayoutPanel As FlowLayoutPanel)
        ' Resize the target form
        ClientSize = New Size(pnlDashboard.Width + flpAssistant.Width + mainFlowLayoutPanel.Width, Math.Max(pnlDashboard.Height, mainFlowLayoutPanel.Height))
        CenterToScreen()

        ' Return the FlowLayoutPanel
        currentFlowLayoutPanel = mainFlowLayoutPanel
    End Sub

    ' Dashboard Controls
    Private Sub DashboardButton_Click(sender As Object, e As EventArgs) Handles btnHome.Click, btnPasswords.Click, btnMigration.Click, btnReview.Click, btnSetting.Click, btnImport.Click, btnExport.Click, btnLogout.Click
        PlaySound(My.Resources.click)

        Dim buttonActions As New Dictionary(Of Button, Action) From {
        {btnHome, Sub()
                      ShowForm(Home)
                      ResizeForm(Home.flpHome)
                  End Sub},
        {btnPasswords, Sub()
                           listViewHelper.AutoResizeColumns(Passwords.lsvMain)
                           ShowForm(Passwords)
                           ResizeForm(Passwords.flpPasswords)
                       End Sub},
        {btnReview, Sub()
                        listViewHelper.AutoResizeColumns(Review.lsvReview)
                        ShowForm(Review)
                        ResizeForm(Review.flpReview)
                    End Sub},
        {btnMigration, Sub() pnlMigrationOptions.Visible = Not pnlMigrationOptions.Visible},
                {btnImport, Sub()
                                If TriplePassword() Then
                                    Using ofd As New OpenFileDialog()
                                        ofd.Filter = "CSV Files (*.csv)|*.csv"
                                        ofd.Title = "Import Passwords"
                                        If ofd.ShowDialog() = DialogResult.OK Then
                                            ImportPasswords(ofd.FileName)
                                        End If
                                    End Using
                                End If
                            End Sub},
        {btnExport, Sub()
                        If TriplePassword() Then
                            Using folderDialog As New FolderBrowserDialog()
                                If folderDialog.ShowDialog() = DialogResult.OK Then
                                    Dim selectedFolder As String = folderDialog.SelectedPath
                                    ExportPasswords(selectedFolder)
                                End If
                            End Using
                        End If
                    End Sub},
        {btnSetting, Sub()
                         ShowForm(Setting)
                         ResizeForm(Setting.flpSetting)
                     End Sub},
        {btnLogout, Async Sub()
                        timerCount = 0
                        ptcStelle.Image = My.Resources.Goodbye
                        txtGreeting.Text = "Goodbye. Take care."
                        txtStatus.Text = "I hope we meet again, " + displayUser + "..."
                        tmrStelle.Stop()

                        Await Task.Delay(1000)

                        ShowForm(Home)
                        ResizeForm(Home.flpHome)

                        Passwords.lsvMain.Items.Clear()
                        Review.lsvReview.Items.Clear()
                        Passwords.btnRestore.Enabled = False
                        Passwords.btnRestore.BackColor = Color.Gray
                        LaunchPad.Show()
                        Me.Dispose()
                    End Sub
                    }
        }

        ' {btnStatus, Sub() ShowAndResizeForm(Review, Review.flpReview)},
        ' {btnSetting, Sub() ShowAndResizeForm(Setting, Setting.flpSetting)},

        Dim clickedButton As Button = DirectCast(sender, Button)
        If buttonActions.ContainsKey(clickedButton) Then
            buttonActions(clickedButton).Invoke()
        End If
    End Sub
    Private Sub DashboardButton_MouseEnter(sender As Object, e As EventArgs) Handles btnHome.MouseEnter, btnPasswords.MouseEnter, btnMigration.MouseEnter, btnReview.MouseEnter, btnSetting.MouseEnter, btnImport.MouseEnter, btnExport.MouseEnter, btnLogout.MouseEnter
        PlaySound(My.Resources.hover)
    End Sub
    Private Sub PlaySound(resource As System.IO.UnmanagedMemoryStream)
        Using player As New System.Media.SoundPlayer(resource)
            player.Play()
        End Using
    End Sub

    ' User Identity Controls
    Friend Sub SetCurrentUser(username As String, password As String, maxAttempts As Integer)
        currentUser = username

        Dim passwordAttempts As Integer = CInt(securityHelper.ReadCredentials(username, username, 7))
        Dim stelleAttempts As Integer = CInt(securityHelper.ReadCredentials(username, username, 8))

        If passwordAttempts >= maxAttempts Or stelleAttempts > 0 Then
            HandleLockout(username)
        End If

        displayUser = securityHelper.ReadCredentials(username, password, 9)
        securityHelper.ChangeCredentials(username, 0, username, 7, False)

        ' Initialization
        currentHashCode = securityHelper.ReadCredentials(currentUser, password, 4)
        passwordHelper.LoadPasswords(currentHashCode, Passwords.lsvMain)

        ' Generation
        Dim tempHashCode As String = securityHelper.GenerateString(20, 2)
        securityHelper.ChangeCredentials(currentUser, tempHashCode, tempHashCode, 3, False)
        Home.LoadLastLoginTime(currentUser)

        ' Modification
        passwordHelper.UpdatePasswords(currentHashCode, tempHashCode)
        currentHashCode = tempHashCode
        securityHelper.ChangeCredentials(currentUser, currentHashCode, password, 4, False)

        Login.Hide()
    End Sub
    Private Sub tmrStelle_Tick(sender As Object, e As EventArgs) Handles tmrStelle.Tick
        timerCount += 1
        If timerCount = 5 Then
            tmrStelle.Enabled = False
            ptcStelle.Image = My.Resources.Standby
            txtGreeting.Text = displayUser + "..."
            txtStatus.Text = "Hmm... what should we do today?" & vbCrLf & "How about we update some passwords?"
        End If
    End Sub
    Private Sub HandleLockout(inputEmail As String)
        Dim stelleAttempts As Integer = CInt(securityHelper.ReadCredentials(inputEmail, inputEmail, 8))

        MsgBox("Maximum number of attempts reached for this account." & vbCrLf & "Please enter your latest stelle code to unlock your account.", vbExclamation + vbOKOnly, "Account Locked")

        If Passwords.VerifyPassword("Stelle Code", 5, My.Resources.iconCode) Then
            securityHelper.ChangeCredentials(inputEmail, 0, inputEmail, 7, False)
            securityHelper.ChangeCredentials(inputEmail, 0, inputEmail, 8, False)
            MsgBox("Stelle code entered successfully. Your account has been unlocked.", vbInformation + vbOKOnly, "Account Unlocked")
        Else
            stelleAttempts += 1
            securityHelper.ChangeCredentials(inputEmail, stelleAttempts, inputEmail, 8, False)
            Dim lockoutTime As DateTime = DateTime.Now.Add(GetLockoutDuration(stelleAttempts))
            securityHelper.ChangeCredentials(inputEmail, lockoutTime.ToString(), inputEmail, 10, False)

            LaunchPad.Show()
            Me.Hide()
        End If
    End Sub
    Private Function GetLockoutDuration(stelleAttempts As Integer) As TimeSpan
        ' Initial lockout time is 15 minutes, doubling with each failed attempt
        Dim initialMinutes As Double = 15
        Dim lockoutMinutes As Double = initialMinutes * Math.Pow(2, stelleAttempts - 1)
        Return TimeSpan.FromMinutes(lockoutMinutes)
    End Function

    ' Data Transfer
    Private Sub ExportPasswords(selectedFolder As String)
        ' Create the file name based on the user's name
        Dim fileName As String = $"{currentUser} Passwords.csv"
        Dim filePath As String = Path.Combine(selectedFolder, fileName)

        ' Write the passwords to the CSV file in Google format
        Using writer As New StreamWriter(filePath, False, Encoding.UTF8)
            ' Write the header line
            writer.WriteLine("name,url,username,password,note")

            ' Write each password entry
            For Each item As ListViewItem In Passwords.lsvMain.Items
                Dim account As String = textHelper.EscapeCSVField(item.SubItems(0).Text)

                ' Skip entry if account is empty
                If String.IsNullOrEmpty(account) Then
                    Continue For
                End If

                Dim user As String = textHelper.EscapeCSVField(item.SubItems(1).Text)
                Dim email As String = textHelper.EscapeCSVField(item.SubItems(2).Text)
                Dim password As String = textHelper.EscapeCSVField(item.SubItems(3).Tag.ToString())

                ' Create a combined username/email field for export
                Dim usernameOrEmail As String = If(String.IsNullOrEmpty(email), user, email)

                ' Create a URL based on the account
                Dim url As String = $"https://{account}"

                writer.WriteLine($"{account},{url},{usernameOrEmail},{password},")
            Next
        End Using
        MessageBox.Show($"Passwords exported successfully to {filePath}.", "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub ImportPasswords(filePath As String)
        Dim importedLines As New List(Of String)
        Using reader As New StreamReader(filePath, Encoding.UTF8)
            Dim line As String = reader.ReadLine() ' Read the header line and ignore it
            line = reader.ReadLine() ' Read the first actual data line
            While line IsNot Nothing
                Dim parts As String() = line.Split(","c)
                If parts.Length >= 4 Then
                    Dim account As String = parts(0).Trim()
                    ' Dim url As String = parts(1).Trim()
                    Dim usernameOrEmail As String = parts(2).Trim()
                    Dim password As String = parts(3).Trim()

                    ' Remove surrounding double quotes if present and not escaped
                    If password.StartsWith("""") AndAlso Not password.StartsWith("""""") Then
                        password = password.Substring(1)
                    End If
                    If password.EndsWith("""") AndAlso Not password.EndsWith("""""") Then
                        password = password.Substring(0, password.Length - 1)
                    End If

                    ' Handle cases where there are 3 double quotes at the start or end
                    If password.StartsWith("""""") AndAlso password.StartsWith("""""""") Then
                        password = password.Substring(1)
                    End If
                    If password.EndsWith("""""") AndAlso password.EndsWith("""""""") Then
                        password = password.Substring(0, password.Length - 1)
                    End If
                    ' Replace escaped double quotes with a single double quote
                    password = password.Replace("""""", """")

                    Dim username As String = String.Empty
                    Dim email As String = String.Empty

                    If usernameOrEmail.Contains("@") Then
                        email = usernameOrEmail
                    Else
                        username = usernameOrEmail
                    End If

                    Dim listViewItem As New ListViewItem(account)
                    listViewItem.SubItems.Add(New ListViewItem.ListViewSubItem() With {.Text = username})
                    listViewItem.SubItems.Add(New ListViewItem.ListViewSubItem() With {.Text = email})
                    listViewItem.SubItems.Add(New ListViewItem.ListViewSubItem() With {.Text = If(Passwords.passwordsVisible, password, New String("*"c, password.Length)), .Tag = password})

                    Passwords.lsvMain.Items.Add(listViewItem)
                End If
                line = reader.ReadLine()
            End While
        End Using
        Passwords.SavePasswords(currentHashCode)
        listViewHelper.AutoResizeColumns(Passwords.lsvMain)
    End Sub
    Friend Function TriplePassword() As Boolean
        Using confirmForm As New Message()
            confirmForm.Text = "Are you sure?"
            confirmForm.flpMain.Visible = False
            confirmForm.flpExtra.Visible = False

            If confirmForm.ShowDialog() = DialogResult.OK Then
                Using tripleForm As New Message()
                    tripleForm.Text = "Authentication Required: "
                    tripleForm.ptcField.Image = My.Resources.iconPassword
                    tripleForm.ptcVerify.Image = My.Resources.iconVault
                    tripleForm.ptcEmail.Image = My.Resources.iconCode
                    textHelper.ConfigureTextBox(tripleForm.txtField, "Account Password", True)
                    textHelper.ConfigureTextBox(tripleForm.txtVerify, "Vault Password", True)
                    textHelper.ConfigureTextBox(tripleForm.txtEmail, "Stelle Code", True)

                    tripleForm.flpPassword.Visible = False
                    If tripleForm.ShowDialog() = DialogResult.OK Then
                        Dim password As String = textHelper.GetActualText(tripleForm.txtField)
                        Dim vault As String = textHelper.GetActualText(tripleForm.txtVerify)
                        Dim code As String = textHelper.GetActualText(tripleForm.txtEmail)
                        If securityHelper.CheckCredentials(currentUser, password, 1) And securityHelper.CheckCredentials(currentUser, vault, 2) And securityHelper.CheckCredentials(currentUser, code, 5) Then
                            Return True
                        End If
                    End If
                    Return False
                End Using
                Return False
            End If
        End Using
        Return False
    End Function


    Private currentIndex As Integer = 0
    Private stelleCodeChars As Char()
    Private Sub ptcStelle_Click(sender As Object, e As EventArgs) Handles ptcStelle.Click
        If Setting.passwordsChanged Then
            tmrStelle.Stop()
            timerCount = 0
            currentIndex = 0
            Dim stelleCode As String = securityHelper.GenerateStelleCode(15, 5)
            securityHelper.ChangeCredentials(currentUser, stelleCode, stelleCode, 5, False)

            txtGreeting.Text = $"Okay, {displayUser}!"
            txtStatus.Text = "Listen carefully, okay?"

            ' Convert the input string to a character array
            stelleCodeChars = stelleCode.ToCharArray()

            ' Start the timer
            tmrDisplay.Start()
        End If
    End Sub
    Private Sub tmrDisplay_Tick(sender As Object, e As EventArgs) Handles tmrDisplay.Tick
        ' Check if there are more characters to process
        If currentIndex < stelleCodeChars.Length Then
            ' Get the current character
            Dim ch As Char = stelleCodeChars(currentIndex)

            txtStatus.Text = stelleData(Random.Next(stelleData.Length))
            ' Determine the appropriate image based on the character
            Select Case ch
                Case "0"
                    ptcStelle.Image = My.Resources._0
                Case "1"
                    ptcStelle.Image = My.Resources._1
                Case "2"
                    ptcStelle.Image = My.Resources._2
                Case "3"
                    ptcStelle.Image = My.Resources._3
                Case "4"
                    ptcStelle.Image = My.Resources._4
                Case "5"
                    ptcStelle.Image = My.Resources._5
                Case "6"
                    ptcStelle.Image = My.Resources._6
                Case "7"
                    ptcStelle.Image = My.Resources._7
                Case "8"
                    ptcStelle.Image = My.Resources._8
                Case "9"
                    ptcStelle.Image = My.Resources._9
                Case Else
                    ptcStelle.Image = My.Resources._Nothing
            End Select

            ' Move to the next character
            currentIndex += 1
        Else
            txtStatus.Text = "Alright! That's everything! Did you manage to get it all correct? Let's check!"
            ' Stop the timer when all characters have been processed
            tmrDisplay.Stop()

            ' Check the user's response
            If Passwords.VerifyPassword("Stelle Code", 5, My.Resources.iconVault) Then
                txtGreeting.Text = $"Great, {displayUser}!"
                txtStatus.Text = "Spot on! Remember the code I just shared with you."
                Setting.passwordsChanged = False
                tmrStelle.Start()
            Else
                txtGreeting.Text = "Oops!"
                txtStatus.Text = "Was that too quick for you? Let's give it another try. Give me another click!"
            End If
        End If
    End Sub
End Class