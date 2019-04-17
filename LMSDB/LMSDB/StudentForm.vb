Imports MySql.Data.MySqlClient

Public Class StudentForm

    Public Mysqlcon As New MySqlConnection
    Dim command As MySqlCommand

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub StudentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button_Save_Click(sender As Object, e As EventArgs) Handles Button_Save.Click
        Mysqlcon = New MySqlConnection
        Mysqlcon.ConnectionString = "server=localhost;userid=root;password=QzmP28chap73;database=ldbmsrev"
        Dim reader As MySqlDataReader

        Try
            Mysqlcon.Open()

            Dim query As String
            query = "insert into ldbmsrev.student (Student_id,fName,lName,Birth_Date) values (' " & TextBox_Student_id.Text & " ',' " & TextBox_fName.Text & " ',' " & TextBox_lName.Text & " ',' " & TextBox_Date_of_Birth.Text & " ')"
            command = New MySqlCommand(query, Mysqlcon)
            reader = command.ExecuteReader

            MessageBox.Show("Data Saved")

            Mysqlcon.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            Mysqlcon.Dispose()

        End Try
    End Sub

    Private Sub Button_Close_Click(sender As Object, e As EventArgs) Handles Button_Close.Click
        Me.Close()
    End Sub
End Class


