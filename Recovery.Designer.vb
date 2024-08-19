<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recovery
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
        flpLogo = New FlowLayoutPanel()
        ptcLogo = New PictureBox()
        flpWhole = New FlowLayoutPanel()
        flpInfo = New FlowLayoutPanel()
        lblTitle = New Label()
        flpAccount = New FlowLayoutPanel()
        ptcIconAccount = New PictureBox()
        flpInputAccount = New FlowLayoutPanel()
        txtName = New TextBox()
        FlowLayoutPanel3 = New FlowLayoutPanel()
        ptcIconPassword = New PictureBox()
        flpInputPassword = New FlowLayoutPanel()
        txtPassword = New TextBox()
        flpCode = New FlowLayoutPanel()
        ptcCode = New PictureBox()
        flpInputCode = New FlowLayoutPanel()
        txtRecoveryPassword = New TextBox()
        btnChange = New CustomButton()
        lklLogin = New LinkLabel()
        flpLogo.SuspendLayout()
        CType(ptcLogo, ComponentModel.ISupportInitialize).BeginInit()
        flpWhole.SuspendLayout()
        flpInfo.SuspendLayout()
        flpAccount.SuspendLayout()
        CType(ptcIconAccount, ComponentModel.ISupportInitialize).BeginInit()
        flpInputAccount.SuspendLayout()
        FlowLayoutPanel3.SuspendLayout()
        CType(ptcIconPassword, ComponentModel.ISupportInitialize).BeginInit()
        flpInputPassword.SuspendLayout()
        flpCode.SuspendLayout()
        CType(ptcCode, ComponentModel.ISupportInitialize).BeginInit()
        flpInputCode.SuspendLayout()
        SuspendLayout()
        ' 
        ' flpLogo
        ' 
        flpLogo.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        flpLogo.AutoSize = True
        flpLogo.Controls.Add(ptcLogo)
        flpLogo.Location = New Point(79, 3)
        flpLogo.Name = "flpLogo"
        flpLogo.Size = New Size(115, 105)
        flpLogo.TabIndex = 115
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
        ' flpWhole
        ' 
        flpWhole.AutoSize = True
        flpWhole.AutoSizeMode = AutoSizeMode.GrowAndShrink
        flpWhole.BackColor = Color.Transparent
        flpWhole.Controls.Add(flpLogo)
        flpWhole.Controls.Add(flpInfo)
        flpWhole.Controls.Add(flpAccount)
        flpWhole.Controls.Add(FlowLayoutPanel3)
        flpWhole.Controls.Add(flpCode)
        flpWhole.Controls.Add(btnChange)
        flpWhole.Controls.Add(lklLogin)
        flpWhole.FlowDirection = FlowDirection.TopDown
        flpWhole.Location = New Point(26, 24)
        flpWhole.Margin = New Padding(3, 2, 3, 2)
        flpWhole.Name = "flpWhole"
        flpWhole.Size = New Size(273, 296)
        flpWhole.TabIndex = 116
        ' 
        ' flpInfo
        ' 
        flpInfo.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        flpInfo.AutoSize = True
        flpInfo.AutoSizeMode = AutoSizeMode.GrowAndShrink
        flpInfo.Controls.Add(lblTitle)
        flpInfo.Location = New Point(42, 113)
        flpInfo.Margin = New Padding(3, 2, 3, 2)
        flpInfo.Name = "flpInfo"
        flpInfo.Size = New Size(189, 38)
        flpInfo.TabIndex = 118
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.BackColor = Color.Transparent
        lblTitle.Font = New Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point)
        lblTitle.ForeColor = Color.SeaShell
        lblTitle.Location = New Point(3, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(183, 38)
        lblTitle.TabIndex = 115
        lblTitle.Text = "Recovery"
        lblTitle.TextAlign = ContentAlignment.TopCenter
        ' 
        ' flpAccount
        ' 
        flpAccount.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        flpAccount.AutoSize = True
        flpAccount.AutoSizeMode = AutoSizeMode.GrowAndShrink
        flpAccount.BackColor = Color.SeaShell
        flpAccount.Controls.Add(ptcIconAccount)
        flpAccount.Controls.Add(flpInputAccount)
        flpAccount.ForeColor = Color.Black
        flpAccount.Location = New Point(3, 155)
        flpAccount.Margin = New Padding(3, 2, 3, 2)
        flpAccount.Name = "flpAccount"
        flpAccount.Size = New Size(267, 28)
        flpAccount.TabIndex = 110
        ' 
        ' ptcIconAccount
        ' 
        ptcIconAccount.Image = My.Resources.Resources.iconEmail
        ptcIconAccount.Location = New Point(3, 2)
        ptcIconAccount.Margin = New Padding(3, 2, 3, 2)
        ptcIconAccount.Name = "ptcIconAccount"
        ptcIconAccount.Size = New Size(26, 24)
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
        flpInputAccount.Location = New Point(35, 3)
        flpInputAccount.Margin = New Padding(3, 2, 3, 2)
        flpInputAccount.Name = "flpInputAccount"
        flpInputAccount.Size = New Size(229, 22)
        flpInputAccount.TabIndex = 101
        ' 
        ' txtName
        ' 
        txtName.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        txtName.BackColor = Color.SeaShell
        txtName.BorderStyle = BorderStyle.None
        txtName.ForeColor = Color.Gray
        txtName.Location = New Point(3, 3)
        txtName.Name = "txtName"
        txtName.Size = New Size(223, 16)
        txtName.TabIndex = 101
        txtName.Text = "Email"
        ' 
        ' FlowLayoutPanel3
        ' 
        FlowLayoutPanel3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        FlowLayoutPanel3.AutoSize = True
        FlowLayoutPanel3.AutoSizeMode = AutoSizeMode.GrowAndShrink
        FlowLayoutPanel3.BackColor = Color.SeaShell
        FlowLayoutPanel3.Controls.Add(ptcIconPassword)
        FlowLayoutPanel3.Controls.Add(flpInputPassword)
        FlowLayoutPanel3.Location = New Point(3, 187)
        FlowLayoutPanel3.Margin = New Padding(3, 2, 3, 2)
        FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        FlowLayoutPanel3.Size = New Size(267, 28)
        FlowLayoutPanel3.TabIndex = 112
        ' 
        ' ptcIconPassword
        ' 
        ptcIconPassword.Image = My.Resources.Resources.iconPassword
        ptcIconPassword.Location = New Point(3, 2)
        ptcIconPassword.Margin = New Padding(3, 2, 3, 2)
        ptcIconPassword.Name = "ptcIconPassword"
        ptcIconPassword.Size = New Size(26, 24)
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
        flpInputPassword.Location = New Point(35, 3)
        flpInputPassword.Margin = New Padding(3, 2, 3, 2)
        flpInputPassword.Name = "flpInputPassword"
        flpInputPassword.Size = New Size(229, 22)
        flpInputPassword.TabIndex = 102
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.SeaShell
        txtPassword.BorderStyle = BorderStyle.None
        txtPassword.ForeColor = Color.Gray
        txtPassword.Location = New Point(3, 3)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(223, 16)
        txtPassword.TabIndex = 102
        txtPassword.Text = "Account Password"
        ' 
        ' flpCode
        ' 
        flpCode.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        flpCode.AutoSize = True
        flpCode.AutoSizeMode = AutoSizeMode.GrowAndShrink
        flpCode.BackColor = Color.SeaShell
        flpCode.Controls.Add(ptcCode)
        flpCode.Controls.Add(flpInputCode)
        flpCode.Location = New Point(3, 219)
        flpCode.Margin = New Padding(3, 2, 3, 2)
        flpCode.Name = "flpCode"
        flpCode.Size = New Size(267, 28)
        flpCode.TabIndex = 113
        ' 
        ' ptcCode
        ' 
        ptcCode.Image = My.Resources.Resources.iconCode
        ptcCode.Location = New Point(3, 2)
        ptcCode.Margin = New Padding(3, 2, 3, 2)
        ptcCode.Name = "ptcCode"
        ptcCode.Size = New Size(26, 24)
        ptcCode.SizeMode = PictureBoxSizeMode.StretchImage
        ptcCode.TabIndex = 116
        ptcCode.TabStop = False
        ' 
        ' flpInputCode
        ' 
        flpInputCode.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        flpInputCode.AutoSize = True
        flpInputCode.BackColor = Color.Transparent
        flpInputCode.Controls.Add(txtRecoveryPassword)
        flpInputCode.Location = New Point(35, 3)
        flpInputCode.Margin = New Padding(3, 2, 3, 2)
        flpInputCode.Name = "flpInputCode"
        flpInputCode.Size = New Size(229, 22)
        flpInputCode.TabIndex = 103
        ' 
        ' txtRecoveryPassword
        ' 
        txtRecoveryPassword.BackColor = Color.SeaShell
        txtRecoveryPassword.BorderStyle = BorderStyle.None
        txtRecoveryPassword.ForeColor = Color.Gray
        txtRecoveryPassword.Location = New Point(3, 3)
        txtRecoveryPassword.Name = "txtRecoveryPassword"
        txtRecoveryPassword.Size = New Size(223, 16)
        txtRecoveryPassword.TabIndex = 103
        txtRecoveryPassword.Text = "Stelle Code"
        ' 
        ' btnChange
        ' 
        btnChange.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        btnChange.BackColor = Color.Moccasin
        btnChange.BorderRadius = 20
        btnChange.FlatAppearance.BorderSize = 0
        btnChange.FlatStyle = FlatStyle.Flat
        btnChange.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnChange.HoverBackColor = Color.White
        btnChange.HoverForeColor = Color.Navy
        btnChange.Location = New Point(3, 251)
        btnChange.Margin = New Padding(3, 2, 3, 2)
        btnChange.Name = "btnChange"
        btnChange.Size = New Size(267, 28)
        btnChange.SoundClick = "click"
        btnChange.SoundHover = "hover"
        btnChange.TabIndex = 301
        btnChange.TabStop = False
        btnChange.Text = "&Change Password"
        btnChange.UseVisualStyleBackColor = False
        ' 
        ' lklLogin
        ' 
        lklLogin.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        lklLogin.AutoSize = True
        lklLogin.LinkColor = Color.Beige
        lklLogin.Location = New Point(37, 281)
        lklLogin.Name = "lklLogin"
        lklLogin.Size = New Size(199, 15)
        lklLogin.TabIndex = 160
        lklLogin.TabStop = True
        lklLogin.Text = "Remembered your password? Log In"
        lklLogin.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Recovery
        ' 
        AcceptButton = btnChange
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        BackgroundImage = My.Resources.Resources.backgroundRecovery
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(324, 346)
        Controls.Add(flpWhole)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = My.Resources.Resources.Lucky_Stelle
        Margin = New Padding(3, 2, 3, 2)
        Name = "Recovery"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Lucky Stelle"
        flpLogo.ResumeLayout(False)
        CType(ptcLogo, ComponentModel.ISupportInitialize).EndInit()
        flpWhole.ResumeLayout(False)
        flpWhole.PerformLayout()
        flpInfo.ResumeLayout(False)
        flpInfo.PerformLayout()
        flpAccount.ResumeLayout(False)
        flpAccount.PerformLayout()
        CType(ptcIconAccount, ComponentModel.ISupportInitialize).EndInit()
        flpInputAccount.ResumeLayout(False)
        flpInputAccount.PerformLayout()
        FlowLayoutPanel3.ResumeLayout(False)
        FlowLayoutPanel3.PerformLayout()
        CType(ptcIconPassword, ComponentModel.ISupportInitialize).EndInit()
        flpInputPassword.ResumeLayout(False)
        flpInputPassword.PerformLayout()
        flpCode.ResumeLayout(False)
        flpCode.PerformLayout()
        CType(ptcCode, ComponentModel.ISupportInitialize).EndInit()
        flpInputCode.ResumeLayout(False)
        flpInputCode.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents flpCode As FlowLayoutPanel
    Friend WithEvents ptcCode As PictureBox
    Friend WithEvents flpInputCode As FlowLayoutPanel
    Friend WithEvents txtRecoveryPassword As TextBox
    Friend WithEvents lklLogin As LinkLabel
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents ptcIconPassword As PictureBox
    Friend WithEvents flpInputPassword As FlowLayoutPanel
    Friend WithEvents flpLogo As FlowLayoutPanel
    Friend WithEvents ptcLogo As PictureBox
    Friend WithEvents flpWhole As FlowLayoutPanel
    Friend WithEvents flpInfo As FlowLayoutPanel
    Friend WithEvents lblTitle As Label
    Friend WithEvents flpAccount As FlowLayoutPanel
    Friend WithEvents ptcIconAccount As PictureBox
    Friend WithEvents flpInputAccount As FlowLayoutPanel
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnChange As CustomButton
End Class
