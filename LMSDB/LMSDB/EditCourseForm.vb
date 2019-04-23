Public Class EditCourseForm
    Dim CourseEdit As New COURSE()
    Private Sub EditCourseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Display COURSE on the combo box list

        ComboBoxEditCourse.DataSource = CourseEdit.GetAllCourses()
        ComboBoxEditCourse.DisplayMember = "Course_Title"
        ComboBoxEditCourse.ValueMember = "Course_id"

        'Set the selected combo item to nothing
        ComboBoxEditCourse.SelectedItem = Nothing

    End Sub

    Sub FillCombo(ByVal index As Integer)
        'Reload data into combo box list and Display current COURSE on the combo box list
        'Index is the selected record
        ComboBoxEditCourse.DataSource = CourseEdit.GetAllCourses()
        ComboBoxEditCourse.DisplayMember = "Course_Title"
        ComboBoxEditCourse.ValueMember = "Course_id"
        'Set the selected combo item to index
        ComboBoxEditCourse.SelectedIndex = index

    End Sub

    Private Sub ComboBoxEditCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxEditCourse.SelectedIndexChanged

        Try
            'Display the selected course details
            Dim Course_idEdit As Integer = Convert.ToInt32(ComboBoxEditCourse.SelectedValue)
            Dim table As New DataTable()
            table = CourseEdit.GetAllCoursesByID(Course_idEdit)
            TextBoxCourseTitel.Text = table.Rows(0)(1)
            NumericUpDownCourseHrs.Value = table.Rows(0)(3)
            TextBoxCourseDescription.Text = table.Rows(0)(2)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub ButtonEditCourse_Click(sender As Object, e As EventArgs) Handles ButtonEditCourse.Click

        'No changes to course title no edit

        Dim Course_Title As String = TextBoxCourseTitel.Text
        Dim Course_Hours As Integer = NumericUpDownCourseHrs.Value
        Dim Description As String = TextBoxCourseDescription.Text
        Dim Course_id As Integer = ComboBoxEditCourse.SelectedValue

        If Not CourseEdit.CheckCourseTitle(Course_Title, Convert.ToInt32(ComboBoxEditCourse.SelectedValue)) Then
            MsgBox("This Title Already Exists", MsgBoxStyle.Exclamation, "Edit Course")
        Else
            If CourseEdit.UpdateCourse(Course_id, Course_Title, Description, Course_Hours) Then
                MsgBox("Course Updated Successfully", MsgBoxStyle.Information, "Edit Course")
                FillCombo(ComboBoxEditCourse.SelectedIndex)
            Else
                MsgBox("Update Fail", MsgBoxStyle.Information, "Edit Course")
            End If

        End If

    End Sub
End Class