Imports System.Data.SqlClient
Public Class FormAdminSettings
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        btnSave.Enabled = False
        If txtFullname.Text = "" Then
            MsgBox("Fullname is empty.", vbCritical, "Warning!")
            btnSave.Enabled = True
            Exit Sub
        End If

        If InStr(txtUsername.Text, " ") Then
            MsgBox("Username must not include spaces.", vbCritical, "Warning!")
            btnSave.Enabled = True
            Exit Sub
        End If

        If InStr(txtPassword.Text, " ") Then
            MsgBox("Password must not include spaces.", vbCritical, "Warning!")
            btnSave.Enabled = True
            Exit Sub
        End If

        If txtUsername.Text = "" Then
            MsgBox("Username is empty.", vbCritical, "Warning!")
            btnSave.Enabled = True
            Exit Sub
        End If

        If txtPassword.Text = "" Then
            MsgBox("Password is empty.", vbCritical, "Warning!")
            btnSave.Enabled = True
            Exit Sub
        End If

        If txtConfirmPassword.Text = "" Then
            MsgBox("Please confirm your password.", vbCritical, "Warning!")
            btnSave.Enabled = True
            Exit Sub
        End If

        If txtPassword.Text <> txtConfirmPassword.Text Then
            MsgBox("Password not matched.", vbCritical, "Warning!")
            btnSave.Enabled = True
            Exit Sub
        End If

        'CHECK DUPLICATION
        Dim sql As String
        sql = " select count(*) from user_tbl where " &
                                                  "(user_name Like '%" & txtFullname.Text & "%'" &
                                                  "and user_uname like '%" & txtUsername.Text & "%'" &
                                                  "and title like '%" & txtTitle.Text & "%')"
        If checkDuplicate(sql) = True Then
            MsgBox("Duplicate of record.", vbCritical, "Warning!")
            txtFullname.Clear()
            txtTitle.Clear()
            txtUsername.Clear()
            txtPassword.Clear()
            txtConfirmPassword.Clear()
            btnSave.Enabled = True
            Exit Sub
        End If

        'INSERT
        Dim str_qry As String
        str_qry = "insert into user_tbl(user_name, user_uname, user_pass, user_type, title)" &
            "values('" & txtFullname.Text & "','" & txtUsername.Text & "','" & txtPassword.Text & "',2,'" & txtTitle.Text & "')"
        If insertData(str_qry) = False Then
            MsgBox("New user failed to add.", vbCritical, "Error!")
            btnSave.Enabled = True
            Exit Sub
        End If

        MsgBox("New user has been successfully added.", vbInformation, "Success!")
        txtFullname.Clear()
        txtTitle.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
        txtConfirmPassword.Clear()
        btnSave.Enabled = True
        loadUsers()
    End Sub



    Sub loadUsers()
        openCon()
        Try
            Dim dataadapter As New SqlDataAdapter("select user_id, user_name, user_uname, user_pass, title from user_tbl where user_type != 1", conn)
            Dim ds As New DataSet()
            DataGridView1.Rows.Clear()
            dataadapter.Fill(ds, "user_table")
            conn.Close()
            If ds.Tables(0).Rows.Count < 1 Then
                'MsgBox("No record to display.", vbInformation, "Information")
                Exit Sub
            End If

            For Each dr As DataRow In ds.Tables(0).Rows
                DataGridView1.Rows.Add(dr.Item("user_id"), dr.Item("user_name"), dr.Item("user_uname"), dr.Item("user_pass"), dr.Item("title"))
            Next


        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
            Exit Sub
        End Try
    End Sub

    Sub searchUsers(ByRef search_str As String)
        openCon()
        Try
            Dim dataadapter As New SqlDataAdapter("select user_id, user_name, user_uname, user_pass, title from user_tbl where user_type != 1 and" &
                                                  "(user_name like '%" & search_str & "%'" &
                                                  "or user_uname like '%" & search_str & "%'" &
                                                  "or title like '%" & search_str & "%')", conn)
            Dim ds As New DataSet()
            DataGridView1.Rows.Clear()
            dataadapter.Fill(ds, "user_table")
            conn.Close()
            If ds.Tables(0).Rows.Count < 1 Then
                MsgBox("No record to display.", vbInformation, "Information")
                Exit Sub
            End If

            For Each dr As DataRow In ds.Tables(0).Rows
                DataGridView1.Rows.Add(dr.Item("user_id"), dr.Item("user_name"), dr.Item("user_uname"), dr.Item("user_pass"), dr.Item("title"))
            Next


        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
            Exit Sub
        End Try
    End Sub

    'FORM LOAD
    Private Sub FormAdminSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadUsers()
        loadDepartment()
        loadSchoolYear()
        loadSemester()
        fill_cmbRoomDepartment()
        cmbRoomDepartment.SelectedIndex = -1
        loadRoom()

    End Sub

    Private Sub btnUpdateSelected_Click(sender As Object, e As EventArgs) Handles btnUpdateSelected.Click
        btnSave.Visible = False
        btnUpdate.Visible = True
        btnCancelUpdate.Visible = True
        txtUserID.Text = DataGridView1.SelectedCells(0).Value
        txtFullname.Text = DataGridView1.SelectedCells(1).Value
        txtUsername.Text = DataGridView1.SelectedCells(2).Value
        txtPassword.Text = DataGridView1.SelectedCells(3).Value
        txtConfirmPassword.Text = DataGridView1.SelectedCells(3).Value
        txtTitle.Text = If(String.IsNullOrEmpty(DataGridView1.SelectedCells(4).Value.ToString), "", DataGridView1.SelectedCells(4).Value)

    End Sub

    Private Sub btnCancelUpdate_Click(sender As Object, e As EventArgs) Handles btnCancelUpdate.Click
        txtUserID.Clear()
        txtFullname.Clear()
        txtTitle.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
        txtConfirmPassword.Clear()
        btnUpdate.Visible = False
        btnCancelUpdate.Visible = False
        btnSave.Visible = True
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        btnUpdate.Enabled = False
        btnCancelUpdate.Enabled = False
        If txtFullname.Text = "" Then
            MsgBox("Fullname Is empty.", vbCritical, "Warning!")
            btnUpdate.Enabled = True
            btnCancelUpdate.Enabled = True
            Exit Sub
        End If

        If InStr(txtUsername.Text, " ") Then
            MsgBox("Username must Not include spaces.", vbCritical, "Warning!")
            btnUpdate.Enabled = True
            btnCancelUpdate.Enabled = True
            Exit Sub
        End If

        If InStr(txtPassword.Text, " ") Then
            MsgBox("Password must Not include spaces.", vbCritical, "Warning!")
            btnUpdate.Enabled = True
            btnCancelUpdate.Enabled = True
            Exit Sub
        End If

        If txtUsername.Text = "" Then
            MsgBox("Username Is empty.", vbCritical, "Warning!")
            btnUpdate.Enabled = True
            btnCancelUpdate.Enabled = True
            Exit Sub
        End If

        If txtPassword.Text = "" Then
            MsgBox("Password Is empty.", vbCritical, "Warning!")
            btnUpdate.Enabled = True
            btnCancelUpdate.Enabled = True
            Exit Sub
        End If

        If txtConfirmPassword.Text = "" Then
            MsgBox("Please confirm your password.", vbCritical, "Warning!")
            btnUpdate.Enabled = True
            btnCancelUpdate.Enabled = True
            Exit Sub
        End If

        If txtPassword.Text <> txtConfirmPassword.Text Then
            MsgBox("Password Not matched.", vbCritical, "Warning!")
            btnUpdate.Enabled = True
            btnCancelUpdate.Enabled = True
            Exit Sub
        End If

        'CHECK DUPLICATION
        Dim sql As String
        sql = " select count(*) from user_tbl where " &
                                                  "(user_name Like '%" & txtFullname.Text & "%'" &
                                                  "and user_uname like '%" & txtUsername.Text & "%'" &
                                                  "and title like '%" & txtTitle.Text & "%')"
        If checkDuplicate(sql) = True Then
            MsgBox("Duplicate of record or no changes has been made.", vbCritical, "Warning!")
            txtUserID.Clear()
            txtFullname.Clear()
            txtTitle.Clear()
            txtUsername.Clear()
            txtPassword.Clear()
            txtConfirmPassword.Clear()
            btnUpdate.Enabled = False
            btnCancelUpdate.Enabled = False
            btnUpdate.Visible = False
            btnCancelUpdate.Visible = False
            btnSave.Enabled = True
            btnSave.Visible = True
            Exit Sub
        End If

        'UPDATE
        Dim str_qry As String
        str_qry = "update user_tbl set user_name = '" & txtFullname.Text & "', user_uname = '" & txtUsername.Text & "'" &
            ", user_pass = '" & txtPassword.Text & "', title = '" & txtTitle.Text & "' where user_id = '" & txtUserID.Text & "'"
        If updateData(str_qry) = False Then
            MsgBox("Failed to Update.", vbCritical, "Error!")
            btnUpdate.Enabled = True
            btnCancelUpdate.Enabled = True
            Exit Sub
        End If

        MsgBox("Successfully Updated.", vbInformation, "Success!")
        txtUserID.Clear()
        txtFullname.Clear()
        txtTitle.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
        txtConfirmPassword.Clear()
        btnUpdate.Enabled = False
        btnCancelUpdate.Enabled = False
        btnUpdate.Visible = False
        btnCancelUpdate.Visible = False
        btnSave.Enabled = True
        btnSave.Visible = True

        loadUsers()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtSearch.Text = "" Then
            loadUsers()
            Exit Sub
        End If
        searchUsers(txtSearch.Text)
    End Sub

    Private Sub btnDepSave_Click(sender As Object, e As EventArgs) Handles btnDepSave.Click
        btnDepSave.Enabled = False
        If txtDepName.Text = "" Then
            MsgBox("Please Enter Department Name.", vbCritical, "Warning!")
            Exit Sub
        End If
        If txtDepHead.Text = "" Then
            MsgBox("Please Enter Department Head.", vbCritical, "Warning!")
            Exit Sub
        End If

        'Check Duplicate
        Dim sql As String
        sql = "select count(*) from department_tbl where dep_name like '%" & txtDepName.Text & "%'" &
            "and dep_head like '%" & txtDepHead.Text & "%'"
        If checkDuplicate(sql) = True Then
            MsgBox("Duplication of Entry.", vbCritical, "Warning!")
            btnSemCancelUpdate.Enabled = True
            btnSemUpdate.Enabled = True
            Exit Sub
        End If

        'INSERT
        Dim str_qry As String
        str_qry = "insert into department_tbl(dep_name, dep_head)" &
            "values('" & txtDepName.Text & "','" & txtDepHead.Text & "')"
        If insertData(str_qry) = False Then
            MsgBox("New department failed to add.", vbCritical, "Error!")
            btnSave.Enabled = True
            Exit Sub
        End If
        MsgBox("New department has been added.", vbInformation, "Information")
        txtDepName.Clear()
        txtDepHead.Clear()
        btnDepSave.Enabled = True
        loadDepartment()
    End Sub

    Sub loadDepartment()
        openCon()
        Try
            Dim dataadapter As New SqlDataAdapter("select dep_id, dep_name, dep_head from department_tbl", conn)
            Dim ds As New DataSet()
            DataGridView2.Rows.Clear()
            dataadapter.Fill(ds, "department_table")
            conn.Close()
            If ds.Tables(0).Rows.Count < 1 Then
                'MsgBox("No record to display.", vbInformation, "Information")
                Exit Sub
            End If

            For Each dr As DataRow In ds.Tables(0).Rows
                DataGridView2.Rows.Add(dr.Item("dep_id"), dr.Item("dep_name"), dr.Item("dep_head"))
            Next


        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
            Exit Sub
        End Try
    End Sub

    Sub searchDepartment(ByRef search_str As String)
        openCon()
        Try
            Dim dataadapter As New SqlDataAdapter("select dep_id, dep_name, dep_head from department_tbl where " &
                                                  "dep_name like '%" & search_str & "%' or dep_head like '%" & search_str & "%'", conn)
            Dim ds As New DataSet()
            DataGridView2.Rows.Clear()
            dataadapter.Fill(ds, "department_table")
            conn.Close()
            If ds.Tables(0).Rows.Count < 1 Then
                MsgBox("No record to display.", vbInformation, "Information")
                Exit Sub
            End If

            For Each dr As DataRow In ds.Tables(0).Rows
                DataGridView2.Rows.Add(dr.Item("dep_id"), dr.Item("dep_name"), dr.Item("dep_head"))
            Next


        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
            Exit Sub
        End Try
    End Sub
    Private Sub btnDeleteUser_Click(sender As Object, e As EventArgs) Handles btnDeleteUser.Click
        Dim ans As String = MsgBox("Are you sure you want to delete '" & DataGridView1.SelectedCells(1).Value & "'?", vbYesNo, "Alert")
        If ans = DialogResult.Yes Then
            Dim sql As String = "delete from user_tbl where user_id = '" & DataGridView1.SelectedCells(0).Value & "'"
            If deleteData(sql) = False Then
                MsgBox("Failed to delete record.", vbCritical, "Warning!")
                Exit Sub
            End If
            MsgBox("Successfully deleted.", vbInformation, "Information")
            loadUsers()
        End If
    End Sub

    Private Sub btnDepUpdSelected_Click(sender As Object, e As EventArgs) Handles btnDepUpdSelected.Click
        btnDepSave.Visible = False
        btnDepSave.Enabled = False
        btnDepUpdate.Visible = True
        btnDepUpdate.Enabled = True
        btnDepCancelUpdate.Visible = True
        btnDepCancelUpdate.Enabled = True
        txtDepID.Text = DataGridView2.SelectedCells(0).Value
        txtDepName.Text = DataGridView2.SelectedCells(1).Value
        txtDepHead.Text = DataGridView2.SelectedCells(2).Value
    End Sub

    Private Sub btnDepCancelUpdate_Click(sender As Object, e As EventArgs) Handles btnDepCancelUpdate.Click
        btnDepUpdate.Visible = False
        btnDepUpdate.Enabled = False
        txtDepID.Clear()
        txtDepName.Clear()
        txtDepHead.Clear()
        btnDepSave.Visible = True
        btnDepSave.Enabled = True
        btnDepCancelUpdate.Enabled = False
        btnDepCancelUpdate.Visible = False
    End Sub

    Private Sub btnDepUpdate_Click(sender As Object, e As EventArgs) Handles btnDepUpdate.Click
        btnDepUpdate.Enabled = False
        btnDepCancelUpdate.Enabled = False
        If txtDepName.Text = "" Then
            MsgBox("Department name must not empty.", vbCritical, "Warning!")
            btnDepUpdate.Enabled = True
            btnDepCancelUpdate.Enabled = True
            Exit Sub
        End If
        If txtDepHead.Text = "" Then
            MsgBox("Department head must not empty.", vbCritical, "Warning!")
            btnDepUpdate.Enabled = True
            btnDepCancelUpdate.Enabled = True
            Exit Sub
        End If

        'Check Duplicate
        Dim sql As String
        sql = "select count(*) from department_tbl where dep_name like '%" & txtDepName.Text & "%'" &
            "and dep_head like '%" & txtDepHead.Text & "%'"
        If checkDuplicate(sql) = True Then
            MsgBox("Duplication of Entry or no changes has been made.", vbCritical, "Warning!")
            btnSemCancelUpdate.Enabled = True
            btnSemUpdate.Enabled = True
            Exit Sub
        End If

        'UPDATE
        Dim qry As String = "update department_tbl set dep_name = '" & txtDepName.Text & "', dep_head = '" & txtDepHead.Text & "' where dep_id = '" & txtDepID.Text & "'"
        If updateData(qry) = False Then
            MsgBox("Failed to update.", vbCritical, "Warning!")
            btnDepUpdate.Enabled = True
            btnDepCancelUpdate.Enabled = True
            Exit Sub
        End If
        MsgBox("Successfully Updated.", vbInformation, "Information")

        btnDepUpdate.Visible = False
        btnDepUpdate.Enabled = False
        txtDepID.Clear()
        txtDepName.Clear()
        txtDepHead.Clear()
        btnDepSave.Visible = True
        btnDepSave.Enabled = True
        btnDepCancelUpdate.Enabled = False
        btnDepCancelUpdate.Visible = False

        loadDepartment()

    End Sub

    Private Sub btnDepDelSelected_Click(sender As Object, e As EventArgs) Handles btnDepDelSelected.Click
        Dim ans As String = MsgBox("Are you sure you want to delete '" & DataGridView2.SelectedCells(1).Value & "'?", vbYesNo, "Alert")
        If ans = DialogResult.Yes Then
            Dim sql As String = "delete from department_tbl where dep_id = '" & DataGridView2.SelectedCells(0).Value & "'"
            If deleteData(sql) = False Then
                MsgBox("Failed to delete record.", vbCritical, "Warning!")
                Exit Sub
            End If
            MsgBox("Successfully deleted.", vbInformation, "Information")
            loadDepartment()
        End If
    End Sub

    Private Sub btnDepSearch_Click(sender As Object, e As EventArgs) Handles btnDepSearch.Click
        If txtDepSearch.Text = "" Then
            loadDepartment()
            Exit Sub
        End If
        searchDepartment(txtDepSearch.Text)
    End Sub

    '=====================FOR SCHOOL YEAR TAB=======================================
    Private Sub btnSYsave_Click(sender As Object, e As EventArgs) Handles btnSYsave.Click
        If txtSYStart.Text = "" Then
            MsgBox("Please insert start year.", vbCritical, "Warning!")
            Exit Sub
        End If

        If txtSYEnd.Text = "" Then
            MsgBox("Please insert end year.", vbCritical, "Warning!")
            Exit Sub
        End If

        'CHECK DUPLICATION
        Dim sql As String
        sql = "select count(*) from school_yr_tbl where sy_yrstart like '%" & txtSYStart.Text & "%' and sy_yrend like '%" & txtSYEnd.Text & "%'"
        If checkDuplicate(sql) = True Then
            MsgBox("Duplicate of record.", vbCritical, "Warning!")
            Exit Sub
        End If

        Dim str_qry As String
        str_qry = "insert into school_yr_tbl(sy_yrstart, sy_yrend)" &
            "values('" & txtSYStart.Text & "','" & txtSYEnd.Text & "')"
        If insertData(str_qry) = False Then
            MsgBox("New School Year failed to add.", vbCritical, "Error!")
            btnSave.Enabled = True
            Exit Sub
        End If
        MsgBox("New School Year has been added.", vbInformation, "Information")
        loadSchoolYear()
        txtSYStart.Clear()
        txtSYEnd.Clear()

    End Sub

    '============PROCEDURE TO LOAD SCHOOL YEAR TABLE=================
    Sub loadSchoolYear()
        openCon()
        Try
            Dim dataadapter As New SqlDataAdapter("select * from school_yr_tbl", conn)
            Dim ds As New DataSet()
            DataGridView3.Rows.Clear()
            dataadapter.Fill(ds, "school_year_table")
            conn.Close()
            If ds.Tables(0).Rows.Count < 1 Then
                'MsgBox("No record to display.", vbInformation, "Information")
                Exit Sub
            End If

            For Each dr As DataRow In ds.Tables(0).Rows
                DataGridView3.Rows.Add(dr.Item("sy_id"), dr.Item("sy_yrstart"), dr.Item("sy_yrend"))
            Next


        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
            Exit Sub
        End Try
    End Sub
    '==================SEARCH SCHOOL YEAR =====================
    Sub searchSchoolYear(ByRef search_str As String)
        openCon()
        Try
            Dim dataadapter As New SqlDataAdapter("select * from school_yr_tbl where " &
                                                  "sy_yrstart like '%" & search_str & "%' or sy_yrend like '%" & search_str & "%'", conn)
            Dim ds As New DataSet()
            DataGridView3.Rows.Clear()
            dataadapter.Fill(ds, "schoolyr_table")
            conn.Close()
            If ds.Tables(0).Rows.Count < 1 Then
                MsgBox("No record to display.", vbInformation, "Information")
                Exit Sub
            End If

            For Each dr As DataRow In ds.Tables(0).Rows
                DataGridView3.Rows.Add(dr.Item("sy_id"), dr.Item("sy_yrstart"), dr.Item("sy_yrend"))
            Next


        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
            Exit Sub
        End Try
    End Sub

    '==================UPDATE SELECTED ROW=====================
    Private Sub btnUpdateRow_Click(sender As Object, e As EventArgs) Handles btnUpdateRow.Click
        btnSYUpdate.Visible = True
        btnSYUpdate.Enabled = True
        btnSYCancelUpdate.Visible = True
        btnSYCancelUpdate.Enabled = True
        txtSYID.Text = DataGridView3.SelectedCells(0).Value
        txtSYStart.Text = DataGridView3.SelectedCells(1).Value
        txtSYEnd.Text = DataGridView3.SelectedCells(2).Value
    End Sub
    '=====================CANCEL UPDATE=========================
    Private Sub btnSYCancelUpdate_Click(sender As Object, e As EventArgs) Handles btnSYCancelUpdate.Click
        btnSYUpdate.Enabled = False
        btnSYUpdate.Visible = False
        btnSYCancelUpdate.Enabled = False
        btnSYCancelUpdate.Visible = False
        txtSYStart.Clear()
        txtSYEnd.Clear()
        txtSYID.Clear()
    End Sub

    '============SAVE UPDATE===========
    Private Sub btnSYUpdate_Click(sender As Object, e As EventArgs) Handles btnSYUpdate.Click
        If txtSYStart.Text = "" Then
            MsgBox("Please insert start year.", vbCritical, "Warning!")
            Exit Sub
        End If

        If txtSYEnd.Text = "" Then
            MsgBox("Please insert end year.", vbCritical, "Warning!")
            Exit Sub
        End If

        'CHECK DUPLICATION
        Dim sql As String
        sql = "select count(*) from school_yr_tbl where sy_yrstart like '%" & txtSYStart.Text & "%' and sy_yrend like '%" & txtSYEnd.Text & "%'"
        If checkDuplicate(sql) = True Then
            MsgBox("Duplicate of record or no changes has been made.", vbCritical, "Warning!")
            Exit Sub
        End If

        Dim str_qry As String
        str_qry = "update school_yr_tbl set sy_yrstart = '" & txtSYStart.Text & "', sy_yrend = '" & txtSYEnd.Text & "' where sy_id = '" & txtSYID.Text & "'"
        If updateData(str_qry) = False Then
            MsgBox("Failed to update.", vbCritical, "Error!")
            btnSave.Enabled = True
            Exit Sub
        End If
        MsgBox("Successfully updated.", vbInformation, "Information")
        loadSchoolYear()
        txtSYStart.Clear()
        txtSYEnd.Clear()
        btnSYUpdate.Enabled = False
        btnSYUpdate.Visible = False
        btnSYCancelUpdate.Enabled = False
        btnSYCancelUpdate.Visible = False
    End Sub

    Private Sub btnSYDeleteRow_Click(sender As Object, e As EventArgs) Handles btnSYDeleteRow.Click
        Dim ans As String = MsgBox("Are you sure you want to delete school year '" & DataGridView3.SelectedCells(1).Value & "' - '" & DataGridView3.SelectedCells(2).Value & "'?", vbYesNo, "Alert")
        If ans = DialogResult.Yes Then
            Dim sql As String = "delete from school_yr_tbl where sy_id = '" & DataGridView3.SelectedCells(0).Value & "'"
            If deleteData(sql) = False Then
                MsgBox("Failed to delete record.", vbCritical, "Warning!")
                Exit Sub
            End If
            MsgBox("Successfully deleted.", vbInformation, "Information")
            loadSchoolYear()
        End If
    End Sub

    Private Sub btnSYSearch_Click(sender As Object, e As EventArgs) Handles btnSYSearch.Click
        If txtSYSearch.Text = "" Then
            loadSchoolYear()
            Exit Sub
        End If
        searchSchoolYear(txtSYSearch.Text)
    End Sub

    '===============FOR SEMESTER TAB ===========================
    Private Sub btnSemSave_Click(sender As Object, e As EventArgs) Handles btnSemSave.Click
        btnSemSave.Enabled = False
        If txtSemName.Text = "" Then
            MsgBox("Please insert Semester name.", vbCritical, "Warning!")
            btnSemSave.Enabled = True
            Exit Sub
        End If

        If dpSemStart.Value >= dpSemEnd.Value Then
            MsgBox("Start Date must not be greater than End Date.", vbCritical, "Warning!")
            btnSemSave.Enabled = True
            Exit Sub
        End If

        'Check Duplicate
        Dim sql As String
        sql = "select count(*) from semester_tbl where sem_name like '%" & txtSemName.Text & "%'" &
            "and sem_start='" & dpSemStart.Value & "' and sem_end='" & dpSemEnd.Value & "'"
        If checkDuplicate(sql) = True Then
            MsgBox("Duplication of Entry.", vbCritical, "Warning!")
            btnSemSave.Enabled = True
            Exit Sub
        End If

        Dim qry As String
        qry = "insert into semester_tbl(sem_name,sem_start,sem_end)" &
            "values('" & txtSemName.Text & "','" & dpSemStart.Value & "','" & dpSemEnd.Value & "')"
        If insertData(qry) = False Then
            MsgBox("Failed to add new Semester.", vbCritical, "Warning")
            btnSemSave.Enabled = True
            Exit Sub
        End If
        MsgBox("Successfully Saved.", vbInformation, "Information")
        txtSemName.Clear()
        dpSemStart.Value = Date.Now
        dpSemEnd.Value = Date.Now
        btnSemSave.Enabled = True
        loadSemester()
    End Sub

    '=============LOAD SEMESTER TABLE===============
    Sub loadSemester()
        openCon()
        Try
            Dim dataadapter As New SqlDataAdapter("select * from semester_tbl", conn)
            Dim ds As New DataSet()
            DataGridView4.Rows.Clear()
            dataadapter.Fill(ds, "semester_table")
            conn.Close()
            If ds.Tables(0).Rows.Count < 1 Then
                'MsgBox("No record to display.", vbInformation, "Information")
                Exit Sub
            End If

            For Each dr As DataRow In ds.Tables(0).Rows
                DataGridView4.Rows.Add(dr.Item("sem_id"), dr.Item("sem_name"), dr.Item("sem_start"), dr.Item("sem_end"))
            Next

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
            Exit Sub
        End Try
    End Sub

    Sub searchSemester(ByRef search_str As String)
        openCon()
        Try
            Dim dataadapter As New SqlDataAdapter("select * from semester_tbl where sem_name like '%" & search_str & "%'" &
                                                  " or sem_start like '%" & search_str & "%' or sem_end like '%" & search_str & "%'", conn)
            Dim ds As New DataSet()
            DataGridView4.Rows.Clear()
            dataadapter.Fill(ds, "semester_table")
            conn.Close()
            If ds.Tables(0).Rows.Count < 1 Then
                'MsgBox("No record to display.", vbInformation, "Information")
                Exit Sub
            End If

            For Each dr As DataRow In ds.Tables(0).Rows
                DataGridView4.Rows.Add(dr.Item("sem_id"), dr.Item("sem_name"), dr.Item("sem_start"), dr.Item("sem_end"))
            Next

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
            Exit Sub
        End Try
    End Sub

    Private Sub btnSemUpdateRow_Click(sender As Object, e As EventArgs) Handles btnSemUpdateRow.Click
        btnSemUpdate.Enabled = True
        btnSemUpdate.Visible = True
        btnSemCancelUpdate.Enabled = True
        btnSemCancelUpdate.Visible = True

        txtSemID.Text = DataGridView4.SelectedCells(0).Value
        txtSemName.Text = DataGridView4.SelectedCells(1).Value
        dpSemStart.Value = DataGridView4.SelectedCells(2).Value
        dpSemEnd.Value = DataGridView4.SelectedCells(3).Value
    End Sub

    Private Sub btnSemCancelUpdate_Click(sender As Object, e As EventArgs) Handles btnSemCancelUpdate.Click
        btnSemUpdate.Enabled = False
        btnSemUpdate.Visible = False
        btnSemCancelUpdate.Enabled = False
        btnSemCancelUpdate.Visible = False

        txtSemID.Clear()
        txtSemName.Clear()
        dpSemStart.Value = Date.Now
        dpSemEnd.Value = Date.Now
    End Sub

    Private Sub btnSemUpdate_Click(sender As Object, e As EventArgs) Handles btnSemUpdate.Click
        btnSemCancelUpdate.Enabled = False
        btnSemUpdate.Enabled = False

        If txtSemName.Text = "" Then
            MsgBox("Please insert Semester name.", vbCritical, "Warning!")
            btnSemCancelUpdate.Enabled = True
            btnSemUpdate.Enabled = True
            Exit Sub
        End If

        If dpSemStart.Value >= dpSemEnd.Value Then
            MsgBox("Start Date must not be greater than End Date.", vbCritical, "Warning!")
            btnSemCancelUpdate.Enabled = True
            btnSemUpdate.Enabled = True
            Exit Sub
        End If

        'Check Duplicate
        Dim sql As String
        sql = "select count(*) from semester_tbl where sem_name like '%" & txtSemName.Text & "%'" &
            "and sem_start='" & dpSemStart.Value & "' and sem_end='" & dpSemEnd.Value & "'"
        If checkDuplicate(sql) = True Then
            MsgBox("Duplication of Entry.", vbCritical, "Warning!")
            btnSemCancelUpdate.Enabled = True
            btnSemUpdate.Enabled = True
            Exit Sub
        End If

        Dim qry As String
        qry = "update semester_tbl set sem_name = '" & txtSemName.Text & "'" &
            ",sem_start = '" & dpSemStart.Value & "', sem_end = '" & dpSemEnd.Value & "' where sem_id = '" & txtSemID.Text & "'"
        If updateData(qry) = False Then
            MsgBox("Update failed.", vbCritical, "Warning")
            btnSemCancelUpdate.Enabled = True
            btnSemUpdate.Enabled = True
            Exit Sub
        End If
        MsgBox("Successfully Updated.", vbInformation, "Information")
        txtSemName.Clear()
        dpSemStart.Value = Date.Now
        dpSemEnd.Value = Date.Now
        btnSemUpdate.Enabled = False
        btnSemCancelUpdate.Enabled = False
        btnSemUpdate.Visible = False
        btnSemCancelUpdate.Visible = False
        btnSemSave.Enabled = True
        loadSemester()
    End Sub

    Private Sub btnSemDeleteRow_Click(sender As Object, e As EventArgs) Handles btnSemDeleteRow.Click
        Dim ans As String = MsgBox("Are you sure you want to delete semester '" & DataGridView4.SelectedCells(1).Value & "' dated '" & DataGridView4.SelectedCells(2).Value & "' - '" & DataGridView4.SelectedCells(3).Value & "'?", vbYesNo, "Alert")
        If ans = DialogResult.Yes Then
            Dim sql As String = "delete from semester_tbl where sem_id = '" & DataGridView4.SelectedCells(0).Value & "'"
            If deleteData(sql) = False Then
                MsgBox("Failed to delete record.", vbCritical, "Warning!")
                Exit Sub
            End If
            MsgBox("Successfully deleted.", vbInformation, "Information")
            loadSemester()
        End If
    End Sub

    Private Sub btnSemSearch_Click(sender As Object, e As EventArgs) Handles btnSemSearch.Click
        If txtSemSearch.Text = "" Then
            loadSemester()
            Exit Sub
        End If
        searchSemester(txtSemSearch.Text)
    End Sub

    '===================ROOM TAB=========================
    Sub fill_cmbRoomDepartment()
        Try
            openCon()
            myCmd.Connection = conn
            myCmd.CommandText = "SELECT * FROM department_tbl"
            'myReader = myCmd.ExecuteReader()
            Dim sqlAdapter As New SqlDataAdapter(myCmd)

            Dim cmbdepartmenttbl As New DataTable()

            sqlAdapter.Fill(cmbdepartmenttbl)

            cmbRoomDepartment.DataSource = cmbdepartmenttbl

            cmbRoomDepartment.DisplayMember = "dep_name"
            cmbRoomDepartment.ValueMember = "dep_id"

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
            Exit Sub
        End Try
    End Sub

    Private Sub btnRoomSave_Click(sender As Object, e As EventArgs) Handles btnRoomSave.Click
        btnRoomSave.Enabled = False
        If txtRoomCode.Text = "" Then
            MsgBox("Room code is empty.", vbCritical, "Warning!")
            btnRoomSave.Enabled = True
            Exit Sub
        End If
        If txtRoomName.Text = "" Then
            MsgBox("Room name is empty.", vbCritical, "Warning!")
            btnRoomSave.Enabled = True
            Exit Sub
        End If

        'Check Duplicate
        Dim sql As String
        sql = "select count(*) from room_tbl where room_code like '%" & txtRoomCode.Text & "%'" &
            "and room_name like '%" & txtRoomName.Text & "%'"
        If checkDuplicate(sql) = True Then
            MsgBox("Duplication of Entry.", vbCritical, "Warning!")
            btnSemCancelUpdate.Enabled = True
            btnSemUpdate.Enabled = True
            Exit Sub
        End If

        'INSERT
        Dim qry As String
        qry = "insert into room_tbl(room_code,room_name,dep_id)" &
            "values('" & txtRoomCode.Text & "','" & txtRoomName.Text & "','" & cmbRoomDepartment.SelectedValue & "')"
        If insertData(qry) = False Then
            MsgBox("Failed to add new room.", vbCritical, "Warning!")
            btnRoomSave.Enabled = True
            Exit Sub
        End If
        MsgBox("Successfully added.", vbInformation, "Information")
        txtRoomCode.Clear()
        txtRoomName.Clear()
        cmbRoomDepartment.SelectedIndex = -1
        btnRoomSave.Enabled = True
        loadRoom()
    End Sub

    Sub loadRoom()
        openCon()
        Try
            Dim dataadapter As New SqlDataAdapter("select a.room_id, a.dep_id as department_id, a.room_code, a.room_name, b.dep_name as department" &
                                                  " from room_tbl as a inner join department_tbl as b on a.dep_id = b.dep_id", conn)
            Dim ds As New DataSet()
            DataGridView5.Rows.Clear()
            dataadapter.Fill(ds, "room_table")
            conn.Close()
            If ds.Tables(0).Rows.Count < 1 Then
                'MsgBox("No record to display.", vbInformation, "Information")
                Exit Sub
            End If

            For Each dr As DataRow In ds.Tables(0).Rows
                DataGridView5.Rows.Add(dr.Item("room_id"), dr.Item("department_id"), dr.Item("room_code"), dr.Item("room_name"), dr.Item("department"))
            Next

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
            Exit Sub
        End Try
    End Sub
    Sub searchRoom(ByRef str_search As String)
        openCon()
        Try
            Dim dataadapter As New SqlDataAdapter("select a.room_id, a.dep_id as department_id, a.room_code, a.room_name, b.dep_name as department" &
                                                  " from room_tbl as a inner join department_tbl as b on a.dep_id = b.dep_id where a.room_code like '%" & str_search & "%'" &
                                                  "or a.room_name like '%" & str_search & "%' or b.dep_name like '%" & str_search & "%'", conn)
            Dim ds As New DataSet()
            DataGridView5.Rows.Clear()
            dataadapter.Fill(ds, "room_table")
            conn.Close()
            If ds.Tables(0).Rows.Count < 1 Then
                'MsgBox("No record to display.", vbInformation, "Information")
                Exit Sub
            End If

            For Each dr As DataRow In ds.Tables(0).Rows
                DataGridView5.Rows.Add(dr.Item("room_id"), dr.Item("department_id"), dr.Item("room_code"), dr.Item("room_name"), dr.Item("department"))
            Next

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
            Exit Sub
        End Try
    End Sub

    Private Sub UpdateRoomRow_Click(sender As Object, e As EventArgs) Handles UpdateRoomRow.Click
        btnUpdateRoom.Visible = True
        btnUpdateRoom.Enabled = True
        btnCancelUpdateRoom.Visible = True
        btnCancelUpdateRoom.Enabled = True

        txtRoomID.Text = DataGridView5.SelectedCells(0).Value
        txtRoomCode.Text = DataGridView5.SelectedCells(2).Value
        txtRoomName.Text = DataGridView5.SelectedCells(3).Value
        cmbRoomDepartment.SelectedValue = DataGridView5.SelectedCells(1).Value
    End Sub

    Private Sub btnCancelUpdateRoom_Click(sender As Object, e As EventArgs) Handles btnCancelUpdateRoom.Click
        btnUpdateRoom.Visible = False
        btnUpdateRoom.Enabled = False
        txtRoomID.Clear()
        txtRoomCode.Clear()
        txtRoomName.Clear()
        cmbRoomDepartment.SelectedIndex = -1
        btnCancelUpdateRoom.Visible = False
        btnCancelUpdateRoom.Visible = False
    End Sub

    Private Sub btnUpdateRoom_Click(sender As Object, e As EventArgs) Handles btnUpdateRoom.Click
        btnUpdateRoom.Enabled = False
        btnCancelUpdateRoom.Enabled = False

        If txtRoomCode.Text = "" Then
            MsgBox("Room code is empty.", vbCritical, "Warning!")
            btnRoomSave.Enabled = True
            Exit Sub
        End If
        If txtRoomName.Text = "" Then
            MsgBox("Room name is empty.", vbCritical, "Warning!")
            btnRoomSave.Enabled = True
            Exit Sub
        End If

        'Check Duplicate
        Dim sql As String
        sql = "select count(*) from room_tbl where room_code like '%" & txtRoomCode.Text & "%'" &
            "and room_name like '%" & txtRoomName.Text & "%'"
        If checkDuplicate(sql) = True Then
            MsgBox("Duplication of Entry.", vbCritical, "Warning!")
            btnSemCancelUpdate.Enabled = True
            btnSemUpdate.Enabled = True
            Exit Sub
        End If

        'UPDATE
        Dim qry As String
        qry = "update room_tbl set room_code = '" & txtRoomCode.Text & "', room_name = '" & txtRoomName.Text & "'" &
            ",dep_id = '" & cmbRoomDepartment.SelectedValue & "' where room_id='" & txtRoomID.Text & "'"
        If updateData(qry) = False Then
            MsgBox("Failed to update.", vbCritical, "Warning!")
            btnRoomSave.Enabled = True
            Exit Sub
        End If
        MsgBox("Successfully updated.", vbInformation, "Information")
        txtRoomCode.Clear()
        txtRoomName.Clear()
        cmbRoomDepartment.SelectedIndex = -1
        btnUpdateRoom.Visible = False
        btnUpdateRoom.Enabled = False
        btnCancelUpdateRoom.Enabled = False
        btnCancelUpdateRoom.Visible = False
        btnRoomSave.Enabled = True
        loadRoom()
    End Sub

    Private Sub btnRoomDeleteRow_Click(sender As Object, e As EventArgs) Handles btnRoomDeleteRow.Click
        Dim ans As String = MsgBox("Are you sure you want to delete room '" & DataGridView5.SelectedCells(2).Value & "' with name '" & DataGridView5.SelectedCells(3).Value & "'?", vbYesNo, "Alert")
        If ans = DialogResult.Yes Then
            Dim sql As String = "delete from room_tbl where room_id = '" & DataGridView5.SelectedCells(0).Value & "'"
            If deleteData(sql) = False Then
                MsgBox("Failed to delete record.", vbCritical, "Warning!")
                Exit Sub
            End If
            MsgBox("Successfully deleted.", vbInformation, "Information")
            loadRoom()
        End If
    End Sub

    Private Sub btnSearchRoom_Click(sender As Object, e As EventArgs) Handles btnSearchRoom.Click
        If txtSearchRoom.Text = "" Then
            loadRoom()
            Exit Sub
        End If
        searchRoom(txtSearchRoom.Text)
    End Sub
End Class