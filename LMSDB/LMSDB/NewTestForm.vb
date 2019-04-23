Imports MySql.Data.MySqlClient

Public Class NewTestForm
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCreditHours.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim Grades As New GRADES()
            Dim Student_id As Integer = TextBoxStudentId.Text
            Dim ExamGrade As Integer = TextBoxExamAVG.Text
            Dim Credithours As Integer = TextBoxCreditHours.Text

            If Grades.InsertGrades(Student_id, ExamGrade, Credithours) Then

                MsgBox("New Grades Added Successfully", MsgBoxStyle.Information, "Add Grades")
            Else
                MsgBox("Error Adding New Grades", MsgBoxStyle.Critical, "Add Grades")
            End If

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally

        End Try



    End Sub

End Class