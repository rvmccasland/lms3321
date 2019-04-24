Public Class RemoveGrade

    Dim score As New GRADES()
    Private Sub RemoveGrade_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DataGridViewStudentScore.DataSource = score.getStudentScore()

    End Sub

    Private Sub ButtonRemoveGrade_Click(sender As Object, e As EventArgs) Handles ButtonRemoveGrade.Click
        Dim studentIDtoDel As Integer = DataGridViewStudentScore.CurrentRow.Cells(0).Value
        Dim courseIDtoDel As Integer = DataGridViewStudentScore.CurrentRow.Cells(3).Value

        If MsgBox("DELETE THIS GRADE", MsgBoxStyle.YesNo, "Delete Grade") = MsgBoxResult.Yes Then

            If score.DeleteGrade(studentIDtoDel, courseIDtoDel) Then
                MsgBox("Grade Deleted", MsgBoxStyle.Information, "Delete Grade")
                DataGridViewStudentScore.DataSource = score.getStudentScore()
            Else
                MsgBox("Grade NOT Deleted", MsgBoxStyle.Exclamation, "Delete Grade")
            End If

        End If


    End Sub
End Class