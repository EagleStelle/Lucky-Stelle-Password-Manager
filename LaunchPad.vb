Public Class LaunchPad
    Private Sub LaunchPad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ClientSize = New Size(flpWhole.Width + 60, flpWhole.Height + 60)
    End Sub
    Private Sub LaunchPad_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Splash.Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Me.Hide()
        Register.Show()
    End Sub
End Class
