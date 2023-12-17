Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Navigate to Form1
        Dim form1 As New Form2()
        form1.Show()
        Me.Hide()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Navigate to Form2
        Dim form4 As New Form4()
        form4.Show()
        Me.Hide()
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Navigate to Form2
        Dim form5 As New Form5()
        form5.Show()
        Me.Hide()
    End Sub

End Class
