<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QRCode
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
        flpQRCode = New FlowLayoutPanel()
        ptcQRCode = New PictureBox()
        FlowLayoutPanel3 = New FlowLayoutPanel()
        PictureBox2 = New PictureBox()
        FlowLayoutPanel4 = New FlowLayoutPanel()
        txtStelleCode = New TextBox()
        btnSubmit = New CustomButton()
        flpQRCode.SuspendLayout()
        CType(ptcQRCode, ComponentModel.ISupportInitialize).BeginInit()
        FlowLayoutPanel3.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        FlowLayoutPanel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' flpQRCode
        ' 
        flpQRCode.AutoSize = True
        flpQRCode.AutoSizeMode = AutoSizeMode.GrowAndShrink
        flpQRCode.BackColor = Color.Transparent
        flpQRCode.Controls.Add(ptcQRCode)
        flpQRCode.Controls.Add(FlowLayoutPanel3)
        flpQRCode.Controls.Add(btnSubmit)
        flpQRCode.FlowDirection = FlowDirection.TopDown
        flpQRCode.Location = New Point(30, 30)
        flpQRCode.Margin = New Padding(3, 4, 3, 4)
        flpQRCode.Name = "flpQRCode"
        flpQRCode.Size = New Size(309, 394)
        flpQRCode.TabIndex = 301
        ' 
        ' ptcQRCode
        ' 
        ptcQRCode.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        ptcQRCode.Location = New Point(3, 4)
        ptcQRCode.Margin = New Padding(3, 4, 3, 4)
        ptcQRCode.Name = "ptcQRCode"
        ptcQRCode.Size = New Size(303, 303)
        ptcQRCode.SizeMode = PictureBoxSizeMode.StretchImage
        ptcQRCode.TabIndex = 108
        ptcQRCode.TabStop = False
        ' 
        ' FlowLayoutPanel3
        ' 
        FlowLayoutPanel3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        FlowLayoutPanel3.AutoSize = True
        FlowLayoutPanel3.BackColor = Color.AliceBlue
        FlowLayoutPanel3.Controls.Add(PictureBox2)
        FlowLayoutPanel3.Controls.Add(FlowLayoutPanel4)
        FlowLayoutPanel3.ForeColor = Color.Black
        FlowLayoutPanel3.Location = New Point(3, 314)
        FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        FlowLayoutPanel3.Size = New Size(303, 36)
        FlowLayoutPanel3.TabIndex = 302
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.iconCode
        PictureBox2.Location = New Point(3, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(30, 30)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 114
        PictureBox2.TabStop = False
        ' 
        ' FlowLayoutPanel4
        ' 
        FlowLayoutPanel4.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        FlowLayoutPanel4.AutoSize = True
        FlowLayoutPanel4.BackColor = Color.Transparent
        FlowLayoutPanel4.Controls.Add(txtStelleCode)
        FlowLayoutPanel4.FlowDirection = FlowDirection.TopDown
        FlowLayoutPanel4.Location = New Point(39, 4)
        FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        FlowLayoutPanel4.Size = New Size(261, 27)
        FlowLayoutPanel4.TabIndex = 115
        ' 
        ' txtStelleCode
        ' 
        txtStelleCode.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        txtStelleCode.BackColor = Color.AliceBlue
        txtStelleCode.BorderStyle = BorderStyle.None
        txtStelleCode.ForeColor = Color.Black
        txtStelleCode.Location = New Point(3, 4)
        txtStelleCode.Margin = New Padding(3, 4, 3, 4)
        txtStelleCode.Name = "txtStelleCode"
        txtStelleCode.ReadOnly = True
        txtStelleCode.Size = New Size(255, 19)
        txtStelleCode.TabIndex = 300
        txtStelleCode.TabStop = False
        txtStelleCode.Text = "Stelle Code"
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        btnSubmit.BackColor = Color.Moccasin
        btnSubmit.BorderRadius = 20
        btnSubmit.FlatAppearance.BorderSize = 0
        btnSubmit.FlatStyle = FlatStyle.Flat
        btnSubmit.Font = New Font("Segoe UI", 12F)
        btnSubmit.HoverBackColor = Color.White
        btnSubmit.HoverForeColor = Color.Navy
        btnSubmit.Location = New Point(3, 356)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(303, 35)
        btnSubmit.SoundClick = "click"
        btnSubmit.SoundHover = "hover"
        btnSubmit.TabIndex = 302
        btnSubmit.TabStop = False
        btnSubmit.Text = "&Submit"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' QRCode
        ' 
        AcceptButton = btnSubmit
        AutoScaleDimensions = New SizeF(8F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.backgroundRegister
        ClientSize = New Size(368, 450)
        Controls.Add(flpQRCode)
        Icon = My.Resources.Resources.Lucky_Stelle
        Name = "QRCode"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Lucky Stelle"
        flpQRCode.ResumeLayout(False)
        flpQRCode.PerformLayout()
        CType(ptcQRCode, ComponentModel.ISupportInitialize).EndInit()
        FlowLayoutPanel3.ResumeLayout(False)
        FlowLayoutPanel3.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        FlowLayoutPanel4.ResumeLayout(False)
        FlowLayoutPanel4.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents flpQRCode As FlowLayoutPanel
    Friend WithEvents ptcQRCode As PictureBox
    Friend WithEvents btnSubmit As CustomButton
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents FlowLayoutPanel4 As FlowLayoutPanel
    Friend WithEvents txtStelleCode As TextBox
End Class
