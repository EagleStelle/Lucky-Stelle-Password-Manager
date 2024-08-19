Imports System.ComponentModel.Design.ObjectSelectorEditor
Imports QRCoder

Public Class Register
    Private textHelper As New TextHelper()
    Private securityHelper As New SecurityHelperAdvanced()

    Friend inputEmail As String
    Friend inputPassword As String
    Friend inputVaultPassword As String

    Private buttonClicked As Boolean = False
    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ClientSize = New Size(flpWhole.Width + 60, flpWhole.Height + 60)
        Me.CenterToScreen()
        lklLogin.TabStop = False

        textHelper.ConfigureTextBox(txtName, "Email", False)
        textHelper.ConfigureTextBox(txtPassword, "Account Password", True)
        textHelper.ConfigureTextBox(txtVaultPassword, "Vault Password", True)
    End Sub
    Private Sub Register_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        LaunchPad.Close()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        inputEmail = textHelper.GetActualText(txtName)
        inputPassword = textHelper.GetActualText(txtPassword)
        inputVaultPassword = textHelper.GetActualText(txtVaultPassword)

        If securityHelper.ValidateEmail(txtName).Item1 Then
            MessageBox.Show(securityHelper.ValidateEmail(txtName).Item2, "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If txtPassword.Text = String.Empty OrElse txtPassword.Text = "Account Password" Then
            MessageBox.Show("Account Password is required." & vbCrLf & " Please enter your account password.", "Missing Account Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        ElseIf txtVaultPassword.Text = String.Empty OrElse txtVaultPassword.Text = "Vault Password" Then
            MessageBox.Show("Vault Password is required." & vbCrLf & " Please enter your vault password.", "Missing Vault Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Using stelleForm As New QRCode()
            stelleForm.Text = "Stelle Code: "

            If stelleForm.ShowDialog() = DialogResult.OK Then
                securityHelper.CreateCredentials(inputEmail, inputPassword, inputVaultPassword, 0, stelleForm.txtStelleCode.Text)
                Login.Show()
                Hide()
            End If
        End Using

        textHelper.StandardTextBox(txtName, "Email")
        textHelper.StandardTextBox(txtPassword, "Account Password")
        textHelper.StandardTextBox(txtVaultPassword, "Vault Password")

        inputEmail = textHelper.GetActualText(txtName)
        inputPassword = textHelper.GetActualText(txtPassword)
        inputVaultPassword = textHelper.GetActualText(txtVaultPassword)
    End Sub
    Private Sub Login_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklLogin.LinkClicked
        My.Computer.Audio.Play(My.Resources.switch, AudioPlayMode.Background)

        Login.Show()

        inputEmail = textHelper.GetActualText(txtName)
        inputPassword = textHelper.GetActualText(txtPassword)

        textHelper.ForwardTextBox(Me, "txtName", "Email", inputEmail, Login, False)
        textHelper.ForwardTextBox(Me, "txtPassword", "Account Password", inputPassword, Login, True)
        textHelper.StandardTextBox(txtVaultPassword, "Vault Password")
        Me.Hide()
    End Sub

End Class
