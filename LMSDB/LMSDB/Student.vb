Imports System.IO
Imports MySql.Data.MySqlClient


Public Class Student

    Dim db As New MYSQL_DB_()

    'Function to insert a new student
    Public Function InsertStudent(ByVal Student_id As Integer, ByVal fName As String, ByVal lName As String, ByVal Birth_Date As Date, ByVal Gender As String, ByVal Address As String, ByVal eMail As String, ByVal Picture As MemoryStream) As Boolean

        Dim command As New MySqlCommand("INSERT INTO `ldbmsrev`.`student`(`Student_id`,`fName`,`lName`,`Birth_Date`,`Gender`,`Address`,`eMail`,`Picture`)
VALUES (@Student_idNew, @fNameNew, @lNameNew, @Birth_DateNew, @GenderNew, @AddressNew, @eMailNew, @PictureNew);", db.getConnection)

        '@Student_idNew,@fNameNew, @lNameNew, @Birth_DateNew, @Gender, @AddressNew, @eMailNew, @PictureNew
        command.Parameters.Add("@Student_idNew", MySqlDbType.VarChar).Value = Student_id
        command.Parameters.Add("@fNameNew", MySqlDbType.VarChar).Value = fName
        command.Parameters.Add("@lNameNew", MySqlDbType.VarChar).Value = lName
        command.Parameters.Add("@Birth_DateNew", MySqlDbType.Date).Value = Birth_Date
        command.Parameters.Add("@GenderNew", MySqlDbType.VarChar).Value = Gender
        command.Parameters.Add("@AddressNew", MySqlDbType.VarChar).Value = Address
        command.Parameters.Add("@eMailNew", MySqlDbType.VarChar).Value = eMail
        command.Parameters.Add("@PictureNew", MySqlDbType.Blob).Value = Picture.ToArray()

        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then

            Return True

        Else

            Return False

        End If

        db.closeConnection()


    End Function

    'Function to get all student data from database
    Function GetStudentsList(ByVal command As MySqlCommand) As DataTable

        'Dim command As New MySqlCommand("SELECT Student_id, fName, lName, Birth_Date, Gender, Address, eMail, Picture FROM ldbmsrev.student ORDER BY Student_id;")
        command.Connection = db.getConnection

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        Return table

    End Function

    Public Function DeleteStudent(ByVal Student_id As Integer) As Boolean

        Dim command As New MySqlCommand("DELETE FROM `ldbmsrev`.`student` WHERE (`Student_id` = @Student_idNew);", db.getConnection)

        command.Parameters.Add("@Student_idNew", MySqlDbType.Int32).Value = Student_id

        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then

            Return True

        Else

            Return False

        End If

        db.closeConnection()

    End Function

    'Function to update student
    Public Function UpdateStudent(ByVal Student_id As Integer, ByVal fName As String, ByVal lName As String, ByVal Birth_Date As Date, ByVal Gender As String, ByVal Address As String, ByVal eMail As String, ByVal Picture As MemoryStream) As Boolean

        Dim command As New MySqlCommand("UPDATE `ldbmsrev`.`student` SET `Student_id` = @Student_idUpdate,`fName` = @fNameUpdate,`lName` = @lNameUpdate,`Birth_Date` = @Birth_DateUpdate,`Gender` = @GenderUpdate,
`Address` = @AddressUpdate, `eMail` = @eMailUpdate, `Picture` = @PictureUpdate WHERE `Student_id` = @Student_idUpdate;", db.getConnection)

        '@Student_idNew,@fNameNew, @lNameNew, @Birth_DateNew, @Gender, @AddressNew, @eMailNew, @PictureNew
        command.Parameters.Add("@Student_idUpdate", MySqlDbType.VarChar).Value = Student_id
        command.Parameters.Add("@fNameUpdate", MySqlDbType.VarChar).Value = fName
        command.Parameters.Add("@lNameUpdate", MySqlDbType.VarChar).Value = lName
        command.Parameters.Add("@Birth_DateUpdate", MySqlDbType.Date).Value = Birth_Date
        command.Parameters.Add("@GenderUpdate", MySqlDbType.VarChar).Value = Gender
        command.Parameters.Add("@AddressUpdate", MySqlDbType.VarChar).Value = Address
        command.Parameters.Add("@eMailUpdate", MySqlDbType.VarChar).Value = eMail
        command.Parameters.Add("@PictureUpdate", MySqlDbType.Blob).Value = Picture.ToArray()

        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then

            Return True

        Else

            Return False

        End If

        db.closeConnection()


    End Function
    'Function to execute count query
    Function ExecCount(ByVal query As String) As String

        Dim command As New MySqlCommand(query, db.getConnection)

        db.openConnection()
        Return command.ExecuteScalar().ToString()
        db.closeConnection()

    End Function
    'Total students count
    Function TotalStudent() As String

        Return execCount("SELECT COUNT(*) FROM `ldbmsrev`.`student`;")

    End Function
    'Total male students count
    Function TotalMaleStudent() As String

        Return execCount("SELECT COUNT(*) FROM `ldbmsrev`.`student` WHERE gender = 'Male';")

    End Function
    'Total female students count
    Function TotalFemaleStudent() As String

        Return ExecCount("SELECT COUNT(*) FROM `ldbmsrev`.`student` WHERE gender = 'Female';")

    End Function

End Class
