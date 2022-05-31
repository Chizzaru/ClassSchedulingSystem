Imports System.Data.SqlClient
Public Class FormSchedule
    Public v1, v2, v3 As String
    Private Sub FormSchedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If txtSubjectID.Text = "" Then
            fillComboBox1()
            Exit Sub
        End If
        fillComboBox()
        forcmbedit(v1, v2, v3)
    End Sub
    '===================FOR COMBO BOX=========================
    Sub fill_cmbDepartment()
        Try
            openCon()
            myCmd.Connection = conn
            myCmd.CommandText = "SELECT * FROM department_tbl"
            'myReader = myCmd.ExecuteReader()
            Dim sqlAdapter As New SqlDataAdapter(myCmd)

            Dim cmbdepartmenttbl As New DataTable()

            sqlAdapter.Fill(cmbdepartmenttbl)

            cmbDepartment.DataSource = cmbdepartmenttbl

            cmbDepartment.DisplayMember = "dep_name"
            cmbDepartment.ValueMember = "dep_id"

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
            Exit Sub
        End Try
    End Sub
    Sub fill_cmbRoom()
        Try
            openCon()
            myCmd.Connection = conn
            myCmd.CommandText = "SELECT * FROM room_tbl"
            'myReader = myCmd.ExecuteReader()
            Dim sqlAdapter As New SqlDataAdapter(myCmd)

            Dim cmbroomtbl As New DataTable()

            sqlAdapter.Fill(cmbroomtbl)

            cmbRoom.DataSource = cmbroomtbl

            cmbRoom.DisplayMember = "room_code"
            cmbRoom.ValueMember = "room_id"

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
            Exit Sub
        End Try
    End Sub
    Sub fill_cmbSemester()
        Try
            openCon()
            myCmd.Connection = conn
            myCmd.CommandText = "SELECT * FROM semester_tbl"
            'myReader = myCmd.ExecuteReader()
            Dim sqlAdapter As New SqlDataAdapter(myCmd)

            Dim cmbsemestertbl As New DataTable()

            sqlAdapter.Fill(cmbsemestertbl)

            cmbSemester.DataSource = cmbsemestertbl

            cmbSemester.DisplayMember = "sem_name"
            cmbSemester.ValueMember = "sem_id"

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
            Exit Sub
        End Try
    End Sub
    '======================TO FILL COMBO BOX================
    Sub fillComboBox()
        fill_cmbDepartment()
        'cmbDepartment.SelectedIndex = -1
        fill_cmbRoom()
        'cmbRoom.SelectedIndex = -1
        fill_cmbSemester()
        'cmbSemester.SelectedIndex = -1
    End Sub
    Sub fillComboBox1()
        fill_cmbDepartment()
        cmbDepartment.SelectedIndex = -1
        fill_cmbRoom()
        cmbRoom.SelectedIndex = -1
        fill_cmbSemester()
        cmbSemester.SelectedIndex = -1
    End Sub

    Private Sub btnSaveSchedule_Click(sender As Object, e As EventArgs) Handles btnSaveSchedule.Click
        btnSaveSchedule.Enabled = False
        btnCancel.Enabled = False
        If txtSubjectCode.Text = "" Or txtSubjectName.Text = "" Or txtUnit.Text = "" Or txtSubjectStart.Text = "" Or txtSubjectEnd.Text = "" Or cmbDepartment.SelectedIndex = -1 Or cmbRoom.SelectedIndex = -1 Or cmbSemester.SelectedIndex = -1 Then
            MsgBox("All fields are required.", vbCritical, "Warning!")
            btnSaveSchedule.Enabled = True
            btnCancel.Enabled = True
            Exit Sub
        End If

        'INSERT
        Dim str_qry As String
        str_qry = "insert into subject_tbl(subj_code, subj_name,subj_unit,subj_start,subj_end,ins_id,dep_id,room_id, sem_id)" &
            "values('" & txtSubjectCode.Text & "','" & txtSubjectName.Text & "','" & txtUnit.Text & "','" & txtSubjectStart.Text & "','" & txtSubjectEnd.Text & "','" & user_id & "','" & cmbDepartment.SelectedValue & "'," &
            "'" & cmbRoom.SelectedValue & "','" & cmbSemester.SelectedValue & "')"
        If insertData(str_qry) = False Then
            MsgBox("New user failed to add.", vbCritical, "Error!")
            btnSaveSchedule.Enabled = True
            btnCancel.Enabled = True
            Exit Sub
        End If
        MsgBox("Successfully created class.", vbInformation, "Success")

        txtSubjectCode.Clear()
        txtSubjectName.Clear()
        txtUnit.Clear()
        txtSubjectStart.Clear()
        txtSubjectEnd.Clear()
        cmbDepartment.SelectedIndex = -1
        cmbRoom.SelectedIndex = -1
        cmbSemester.SelectedIndex = -1

        btnSaveSchedule.Enabled = True
        btnCancel.Enabled = True
        FormParent.loadSchedule()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        btnUpdate.Enabled = False
        btnCancel.Enabled = False
        If txtSubjectCode.Text = "" Or txtSubjectName.Text = "" Or txtUnit.Text = "" Or txtSubjectStart.Text = "" Or txtSubjectEnd.Text = "" Or cmbDepartment.SelectedIndex = -1 Or cmbRoom.SelectedIndex = -1 Or cmbSemester.SelectedIndex = -1 Then
            MsgBox("All fields are required.", vbCritical, "Warning!")
            btnUpdate.Enabled = True
            btnCancel.Enabled = True
            Exit Sub
        End If

        'INSERT
        Dim str_qry As String
        str_qry = "update subject_tbl set subj_code = '" & txtSubjectCode.Text & "', subj_name='" & txtSubjectName.Text & "',subj_unit='" & txtUnit.Text & "'," &
            " subj_start='" & txtSubjectStart.Text & "',subj_end='" & txtSubjectEnd.Text & "',dep_id='" & cmbDepartment.SelectedValue & "',room_id='" & cmbRoom.SelectedValue & "', sem_id='" & cmbSemester.SelectedValue & "' where " &
            "subj_id = '" & txtSubjectID.Text & "'"
        If updateData(str_qry) = False Then
            MsgBox("Update failed.", vbCritical, "Error!")
            btnUpdate.Enabled = True
            btnCancel.Enabled = True
            Exit Sub
        End If
        MsgBox("Successfully updated.", vbInformation, "Success")
        btnUpdate.Enabled = True
        btnCancel.Enabled = True
        FormParent.loadSchedule()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtSubjectCode.Clear()
        txtSubjectName.Clear()
        txtUnit.Clear()
        txtSubjectStart.Clear()
        txtSubjectEnd.Clear()
        cmbDepartment.SelectedIndex = -1
        cmbRoom.SelectedIndex = -1
        cmbSemester.SelectedIndex = -1
        Me.Close()
    End Sub


    Sub forcmbedit(ByRef val1 As String, ByRef val2 As String, ByRef val3 As String)
        cmbDepartment.SelectedValue = val1
        cmbRoom.SelectedValue = val2
        cmbSemester.SelectedValue = val3
    End Sub

End Class