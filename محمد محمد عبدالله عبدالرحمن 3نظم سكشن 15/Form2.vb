Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form2
    Dim connectionString As String = "Data Source=DESKTOP-T5B59SU;Initial Catalog=Hotel;Integrated Security=True"


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim insertQuery As String = "INSERT INTO Rooms (RoomID, RoomNumber, RoomType, Price, IsAvailable) VALUES (@RoomID, @RoomNumber, @RoomType, @Price, @IsAvailable)"

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Using command As New SqlCommand(insertQuery, connection)
                ' Add parameters
                command.Parameters.AddWithValue("@RoomID", CInt(TextBox1.Text))
                command.Parameters.AddWithValue("@RoomNumber", CInt(TextBox2.Text))
                command.Parameters.AddWithValue("@RoomType", TextBox3.Text)
                command.Parameters.AddWithValue("@Price", CInt(TextBox4.Text))
                command.Parameters.AddWithValue("@IsAvailable", (TextBox5.Text))

                ' Execute the query
                command.ExecuteNonQuery()

                MessageBox.Show("Data inserted successfully.")
            End Using

            connection.Close()
        End Using
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Assuming TextBox1 contains the RoomID you want to delete
        Dim RoomIDToDelete As Integer = CInt(TextBox1.Text)

        Dim deleteQuery As String = "DELETE FROM Rooms WHERE RoomID = @RoomID"

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Using command As New SqlCommand(deleteQuery, connection)
                ' Add the parameter
                command.Parameters.AddWithValue("@RoomID", RoomIDToDelete)

                ' Execute the query
                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Room deleted successfully.")
                Else
                    MessageBox.Show("Room not found or deletion failed.")
                End If
            End Using

            connection.Close()
        End Using
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim selectQuery As String = "SELECT * FROM Rooms"

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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim form3 As New Form1()
        form3.Show()
        Me.Hide()
    End Sub
End Class