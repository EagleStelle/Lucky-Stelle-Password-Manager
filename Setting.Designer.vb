<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Setting
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
        components = New ComponentModel.Container()
        btnChangeAccountPassword = New Button()
        btnChangeVaultPassword = New Button()
        tmrStelle = New Timer(components)
        tmrDisplay = New Timer(components)
        flpSetting = New FlowLayoutPanel()
        flpInfoManagement = New FlowLayoutPanel()
        Label1 = New Label()
        btnChangeName = New Button()
        btnDeleteAccount = New Button()
        flpSetting.SuspendLayout()
        flpInfoManagement.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnChangeAccountPassword
        ' 
        btnChangeAccountPassword.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        btnChangeAccountPassword.BackColor = Color.FromArgb(CByte(106), CByte(80), CByte(109))
        btnChangeAccountPassword.FlatAppearance.BorderSize = 0
        btnChangeAccountPassword.FlatStyle = FlatStyle.Flat
        btnChangeAccountPassword.Location = New Point(3, 85)
        btnChangeAccountPassword.Margin = New Padding(3, 4, 3, 4)
        btnChangeAccountPassword.Name = "btnChangeAccountPassword"
        btnChangeAccountPassword.Size = New Size(284, 35)
        btnChangeAccountPassword.TabIndex = 201
        btnChangeAccountPassword.TabStop = False
        btnChangeAccountPassword.Text = "Change Account Password"
        btnChangeAccountPassword.UseVisualStyleBackColor = False
        ' 
        ' btnChangeVaultPassword
        ' 
        btnChangeVaultPassword.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        btnChangeVaultPassword.BackColor = Color.FromArgb(CByte(106), CByte(80), CByte(109))
        btnChangeVaultPassword.FlatAppearance.BorderSize = 0
        btnChangeVaultPassword.FlatStyle = FlatStyle.Flat
        btnChangeVaultPassword.Location = New Point(3, 128)
        btnChangeVaultPassword.Margin = New Padding(3, 4, 3, 4)
        btnChangeVaultPassword.Name = "btnChangeVaultPassword"
        btnChangeVaultPassword.Size = New Size(284, 35)
        btnChangeVaultPassword.TabIndex = 202
        btnChangeVaultPassword.TabStop = False
        btnChangeVaultPassword.Text = "Change Vault Password"
        btnChangeVaultPassword.UseVisualStyleBackColor = False
        ' 
        ' tmrStelle
        ' 
        tmrStelle.Interval = 1000
        ' 
        ' tmrDisplay
        ' 
        tmrDisplay.Interval = 1500
        ' 
        ' flpSetting
        ' 
        flpSetting.AutoSize = True
        flpSetting.AutoSizeMode = AutoSizeMode.GrowAndShrink
        flpSetting.Controls.Add(flpInfoManagement)
        flpSetting.Controls.Add(btnChangeName)
        flpSetting.Controls.Add(btnChangeAccountPassword)
        flpSetting.Controls.Add(btnChangeVaultPassword)
        flpSetting.Controls.Add(btnDeleteAccount)
        flpSetting.FlowDirection = FlowDirection.TopDown
        flpSetting.Location = New Point(0, 0)
        flpSetting.Name = "flpSetting"
        flpSetting.Size = New Size(290, 210)
        flpSetting.TabIndex = 122
        ' 
        ' flpInfoManagement
        ' 
        flpInfoManagement.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        flpInfoManagement.AutoSize = True
        flpInfoManagement.AutoSizeMode = AutoSizeMode.GrowAndShrink
        flpInfoManagement.Controls.Add(Label1)
        flpInfoManagement.FlowDirection = FlowDirection.TopDown
        flpInfoManagement.Font = New Font("Segoe UI", 18F)
        flpInfoManagement.Location = New Point(38, 3)
        flpInfoManagement.Name = "flpInfoManagement"
        flpInfoManagement.Size = New Size(214, 32)
        flpInfoManagement.TabIndex = 124
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(255), CByte(223), CByte(122))
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(208, 32)
        Label1.TabIndex = 108
        Label1.Text = "Account Settings"
        ' 
        ' btnChangeName
        ' 
        btnChangeName.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        btnChangeName.BackColor = Color.FromArgb(CByte(106), CByte(80), CByte(109))
        btnChangeName.FlatAppearance.BorderSize = 0
        btnChangeName.FlatStyle = FlatStyle.Flat
        btnChangeName.Location = New Point(3, 42)
        btnChangeName.Margin = New Padding(3, 4, 3, 4)
        btnChangeName.Name = "btnChangeName"
        btnChangeName.Size = New Size(284, 35)
        btnChangeName.TabIndex = 204
        btnChangeName.TabStop = False
        btnChangeName.Text = "Change Username"
        btnChangeName.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteAccount
        ' 
        btnDeleteAccount.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        btnDeleteAccount.BackColor = Color.FromArgb(CByte(174), CByte(85), CByte(85))
        btnDeleteAccount.FlatAppearance.BorderSize = 0
        btnDeleteAccount.FlatStyle = FlatStyle.Flat
        btnDeleteAccount.Location = New Point(3, 171)
        btnDeleteAccount.Margin = New Padding(3, 4, 3, 4)
        btnDeleteAccount.Name = "btnDeleteAccount"
        btnDeleteAccount.Size = New Size(284, 35)
        btnDeleteAccount.TabIndex = 203
        btnDeleteAccount.TabStop = False
        btnDeleteAccount.Text = "Delete Account"
        btnDeleteAccount.UseVisualStyleBackColor = False
        ' 
        ' Setting
        ' 
        AutoScaleDimensions = New SizeF(8F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(60), CByte(51), CByte(81))
        ClientSize = New Size(290, 210)
        Controls.Add(flpSetting)
        ForeColor = Color.FromArgb(CByte(240), CByte(241), CByte(199))
        FormBorderStyle = FormBorderStyle.None
        Icon = My.Resources.Resources.Lucky_Stelle
        Margin = New Padding(3, 4, 3, 4)
        Name = "Setting"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Lucky Stelle"
        flpSetting.ResumeLayout(False)
        flpSetting.PerformLayout()
        flpInfoManagement.ResumeLayout(False)
        flpInfoManagement.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents flpInfoManagement As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnChangeAccountPassword As Button
    Friend WithEvents btnChangeVaultPassword As Button
    Friend WithEvents tmrStelle As Timer
    Friend WithEvents tmrDisplay As Timer
    Friend WithEvents flpLogo As FlowLayoutPanel
    Friend WithEvents ptcLogo As PictureBox
    Friend WithEvents flpTitle As FlowLayoutPanel
    Friend WithEvents lblTitle As Label
    Friend WithEvents flpTag As FlowLayoutPanel
    Friend WithEvents lblTag As Label
    Friend WithEvents flpSetting As FlowLayoutPanel
    Friend WithEvents btnDeleteAccount As Button
    Friend WithEvents btnChangeName As Button
End Class
