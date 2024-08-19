<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LaunchPad
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        flpWhole = New FlowLayoutPanel()
        flpLogo = New FlowLayoutPanel()
        ptcLogo = New PictureBox()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        lblTitle = New Label()
        FlowLayoutPanel2 = New FlowLayoutPanel()
        lblTag = New Label()
        Panel1 = New Panel()
        btnLogin = New CustomButton()
        btnRegister = New CustomButton()
        flpWhole.SuspendLayout()
        flpLogo.SuspendLayout()
        CType(ptcLogo, ComponentModel.ISupportInitialize).BeginInit()
        FlowLayoutPanel1.SuspendLayout()
        FlowLayoutPanel2.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' flpWhole
        ' 
        flpWhole.AutoSize = True
        flpWhole.AutoSizeMode = AutoSizeMode.GrowAndShrink
        flpWhole.BackColor = Color.Transparent
        flpWhole.Controls.Add(flpLogo)
        flpWhole.Controls.Add(FlowLayoutPanel1)
        flpWhole.Controls.Add(FlowLayoutPanel2)
        flpWhole.Controls.Add(Panel1)
        flpWhole.Controls.Add(btnRegister)
        flpWhole.FlowDirection = FlowDirection.TopDown
        flpWhole.Location = New Point(26, 24)
        flpWhole.Margin = New Padding(3, 2, 3, 2)
        flpWhole.Name = "flpWhole"
        flpWhole.Size = New Size(246, 260)
        flpWhole.TabIndex = 0
        ' 
        ' flpLogo
        ' 
        flpLogo.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        flpLogo.AutoSize = True
        flpLogo.Controls.Add(ptcLogo)
        flpLogo.Location = New Point(65, 3)
        flpLogo.Name = "flpLogo"
        flpLogo.Size = New Size(115, 105)
        flpLogo.TabIndex = 106
        ' 
        ' ptcLogo
        ' 
        ptcLogo.Image = My.Resources.Resources.Logo
        ptcLogo.Location = New Point(3, 3)
        ptcLogo.Name = "ptcLogo"
        ptcLogo.Size = New Size(109, 99)
        ptcLogo.SizeMode = PictureBoxSizeMode.StretchImage
        ptcLogo.TabIndex = 111
        ptcLogo.TabStop = False
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        FlowLayoutPanel1.AutoSize = True
        FlowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        FlowLayoutPanel1.Controls.Add(lblTitle)
        FlowLayoutPanel1.Location = New Point(3, 113)
        FlowLayoutPanel1.Margin = New Padding(3, 2, 3, 2)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(240, 38)
        FlowLayoutPanel1.TabIndex = 116
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.BackColor = Color.Transparent
        lblTitle.Font = New Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(3, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(234, 38)
        lblTitle.TabIndex = 115
        lblTitle.Text = "Lucky Stelle"
        lblTitle.TextAlign = ContentAlignment.TopCenter
        ' 
        ' FlowLayoutPanel2
        ' 
        FlowLayoutPanel2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        FlowLayoutPanel2.AutoSize = True
        FlowLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink
        FlowLayoutPanel2.Controls.Add(lblTag)
        FlowLayoutPanel2.Location = New Point(4, 155)
        FlowLayoutPanel2.Margin = New Padding(3, 2, 3, 2)
        FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        FlowLayoutPanel2.Size = New Size(237, 20)
        FlowLayoutPanel2.TabIndex = 1
        ' 
        ' lblTag
        ' 
        lblTag.AutoSize = True
        lblTag.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        lblTag.ForeColor = Color.AliceBlue
        lblTag.Location = New Point(3, 0)
        lblTag.Name = "lblTag"
        lblTag.Size = New Size(231, 20)
        lblTag.TabIndex = 1
        lblTag.Text = "Secure Your Luck with Every Login"
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Panel1.Controls.Add(btnLogin)
        Panel1.Location = New Point(3, 179)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(240, 51)
        Panel1.TabIndex = 1
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.Beige
        btnLogin.BorderRadius = 20
        btnLogin.Dock = DockStyle.Bottom
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnLogin.HoverBackColor = Color.White
        btnLogin.HoverForeColor = Color.Navy
        btnLogin.Location = New Point(0, 27)
        btnLogin.Margin = New Padding(3, 2, 3, 2)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(240, 24)
        btnLogin.SoundClick = "click"
        btnLogin.SoundHover = "hover"
        btnLogin.TabIndex = 1
        btnLogin.Text = "&Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' btnRegister
        ' 
        btnRegister.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        btnRegister.BackColor = Color.Moccasin
        btnRegister.BorderRadius = 20
        btnRegister.FlatAppearance.BorderSize = 0
        btnRegister.FlatStyle = FlatStyle.Flat
        btnRegister.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnRegister.HoverBackColor = Color.White
        btnRegister.HoverForeColor = Color.Navy
        btnRegister.Location = New Point(3, 234)
        btnRegister.Margin = New Padding(3, 2, 3, 2)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(240, 24)
        btnRegister.SoundClick = "click"
        btnRegister.SoundHover = "hover"
        btnRegister.TabIndex = 2
        btnRegister.Text = "&Register"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' LaunchPad
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        BackgroundImage = My.Resources.Resources.backgroundLaunchPad
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(270, 314)
        Controls.Add(flpWhole)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = My.Resources.Resources.Lucky_Stelle
        Margin = New Padding(3, 2, 3, 2)
        MaximizeBox = False
        MinimizeBox = False
        Name = "LaunchPad"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Lucky Stelle"
        flpWhole.ResumeLayout(False)
        flpWhole.PerformLayout()
        flpLogo.ResumeLayout(False)
        CType(ptcLogo, ComponentModel.ISupportInitialize).EndInit()
        FlowLayoutPanel1.ResumeLayout(False)
        FlowLayoutPanel1.PerformLayout()
        FlowLayoutPanel2.ResumeLayout(False)
        FlowLayoutPanel2.PerformLayout()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents flpWhole As FlowLayoutPanel
    Friend WithEvents flpLogo As FlowLayoutPanel
    Friend WithEvents ptcLogo As PictureBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents lblTitle As Label
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents lblTag As Label
    Friend WithEvents btnLogin As CustomButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnRegister As CustomButton
End Class
