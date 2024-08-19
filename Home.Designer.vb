<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        flpDisplay = New FlowLayoutPanel()
        flpLogo = New FlowLayoutPanel()
        ptcLogo = New PictureBox()
        flpLabel = New FlowLayoutPanel()
        flpTitle = New FlowLayoutPanel()
        Label5 = New Label()
        flpTagline = New FlowLayoutPanel()
        Label6 = New Label()
        FlowLayoutPanel2 = New FlowLayoutPanel()
        Label1 = New Label()
        flpHome = New FlowLayoutPanel()
        flpRecent = New FlowLayoutPanel()
        lblRecent = New Label()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        lblAttempts = New Label()
        flpDisplay.SuspendLayout()
        flpLogo.SuspendLayout()
        CType(ptcLogo, ComponentModel.ISupportInitialize).BeginInit()
        flpLabel.SuspendLayout()
        flpTitle.SuspendLayout()
        flpTagline.SuspendLayout()
        FlowLayoutPanel2.SuspendLayout()
        flpHome.SuspendLayout()
        flpRecent.SuspendLayout()
        FlowLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' flpDisplay
        ' 
        flpDisplay.AutoSize = True
        flpDisplay.AutoSizeMode = AutoSizeMode.GrowAndShrink
        flpDisplay.Controls.Add(flpLogo)
        flpDisplay.Controls.Add(flpLabel)
        flpDisplay.ForeColor = SystemColors.ControlText
        flpDisplay.Location = New Point(3, 3)
        flpDisplay.Name = "flpDisplay"
        flpDisplay.Size = New Size(389, 141)
        flpDisplay.TabIndex = 131
        ' 
        ' flpLogo
        ' 
        flpLogo.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        flpLogo.AutoSize = True
        flpLogo.Controls.Add(ptcLogo)
        flpLogo.Location = New Point(3, 4)
        flpLogo.Margin = New Padding(3, 4, 3, 4)
        flpLogo.Name = "flpLogo"
        flpLogo.Size = New Size(131, 133)
        flpLogo.TabIndex = 120
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
        ' flpLabel
        ' 
        flpLabel.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        flpLabel.AutoSize = True
        flpLabel.AutoSizeMode = AutoSizeMode.GrowAndShrink
        flpLabel.Controls.Add(flpTitle)
        flpLabel.Controls.Add(flpTagline)
        flpLabel.Controls.Add(FlowLayoutPanel2)
        flpLabel.FlowDirection = FlowDirection.TopDown
        flpLabel.Location = New Point(140, 12)
        flpLabel.Margin = New Padding(3, 4, 3, 4)
        flpLabel.Name = "flpLabel"
        flpLabel.Size = New Size(246, 116)
        flpLabel.TabIndex = 121
        ' 
        ' flpTitle
        ' 
        flpTitle.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        flpTitle.AutoSize = True
        flpTitle.AutoSizeMode = AutoSizeMode.GrowAndShrink
        flpTitle.BackColor = Color.Transparent
        flpTitle.Controls.Add(Label5)
        flpTitle.Location = New Point(3, 3)
        flpTitle.Name = "flpTitle"
        flpTitle.Size = New Size(240, 38)
        flpTitle.TabIndex = 121
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Verdana", 24F, FontStyle.Bold)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(3, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(234, 38)
        Label5.TabIndex = 115
        Label5.Text = "Lucky Stelle"
        Label5.TextAlign = ContentAlignment.TopCenter
        ' 
        ' flpTagline
        ' 
        flpTagline.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        flpTagline.AutoSize = True
        flpTagline.AutoSizeMode = AutoSizeMode.GrowAndShrink
        flpTagline.Controls.Add(Label6)
        flpTagline.Location = New Point(4, 47)
        flpTagline.Name = "flpTagline"
        flpTagline.Size = New Size(237, 20)
        flpTagline.TabIndex = 15
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 11F)
        Label6.ForeColor = Color.AliceBlue
        Label6.Location = New Point(3, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(231, 20)
        Label6.TabIndex = 1
        Label6.Text = "Secure Your Luck with Every Login"
        ' 
        ' FlowLayoutPanel2
        ' 
        FlowLayoutPanel2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        FlowLayoutPanel2.AutoSize = True
        FlowLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink
        FlowLayoutPanel2.Controls.Add(Label1)
        FlowLayoutPanel2.Location = New Point(15, 73)
        FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        FlowLayoutPanel2.Size = New Size(215, 40)
        FlowLayoutPanel2.TabIndex = 16
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11F)
        Label1.ForeColor = Color.AliceBlue
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Padding = New Padding(0, 20, 0, 0)
        Label1.Size = New Size(209, 40)
        Label1.TabIndex = 1
        Label1.Text = "Copyright © 2024 Eagle Stelle"
        ' 
        ' flpHome
        ' 
        flpHome.AutoSize = True
        flpHome.AutoSizeMode = AutoSizeMode.GrowAndShrink
        flpHome.Controls.Add(flpDisplay)
        flpHome.Controls.Add(flpRecent)
        flpHome.Controls.Add(FlowLayoutPanel1)
        flpHome.FlowDirection = FlowDirection.TopDown
        flpHome.Location = New Point(0, 0)
        flpHome.Margin = New Padding(3, 4, 3, 4)
        flpHome.Name = "flpHome"
        flpHome.Size = New Size(395, 230)
        flpHome.TabIndex = 132
        ' 
        ' flpRecent
        ' 
        flpRecent.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        flpRecent.AutoSize = True
        flpRecent.AutoSizeMode = AutoSizeMode.GrowAndShrink
        flpRecent.Controls.Add(lblRecent)
        flpRecent.Location = New Point(194, 151)
        flpRecent.Margin = New Padding(3, 4, 3, 4)
        flpRecent.Name = "flpRecent"
        flpRecent.Size = New Size(6, 46)
        flpRecent.TabIndex = 132
        ' 
        ' lblRecent
        ' 
        lblRecent.AutoSize = True
        lblRecent.Font = New Font("Segoe UI", 12F)
        lblRecent.Location = New Point(3, 0)
        lblRecent.Name = "lblRecent"
        lblRecent.Padding = New Padding(0, 25, 0, 0)
        lblRecent.Size = New Size(0, 46)
        lblRecent.TabIndex = 132
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        FlowLayoutPanel1.AutoSize = True
        FlowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        FlowLayoutPanel1.Controls.Add(lblAttempts)
        FlowLayoutPanel1.Location = New Point(194, 205)
        FlowLayoutPanel1.Margin = New Padding(3, 4, 3, 4)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(6, 21)
        FlowLayoutPanel1.TabIndex = 133
        ' 
        ' lblAttempts
        ' 
        lblAttempts.AutoSize = True
        lblAttempts.Font = New Font("Segoe UI", 12F)
        lblAttempts.ForeColor = Color.FromArgb(CByte(204), CByte(137), CByte(137))
        lblAttempts.Location = New Point(3, 0)
        lblAttempts.Name = "lblAttempts"
        lblAttempts.Size = New Size(0, 21)
        lblAttempts.TabIndex = 132
        ' 
        ' Home
        ' 
        AutoScaleDimensions = New SizeF(8F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = Color.FromArgb(CByte(60), CByte(51), CByte(81))
        ClientSize = New Size(395, 236)
        Controls.Add(flpHome)
        ForeColor = Color.White
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "Home"
        StartPosition = FormStartPosition.CenterParent
        Text = "Home"
        flpDisplay.ResumeLayout(False)
        flpDisplay.PerformLayout()
        flpLogo.ResumeLayout(False)
        CType(ptcLogo, ComponentModel.ISupportInitialize).EndInit()
        flpLabel.ResumeLayout(False)
        flpLabel.PerformLayout()
        flpTitle.ResumeLayout(False)
        flpTitle.PerformLayout()
        flpTagline.ResumeLayout(False)
        flpTagline.PerformLayout()
        FlowLayoutPanel2.ResumeLayout(False)
        FlowLayoutPanel2.PerformLayout()
        flpHome.ResumeLayout(False)
        flpHome.PerformLayout()
        flpRecent.ResumeLayout(False)
        flpRecent.PerformLayout()
        FlowLayoutPanel1.ResumeLayout(False)
        FlowLayoutPanel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents flpDisplay As FlowLayoutPanel
    Friend WithEvents flpLogo As FlowLayoutPanel
    Friend WithEvents ptcLogo As PictureBox
    Friend WithEvents flpTitle As FlowLayoutPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents flpTagline As FlowLayoutPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents flpLabel As FlowLayoutPanel
    Friend WithEvents flpHome As FlowLayoutPanel
    Friend WithEvents flpRecent As FlowLayoutPanel
    Friend WithEvents lblRecent As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents lblAttempts As Label
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents Label1 As Label
End Class
