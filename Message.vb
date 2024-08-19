Public Class Message
    Private textHelper As New TextHelper()
    Private securityHelper As New SecurityHelper()

    Public Property Field As String
    Public Property Verify As String

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Field = txtField.Text
        Verify = txtVerify.Text
        Me.DialogResult = DialogResult.OK
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
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        DialogResult = DialogResult.Cancel
    End Sub
    Private Sub trkLength_ValueChanged(sender As Object, e As EventArgs) Handles trkLength.ValueChanged
        lblPasswordLength.Text = $"Password Length: {trkLength.Value}"
    End Sub
    Private Sub Message_Load(sender As Object, e As EventArgs) Handles Me.Load
        flpWhole.PerformLayout()
        flpWhole.Refresh()
        ClientSize = New Size(flpWhole.Width + 60, flpWhole.Height + 60)
    End Sub
End Class
