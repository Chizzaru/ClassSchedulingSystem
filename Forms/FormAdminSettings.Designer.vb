<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAdminSettings
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAdminSettings))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnDeleteUser = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnUpdateSelected = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.user_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.user_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.user_uname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.user_pass = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.title = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnCancelUpdate = New System.Windows.Forms.Button()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFullname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnDepDelSelected = New System.Windows.Forms.Button()
        Me.btnDepSearch = New System.Windows.Forms.Button()
        Me.txtDepSearch = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnDepUpdSelected = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.dep_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dep_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dep_head = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnDepUpdate = New System.Windows.Forms.Button()
        Me.btnDepCancelUpdate = New System.Windows.Forms.Button()
        Me.txtDepID = New System.Windows.Forms.TextBox()
        Me.txtDepHead = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnDepSave = New System.Windows.Forms.Button()
        Me.txtDepName = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.btnSemDeleteRow = New System.Windows.Forms.Button()
        Me.btnSemSearch = New System.Windows.Forms.Button()
        Me.txtSemSearch = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btnSemUpdateRow = New System.Windows.Forms.Button()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.sem_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sem_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sem_start = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sem_end = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.dpSemEnd = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.dpSemStart = New System.Windows.Forms.DateTimePicker()
        Me.txtSemName = New System.Windows.Forms.TextBox()
        Me.btnSemUpdate = New System.Windows.Forms.Button()
        Me.btnSemCancelUpdate = New System.Windows.Forms.Button()
        Me.txtSemID = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnSemSave = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.btnSYDeleteRow = New System.Windows.Forms.Button()
        Me.btnSYSearch = New System.Windows.Forms.Button()
        Me.txtSYSearch = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnUpdateRow = New System.Windows.Forms.Button()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.sy_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sy_yrstart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sy_yrend = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtSYEnd = New System.Windows.Forms.MaskedTextBox()
        Me.txtSYStart = New System.Windows.Forms.MaskedTextBox()
        Me.btnSYUpdate = New System.Windows.Forms.Button()
        Me.btnSYCancelUpdate = New System.Windows.Forms.Button()
        Me.txtSYID = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnSYsave = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.btnUpdateRoom = New System.Windows.Forms.Button()
        Me.btnCancelUpdateRoom = New System.Windows.Forms.Button()
        Me.txtRoomID = New System.Windows.Forms.TextBox()
        Me.btnRoomSave = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtRoomCode = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtRoomName = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cmbRoomDepartment = New System.Windows.Forms.ComboBox()
        Me.DataGridView5 = New System.Windows.Forms.DataGridView()
        Me.room_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.department_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.room_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.room_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.department = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnRoomDeleteRow = New System.Windows.Forms.Button()
        Me.btnSearchRoom = New System.Windows.Forms.Button()
        Me.txtSearchRoom = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.UpdateRoomRow = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1370, 509)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnDeleteUser)
        Me.TabPage1.Controls.Add(Me.btnSearch)
        Me.TabPage1.Controls.Add(Me.txtSearch)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.btnUpdateSelected)
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1362, 480)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Users"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnDeleteUser
        '
        Me.btnDeleteUser.Location = New System.Drawing.Point(1035, 18)
        Me.btnDeleteUser.Name = "btnDeleteUser"
        Me.btnDeleteUser.Size = New System.Drawing.Size(150, 35)
        Me.btnDeleteUser.TabIndex = 6
        Me.btnDeleteUser.Text = "Delete Selected Row"
        Me.btnDeleteUser.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(704, 18)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(72, 35)
        Me.btnSearch.TabIndex = 5
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(439, 24)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(259, 22)
        Me.txtSearch.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(380, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 16)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Search : "
        '
        'btnUpdateSelected
        '
        Me.btnUpdateSelected.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdateSelected.Location = New System.Drawing.Point(1201, 18)
        Me.btnUpdateSelected.Name = "btnUpdateSelected"
        Me.btnUpdateSelected.Size = New System.Drawing.Size(153, 35)
        Me.btnUpdateSelected.TabIndex = 2
        Me.btnUpdateSelected.Text = "Update Selected Row"
        Me.btnUpdateSelected.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.user_id, Me.user_name, Me.user_uname, Me.user_pass, Me.title})
        Me.DataGridView1.Location = New System.Drawing.Point(379, 59)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(977, 413)
        Me.DataGridView1.TabIndex = 1
        '
        'user_id
        '
        Me.user_id.HeaderText = "#"
        Me.user_id.Name = "user_id"
        Me.user_id.ReadOnly = True
        Me.user_id.Visible = False
        Me.user_id.Width = 50
        '
        'user_name
        '
        Me.user_name.HeaderText = "Fullname"
        Me.user_name.Name = "user_name"
        Me.user_name.ReadOnly = True
        Me.user_name.Width = 300
        '
        'user_uname
        '
        Me.user_uname.HeaderText = "Username"
        Me.user_uname.Name = "user_uname"
        Me.user_uname.ReadOnly = True
        Me.user_uname.Width = 150
        '
        'user_pass
        '
        Me.user_pass.HeaderText = "Password"
        Me.user_pass.Name = "user_pass"
        Me.user_pass.ReadOnly = True
        Me.user_pass.Width = 150
        '
        'title
        '
        Me.title.HeaderText = "Title"
        Me.title.Name = "title"
        Me.title.ReadOnly = True
        Me.title.Width = 350
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnUpdate)
        Me.GroupBox1.Controls.Add(Me.btnCancelUpdate)
        Me.GroupBox1.Controls.Add(Me.txtUserID)
        Me.GroupBox1.Controls.Add(Me.txtTitle)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.txtConfirmPassword)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtUsername)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtFullname)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(368, 474)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add New User"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(22, 317)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(91, 35)
        Me.btnUpdate.TabIndex = 14
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        Me.btnUpdate.Visible = False
        '
        'btnCancelUpdate
        '
        Me.btnCancelUpdate.Location = New System.Drawing.Point(120, 317)
        Me.btnCancelUpdate.Name = "btnCancelUpdate"
        Me.btnCancelUpdate.Size = New System.Drawing.Size(91, 35)
        Me.btnCancelUpdate.TabIndex = 13
        Me.btnCancelUpdate.Text = "Cancel"
        Me.btnCancelUpdate.UseVisualStyleBackColor = True
        Me.btnCancelUpdate.Visible = False
        '
        'txtUserID
        '
        Me.txtUserID.Location = New System.Drawing.Point(27, 370)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(182, 22)
        Me.txtUserID.TabIndex = 12
        Me.txtUserID.Visible = False
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(23, 92)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(325, 22)
        Me.txtTitle.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Title : "
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(23, 317)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(91, 35)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Location = New System.Drawing.Point(23, 268)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.Size = New System.Drawing.Size(324, 22)
        Me.txtConfirmPassword.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 248)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Confirm-Password : "
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(23, 205)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(324, 22)
        Me.txtPassword.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Password : "
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(22, 161)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(324, 22)
        Me.txtUsername.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Username :"
        '
        'txtFullname
        '
        Me.txtFullname.Location = New System.Drawing.Point(22, 47)
        Me.txtFullname.Name = "txtFullname"
        Me.txtFullname.Size = New System.Drawing.Size(325, 22)
        Me.txtFullname.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fullname : "
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnDepDelSelected)
        Me.TabPage2.Controls.Add(Me.btnDepSearch)
        Me.TabPage2.Controls.Add(Me.txtDepSearch)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.btnDepUpdSelected)
        Me.TabPage2.Controls.Add(Me.DataGridView2)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1362, 480)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Department"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnDepDelSelected
        '
        Me.btnDepDelSelected.Location = New System.Drawing.Point(1030, 16)
        Me.btnDepDelSelected.Name = "btnDepDelSelected"
        Me.btnDepDelSelected.Size = New System.Drawing.Size(150, 35)
        Me.btnDepDelSelected.TabIndex = 11
        Me.btnDepDelSelected.Text = "Delete Selected Row"
        Me.btnDepDelSelected.UseVisualStyleBackColor = True
        '
        'btnDepSearch
        '
        Me.btnDepSearch.Location = New System.Drawing.Point(699, 16)
        Me.btnDepSearch.Name = "btnDepSearch"
        Me.btnDepSearch.Size = New System.Drawing.Size(72, 35)
        Me.btnDepSearch.TabIndex = 10
        Me.btnDepSearch.Text = "Search"
        Me.btnDepSearch.UseVisualStyleBackColor = True
        '
        'txtDepSearch
        '
        Me.txtDepSearch.Location = New System.Drawing.Point(434, 22)
        Me.txtDepSearch.Name = "txtDepSearch"
        Me.txtDepSearch.Size = New System.Drawing.Size(259, 22)
        Me.txtDepSearch.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(375, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 16)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Search : "
        '
        'btnDepUpdSelected
        '
        Me.btnDepUpdSelected.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDepUpdSelected.Location = New System.Drawing.Point(1196, 16)
        Me.btnDepUpdSelected.Name = "btnDepUpdSelected"
        Me.btnDepUpdSelected.Size = New System.Drawing.Size(153, 35)
        Me.btnDepUpdSelected.TabIndex = 7
        Me.btnDepUpdSelected.Text = "Update Selected Row"
        Me.btnDepUpdSelected.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dep_id, Me.dep_name, Me.dep_head})
        Me.DataGridView2.Location = New System.Drawing.Point(377, 61)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(977, 413)
        Me.DataGridView2.TabIndex = 2
        '
        'dep_id
        '
        Me.dep_id.HeaderText = "#"
        Me.dep_id.Name = "dep_id"
        Me.dep_id.ReadOnly = True
        Me.dep_id.Visible = False
        Me.dep_id.Width = 50
        '
        'dep_name
        '
        Me.dep_name.HeaderText = "Department Name"
        Me.dep_name.Name = "dep_name"
        Me.dep_name.ReadOnly = True
        Me.dep_name.Width = 300
        '
        'dep_head
        '
        Me.dep_head.HeaderText = "Department Head"
        Me.dep_head.Name = "dep_head"
        Me.dep_head.ReadOnly = True
        Me.dep_head.Width = 350
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnDepUpdate)
        Me.GroupBox2.Controls.Add(Me.btnDepCancelUpdate)
        Me.GroupBox2.Controls.Add(Me.txtDepID)
        Me.GroupBox2.Controls.Add(Me.txtDepHead)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.btnDepSave)
        Me.GroupBox2.Controls.Add(Me.txtDepName)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox2.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(368, 474)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Add New Department"
        '
        'btnDepUpdate
        '
        Me.btnDepUpdate.Location = New System.Drawing.Point(23, 139)
        Me.btnDepUpdate.Name = "btnDepUpdate"
        Me.btnDepUpdate.Size = New System.Drawing.Size(91, 35)
        Me.btnDepUpdate.TabIndex = 14
        Me.btnDepUpdate.Text = "Update"
        Me.btnDepUpdate.UseVisualStyleBackColor = True
        Me.btnDepUpdate.Visible = False
        '
        'btnDepCancelUpdate
        '
        Me.btnDepCancelUpdate.Location = New System.Drawing.Point(120, 139)
        Me.btnDepCancelUpdate.Name = "btnDepCancelUpdate"
        Me.btnDepCancelUpdate.Size = New System.Drawing.Size(91, 35)
        Me.btnDepCancelUpdate.TabIndex = 13
        Me.btnDepCancelUpdate.Text = "Cancel"
        Me.btnDepCancelUpdate.UseVisualStyleBackColor = True
        Me.btnDepCancelUpdate.Visible = False
        '
        'txtDepID
        '
        Me.txtDepID.Location = New System.Drawing.Point(23, 195)
        Me.txtDepID.Name = "txtDepID"
        Me.txtDepID.Size = New System.Drawing.Size(182, 22)
        Me.txtDepID.TabIndex = 12
        Me.txtDepID.Visible = False
        '
        'txtDepHead
        '
        Me.txtDepHead.Location = New System.Drawing.Point(23, 92)
        Me.txtDepHead.Name = "txtDepHead"
        Me.txtDepHead.Size = New System.Drawing.Size(325, 22)
        Me.txtDepHead.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 73)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 16)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Department Head : "
        '
        'btnDepSave
        '
        Me.btnDepSave.Location = New System.Drawing.Point(23, 139)
        Me.btnDepSave.Name = "btnDepSave"
        Me.btnDepSave.Size = New System.Drawing.Size(91, 35)
        Me.btnDepSave.TabIndex = 8
        Me.btnDepSave.Text = "Save"
        Me.btnDepSave.UseVisualStyleBackColor = True
        '
        'txtDepName
        '
        Me.txtDepName.Location = New System.Drawing.Point(22, 47)
        Me.txtDepName.Name = "txtDepName"
        Me.txtDepName.Size = New System.Drawing.Size(325, 22)
        Me.txtDepName.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(19, 28)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(127, 16)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Department Name : "
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.btnSemDeleteRow)
        Me.TabPage4.Controls.Add(Me.btnSemSearch)
        Me.TabPage4.Controls.Add(Me.txtSemSearch)
        Me.TabPage4.Controls.Add(Me.Label18)
        Me.TabPage4.Controls.Add(Me.btnSemUpdateRow)
        Me.TabPage4.Controls.Add(Me.DataGridView4)
        Me.TabPage4.Controls.Add(Me.GroupBox5)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1362, 480)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Semester"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'btnSemDeleteRow
        '
        Me.btnSemDeleteRow.Location = New System.Drawing.Point(1032, 18)
        Me.btnSemDeleteRow.Name = "btnSemDeleteRow"
        Me.btnSemDeleteRow.Size = New System.Drawing.Size(150, 35)
        Me.btnSemDeleteRow.TabIndex = 21
        Me.btnSemDeleteRow.Text = "Delete Selected Row"
        Me.btnSemDeleteRow.UseVisualStyleBackColor = True
        '
        'btnSemSearch
        '
        Me.btnSemSearch.Location = New System.Drawing.Point(701, 18)
        Me.btnSemSearch.Name = "btnSemSearch"
        Me.btnSemSearch.Size = New System.Drawing.Size(72, 35)
        Me.btnSemSearch.TabIndex = 20
        Me.btnSemSearch.Text = "Search"
        Me.btnSemSearch.UseVisualStyleBackColor = True
        '
        'txtSemSearch
        '
        Me.txtSemSearch.Location = New System.Drawing.Point(436, 24)
        Me.txtSemSearch.Name = "txtSemSearch"
        Me.txtSemSearch.Size = New System.Drawing.Size(259, 22)
        Me.txtSemSearch.TabIndex = 19
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(377, 29)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(60, 16)
        Me.Label18.TabIndex = 18
        Me.Label18.Text = "Search : "
        '
        'btnSemUpdateRow
        '
        Me.btnSemUpdateRow.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSemUpdateRow.Location = New System.Drawing.Point(1198, 18)
        Me.btnSemUpdateRow.Name = "btnSemUpdateRow"
        Me.btnSemUpdateRow.Size = New System.Drawing.Size(153, 35)
        Me.btnSemUpdateRow.TabIndex = 17
        Me.btnSemUpdateRow.Text = "Update Selected Row"
        Me.btnSemUpdateRow.UseVisualStyleBackColor = True
        '
        'DataGridView4
        '
        Me.DataGridView4.AllowUserToAddRows = False
        Me.DataGridView4.AllowUserToDeleteRows = False
        Me.DataGridView4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView4.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sem_id, Me.sem_name, Me.sem_start, Me.sem_end})
        Me.DataGridView4.Location = New System.Drawing.Point(377, 61)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.ReadOnly = True
        Me.DataGridView4.RowHeadersVisible = False
        Me.DataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView4.Size = New System.Drawing.Size(977, 413)
        Me.DataGridView4.TabIndex = 4
        '
        'sem_id
        '
        Me.sem_id.HeaderText = "#"
        Me.sem_id.Name = "sem_id"
        Me.sem_id.ReadOnly = True
        Me.sem_id.Visible = False
        Me.sem_id.Width = 50
        '
        'sem_name
        '
        Me.sem_name.HeaderText = "Semester Name"
        Me.sem_name.Name = "sem_name"
        Me.sem_name.ReadOnly = True
        Me.sem_name.Width = 300
        '
        'sem_start
        '
        Me.sem_start.HeaderText = "Semester Start"
        Me.sem_start.Name = "sem_start"
        Me.sem_start.ReadOnly = True
        Me.sem_start.Width = 200
        '
        'sem_end
        '
        Me.sem_end.HeaderText = "Semester End"
        Me.sem_end.Name = "sem_end"
        Me.sem_end.ReadOnly = True
        Me.sem_end.Width = 200
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.dpSemEnd)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.dpSemStart)
        Me.GroupBox5.Controls.Add(Me.txtSemName)
        Me.GroupBox5.Controls.Add(Me.btnSemUpdate)
        Me.GroupBox5.Controls.Add(Me.btnSemCancelUpdate)
        Me.GroupBox5.Controls.Add(Me.txtSemID)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.btnSemSave)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox5.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(368, 474)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Add New Semester Year"
        '
        'dpSemEnd
        '
        Me.dpSemEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpSemEnd.Location = New System.Drawing.Point(23, 145)
        Me.dpSemEnd.Name = "dpSemEnd"
        Me.dpSemEnd.Size = New System.Drawing.Size(321, 22)
        Me.dpSemEnd.TabIndex = 23
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(20, 124)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(99, 16)
        Me.Label17.TabIndex = 22
        Me.Label17.Text = "Semester End :"
        '
        'dpSemStart
        '
        Me.dpSemStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpSemStart.Location = New System.Drawing.Point(23, 97)
        Me.dpSemStart.Name = "dpSemStart"
        Me.dpSemStart.Size = New System.Drawing.Size(321, 22)
        Me.dpSemStart.TabIndex = 21
        '
        'txtSemName
        '
        Me.txtSemName.Location = New System.Drawing.Point(23, 47)
        Me.txtSemName.Name = "txtSemName"
        Me.txtSemName.Size = New System.Drawing.Size(322, 22)
        Me.txtSemName.TabIndex = 20
        '
        'btnSemUpdate
        '
        Me.btnSemUpdate.Location = New System.Drawing.Point(23, 199)
        Me.btnSemUpdate.Name = "btnSemUpdate"
        Me.btnSemUpdate.Size = New System.Drawing.Size(91, 35)
        Me.btnSemUpdate.TabIndex = 14
        Me.btnSemUpdate.Text = "Update"
        Me.btnSemUpdate.UseVisualStyleBackColor = True
        Me.btnSemUpdate.Visible = False
        '
        'btnSemCancelUpdate
        '
        Me.btnSemCancelUpdate.Location = New System.Drawing.Point(121, 199)
        Me.btnSemCancelUpdate.Name = "btnSemCancelUpdate"
        Me.btnSemCancelUpdate.Size = New System.Drawing.Size(91, 35)
        Me.btnSemCancelUpdate.TabIndex = 13
        Me.btnSemCancelUpdate.Text = "Cancel"
        Me.btnSemCancelUpdate.UseVisualStyleBackColor = True
        Me.btnSemCancelUpdate.Visible = False
        '
        'txtSemID
        '
        Me.txtSemID.Location = New System.Drawing.Point(21, 317)
        Me.txtSemID.Name = "txtSemID"
        Me.txtSemID.Size = New System.Drawing.Size(182, 22)
        Me.txtSemID.TabIndex = 12
        Me.txtSemID.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(19, 76)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(102, 16)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "Semester Start :"
        '
        'btnSemSave
        '
        Me.btnSemSave.Location = New System.Drawing.Point(24, 199)
        Me.btnSemSave.Name = "btnSemSave"
        Me.btnSemSave.Size = New System.Drawing.Size(91, 35)
        Me.btnSemSave.TabIndex = 8
        Me.btnSemSave.Text = "Save"
        Me.btnSemSave.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(19, 28)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(115, 16)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Semester Name : "
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.btnSYDeleteRow)
        Me.TabPage5.Controls.Add(Me.btnSYSearch)
        Me.TabPage5.Controls.Add(Me.txtSYSearch)
        Me.TabPage5.Controls.Add(Me.Label14)
        Me.TabPage5.Controls.Add(Me.btnUpdateRow)
        Me.TabPage5.Controls.Add(Me.DataGridView3)
        Me.TabPage5.Controls.Add(Me.GroupBox4)
        Me.TabPage5.Location = New System.Drawing.Point(4, 25)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(1362, 480)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "School Year"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'btnSYDeleteRow
        '
        Me.btnSYDeleteRow.Location = New System.Drawing.Point(1031, 12)
        Me.btnSYDeleteRow.Name = "btnSYDeleteRow"
        Me.btnSYDeleteRow.Size = New System.Drawing.Size(150, 35)
        Me.btnSYDeleteRow.TabIndex = 16
        Me.btnSYDeleteRow.Text = "Delete Selected Row"
        Me.btnSYDeleteRow.UseVisualStyleBackColor = True
        '
        'btnSYSearch
        '
        Me.btnSYSearch.Location = New System.Drawing.Point(700, 12)
        Me.btnSYSearch.Name = "btnSYSearch"
        Me.btnSYSearch.Size = New System.Drawing.Size(72, 35)
        Me.btnSYSearch.TabIndex = 15
        Me.btnSYSearch.Text = "Search"
        Me.btnSYSearch.UseVisualStyleBackColor = True
        '
        'txtSYSearch
        '
        Me.txtSYSearch.Location = New System.Drawing.Point(435, 18)
        Me.txtSYSearch.Name = "txtSYSearch"
        Me.txtSYSearch.Size = New System.Drawing.Size(259, 22)
        Me.txtSYSearch.TabIndex = 14
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(376, 23)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(60, 16)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Search : "
        '
        'btnUpdateRow
        '
        Me.btnUpdateRow.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdateRow.Location = New System.Drawing.Point(1197, 12)
        Me.btnUpdateRow.Name = "btnUpdateRow"
        Me.btnUpdateRow.Size = New System.Drawing.Size(153, 35)
        Me.btnUpdateRow.TabIndex = 12
        Me.btnUpdateRow.Text = "Update Selected Row"
        Me.btnUpdateRow.UseVisualStyleBackColor = True
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToDeleteRows = False
        Me.DataGridView3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView3.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sy_id, Me.sy_yrstart, Me.sy_yrend})
        Me.DataGridView3.Location = New System.Drawing.Point(379, 59)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        Me.DataGridView3.RowHeadersVisible = False
        Me.DataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView3.Size = New System.Drawing.Size(977, 413)
        Me.DataGridView3.TabIndex = 3
        '
        'sy_id
        '
        Me.sy_id.HeaderText = "#"
        Me.sy_id.Name = "sy_id"
        Me.sy_id.ReadOnly = True
        Me.sy_id.Visible = False
        Me.sy_id.Width = 50
        '
        'sy_yrstart
        '
        Me.sy_yrstart.HeaderText = "Year Start"
        Me.sy_yrstart.Name = "sy_yrstart"
        Me.sy_yrstart.ReadOnly = True
        Me.sy_yrstart.Width = 300
        '
        'sy_yrend
        '
        Me.sy_yrend.HeaderText = "Year End"
        Me.sy_yrend.Name = "sy_yrend"
        Me.sy_yrend.ReadOnly = True
        Me.sy_yrend.Width = 350
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtSYEnd)
        Me.GroupBox4.Controls.Add(Me.txtSYStart)
        Me.GroupBox4.Controls.Add(Me.btnSYUpdate)
        Me.GroupBox4.Controls.Add(Me.btnSYCancelUpdate)
        Me.GroupBox4.Controls.Add(Me.txtSYID)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.btnSYsave)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox4.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(368, 474)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Add New School Year"
        '
        'txtSYEnd
        '
        Me.txtSYEnd.Location = New System.Drawing.Point(22, 92)
        Me.txtSYEnd.Mask = "0000"
        Me.txtSYEnd.Name = "txtSYEnd"
        Me.txtSYEnd.Size = New System.Drawing.Size(324, 22)
        Me.txtSYEnd.TabIndex = 19
        Me.txtSYEnd.ValidatingType = GetType(Integer)
        '
        'txtSYStart
        '
        Me.txtSYStart.Location = New System.Drawing.Point(22, 47)
        Me.txtSYStart.Mask = "0000"
        Me.txtSYStart.Name = "txtSYStart"
        Me.txtSYStart.Size = New System.Drawing.Size(324, 22)
        Me.txtSYStart.TabIndex = 18
        Me.txtSYStart.ValidatingType = GetType(Integer)
        '
        'btnSYUpdate
        '
        Me.btnSYUpdate.Location = New System.Drawing.Point(24, 139)
        Me.btnSYUpdate.Name = "btnSYUpdate"
        Me.btnSYUpdate.Size = New System.Drawing.Size(91, 35)
        Me.btnSYUpdate.TabIndex = 14
        Me.btnSYUpdate.Text = "Update"
        Me.btnSYUpdate.UseVisualStyleBackColor = True
        Me.btnSYUpdate.Visible = False
        '
        'btnSYCancelUpdate
        '
        Me.btnSYCancelUpdate.Location = New System.Drawing.Point(120, 139)
        Me.btnSYCancelUpdate.Name = "btnSYCancelUpdate"
        Me.btnSYCancelUpdate.Size = New System.Drawing.Size(91, 35)
        Me.btnSYCancelUpdate.TabIndex = 13
        Me.btnSYCancelUpdate.Text = "Cancel"
        Me.btnSYCancelUpdate.UseVisualStyleBackColor = True
        Me.btnSYCancelUpdate.Visible = False
        '
        'txtSYID
        '
        Me.txtSYID.Location = New System.Drawing.Point(23, 195)
        Me.txtSYID.Name = "txtSYID"
        Me.txtSYID.Size = New System.Drawing.Size(182, 22)
        Me.txtSYID.TabIndex = 12
        Me.txtSYID.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(19, 73)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(38, 16)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "End :"
        '
        'btnSYsave
        '
        Me.btnSYsave.Location = New System.Drawing.Point(23, 139)
        Me.btnSYsave.Name = "btnSYsave"
        Me.btnSYsave.Size = New System.Drawing.Size(91, 35)
        Me.btnSYsave.TabIndex = 8
        Me.btnSYsave.Text = "Save"
        Me.btnSYsave.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(19, 28)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 16)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Start : "
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.btnRoomDeleteRow)
        Me.TabPage7.Controls.Add(Me.btnSearchRoom)
        Me.TabPage7.Controls.Add(Me.txtSearchRoom)
        Me.TabPage7.Controls.Add(Me.Label22)
        Me.TabPage7.Controls.Add(Me.UpdateRoomRow)
        Me.TabPage7.Controls.Add(Me.DataGridView5)
        Me.TabPage7.Controls.Add(Me.GroupBox6)
        Me.TabPage7.Location = New System.Drawing.Point(4, 25)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(1362, 480)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "Room/Hall"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.cmbRoomDepartment)
        Me.GroupBox6.Controls.Add(Me.Label21)
        Me.GroupBox6.Controls.Add(Me.txtRoomName)
        Me.GroupBox6.Controls.Add(Me.Label19)
        Me.GroupBox6.Controls.Add(Me.txtRoomCode)
        Me.GroupBox6.Controls.Add(Me.btnUpdateRoom)
        Me.GroupBox6.Controls.Add(Me.btnCancelUpdateRoom)
        Me.GroupBox6.Controls.Add(Me.txtRoomID)
        Me.GroupBox6.Controls.Add(Me.btnRoomSave)
        Me.GroupBox6.Controls.Add(Me.Label20)
        Me.GroupBox6.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox6.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(368, 474)
        Me.GroupBox6.TabIndex = 3
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Add New Room/Hall"
        '
        'btnUpdateRoom
        '
        Me.btnUpdateRoom.Location = New System.Drawing.Point(24, 212)
        Me.btnUpdateRoom.Name = "btnUpdateRoom"
        Me.btnUpdateRoom.Size = New System.Drawing.Size(91, 35)
        Me.btnUpdateRoom.TabIndex = 14
        Me.btnUpdateRoom.Text = "Update"
        Me.btnUpdateRoom.UseVisualStyleBackColor = True
        Me.btnUpdateRoom.Visible = False
        '
        'btnCancelUpdateRoom
        '
        Me.btnCancelUpdateRoom.Location = New System.Drawing.Point(121, 212)
        Me.btnCancelUpdateRoom.Name = "btnCancelUpdateRoom"
        Me.btnCancelUpdateRoom.Size = New System.Drawing.Size(91, 35)
        Me.btnCancelUpdateRoom.TabIndex = 13
        Me.btnCancelUpdateRoom.Text = "Cancel"
        Me.btnCancelUpdateRoom.UseVisualStyleBackColor = True
        Me.btnCancelUpdateRoom.Visible = False
        '
        'txtRoomID
        '
        Me.txtRoomID.Location = New System.Drawing.Point(24, 268)
        Me.txtRoomID.Name = "txtRoomID"
        Me.txtRoomID.Size = New System.Drawing.Size(182, 22)
        Me.txtRoomID.TabIndex = 12
        Me.txtRoomID.Visible = False
        '
        'btnRoomSave
        '
        Me.btnRoomSave.Location = New System.Drawing.Point(24, 212)
        Me.btnRoomSave.Name = "btnRoomSave"
        Me.btnRoomSave.Size = New System.Drawing.Size(91, 35)
        Me.btnRoomSave.TabIndex = 8
        Me.btnRoomSave.Text = "Save"
        Me.btnRoomSave.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(19, 28)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(87, 16)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Room Code: "
        '
        'txtRoomCode
        '
        Me.txtRoomCode.Location = New System.Drawing.Point(24, 53)
        Me.txtRoomCode.Name = "txtRoomCode"
        Me.txtRoomCode.Size = New System.Drawing.Size(314, 22)
        Me.txtRoomCode.TabIndex = 15
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(21, 80)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(85, 16)
        Me.Label19.TabIndex = 16
        Me.Label19.Text = "Room Name"
        '
        'txtRoomName
        '
        Me.txtRoomName.Location = New System.Drawing.Point(24, 104)
        Me.txtRoomName.Name = "txtRoomName"
        Me.txtRoomName.Size = New System.Drawing.Size(313, 22)
        Me.txtRoomName.TabIndex = 17
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(21, 131)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(78, 16)
        Me.Label21.TabIndex = 18
        Me.Label21.Text = "Department"
        '
        'cmbRoomDepartment
        '
        Me.cmbRoomDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRoomDepartment.FormattingEnabled = True
        Me.cmbRoomDepartment.Location = New System.Drawing.Point(25, 155)
        Me.cmbRoomDepartment.Name = "cmbRoomDepartment"
        Me.cmbRoomDepartment.Size = New System.Drawing.Size(311, 24)
        Me.cmbRoomDepartment.TabIndex = 19
        '
        'DataGridView5
        '
        Me.DataGridView5.AllowUserToAddRows = False
        Me.DataGridView5.AllowUserToDeleteRows = False
        Me.DataGridView5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView5.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView5.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.room_id, Me.department_id, Me.room_code, Me.room_name, Me.department})
        Me.DataGridView5.Location = New System.Drawing.Point(377, 59)
        Me.DataGridView5.Name = "DataGridView5"
        Me.DataGridView5.ReadOnly = True
        Me.DataGridView5.RowHeadersVisible = False
        Me.DataGridView5.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView5.Size = New System.Drawing.Size(977, 413)
        Me.DataGridView5.TabIndex = 4
        '
        'room_id
        '
        Me.room_id.HeaderText = "#"
        Me.room_id.Name = "room_id"
        Me.room_id.ReadOnly = True
        Me.room_id.Visible = False
        Me.room_id.Width = 50
        '
        'department_id
        '
        Me.department_id.HeaderText = "Department ID"
        Me.department_id.Name = "department_id"
        Me.department_id.ReadOnly = True
        Me.department_id.Visible = False
        '
        'room_code
        '
        Me.room_code.HeaderText = "Room Code"
        Me.room_code.Name = "room_code"
        Me.room_code.ReadOnly = True
        Me.room_code.Width = 150
        '
        'room_name
        '
        Me.room_name.HeaderText = "Room Name"
        Me.room_name.Name = "room_name"
        Me.room_name.ReadOnly = True
        Me.room_name.Width = 250
        '
        'department
        '
        Me.department.HeaderText = "Department"
        Me.department.Name = "department"
        Me.department.ReadOnly = True
        Me.department.Width = 300
        '
        'btnRoomDeleteRow
        '
        Me.btnRoomDeleteRow.Location = New System.Drawing.Point(1032, 13)
        Me.btnRoomDeleteRow.Name = "btnRoomDeleteRow"
        Me.btnRoomDeleteRow.Size = New System.Drawing.Size(150, 35)
        Me.btnRoomDeleteRow.TabIndex = 21
        Me.btnRoomDeleteRow.Text = "Delete Selected Row"
        Me.btnRoomDeleteRow.UseVisualStyleBackColor = True
        '
        'btnSearchRoom
        '
        Me.btnSearchRoom.Location = New System.Drawing.Point(701, 13)
        Me.btnSearchRoom.Name = "btnSearchRoom"
        Me.btnSearchRoom.Size = New System.Drawing.Size(72, 35)
        Me.btnSearchRoom.TabIndex = 20
        Me.btnSearchRoom.Text = "Search"
        Me.btnSearchRoom.UseVisualStyleBackColor = True
        '
        'txtSearchRoom
        '
        Me.txtSearchRoom.Location = New System.Drawing.Point(436, 19)
        Me.txtSearchRoom.Name = "txtSearchRoom"
        Me.txtSearchRoom.Size = New System.Drawing.Size(259, 22)
        Me.txtSearchRoom.TabIndex = 19
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(377, 24)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(60, 16)
        Me.Label22.TabIndex = 18
        Me.Label22.Text = "Search : "
        '
        'UpdateRoomRow
        '
        Me.UpdateRoomRow.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UpdateRoomRow.Location = New System.Drawing.Point(1198, 13)
        Me.UpdateRoomRow.Name = "UpdateRoomRow"
        Me.UpdateRoomRow.Size = New System.Drawing.Size(153, 35)
        Me.UpdateRoomRow.TabIndex = 17
        Me.UpdateRoomRow.Text = "Update Selected Row"
        Me.UpdateRoomRow.UseVisualStyleBackColor = True
        '
        'FormAdminSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 509)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormAdminSettings"
        Me.Text = "Admin Settings"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtFullname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnSave As Button
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtUserID As TextBox
    Friend WithEvents btnUpdateSelected As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnCancelUpdate As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents user_id As DataGridViewTextBoxColumn
    Friend WithEvents user_name As DataGridViewTextBoxColumn
    Friend WithEvents user_uname As DataGridViewTextBoxColumn
    Friend WithEvents user_pass As DataGridViewTextBoxColumn
    Friend WithEvents title As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnDepUpdate As Button
    Friend WithEvents btnDepCancelUpdate As Button
    Friend WithEvents txtDepID As TextBox
    Friend WithEvents txtDepHead As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnDepSave As Button
    Friend WithEvents txtDepName As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents dep_id As DataGridViewTextBoxColumn
    Friend WithEvents dep_name As DataGridViewTextBoxColumn
    Friend WithEvents dep_head As DataGridViewTextBoxColumn
    Friend WithEvents btnDeleteUser As Button
    Friend WithEvents btnDepDelSelected As Button
    Friend WithEvents btnDepSearch As Button
    Friend WithEvents txtDepSearch As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnDepUpdSelected As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnSYUpdate As Button
    Friend WithEvents btnSYCancelUpdate As Button
    Friend WithEvents txtSYID As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents btnSYsave As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents sy_id As DataGridViewTextBoxColumn
    Friend WithEvents sy_yrstart As DataGridViewTextBoxColumn
    Friend WithEvents sy_yrend As DataGridViewTextBoxColumn
    Friend WithEvents btnSYDeleteRow As Button
    Friend WithEvents btnSYSearch As Button
    Friend WithEvents txtSYSearch As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents btnUpdateRow As Button
    Friend WithEvents txtSYEnd As MaskedTextBox
    Friend WithEvents txtSYStart As MaskedTextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents txtSemName As TextBox
    Friend WithEvents btnSemUpdate As Button
    Friend WithEvents btnSemCancelUpdate As Button
    Friend WithEvents txtSemID As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents btnSemSave As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents dpSemEnd As DateTimePicker
    Friend WithEvents Label17 As Label
    Friend WithEvents dpSemStart As DateTimePicker
    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents sem_id As DataGridViewTextBoxColumn
    Friend WithEvents sem_name As DataGridViewTextBoxColumn
    Friend WithEvents sem_start As DataGridViewTextBoxColumn
    Friend WithEvents sem_end As DataGridViewTextBoxColumn
    Friend WithEvents btnSemDeleteRow As Button
    Friend WithEvents btnSemSearch As Button
    Friend WithEvents txtSemSearch As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents btnSemUpdateRow As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents cmbRoomDepartment As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtRoomName As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtRoomCode As TextBox
    Friend WithEvents btnUpdateRoom As Button
    Friend WithEvents btnCancelUpdateRoom As Button
    Friend WithEvents txtRoomID As TextBox
    Friend WithEvents btnRoomSave As Button
    Friend WithEvents Label20 As Label
    Friend WithEvents DataGridView5 As DataGridView
    Friend WithEvents room_id As DataGridViewTextBoxColumn
    Friend WithEvents department_id As DataGridViewTextBoxColumn
    Friend WithEvents room_code As DataGridViewTextBoxColumn
    Friend WithEvents room_name As DataGridViewTextBoxColumn
    Friend WithEvents department As DataGridViewTextBoxColumn
    Friend WithEvents btnRoomDeleteRow As Button
    Friend WithEvents btnSearchRoom As Button
    Friend WithEvents txtSearchRoom As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents UpdateRoomRow As Button
End Class
