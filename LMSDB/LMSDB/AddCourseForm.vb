Imports MySql.Data.MySqlClient

Public Class AddCourseForm
    Private Sub ButtonAddCourse_Click(sender As Object, e As EventArgs) Handles ButtonAddCourse.Click

        Try
            Dim Course_id As String = TextBoxCourseID.Text
            Dim Course_Title As String = TextBoxCourseTitel.Text
            Dim Descriptioin As String = TextBoxCourseDescription.Text
            Dim CourseHours As Integer = NumericUpDownCourseHrs.Value

            Dim course As New COURSE()
            'Check to see if fielda are blank
            If Course_id.Trim() = "" Or Course_Title.Trim() = "" Then
                MsgBox("Add A Course ID OR Course Title", MsgBoxStyle.Information, "Add Course")

            Else
                If course.CheckCourseTitle(Course_Title) Then

                    If course.InsertCourse(Course_id, Course_Title, Descriptioin, CourseHours) Then
                        MsgBox("Course Added Successfully", MsgBoxStyle.Information, "Add Course")
                    Else
                        MsgBox("COURSE ADDITION FAILURE", MsgBoxStyle.Information, "Add Course")
                    End If

                Else
                    MsgBox("This Course Title Already Exists", MsgBoxStyle.Information, "Add Course")
                End If

            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally

        End Try

        'Clear fields after entries
        TextBoxCourseID.Text = ""
        TextBoxCourseTitel.Text = ""
        TextBoxCourseDescription.Text = ""
        NumericUpDownCourseHrs.Value = 3

    End Sub

    Private Sub TextBoxCourseID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxCourseID.KeyPress
        'Allow only numbers on this textbox
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class