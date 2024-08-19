Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Public Class ToggleButton
    Inherits CheckBox

    Private _checkedColor As Color = Color.Green
    Private _uncheckedColor As Color = Color.Red

    Public Sub New()
        ' Set default properties
        Me.Appearance = Appearance.Button
        Me.AutoSize = False
        Me.Size = New Size(100, 50) ' Adjust default size
        Me.FlatStyle = FlatStyle.Flat
        Me.TextAlign = ContentAlignment.MiddleCenter
        Me.MinimumSize = New Size(25, 13) ' Set minimum size to prevent too small sizes
    End Sub

    ' Property for CheckedColor
    <Category("Appearance"), Description("Color when the button is checked")>
    Public Property CheckedColor As Color
        Get
            Return _checkedColor
        End Get
        Set(value As Color)
            _checkedColor = value
            Me.Invalidate() ' Force the control to redraw itself
        End Set
    End Property

    ' Property for UncheckedColor
    <Category("Appearance"), Description("Color when the button is unchecked")>
    Public Property UncheckedColor As Color
        Get
            Return _uncheckedColor
        End Get
        Set(value As Color)
            _uncheckedColor = value
            Me.Invalidate() ' Force the control to redraw itself
        End Set
    End Property

    Protected Overrides Sub OnPaint(pevent As PaintEventArgs)
        MyBase.OnPaint(pevent)
        Dim g As Graphics = pevent.Graphics

        ' Clear background
        g.Clear(Me.BackColor)

        ' Draw the toggle button background
        If Me.Checked Then
            g.FillRectangle(New SolidBrush(_checkedColor), 0, 0, Me.Width, Me.Height)
        Else
            g.FillRectangle(New SolidBrush(_uncheckedColor), 0, 0, Me.Width, Me.Height)
        End If

        ' Draw the toggle switch
        Dim switchWidth As Integer = Me.Width / 2
        Dim switchHeight As Integer = Me.Height - 4
        Dim switchRectangle As Rectangle

        If Me.Checked Then
            switchRectangle = New Rectangle(Me.Width - switchWidth - 2, 2, switchWidth, switchHeight)
        Else
            switchRectangle = New Rectangle(2, 2, switchWidth, switchHeight)
        End If

        g.FillRectangle(Brushes.White, switchRectangle)
        g.DrawRectangle(Pens.Black, switchRectangle)
    End Sub

    Protected Overrides Sub OnCheckedChanged(e As EventArgs)
        MyBase.OnCheckedChanged(e)
        Me.Invalidate() ' Force the control to redraw itself
    End Sub

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        Me.Invalidate() ' Force the control to redraw itself when resized
    End Sub
End Class
