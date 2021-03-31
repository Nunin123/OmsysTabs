Public Class frmMain
    Private Sub btnManageOrder_Click(sender As Object, e As EventArgs) Handles btnManageOrder.Click
        Dim ManageOrder As New btnAdd
        ManageOrder.Show()
    End Sub

    Private Sub btnManageStock_Click(sender As Object, e As EventArgs) Handles btnManageStock.Click
        Dim ManageStocks As New frmMainScreen2
        ManageStocks.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim frmManageOrder As New btnAdd
        Dim frmManageStocks As New frmMainScreen2
        Dim LoginForm As New frmLogin

        Dim choice As DialogResult = MessageBox.Show("Are you sure want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo)
        If choice = DialogResult.Yes Then
            LoginForm.Show()
            frmManageOrder.Close()
            frmManageStocks.Close()
            Close()
        End If
    End Sub
End Class