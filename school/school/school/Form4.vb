﻿Imports System.Data.SqlClient

Public Class Form4
    Dim connectionString As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=school;Integrated Security=True"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim insertQuery As String = "INSERT INTO Enrollments  (EnrollmentID   , StudentID , CourseID , EnrollmentDate ) VALUES (@EnrollmentID   , @StudentID , @CourseID , @EnrollmentDate   )"

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Using command As New SqlCommand(insertQuery, connection)
                ' Add parameters
                command.Parameters.AddWithValue("@EnrollmentID ", CInt(TextBox1.Text))
                command.Parameters.AddWithValue("@StudentID  ", CInt(TextBox2.Text))
                command.Parameters.AddWithValue("@CourseID  ", CInt(TextBox3.Text))
                command.Parameters.AddWithValue("@EnrollmentDate  ", TextBox4.Text)


                ' Execute the query
                command.ExecuteNonQuery()

                MessageBox.Show("Data inserted successfully.")
            End Using

            connection.Close()
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Assuming TextBox1 contains the StudentID you want to delete
        Dim StudentIDToDelete As Integer = CInt(TextBox1.Text)

        ' Corrected query to match the table name "Students"
        Dim deleteQuery As String = "DELETE FROM Enrollments   WHERE EnrollmentID   = @EnrollmentID "

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Using command As New SqlCommand(deleteQuery, connection)
                ' Add the parameter
                command.Parameters.AddWithValue("@EnrollmentID ", StudentIDToDelete)

                ' Execute the query
                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Enrollment deleted successfully.")
                Else
                    MessageBox.Show("Enrollment not found or deletion failed.")
                End If
            End Using

            connection.Close()
        End Using
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim selectQuery As String = "SELECT * FROM Enrollments   "

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
        Dim form1 As New Form1()
        form1.Show()
        Me.Hide()
    End Sub
End Class
