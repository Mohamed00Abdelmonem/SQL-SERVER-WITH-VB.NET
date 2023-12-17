Imports System.Data.SqlClient

Public Class Form2
    Dim connectionString As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HospitalDB;Integrated Security=True"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim insertQuery As String = "INSERT INTO Patients  (PatientID , FirstName , LastName , DateOfBirth , Gender , PhoneNumber ,Email ) VALUES (@PatientID , @FirstName, @LastName, @DateOfBirth , @Gender ,@PhoneNumber , @Email)"

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Using command As New SqlCommand(insertQuery, connection)
                ' Add parameters
                command.Parameters.AddWithValue("@PatientID", CInt(TextBox1.Text))
                command.Parameters.AddWithValue("@FirstName", TextBox2.Text)
                command.Parameters.AddWithValue("@LastName", TextBox3.Text)
                command.Parameters.AddWithValue("@DateOfBirth", TextBox4.Text)
                command.Parameters.AddWithValue("@Gender", (TextBox5.Text))
                command.Parameters.AddWithValue("@PhoneNumber", (TextBox6.Text))
                command.Parameters.AddWithValue("@Email", (TextBox7.Text))


                ' Execute the query
                command.ExecuteNonQuery()

                MessageBox.Show("Data inserted successfully.")
            End Using

            connection.Close()
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Assuming TextBox1 contains the PatientID you want to delete
        Dim PatientIDToDelete As Integer = CInt(TextBox1.Text)

        Dim deleteQuery As String = "DELETE FROM Patients WHERE PatientID = @PatientID"

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Using command As New SqlCommand(deleteQuery, connection)
                ' Add the parameter
                command.Parameters.AddWithValue("@PatientID", PatientIDToDelete)

                ' Execute the query
                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Patient deleted successfully.")
                Else
                    MessageBox.Show("Patient not found or deletion failed.")
                End If
            End Using

            connection.Close()
        End Using
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim selectQuery As String = "SELECT * FROM Patients "

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

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim form1 As New Form1()
        form1.Show()
        Me.Hide()
    End Sub
End Class




