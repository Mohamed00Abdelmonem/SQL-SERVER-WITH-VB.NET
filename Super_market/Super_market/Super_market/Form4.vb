Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form4
    Dim connectionString As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=super_market;Integrated Security=True"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim insertQuery As String = "INSERT INTO Customers (CustomerID, CustomerName, PhoneNumber) VALUES (@CustomerID, @CustomerName, @PhoneNumber)"

            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Using command As New SqlCommand(insertQuery, connection)
                    ' Add parameters
                    command.Parameters.AddWithValue("@CustomerID", CInt(TextBox1.Text))
                    command.Parameters.AddWithValue("@CustomerName", TextBox2.Text)
                    command.Parameters.AddWithValue("@PhoneNumber", TextBox3.Text)

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
            ' Assuming TextBox1 contains the CustomerID you want to delete
            Dim customerIDToDelete As Integer = CInt(TextBox1.Text)

            Dim deleteQuery As String = "DELETE FROM Customers WHERE CustomerID = @CustomerID"

            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Using command As New SqlCommand(deleteQuery, connection)
                    ' Add the parameter
                    command.Parameters.AddWithValue("@CustomerID", customerIDToDelete)

                    ' Execute the query
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Customer deleted successfully.")
                    Else
                        MessageBox.Show("Customer not found or deletion failed.")
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
            Dim selectQuery As String = "SELECT * FROM Customers"

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
