Imports System.Data.SqlClient
Public Class FormParent
    Private Sub FormParent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim child_form As New FormLogin
        child_form.MdiParent = Me
        child_form.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim ans As String = MsgBox("Are you sure you want to logout?", vbYesNo, "Alert")
        If ans = DialogResult.Yes Then
            Me.Close()
        End If
        'Me.Close()
    End Sub

    Private Sub PanelSchedule_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click, PanelSchedule.Click, Label1.Click
        FormSchedule.ShowDialog()
    End Sub

    Private Sub PanelPrint_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click, PanelPrint.Click, Label2.Click
        FormPrint.Show()
    End Sub

    Private Sub PanelAdminSettings_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click, PanelAdminSettings.Click, Label3.Click
        If user_type <> 1 Then
            MsgBox("Only Administrator can access this settings.", vbCritical, "Warning!")
            Exit Sub
        End If
        FormAdminSettings.ShowDialog()
    End Sub

    Sub loadSchedule()
        openCon()
        Try
            Dim dataadapter As New SqlDataAdapter("select a.subj_id,a.subj_code,a.subj_name,a.subj_unit,a.subj_start,a.subj_end" &
                                                  ",b.dep_id, b.dep_name,c.room_id,c.room_name,d.sem_id,d.sem_name " &
                                                  "from subject_tbl as a inner join department_tbl as b on a.dep_id = b.dep_id " &
                                                  "inner join room_tbl as c on a.room_id = c.room_id " &
                                                  "inner join semester_tbl as d on a.sem_id = d.sem_id where a.ins_id = '" & user_id & "'", conn)
            Dim ds As New DataSet()
            DataGridView1.Rows.Clear()
            dataadapter.Fill(ds, "subj_table")
            conn.Close()
            If ds.Tables(0).Rows.Count < 1 Then
                'MsgBox("No record to display.", vbInformation, "Information")
                Exit Sub
            End If

            For Each dr As DataRow In ds.Tables(0).Rows
                DataGridView1.Rows.Add(dr.Item("subj_id"), dr.Item("subj_code"), dr.Item("subj_name"), dr.Item("subj_unit"), dr.Item("subj_start"), dr.Item("subj_end"),
                                       dr.Item("dep_id"), dr.Item("dep_name"), dr.Item("room_id"), dr.Item("room_name"), dr.Item("sem_id"), dr.Item("sem_name"))
            Next


        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
            Exit Sub
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim editform As New FormSchedule

        editform.txtSubjectCode.Text = DataGridView1.SelectedCells(1).Value
        editform.txtSubjectID.Text = DataGridView1.SelectedCells(0).Value
        editform.txtSubjectName.Text = DataGridView1.SelectedCells(2).Value
        editform.txtUnit.Text = DataGridView1.SelectedCells(3).Value
        editform.txtSubjectStart.Text = DataGridView1.SelectedCells(4).Value.ToString
        editform.txtSubjectEnd.Text = DataGridView1.SelectedCells(5).Value.ToString
        editform.v1 = DataGridView1.SelectedCells(6).Value
        editform.v2 = DataGridView1.SelectedCells(8).Value
        editform.v3 = DataGridView1.SelectedCells(10).Value

        editform.ShowDialog()


    End Sub

    Private Sub btnDeleteRow_Click(sender As Object, e As EventArgs) Handles btnDeleteRow.Click
        Dim ans As String = MsgBox("Are you sure you want to delete '" & DataGridView1.SelectedCells(1).Value & "'?", vbYesNo, "Alert")
        If ans = DialogResult.Yes Then
            Dim sql As String = "delete from subject_tbl where subj_id = '" & DataGridView1.SelectedCells(0).Value & "'"
            If deleteData(sql) = False Then
                MsgBox("Failed to delete record.", vbCritical, "Warning!")
                Exit Sub
            End If
            MsgBox("Successfully deleted.", vbInformation, "Information")
            loadSchedule()
        End If
    End Sub
End Class