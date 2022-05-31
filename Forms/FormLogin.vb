Public Class FormLogin
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        FormParent.Dispose()
        FormParent.Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim UserTypeID As String = checkUser(txtUsername.Text, txtPassword.Text)
        If UserTypeID = 0 Then
            MsgBox("Invalid User", vbCritical)
            Exit Sub
        End If



        FormParent.ParentPanel.Visible = True
        showUserInfo(user_id)
        FormParent.loadSchedule()

        Me.Close()

    End Sub

    Private Sub txtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown, txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim UserTypeID As String = checkUser(txtUsername.Text, txtPassword.Text)
            If UserTypeID = 0 Then
                MsgBox("Invalid User", vbCritical)
                Exit Sub
            End If

            FormParent.ParentPanel.Visible = True
            showUserInfo(user_id)
            FormParent.loadSchedule()
            Me.Close()
        End If
    End Sub
End Class