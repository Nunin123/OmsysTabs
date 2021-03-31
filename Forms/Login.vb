Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim mainScreen As New btnAdd
        Dim userPass As String

        userPass = My.Settings.Password

        If txtUsername.Text = "" Then
            MessageBox.Show("Please input a username.", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtPassword.Text = "" Then
            MessageBox.Show("Please input a password.", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtUsername.Text <> "1" Then
            MessageBox.Show("Incorrect username.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtPassword.Text <> userPass Then
            MessageBox.Show("Incorrect password.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            mainScreen.Show()
            Close()
        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim forgotPass As New ForgotPass

        forgotPass.Show()
    End Sub
End Class
