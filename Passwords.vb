Imports System.IO
Imports System.Text

Public Class Passwords
    Private textHelper As New TextHelper()
    Private securityHelper As New SecurityHelperAdvanced()
    Private listViewHelper As New ListViewHelper()

    Friend passwordsVisible As Boolean = False
    Private passwordsChanged As Boolean = False

    Friend removedPasswords As New List(Of ListViewItem)

    ' Form Controls
    Private Sub Passwords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClientSize = New Size(flpPasswords.Width, flpPasswords.Height)

        textHelper.ConfigureTextBox(txtAccount, "Website", False)
        textHelper.ConfigureTextBox(txtUsername, "Username", False)
        textHelper.ConfigureTextBox(txtEmail, "Email", False)
        textHelper.ConfigureTextBox(txtPassword, "Password", True)
        textHelper.ConfigureTextBox(txtSearch, "Search", False)

        listViewHelper.AttachHandlers(lsvMain)
        listViewHelper.AutoResizeColumns(lsvMain)

        LoadPasswords(Body.currentHashCode, lsvMain)
    End Sub

    ' Password Management
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim inputAccount = textHelper.GetActualText(txtAccount)
        Dim inputUsername = textHelper.GetActualText(txtUsername)
        Dim inputEmail = textHelper.GetActualText(txtEmail)
        Dim inputPassword = textHelper.GetActualText(txtPassword)
        Dim dateAdded = DateTime.Now.ToString("yyyy-MM-dd") ' Add the current date and time

        If inputUsername = "Username" Then
            inputUsername = ""
        End If

        Body.timerCount = 0
        Body.tmrStelle.Enabled = True
        If inputPassword.Length <= 10 Then
            Body.ptcStelle.Image = My.Resources.AddShort
            Body.txtGreeting.Text = "Uhh... " + Body.displayUser + "?"
            Body.txtStatus.Text = "Really? A short password? Do you want your data stolen? You need to take this seriously."
        ElseIf inputPassword.Length >= 11 And inputPassword.Length <= 20 Then
            Body.ptcStelle.Image = My.Resources.AddMedium
            Body.txtGreeting.Text = Body.displayUser + "..."
            Body.txtStatus.Text = "Oh, a medium-length password? That's kinda... meh. We could definitely do better than that."
        ElseIf inputPassword.Length > 20 Then
            Body.ptcStelle.Image = My.Resources.AddLong
            Body.txtGreeting.Text = "Great, " + Body.displayUser + "!"
            Body.txtStatus.Text = "A long password! That's what I'm talking about! Keep up the stellar work!"
        End If

        ' Escape fields to handle commas and quotes
        Dim listViewItem As New ListViewItem(textHelper.EscapeCSVField(inputAccount))
        listViewItem.SubItems.Add(textHelper.EscapeCSVField(inputUsername))
        listViewItem.SubItems.Add(textHelper.EscapeCSVField(inputEmail))
        listViewItem.SubItems.Add(New ListViewItem.ListViewSubItem(listViewItem, If(passwordsVisible, textHelper.EscapeCSVField(inputPassword), New String("*"c, inputPassword.Length))) With {.Tag = inputPassword})

        ' Store the dateAdded in a way that won't display it on the ListView
        listViewItem.Tag = dateAdded ' Store dateAdded in the Tag property of the ListViewItem

        lsvMain.Items.Add(listViewItem)
        originalItems.Add(listViewItem.Clone())

        SavePasswords(Body.currentHashCode)
        listViewHelper.AutoResizeColumns(lsvMain)
        listViewHelper.AutoResizeColumns(Review.lsvReview)

        textHelper.StandardTextBox(txtAccount, "Website")
        textHelper.StandardTextBox(txtUsername, "Username")
        textHelper.StandardTextBox(txtEmail, "Email")
        textHelper.StandardTextBox(txtPassword, "Password")
    End Sub
    Private Sub btnSuggest_Click(sender As Object, e As EventArgs) Handles btnSuggest.Click
        Body.timerCount = 0
        Body.tmrStelle.Enabled = True
        Body.ptcStelle.Image = My.Resources.Suggest

        ' Body.txtStatus.Text = stelleData(Random.Next(stelleData.Length))
        Dim passwordLength = trkLength.Value
        Dim suggestedPassword = securityHelper.GenerateString(passwordLength, 0)
        txtPassword.Text = suggestedPassword
        txtPassword.ForeColor = Color.Black

        Dim inputUsername = textHelper.GetActualText(txtUsername)
        Dim inputEmail = textHelper.GetActualText(txtEmail)
        Dim inputPassword = textHelper.GetActualText(txtPassword)
    End Sub
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        ' Check if there are any selected items to remove
        If lsvMain.SelectedItems.Count > 0 Then
            Body.timerCount = 0
            Body.tmrStelle.Enabled = True
            Body.ptcStelle.Image = My.Resources.Remove
            Body.txtGreeting.Text = "Why... " + Body.displayUser + "?"
            Body.txtStatus.Text = "Why do you want to remove your passwords here? That doesn't seem logical."

            ' Loop through the selected items and remove them
            For Each item As ListViewItem In lsvMain.SelectedItems
                ' Add the removed item to the list of removed passwords
                removedPasswords.Add(item)
                ' Limit the list to the last 5 removed passwords
                If removedPasswords.Count > 5 Then
                    removedPasswords.RemoveAt(0)
                End If

                lsvMain.Items.Remove(item)
                originalItems.RemoveAll(Function(oriItem) oriItem.Text = item.Text AndAlso oriItem.SubItems(1).Text = item.SubItems(1).Text) ' Synchronize with originalItems
            Next

            ' Save the updated list of passwords
            SavePasswords(Body.currentHashCode)
            LoadPasswords(Body.currentHashCode, lsvMain)
            listViewHelper.AutoResizeColumns(lsvMain)
            listViewHelper.AutoResizeColumns(Review.lsvReview)

            btnRestore.Enabled = True
            btnRestore.BackColor = Color.FromArgb(174, 107, 107)
        Else
            MessageBox.Show("Please select an item from the list of entries to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btnRestore_Click(sender As Object, e As EventArgs) Handles btnRestore.Click
        ' Check if there are any removed passwords to restore
        If removedPasswords.Count > 0 Then
            Body.timerCount = 0
            Body.tmrStelle.Enabled = True
            Body.ptcStelle.Image = My.Resources.AddLong
            Body.txtGreeting.Text = "Why... " + Body.displayUser + "?"
            Body.txtStatus.Text = "I'm glad you changed your mind. For a moment, I was really worried you were going to delete it for good. Everything is back to the way it was. Just let me know if you need anything else."

            ' Get the last removed password
            Dim lastRemovedPassword As ListViewItem = removedPasswords(removedPasswords.Count - 1)

            ' Add it back to the list
            lsvMain.Items.Add(lastRemovedPassword)
            originalItems.Add(lastRemovedPassword) ' Add back to originalItems

            ' Remove it from the list of removed passwords
            removedPasswords.RemoveAt(removedPasswords.Count - 1)

            ' Save the updated list of passwords
            SavePasswords(Body.currentHashCode)
            LoadPasswords(Body.currentHashCode, lsvMain)
            listViewHelper.AutoResizeColumns(lsvMain)
            listViewHelper.AutoResizeColumns(Review.lsvReview)

            If removedPasswords.Count = 0 Then
                ' Disable the restore button
                btnRestore.Enabled = False
                btnRestore.BackColor = Color.Gray
            End If
        Else
            MessageBox.Show("No removed passwords to restore.", "Restore Failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        passwordsVisible = Not passwordsVisible

        If passwordsVisible Then
            Body.timerCount = 0
            Body.tmrStelle.Enabled = True
            Body.ptcStelle.Image = My.Resources.Show
            Body.tmrStelle.Stop()
            Body.txtGreeting.Text = "..."
            Body.txtStatus.Text = "Oh, you want to see your saved passwords? Sure, but I'll need the vault password first. Could you provide that?"

            ' Verify vault password
            If VerifyPassword("Vault Password", 2, My.Resources.iconVault) Then
                For Each item As ListViewItem In lsvMain.Items
                    item.SubItems(3).Text = item.SubItems(3).Tag.ToString ' Show password
                Next
                For Each item As ListViewItem In Review.lsvReview.Items
                    item.SubItems(1).Text = item.SubItems(1).Tag.ToString ' Show password
                Next
                listViewHelper.AutoResizeColumns(lsvMain)
                listViewHelper.AutoResizeColumns(Review.lsvReview)

                Body.ResizeForm(Body.currentFlowLayoutPanel)
                CenterToScreen()
            Else
                passwordsVisible = Not passwordsVisible ' Revert visibility flag
            End If

            Body.tmrStelle.Start()
        Else
            ' Mask passwords if visibility is toggled off
            For Each item As ListViewItem In lsvMain.Items
                item.SubItems(3).Text = New String("*"c, item.SubItems(3).Tag.ToString.Length) ' Mask password
            Next
            For Each item As ListViewItem In Review.lsvReview.Items
                item.SubItems(1).Text = New String("*"c, item.SubItems(1).Tag.ToString.Length) ' Mask password
            Next

            listViewHelper.AutoResizeColumns(lsvMain)
            listViewHelper.AutoResizeColumns(Review.lsvReview)
            Body.ResizeForm(Body.currentFlowLayoutPanel)
            CenterToScreen()
        End If

        Review.ReviewPasswords(Body.currentHashCode)
        btnShow.Text = If(passwordsVisible, "Hide Passwords", "Show Passwords")
    End Sub

    ' Miscellaneous Controls
    Private Sub trkLength_ValueChanged(sender As Object, e As EventArgs) Handles trkLength.ValueChanged
        lblPasswordLength.Text = $"Password Length: {trkLength.Value}"
    End Sub
    Private Sub txtEmailOrPassword_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged, txtPassword.TextChanged
        ' Check if both fields are filled with valid data
        Dim isEmailValid As Boolean = txtEmail.Text <> String.Empty AndAlso txtEmail.Text <> "Email"
        Dim isPasswordValid As Boolean = txtPassword.Text <> String.Empty AndAlso txtPassword.Text <> "Password"

        ' Enable/Disable the Add button and set the background color
        btnAdd.Enabled = isEmailValid AndAlso isPasswordValid
        btnAdd.BackColor = If(btnAdd.Enabled, Color.FromArgb(106, 80, 109), Color.Gray)

        ' Update password suggestion visibility and content
        If isPasswordValid Then
            Dim password As String = textHelper.GetActualText(txtPassword)
            Dim suggestion As String = Review.GetFeedback(password, DateTime.Now.ToString("yyyy-MM-dd")).ToString
            txtSuggestion.Text = suggestion
            txtSuggestion.Visible = Not String.IsNullOrEmpty(suggestion)
        Else
            txtSuggestion.Visible = False
        End If
    End Sub


    ' User Passwords Controls
    Friend Sub SavePasswords(key As String)
        Dim userFile As String = Path.Combine(securityHelper.userFolder, securityHelper.GenerateEncryptedFileName($"{key}.csv"))
        Dim encryptedLines As New List(Of String)

        ' Initialize AutoCompleteStringCollection objects
        Dim accountAutoComplete As New AutoCompleteStringCollection()
        Dim usernameAutoComplete As New AutoCompleteStringCollection()
        Dim emailAutoComplete As New AutoCompleteStringCollection()

        For Each item As ListViewItem In lsvMain.Items
            If item.SubItems.Count < 4 Then Continue For ' Ensure there are enough subitems
            Dim account As String = textHelper.EscapeCSVField(item.Text)
            Dim username As String = textHelper.EscapeCSVField(item.SubItems(1).Text)
            Dim email As String = textHelper.EscapeCSVField(item.SubItems(2).Text)
            Dim password As String = textHelper.EscapeCSVField(item.SubItems(3).Tag.ToString()) ' Use original password from .Tag
            Dim dateAdded As String = item.Tag.ToString() ' Retrieve dateAdded from the Tag property
            Dim encryptedLine As String = securityHelper.Encrypt($"{account},{username},{email},{password},{dateAdded}", key) ' Include dateAdded in the encrypted line
            encryptedLines.Add(encryptedLine)

            ' Add to AutoCompleteStringCollection
            accountAutoComplete.Add(account)
            usernameAutoComplete.Add(username)
            emailAutoComplete.Add(email)
        Next

        ' Create directory if it doesn't exist
        If Not Directory.Exists(securityHelper.userFolder) Then
            Directory.CreateDirectory(securityHelper.userFolder)
        End If

        ' Write to file with UTF-8 encoding in a memory-efficient way
        Using writer As New StreamWriter(userFile, False, Encoding.UTF8)
            For Each line As String In encryptedLines
                writer.WriteLine(line)
            Next
        End Using

        ' Set AutoComplete properties for txtAccount, txtUsername, and txtEmail
        txtAccount.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtAccount.AutoCompleteCustomSource = accountAutoComplete

        txtUsername.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtUsername.AutoCompleteCustomSource = usernameAutoComplete

        txtEmail.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtEmail.AutoCompleteCustomSource = emailAutoComplete

        Review.ReviewPasswords(Body.currentHashCode)
    End Sub
    Friend Sub LoadPasswords(key As String, lsv As ListView)
        lsv.Items.Clear()
        originalItems.Clear() ' Clear originalItems

        ' Initialize AutoCompleteStringCollection objects
        Dim accountAutoComplete As New AutoCompleteStringCollection()
        Dim usernameAutoComplete As New AutoCompleteStringCollection()
        Dim emailAutoComplete As New AutoCompleteStringCollection()

        Dim userFile As String = Path.Combine(securityHelper.userFolder, securityHelper.GenerateEncryptedFileName($"{key}.csv"))
        If File.Exists(userFile) Then
            Using reader As New StreamReader(userFile, Encoding.UTF8)
                Dim line As String = reader.ReadLine()
                While line IsNot Nothing
                    Dim decryptedLine As String = securityHelper.Decrypt(line, key)
                    Dim parts As String() = textHelper.SplitCSVLine(decryptedLine)
                    If parts.Length = 5 Then
                        Dim listViewItem As New ListViewItem(parts(0)) ' Account
                        listViewItem.SubItems.Add(New ListViewItem.ListViewSubItem() With {.Text = parts(1)}) ' Username
                        listViewItem.SubItems.Add(New ListViewItem.ListViewSubItem() With {.Text = parts(2)}) ' Email
                        listViewItem.SubItems.Add(New ListViewItem.ListViewSubItem() With {.Text = If(passwordsVisible, parts(3), New String("*"c, parts(3).Length)), .Tag = parts(3)}) ' Password
                        listViewItem.Tag = parts(4)
                        lsv.Items.Add(listViewItem)
                        originalItems.Add(listViewItem.Clone())

                        ' Add to AutoCompleteStringCollection
                        accountAutoComplete.Add(parts(0))
                        usernameAutoComplete.Add(parts(1))
                        emailAutoComplete.Add(parts(2))
                    End If
                    line = reader.ReadLine()
                End While
            End Using
        End If

        ' Set AutoComplete properties for txtAccount, txtUsername, and txtEmail
        txtAccount.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtAccount.AutoCompleteCustomSource = accountAutoComplete

        txtUsername.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtUsername.AutoCompleteCustomSource = usernameAutoComplete

        txtEmail.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtEmail.AutoCompleteCustomSource = emailAutoComplete

        Review.ReviewPasswords(Body.currentHashCode)
    End Sub

    Friend Sub UpdatePasswords(oldRecoveryPassword As String, newRecoveryPassword As String)
        Dim oldUserFile As String = Path.Combine(securityHelper.userFolder, securityHelper.GenerateEncryptedFileName($"{oldRecoveryPassword}.csv"))
        Dim newUserFile As String = Path.Combine(securityHelper.userFolder, securityHelper.GenerateEncryptedFileName($"{newRecoveryPassword}.csv"))

        Dim decryptedLines As New List(Of String)

        ' Check if the old file exists and read its contents
        If File.Exists(oldUserFile) Then
            Try
                Using reader As New StreamReader(oldUserFile, Encoding.UTF8)
                    Dim line As String = reader.ReadLine()
                    While line IsNot Nothing
                        Try
                            decryptedLines.Add(securityHelper.Decrypt(line, oldRecoveryPassword))
                        Catch ex As Exception
                            MsgBox($"Decryption error: {ex.Message}")
                        End Try
                        line = reader.ReadLine()
                    End While
                End Using

                ' Delete the old file after reading
                Try
                    File.Delete(oldUserFile)
                Catch ex As Exception
                    ' MsgBox($"Failed to delete old file: {ex.Message}")
                End Try
            Catch ex As Exception
                ' MsgBox($"Error reading old file: {ex.Message}")
            End Try
        Else
            ' MsgBox("Old file does not exist.")
        End If

        ' Encrypt the decrypted lines with the new recovery password
        Dim newEncryptedLines As New List(Of String)
        For Each decryptedLine In decryptedLines
            Dim parts As String() = textHelper.SplitCSVLine(decryptedLine)
            If parts.Length = 5 Then
                Dim account As String = textHelper.EscapeCSVField(parts(0))
                Dim username As String = textHelper.EscapeCSVField(parts(1))
                Dim email As String = textHelper.EscapeCSVField(parts(2))
                Dim password As String = textHelper.EscapeCSVField(parts(3))
                Dim dateAdded As String = textHelper.EscapeCSVField(parts(4))
                newEncryptedLines.Add(securityHelper.Encrypt($"{account},{username},{email},{password},{dateAdded}", newRecoveryPassword))
            End If
        Next

        ' Save the new encrypted lines to the new file
        Try
            Using writer As New StreamWriter(newUserFile, False, Encoding.UTF8)
                For Each line As String In newEncryptedLines
                    writer.WriteLine(line)
                Next
            End Using
            ' MsgBox("New file saved successfully.")
        Catch ex As Exception
            ' MsgBox($"Failed to save new file: {ex.Message}")
        End Try
    End Sub

    Friend Function VerifyPassword(prompt As String, selector As Integer, image As Image) As Boolean
        ' Show the custom vault password input form
        Using verifyForm As New Message()
            verifyForm.Text = "Authentication Required: "
            verifyForm.ptcVerify.Image = image
            textHelper.ConfigureTextBox(verifyForm.txtVerify, prompt, True)
            verifyForm.flpField.Visible = False
            verifyForm.flpExtra.Visible = False

            If verifyForm.ShowDialog() = DialogResult.OK Then
                Dim verifyText As String = textHelper.GetActualText(verifyForm.txtVerify)
                If securityHelper.CheckCredentials(Body.currentUser, verifyText, selector) Then
                    Return True
                End If
            End If
        End Using

        Return False
    End Function
    Private Sub ChangePassword(prompt As String, selector As Integer, image As Image)
        Using changeForm As New Message()
            changeForm.Text = "Authentication Required: "
            changeForm.ptcField.Image = image
            changeForm.ptcVerify.Image = My.Resources.iconCode
            textHelper.ConfigureTextBox(changeForm.txtField, prompt, True)
            textHelper.ConfigureTextBox(changeForm.txtVerify, "Stelle Code", True)
            changeForm.flpExtra.Visible = False

            If changeForm.ShowDialog() = DialogResult.OK Then
                Dim newPassword As String = textHelper.GetActualText(changeForm.txtField)
                Dim verifyPassword As String = textHelper.GetActualText(changeForm.txtVerify)
                If securityHelper.CheckCredentials(Body.currentUser, verifyPassword, 5) Then
                    securityHelper.ChangeCredentials(Body.currentUser, newPassword, newPassword, selector, True)
                    If selector = 1 Then
                        securityHelper.ChangeCredentials(Body.currentUser, Body.currentHashCode, newPassword, 4, False)
                    End If

                    passwordsChanged = True

                    Body.tmrStelle.Stop()
                    Body.timerCount = 0
                    Body.ptcStelle.Image = My.Resources.Suggest
                    Body.txtGreeting.Text = $"Hey, {Body.displayUser}!"
                    Body.txtStatus.Text = "Did you just changed your password? Click for a new Stelle Code. The one you used is old and at risk."
                End If
            End If
        End Using
    End Sub

    ' Sorting Passwords
    Private currentSortColumn As SortColumns = SortColumns.Website
    Private currentSortOrder As SortOrder = SortOrder.Ascending
    Private Enum SortColumns
        Website
        Username
        Email
    End Enum
    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click
        ' Cycle through the columns
        currentSortColumn = CType((CInt(currentSortColumn) + 1) Mod [Enum].GetValues(GetType(SortColumns)).Length, SortColumns)
        btnSort.Text = "Sort by: " & currentSortColumn.ToString()
    End Sub
    Private Sub btnSortAscending_Click(sender As Object, e As EventArgs) Handles btnSortAscending.Click
        ' Set the sort order to ascending
        currentSortOrder = SortOrder.Ascending
        SortListView()
    End Sub
    Private Sub btnSortDescending_Click(sender As Object, e As EventArgs) Handles btnSortDescending.Click
        ' Set the sort order to descending
        currentSortOrder = SortOrder.Descending
        SortListView()
    End Sub
    Private Sub SortListView()
        Dim columnIndex As Integer
        Select Case currentSortColumn
            Case SortColumns.Website
                columnIndex = 0
            Case SortColumns.Username
                columnIndex = 1
            Case SortColumns.Email
                columnIndex = 2
        End Select

        lsvMain.ListViewItemSorter = New ListViewItemComparer(columnIndex, currentSortOrder)
        lsvMain.Sort()
    End Sub
    Private Class ListViewItemComparer
        Implements IComparer

        Private col As Integer
        Private order As SortOrder

        Public Sub New(column As Integer, sortOrder As SortOrder)
            col = column
            order = sortOrder
        End Sub
        Public Function Compare(x As Object, y As Object) As Integer Implements IComparer.Compare
            Dim result As Integer = String.Compare(CType(x, ListViewItem).SubItems(col).Text, CType(y, ListViewItem).SubItems(col).Text)
            If order = SortOrder.Descending Then
                result = -result
            End If
            Return result
        End Function
    End Class

    ' Searching Passwords
    Private originalItems As New List(Of ListViewItem)
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim searchQuery = txtSearch.Text

        ' Skip searching if the search query is empty
        If String.IsNullOrEmpty(searchQuery) Or searchQuery = "Search" Then
            lsvMain.Items.Clear()
            lsvMain.Items.AddRange(originalItems.ToArray())
            Return
        End If

        lsvMain.BeginUpdate()

        ' Filter the items based on the search query
        Dim itemsToShow = originalItems.Where(Function(item) item.Text.ToLower.Contains(searchQuery) OrElse
                                                     item.SubItems(1).Text.ToLower.Contains(searchQuery) OrElse
                                                     item.SubItems(2).Text.ToLower.Contains(searchQuery) OrElse
                                                     item.SubItems(3).Text.ToLower.Contains(searchQuery)).ToArray

        ' Clear the ListView and add the filtered items
        lsvMain.Items.Clear()
        lsvMain.Items.AddRange(itemsToShow)

        lsvMain.EndUpdate()
    End Sub
End Class