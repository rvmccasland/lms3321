
Imports MySql.Data.MySqlClient

Public Class TEACHER

    Dim db As New MYSQL_DB_()

    'Function to insert a new teacher
    Public Function InsertTeacher(ByVal Teacher_id As Integer, ByVal fName As String, ByVal lName As String) As Boolean

        Dim command As New MySqlCommand("INSERT INTO `ldbmsrev`.`teacher`(`Teacher_id`,`fName`,`lName`)
VALUES (@teacher_idNew, @fNameNew, @lNameNew);", db.getConnection)

        command.Parameters.Add("@Teacher_idNew", MySqlDbType.VarChar).Value = Teacher_id
        command.Parameters.Add("@fNameNew", MySqlDbType.VarChar).Value = fName
        command.Parameters.Add("@lNameNew", MySqlDbType.VarChar).Value = lName

        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then

            Return True

        Else

            Return False

        End If

        db.closeConnection()


    End Function

    'Function to get all teacher data from database
    Function GetTeacherList(ByVal command As MySqlCommand) As DataTable

        'Dim command As New MySqlCommand("SELECT Teacher_id, fName, lName FROM ldbmsrev.teacher ORDER BY Teacher_id;")
        command.Connection = db.getConnection

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        Return table

    End Function

    Public Function DeleteTeacher(ByVal Teacher_id As Integer) As Boolean

        Dim command As New MySqlCommand("DELETE FROM `ldbmsrev`.`teacher` WHERE (`Teacher_id` = @Teacher_idNew);", db.getConnection)

        command.Parameters.Add("@Teacher_idNew", MySqlDbType.Int32).Value = Teacher_id

        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then

            Return True

        Else

            Return False

        End If

        db.closeConnection()

    End Function

    'Function to update student
    Public Function UpdateTeacher(ByVal Teacher_id As Integer, ByVal fName As String, ByVal lName As String) As Boolean

        Dim command As New MySqlCommand("UPDATE `ldbmsrev`.`teacher` SET `Teacher_id` = @Teacher_idUpdate,`fName` = @fNameUpdate,`lName` = @lNameUpdate WHERE `Teacher_id` = @Teacher_idUpdate;", db.getConnection)


        command.Parameters.Add("@Teacher_idUpdate", MySqlDbType.VarChar).Value = Teacher_id
        command.Parameters.Add("@fNameUpdate", MySqlDbType.VarChar).Value = fName
        command.Parameters.Add("@lNameUpdate", MySqlDbType.VarChar).Value = lName

        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then

            Return True

        Else

            Return False

        End If

        db.closeConnection()


    End Function

End Class
