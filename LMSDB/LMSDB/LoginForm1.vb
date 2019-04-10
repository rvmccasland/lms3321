Imports MySql.Data.MySqlClient

Public Class LoginForm1

    Public Mysqlcon As New MySqlConnection
    Dim command As MySqlCommand

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Login.Click

        Mysqlcon = New MySqlConnection
        Mysqlcon.ConnectionString = "server=localhost;userid=root;password=QzmP28chap73;database=ldbmsrev"
        Dim reader As MySqlDataReader

        Try
            Mysqlcon.Open()
            'MessageBox.Show("Connected to Database Successful")

            'Querry database for username and password
            Dim query As String
            query = "select * from ldbmsrev.user where username = '" & UsernameTextBox.Text & "' and password = '" & PasswordTextBox.Text & "'"
            command = New MySqlCommand(query, Mysqlcon)
            reader = command.ExecuteReader

            Dim count As Integer
            count = 0

            While reader.Read
                count = count + 1
            End While

            If count = 1 Then
                MessageBox.Show("Username and Password are Valid")
                StudentForm.Show()
                Me.Hide()
            ElseIf count > 1 Then
                MessageBox.Show("Username and Password are Duplicate")
            Else
                MsgBox("Username and Password are Invalid", MsgBoxStyle.Critical, "Login Error")

            End If

            Mysqlcon.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            Mysqlcon.Dispose()

        End Try

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        ' Show Password
        If PasswordTextBox.UseSystemPasswordChar Then
            PasswordTextBox.UseSystemPasswordChar = False
        Else
            'Hidden Password
            PasswordTextBox.UseSystemPasswordChar = True
        End If

    End Sub
End Class
