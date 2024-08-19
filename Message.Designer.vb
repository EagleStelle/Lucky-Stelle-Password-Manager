<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Message
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
        flpMain = New FlowLayoutPanel()
        flpField = New FlowLayoutPanel()
        ptcField = New PictureBox()
        FlowLayoutPanel3 = New FlowLayoutPanel()
        txtField = New TextBox()
        flpVerify = New FlowLayoutPanel()
        ptcVerify = New PictureBox()
        FlowLayoutPanel5 = New FlowLayoutPanel()
        txtVerify = New TextBox()
        flpWhole = New FlowLayoutPanel()
        flpExtra = New FlowLayoutPanel()
        flpEmail = New FlowLayoutPanel()
        ptcEmail = New PictureBox()
        FlowLayoutPanel6 = New FlowLayoutPanel()
        txtEmail = New TextBox()
        flpPassword = New FlowLayoutPanel()
        PictureBox4 = New PictureBox()
        FlowLayoutPanel9 = New FlowLayoutPanel()
        txtPassword = New TextBox()
        flpButton = New FlowLayoutPanel()
        btnOK = New Button()
        pnlSuggest = New Panel()
        trkLength = New CustomTrackBar()
        lblPasswordLength = New Label()
        btnSuggest = New Button()
        btnCancel = New Button()
        flpMain.SuspendLayout()
        flpField.SuspendLayout()
        CType(ptcField, ComponentModel.ISupportInitialize).BeginInit()
        FlowLayoutPanel3.SuspendLayout()
        flpVerify.SuspendLayout()
        CType(ptcVerify, ComponentModel.ISupportInitialize).BeginInit()
        FlowLayoutPanel5.SuspendLayout()
        flpWhole.SuspendLayout()
        flpExtra.SuspendLayout()
        flpEmail.SuspendLayout()
        CType(ptcEmail, ComponentModel.ISupportInitialize).BeginInit()
        FlowLayoutPanel6.SuspendLayout()
        flpPassword.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        FlowLayoutPanel9.SuspendLayout()
        flpButton.SuspendLayout()
        pnlSuggest.SuspendLayout()
        CType(trkLength, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' flpMain
        ' 
        flpMain.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        flpMain.AutoSize = True
        flpMain.AutoSizeMode = AutoSizeMode.GrowAndShrink
        flpMain.Controls.Add(flpField)
        flpMain.Controls.Add(flpVerify)
        flpMain.FlowDirection = FlowDirection.TopDown
        flpMain.Location = New Point(3, 3)
        flpMain.Name = "flpMain"
        flpMain.Size = New Size(309, 84)
        flpMain.TabIndex = 101
        ' 
        ' flpField
        ' 
        flpField.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        flpField.AutoSize = True
        flpField.AutoSizeMode = AutoSizeMode.GrowAndShrink
        flpField.BackColor = Color.FromArgb(CByte(240), CByte(241), CByte(199))
        flpField.Controls.Add(ptcField)
        flpField.Controls.Add(FlowLayoutPanel3)
        flpField.ForeColor = Color.Black
        flpField.Location = New Point(3, 3)
        flpField.Name = "flpField"
        flpField.Size = New Size(303, 36)
        flpField.TabIndex = 101
        ' 
        ' ptcField
        ' 
        ptcField.Image = My.Resources.Resources.iconPassword
        ptcField.Location = New Point(3, 3)
        ptcField.Name = "ptcField"
        ptcField.Size = New Size(30, 30)
        ptcField.SizeMode = PictureBoxSizeMode.StretchImage
        ptcField.TabIndex = 114
        ptcField.TabStop = False
        ' 
        ' FlowLayoutPanel3
        ' 
        FlowLayoutPanel3.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        FlowLayoutPanel3.AutoSize = True
        FlowLayoutPanel3.AutoSizeMode = AutoSizeMode.GrowAndShrink
        FlowLayoutPanel3.BackColor = Color.Transparent
        FlowLayoutPanel3.Controls.Add(txtField)
        FlowLayoutPanel3.FlowDirection = FlowDirection.TopDown
        FlowLayoutPanel3.Location = New Point(39, 4)
        FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        FlowLayoutPanel3.Size = New Size(261, 27)
        FlowLayoutPanel3.TabIndex = 115
        ' 
        ' txtField
        ' 
        txtField.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        txtField.BackColor = Color.FromArgb(CByte(240), CByte(241), CByte(199))
        txtField.BorderStyle = BorderStyle.None
        txtField.ForeColor = Color.Black
        txtField.Location = New Point(3, 4)
        txtField.Margin = New Padding(3, 4, 3, 4)
        txtField.Name = "txtField"
        txtField.Size = New Size(255, 19)
        txtField.TabIndex = 101
        txtField.Text = "Field"
        ' 
        ' flpVerify
        ' 
        flpVerify.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        flpVerify.AutoSize = True
        flpVerify.AutoSizeMode = AutoSizeMode.GrowAndShrink
        flpVerify.BackColor = Color.FromArgb(CByte(240), CByte(241), CByte(199))
        flpVerify.Controls.Add(ptcVerify)
        flpVerify.Controls.Add(FlowLayoutPanel5)
        flpVerify.ForeColor = Color.Black
        flpVerify.Location = New Point(3, 45)
        flpVerify.Name = "flpVerify"
        flpVerify.Size = New Size(303, 36)
        flpVerify.TabIndex = 102
        ' 
        ' ptcVerify
        ' 
        ptcVerify.Image = My.Resources.Resources.iconCode
        ptcVerify.Location = New Point(3, 3)
        ptcVerify.Name = "ptcVerify"
        ptcVerify.Size = New Size(30, 30)
        ptcVerify.SizeMode = PictureBoxSizeMode.StretchImage
        ptcVerify.TabIndex = 114
        ptcVerify.TabStop = False
        ' 
        ' FlowLayoutPanel5
        ' 
        FlowLayoutPanel5.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        FlowLayoutPanel5.AutoSize = True
        FlowLayoutPanel5.AutoSizeMode = AutoSizeMode.GrowAndShrink
        FlowLayoutPanel5.BackColor = Color.Transparent
        FlowLayoutPanel5.Controls.Add(txtVerify)
        FlowLayoutPanel5.FlowDirection = FlowDirection.TopDown
        FlowLayoutPanel5.Location = New Point(39, 4)
        FlowLayoutPanel5.Name = "FlowLayoutPanel5"
        FlowLayoutPanel5.Size = New Size(261, 27)
        FlowLayoutPanel5.TabIndex = 115
        ' 
        ' txtVerify
        ' 
        txtVerify.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        txtVerify.BackColor = Color.FromArgb(CByte(240), CByte(241), CByte(199))
        txtVerify.BorderStyle = BorderStyle.None
        txtVerify.ForeColor = Color.Black
        txtVerify.Location = New Point(3, 4)
        txtVerify.Margin = New Padding(3, 4, 3, 4)
        txtVerify.Name = "txtVerify"
        txtVerify.Size = New Size(255, 19)
        txtVerify.TabIndex = 102
        txtVerify.Text = "Verify"
        ' 
        ' flpWhole
        ' 
        flpWhole.AutoSize = True
        flpWhole.AutoSizeMode = AutoSizeMode.GrowAndShrink
        flpWhole.Controls.Add(flpMain)
        flpWhole.Controls.Add(flpExtra)
        flpWhole.Controls.Add(flpButton)
        flpWhole.FlowDirection = FlowDirection.TopDown
        flpWhole.Location = New Point(30, 30)
        flpWhole.Name = "flpWhole"
        flpWhole.Size = New Size(315, 377)
        flpWhole.TabIndex = 142
        ' 
        ' flpExtra
        ' 
        flpExtra.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        flpExtra.AutoSize = True
        flpExtra.AutoSizeMode = AutoSizeMode.GrowAndShrink
        flpExtra.Controls.Add(flpEmail)
        flpExtra.Controls.Add(flpPassword)
        flpExtra.FlowDirection = FlowDirection.TopDown
        flpExtra.Location = New Point(3, 93)
        flpExtra.Name = "flpExtra"
        flpExtra.Size = New Size(309, 84)
        flpExtra.TabIndex = 103
        ' 
        ' flpEmail
        ' 
        flpEmail.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        flpEmail.AutoSize = True
        flpEmail.AutoSizeMode = AutoSizeMode.GrowAndShrink
        flpEmail.BackColor = Color.FromArgb(CByte(240), CByte(241), CByte(199))
        flpEmail.Controls.Add(ptcEmail)
        flpEmail.Controls.Add(FlowLayoutPanel6)
        flpEmail.ForeColor = Color.Black
        flpEmail.Location = New Point(3, 3)
        flpEmail.Name = "flpEmail"
        flpEmail.Size = New Size(303, 36)
        flpEmail.TabIndex = 100
        ' 
        ' ptcEmail
        ' 
        ptcEmail.Image = My.Resources.Resources.iconEmail
        ptcEmail.Location = New Point(3, 3)
        ptcEmail.Name = "ptcEmail"
        ptcEmail.Size = New Size(30, 30)
        ptcEmail.SizeMode = PictureBoxSizeMode.StretchImage
        ptcEmail.TabIndex = 114
        ptcEmail.TabStop = False
        ' 
        ' FlowLayoutPanel6
        ' 
        FlowLayoutPanel6.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        FlowLayoutPanel6.AutoSize = True
        FlowLayoutPanel6.AutoSizeMode = AutoSizeMode.GrowAndShrink
        FlowLayoutPanel6.BackColor = Color.Transparent
        FlowLayoutPanel6.Controls.Add(txtEmail)
        FlowLayoutPanel6.FlowDirection = FlowDirection.TopDown
        FlowLayoutPanel6.Location = New Point(39, 4)
        FlowLayoutPanel6.Name = "FlowLayoutPanel6"
        FlowLayoutPanel6.Size = New Size(261, 27)
        FlowLayoutPanel6.TabIndex = 115
        ' 
        ' txtEmail
        ' 
        txtEmail.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        txtEmail.BackColor = Color.FromArgb(CByte(240), CByte(241), CByte(199))
        txtEmail.BorderStyle = BorderStyle.None
        txtEmail.ForeColor = Color.Black
        txtEmail.Location = New Point(3, 4)
        txtEmail.Margin = New Padding(3, 4, 3, 4)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(255, 19)
        txtEmail.TabIndex = 103
        txtEmail.Text = "Email"
        ' 
        ' flpPassword
        ' 
        flpPassword.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        flpPassword.AutoSize = True
        flpPassword.AutoSizeMode = AutoSizeMode.GrowAndShrink
        flpPassword.BackColor = Color.FromArgb(CByte(240), CByte(241), CByte(199))
        flpPassword.Controls.Add(PictureBox4)
        flpPassword.Controls.Add(FlowLayoutPanel9)
        flpPassword.ForeColor = Color.Black
        flpPassword.Location = New Point(3, 45)
        flpPassword.Name = "flpPassword"
        flpPassword.Size = New Size(303, 36)
        flpPassword.TabIndex = 100
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = My.Resources.Resources.iconPassword
        PictureBox4.Location = New Point(3, 3)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(30, 30)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 114
        PictureBox4.TabStop = False
        ' 
        ' FlowLayoutPanel9
        ' 
        FlowLayoutPanel9.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        FlowLayoutPanel9.AutoSize = True
        FlowLayoutPanel9.AutoSizeMode = AutoSizeMode.GrowAndShrink
        FlowLayoutPanel9.BackColor = Color.Transparent
        FlowLayoutPanel9.Controls.Add(txtPassword)
        FlowLayoutPanel9.FlowDirection = FlowDirection.TopDown
        FlowLayoutPanel9.Location = New Point(39, 4)
        FlowLayoutPanel9.Name = "FlowLayoutPanel9"
        FlowLayoutPanel9.Size = New Size(261, 27)
        FlowLayoutPanel9.TabIndex = 100
        ' 
        ' txtPassword
        ' 
        txtPassword.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        txtPassword.BackColor = Color.FromArgb(CByte(240), CByte(241), CByte(199))
        txtPassword.BorderStyle = BorderStyle.None
        txtPassword.ForeColor = Color.Black
        txtPassword.Location = New Point(3, 4)
        txtPassword.Margin = New Padding(3, 4, 3, 4)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(255, 19)
        txtPassword.TabIndex = 100
        txtPassword.Text = "Password"
        ' 
        ' flpButton
        ' 
        flpButton.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        flpButton.AutoSize = True
        flpButton.AutoSizeMode = AutoSizeMode.GrowAndShrink
        flpButton.Controls.Add(btnOK)
        flpButton.Controls.Add(pnlSuggest)
        flpButton.Controls.Add(btnCancel)
        flpButton.FlowDirection = FlowDirection.TopDown
        flpButton.Location = New Point(3, 183)
        flpButton.Name = "flpButton"
        flpButton.Size = New Size(309, 191)
        flpButton.TabIndex = 143
        ' 
        ' btnOK
        ' 
        btnOK.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        btnOK.AutoSize = True
        btnOK.BackColor = Color.FromArgb(CByte(255), CByte(223), CByte(122))
        btnOK.FlatStyle = FlatStyle.Flat
        btnOK.ForeColor = Color.Black
        btnOK.Location = New Point(3, 4)
        btnOK.Margin = New Padding(3, 4, 3, 4)
        btnOK.Name = "btnOK"
        btnOK.Size = New Size(303, 35)
        btnOK.TabIndex = 111
        btnOK.TabStop = False
        btnOK.Text = "OK"
        btnOK.UseVisualStyleBackColor = False
        ' 
        ' pnlSuggest
        ' 
        pnlSuggest.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        pnlSuggest.AutoSize = True
        pnlSuggest.Controls.Add(trkLength)
        pnlSuggest.Controls.Add(lblPasswordLength)
        pnlSuggest.Controls.Add(btnSuggest)
        pnlSuggest.Location = New Point(3, 46)
        pnlSuggest.Name = "pnlSuggest"
        pnlSuggest.Size = New Size(303, 99)
        pnlSuggest.TabIndex = 209
        pnlSuggest.Visible = False
        ' 
        ' trkLength
        ' 
        trkLength.Dock = DockStyle.Top
        trkLength.LargeChange = 10
        trkLength.Location = New Point(0, 54)
        trkLength.Maximum = 100
        trkLength.Minimum = 10
        trkLength.Name = "trkLength"
        trkLength.Size = New Size(303, 45)
        trkLength.SmallChange = 0
        trkLength.TabIndex = 206
        trkLength.TabStop = False
        trkLength.ThumbColor = Color.FromArgb(CByte(106), CByte(80), CByte(109))
        trkLength.TickColor = Color.FromArgb(CByte(174), CByte(107), CByte(107))
        trkLength.TickFrequency = 10
        trkLength.TrackLineColor = Color.FromArgb(CByte(240), CByte(241), CByte(199))
        trkLength.Value = 10
        ' 
        ' lblPasswordLength
        ' 
        lblPasswordLength.AutoSize = True
        lblPasswordLength.Dock = DockStyle.Top
        lblPasswordLength.Location = New Point(0, 35)
        lblPasswordLength.Name = "lblPasswordLength"
        lblPasswordLength.Size = New Size(137, 19)
        lblPasswordLength.TabIndex = 206
        lblPasswordLength.Text = "Password Length: 10"
        ' 
        ' btnSuggest
        ' 
        btnSuggest.BackColor = Color.FromArgb(CByte(106), CByte(80), CByte(109))
        btnSuggest.Dock = DockStyle.Top
        btnSuggest.FlatAppearance.BorderSize = 0
        btnSuggest.FlatStyle = FlatStyle.Flat
        btnSuggest.Location = New Point(0, 0)
        btnSuggest.Margin = New Padding(3, 4, 3, 4)
        btnSuggest.Name = "btnSuggest"
        btnSuggest.Size = New Size(303, 35)
        btnSuggest.TabIndex = 207
        btnSuggest.TabStop = False
        btnSuggest.Text = "Suggest Password"
        btnSuggest.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        btnCancel.BackColor = Color.FromArgb(CByte(174), CByte(107), CByte(107))
        btnCancel.FlatAppearance.BorderSize = 0
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Location = New Point(3, 152)
        btnCancel.Margin = New Padding(3, 4, 3, 4)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(303, 35)
        btnCancel.TabIndex = 208
        btnCancel.TabStop = False
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' Message
        ' 
        AcceptButton = btnOK
        AutoScaleDimensions = New SizeF(8F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(20), CByte(11), CByte(41))
        CancelButton = btnCancel
        ClientSize = New Size(380, 447)
        Controls.Add(flpWhole)
        ForeColor = Color.White
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = My.Resources.Resources.Lucky_Stelle
        MaximizeBox = False
        MinimizeBox = False
        Name = "Message"
        StartPosition = FormStartPosition.CenterScreen
        flpMain.ResumeLayout(False)
        flpMain.PerformLayout()
        flpField.ResumeLayout(False)
        flpField.PerformLayout()
        CType(ptcField, ComponentModel.ISupportInitialize).EndInit()
        FlowLayoutPanel3.ResumeLayout(False)
        FlowLayoutPanel3.PerformLayout()
        flpVerify.ResumeLayout(False)
        flpVerify.PerformLayout()
        CType(ptcVerify, ComponentModel.ISupportInitialize).EndInit()
        FlowLayoutPanel5.ResumeLayout(False)
        FlowLayoutPanel5.PerformLayout()
        flpWhole.ResumeLayout(False)
        flpWhole.PerformLayout()
        flpExtra.ResumeLayout(False)
        flpExtra.PerformLayout()
        flpEmail.ResumeLayout(False)
        flpEmail.PerformLayout()
        CType(ptcEmail, ComponentModel.ISupportInitialize).EndInit()
        FlowLayoutPanel6.ResumeLayout(False)
        FlowLayoutPanel6.PerformLayout()
        flpPassword.ResumeLayout(False)
        flpPassword.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        FlowLayoutPanel9.ResumeLayout(False)
        FlowLayoutPanel9.PerformLayout()
        flpButton.ResumeLayout(False)
        flpButton.PerformLayout()
        pnlSuggest.ResumeLayout(False)
        pnlSuggest.PerformLayout()
        CType(trkLength, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents flpLabel As FlowLayoutPanel
    Friend WithEvents lblAccount As Label
    Friend WithEvents lbl As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents flpMain As FlowLayoutPanel
    Friend WithEvents flpWhole As FlowLayoutPanel
    Friend WithEvents flpField As FlowLayoutPanel
    Friend WithEvents ptcField As PictureBox
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents txtField As TextBox
    Friend WithEvents flpVerify As FlowLayoutPanel
    Friend WithEvents ptcVerify As PictureBox
    Friend WithEvents FlowLayoutPanel5 As FlowLayoutPanel
    Friend WithEvents txtVerify As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents flpEmail As FlowLayoutPanel
    Friend WithEvents ptcEmail As PictureBox
    Friend WithEvents FlowLayoutPanel6 As FlowLayoutPanel
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents flpExtra As FlowLayoutPanel
    Friend WithEvents flpPassword As FlowLayoutPanel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents FlowLayoutPanel9 As FlowLayoutPanel
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents flpButton As FlowLayoutPanel
    Friend WithEvents btnSuggest As Button
    Friend WithEvents lblPasswordLength As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents pnlSuggest As Panel
    Friend WithEvents btnOK As Button
    Friend WithEvents trkLength As CustomTrackBar
End Class
