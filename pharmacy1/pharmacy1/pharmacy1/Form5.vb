Imports System.Data.SqlClient

Public Class Form5
    Dim connectionString As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=pharmacy;Integrated Security=True"

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' View data from the Sales table
        Dim selectQuery As String = "SELECT * FROM Sales"

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
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim insertQuery As String = "INSERT INTO Sales (SaleID, DrugID, CustomerID, SaleDate, Quantity, TotalAmount) VALUES (@SaleID, @DrugID, @CustomerID, @SaleDate, @Quantity, @TotalAmount)"

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Using command As New SqlCommand(insertQuery, connection)
                ' Add parameters
                command.Parameters.AddWithValue("@SaleID", CInt(TextBox1.Text))
                command.Parameters.AddWithValue("@DrugID", CInt(TextBox2.Text))
                command.Parameters.AddWithValue("@CustomerID", CInt(TextBox3.Text))
                command.Parameters.AddWithValue("@SaleDate", CInt(TextBox4.Text))
                command.Parameters.AddWithValue("@Quantity", CInt(TextBox5.Text))
                command.Parameters.AddWithValue("@TotalAmount", CInt(TextBox6.Text))

                ' Execute the query
                command.ExecuteNonQuery()

                MessageBox.Show("Data Drugs inserted successfully.")
            End Using

            connection.Close()
        End Using
    End Sub


    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Assuming TextBox1 contains the SaleID you want to delete
        Dim SaleIDToDelete As Integer

        If Integer.TryParse(TextBox1.Text, SaleIDToDelete) Then
            Dim deleteQuery As String = "DELETE FROM Sales WHERE SaleID = @SaleID"

            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Using command As New SqlCommand(deleteQuery, connection)
                    ' Add the parameter
                    command.Parameters.AddWithValue("@SaleID", SaleIDToDelete)

                    ' Execute the query
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Sale deleted successfully.")
                    Else
                        MessageBox.Show("Sale not found or deletion failed.")
                    End If
                End Using

                connection.Close()
            End Using
        Else
            MessageBox.Show("Please enter a valid SaleID to delete.")
        End If
    End Sub

End Class
