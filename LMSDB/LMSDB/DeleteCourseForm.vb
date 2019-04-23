Public Class DeleteCourseForm
    Private Sub ButtonDeleteCourse_Click(sender As Object, e As EventArgs) Handles ButtonDeleteCourse.Click

        Dim CourseDel As New COURSE()

        Try
            Dim Course_idDel As Integer = Convert.ToInt32(TextBoxCourseID.Text)

            If MsgBox("Are you sure about deleting this course", MsgBoxStyle.YesNo, "Remove Course") = MsgBoxResult.Yes Then

                If CourseDel.DeleteCourse(Course_idDel) Then
                    MsgBox("Course Deleted", MsgBoxStyle.Information, "Remove Course")
                Else
                    MsgBox("Course NOT Deleted", MsgBoxStyle.Information, "Remove Course")

                End If

            End If

        Catch ex As Exception
            MsgBox("Enter A Valid Course ID", MsgBoxStyle.Exclamation, "Remove Course")
        End Try

    End Sub
End Class