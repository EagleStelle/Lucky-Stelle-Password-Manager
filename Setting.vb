Imports System.ComponentModel.Design.ObjectSelectorEditor
Imports System.IO
Imports System.Text

Public Class Setting
    Private passwordHelper As New TextHelper()
    Private securityHelper As New SecurityHelperAdvanced()
    Private random As New Random()

    Friend passwordsChanged As Boolean = False

    ' Central Form Properties
    Private Sub Central_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ClientSize = New Size(flpSetting.Width + 60, flpSetting.Height + 60)
        Me.CenterToScreen()
    End Sub
    Private Sub Central_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        LaunchPad.Close()
    End Sub

    Private Sub btnChangeName_Click(sender As Object, e As EventArgs) Handles btnChangeName.Click
        ChangePassword("New Username", 9, My.Resources.iconEmail)

    End Sub
    Private Sub btnChangeAccountPassword_Click(sender As Object, e As EventArgs) Handles btnChangeAccountPassword.Click
        ChangePassword("New Account Password", 1, My.Resources.iconPassword)

        passwordsChanged = True
        tmrStelle.Stop()
        Body.timerCount = 0
        Body.ptcStelle.Image = My.Resources.Suggest
        Body.txtGreeting.Text = $"Hey, {Body.displayUser}!"
        Body.txtStatus.Text = "Did you just change your password? Click for a new Stelle Code. The one you used is old and at risk."
    End Sub
    Private Sub btnChangeVaultPassword_Click(sender As Object, e As EventArgs) Handles btnChangeVaultPassword.Click
        ChangePassword("New Vault Password", 2, My.Resources.iconVault)

        passwordsChanged = True
        tmrStelle.Stop()
        Body.timerCount = 0
        Body.ptcStelle.Image = My.Resources.Suggest
        Body.txtGreeting.Text = $"Hey, {Body.displayUser}!"
        Body.txtStatus.Text = "Did you just change your password? Click for a new Stelle Code. The one you used is old and at risk."
    End Sub
    Private Sub btnDeleteAccount_Click(sender As Object, e As EventArgs) Handles btnDeleteAccount.Click
        If Body.TriplePassword() Then
            securityHelper.DeleteCredentials(Body.currentUser)
            Body.Dispose()
            LaunchPad.Show()
        End If
    End Sub

    Private Sub ChangePassword(prompt As String, selector As Integer, image As Image)
        Using changeForm As New Message()
            changeForm.Text = "Authentication Required: "
            changeForm.ptcField.Image = If(selector <> 9, My.Resources.iconCode, My.Resources.iconEmail)
            changeForm.ptcVerify.Image = My.Resources.iconCode
            changeForm.flpExtra.Visible = False

            passwordHelper.ConfigureTextBox(changeForm.txtVerify, If(selector <> 9, "Stelle Code", "Account Password"), True)
            passwordHelper.ConfigureTextBox(changeForm.txtField, prompt, If(selector <> 9, True, False))


            If changeForm.ShowDialog() = DialogResult.OK Then
                Dim newPassword As String = passwordHelper.GetActualText(changeForm.txtField)
                Dim verifyPassword As String = passwordHelper.GetActualText(changeForm.txtVerify)
                Dim passwordCorrect As Boolean = securityHelper.CheckCredentials(Body.currentUser, verifyPassword, If(selector <> 9, 5, 1))

                If passwordCorrect Then
                    securityHelper.ChangeCredentials(Body.currentUser, newPassword, If(selector <> 9, newPassword, verifyPassword), selector, True)

                    If selector = 1 Then
                        securityHelper.ChangeCredentials(Body.currentUser, Body.currentHashCode, newPassword, 4, False)
                        securityHelper.ChangeCredentials(Body.currentUser, Body.displayUser, newPassword, 9, False)

                    ElseIf selector = 9 Then
                        Body.displayUser = newPassword
                    End If
                End If
            End If
        End Using
    End Sub
End Class
