Imports MySql.Data.MySqlClient

Public Class COURSE

    Dim db As New MYSQL_DB_()
    Public Function InsertCourse(ByVal Course_id As Integer, ByVal Course_Title As String, ByVal Description As String, ByVal CourseHours As Integer) As Boolean

        Dim command As New MySqlCommand("INSERT INTO `ldbmsrev`.`course`(`Course_id`,`Course_Title`,`Description`,`CourseHours`)VALUES(@Course_idNew, @Course_TitleNew, @DescriptionNew, @CourseHoursNew);", db.getConnection)

            '(@Course_idNew,@Course_TitleNew,@DescriptionNew,@CourseHoursNew);
            command.Parameters.Add("@Course_idNew", MySqlDbType.VarChar).Value = Course_id
            command.Parameters.Add("@Course_TitleNew", MySqlDbType.VarChar).Value = Course_Title
            command.Parameters.Add("@DescriptionNew", MySqlDbType.VarChar).Value = Description
            command.Parameters.Add("@CourseHoursNew", MySqlDbType.Int32).Value = CourseHours

            db.openConnection()

        If command.ExecuteNonQuery() = 1 Then

                Return True
            Else
                Return False

            End If

            db.closeConnection()

    End Function

    Public Function CheckCourseTitle(ByVal CourseTitle As String, ByVal Optional Course_id As Integer = 0) As Boolean

        Dim command As New MySqlCommand("SELECT * FROM ldbmsrev.course WHERE Course_Title=@Course_Title AND Course_id <> @Course_id", db.getConnection)
        command.Parameters.Add("@Course_Title", MySqlDbType.VarChar).Value = CourseTitle
        command.Parameters.Add("@Course_id", MySqlDbType.Int32).Value = Course_id
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        If table.Rows.Count > 0 Then
            'This course name found in database
            Return False
        Else
            Return True

        End If

    End Function

    Public Function DeleteCourse(ByVal Course_id As Integer) As Boolean

        Dim command As New MySqlCommand("DELETE FROM `ldbmsrev`.`course`WHERE Course_id = @Course_idDel;", db.getConnection)

        '(@Course_idNew)
        command.Parameters.Add("@Course_idDel", MySqlDbType.VarChar).Value = Course_id

        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then

            Return True
        Else
            Return False

        End If

        db.closeConnection()

    End Function

    Public Function GetAllCourses() As DataTable

        Dim command As New MySqlCommand("SELECT `course`.`Course_id`,`course`.`Course_Title`,`course`.`Description`, `course`.`CourseHours` FROM `ldbmsrev`.`course`;", db.getConnection)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        Return table

    End Function

    Public Function GetAllCoursesByID(ByVal Course_id As Integer) As DataTable

        Dim command As New MySqlCommand("SELECT `course`.`Course_id`,`course`.`Course_Title`,`course`.`Description`, `course`.`CourseHours` FROM `ldbmsrev`.`course` WHERE Course_id = @Course_idEdit;", db.getConnection)
        command.Parameters.Add("@Course_idEdit", MySqlDbType.VarChar).Value = Course_id
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        Return table

    End Function


    Public Function UpdateCourse(ByVal Course_id As Integer, ByVal Course_Title As String, ByVal Description As String, ByVal CourseHours As Integer) As Boolean

        Dim command As New MySqlCommand("UPDATE `ldbmsrev`.`course` SET `Course_id` = @Course_idUpdate, `Course_Title` = @Course_TitleUpdate, `Description` = @DescriptionUpdate, `CourseHours` = @CourseHoursUpdate
WHERE `Course_id` = @Course_idUpdate;", db.getConnection)

        '(@Course_idUpdate,@Course_TitleUpdate,@DescriptionUpdate,@CourseHoursUpdate);
        command.Parameters.Add("@Course_idUpdate", MySqlDbType.Int32).Value = Course_id
        command.Parameters.Add("@Course_TitleUpdate", MySqlDbType.VarChar).Value = Course_Title
        command.Parameters.Add("@DescriptionUpdate", MySqlDbType.VarChar).Value = Description
        command.Parameters.Add("@CourseHoursUpdate", MySqlDbType.Int32).Value = CourseHours

        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then

            Return True
        Else
            Return False

        End If

        db.closeConnection()

    End Function

End Class