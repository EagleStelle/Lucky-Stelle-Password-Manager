Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Login
    Private textHelper As New TextHelper()
    Private securityHelper As New SecurityHelperAdvanced()
    Private listViewHelper As New ListViewHelper()

    Private passwordAttempts As Integer
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ClientSize = New Size(flpWhole.Width + 60, flpWhole.Height + 60)
        lklRecovery.TabStop = False
        lklRegister.TabStop = False

        textHelper.ConfigureTextBox(txtName, "Email", False)
        textHelper.ConfigureTextBox(txtPassword, "Account Password", True)
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim inputEmail As String = textHelper.GetActualText(txtName)
        Dim inputPassword As String = textHelper.GetActualText(txtPassword)

        If securityHelper.CheckCredentials(inputEmail, inputEmail, 0) Then
            Dim lockoutTime As DateTime = DateTime.Parse(securityHelper.ReadCredentials(inputEmail, inputEmail, 10))

            ' Check if the account is locked and if the lockout period has expired
            If lockoutTime > DateTime.Now Then
                MessageBox.Show($"Your account is locked until {lockoutTime}. " & vbCrLf & "Please try again later.", "Account Locked", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim random As New Random()
            Dim initialAttempts As Integer = random.Next(3, 6)
            Dim lockedAttempts As Integer = random.Next(1, 4)

            If passwordAttempts <= initialAttempts + lockedAttempts Then
                HandleLogin(inputEmail, inputPassword, initialAttempts)
            Else
                MsgBox("Maximum number of attempts reached for this account. " & vbCrLf & "Please try again later.", vbExclamation + vbOKOnly, "Account Locked")
            End If
        ElseIf Not String.IsNullOrEmpty(inputEmail) Then
            MessageBox.Show("Sorry, we couldn't find your accounts." & vbCrLf & "Please sign up to create a new account.", "Account Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub HandleLogin(inputEmail As String, inputPassword As String, maxAttempts As Integer)
        If securityHelper.CheckCredentials(inputEmail, inputPassword, 1) Then
            Dim totalAttempts As Integer = CInt(securityHelper.ReadCredentials(inputEmail, inputEmail, 7)) + CInt(securityHelper.ReadCredentials(inputEmail, inputEmail, 8))

            securityHelper.ChangeCredentials(inputEmail, passwordAttempts, inputEmail, 7, False)
            securityHelper.ChangeCredentials(inputEmail, DateTime.MinValue.ToString(), inputEmail, 10, False)

            passwordAttempts = 0

            Body.Show()
            Body.SetCurrentUser(inputEmail, inputPassword, maxAttempts)
            Body.tmrStelle.Start()
            Body.ptcStelle.Image = My.Resources.Hello
            Body.txtGreeting.Text = $"Welcome, {Body.displayUser}!"
            Body.txtStatus.Text = "I'm Stelle! Ready to serve you today." & vbCrLf & "How are you today? Let's ensure your accounts are secure."

            textHelper.StandardTextBox(txtName, "Email")
            textHelper.StandardTextBox(txtPassword, "Account Password")

            lblRemaining.Visible = False
            Me.Hide()
        Else
            passwordAttempts += 1
            If passwordAttempts <= maxAttempts Then
                lblRemaining.Text = $"Remaining Attempts: {maxAttempts - passwordAttempts}"
            End If
            lblRemaining.Visible = True

            Dim lastTotalAttempts As Integer = securityHelper.ReadCredentials(inputEmail, inputEmail, 11)

            Dim lastLogin As String = securityHelper.ReadCredentials(inputEmail, inputEmail, 6)
            Dim currentTime As DateTime = DateTime.Now
            Dim timeSinceLastLogin As TimeSpan = currentTime - If(String.IsNullOrEmpty(lastLogin), currentTime, DateTime.ParseExact(lastLogin, "yyyy-MMM-dd HH:mm:ss", Nothing))

            If timeSinceLastLogin.TotalDays > 2 And passwordAttempts <> 0 Then
                lastTotalAttempts = passwordAttempts
            Else
                lastTotalAttempts += 1
            End If
            securityHelper.ChangeCredentials(inputEmail, lastTotalAttempts, inputEmail, 11, False)
        End If
    End Sub

    Private Sub Register_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklRegister.LinkClicked
        My.Computer.Audio.Play(My.Resources.switch, AudioPlayMode.Background)

        Register.Show()

        Dim inputEmail = textHelper.GetActualText(txtName)
        Dim inputPassword = textHelper.GetActualText(txtPassword)

        textHelper.ForwardTextBox(Me, "txtName", "Email", inputEmail, Register, False)
        textHelper.ForwardTextBox(Me, "txtPassword", "Account Password", inputPassword, Register, True)

        lblRemaining.Visible = False
        Me.Hide()
    End Sub
    Private Sub Recovery_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklRecovery.LinkClicked
        My.Computer.Audio.Play(My.Resources.switch, AudioPlayMode.Background)

        Recovery.Show()

        Dim inputEmail = textHelper.GetActualText(txtName)
        Dim inputPassword = textHelper.GetActualText(txtPassword)

        textHelper.ForwardTextBox(Me, "txtName", "Email", inputEmail, Recovery, False)
        textHelper.ForwardTextBox(Me, "txtPassword", "Account Password", inputPassword, Recovery, True)

        lblRemaining.Visible = False
        Me.Hide()
    End Sub

    Private Sub Login_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        LaunchPad.Close()
    End Sub
End Class
