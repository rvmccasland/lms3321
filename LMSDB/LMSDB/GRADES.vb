Imports MySql.Data.MySqlClient

Public Class GRADES


    Dim db As New MYSQL_DB_()

    'Function to insert a grades
    Public Function InsertGrades(ByVal Student_id As Integer, ByVal ExamGrade As Integer, ByVal CreditHours As Integer) As Boolean

        Dim command As New MySqlCommand("INSERT INTO `ldbmsrev`.`grades`(`Student_id`,`ExamGrade`,`CreditHours`)VALUES(@Student_idNew, @ExamGradeNew, @CreditHoursNew);", db.getConnection)

        '@Student_idNew, @ExamGradeNew,@CreditHoursNew
        command.Parameters.Add("@Student_idNew", MySqlDbType.Int32).Value = Student_id
        command.Parameters.Add("@ExamGradeNew", MySqlDbType.Int32).Value = ExamGrade
        command.Parameters.Add("@CreditHoursNew", MySqlDbType.Int32).Value = CreditHours

        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then

            Return True

        Else

            Return False

        End If

        db.closeConnection()


    End Function




End Class
