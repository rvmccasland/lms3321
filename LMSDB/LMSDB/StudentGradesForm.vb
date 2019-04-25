Public Class StudentGradesForm


    Dim AvgStudentScore As New GRADES()
    Private Sub StudentGradesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        DataGridViewStudentGrades.DataSource = AvgStudentScore.getSAVGtudentScore()

    End Sub
End Class