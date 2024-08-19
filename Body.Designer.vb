<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Body
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
        btnSetting = New Button()
        btnMigration = New Button()
        btnReview = New Button()
        btnPasswords = New Button()
        btnImport = New Button()
        btnExport = New Button()
        ptcStelle = New PictureBox()
        pnlDashboard = New Panel()
        btnLogout = New Button()
        pnlMigration = New Panel()
        pnlMigrationOptions = New Panel()
        btnHome = New Button()
        tmrStelle = New Timer(components)
        tmrDisplay = New Timer(components)
        flpStelle = New FlowLayoutPanel()
        flpAssistant = New FlowLayoutPanel()
        txtGreeting = New RichTextBox()
        txtStatus = New RichTextBox()
        CType(ptcStelle, ComponentModel.ISupportInitialize).BeginInit()
        pnlDashboard.SuspendLayout()
        pnlMigration.SuspendLayout()
        pnlMigrationOptions.SuspendLayout()
        flpStelle.SuspendLayout()
        flpAssistant.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnSetting
        ' 
        btnSetting.AutoSize = True
        btnSetting.Dock = DockStyle.Top
        btnSetting.FlatAppearance.BorderSize = 0
        btnSetting.FlatStyle = FlatStyle.Flat
        btnSetting.Font = New Font("Segoe UI", 15F)
        btnSetting.ForeColor = Color.White
        btnSetting.Image = My.Resources.Resources.iconSettings
        btnSetting.ImageAlign = ContentAlignment.MiddleLeft
        btnSetting.Location = New Point(0, 368)
        btnSetting.Name = "btnSetting"
        btnSetting.Padding = New Padding(5, 0, 0, 0)
        btnSetting.Size = New Size(206, 68)
        btnSetting.TabIndex = 4
        btnSetting.TabStop = False
        btnSetting.Text = "Setting"
        btnSetting.TextAlign = ContentAlignment.MiddleLeft
        btnSetting.TextImageRelation = TextImageRelation.ImageBeforeText
        btnSetting.UseVisualStyleBackColor = True
        ' 
        ' btnMigration
        ' 
        btnMigration.AutoSize = True
        btnMigration.Dock = DockStyle.Top
        btnMigration.FlatAppearance.BorderSize = 0
        btnMigration.FlatStyle = FlatStyle.Flat
        btnMigration.Font = New Font("Segoe UI", 15F)
        btnMigration.ForeColor = Color.White
        btnMigration.Image = My.Resources.Resources.iconMigration
        btnMigration.ImageAlign = ContentAlignment.MiddleLeft
        btnMigration.Location = New Point(0, 0)
        btnMigration.Name = "btnMigration"
        btnMigration.Padding = New Padding(5, 0, 0, 0)
        btnMigration.Size = New Size(206, 68)
        btnMigration.TabIndex = 6
        btnMigration.TabStop = False
        btnMigration.Text = "Migration"
        btnMigration.TextAlign = ContentAlignment.MiddleLeft
        btnMigration.TextImageRelation = TextImageRelation.ImageBeforeText
        btnMigration.UseVisualStyleBackColor = True
        ' 
        ' btnReview
        ' 
        btnReview.AutoSize = True
        btnReview.Dock = DockStyle.Top
        btnReview.FlatAppearance.BorderSize = 0
        btnReview.FlatStyle = FlatStyle.Flat
        btnReview.Font = New Font("Segoe UI", 15F)
        btnReview.ForeColor = Color.White
        btnReview.Image = My.Resources.Resources.iconStatus
        btnReview.ImageAlign = ContentAlignment.MiddleLeft
        btnReview.Location = New Point(0, 136)
        btnReview.Name = "btnReview"
        btnReview.Padding = New Padding(5, 0, 0, 0)
        btnReview.Size = New Size(206, 68)
        btnReview.TabIndex = 7
        btnReview.TabStop = False
        btnReview.Text = "Review"
        btnReview.TextAlign = ContentAlignment.MiddleLeft
        btnReview.TextImageRelation = TextImageRelation.ImageBeforeText
        btnReview.UseVisualStyleBackColor = True
        ' 
        ' btnPasswords
        ' 
        btnPasswords.AutoSize = True
        btnPasswords.Dock = DockStyle.Top
        btnPasswords.FlatAppearance.BorderSize = 0
        btnPasswords.FlatStyle = FlatStyle.Flat
        btnPasswords.Font = New Font("Segoe UI", 15F)
        btnPasswords.ForeColor = Color.White
        btnPasswords.Image = My.Resources.Resources.iconSystem
        btnPasswords.ImageAlign = ContentAlignment.MiddleLeft
        btnPasswords.Location = New Point(0, 68)
        btnPasswords.Name = "btnPasswords"
        btnPasswords.Padding = New Padding(5, 0, 0, 0)
        btnPasswords.Size = New Size(206, 68)
        btnPasswords.TabIndex = 3
        btnPasswords.TabStop = False
        btnPasswords.Text = "Passwords"
        btnPasswords.TextAlign = ContentAlignment.MiddleLeft
        btnPasswords.TextImageRelation = TextImageRelation.ImageBeforeText
        btnPasswords.UseVisualStyleBackColor = True
        ' 
        ' btnImport
        ' 
        btnImport.AutoSize = True
        btnImport.BackColor = Color.FromArgb(CByte(106), CByte(80), CByte(109))
        btnImport.Dock = DockStyle.Top
        btnImport.FlatAppearance.BorderSize = 0
        btnImport.FlatStyle = FlatStyle.Flat
        btnImport.Font = New Font("Segoe UI", 15F)
        btnImport.ForeColor = Color.White
        btnImport.ImageAlign = ContentAlignment.MiddleLeft
        btnImport.Location = New Point(0, 0)
        btnImport.Name = "btnImport"
        btnImport.Padding = New Padding(5, 0, 0, 0)
        btnImport.Size = New Size(206, 48)
        btnImport.TabIndex = 7
        btnImport.TabStop = False
        btnImport.Text = "Import Passwords"
        btnImport.TextAlign = ContentAlignment.MiddleLeft
        btnImport.TextImageRelation = TextImageRelation.ImageBeforeText
        btnImport.UseVisualStyleBackColor = False
        ' 
        ' btnExport
        ' 
        btnExport.AutoSize = True
        btnExport.BackColor = Color.FromArgb(CByte(106), CByte(80), CByte(109))
        btnExport.Dock = DockStyle.Top
        btnExport.FlatAppearance.BorderSize = 0
        btnExport.FlatStyle = FlatStyle.Flat
        btnExport.Font = New Font("Segoe UI", 15F)
        btnExport.ForeColor = Color.White
        btnExport.ImageAlign = ContentAlignment.MiddleLeft
        btnExport.Location = New Point(0, 48)
        btnExport.Name = "btnExport"
        btnExport.Padding = New Padding(5, 0, 0, 0)
        btnExport.Size = New Size(206, 48)
        btnExport.TabIndex = 8
        btnExport.TabStop = False
        btnExport.Text = "Export Passwords"
        btnExport.TextAlign = ContentAlignment.MiddleLeft
        btnExport.TextImageRelation = TextImageRelation.ImageBeforeText
        btnExport.UseVisualStyleBackColor = False
        ' 
        ' ptcStelle
        ' 
        ptcStelle.Anchor = AnchorStyles.None
        ptcStelle.BorderStyle = BorderStyle.FixedSingle
        ptcStelle.Image = My.Resources.Resources.Hello
        ptcStelle.Location = New Point(3, 3)
        ptcStelle.Name = "ptcStelle"
        ptcStelle.Size = New Size(267, 395)
        ptcStelle.SizeMode = PictureBoxSizeMode.StretchImage
        ptcStelle.TabIndex = 105
        ptcStelle.TabStop = False
        ' 
        ' pnlDashboard
        ' 
        pnlDashboard.BackColor = Color.FromArgb(CByte(85), CByte(63), CByte(90))
        pnlDashboard.Controls.Add(btnLogout)
        pnlDashboard.Controls.Add(btnSetting)
        pnlDashboard.Controls.Add(pnlMigration)
        pnlDashboard.Controls.Add(btnReview)
        pnlDashboard.Controls.Add(btnPasswords)
        pnlDashboard.Controls.Add(btnHome)
        pnlDashboard.Dock = DockStyle.Left
        pnlDashboard.Location = New Point(0, 0)
        pnlDashboard.Name = "pnlDashboard"
        pnlDashboard.Size = New Size(206, 671)
        pnlDashboard.TabIndex = 13
        ' 
        ' btnLogout
        ' 
        btnLogout.AutoSize = True
        btnLogout.Dock = DockStyle.Bottom
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Segoe UI", 14F)
        btnLogout.ForeColor = Color.White
        btnLogout.Image = My.Resources.Resources.iconSignout
        btnLogout.ImageAlign = ContentAlignment.MiddleLeft
        btnLogout.Location = New Point(0, 603)
        btnLogout.Name = "btnLogout"
        btnLogout.Padding = New Padding(5, 0, 0, 0)
        btnLogout.Size = New Size(206, 68)
        btnLogout.TabIndex = 10
        btnLogout.TabStop = False
        btnLogout.Text = "Logout"
        btnLogout.TextAlign = ContentAlignment.MiddleLeft
        btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' pnlMigration
        ' 
        pnlMigration.AutoSize = True
        pnlMigration.Controls.Add(pnlMigrationOptions)
        pnlMigration.Controls.Add(btnMigration)
        pnlMigration.Dock = DockStyle.Top
        pnlMigration.Location = New Point(0, 204)
        pnlMigration.Name = "pnlMigration"
        pnlMigration.Size = New Size(206, 164)
        pnlMigration.TabIndex = 9
        ' 
        ' pnlMigrationOptions
        ' 
        pnlMigrationOptions.AutoSize = True
        pnlMigrationOptions.Controls.Add(btnExport)
        pnlMigrationOptions.Controls.Add(btnImport)
        pnlMigrationOptions.Dock = DockStyle.Top
        pnlMigrationOptions.Location = New Point(0, 68)
        pnlMigrationOptions.Name = "pnlMigrationOptions"
        pnlMigrationOptions.Size = New Size(206, 96)
        pnlMigrationOptions.TabIndex = 7
        pnlMigrationOptions.Visible = False
        ' 
        ' btnHome
        ' 
        btnHome.AutoSize = True
        btnHome.Dock = DockStyle.Top
        btnHome.FlatAppearance.BorderSize = 0
        btnHome.FlatStyle = FlatStyle.Flat
        btnHome.Font = New Font("Segoe UI", 15F)
        btnHome.ForeColor = Color.White
        btnHome.Image = My.Resources.Resources.iconHome
        btnHome.ImageAlign = ContentAlignment.MiddleLeft
        btnHome.Location = New Point(0, 0)
        btnHome.Name = "btnHome"
        btnHome.Padding = New Padding(5, 0, 0, 0)
        btnHome.Size = New Size(206, 68)
        btnHome.TabIndex = 11
        btnHome.TabStop = False
        btnHome.Text = "Home"
        btnHome.TextAlign = ContentAlignment.MiddleLeft
        btnHome.TextImageRelation = TextImageRelation.ImageBeforeText
        btnHome.UseVisualStyleBackColor = True
        ' 
        ' tmrStelle
        ' 
        tmrStelle.Interval = 1000
        ' 
        ' tmrDisplay
        ' 
        tmrDisplay.Interval = 1000
        ' 
        ' flpStelle
        ' 
        flpStelle.AutoSize = True
        flpStelle.AutoSizeMode = AutoSizeMode.GrowAndShrink
        flpStelle.Controls.Add(ptcStelle)
        flpStelle.FlowDirection = FlowDirection.TopDown
        flpStelle.Location = New Point(3, 3)
        flpStelle.Name = "flpStelle"
        flpStelle.Size = New Size(273, 401)
        flpStelle.TabIndex = 126
        ' 
        ' flpAssistant
        ' 
        flpAssistant.AutoSize = True
        flpAssistant.BackColor = Color.FromArgb(CByte(106), CByte(80), CByte(109))
        flpAssistant.Controls.Add(flpStelle)
        flpAssistant.Controls.Add(txtGreeting)
        flpAssistant.Controls.Add(txtStatus)
        flpAssistant.Dock = DockStyle.Left
        flpAssistant.FlowDirection = FlowDirection.TopDown
        flpAssistant.Location = New Point(206, 0)
        flpAssistant.Name = "flpAssistant"
        flpAssistant.Size = New Size(279, 671)
        flpAssistant.TabIndex = 127
        ' 
        ' txtGreeting
        ' 
        txtGreeting.BackColor = Color.FromArgb(CByte(106), CByte(80), CByte(109))
        txtGreeting.BorderStyle = BorderStyle.None
        txtGreeting.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        txtGreeting.ForeColor = Color.FromArgb(CByte(240), CByte(241), CByte(199))
        txtGreeting.Location = New Point(3, 410)
        txtGreeting.Name = "txtGreeting"
        txtGreeting.ReadOnly = True
        txtGreeting.Size = New Size(269, 41)
        txtGreeting.TabIndex = 305
        txtGreeting.TabStop = False
        txtGreeting.Text = "Hi {user}!"
        ' 
        ' txtStatus
        ' 
        txtStatus.BackColor = Color.FromArgb(CByte(106), CByte(80), CByte(109))
        txtStatus.BorderStyle = BorderStyle.None
        txtStatus.Font = New Font("Segoe UI", 11F)
        txtStatus.ForeColor = Color.FromArgb(CByte(240), CByte(241), CByte(199))
        txtStatus.Location = New Point(3, 457)
        txtStatus.Name = "txtStatus"
        txtStatus.ReadOnly = True
        txtStatus.Size = New Size(269, 130)
        txtStatus.TabIndex = 306
        txtStatus.TabStop = False
        txtStatus.Text = "{status}"
        ' 
        ' Body
        ' 
        AutoScaleDimensions = New SizeF(8F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(60), CByte(51), CByte(81))
        ClientSize = New Size(1009, 671)
        Controls.Add(flpAssistant)
        Controls.Add(pnlDashboard)
        Icon = My.Resources.Resources.Lucky_Stelle
        IsMdiContainer = True
        Name = "Body"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Lucky Stelle"
        CType(ptcStelle, ComponentModel.ISupportInitialize).EndInit()
        pnlDashboard.ResumeLayout(False)
        pnlDashboard.PerformLayout()
        pnlMigration.ResumeLayout(False)
        pnlMigration.PerformLayout()
        pnlMigrationOptions.ResumeLayout(False)
        pnlMigrationOptions.PerformLayout()
        flpStelle.ResumeLayout(False)
        flpAssistant.ResumeLayout(False)
        flpAssistant.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnPasswords As Button
    Friend WithEvents btnSetting As Button
    Friend WithEvents btnMigration As Button
    Friend WithEvents btnReview As Button
    Friend WithEvents btnImport As Button
    Friend WithEvents btnExport As Button
    Friend WithEvents ptcStelle As PictureBox
    Friend WithEvents pnlDashboard As Panel
    Friend WithEvents pnlMigration As Panel
    Friend WithEvents pnlMigrationOptions As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents tmrStelle As Timer
    Friend WithEvents tmrDisplay As Timer
    Friend WithEvents flpStelle As FlowLayoutPanel
    Friend WithEvents flpAssistant As FlowLayoutPanel
    Friend WithEvents btnHome As Button
    Friend WithEvents txtGreeting As RichTextBox
    Friend WithEvents txtStatus As RichTextBox
End Class
