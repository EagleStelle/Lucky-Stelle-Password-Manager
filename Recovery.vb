Public Class Recovery
    Private passwordHelper As New TextHelper()
    Private securityHelper As New SecurityHelperAdvanced()

    Private inputEmail As String
    Private inputPassword As String
    Private Sub Recovery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ClientSize = New Size(flpWhole.Width + 60, flpWhole.Height + 60)
        lklLogin.TabStop = False

        passwordHelper.ConfigureTextBox(txtName, "Email", False)
        passwordHelper.ConfigureTextBox(txtPassword, "New Account Password", True)
        passwordHelper.ConfigureTextBox(txtRecoveryPassword, "Stelle Code", True)
    End Sub
    Private Sub lklLogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklLogin.LinkClicked
        My.Computer.Audio.Play(My.Resources.switch, AudioPlayMode.Background)

        Login.Show()

        inputEmail = passwordHelper.GetActualText(txtName)
        inputPassword = passwordHelper.GetActualText(txtPassword)

        passwordHelper.ForwardTextBox(Me, "txtName", "Email", inputEmail, Login, False)
        passwordHelper.ForwardTextBox(Me, "txtPassword", "New Account Password", inputPassword, Login, True)
        passwordHelper.StandardTextBox(txtRecoveryPassword, "Stelle Code")

        Me.Hide()
    End Sub
    Private Sub Recovery_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        LaunchPad.Close()
    End Sub
    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        inputEmail = passwordHelper.GetActualText(txtName)
        inputPassword = passwordHelper.GetActualText(txtPassword)
        Dim inputStelleCode = passwordHelper.GetActualText(txtRecoveryPassword)

        If securityHelper.CheckCredentials(inputEmail, inputStelleCode, 5) Then
            securityHelper.ChangeCredentials(inputEmail, inputPassword, inputPassword, 1, True)
            securityHelper.ChangeCredentials(inputEmail, 0, inputPassword, 4, False)
            securityHelper.ChangeCredentials(inputEmail, inputEmail, inputPassword, 9, False)

            passwordHelper.StandardTextBox(txtName, "Email")
            passwordHelper.StandardTextBox(txtPassword, "Account Password")
            passwordHelper.StandardTextBox(txtRecoveryPassword, "Stelle Code")

            Login.Show()
            Hide()
        End If
    End Sub
End Class