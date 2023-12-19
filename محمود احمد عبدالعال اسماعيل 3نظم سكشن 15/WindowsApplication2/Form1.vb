Imports System.Data.SqlClient
Public Class Form1

    Dim connectionstring As String = "data source =DESKTOP-I1R2135\SQLEXPRESS;initial catalog =المصريه_للطيران ; integrated security=true"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim insertQuery As String = "insert into الموظفين (id,Name,Address,salare,Age,phone)values(@id,@Name,@Address,@salare,@Age,@phone)"
        Using connection As New SqlConnection(connectionstring)
            Using command As New SqlCommand(insertQuery, connection)

                command.Parameters.AddWithValue("@id", CInt(TextBox1.Text))
                command.Parameters.AddWithValue("@Name", (TextBox2.Text))
                command.Parameters.AddWithValue("@Address", (TextBox3.Text))
                command.Parameters.AddWithValue("@salare", CInt(TextBox4.Text))
                command.Parameters.AddWithValue("@age", CInt(TextBox5.Text))
                command.Parameters.AddWithValue("@phone", CInt(TextBox6.Text))

                connection.Open()
                command.ExecuteNonQuery()
                MessageBox.Show("data inserted successfully!!!!")
                connection.Close()

            End Using
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim deleteQuery As String = "delete from الموظفين where id =@id"
        Using connection As New SqlConnection(connectionstring)
            Using command As New SqlCommand(deleteQuery, connection)

                command.Parameters.AddWithValue("@id", CInt(TextBox1.Text))
                connection.Open()
                command.ExecuteNonQuery()
                MessageBox.Show("successfully delete!!!!")
                connection.Close()
            End Using
        End Using
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim selectQuery As String = "select * from الموظفين"
        Using connection As New SqlConnection(connectionstring)
            Using command As New SqlCommand(selectQuery, connection)

                connection.Open()
                Using reader As SqlDataReader = command.ExecuteReader()
                    Dim datatable As New DataTable()
                    datatable.Load(reader)
                    DataGridView1.DataSource = datatable
                End Using
                connection.Close()
            End Using
        End Using
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
