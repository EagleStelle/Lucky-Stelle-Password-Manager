<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Splash
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
        components = New ComponentModel.Container()
        flpWhole = New FlowLayoutPanel()
        flpLogo = New FlowLayoutPanel()
        ptcLogo = New PictureBox()
        flpCopyright = New FlowLayoutPanel()
        lblCopyright = New Label()
        flpLoading = New FlowLayoutPanel()
        prgLoading = New CustomProgressBar()
        flpProgress = New FlowLayoutPanel()
        lblProgress = New Label()
        tmrLoading = New Timer(components)
        flpWhole.SuspendLayout()
        flpLogo.SuspendLayout()
        CType(ptcLogo, ComponentModel.ISupportInitialize).BeginInit()
        flpCopyright.SuspendLayout()
        flpLoading.SuspendLayout()
        flpProgress.SuspendLayout()
        SuspendLayout()
        ' 
        ' flpWhole
        ' 
        flpWhole.AutoSize = True
        flpWhole.AutoSizeMode = AutoSizeMode.GrowAndShrink
        flpWhole.BackColor = Color.Transparent
        flpWhole.Controls.Add(flpLogo)
        flpWhole.Controls.Add(flpCopyright)
        flpWhole.Controls.Add(flpLoading)
        flpWhole.Controls.Add(flpProgress)
        flpWhole.FlowDirection = FlowDirection.TopDown
        flpWhole.Location = New Point(30, 30)
        flpWhole.Name = "flpWhole"
        flpWhole.Size = New Size(396, 529)
        flpWhole.TabIndex = 0
        ' 
        ' flpLogo
        ' 
        flpLogo.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        flpLogo.AutoSize = True
        flpLogo.AutoSizeMode = AutoSizeMode.GrowAndShrink
        flpLogo.Controls.Add(ptcLogo)
        flpLogo.Location = New Point(3, 3)
        flpLogo.Name = "flpLogo"
        flpLogo.Size = New Size(390, 390)
        flpLogo.TabIndex = 2
        ' 
        ' ptcLogo
        ' 
        ptcLogo.Image = My.Resources.Resources.logoSimple
        ptcLogo.Location = New Point(3, 3)
        ptcLogo.Name = "ptcLogo"
        ptcLogo.Size = New Size(384, 384)
        ptcLogo.SizeMode = PictureBoxSizeMode.StretchImage
        ptcLogo.TabIndex = 1
        ptcLogo.TabStop = False
        ' 
        ' flpCopyright
        ' 
        flpCopyright.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        flpCopyright.AutoSize = True
        flpCopyright.AutoSizeMode = AutoSizeMode.GrowAndShrink
        flpCopyright.Controls.Add(lblCopyright)
        flpCopyright.Location = New Point(66, 399)
        flpCopyright.Name = "flpCopyright"
        flpCopyright.Size = New Size(264, 45)
        flpCopyright.TabIndex = 4
        ' 
        ' lblCopyright
        ' 
        lblCopyright.AutoSize = True
        lblCopyright.Font = New Font("Segoe UI", 14F)
        lblCopyright.ForeColor = Color.White
        lblCopyright.Location = New Point(3, 0)
        lblCopyright.Name = "lblCopyright"
        lblCopyright.Padding = New Padding(0, 20, 0, 0)
        lblCopyright.Size = New Size(258, 45)
        lblCopyright.TabIndex = 3
        lblCopyright.Text = "Copyright © 2024 EagleStelle"
        ' 
        ' flpLoading
        ' 
        flpLoading.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        flpLoading.AutoSize = True
        flpLoading.AutoSizeMode = AutoSizeMode.GrowAndShrink
        flpLoading.Controls.Add(prgLoading)
        flpLoading.Location = New Point(3, 450)
        flpLoading.Name = "flpLoading"
        flpLoading.Padding = New Padding(0, 20, 0, 0)
        flpLoading.Size = New Size(390, 49)
        flpLoading.TabIndex = 6
        ' 
        ' prgLoading
        ' 
        prgLoading.BackColor = Color.Black
        prgLoading.ForeColor = Color.White
        prgLoading.Location = New Point(3, 23)
        prgLoading.Name = "prgLoading"
        prgLoading.Size = New Size(384, 23)
        prgLoading.TabIndex = 1
        ' 
        ' flpProgress
        ' 
        flpProgress.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        flpProgress.AutoSize = True
        flpProgress.AutoSizeMode = AutoSizeMode.GrowAndShrink
        flpProgress.Controls.Add(lblProgress)
        flpProgress.Location = New Point(179, 505)
        flpProgress.Name = "flpProgress"
        flpProgress.Size = New Size(38, 21)
        flpProgress.TabIndex = 7
        ' 
        ' lblProgress
        ' 
        lblProgress.AutoSize = True
        lblProgress.Font = New Font("Segoe UI", 12F)
        lblProgress.ForeColor = Color.White
        lblProgress.Location = New Point(3, 0)
        lblProgress.Name = "lblProgress"
        lblProgress.Size = New Size(32, 21)
        lblProgress.TabIndex = 3
        lblProgress.Text = "0%"
        ' 
        ' tmrLoading
        ' 
        tmrLoading.Interval = 10
        ' 
        ' Splash
        ' 
        AutoScaleDimensions = New SizeF(8F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        BackgroundImage = My.Resources.Resources.backgroundSplash
        ClientSize = New Size(460, 580)
        Controls.Add(flpWhole)
        FormBorderStyle = FormBorderStyle.None
        Icon = My.Resources.Resources.Lucky_Stelle
        Name = "Splash"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Splash"
        flpWhole.ResumeLayout(False)
        flpWhole.PerformLayout()
        flpLogo.ResumeLayout(False)
        CType(ptcLogo, ComponentModel.ISupportInitialize).EndInit()
        flpCopyright.ResumeLayout(False)
        flpCopyright.PerformLayout()
        flpLoading.ResumeLayout(False)
        flpProgress.ResumeLayout(False)
        flpProgress.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents flpWhole As FlowLayoutPanel
    Friend WithEvents flpLogo As FlowLayoutPanel
    Friend WithEvents ptcLogo As PictureBox
    Friend WithEvents lblCopyright As Label
    Friend WithEvents flpCopyright As FlowLayoutPanel
    Friend WithEvents flpLoading As FlowLayoutPanel
    Friend WithEvents flpProgress As FlowLayoutPanel
    Friend WithEvents lblProgress As Label
    Friend WithEvents tmrLoading As Timer
    Friend WithEvents prgLoading As CustomProgressBar
End Class
