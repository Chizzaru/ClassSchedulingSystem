Imports System.Data.SqlClient
Imports System.Data
Module dbaseModule
    Public myCmd As New SqlCommand
    Public myReader As SqlDataReader
    Public results As String
    Public conn As New SqlConnection
    Dim server As String = GetIniValue("SQLServer", "IP", My.Application.Info.DirectoryPath & "\Options.ini")
    Dim user As String = GetIniValue("SQLServer", "User", My.Application.Info.DirectoryPath & "\Options.ini")
    Dim pword As String = GetIniValue("SQLServer", "Pass", My.Application.Info.DirectoryPath & "\Options.ini")
    Dim dbase As String = GetIniValue("SQLServer", "Dbase", My.Application.Info.DirectoryPath & "\Options.ini")

    Public user_id, user_type As String
    Public userName As String

    Sub openCon()
        conn = New SqlConnection("Data Source=" + server + "; Initial Catalog=" + dbase + "; User ID=" + user + "; Password=" + decrypt(pword) + ";")
        Try
            conn.Open()
            'MessageBox.Show("My Database Connection Successfully Connected")
            'conn.Close()
        Catch errex As Exception
            MessageBox.Show("My Database Connection Problem")
        End Try
    End Sub

    Sub showUserInfo(ByRef userid As String)
        openCon()
        Try
            myCmd.Connection = conn
            myCmd.CommandText = " SELECT user_name, title FROM user_tbl WHERE user_id='" + userid + "' "
            myReader = myCmd.ExecuteReader()
            myReader.Read()
            FormParent.labelFullname.Text = myReader.Item(0)
            FormParent.LabelType.Text = myReader.Item(1)
            myReader.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Function checkUser(ByRef username As String, ByRef password As String) As Integer
        openCon()
        Try
            myCmd.Connection = conn
            myCmd.CommandText = " SELECT user_id, user_name, user_type FROM dbo.user_tbl WHERE [user_uname]='" + username + "' AND [user_pass]='" + password + "' "
            myReader = myCmd.ExecuteReader()
            myReader.Read()
            user_id = myReader.Item(0)
            user_type = myReader.Item(2)
            myReader.Close()
            conn.Close()
        Catch ex As Exception

        End Try

        Return user_type

    End Function


    Public Function insertData(ByRef qry As String) As Boolean
        Dim ret As Boolean
        Try
            openCon()
            myCmd.Connection = conn
            myCmd.CommandText = qry
            myReader = myCmd.ExecuteReader()
            conn.Close()
            ret = True
        Catch ex As Exception
            'conn.Close()
            'MsgBox(ex.Message, vbCritical, "Error!")
            ret = False
        End Try
        Return ret
    End Function

    Public Function updateData(ByRef qry As String) As Boolean
        Dim ret As Boolean
        Try
            openCon()
            myCmd.Connection = conn
            myCmd.CommandText = qry
            myReader = myCmd.ExecuteReader()
            conn.Close()
            ret = True
        Catch ex As Exception
            'conn.Close()
            'MsgBox(ex.Message, vbCritical, "Error!")
            ret = False
        End Try
        Return ret
    End Function

    Public Function deleteData(ByRef qry As String) As Boolean
        Dim ret As Boolean
        Try
            openCon()
            myCmd.Connection = conn
            myCmd.CommandText = qry
            myReader = myCmd.ExecuteReader()
            conn.Close()
            ret = True
        Catch ex As Exception
            'conn.Close()
            'MsgBox(ex.Message, vbCritical, "Error!")
            ret = False
        End Try
        Return ret
    End Function

    'CHECKING FOR DUPLICATION========================
    Public Function checkDuplicate(ByRef qry As String) As Boolean
        openCon()
        myCmd.Connection = conn
        myCmd.CommandText = qry
        myReader = myCmd.ExecuteReader()
        myReader.Read()
        Dim result_count = myReader.Item(0)
        conn.Close()
        If result_count < 1 Then
            Return False
        Else
            Return True
        End If
    End Function


End Module
