Imports MySql.Data.MySqlClient

Public Class GRADES

    Dim db As New MYSQL_DB_()
    Public Function InsertGrades(ByVal Student_id As Integer, ByVal Course_id As Integer, ByVal ExamGrades As Double, ByVal CreditHours As Integer, ByVal Description As String, ByVal GPA As Double) As Boolean

        Dim command As New MySqlCommand("INSERT INTO `ldbmsrev`.`grades`(`Student_id`,`Course_id`,`ExamGrade`,`CreditHours`,`Description`,`GPA`)VALUES(@Student_idNew, @Course_idNew, @ExamGradeNew, @CreditHoursNew, @DescriptionNew, @GPANew);", db.getConnection)

        '(@Student_idNew,@Course_idNew,@ExamGradeNew,@CreditHoursNew,@DescriptionNew,@GPANew)
        command.Parameters.Add("@Student_idNew", MySqlDbType.Int32).Value = Student_id
        command.Parameters.Add("@Course_idNew", MySqlDbType.Int32).Value = Course_id
        command.Parameters.Add("@ExamGradeNew", MySqlDbType.Double).Value = ExamGrades
        command.Parameters.Add("@CreditHoursNew", MySqlDbType.Int32).Value = CreditHours
        command.Parameters.Add("@DescriptionNew", MySqlDbType.VarChar).Value = Description
        command.Parameters.Add("@GPANew", MySqlDbType.Double).Value = GPA

        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then

            Return True
        Else
            Return False

        End If

        db.closeConnection()

    End Function

    Function studentScoreExist(ByVal Student_IDcheck As Integer, ByVal Course_IDcheck As Integer) As Boolean

        Dim command As New MySqlCommand("SELECT * FROM `ldbmsrev`.`grades` WHERE Student_id = @Student_idNew AND Course_id = @Course_idNew;", db.getConnection)

        '(@Student_idNew,@Course_idNew,@ExamGradeNew,@CreditHoursNew,@DescriptionNew,@GPANew)
        command.Parameters.Add("@Student_idNew", MySqlDbType.Int32).Value = Student_IDcheck
        command.Parameters.Add("@Course_idNew", MySqlDbType.Int32).Value = Course_IDcheck

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        If table.Rows.Count = 0 Then
            Return False
        Else

            Return True


        End If

    End Function

    Function getStudentScore() As DataTable

        Dim command As New MySqlCommand()
        command.Connection = db.getConnection
        command.CommandText = "SELECT grades.Student_id, student.fName, student.lName, grades.Course_id, course.Course_Title, grades.ExamGrade FROM student " & vbCrLf &
"INNER JOIN grades on student.Student_id = grades.Student_id " & vbCrLf & "INNER JOIN course on grades.Course_id = course.Course_id;"

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable
        adapter.Fill(table)

        Return table

    End Function
    Function getSAVGtudentScoreCourse() As DataTable

        Dim command As New MySqlCommand()
        command.Connection = db.getConnection
        command.CommandText = "SELECT course.Course_Title, avg(grades.ExamGrade) AS 'Average Score' from course, grades where course.Course_id = grades.Course_id group by course.Course_Title"

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable
        adapter.Fill(table)

        Return table

    End Function




    Public Function DeleteGrade(ByVal Student_id As Integer, ByVal Course_id As Integer) As Boolean

        Dim command As New MySqlCommand("DELETE FROM `ldbmsrev`.`grades`WHERE Student_id = @Student_idDel AND Course_id = @Course_idDel;", db.getConnection)

        '(@Course_idDel, Student_idDel)
        command.Parameters.Add("@Student_idDel", MySqlDbType.Int32).Value = Student_id
        command.Parameters.Add("@Course_idDel", MySqlDbType.Int32).Value = Course_id

        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then

            Return True
        Else
            Return False

        End If

        db.closeConnection()

    End Function


End Class
