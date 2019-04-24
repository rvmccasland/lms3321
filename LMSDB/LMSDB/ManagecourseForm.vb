Imports MySql.Data.MySqlClient

Public Class ManagecourseForm

    Dim ManageCourse As New COURSE()
    Dim position As Integer
    Private Sub ManagecourseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ReloadListBoxData()

    End Sub

    'Sub to populate modify the listbox data

    Sub ReloadListBoxData()

        ListBoxCourses.DataSource = ManageCourse.GetAllCourses()
        ListBoxCourses.ValueMember = "Course_id"
        ListBoxCourses.DisplayMember = "Course_Title"

        ListBoxCourses.SelectedItem = Nothing
        LabelCourseTotal.Text = "Total Courses: " + ManageCourse.TotalCourses()

    End Sub

    Private Sub ListBoxCourses_Click(sender As Object, e As EventArgs) Handles ListBoxCourses.Click

        Try
            Dim CourseData As DataRowView = ListBoxCourses.SelectedItem
            position = ListBoxCourses.SelectedIndex
            ShowData(position)

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally


        End Try


    End Sub

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
                        ReloadListBoxData()

                    Else
                        MsgBox("COURSE ADDITION FAILURE", MsgBoxStyle.Information, "Add Course")
                    End If

                Else
                    MsgBox("This Course Title Already Exists", MsgBoxStyle.Information, "Add Course")
                End If

            End If
            position = 0
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

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        'No changes to course title no edit
        Dim Course_Title As String = TextBoxCourseTitel.Text
        Dim Course_Hours As Integer = NumericUpDownCourseHrs.Value
        Dim Description As String = TextBoxCourseDescription.Text
        Dim Course_id As Integer = ListBoxCourses.SelectedValue

        If Not ManageCourse.CheckCourseTitle(Course_Title, Convert.ToInt32(ListBoxCourses.SelectedValue)) Then
            MsgBox("This Title Already Exists", MsgBoxStyle.Exclamation, "Edit Course")
        Else
            If ManageCourse.UpdateCourse(Course_id, Course_Title, Description, Course_Hours) Then
                MsgBox("Course Updated Successfully", MsgBoxStyle.Information, "Edit Course")
                ReloadListBoxData()
            Else
                MsgBox("Update Fail", MsgBoxStyle.Information, "Edit Course")
            End If

        End If

        position = 0

    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Dim CourseDel As New COURSE()

        Try
            Dim Course_idDel As Integer = Convert.ToInt32(ListBoxCourses.SelectedValue)

            If MsgBox("Are you sure about deleting this course", MsgBoxStyle.YesNo, "Remove Course") = MsgBoxResult.Yes Then

                If CourseDel.DeleteCourse(Course_idDel) Then
                    MsgBox("Course Deleted", MsgBoxStyle.Information, "Remove Course")
                    'Clear fields after delete
                    TextBoxCourseID.Text = ""
                    TextBoxCourseTitel.Text = ""
                    TextBoxCourseDescription.Text = ""
                    NumericUpDownCourseHrs.Value = 3

                    ReloadListBoxData()
                Else
                    MsgBox("Course NOT Deleted", MsgBoxStyle.Information, "Remove Course")

                End If

            End If

        Catch ex As Exception
            MsgBox("Enter A Valid Course ID", MsgBoxStyle.Exclamation, "Remove Course")
        End Try

        position = 0

    End Sub
    Private Sub ButtonFirst_Click(sender As Object, e As EventArgs) Handles ButtonFirst.Click
        position = 0
        ShowData(position)
    End Sub
    Private Sub ButtonNext_Click(sender As Object, e As EventArgs) Handles ButtonNext.Click
        If position < ManageCourse.GetAllCourses().Rows.Count - 1 Then
            position = position + 1
            ShowData(position)
        End If
    End Sub

    Private Sub ButtonPrevious_Click(sender As Object, e As EventArgs) Handles ButtonPrevious.Click
        If position > 0 Then
            position = position - 1
            ShowData(position)
        End If
    End Sub

    Private Sub ButtonLast_Click(sender As Object, e As EventArgs) Handles ButtonLast.Click
        position = ManageCourse.GetAllCourses().Rows.Count - 1
        ShowData(position)
    End Sub

    'Index Data To Show In Table
    Sub ShowData(ByVal index As Integer)

        Try
            Dim CourseDataRow As DataRow = ManageCourse.GetAllCourses().Rows(index)
            ListBoxCourses.SelectedIndex = index
            TextBoxCourseID.Text = CourseDataRow.Item(0).ToString()
            TextBoxCourseTitel.Text = CourseDataRow.Item(1).ToString()
            TextBoxCourseDescription.Text = CourseDataRow.Item(2).ToString()
            NumericUpDownCourseHrs.Value = CourseDataRow.Item(3)
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally


        End Try

    End Sub



End Class