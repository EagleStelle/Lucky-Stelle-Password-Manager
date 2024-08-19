<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Register
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        flpWhole = New FlowLayoutPanel()
        flpLogo = New FlowLayoutPanel()
        ptcLogo = New PictureBox()
        flpInfo = New FlowLayoutPanel()
        lblTitle = New Label()
        flpAccount = New FlowLayoutPanel()
        ptcIconAccount = New PictureBox()
        flpInputAccount = New FlowLayoutPanel()
        txtName = New TextBox()
        flpPassword = New FlowLayoutPanel()
        ptcIconPassword = New PictureBox()
        flpInputPassword = New FlowLayoutPanel()
        txtPassword = New TextBox()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        PictureBox1 = New PictureBox()
        FlowLayoutPanel2 = New FlowLayoutPanel()
        txtVaultPassword = New TextBox()
        btnRegister = New CustomButton()
        lklLogin = New LinkLabel()
        flpWhole.SuspendLayout()
        flpLogo.SuspendLayout()
        CType(ptcLogo, ComponentModel.ISupportInitialize).BeginInit()
        flpInfo.SuspendLayout()
        flpAccount.SuspendLayout()
        CType(ptcIconAccount, ComponentModel.ISupportInitialize).BeginInit()
        flpInputAccount.SuspendLayout()
        flpPassword.SuspendLayout()
        CType(ptcIconPassword, ComponentModel.ISupportInitialize).BeginInit()
        flpInputPassword.SuspendLayout()
        FlowLayoutPanel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        FlowLayoutPanel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' flpWhole
        ' 
        flpWhole.AutoSize = True
        flpWhole.AutoSizeMode = AutoSizeMode.GrowAndShrink
        flpWhole.BackColor = Color.Transparent
        flpWhole.Controls.Add(flpLogo)
        flpWhole.Controls.Add(flpInfo)
        flpWhole.Controls.Add(flpAccount)
        flpWhole.Controls.Add(flpPassword)
        flpWhole.Controls.Add(FlowLayoutPanel1)
        flpWhole.Controls.Add(btnRegister)
        flpWhole.Controls.Add(lklLogin)
        flpWhole.FlowDirection = FlowDirection.TopDown
        flpWhole.Location = New Point(30, 30)
        flpWhole.Margin = New Padding(3, 4, 3, 4)
        flpWhole.Name = "flpWhole"
        flpWhole.Size = New Size(309, 371)
        flpWhole.TabIndex = 113
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
        flpLogo.TabIndex = 300
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
        ' flpInfo
        ' 
        flpInfo.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        flpInfo.AutoSize = True
        flpInfo.AutoSizeMode = AutoSizeMode.GrowAndShrink
        flpInfo.Controls.Add(lblTitle)
        flpInfo.Location = New Point(74, 144)
        flpInfo.Name = "flpInfo"
        flpInfo.Size = New Size(161, 38)
        flpInfo.TabIndex = 300
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.BackColor = Color.Transparent
        lblTitle.Font = New Font("Verdana", 24.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.AliceBlue
        lblTitle.Location = New Point(3, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(155, 38)
        lblTitle.TabIndex = 300
        lblTitle.Text = "Sign Up"
        lblTitle.TextAlign = ContentAlignment.TopCenter
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
        flpAccount.TabIndex = 1
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
        txtName.TabIndex = 1
        txtName.Text = "Email"
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
        flpPassword.TabIndex = 2
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
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.AliceBlue
        txtPassword.BorderStyle = BorderStyle.None
        txtPassword.ForeColor = Color.Gray
        txtPassword.Location = New Point(3, 4)
        txtPassword.Margin = New Padding(3, 4, 3, 4)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(255, 19)
        txtPassword.TabIndex = 2
        txtPassword.Text = "Account Password"
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        FlowLayoutPanel1.AutoSize = True
        FlowLayoutPanel1.BackColor = Color.AliceBlue
        FlowLayoutPanel1.Controls.Add(PictureBox1)
        FlowLayoutPanel1.Controls.Add(FlowLayoutPanel2)
        FlowLayoutPanel1.Location = New Point(3, 272)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(303, 36)
        FlowLayoutPanel1.TabIndex = 3
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.iconVault
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(30, 30)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 116
        PictureBox1.TabStop = False
        ' 
        ' FlowLayoutPanel2
        ' 
        FlowLayoutPanel2.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        FlowLayoutPanel2.AutoSize = True
        FlowLayoutPanel2.BackColor = Color.Transparent
        FlowLayoutPanel2.Controls.Add(txtVaultPassword)
        FlowLayoutPanel2.Location = New Point(39, 4)
        FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        FlowLayoutPanel2.Size = New Size(261, 27)
        FlowLayoutPanel2.TabIndex = 114
        ' 
        ' txtVaultPassword
        ' 
        txtVaultPassword.BackColor = Color.AliceBlue
        txtVaultPassword.BorderStyle = BorderStyle.None
        txtVaultPassword.ForeColor = Color.Gray
        txtVaultPassword.Location = New Point(3, 4)
        txtVaultPassword.Margin = New Padding(3, 4, 3, 4)
        txtVaultPassword.Name = "txtVaultPassword"
        txtVaultPassword.Size = New Size(255, 19)
        txtVaultPassword.TabIndex = 3
        txtVaultPassword.Text = "Vault Password"
        ' 
        ' btnRegister
        ' 
        btnRegister.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        btnRegister.BackColor = Color.Moccasin
        btnRegister.BorderRadius = 20
        btnRegister.FlatAppearance.BorderSize = 0
        btnRegister.FlatStyle = FlatStyle.Flat
        btnRegister.Font = New Font("Segoe UI", 12.0F)
        btnRegister.HoverBackColor = Color.White
        btnRegister.HoverForeColor = Color.Navy
        btnRegister.Location = New Point(3, 314)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(303, 35)
        btnRegister.SoundClick = "click"
        btnRegister.SoundHover = "hover"
        btnRegister.TabIndex = 300
        btnRegister.TabStop = False
        btnRegister.Text = "&Register"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' lklLogin
        ' 
        lklLogin.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        lklLogin.AutoSize = True
        lklLogin.LinkColor = Color.Beige
        lklLogin.Location = New Point(50, 352)
        lklLogin.Name = "lklLogin"
        lklLogin.Size = New Size(208, 19)
        lklLogin.TabIndex = 300
        lklLogin.TabStop = True
        lklLogin.Text = "Already have an account? Log In"
        lklLogin.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Register
        ' 
        AcceptButton = btnRegister
        AutoScaleDimensions = New SizeF(8.0F, 19.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        BackgroundImage = My.Resources.Resources.backgroundRegister
        BackgroundImageLayout = ImageLayout.Stretch
        CancelButton = lklLogin
        ClientSize = New Size(385, 784)
        Controls.Add(flpWhole)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = My.Resources.Resources.Lucky_Stelle
        MaximizeBox = False
        MinimizeBox = False
        Name = "Register"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Lucky Stelle"
        flpWhole.ResumeLayout(False)
        flpWhole.PerformLayout()
        flpLogo.ResumeLayout(False)
        CType(ptcLogo, ComponentModel.ISupportInitialize).EndInit()
        flpInfo.ResumeLayout(False)
        flpInfo.PerformLayout()
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
        FlowLayoutPanel1.ResumeLayout(False)
        FlowLayoutPanel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        FlowLayoutPanel2.ResumeLayout(False)
        FlowLayoutPanel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents flpWhole As FlowLayoutPanel
    Friend WithEvents flpLogo As FlowLayoutPanel
    Friend WithEvents ptcLogo As PictureBox
    Friend WithEvents flpInfo As FlowLayoutPanel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lklLogin As LinkLabel
    Friend WithEvents flpAccount As FlowLayoutPanel
    Friend WithEvents ptcIconAccount As PictureBox
    Friend WithEvents flpInputAccount As FlowLayoutPanel
    Friend WithEvents txtName As TextBox
    Friend WithEvents flpPassword As FlowLayoutPanel
    Friend WithEvents ptcIconPassword As PictureBox
    Friend WithEvents flpInputPassword As FlowLayoutPanel
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents txtVaultPassword As TextBox
    Friend WithEvents btnRegister As CustomButton
End Class
