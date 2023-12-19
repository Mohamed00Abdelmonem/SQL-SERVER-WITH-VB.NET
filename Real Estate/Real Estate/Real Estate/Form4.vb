Imports System.Data.SqlClient

Public Class Form4
    Dim connectionString As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=real_estate;Integrated Security=True"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim insertQuery As String = "INSERT INTO Transactions (TransactionID, PropertyID, InvestorID) VALUES (@TransactionID, @PropertyID, @InvestorID)"

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Using command As New SqlCommand(insertQuery, connection)
                ' Add parameters
                command.Parameters.AddWithValue("@TransactionID", CInt(TextBox1.Text))
                command.Parameters.AddWithValue("@PropertyID", TextBox2.Text)
                command.Parameters.AddWithValue("@InvestorID", TextBox3.Text)

                ' Execute the query
                command.ExecuteNonQuery()

                MessageBox.Show("Data inserted successfully.")
            End Using

            connection.Close()
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Assuming TextBox1 contains the CustomerID you want to delete
        Dim customerIDToDelete As Integer = CInt(TextBox1.Text)

        Dim deleteQuery As String = "DELETE FROM Transactions WHERE TransactionID = @TransactionID"

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Using command As New SqlCommand(deleteQuery, connection)
                ' Add the parameter
                command.Parameters.AddWithValue("@TransactionID", customerIDToDelete)

                ' Execute the query
                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("TransactionID deleted successfully.")
                Else
                    MessageBox.Show("TransactionID not found or deletion failed.")
                End If
            End Using

            connection.Close()
        End Using
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim selectQuery As String = "SELECT * FROM Transactions"

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

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Dim form3 As New Form1()
        form3.Show()
        Me.Hide()
    End Sub
End Class



