Imports MySql.Data.MySqlClient

Public Class AddGradesForm

    Dim score As New GRADES()
    Dim CourseEdit As New COURSE()
    Dim Student As New Student()
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

    Private Sub AddGradesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Display COURSE on the combo box list
        ComboBoxEditCourse.DataSource = CourseEdit.GetAllCourses()
        ComboBoxEditCourse.DisplayMember = "Course_Title"
        ComboBoxEditCourse.ValueMember = "Course_id"

        'Set the selected combo item to nothing
        ComboBoxEditCourse.SelectedItem = Nothing

        Dim command As New MySqlCommand("SELECT Student_id, fName, lName FROM ldbmsrev.student ORDER BY Student_id;")
        DataGridViewStudent.DataSource = Student.GetStudentsList(command)


    End Sub

    Private Sub DataGridViewStudent_Click(sender As Object, e As EventArgs) Handles DataGridViewStudent.Click

        TextBoxStudentID.Text = DataGridViewStudent.CurrentRow.Cells(0).Value.ToString()



    End Sub

    Private Sub ButtonRemoveGrade_Click(sender As Object, e As EventArgs) Handles ButtonRemoveGrade.Click
        RemoveGrade.Show()
    End Sub
End Class