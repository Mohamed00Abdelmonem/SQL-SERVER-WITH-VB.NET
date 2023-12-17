﻿Imports System.Data.SqlClient

Public Class Form4
    Dim connectionString As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HospitalDB;Integrated Security=True"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim insertQuery As String = "INSERT INTO Appointments    (AppointmentID   , PatientID  , DoctorID  , AppointmentDate ) VALUES (@AppointmentID   , @PatientID , @DoctorID , @AppointmentDate)"

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Using command As New SqlCommand(insertQuery, connection)
                ' Add parameters
                command.Parameters.AddWithValue("@AppointmentID ", CInt(TextBox1.Text))
                command.Parameters.AddWithValue("@PatientID ", TextBox2.Text)
                command.Parameters.AddWithValue("@DoctorID ", TextBox3.Text)
                command.Parameters.AddWithValue("@AppointmentDate ", TextBox4.Text)


                ' Execute the query
                command.ExecuteNonQuery()

                MessageBox.Show("Data inserted successfully.")
            End Using

            connection.Close()
        End Using
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Assuming TextBox1 contains the AppointmentID you want to delete
        Dim AppointmentIDToDelete As Integer = CInt(TextBox1.Text)

        Dim deleteQuery As String = "DELETE FROM Appointments WHERE AppointmentID = @AppointmentID"

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Using command As New SqlCommand(deleteQuery, connection)
                ' Add the parameter
                command.Parameters.AddWithValue("@AppointmentID", AppointmentIDToDelete)

                ' Execute the query
                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Appointment deleted successfully.")
                Else
                    MessageBox.Show("Appointment not found or deletion failed.")
                End If
            End Using

            connection.Close()
        End Using
    End Sub




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim selectQuery As String = "SELECT * FROM Appointments  "

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




