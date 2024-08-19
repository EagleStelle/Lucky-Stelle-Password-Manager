Public Class Home
    Private securityHelper As New SecurityHelperAdvanced()

    Private recentLogin As String

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the anchor of all controls to None
        For Each ctrl As Control In Me.Controls
            ctrl.Anchor = AnchorStyles.None
        Next
        ClientSize = New Size(flpHome.Width + 2000, flpHome.Height)
    End Sub

    Friend Sub LoadLastLoginTime(username As String)
        Dim lastLogin As String = securityHelper.ReadCredentials(username, username, 6)
        If String.IsNullOrEmpty(lastLogin) Then
            lblRecent.Text = "Last Login: Never"
        Else
            Dim lastLoginDate As DateTime = DateTime.ParseExact(lastLogin, "yyyy-MMM-dd HH:mm:ss", Nothing)
            Dim formattedLastLogin As String = lastLoginDate.ToString("MMMM d, yyyy 'at' h:mmtt")
            lblRecent.Text = "Last Login: " & formattedLastLogin
        End If

        Dim lastAttempts As Integer = securityHelper.ReadCredentials(username, username, 11)
        If lastAttempts > 0 Then
            lblAttempts.Visible = True
            lblAttempts.Text = $"{lastAttempts} recent failed login attempts."
        Else
            lblAttempts.Visible = False
        End If

        Dim currentTime As DateTime = DateTime.Now
        Dim timeSinceLastLogin As TimeSpan = currentTime - If(String.IsNullOrEmpty(lastLogin), currentTime, DateTime.ParseExact(lastLogin, "yyyy-MMM-dd HH:mm:ss", Nothing))

        securityHelper.ChangeCredentials(username, currentTime.ToString("yyyy-MMM-dd HH:mm:ss"), username, 6, False)
        ClientSize = New Size(flpHome.Width, flpHome.Height)
    End Sub
End Class