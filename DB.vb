Imports System.Data.OleDb

Module DB
    Function Connect() As OleDbConnection
        Dim connection = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" & Application.StartupPath & "/data.mdb")
        connection.Open()
        Return connection
    End Function

    Function GetDataTable(sql As String) As DataTable
        Dim connection = Connect()
        Dim dataTable As New DataTable()

        Using cmd As New OleDbCommand(sql, connection), adapter As New OleDbDataAdapter(cmd)
            cmd.Connection.Close()
            adapter.Fill(dataTable)
        End Using

        connection.Close()

        Return dataTable
    End Function

    Function ExecuteNonQuery(sql As String) As Boolean
        Using cmd As New OleDbCommand With {
            .Connection = Connect(),
            .CommandText = sql
        }
            Dim isSuccess = False
            Try
                cmd.ExecuteNonQuery()
                isSuccess = True
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            cmd.Connection.Close()

            Return isSuccess
        End Using
    End Function

    Function RowsCount(sql As String) As Integer
        Return GetDataTable(sql).Rows.Count()
    End Function
End Module
