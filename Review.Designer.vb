<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Review
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
        flpReview = New FlowLayoutPanel()
        lsvReview = New ListView()
        chmIndex = New ColumnHeader()
        chmPassword = New ColumnHeader()
        chmRating = New ColumnHeader()
        chmFeedback = New ColumnHeader()
        flpReviewUnsecure = New FlowLayoutPanel()
        lblReviewUnsecure = New Label()
        flpReviewSecure = New FlowLayoutPanel()
        lblReviewSecure = New Label()
        chmDateAdded = New ColumnHeader()
        flpReview.SuspendLayout()
        flpReviewUnsecure.SuspendLayout()
        flpReviewSecure.SuspendLayout()
        SuspendLayout()
        ' 
        ' flpReview
        ' 
        flpReview.AutoSize = True
        flpReview.AutoSizeMode = AutoSizeMode.GrowAndShrink
        flpReview.Controls.Add(lsvReview)
        flpReview.Controls.Add(flpReviewUnsecure)
        flpReview.Controls.Add(flpReviewSecure)
        flpReview.FlowDirection = FlowDirection.TopDown
        flpReview.Location = New Point(0, 0)
        flpReview.Name = "flpReview"
        flpReview.Size = New Size(1106, 591)
        flpReview.TabIndex = 3
        ' 
        ' lsvReview
        ' 
        lsvReview.BackColor = Color.FromArgb(CByte(240), CByte(241), CByte(199))
        lsvReview.BorderStyle = BorderStyle.None
        lsvReview.CheckBoxes = True
        lsvReview.Columns.AddRange(New ColumnHeader() {chmIndex, chmPassword, chmDateAdded, chmRating, chmFeedback})
        lsvReview.ForeColor = Color.Black
        lsvReview.FullRowSelect = True
        lsvReview.Location = New Point(3, 4)
        lsvReview.Margin = New Padding(3, 4, 3, 4)
        lsvReview.Name = "lsvReview"
        lsvReview.OwnerDraw = True
        lsvReview.Size = New Size(1100, 507)
        lsvReview.TabIndex = 101
        lsvReview.TabStop = False
        lsvReview.UseCompatibleStateImageBehavior = False
        lsvReview.View = View.Details
        ' 
        ' chmIndex
        ' 
        chmIndex.Text = "Index"
        chmIndex.Width = 150
        ' 
        ' chmPassword
        ' 
        chmPassword.Text = "Password"
        chmPassword.Width = 250
        ' 
        ' chmRating
        ' 
        chmRating.Text = "Rating"
        chmRating.Width = 250
        ' 
        ' chmFeedback
        ' 
        chmFeedback.Text = "Feedback"
        chmFeedback.Width = 250
        ' 
        ' flpReviewUnsecure
        ' 
        flpReviewUnsecure.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        flpReviewUnsecure.AutoSize = True
        flpReviewUnsecure.Controls.Add(lblReviewUnsecure)
        flpReviewUnsecure.Location = New Point(303, 518)
        flpReviewUnsecure.Name = "flpReviewUnsecure"
        flpReviewUnsecure.Size = New Size(499, 32)
        flpReviewUnsecure.TabIndex = 127
        ' 
        ' lblReviewUnsecure
        ' 
        lblReviewUnsecure.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        lblReviewUnsecure.AutoSize = True
        lblReviewUnsecure.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        lblReviewUnsecure.ForeColor = Color.FromArgb(CByte(255), CByte(105), CByte(105))
        lblReviewUnsecure.Location = New Point(3, 0)
        lblReviewUnsecure.Name = "lblReviewUnsecure"
        lblReviewUnsecure.Size = New Size(493, 32)
        lblReviewUnsecure.TabIndex = 0
        lblReviewUnsecure.Text = "You have {number} unsecured passwords!"
        ' 
        ' flpReviewSecure
        ' 
        flpReviewSecure.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        flpReviewSecure.AutoSize = True
        flpReviewSecure.Controls.Add(lblReviewSecure)
        flpReviewSecure.Location = New Point(368, 556)
        flpReviewSecure.Name = "flpReviewSecure"
        flpReviewSecure.Size = New Size(370, 32)
        flpReviewSecure.TabIndex = 128
        flpReviewSecure.Visible = False
        ' 
        ' lblReviewSecure
        ' 
        lblReviewSecure.AutoSize = True
        lblReviewSecure.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        lblReviewSecure.ForeColor = Color.FromArgb(CByte(255), CByte(223), CByte(122))
        lblReviewSecure.Location = New Point(3, 0)
        lblReviewSecure.Name = "lblReviewSecure"
        lblReviewSecure.Size = New Size(364, 32)
        lblReviewSecure.TabIndex = 0
        lblReviewSecure.Text = "All your passwords are secure!"
        ' 
        ' chmDateAdded
        ' 
        chmDateAdded.Text = "Date Added"
        chmDateAdded.Width = 200
        ' 
        ' Review
        ' 
        AutoScaleDimensions = New SizeF(8F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(60), CByte(51), CByte(81))
        ClientSize = New Size(1105, 592)
        Controls.Add(flpReview)
        ForeColor = Color.White
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "Review"
        StartPosition = FormStartPosition.CenterParent
        Text = "Review"
        flpReview.ResumeLayout(False)
        flpReview.PerformLayout()
        flpReviewUnsecure.ResumeLayout(False)
        flpReviewUnsecure.PerformLayout()
        flpReviewSecure.ResumeLayout(False)
        flpReviewSecure.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents flpReview As FlowLayoutPanel
    Friend WithEvents lsvReview As ListView
    Friend WithEvents chmIndex As ColumnHeader
    Friend WithEvents chmPassword As ColumnHeader
    Friend WithEvents chmRating As ColumnHeader
    Friend WithEvents chmFeedback As ColumnHeader
    Friend WithEvents flpReviewUnsecure As FlowLayoutPanel
    Friend WithEvents lblReviewUnsecure As Label
    Friend WithEvents flpReviewSecure As FlowLayoutPanel
    Friend WithEvents lblReviewSecure As Label
    Friend WithEvents chmDateAdded As ColumnHeader
End Class
