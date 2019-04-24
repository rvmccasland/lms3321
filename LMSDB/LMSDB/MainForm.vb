Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        BackgroundImage = Image.FromFile("../../Images/colorful-340.png")

    End Sub
    Private Sub AddNewStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewStudentToolStripMenuItem.Click
        Dim addStudent As New AddstudentForm()
        addStudent.Show(Me)
    End Sub

    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub StudentListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentListToolStripMenuItem.Click

        Dim studentList As New StudentListForm()
        studentList.Show(Me)

    End Sub

    Private Sub StaticsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StaticsToolStripMenuItem.Click

        Dim StaticF As New StaticsForm()
        StaticF.Show(Me)


    End Sub

    Private Sub EditDeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditDeleteToolStripMenuItem.Click

        Dim UpdateDeleteStudent As New UpdateDeleteStudentForm()
        UpdateDeleteStudent.Show(Me)


    End Sub

    Private Sub ManageStudentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageStudentsToolStripMenuItem.Click

        Dim ManageStudentF As New ManageStudentForm()
        ManageStudentF.Show(Me)

    End Sub

    Private Sub AddNewCourseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewCourseToolStripMenuItem.Click

        Dim addCourseF As New AddCourseForm()
        addCourseF.Show(Me)

    End Sub

    Private Sub RemoveCourseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveCourseToolStripMenuItem.Click

        Dim removeCourseF As New DeleteCourseForm()
        removeCourseF.Show(Me)

    End Sub

    Private Sub EditCourseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditCourseToolStripMenuItem.Click

        Dim editCourseF As New EditCourseForm()
        editCourseF.Show(Me)

    End Sub

    Private Sub ManageCoursesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageCoursesToolStripMenuItem.Click

        Dim manageCourseF As New ManagecourseForm()
        manageCourseF.Show(Me)

    End Sub

    Private Sub RecordNewGradesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecordNewGradesToolStripMenuItem.Click

        Dim CalculateGradesF As New AddGradesForm()
        AddGradesForm.Show(Me)

    End Sub

    Private Sub ManageGradesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageGradesToolStripMenuItem.Click
        Dim ManageGradesF As New ManageGrades()
        ManageGrades.Show(Me)

    End Sub
End Class