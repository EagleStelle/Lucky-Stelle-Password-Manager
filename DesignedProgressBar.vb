Imports System.Windows.Forms
Imports System.Drawing

Public Class CustomProgressBar
    Inherits ProgressBar

    Public Sub New()
        ' Enable double buffering to reduce flickering
        Me.SetStyle(ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
        Me.ForeColor = Color.White
        Me.BackColor = Color.Black
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        ' Clear the background
        e.Graphics.Clear(Me.BackColor)

        ' Calculate the width of the progress fill
        Dim progressWidth As Integer = CInt(Me.Width * (Me.Value / Me.Maximum))

        ' Draw the progress fill using ForeColor
        Using progressBrush As New SolidBrush(Me.ForeColor)
            e.Graphics.FillRectangle(progressBrush, 0, 0, progressWidth, Me.Height)
        End Using
    End Sub
End Class
