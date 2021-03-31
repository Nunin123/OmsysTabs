Public Class btnAdd
    Dim yes As Boolean = False
    Sub dgv_styleRow()
        For i As Integer = 0 To OMSys_OrdersV2DBDataGridView.RowCount - 1
            If i Mod 2 = 0 Then
                OMSys_OrdersV2DBDataGridView.Rows(i).DefaultCellStyle.BackColor = System.Drawing.Color.White
            Else
                OMSys_OrdersV2DBDataGridView.Rows(i).DefaultCellStyle.BackColor = System.Drawing.Color.LightGray
            End If
        Next
    End Sub
    Sub dgv_styleRow2()
        For i As Integer = 0 To DataGridView1.RowCount - 1
            If i Mod 2 = 0 Then
                DataGridView1.Rows(i).DefaultCellStyle.BackColor = System.Drawing.Color.White
            Else
                DataGridView1.Rows(i).DefaultCellStyle.BackColor = System.Drawing.Color.LightGray
            End If
        Next
    End Sub
    Private Sub frmMainScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OMSysOrdersDBDataSet.OMSys_OrdersV2DB' table. You can move, or remove it, as needed.
        Me.OMSys_OrdersV2DBTableAdapter.Fill(Me.OMSysOrdersDBDataSet.OMSys_OrdersV2DB)

        Me.OMSys_StocksDBTableAdapter.Fill(Me.OMSysOrdersDBDataSet.OMSys_StocksDB)

        Dim myFNames = From n In OMSysOrdersDBDataSet.OMSys_OrdersV2DB Select n.Customer_FirstName

        txt_FirstName.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txt_FirstName.AutoCompleteSource = AutoCompleteSource.CustomSource

        txt_FirstName.AutoCompleteCustomSource.AddRange(myFNames.ToArray())

        Dim myLNames = From n In OMSysOrdersDBDataSet.OMSys_OrdersV2DB Select n.Customer_LastName

        txt_LastName.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txt_LastName.AutoCompleteSource = AutoCompleteSource.CustomSource

        txt_LastName.AutoCompleteCustomSource.AddRange(myLNames.ToArray())

        dgv_styleRow()
        dgv_styleRow2()

        DateTimePicker3.Enabled = False
        txt_StockName.Enabled = False
        txt_Stock.Enabled = False
        txt_Color.Enabled = False
        txt_OriginalPrice.Enabled = False
        txt_SellingPrice.Enabled = False
        cmb_Size.Enabled = False

        cmb_Status.Enabled = False
        txt_ProductName.Enabled = False
        txt_FirstName.Enabled = False
        txt_MiddleName.Enabled = False
        txt_LastName.Enabled = False
        txt_Quantity.Enabled = False
        txtPrice.Enabled = False
        txt_Address.Enabled = False
        txt_ContactNumber.Enabled = False
        RichTextBox1.Enabled = False
        DateTimePicker1.Enabled = False
        DateTimePicker2.Enabled = False
    End Sub
    Private Sub OMSys_OrdersDBBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.OMSys_OrdersV2DBBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OMSysOrdersDBDataSet)
    End Sub
    Private Sub doNothing()

    End Sub
    Private Sub displayAll()
        txtSearch.Text = ""

        Me.OMSys_OrdersV2DBTableAdapter.Fill(Me.OMSysOrdersDBDataSet.OMSys_OrdersV2DB)
        Me.OMSys_OrdersV2DBBindingSource.RemoveFilter()
        dgv_styleRow()
    End Sub
    Private Sub displayAll2()
        txtStockSearch.Text = ""

        Me.OMSys_StocksDBTableAdapter.Fill(Me.OMSysOrdersDBDataSet.OMSys_StocksDB)
        Me.OMSysStocksDBBindingSource.RemoveFilter()
        dgv_styleRow2()
    End Sub
    Private Sub btnViewAll_Click(sender As Object, e As EventArgs) Handles btnViewAll.Click
        Call displayAll()
    End Sub
    Private Sub OMSys_OrdersV2DBDataGridView_DataSourceChanged(sender As Object, e As EventArgs) Handles OMSys_OrdersV2DBDataGridView.DataSourceChanged
        dgv_styleRow()
    End Sub
    Private Sub btnAddOrder1_Click_1(sender As Object, e As EventArgs) Handles btnAddOrder1.Click
        OMSys_OrdersV2DBBindingSource.AddNew()
        cmb_Status.SelectedIndex = 0
        dgv_styleRow()
        cmb_Status.Enabled = True
        txt_ProductName.Enabled = True
        txt_FirstName.Enabled = True
        txt_MiddleName.Enabled = True
        txt_LastName.Enabled = True
        txt_Quantity.Enabled = True
        txtPrice.Enabled = True
        txt_Address.Enabled = True
        txt_ContactNumber.Enabled = True
        RichTextBox1.Enabled = True
        DateTimePicker1.Enabled = True
        DateTimePicker2.Enabled = True
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txt_ProductName.Text = "" Or txt_Quantity.Text = "" Or txt_LastName.Text = "" Or
            txt_FirstName.Text = "" Or txt_Address.Text = "" Or txt_ContactNumber.Text = "" Or cmb_Status.Text = "" Then

            MessageBox.Show("Please fill the required field/s.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                OMSys_OrdersV2DBBindingSource.EndEdit()
                OMSys_OrdersV2DBTableAdapter.Update(OMSysOrdersDBDataSet)
                MessageBox.Show("Order saved!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dgv_styleRow()
                cmb_Status.Enabled = False
                txt_ProductName.Enabled = False
                txt_FirstName.Enabled = False
                txt_MiddleName.Enabled = False
                txt_LastName.Enabled = False
                txt_Quantity.Enabled = False
                txtPrice.Enabled = False
                txt_Address.Enabled = False
                txt_ContactNumber.Enabled = False
                RichTextBox1.Enabled = False
                DateTimePicker1.Enabled = False
                DateTimePicker2.Enabled = False
            Catch ex As Exception
                ' MessageBox.Show("Database error, the application will restart to save the changes.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                'Application.Restart()
                ' Puwede yung code above pero pwede rin to, ikaw mamili kung ano mas maganda pag nag e-error
                Me.Refresh()
            End Try
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim choice As DialogResult = MessageBox.Show("Are you sure you want to delete this order?", "Delete", MessageBoxButtons.YesNo)
        If choice = DialogResult.Yes Then
            Try
                OMSys_OrdersV2DBBindingSource.RemoveCurrent()
                OMSys_OrdersV2DBBindingSource.EndEdit()
                OMSys_OrdersV2DBTableAdapter.Update(OMSysOrdersDBDataSet)
                dgv_styleRow()
            Catch ex As Exception

            End Try
        End If
        OMSys_OrdersV2DBBindingSource.MoveLast()

    End Sub

    Private Sub txt_Quantity_TextChanged(sender As Object, e As EventArgs) Handles txt_Quantity.TextChanged
        Dim total As Decimal

        total = Val(txtPrice.Text) * Val(txt_Quantity.Text)
        txt_TotalPrice.Text = total
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtSearch.Text = "" Then
            Call doNothing()
            Exit Sub
        Else
            OMSys_OrdersV2DBBindingSource.Filter = "(Convert(ID, 'System.String') LIKE '" & txtSearch.Text & "')" &
                "OR (Customer_FirstName LIKE '" & txtSearch.Text & "') OR (Product_Name LIKE '" & txtSearch.Text & "')" &
                "OR (Address LIKE '" & txtSearch.Text & "') OR (Status LIKE '" & txtSearch.Text & "')" &
                "OR (Customer_MiddleName LIKE '" & txtSearch.Text & "') OR (Customer_LastName LIKE '" & txtSearch.Text & "')"

            If OMSys_OrdersV2DBBindingSource.Count <> 0 Then
                With OMSys_OrdersV2DBDataGridView
                    .DataSource = OMSys_OrdersV2DBBindingSource
                End With
                dgv_styleRow()
            Else
                MessageBox.Show("Nothing found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                'OMSys_OrdersV2DBBindingSource = Nothing
                Call displayAll()
            End If
        End If
    End Sub

    Private Sub OMSys_OrdersV2DBDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles OMSys_OrdersV2DBDataGridView.CellClick

        cmb_Status.Enabled = True
        txt_ProductName.Enabled = True
        txt_FirstName.Enabled = True
        txt_MiddleName.Enabled = True
        txt_LastName.Enabled = True
        txt_Quantity.Enabled = True
        txtPrice.Enabled = True
        txt_Address.Enabled = True
        txt_ContactNumber.Enabled = True
        RichTextBox1.Enabled = True
        DateTimePicker1.Enabled = True
        DateTimePicker2.Enabled = True
    End Sub

    Private Sub btnClearFields_Click(sender As Object, e As EventArgs) Handles btnClearFields.Click
        Dim choice As DialogResult = MessageBox.Show("Are you sure you want to clear all the fields?", "Clear Fields", MessageBoxButtons.YesNo)
        If choice = DialogResult.Yes Then

            txt_ProductName.Text = ""
            txt_FirstName.Text = ""
            txt_MiddleName.Text = ""
            txt_LastName.Text = ""
            txt_Quantity.Text = ""
            txtPrice.Text = ""
            txt_Address.Text = ""
            txt_ContactNumber.Text = ""
            RichTextBox1.Text = ""
        End If
    End Sub

    Private Sub btnOrdersTab_Click(sender As Object, e As EventArgs) Handles btnOrdersTab.Click
        btnOrdersTab.BackColor = Drawing.Color.White
        btnOrdersTab.ForeColor = Drawing.Color.Black
        btnStocksTab.BackColor = Drawing.Color.DarkCyan
        btnStocksTab.ForeColor = Drawing.Color.White

        panelOrderList.Visible = True
        panelStockList.Visible = False
    End Sub

    Private Sub btnStocksTab_Click(sender As Object, e As EventArgs) Handles btnStocksTab.Click
        btnStocksTab.BackColor = Drawing.Color.White
        btnStocksTab.ForeColor = Drawing.Color.Black
        btnOrdersTab.BackColor = Drawing.Color.DarkCyan
        btnOrdersTab.ForeColor = Drawing.Color.White

        panelOrderList.Visible = False
        panelStockList.Visible = True
    End Sub

    Private Sub btnLogoutTab_Click(sender As Object, e As EventArgs) Handles btnLogoutTab.Click
        Dim LoginForm As New frmLogin

        Dim choice As DialogResult = MessageBox.Show("Are you sure want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo)
        If choice = DialogResult.Yes Then
            LoginForm.Show()
            Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtStockSearch.Text = "" Then
            Call doNothing()
            Exit Sub
        Else
            OMSysStocksDBBindingSource.Filter = "(Convert(ID, 'System.String') LIKE '" & txtStockSearch.Text & "')" &
                "OR (Material_Name LIKE '" & txtStockSearch.Text & "')" &
                "OR (Size LIKE '" & txtStockSearch.Text & "')" &
                "OR (Color LIKE '" & txtStockSearch.Text & "')"

            If OMSysStocksDBBindingSource.Count <> 0 Then
                With DataGridView1
                    .DataSource = OMSysStocksDBBindingSource
                End With
                dgv_styleRow2()
            Else
                MessageBox.Show("Nothing found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                'OMSys_OrdersV2DBBindingSource = Nothing
                Call displayAll2()
            End If
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call displayAll2()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DateTimePicker3.Checked = False
        OMSysStocksDBBindingSource.AddNew()
        cmb_Size.SelectedIndex = 0
        dgv_styleRow2()
        DateTimePicker3.Enabled = True
        txt_StockName.Enabled = True
        txt_Stock.Enabled = True
        txt_Color.Enabled = True
        txt_OriginalPrice.Enabled = True
        txt_SellingPrice.Enabled = True
        cmb_Size.Enabled = True
    End Sub

    Private Sub btnUpdateOrder_Click(sender As Object, e As EventArgs) Handles btnUpdateStock.Click
        If txt_StockName.Text = "" Or txt_Stock.Text = "" Or txt_Color.Text = "" Or txt_SellingPrice.Text = "" Or txt_OriginalPrice.Text = "" Then
            MessageBox.Show("Please fill the required field/s.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                OMSysStocksDBBindingSource.EndEdit()
                OMSys_StocksDBTableAdapter.Update(OMSysOrdersDBDataSet)
                MessageBox.Show("Stock saved!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dgv_styleRow2()

                DateTimePicker3.Enabled = False
                txt_StockName.Enabled = False
                txt_Stock.Enabled = False
                txt_Color.Enabled = False
                txt_OriginalPrice.Enabled = False
                txt_SellingPrice.Enabled = False
                cmb_Size.Enabled = False
            Catch ex As Exception
                'MessageBox.Show("Database error, the application will restart to save the changes.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                'Application.Restart()
                ' Puwede yung code above pero pwede rin to, ikaw mamili kung ano mas maganda pag nag e-error
                Me.Refresh()
            End Try
        End If
    End Sub

    Private Sub btnDeleteOrder_Click(sender As Object, e As EventArgs) Handles btnDeleteStock.Click
        Dim choice As DialogResult = MessageBox.Show("Are you sure you want to delete this stock?", "Delete", MessageBoxButtons.YesNo)
        If choice = DialogResult.Yes Then
            Try
                OMSysStocksDBBindingSource.RemoveCurrent()
                OMSysStocksDBBindingSource.EndEdit()
                OMSys_StocksDBTableAdapter.Update(OMSysOrdersDBDataSet)
                dgv_styleRow2()
            Catch ex As Exception

            End Try
        End If
        OMSysStocksDBBindingSource.MoveLast()
    End Sub

    Private Sub DateTimePicker3_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker3.ValueChanged
        yes = True
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        DateTimePicker3.Enabled = True
        txt_StockName.Enabled = True
        txt_Stock.Enabled = True
        txt_Color.Enabled = True
        txt_OriginalPrice.Enabled = True
        txt_SellingPrice.Enabled = True
        cmb_Size.Enabled = True
    End Sub

    Private Sub DataGridView1_DataSourceChanged(sender As Object, e As EventArgs) Handles DataGridView1.DataSourceChanged
        dgv_styleRow2()
    End Sub
End Class