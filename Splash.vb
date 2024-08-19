Public Class Splash
    ' Add class-level variables
    Private progress As Integer = 0

    Private Async Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ClientSize = New Size(flpWhole.Width + 60, flpWhole.Height + 60)

        ' Initialize ProgressBar
        prgLoading.Minimum = 0
        prgLoading.Maximum = 100
        prgLoading.Value = 0

        Await Task.Delay(1000)
        tmrLoading.Start()
    End Sub

    Private Sub tmrLoading_Tick(sender As Object, e As EventArgs) Handles tmrLoading.Tick
        ' Increment ProgressBar value
        progress += 1
        prgLoading.Value = progress
        lblProgress.Text = progress.ToString() & "%"

        ' Stop Timer when ProgressBar is full
        If progress >= 100 Then
            tmrLoading.Stop()
            Cleanup()
        End If
    End Sub

    Private Sub Cleanup()
        ' Dispose of the Timer
        tmrLoading.Dispose()

        ' Remove controls from the form
        Me.Controls.Remove(flpWhole)
        Me.Controls.Remove(flpLogo)
        Me.Controls.Remove(flpProgress)
        Me.Controls.Remove(flpLoading)
        Me.Controls.Remove(flpCopyright)
        Me.Controls.Remove(lblCopyright)
        Me.Controls.Remove(lblProgress)
        Me.Controls.Remove(prgLoading)
        Me.Controls.Remove(ptcLogo)

        LaunchPad.Show()
        Hide()
    End Sub
End Class