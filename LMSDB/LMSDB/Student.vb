Imports System.IO
Imports MySql.Data.MySqlClient


Public Class Student

    Dim db As New MYSQL_DB_()

    'Function to insert a new student
    Public Function insertStudent(ByVal Student_id As Integer, ByVal fName As String, ByVal lName As String, ByVal Birth_Date As Date, ByVal Address As String, ByVal eMail As String, ByVal Picture As MemoryStream) As Boolean

        Dim command As New MySqlCommand("INSERT INTO `ldbmsrev`.`student`(`Student_id`,`fName`,`lName`,`Birth_Date`,`Address`,`eMail`,`Picture`)
VALUES (@Student_idNew, @fNameNew, @lNameNew, @Birth_DateNew, @AddressNew, @eMailNew, @PictureNew);", db.getConnection)

        '@Student_idNew,@fNameNew, @lNameNew, @Birth_DateNew, @AddressNew, @eMailNew, @PictureNew
        command.Parameters.Add("@Student_idNew", MySqlDbType.VarChar).Value = Student_id
        command.Parameters.Add("@fNameNew", MySqlDbType.VarChar).Value = fName
        command.Parameters.Add("@lNameNew", MySqlDbType.VarChar).Value = lName
        command.Parameters.Add("@Birth_DateNew", MySqlDbType.Date).Value = Birth_Date
        command.Parameters.Add("@AddressNew", MySqlDbType.VarChar).Value = Address
        command.Parameters.Add("@eMailNew", MySqlDbType.VarChar).Value = eMail
        command.Parameters.Add("@PictureNew", MySqlDbType.Blob).Value = Picture

        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then

            Return True

        Else

            Return False

        End If



    End Function



End Class
