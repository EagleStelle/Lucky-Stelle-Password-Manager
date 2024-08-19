Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Media

Public Class CustomButton
    Inherits Button

    Private _hoverBackColor As Color = Color.FromArgb(28, 151, 234)
    Private _hoverForeColor As Color = Color.Yellow
    Private _borderRadius As Integer = 20
    Private _originalBackColor As Color
    Private _originalForeColor As Color
    Private _soundClick As String
    Private _soundHover As String

    ' Added fields for font handling
    Private _hoverFont As Font
    Private _originalFont As Font

    ' Field for sound handling
    Private _soundPlayer As SoundPlayer
    Private _soundStream As Stream

    Public Sub New()
        Me.FlatStyle = FlatStyle.Flat
        Me.FlatAppearance.BorderSize = 0
        Me._originalBackColor = Me.BackColor
        Me._originalForeColor = Me.ForeColor
        Me.DoubleBuffered = True ' Enable double buffering to reduce flickering

        ' Initialize the fonts
        Me._originalFont = Me.Font
        Me._hoverFont = New Font(Me.Font, FontStyle.Bold)
    End Sub

    Public Property HoverBackColor() As Color
        Get
            Return _hoverBackColor
        End Get
        Set(ByVal value As Color)
            _hoverBackColor = value
        End Set
    End Property

    Public Property HoverForeColor() As Color
        Get
            Return _hoverForeColor
        End Get
        Set(ByVal value As Color)
            _hoverForeColor = value
        End Set
    End Property

    Public Property BorderRadius() As Integer
        Get
            Return _borderRadius
        End Get
        Set(ByVal value As Integer)
            _borderRadius = value
            Me.Invalidate()
        End Set
    End Property

    Protected Overrides Sub OnPaint(ByVal pevent As PaintEventArgs)
        MyBase.OnPaint(pevent)
        Dim graphics As Graphics = pevent.Graphics
        graphics.SmoothingMode = SmoothingMode.AntiAlias

        Dim rect As New Rectangle(0, 0, Me.Width, Me.Height)
        Dim path As GraphicsPath = GetRoundRectanglePath(rect, _borderRadius)

        Me.Region = New Region(path)

        Using brush As New SolidBrush(Me.BackColor)
            graphics.FillPath(brush, path)
        End Using

        TextRenderer.DrawText(graphics, Me.Text, Me.Font, rect, Me.ForeColor, TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)
    End Sub

    Protected Overrides Sub OnMouseEnter(ByVal e As EventArgs)
        PlaySound(_soundHover)
        MyBase.OnMouseEnter(e)
        _originalBackColor = Me.BackColor
        _originalForeColor = Me.ForeColor
        _originalFont = Me.Font ' Ensure the original font is saved
        Me.BackColor = _hoverBackColor
        Me.ForeColor = _hoverForeColor
        Me.Font = New Font(_originalFont, FontStyle.Bold) ' Make the font bold
    End Sub

    Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
        MyBase.OnMouseLeave(e)
        Me.BackColor = _originalBackColor
        Me.ForeColor = _originalForeColor
        Me.Font = _originalFont ' Restore the original font
    End Sub


    Protected Overrides Sub OnClick(ByVal e As EventArgs)
        PlaySound(_soundClick)
        MyBase.OnClick(e)
    End Sub

    Private Function GetRoundRectanglePath(ByVal rect As Rectangle, ByVal radius As Integer) As GraphicsPath
        Dim path As New GraphicsPath()
        path.AddArc(rect.Left, rect.Top, radius, radius, 180, 90)
        path.AddArc(rect.Right - radius, rect.Top, radius, radius, 270, 90)
        path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90)
        path.AddArc(rect.Left, rect.Bottom - radius, radius, radius, 90, 90)
        path.CloseFigure()
        Return path
    End Function

    Public Property SoundClick As String
        Get
            Return _soundClick
        End Get
        Set(value As String)
            _soundClick = value
        End Set
    End Property

    Public Property SoundHover As String
        Get
            Return _soundHover
        End Get
        Set(value As String)
            _soundHover = value
        End Set
    End Property

    ' Method to play the sound
    Private Sub PlaySound(sound As String)
        If Not String.IsNullOrEmpty(sound) Then
            Try
                Dim soundResource = My.Resources.ResourceManager.GetObject(sound)
                If TypeOf soundResource Is UnmanagedMemoryStream Then
                    _soundStream = DirectCast(soundResource, UnmanagedMemoryStream)
                ElseIf TypeOf soundResource Is MemoryStream Then
                    _soundStream = DirectCast(soundResource, MemoryStream)
                Else
                    MessageBox.Show("Sound resource not found or of unsupported type.")
                    Return
                End If

                If _soundPlayer Is Nothing Then
                    _soundPlayer = New SoundPlayer(_soundStream)
                Else
                    _soundPlayer.Stream = _soundStream
                End If

                _soundPlayer.Play()
            Catch ex As Exception
                MessageBox.Show("Error playing sound: " & ex.Message)
            End Try
        End If
    End Sub

    ' Proper disposal of resources
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If _soundPlayer IsNot Nothing Then
                _soundPlayer.Stop()
                _soundPlayer.Dispose()
                _soundPlayer = Nothing
            End If
            If _hoverFont IsNot Nothing Then _hoverFont.Dispose()
            If _originalFont IsNot Nothing Then _originalFont.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub
End Class
