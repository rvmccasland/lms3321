Public Class ManagecourseForm

    Dim ManageCourse As New COURSE()
    Private Sub ManagecourseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ListBoxCourses.DataSource = ManageCourse.GetAllCourses()
        ListBoxCourses.ValueMember = "Course_id"
        ListBoxCourses.DisplayMember = "Course_Title"

        LabelCourseTotal.Text = "Total Courses: " + ManageCourse.TotalCourses()


    End Sub

    Private Sub ListBoxCourses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxCourses.SelectedIndexChanged
        Try
            TextBoxCourseID.Text = ListBoxCourses.SelectedValue.ToString()
            TextBoxCourseTitel.Text = ListBoxCourses.SelectedValue.ToString()
            TextBoxCourseDescription.Text = ListBoxCourses.SelectedValue.ToString()
            NumericUpDownCourseHrs.Value = ListBoxCourses.SelectedValue.ToString()
        Catch

        End Try

    End Sub

    Private Sub ListBoxCourses_Click(sender As Object, e As EventArgs) Handles ListBoxCourses.Click

        TextBoxCourseID.Text = ListBoxCourses.SelectedValue


    End Sub
End Class