<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormParent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormParent))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ParentPanel = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PanelAdminSettings = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PanelPrint = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PanelSchedule = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.labelFullname = New System.Windows.Forms.Label()
        Me.LabelType = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.subj_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subj_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subj_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subj_unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subj_start = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subj_end = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dep_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dep_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.room_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.room_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sem_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sem_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDeleteRow = New System.Windows.Forms.Button()
        Me.ParentPanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PanelAdminSettings.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelPrint.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSchedule.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.btnLogout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ParentPanel
        '
        Me.ParentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ParentPanel.Controls.Add(Me.Panel4)
        Me.ParentPanel.Controls.Add(Me.Panel2)
        Me.ParentPanel.Controls.Add(Me.Panel1)
        Me.ParentPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ParentPanel.Location = New System.Drawing.Point(0, 0)
        Me.ParentPanel.Name = "ParentPanel"
        Me.ParentPanel.Size = New System.Drawing.Size(800, 450)
        Me.ParentPanel.TabIndex = 1
        Me.ParentPanel.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PanelAdminSettings)
        Me.Panel2.Controls.Add(Me.PanelPrint)
        Me.Panel2.Controls.Add(Me.PanelSchedule)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 59)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(211, 389)
        Me.Panel2.TabIndex = 1
        '
        'PanelAdminSettings
        '
        Me.PanelAdminSettings.Controls.Add(Me.Label3)
        Me.PanelAdminSettings.Controls.Add(Me.PictureBox5)
        Me.PanelAdminSettings.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelAdminSettings.Location = New System.Drawing.Point(0, 202)
        Me.PanelAdminSettings.Name = "PanelAdminSettings"
        Me.PanelAdminSettings.Size = New System.Drawing.Size(209, 58)
        Me.PanelAdminSettings.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(54, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Admin Settings"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(8, 8)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 0
        Me.PictureBox5.TabStop = False
        '
        'PanelPrint
        '
        Me.PanelPrint.Controls.Add(Me.Label2)
        Me.PanelPrint.Controls.Add(Me.PictureBox4)
        Me.PanelPrint.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelPrint.Location = New System.Drawing.Point(0, 144)
        Me.PanelPrint.Name = "PanelPrint"
        Me.PanelPrint.Size = New System.Drawing.Size(209, 58)
        Me.PanelPrint.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(54, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Print Schedule"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(8, 8)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 0
        Me.PictureBox4.TabStop = False
        '
        'PanelSchedule
        '
        Me.PanelSchedule.Controls.Add(Me.Label1)
        Me.PanelSchedule.Controls.Add(Me.PictureBox3)
        Me.PanelSchedule.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSchedule.Location = New System.Drawing.Point(0, 86)
        Me.PanelSchedule.Name = "PanelSchedule"
        Me.PanelSchedule.Size = New System.Drawing.Size(209, 58)
        Me.PanelSchedule.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(54, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Schedule"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(8, 8)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.LabelType)
        Me.Panel3.Controls.Add(Me.labelFullname)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(209, 86)
        Me.Panel3.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(798, 59)
        Me.Panel1.TabIndex = 0
        '
        'btnLogout
        '
        Me.btnLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), System.Drawing.Image)
        Me.btnLogout.Location = New System.Drawing.Point(750, 8)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(40, 40)
        Me.btnLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnLogout.TabIndex = 2
        Me.btnLogout.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(10, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(65, 48)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(81, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(302, 44)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'labelFullname
        '
        Me.labelFullname.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelFullname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelFullname.Location = New System.Drawing.Point(-1, 14)
        Me.labelFullname.Name = "labelFullname"
        Me.labelFullname.Size = New System.Drawing.Size(205, 31)
        Me.labelFullname.TabIndex = 0
        Me.labelFullname.Text = "Fullname"
        Me.labelFullname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelType
        '
        Me.LabelType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelType.Location = New System.Drawing.Point(-1, 47)
        Me.LabelType.Name = "LabelType"
        Me.LabelType.Size = New System.Drawing.Size(208, 21)
        Me.LabelType.TabIndex = 1
        Me.LabelType.Text = "Usertype"
        Me.LabelType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnDeleteRow)
        Me.Panel4.Controls.Add(Me.btnEdit)
        Me.Panel4.Controls.Add(Me.DataGridView1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(211, 59)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(587, 389)
        Me.Panel4.TabIndex = 2
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
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.subj_id, Me.subj_code, Me.subj_name, Me.subj_unit, Me.subj_start, Me.subj_end, Me.dep_id, Me.dep_name, Me.room_id, Me.room_name, Me.sem_id, Me.sem_name})
        Me.DataGridView1.Location = New System.Drawing.Point(6, 57)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(574, 326)
        Me.DataGridView1.TabIndex = 0
        '
        'subj_id
        '
        Me.subj_id.HeaderText = "#"
        Me.subj_id.Name = "subj_id"
        Me.subj_id.ReadOnly = True
        Me.subj_id.Visible = False
        '
        'subj_code
        '
        Me.subj_code.HeaderText = "Subject Code"
        Me.subj_code.Name = "subj_code"
        Me.subj_code.ReadOnly = True
        '
        'subj_name
        '
        Me.subj_name.HeaderText = "Subject Name"
        Me.subj_name.Name = "subj_name"
        Me.subj_name.ReadOnly = True
        Me.subj_name.Width = 200
        '
        'subj_unit
        '
        Me.subj_unit.HeaderText = "Unit"
        Me.subj_unit.Name = "subj_unit"
        Me.subj_unit.ReadOnly = True
        '
        'subj_start
        '
        Me.subj_start.HeaderText = "Start"
        Me.subj_start.Name = "subj_start"
        Me.subj_start.ReadOnly = True
        '
        'subj_end
        '
        Me.subj_end.HeaderText = "End"
        Me.subj_end.Name = "subj_end"
        Me.subj_end.ReadOnly = True
        '
        'dep_id
        '
        Me.dep_id.HeaderText = "Department ID"
        Me.dep_id.Name = "dep_id"
        Me.dep_id.ReadOnly = True
        Me.dep_id.Visible = False
        '
        'dep_name
        '
        Me.dep_name.HeaderText = "Department"
        Me.dep_name.Name = "dep_name"
        Me.dep_name.ReadOnly = True
        Me.dep_name.Width = 250
        '
        'room_id
        '
        Me.room_id.HeaderText = "Room ID"
        Me.room_id.Name = "room_id"
        Me.room_id.ReadOnly = True
        Me.room_id.Visible = False
        '
        'room_name
        '
        Me.room_name.HeaderText = "Room"
        Me.room_name.Name = "room_name"
        Me.room_name.ReadOnly = True
        Me.room_name.Width = 200
        '
        'sem_id
        '
        Me.sem_id.HeaderText = "Semester ID"
        Me.sem_id.Name = "sem_id"
        Me.sem_id.ReadOnly = True
        Me.sem_id.Visible = False
        '
        'sem_name
        '
        Me.sem_name.HeaderText = "Semester"
        Me.sem_name.Name = "sem_name"
        Me.sem_name.ReadOnly = True
        Me.sem_name.Width = 250
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEdit.Location = New System.Drawing.Point(466, 12)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(114, 35)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "Edit Selected Row"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDeleteRow
        '
        Me.btnDeleteRow.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeleteRow.Location = New System.Drawing.Point(346, 12)
        Me.btnDeleteRow.Name = "btnDeleteRow"
        Me.btnDeleteRow.Size = New System.Drawing.Size(114, 35)
        Me.btnDeleteRow.TabIndex = 2
        Me.btnDeleteRow.Text = "Delete Selected Row"
        Me.btnDeleteRow.UseVisualStyleBackColor = True
        '
        'FormParent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ParentPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Name = "FormParent"
        Me.Text = "FormParent"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ParentPanel.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.PanelAdminSettings.ResumeLayout(False)
        Me.PanelAdminSettings.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelPrint.ResumeLayout(False)
        Me.PanelPrint.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSchedule.ResumeLayout(False)
        Me.PanelSchedule.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.btnLogout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ParentPanel As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PanelSchedule As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PanelAdminSettings As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PanelPrint As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents btnLogout As PictureBox
    Friend WithEvents labelFullname As Label
    Friend WithEvents LabelType As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents subj_id As DataGridViewTextBoxColumn
    Friend WithEvents subj_code As DataGridViewTextBoxColumn
    Friend WithEvents subj_name As DataGridViewTextBoxColumn
    Friend WithEvents subj_unit As DataGridViewTextBoxColumn
    Friend WithEvents subj_start As DataGridViewTextBoxColumn
    Friend WithEvents subj_end As DataGridViewTextBoxColumn
    Friend WithEvents dep_id As DataGridViewTextBoxColumn
    Friend WithEvents dep_name As DataGridViewTextBoxColumn
    Friend WithEvents room_id As DataGridViewTextBoxColumn
    Friend WithEvents room_name As DataGridViewTextBoxColumn
    Friend WithEvents sem_id As DataGridViewTextBoxColumn
    Friend WithEvents sem_name As DataGridViewTextBoxColumn
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDeleteRow As Button
End Class
