Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form3
    Dim connectionString As String = "Data Source=DESKTOP-T5B59SU;Initial Catalog=Hotel;Integrated Security=True"


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim insertQuery As String = "INSERT INTO Customers (CustomerID, FirstName, LastName, Email, Phone) VALUES (@CustomerID, @FirstName, @LastName, @Email, @Phone)"

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Using command As New SqlCommand(insertQuery, connection)
                ' Add parameters
                command.Parameters.AddWithValue("@CustomerID", CInt(TextBox1.Text))
                command.Parameters.AddWithValue("@FirstName", (TextBox2.Text))
                command.Parameters.AddWithValue("@LastName", TextBox3.Text)
                command.Parameters.AddWithValue("@Email", (TextBox4.Text))
                command.Parameters.AddWithValue("@Phone", (TextBox5.Text))

                ' Execute the query
                command.ExecuteNonQuery()

                MessageBox.Show("Data inserted successfully.")
            End Using

            connection.Close()
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Assuming TextBox1 contains the CustomerID you want to delete
        Dim CustomerIDToDelete As Integer = CInt(TextBox1.Text)

        Dim deleteQuery As String = "DELETE FROM Customers WHERE CustomerID = @CustomerID"

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Using command As New SqlCommand(deleteQuery, connection)
                ' Add the parameter
                command.Parameters.AddWithValue("@CustomerID", CustomerIDToDelete)

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
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
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
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim form3 As New Form1()
        form3.Show()
        Me.Hide()
    End Sub
End Class