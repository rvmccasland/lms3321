Imports MySql.Data.MySqlClient

Public Class CourseDNU

    Dim db As New MYSQL_DB_()

    Public Function InsertCourse(ByVal Course_id As Integer, ByVal Course_Title As String, ByVal Description As String, ByVal CourseHours As Integer) As Boolean

        Dim command As New MySqlCommand("INSERT INTO `ldbmsrev`.`course`(`Course_id`,`Course_Title`,`Description`,`CourseHours`)VALUES (@Course_idNew, @Course_TitleNew, @DescriptionNew, @CourseHoursNew);")

        '@Course_idNew,@Course_TitleNew,@DescriptionNew,@CourseHoursNew
        command.Parameters.Add("@Course_idNew", MySqlDbType.VarChar).Value = Course_id
        command.Parameters.Add("@Course-TitleNew", MySqlDbType.VarChar).Value = Course_Title
        command.Parameters.Add("@DescriptionNew", MySqlDbType.VarChar).Value = Description
        command.Parameters.Add("@CourseHoursNew", MySqlDbType.VarChar).Value = CourseHours

        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then
            Return True
        Else
            Return False

        End If

        db.closeConnection()



    End Function


End Class
