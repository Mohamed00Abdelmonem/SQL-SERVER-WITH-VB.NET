Imports System.Data.SqlClient

Public Class Form3
    Dim connectionString As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=super_market;Integrated Security=True"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim insertQuery As String = "INSERT INTO Products (ProductID, ProductName, Price, CategoryID, TransactionDate) VALUES (@ProductID, @ProductName, @Price, @CategoryID, @TransactionDate)"

            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Using command As New SqlCommand(insertQuery, connection)
                    ' Add parameters
                    command.Parameters.AddWithValue("@ProductID", CInt(TextBox1.Text))
                    command.Parameters.AddWithValue("@ProductName", TextBox2.Text)
                    command.Parameters.AddWithValue("@Price", Decimal.Parse(TextBox3.Text))
                    command.Parameters.AddWithValue("@CategoryID", CInt(TextBox4.Text))
                    command.Parameters.AddWithValue("@TransactionDate", DateTime.Now) ' Assuming you want to use the current date/time for TransactionDate

                    ' Execute the query
                    command.ExecuteNonQuery()

                    MessageBox.Show("Data inserted successfully.")
                End Using

                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            ' Assuming TextBox1 contains the ProductID you want to delete
            Dim productIDToDelete As Integer = CInt(TextBox1.Text)

            Dim deleteQuery As String = "DELETE FROM Products WHERE ProductID = @ProductID"

            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Using command As New SqlCommand(deleteQuery, connection)
                    ' Add the parameter
                    command.Parameters.AddWithValue("@ProductID", productIDToDelete)

                    ' Execute the query
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Product deleted successfully.")
                    Else
                        MessageBox.Show("Product not found or deletion failed.")
                    End If
                End Using

                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim selectQuery As String = "SELECT * FROM Products"

            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Using command As New SqlCommand(selectQuery, connection)
                    Using adapter As New SqlDataAdapter(command)
                        Dim dataTable As New DataTable()
                        adapter.Fill(dataTable)

                        ' Assuming DataGridView1 is the name of your DataGridView control
                        DataGridView1.DataSource = dataTable
                    End Using
                End Using

                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
End Class
