Imports System.Data.SqlClient

Public Class Form4
    Dim connectionString As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=pharmacy;Integrated Security=True"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim insertQuery As String = "INSERT INTO Drugs (DrugID, DrugName, Manufacturer, UnitPrice) VALUES (@DrugID, @DrugName, @Manufacturer, @UnitPrice)"

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Using command As New SqlCommand(insertQuery, connection)
                ' Add parameters
                command.Parameters.AddWithValue("@DrugID", CInt(TextBox1.Text))
                command.Parameters.AddWithValue("@DrugName", TextBox2.Text)
                command.Parameters.AddWithValue("@Manufacturer", TextBox3.Text)
                command.Parameters.AddWithValue("@UnitPrice", TextBox4.Text)

                ' Execute the query
                command.ExecuteNonQuery()

                MessageBox.Show("Data Drugs inserted successfully.")
            End Using

            connection.Close()
        End Using
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Assuming TextBox1 contains the DrugID you want to delete
        Dim DrugIDToDelete As Integer

        If Integer.TryParse(TextBox1.Text, DrugIDToDelete) Then
            Dim deleteQuery As String = "DELETE FROM Drugs WHERE DrugID = @DrugID"

            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Using command As New SqlCommand(deleteQuery, connection)
                    ' Add the parameter
                    command.Parameters.AddWithValue("@DrugID", DrugIDToDelete)

                    ' Execute the query
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Drug deleted successfully.")
                    Else
                        MessageBox.Show("Drug not found or deletion failed.")
                    End If
                End Using

                connection.Close()
            End Using
        Else
            MessageBox.Show("Please enter a valid DrugID to delete.")
        End If
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' View data from the Drugs table
        Dim selectQuery As String = "SELECT * FROM Drugs"

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
End Class