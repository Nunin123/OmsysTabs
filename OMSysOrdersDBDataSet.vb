Partial Class OMSysOrdersDBDataSet
    Partial Public Class OMSys_StocksDBDataTable
        Private Sub OMSys_StocksDBDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.IDColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Public Class OMSys_OrdersDBDataTable


    End Class
End Class

Namespace OMSysOrdersDBDataSetTableAdapters
    Partial Public Class OMSys_OrdersDBTableAdapter
    End Class
End Namespace
