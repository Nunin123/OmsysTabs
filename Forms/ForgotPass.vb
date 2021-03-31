Public Class ForgotPass
    'Public userPass2 As String
    Private Sub btnEnterKey_Click(sender As Object, e As EventArgs) Handles btnEnterKey.Click
        If txtMasterKey.Text = "10aKNLjJgl26" Then

            panelResetPass.Visible = True
        ElseIf txtMasterKey.Text = "" Then
            MessageBox.Show("Please input a master key.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            MessageBox.Show("Incorrect master key. Please try again.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub btnSubmitNewPass_Click(sender As Object, e As EventArgs) Handles btnSubmitNewPass.Click
        Dim userPass2 As String

        If txtNewPass.Text = txtConfirmPass.Text Then
            userPass2 = txtConfirmPass.Text
            'frmLogin.userPass = userPass2
            My.Settings.Password = userPass2
            My.Settings.Save()
            Dim okay As DialogResult = MessageBox.Show("Password has been changed successfully!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If okay = DialogResult.OK Then
                Close()
            End If
        Else
            MessageBox.Show("Passwords do not match.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        panelMasterKey.Visible = False
        Panel1.Visible = True
    End Sub

    Private Sub btnSubmitSecQA_Click(sender As Object, e As EventArgs) Handles btnSubmitSecQA.Click
        If txtSecQAnswer.Text = "Taco" Then
            panelResetPass.Visible = True
            Panel1.Visible = False
        ElseIf txtSecQAnswer.Text = "" Then
            MessageBox.Show("Please input an answer.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            MessageBox.Show("Incorrect answer. Please try again.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class