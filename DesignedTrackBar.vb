Imports System.Windows.Forms
Imports System.Drawing

Public Class CustomTrackBar
    Inherits TrackBar

    Public Property TrackLineColor As Color = Color.Gray
    Public Property TickColor As Color = Color.Red
    Public Property ThumbColor As Color = Color.Blue

    Public Sub New()
        MyBase.New()
        Me.SetStyle(ControlStyles.UserPaint, True)
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
    End Sub

    Protected Overrides Sub OnPaintBackground(pevent As PaintEventArgs)
        ' Do not call the base class OnPaintBackground to prevent default background painting
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        ' Clear the control
        e.Graphics.Clear(Me.BackColor)

        ' Draw the track line
        Dim trackLineRect As New Rectangle(0, CInt(Me.Height / 2 - 2), Me.Width, 4)
        Using trackLineBrush As New SolidBrush(TrackLineColor)
            e.Graphics.FillRectangle(trackLineBrush, trackLineRect)
        End Using

        ' Draw the ticks
        Using tickPen As New Pen(TickColor, 2)
            Dim numberOfTicks As Integer = (Me.Maximum - Me.Minimum) / Me.TickFrequency
            For i As Integer = 0 To numberOfTicks
                Dim x As Integer = CInt(i * (Me.Width - 1) / numberOfTicks)
                e.Graphics.DrawLine(tickPen, x, CInt(Me.Height / 2 - 5), x, CInt(Me.Height / 2 + 5))
            Next
        End Using

        ' Draw the thumb
        Dim thumbX As Integer = CInt((Me.Value - Me.Minimum) * (Me.Width - 1) / (Me.Maximum - Me.Minimum))
        ' Adjust the position to ensure accurate rendering
        If thumbX < 0 Then thumbX = 0
        If thumbX > Me.Width - 1 Then thumbX = Me.Width - 1
        Dim thumbRect As New Rectangle(thumbX - 5, CInt(Me.Height / 2 - 10), 10, 20)
        Using thumbBrush As New SolidBrush(ThumbColor)
            e.Graphics.FillRectangle(thumbBrush, thumbRect)
        End Using
    End Sub

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        If e.Button = MouseButtons.Left Then
            UpdateValueFromMouse(e.X)
        End If
    End Sub

    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
        MyBase.OnMouseMove(e)
        If e.Button = MouseButtons.Left Then
            UpdateValueFromMouse(e.X)
        End If
    End Sub

    Protected Overrides Sub OnKeyDown(e As KeyEventArgs)
        MyBase.OnKeyDown(e)
        Select Case e.KeyCode
            Case Keys.Left, Keys.Down
                If Me.Value > Me.Minimum Then
                    Me.Value -= Me.SmallChange
                End If
            Case Keys.Right, Keys.Up
                If Me.Value < Me.Maximum Then
                    Me.Value += Me.SmallChange
                End If
        End Select
        Me.Invalidate()
    End Sub

    Protected Overrides Sub OnValueChanged(e As EventArgs)
        MyBase.OnValueChanged(e)
        Me.Invalidate()
    End Sub

    Private Sub UpdateValueFromMouse(mouseX As Integer)
        Dim newValue As Integer = CInt((mouseX / CSng(Me.Width)) * (Me.Maximum - Me.Minimum)) + Me.Minimum
        If newValue <> Me.Value Then
            Me.Value = Math.Max(Me.Minimum, Math.Min(Me.Maximum, newValue))
            Me.Invalidate()
        End If
    End Sub
End Class
