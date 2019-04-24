Imports MySql.Data.MySqlClient

Public Class ManageGrades

    Dim score As New GRADES()
    Dim student As New Student()
    Dim CourseEdit As New COURSE()
    Dim data As String = "score"
    Private Sub ManageGrades_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DataGridViewManageScore.DataSource = score.getStudentScore()
        ComboBoxEditCourse.DataSource = CourseEdit.GetAllCourses()
        ComboBoxEditCourse.DisplayMember = "Course_Title"
        ComboBoxEditCourse.ValueMember = "Course_id"


    End Sub

    Private Sub ButtonShowGrades_Click(sender As Object, e As EventArgs) Handles ButtonShowGrades.Click
        data = "score"
        DataGridViewManageScore.DataSource = score.getStudentScore()

    End Sub

    Private Sub ButtonShowStudents_Click(sender As Object, e As EventArgs) Handles ButtonShowStudents.Click

        data = "score"
        Dim command As New MySqlCommand("SELECT Student_id, fName, lName FROM ldbmsrev.student ORDER BY Student_id;")
        DataGridViewManageScore.DataSource = student.GetStudentsList(command)

    End Sub
    'Choose datagrid view based on choice student or grades
    Sub getDataFromDatagridview()

        If data = "student" Then
            TextBoxStudentID.Text = DataGridViewManageScore.CurrentRow.Cells(0).Value.ToString()

        ElseIf data = "score" Then
            TextBoxStudentID.Text = DataGridViewManageScore.CurrentRow.Cells(0).Value.ToString()

        End If

    End Sub

    Private Sub DataGridViewManageScore_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewManageScore.CellClick

        getDataFromDatagridview()

    End Sub

    Private Sub ButtonRemoveGrade_Click(sender As Object, e As EventArgs) Handles ButtonRemoveGrade.Click


        Dim studentIDtoDel As Integer = DataGridViewManageScore.CurrentRow.Cells(0).Value
        Dim courseIDtoDel As Integer = DataGridViewManageScore.CurrentRow.Cells(3).Value

        If MsgBox("DELETE THIS GRADE", MsgBoxStyle.YesNo, "Delete Grade") = MsgBoxResult.Yes Then

            If score.DeleteGrade(studentIDtoDel, courseIDtoDel) Then
                MsgBox("Grade Deleted", MsgBoxStyle.Information, "Delete Grade")
                DataGridViewManageScore.DataSource = score.getStudentScore()
            Else
                MsgBox("Grade NOT Deleted", MsgBoxStyle.Exclamation, "Delete Grade")
            End If

        End If

    End Sub

    Private Sub ButtonGrade_Click(sender As Object, e As EventArgs) Handles ButtonGrade.Click

        Try
            Dim Student_id As Integer = Convert.ToInt32(TextBoxStudentID.Text)
            Dim Course_id As Integer = Convert.ToInt32(ComboBoxEditCourse.SelectedValue)
            Dim ExamGrade As Double = Convert.ToDouble(TextBoxExamGrade.Text)
            Dim Description As String = TextBoxCourseDescription.Text
            Dim CreditHours As Integer = Convert.ToInt32(TextBoxCreditHours.Text)
            Dim GPA As Double = 0.0

            If Not score.studentScoreExist(Student_id, Course_id) Then

                If score.InsertGrades(Student_id, Course_id, ExamGrade, CreditHours, Description, GPA) Then

                    MsgBox("Student Grade Recorded", MsgBoxStyle.Information, "Add Grades")

                Else
                    MsgBox("Student Grades NOT Recorded", MsgBoxStyle.Exclamation, "Add Grades")

                End If
            Else
                MsgBox("Student Grade Already Exist", MsgBoxStyle.Exclamation, "Add Grade")

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Add Grade")
        End Try


    End Sub

    Private Sub ButtonAverage_Click(sender As Object, e As EventArgs) Handles ButtonAverage.Click

        Dim avgScoreByCourse As New AverageScoreCourseForm()
        avgScoreByCourse.Show(Me)

    End Sub
End Class