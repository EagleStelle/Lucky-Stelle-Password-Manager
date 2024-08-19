<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Passwords
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
        flpPasswords = New FlowLayoutPanel()
        flpSystemInside = New FlowLayoutPanel()
        lsvMain = New ListView()
        cmhAccount = New ColumnHeader()
        cmhUsername = New ColumnHeader()
        cmhEmail = New ColumnHeader()
        cmhPassword = New ColumnHeader()
        flpControls = New FlowLayoutPanel()
        flpManage = New FlowLayoutPanel()
        flpInfoPasswords = New FlowLayoutPanel()
        Label2 = New Label()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        PictureBox1 = New PictureBox()
        FlowLayoutPanel6 = New FlowLayoutPanel()
        txtAccount = New TextBox()
        flpUsername = New FlowLayoutPanel()
        ptcIconUsername = New PictureBox()
        flpInputUsername = New FlowLayoutPanel()
        txtUsername = New TextBox()
        flpAccount = New FlowLayoutPanel()
        ptcIconAccount = New PictureBox()
        flpInputAccount = New FlowLayoutPanel()
        txtEmail = New TextBox()
        flpPassword = New FlowLayoutPanel()
        ptcIconPassword = New PictureBox()
        flpInputPassword = New FlowLayoutPanel()
        txtPassword = New TextBox()
        txtSuggestion = New RichTextBox()
        btnAdd = New Button()
        btnSuggest = New Button()
        lblPasswordLength = New Label()
        trkLength = New CustomTrackBar()
        btnShow = New Button()
        btnRemove = New Button()
        btnRestore = New Button()
        flpOrganize = New FlowLayoutPanel()
        FlowLayoutPanel8 = New FlowLayoutPanel()
        Label7 = New Label()
        FlowLayoutPanel15 = New FlowLayoutPanel()
        PictureBox2 = New PictureBox()
        FlowLayoutPanel16 = New FlowLayoutPanel()
        txtSearch = New TextBox()
        flpSorting = New FlowLayoutPanel()
        btnSort = New Button()
        btnSortAscending = New Button()
        btnSortDescending = New Button()
        flpPasswords.SuspendLayout()
        flpControls.SuspendLayout()
        flpManage.SuspendLayout()
        flpInfoPasswords.SuspendLayout()
        FlowLayoutPanel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        FlowLayoutPanel6.SuspendLayout()
        flpUsername.SuspendLayout()
        CType(ptcIconUsername, ComponentModel.ISupportInitialize).BeginInit()
        flpInputUsername.SuspendLayout()
        flpAccount.SuspendLayout()
        CType(ptcIconAccount, ComponentModel.ISupportInitialize).BeginInit()
        flpInputAccount.SuspendLayout()
        flpPassword.SuspendLayout()
        CType(ptcIconPassword, ComponentModel.ISupportInitialize).BeginInit()
        flpInputPassword.SuspendLayout()
        CType(trkLength, ComponentModel.ISupportInitialize).BeginInit()
        flpOrganize.SuspendLayout()
        FlowLayoutPanel8.SuspendLayout()
        FlowLayoutPanel15.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        FlowLayoutPanel16.SuspendLayout()
        flpSorting.SuspendLayout()
        SuspendLayout()
        ' 
        ' flpPasswords
        ' 
        flpPasswords.AutoSize = True
        flpPasswords.AutoSizeMode = AutoSizeMode.GrowAndShrink
        flpPasswords.BackColor = Color.FromArgb(CByte(60), CByte(51), CByte(81))
        flpPasswords.Controls.Add(flpSystemInside)
        flpPasswords.Controls.Add(lsvMain)
        flpPasswords.Controls.Add(flpControls)
        flpPasswords.Location = New Point(0, 0)
        flpPasswords.Name = "flpPasswords"
        flpPasswords.Size = New Size(1074, 675)
        flpPasswords.TabIndex = 2
        ' 
        ' flpSystemInside
        ' 
        flpSystemInside.AutoSize = True
        flpSystemInside.Location = New Point(3, 3)
        flpSystemInside.Name = "flpSystemInside"
        flpSystemInside.Size = New Size(0, 0)
        flpSystemInside.TabIndex = 124
        ' 
        ' lsvMain
        ' 
        lsvMain.BackColor = Color.FromArgb(CByte(240), CByte(241), CByte(199))
        lsvMain.BorderStyle = BorderStyle.None
        lsvMain.CheckBoxes = True
        lsvMain.Columns.AddRange(New ColumnHeader() {cmhAccount, cmhUsername, cmhEmail, cmhPassword})
        lsvMain.ForeColor = Color.Black
        lsvMain.FullRowSelect = True
        lsvMain.Location = New Point(9, 4)
        lsvMain.Margin = New Padding(3, 4, 3, 4)
        lsvMain.Name = "lsvMain"
        lsvMain.OwnerDraw = True
        lsvMain.Size = New Size(741, 647)
        lsvMain.TabIndex = 100
        lsvMain.TabStop = False
        lsvMain.UseCompatibleStateImageBehavior = False
        lsvMain.View = View.Details
        ' 
        ' cmhAccount
        ' 
        cmhAccount.Text = "Website"
        cmhAccount.Width = 150
        ' 
        ' cmhUsername
        ' 
        cmhUsername.Text = "Username"
        cmhUsername.Width = 150
        ' 
        ' cmhEmail
        ' 
        cmhEmail.Text = "Email"
        cmhEmail.Width = 170
        ' 
        ' cmhPassword
        ' 
        cmhPassword.Text = "Password"
        cmhPassword.Width = 270
        ' 
        ' flpControls
        ' 
        flpControls.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        flpControls.AutoSize = True
        flpControls.Controls.Add(flpManage)
        flpControls.Controls.Add(flpOrganize)
        flpControls.FlowDirection = FlowDirection.TopDown
        flpControls.Location = New Point(756, 3)
        flpControls.Name = "flpControls"
        flpControls.Size = New Size(315, 669)
        flpControls.TabIndex = 126
        ' 
        ' flpManage
        ' 
        flpManage.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        flpManage.AutoSize = True
        flpManage.AutoSizeMode = AutoSizeMode.GrowAndShrink
        flpManage.Controls.Add(flpInfoPasswords)
        flpManage.Controls.Add(FlowLayoutPanel1)
        flpManage.Controls.Add(flpUsername)
        flpManage.Controls.Add(flpAccount)
        flpManage.Controls.Add(flpPassword)
        flpManage.Controls.Add(txtSuggestion)
        flpManage.Controls.Add(btnAdd)
        flpManage.Controls.Add(btnSuggest)
        flpManage.Controls.Add(lblPasswordLength)
        flpManage.Controls.Add(trkLength)
        flpManage.Controls.Add(btnShow)
        flpManage.Controls.Add(btnRemove)
        flpManage.Controls.Add(btnRestore)
        flpManage.FlowDirection = FlowDirection.TopDown
        flpManage.Location = New Point(3, 3)
        flpManage.Name = "flpManage"
        flpManage.Size = New Size(309, 527)
        flpManage.TabIndex = 123
        ' 
        ' flpInfoPasswords
        ' 
        flpInfoPasswords.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        flpInfoPasswords.AutoSize = True
        flpInfoPasswords.AutoSizeMode = AutoSizeMode.GrowAndShrink
        flpInfoPasswords.Controls.Add(Label2)
        flpInfoPasswords.FlowDirection = FlowDirection.TopDown
        flpInfoPasswords.Font = New Font("Segoe UI", 18F)
        flpInfoPasswords.Location = New Point(35, 3)
        flpInfoPasswords.Name = "flpInfoPasswords"
        flpInfoPasswords.Size = New Size(238, 32)
        flpInfoPasswords.TabIndex = 123
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        Label2.ForeColor = Color.FromArgb(CByte(255), CByte(223), CByte(122))
        Label2.Location = New Point(3, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(232, 32)
        Label2.TabIndex = 108
        Label2.Text = "Manage Passwords"
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        FlowLayoutPanel1.AutoSize = True
        FlowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        FlowLayoutPanel1.BackColor = Color.FromArgb(CByte(240), CByte(241), CByte(199))
        FlowLayoutPanel1.Controls.Add(PictureBox1)
        FlowLayoutPanel1.Controls.Add(FlowLayoutPanel6)
        FlowLayoutPanel1.ForeColor = Color.Black
        FlowLayoutPanel1.Location = New Point(3, 41)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(303, 36)
        FlowLayoutPanel1.TabIndex = 1
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.iconAccount
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(30, 30)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 114
        PictureBox1.TabStop = False
        ' 
        ' FlowLayoutPanel6
        ' 
        FlowLayoutPanel6.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        FlowLayoutPanel6.AutoSize = True
        FlowLayoutPanel6.AutoSizeMode = AutoSizeMode.GrowAndShrink
        FlowLayoutPanel6.BackColor = Color.Transparent
        FlowLayoutPanel6.Controls.Add(txtAccount)
        FlowLayoutPanel6.FlowDirection = FlowDirection.TopDown
        FlowLayoutPanel6.Location = New Point(39, 4)
        FlowLayoutPanel6.Name = "FlowLayoutPanel6"
        FlowLayoutPanel6.Size = New Size(261, 27)
        FlowLayoutPanel6.TabIndex = 2
        ' 
        ' txtAccount
        ' 
        txtAccount.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        txtAccount.AutoCompleteMode = AutoCompleteMode.Suggest
        txtAccount.BackColor = Color.FromArgb(CByte(240), CByte(241), CByte(199))
        txtAccount.BorderStyle = BorderStyle.None
        txtAccount.ForeColor = Color.Gray
        txtAccount.Location = New Point(3, 4)
        txtAccount.Margin = New Padding(3, 4, 3, 4)
        txtAccount.Name = "txtAccount"
        txtAccount.Size = New Size(255, 19)
        txtAccount.TabIndex = 101
        txtAccount.Text = "Account"
        ' 
        ' flpUsername
        ' 
        flpUsername.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        flpUsername.AutoSize = True
        flpUsername.AutoSizeMode = AutoSizeMode.GrowAndShrink
        flpUsername.BackColor = Color.FromArgb(CByte(240), CByte(241), CByte(199))
        flpUsername.Controls.Add(ptcIconUsername)
        flpUsername.Controls.Add(flpInputUsername)
        flpUsername.ForeColor = Color.Black
        flpUsername.Location = New Point(3, 83)
        flpUsername.Name = "flpUsername"
        flpUsername.Size = New Size(303, 36)
        flpUsername.TabIndex = 1
        ' 
        ' ptcIconUsername
        ' 
        ptcIconUsername.Image = My.Resources.Resources.iconUsername
        ptcIconUsername.Location = New Point(3, 3)
        ptcIconUsername.Name = "ptcIconUsername"
        ptcIconUsername.Size = New Size(30, 30)
        ptcIconUsername.SizeMode = PictureBoxSizeMode.StretchImage
        ptcIconUsername.TabIndex = 114
        ptcIconUsername.TabStop = False
        ' 
        ' flpInputUsername
        ' 
        flpInputUsername.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        flpInputUsername.AutoSize = True
        flpInputUsername.AutoSizeMode = AutoSizeMode.GrowAndShrink
        flpInputUsername.BackColor = Color.Transparent
        flpInputUsername.Controls.Add(txtUsername)
        flpInputUsername.FlowDirection = FlowDirection.TopDown
        flpInputUsername.Location = New Point(39, 4)
        flpInputUsername.Name = "flpInputUsername"
        flpInputUsername.Size = New Size(261, 27)
        flpInputUsername.TabIndex = 2
        ' 
        ' txtUsername
        ' 
        txtUsername.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        txtUsername.AutoCompleteMode = AutoCompleteMode.Suggest
        txtUsername.BackColor = Color.FromArgb(CByte(240), CByte(241), CByte(199))
        txtUsername.BorderStyle = BorderStyle.None
        txtUsername.ForeColor = Color.Gray
        txtUsername.Location = New Point(3, 4)
        txtUsername.Margin = New Padding(3, 4, 3, 4)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(255, 19)
        txtUsername.TabIndex = 102
        txtUsername.Text = "Username"
        ' 
        ' flpAccount
        ' 
        flpAccount.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        flpAccount.AutoSize = True
        flpAccount.AutoSizeMode = AutoSizeMode.GrowAndShrink
        flpAccount.BackColor = Color.FromArgb(CByte(240), CByte(241), CByte(199))
        flpAccount.Controls.Add(ptcIconAccount)
        flpAccount.Controls.Add(flpInputAccount)
        flpAccount.ForeColor = Color.Black
        flpAccount.Location = New Point(3, 125)
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
        flpInputAccount.AutoSizeMode = AutoSizeMode.GrowAndShrink
        flpInputAccount.BackColor = Color.Transparent
        flpInputAccount.Controls.Add(txtEmail)
        flpInputAccount.FlowDirection = FlowDirection.TopDown
        flpInputAccount.Location = New Point(39, 4)
        flpInputAccount.Name = "flpInputAccount"
        flpInputAccount.Size = New Size(261, 27)
        flpInputAccount.TabIndex = 2
        ' 
        ' txtEmail
        ' 
        txtEmail.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        txtEmail.AutoCompleteMode = AutoCompleteMode.Suggest
        txtEmail.BackColor = Color.FromArgb(CByte(240), CByte(241), CByte(199))
        txtEmail.BorderStyle = BorderStyle.None
        txtEmail.ForeColor = Color.Gray
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
        flpPassword.Controls.Add(ptcIconPassword)
        flpPassword.Controls.Add(flpInputPassword)
        flpPassword.Location = New Point(3, 167)
        flpPassword.Name = "flpPassword"
        flpPassword.Size = New Size(303, 36)
        flpPassword.TabIndex = 3
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
        flpInputPassword.AutoSizeMode = AutoSizeMode.GrowAndShrink
        flpInputPassword.BackColor = Color.Transparent
        flpInputPassword.Controls.Add(txtPassword)
        flpInputPassword.Location = New Point(39, 4)
        flpInputPassword.Name = "flpInputPassword"
        flpInputPassword.Size = New Size(261, 27)
        flpInputPassword.TabIndex = 2
        ' 
        ' txtPassword
        ' 
        txtPassword.AutoCompleteMode = AutoCompleteMode.Suggest
        txtPassword.BackColor = Color.FromArgb(CByte(240), CByte(241), CByte(199))
        txtPassword.BorderStyle = BorderStyle.None
        txtPassword.ForeColor = Color.Gray
        txtPassword.Location = New Point(3, 4)
        txtPassword.Margin = New Padding(3, 4, 3, 4)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(255, 19)
        txtPassword.TabIndex = 104
        txtPassword.Text = "Password"
        ' 
        ' txtSuggestion
        ' 
        txtSuggestion.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtSuggestion.BackColor = Color.FromArgb(CByte(60), CByte(51), CByte(81))
        txtSuggestion.BorderStyle = BorderStyle.None
        txtSuggestion.Font = New Font("Segoe UI", 8F)
        txtSuggestion.ForeColor = Color.FromArgb(CByte(240), CByte(241), CByte(199))
        txtSuggestion.Location = New Point(3, 209)
        txtSuggestion.Name = "txtSuggestion"
        txtSuggestion.ReadOnly = True
        txtSuggestion.Size = New Size(303, 30)
        txtSuggestion.TabIndex = 307
        txtSuggestion.TabStop = False
        txtSuggestion.Text = ""
        ' 
        ' btnAdd
        ' 
        btnAdd.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        btnAdd.BackColor = Color.Gray
        btnAdd.Enabled = False
        btnAdd.FlatAppearance.BorderSize = 0
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.Location = New Point(3, 246)
        btnAdd.Margin = New Padding(3, 4, 3, 4)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(303, 35)
        btnAdd.TabIndex = 120
        btnAdd.TabStop = False
        btnAdd.Text = "Add Password"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' btnSuggest
        ' 
        btnSuggest.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        btnSuggest.BackColor = Color.FromArgb(CByte(106), CByte(80), CByte(109))
        btnSuggest.FlatAppearance.BorderSize = 0
        btnSuggest.FlatStyle = FlatStyle.Flat
        btnSuggest.Location = New Point(3, 289)
        btnSuggest.Margin = New Padding(3, 4, 3, 4)
        btnSuggest.Name = "btnSuggest"
        btnSuggest.Size = New Size(303, 35)
        btnSuggest.TabIndex = 140
        btnSuggest.TabStop = False
        btnSuggest.Text = "Suggest Password"
        btnSuggest.UseVisualStyleBackColor = False
        ' 
        ' lblPasswordLength
        ' 
        lblPasswordLength.AutoSize = True
        lblPasswordLength.Location = New Point(3, 328)
        lblPasswordLength.Name = "lblPasswordLength"
        lblPasswordLength.Size = New Size(137, 19)
        lblPasswordLength.TabIndex = 117
        lblPasswordLength.Text = "Password Length: 10"
        ' 
        ' trkLength
        ' 
        trkLength.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        trkLength.LargeChange = 10
        trkLength.Location = New Point(3, 350)
        trkLength.Maximum = 100
        trkLength.Minimum = 10
        trkLength.Name = "trkLength"
        trkLength.Size = New Size(303, 45)
        trkLength.SmallChange = 0
        trkLength.TabIndex = 205
        trkLength.TabStop = False
        trkLength.ThumbColor = Color.FromArgb(CByte(106), CByte(80), CByte(109))
        trkLength.TickColor = Color.FromArgb(CByte(174), CByte(107), CByte(107))
        trkLength.TickFrequency = 10
        trkLength.TrackLineColor = Color.FromArgb(CByte(240), CByte(241), CByte(199))
        trkLength.Value = 10
        ' 
        ' btnShow
        ' 
        btnShow.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        btnShow.BackColor = Color.FromArgb(CByte(106), CByte(80), CByte(109))
        btnShow.FlatAppearance.BorderSize = 0
        btnShow.FlatStyle = FlatStyle.Flat
        btnShow.Location = New Point(3, 402)
        btnShow.Margin = New Padding(3, 4, 3, 4)
        btnShow.Name = "btnShow"
        btnShow.Size = New Size(303, 35)
        btnShow.TabIndex = 150
        btnShow.TabStop = False
        btnShow.Text = "Show Passwords"
        btnShow.UseVisualStyleBackColor = False
        ' 
        ' btnRemove
        ' 
        btnRemove.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        btnRemove.BackColor = Color.FromArgb(CByte(174), CByte(107), CByte(107))
        btnRemove.FlatAppearance.BorderSize = 0
        btnRemove.FlatStyle = FlatStyle.Flat
        btnRemove.Location = New Point(3, 445)
        btnRemove.Margin = New Padding(3, 4, 3, 4)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(303, 35)
        btnRemove.TabIndex = 160
        btnRemove.TabStop = False
        btnRemove.Text = "Remove Passwords"
        btnRemove.UseVisualStyleBackColor = False
        ' 
        ' btnRestore
        ' 
        btnRestore.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        btnRestore.BackColor = Color.Gray
        btnRestore.Enabled = False
        btnRestore.FlatAppearance.BorderSize = 0
        btnRestore.FlatStyle = FlatStyle.Flat
        btnRestore.Location = New Point(3, 488)
        btnRestore.Margin = New Padding(3, 4, 3, 4)
        btnRestore.Name = "btnRestore"
        btnRestore.Size = New Size(303, 35)
        btnRestore.TabIndex = 206
        btnRestore.TabStop = False
        btnRestore.Text = "Restore Passwords"
        btnRestore.UseVisualStyleBackColor = False
        ' 
        ' flpOrganize
        ' 
        flpOrganize.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        flpOrganize.AutoSize = True
        flpOrganize.AutoSizeMode = AutoSizeMode.GrowAndShrink
        flpOrganize.Controls.Add(FlowLayoutPanel8)
        flpOrganize.Controls.Add(FlowLayoutPanel15)
        flpOrganize.Controls.Add(flpSorting)
        flpOrganize.FlowDirection = FlowDirection.TopDown
        flpOrganize.Location = New Point(3, 536)
        flpOrganize.Name = "flpOrganize"
        flpOrganize.Size = New Size(309, 130)
        flpOrganize.TabIndex = 206
        ' 
        ' FlowLayoutPanel8
        ' 
        FlowLayoutPanel8.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        FlowLayoutPanel8.AutoSize = True
        FlowLayoutPanel8.AutoSizeMode = AutoSizeMode.GrowAndShrink
        FlowLayoutPanel8.Controls.Add(Label7)
        FlowLayoutPanel8.FlowDirection = FlowDirection.TopDown
        FlowLayoutPanel8.Font = New Font("Segoe UI", 18F)
        FlowLayoutPanel8.Location = New Point(38, 3)
        FlowLayoutPanel8.Name = "FlowLayoutPanel8"
        FlowLayoutPanel8.Size = New Size(232, 31)
        FlowLayoutPanel8.TabIndex = 123
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI", 17F, FontStyle.Bold)
        Label7.ForeColor = Color.FromArgb(CByte(255), CByte(223), CByte(122))
        Label7.Location = New Point(3, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(226, 31)
        Label7.TabIndex = 108
        Label7.Text = "Organize Passwords"
        ' 
        ' FlowLayoutPanel15
        ' 
        FlowLayoutPanel15.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        FlowLayoutPanel15.AutoSize = True
        FlowLayoutPanel15.AutoSizeMode = AutoSizeMode.GrowAndShrink
        FlowLayoutPanel15.BackColor = Color.FromArgb(CByte(240), CByte(241), CByte(199))
        FlowLayoutPanel15.Controls.Add(PictureBox2)
        FlowLayoutPanel15.Controls.Add(FlowLayoutPanel16)
        FlowLayoutPanel15.ForeColor = Color.Black
        FlowLayoutPanel15.Location = New Point(3, 40)
        FlowLayoutPanel15.Name = "FlowLayoutPanel15"
        FlowLayoutPanel15.Size = New Size(303, 36)
        FlowLayoutPanel15.TabIndex = 129
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.iconSearch
        PictureBox2.Location = New Point(3, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(30, 30)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 114
        PictureBox2.TabStop = False
        ' 
        ' FlowLayoutPanel16
        ' 
        FlowLayoutPanel16.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        FlowLayoutPanel16.AutoSize = True
        FlowLayoutPanel16.AutoSizeMode = AutoSizeMode.GrowAndShrink
        FlowLayoutPanel16.BackColor = Color.Transparent
        FlowLayoutPanel16.Controls.Add(txtSearch)
        FlowLayoutPanel16.FlowDirection = FlowDirection.TopDown
        FlowLayoutPanel16.Location = New Point(39, 4)
        FlowLayoutPanel16.Name = "FlowLayoutPanel16"
        FlowLayoutPanel16.Size = New Size(261, 27)
        FlowLayoutPanel16.TabIndex = 115
        ' 
        ' txtSearch
        ' 
        txtSearch.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        txtSearch.BackColor = Color.FromArgb(CByte(240), CByte(241), CByte(199))
        txtSearch.BorderStyle = BorderStyle.None
        txtSearch.ForeColor = Color.Gray
        txtSearch.Location = New Point(3, 4)
        txtSearch.Margin = New Padding(3, 4, 3, 4)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(255, 19)
        txtSearch.TabIndex = 103
        txtSearch.TabStop = False
        txtSearch.Text = "Search"
        ' 
        ' flpSorting
        ' 
        flpSorting.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        flpSorting.AutoSize = True
        flpSorting.AutoSizeMode = AutoSizeMode.GrowAndShrink
        flpSorting.Controls.Add(btnSort)
        flpSorting.Controls.Add(btnSortAscending)
        flpSorting.Controls.Add(btnSortDescending)
        flpSorting.Location = New Point(3, 82)
        flpSorting.Name = "flpSorting"
        flpSorting.Size = New Size(303, 45)
        flpSorting.TabIndex = 161
        ' 
        ' btnSort
        ' 
        btnSort.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        btnSort.AutoSize = True
        btnSort.BackColor = Color.FromArgb(CByte(106), CByte(80), CByte(109))
        btnSort.FlatAppearance.BorderSize = 0
        btnSort.FlatStyle = FlatStyle.Flat
        btnSort.Location = New Point(3, 4)
        btnSort.Margin = New Padding(3, 4, 3, 4)
        btnSort.Name = "btnSort"
        btnSort.Size = New Size(215, 37)
        btnSort.TabIndex = 206
        btnSort.TabStop = False
        btnSort.Text = "Sort by: Website"
        btnSort.UseVisualStyleBackColor = False
        ' 
        ' btnSortAscending
        ' 
        btnSortAscending.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        btnSortAscending.BackColor = Color.FromArgb(CByte(174), CByte(107), CByte(107))
        btnSortAscending.FlatAppearance.BorderSize = 0
        btnSortAscending.FlatStyle = FlatStyle.Flat
        btnSortAscending.Image = My.Resources.Resources.iconUp
        btnSortAscending.Location = New Point(224, 5)
        btnSortAscending.Margin = New Padding(3, 4, 3, 4)
        btnSortAscending.Name = "btnSortAscending"
        btnSortAscending.Size = New Size(35, 35)
        btnSortAscending.TabIndex = 207
        btnSortAscending.TabStop = False
        btnSortAscending.UseVisualStyleBackColor = False
        ' 
        ' btnSortDescending
        ' 
        btnSortDescending.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        btnSortDescending.BackColor = Color.FromArgb(CByte(174), CByte(107), CByte(107))
        btnSortDescending.FlatAppearance.BorderSize = 0
        btnSortDescending.FlatStyle = FlatStyle.Flat
        btnSortDescending.Image = My.Resources.Resources.iconDown
        btnSortDescending.Location = New Point(265, 5)
        btnSortDescending.Margin = New Padding(3, 4, 3, 4)
        btnSortDescending.Name = "btnSortDescending"
        btnSortDescending.Size = New Size(35, 35)
        btnSortDescending.TabIndex = 208
        btnSortDescending.TabStop = False
        btnSortDescending.UseVisualStyleBackColor = False
        ' 
        ' Passwords
        ' 
        AutoScaleDimensions = New SizeF(8F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(60), CByte(51), CByte(81))
        ClientSize = New Size(1084, 709)
        Controls.Add(flpPasswords)
        ForeColor = Color.White
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "Passwords"
        StartPosition = FormStartPosition.CenterParent
        Text = "Passwords"
        flpPasswords.ResumeLayout(False)
        flpPasswords.PerformLayout()
        flpControls.ResumeLayout(False)
        flpControls.PerformLayout()
        flpManage.ResumeLayout(False)
        flpManage.PerformLayout()
        flpInfoPasswords.ResumeLayout(False)
        flpInfoPasswords.PerformLayout()
        FlowLayoutPanel1.ResumeLayout(False)
        FlowLayoutPanel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        FlowLayoutPanel6.ResumeLayout(False)
        FlowLayoutPanel6.PerformLayout()
        flpUsername.ResumeLayout(False)
        flpUsername.PerformLayout()
        CType(ptcIconUsername, ComponentModel.ISupportInitialize).EndInit()
        flpInputUsername.ResumeLayout(False)
        flpInputUsername.PerformLayout()
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
        CType(trkLength, ComponentModel.ISupportInitialize).EndInit()
        flpOrganize.ResumeLayout(False)
        flpOrganize.PerformLayout()
        FlowLayoutPanel8.ResumeLayout(False)
        FlowLayoutPanel8.PerformLayout()
        FlowLayoutPanel15.ResumeLayout(False)
        FlowLayoutPanel15.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        FlowLayoutPanel16.ResumeLayout(False)
        FlowLayoutPanel16.PerformLayout()
        flpSorting.ResumeLayout(False)
        flpSorting.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents flpPasswords As FlowLayoutPanel
    Friend WithEvents flpSystemInside As FlowLayoutPanel
    Friend WithEvents lsvMain As ListView
    Friend WithEvents cmhAccount As ColumnHeader
    Friend WithEvents cmhUsername As ColumnHeader
    Friend WithEvents cmhEmail As ColumnHeader
    Friend WithEvents cmhPassword As ColumnHeader
    Friend WithEvents flpControls As FlowLayoutPanel
    Friend WithEvents flpManage As FlowLayoutPanel
    Friend WithEvents flpInfoPasswords As FlowLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents FlowLayoutPanel6 As FlowLayoutPanel
    Friend WithEvents txtAccount As TextBox
    Friend WithEvents flpUsername As FlowLayoutPanel
    Friend WithEvents ptcIconUsername As PictureBox
    Friend WithEvents flpInputUsername As FlowLayoutPanel
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents flpAccount As FlowLayoutPanel
    Friend WithEvents ptcIconAccount As PictureBox
    Friend WithEvents flpInputAccount As FlowLayoutPanel
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSuggest As Button
    Friend WithEvents lblPasswordLength As Label
    Friend WithEvents trkLength As CustomTrackBar
    Friend WithEvents btnShow As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnRestore As Button
    Friend WithEvents flpOrganize As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel8 As FlowLayoutPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents FlowLayoutPanel15 As FlowLayoutPanel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents FlowLayoutPanel16 As FlowLayoutPanel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents flpSorting As FlowLayoutPanel
    Friend WithEvents btnSort As Button
    Friend WithEvents btnSortAscending As Button
    Friend WithEvents btnSortDescending As Button
    Friend WithEvents flpPassword As FlowLayoutPanel
    Friend WithEvents ptcIconPassword As PictureBox
    Friend WithEvents flpInputPassword As FlowLayoutPanel
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtSuggestion As RichTextBox
End Class
