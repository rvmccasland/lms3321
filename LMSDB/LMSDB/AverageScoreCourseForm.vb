Public Class AverageScoreCourseForm

    Dim AvgScore As New GRADES()
    Private Sub AverageScoreCourseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DataGridViewAVGCourse.DataSource = AvgScore.getSAVGtudentScoreCourse()

    End Sub
End Class