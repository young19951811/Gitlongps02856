Public Class frmlogin
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim user As String = txtuser.Text
        Dim password As String = txtPassword.Text
        If (user = "user" And password = "user") Then
            MessageBox.Show(
                "Chúc mừng nhân viên đã đăng nhập thành công ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.None)
            frmloading.Show()
            Me.Hide()
        Else
            If (password = "admin" And user = "admin") Then
                MessageBox.Show(
                    "Chúc mừng quản trị đã đăng nhập thành công ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.None)
                frmloading.Show()
                Me.Hide()
            Else
                MessageBox.Show(
                    "Vui lòng nhập username và password", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        txtuser.Text = ""
        txtPassword.Text = ""
    End Sub
End Class
