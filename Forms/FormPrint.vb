Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports System.Collections.Generic
Public Class FormPrint
    Private Sub FormPrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fill_cmbSemester()
        cmbSemester.SelectedIndex = -1
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        If cmbSemester.SelectedIndex = -1 Then
            MsgBox("Please select semester.", vbCritical, "Warning")
            Exit Sub
        End If
        Me.ReportViewer1.RefreshReport()
        load_report()
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

    Sub load_report()
        Dim rptDataSource As ReportDataSource
        Try
            With ReportViewer1.LocalReport
                .ReportPath = Application.StartupPath & "\Reports\ReportSchedule.rdlc"
                .DataSources.Clear()
            End With



            Dim dSet As New DataSet1
            Dim dAdapter As New SqlDataAdapter
            Dim fDate As String = "Semister : " & cmbSemester.Text & ""
            Dim parameters As IList(Of ReportParameter) = New List(Of ReportParameter)
            parameters.Add(New ReportParameter("param_semester", fDate))
            parameters.Add(New ReportParameter("param_by", FormParent.labelFullname.Text))


            openCon()
            dAdapter.SelectCommand = New SqlCommand("EXEC dbo.repSchedule '" & cmbSemester.SelectedValue & "','" & user_id & "'", conn)
            'dAdapter.SelectCommand = New SqlCommand("EXEC dbo.repSchedule 1", conn)
            'dAdapter.SelectCommand = New SqlCommand("EXEC dbo.generateDispatchedSummary", conn)
            dAdapter.Fill(dSet.Tables("dtSchedule"))
            conn.Close()

            rptDataSource = New ReportDataSource("DataSet1", dSet.Tables("dtSchedule"))
            ReportViewer1.LocalReport.DataSources.Add(rptDataSource)
            ReportViewer1.LocalReport.SetParameters(parameters)
            ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            ReportViewer1.ZoomMode = ZoomMode.Percent
            ReportViewer1.ZoomPercent = 100

        Catch ex As Exception
            conn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try

        cmbSemester.SelectedIndex = -1
    End Sub
End Class