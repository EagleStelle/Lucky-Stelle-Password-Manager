<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtName = New TextBox()
        txtPassword = New TextBox()
        lklRecovery = New LinkLabel()
        lklRegister = New LinkLabel()
        flpTrademark = New FlowLayoutPanel()
        flpAccount = New FlowLayoutPanel()
        ptcIconAccount = New PictureBox()
        flpInputAccount = New FlowLayoutPanel()
        flpPassword = New FlowLayoutPanel()
        ptcIconPassword = New PictureBox()
        flpInputPassword = New FlowLayoutPanel()
        flpLogo = New FlowLayoutPanel()
        ptcLogo = New PictureBox()
        pnlForgot = New Panel()
        flpWhole = New FlowLayoutPanel()
        flpInfo = New FlowLayoutPanel()
        lblInfo = New Label()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        lblRemaining = New Label()
        btnLogin = New CustomButton()
        flpAccount.SuspendLayout()
        CType(ptcIconAccount, ComponentModel.ISupportInitialize).BeginInit()
        flpInputAccount.SuspendLayout()
        flpPassword.SuspendLayout()
        CType(ptcIconPassword, ComponentModel.ISupportInitialize).BeginInit()
        flpInputPassword.SuspendLayout()
        flpLogo.SuspendLayout()
        CType(ptcLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnlForgot.SuspendLayout()
        flpWhole.SuspendLayout()
        flpInfo.SuspendLayout()
        FlowLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        txtName.BackColor = Color.AliceBlue
        txtName.BorderStyle = BorderStyle.None
        txtName.ForeColor = Color.Gray
        txtName.Location = New Point(3, 4)
        txtName.Margin = New Padding(3, 4, 3, 4)
        txtName.Name = "txtName"
        txtName.Size = New Size(255, 19)
        txtName.TabIndex = 0
        txtName.Text = "Email"
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.AliceBlue
        txtPassword.BorderStyle = BorderStyle.None
        txtPassword.ForeColor = Color.Gray
        txtPassword.Location = New Point(3, 4)
        txtPassword.Margin = New Padding(3, 4, 3, 4)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(255, 19)
        txtPassword.TabIndex = 1
        txtPassword.Text = "Account Password"
        ' 
        ' lklRecovery
        ' 
        lklRecovery.ActiveLinkColor = Color.PaleVioletRed
        lklRecovery.Dock = DockStyle.Top
        lklRecovery.LinkColor = Color.Beige
        lklRecovery.Location = New Point(0, 0)
        lklRecovery.Name = "lklRecovery"
        lklRecovery.Size = New Size(303, 19)
        lklRecovery.TabIndex = 105
        lklRecovery.TabStop = True
        lklRecovery.Text = "Fo&rgot password?"
        lklRecovery.TextAlign = ContentAlignment.BottomRight
        ' 
        ' lklRegister
        ' 
        lklRegister.ActiveLinkColor = Color.IndianRed
        lklRegister.LinkColor = Color.Beige
        lklRegister.Location = New Point(3, 381)
        lklRegister.Name = "lklRegister"
        lklRegister.Size = New Size(303, 19)
        lklRegister.TabIndex = 104
        lklRegister.TabStop = True
        lklRegister.Text = "Don't have an account? &Sign Up"
        lklRegister.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' flpTrademark
        ' 
        flpTrademark.AutoSize = True
        flpTrademark.FlowDirection = FlowDirection.TopDown
        flpTrademark.Location = New Point(3, 174)
        flpTrademark.Margin = New Padding(3, 4, 3, 4)
        flpTrademark.Name = "flpTrademark"
        flpTrademark.Size = New Size(0, 0)
        flpTrademark.TabIndex = 112
        ' 
        ' flpAccount
        ' 
        flpAccount.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        flpAccount.AutoSize = True
        flpAccount.BackColor = Color.AliceBlue
        flpAccount.Controls.Add(ptcIconAccount)
        flpAccount.Controls.Add(flpInputAccount)
        flpAccount.ForeColor = Color.Black
        flpAccount.Location = New Point(3, 188)
        flpAccount.Name = "flpAccount"
        flpAccount.Size = New Size(303, 36)
        flpAccount.TabIndex = 113
        ' 
        ' ptcIconAccount
        ' 
        ptcIconAccount.Image = My.Resources.Resources.iconEmail
        ptcIconAccount.Location = New Point(3, 3)
        ptcIconAccount.Name = "ptcIconAccount"
        ptcIconAccount.Size = New Size(30, 30)
        ptcIconAccount.SizeMode = PictureBoxSizeMode.StretchImage
        ptcIconAccount.TabIndex = 114
        ptcIconAccount.TabStop = False
        ' 
        ' flpInputAccount
        ' 
        flpInputAccount.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        flpInputAccount.AutoSize = True
        flpInputAccount.BackColor = Color.Transparent
        flpInputAccount.Controls.Add(txtName)
        flpInputAccount.FlowDirection = FlowDirection.TopDown
        flpInputAccount.Location = New Point(39, 4)
        flpInputAccount.Name = "flpInputAccount"
        flpInputAccount.Size = New Size(261, 27)
        flpInputAccount.TabIndex = 115
        ' 
        ' flpPassword
        ' 
        flpPassword.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        flpPassword.AutoSize = True
        flpPassword.BackColor = Color.AliceBlue
        flpPassword.Controls.Add(ptcIconPassword)
        flpPassword.Controls.Add(flpInputPassword)
        flpPassword.Location = New Point(3, 230)
        flpPassword.Name = "flpPassword"
        flpPassword.Size = New Size(303, 36)
        flpPassword.TabIndex = 115
        ' 
        ' ptcIconPassword
        ' 
        ptcIconPassword.Image = My.Resources.Resources.iconPassword
        ptcIconPassword.Location = New Point(3, 3)
        ptcIconPassword.Name = "ptcIconPassword"
        ptcIconPassword.Size = New Size(30, 30)
        ptcIconPassword.SizeMode = PictureBoxSizeMode.StretchImage
        ptcIconPassword.TabIndex = 116
        ptcIconPassword.TabStop = False
        ' 
        ' flpInputPassword
        ' 
        flpInputPassword.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        flpInputPassword.AutoSize = True
        flpInputPassword.BackColor = Color.Transparent
        flpInputPassword.Controls.Add(txtPassword)
        flpInputPassword.Location = New Point(39, 4)
        flpInputPassword.Name = "flpInputPassword"
        flpInputPassword.Size = New Size(261, 27)
        flpInputPassword.TabIndex = 114
        ' 
        ' flpLogo
        ' 
        flpLogo.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        flpLogo.AutoSize = True
        flpLogo.Controls.Add(ptcLogo)
        flpLogo.Location = New Point(89, 4)
        flpLogo.Margin = New Padding(3, 4, 3, 4)
        flpLogo.Name = "flpLogo"
        flpLogo.Size = New Size(131, 133)
        flpLogo.TabIndex = 105
        ' 
        ' ptcLogo
        ' 
        ptcLogo.Image = My.Resources.Resources.Logo
        ptcLogo.Location = New Point(3, 4)
        ptcLogo.Margin = New Padding(3, 4, 3, 4)
        ptcLogo.Name = "ptcLogo"
        ptcLogo.Size = New Size(125, 125)
        ptcLogo.SizeMode = PictureBoxSizeMode.StretchImage
        ptcLogo.TabIndex = 111
        ptcLogo.TabStop = False
        ' 
        ' pnlForgot
        ' 
        pnlForgot.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        pnlForgot.AutoSizeMode = AutoSizeMode.GrowAndShrink
        pnlForgot.Controls.Add(lklRecovery)
        pnlForgot.Location = New Point(3, 273)
        pnlForgot.Margin = New Padding(3, 4, 3, 4)
        pnlForgot.Name = "pnlForgot"
        pnlForgot.Size = New Size(303, 38)
        pnlForgot.TabIndex = 112
        ' 
        ' flpWhole
        ' 
        flpWhole.AutoSize = True
        flpWhole.AutoSizeMode = AutoSizeMode.GrowAndShrink
        flpWhole.BackColor = Color.Transparent
        flpWhole.BackgroundImageLayout = ImageLayout.None
        flpWhole.Controls.Add(flpLogo)
        flpWhole.Controls.Add(flpInfo)
        flpWhole.Controls.Add(flpAccount)
        flpWhole.Controls.Add(flpPassword)
        flpWhole.Controls.Add(pnlForgot)
        flpWhole.Controls.Add(FlowLayoutPanel1)
        flpWhole.Controls.Add(btnLogin)
        flpWhole.Controls.Add(lklRegister)
        flpWhole.FlowDirection = FlowDirection.TopDown
        flpWhole.Location = New Point(30, 30)
        flpWhole.Margin = New Padding(3, 4, 3, 4)
        flpWhole.Name = "flpWhole"
        flpWhole.Size = New Size(309, 400)
        flpWhole.TabIndex = 111
        ' 
        ' flpInfo
        ' 
        flpInfo.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        flpInfo.AutoSize = True
        flpInfo.AutoSizeMode = AutoSizeMode.GrowAndShrink
        flpInfo.BackColor = Color.Transparent
        flpInfo.Controls.Add(lblInfo)
        flpInfo.Location = New Point(78, 144)
        flpInfo.Name = "flpInfo"
        flpInfo.Size = New Size(153, 38)
        flpInfo.TabIndex = 119
        ' 
        ' lblInfo
        ' 
        lblInfo.AutoSize = True
        lblInfo.BackColor = Color.Transparent
        lblInfo.Font = New Font("Verdana", 24F, FontStyle.Bold)
        lblInfo.ForeColor = Color.White
        lblInfo.Location = New Point(3, 0)
        lblInfo.Name = "lblInfo"
        lblInfo.Size = New Size(147, 38)
        lblInfo.TabIndex = 115
        lblInfo.Text = "Sign In"
        lblInfo.TextAlign = ContentAlignment.TopCenter
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        FlowLayoutPanel1.AutoSize = True
        FlowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        FlowLayoutPanel1.BackColor = Color.Transparent
        FlowLayoutPanel1.Controls.Add(lblRemaining)
        FlowLayoutPanel1.Location = New Point(73, 318)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(163, 19)
        FlowLayoutPanel1.TabIndex = 120
        ' 
        ' lblRemaining
        ' 
        lblRemaining.AutoSize = True
        lblRemaining.ForeColor = Color.White
        lblRemaining.Location = New Point(3, 0)
        lblRemaining.Name = "lblRemaining"
        lblRemaining.Size = New Size(157, 19)
        lblRemaining.TabIndex = 301
        lblRemaining.Text = "Remaining Attempts: {#}"
        lblRemaining.Visible = False
        ' 
        ' btnLogin
        ' 
        btnLogin.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        btnLogin.BackColor = Color.Beige
        btnLogin.BorderRadius = 20
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Segoe UI", 12F)
        btnLogin.HoverBackColor = Color.White
        btnLogin.HoverForeColor = Color.Navy
        btnLogin.Location = New Point(3, 343)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(303, 35)
        btnLogin.SoundClick = "click"
        btnLogin.SoundHover = "hover"
        btnLogin.TabIndex = 300
        btnLogin.TabStop = False
        btnLogin.Text = "&Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' Login
        ' 
        AcceptButton = btnLogin
        AutoScaleDimensions = New SizeF(8F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        BackgroundImage = My.Resources.Resources.backgroundLogin
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(367, 453)
        Controls.Add(flpWhole)
        Controls.Add(flpTrademark)
        ForeColor = Color.Black
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = My.Resources.Resources.Lucky_Stelle
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Lucky Stelle"
        flpAccount.ResumeLayout(False)
        flpAccount.PerformLayout()
        CType(ptcIconAccount, ComponentModel.ISupportInitialize).EndInit()
        flpInputAccount.ResumeLayout(False)
        flpInputAccount.PerformLayout()
        flpPassword.ResumeLayout(False)
        flpPassword.PerformLayout()
        CType(ptcIconPassword, ComponentModel.ISupportInitialize).EndInit()
        flpInputPassword.ResumeLayout(False)
        flpInputPassword.PerformLayout()
        flpLogo.ResumeLayout(False)
        CType(ptcLogo, ComponentModel.ISupportInitialize).EndInit()
        pnlForgot.ResumeLayout(False)
        flpWhole.ResumeLayout(False)
        flpWhole.PerformLayout()
        flpInfo.ResumeLayout(False)
        flpInfo.PerformLayout()
        FlowLayoutPanel1.ResumeLayout(False)
        FlowLayoutPanel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnLogins As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lklRecovery As LinkLabel
    Friend WithEvents lklRegister As LinkLabel
    Friend WithEvents pnlForgot As Panel
    Friend WithEvents flpTrademark As FlowLayoutPanel
    Friend WithEvents lblTitle As Label
    Friend WithEvents flpAccount As FlowLayoutPanel
    Friend WithEvents ptcIconAccount As PictureBox
    Friend WithEvents flpInputPassword As FlowLayoutPanel
    Friend WithEvents flpLogo As FlowLayoutPanel
    Friend WithEvents ptcLogo As PictureBox
    Friend WithEvents flpInputAccount As FlowLayoutPanel
    Friend WithEvents flpPassword As FlowLayoutPanel
    Friend WithEvents ptcIconPassword As PictureBox
    Friend WithEvents flpWhole As FlowLayoutPanel
    Friend WithEvents pnlInfo As Panel
    Friend WithEvents flpInfo As FlowLayoutPanel
    Friend WithEvents lblInfo As Label
    Friend WithEvents btnLogin As CustomButton
    Friend WithEvents lblRemaining As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
End Class
