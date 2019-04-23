Imports System.IO
Imports MySql.Data.MySqlClient

Public Class UpdateDeleteStudentForm

    Dim student As New Student()

    Private Sub ButtonRemoveStudent_Click(sender As Object, e As EventArgs) Handles ButtonRemoveStudent.Click

        'Delete Student
        Try

            Dim Student_idRemove As Integer = Convert.ToInt32(TextBoxStudentID.Text)

            'Delete precaution
            If MsgBox("Are you sure you want to delete this student? ", MsgBoxStyle.YesNo, "Delete Student") = MsgBoxResult.Yes Then

                If student.deleteStudent(Student_idRemove) Then
                    MsgBox("Student Data Deleted", MsgBoxStyle.Information, "Delete Student")

                    'clear fields  after delete
                    TextBoxStudentID.Text = ""
                    TextBoxfName.Text = ""
                    TextBoxlName.Text = ""
                    TextBoxAddress.Text = ""
                    TextBoxeMail.Text = ""
                    DateTimePicker1.Value = Date.Now
                    PictureBoxStudent.Image = Nothing

                Else
                    MsgBox("Student Data Not Deleted", MsgBoxStyle.Information, "Delete Student")

                End If
            End If
        Catch ex As Exception
            MsgBox("Please enter a valid student ID", MsgBoxStyle.Information, "Delete Student")

        End Try

    End Sub

    Private Sub ButtonEditStudent_Click(sender As Object, e As EventArgs) Handles ButtonEditStudent.Click

        Try
            Dim student As New Student()
            Dim Student_id As String = TextBoxStudentID.Text
            Dim fName As String = TextBoxfName.Text
            Dim lName As String = TextBoxlName.Text
            Dim Birth_Date As Date = DateTimePicker1.Value
            Dim Address As String = TextBoxAddress.Text
            Dim eMail As String = TextBoxeMail.Text
            Dim Picture As New MemoryStream

            Dim Gender As String = "Male"
            If RadioButtonFemale.Checked Then
                Gender = "Female"
            End If

            Dim born_year As Integer = DateTimePicker1.Value.Year
            Dim this_year As Integer = Date.Now.Year

            'Allow only students age between 15 - 100
            If this_year - born_year < 15 Or this_year - born_year > 100 Then
                MsgBox("Student Age Must Be Between 15 and 100 years", MsgBoxStyle.Information, "Birth Date Error Detected")

            Else


                If Verify() Then
                    'Dim Student_id As Integer = Convert.ToInt32(TextBoxStudentID.Text)
                    PictureBoxStudent.Image.Save(Picture, PictureBoxStudent.Image.RawFormat)

                    If student.UpdateStudent(Student_id, fName, lName, Birth_Date, Gender, Address, eMail, Picture) Then

                        MsgBox("Student Edited Successfully", MsgBoxStyle.Information, "Edit Student")
                    Else
                        MsgBox("Error Editing New Student", MsgBoxStyle.Critical, "Edit Student")
                    End If
                Else
                    MsgBox("Empty Fields", MsgBoxStyle.Critical, "Edit Student")
                End If
            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally

        End Try

    End Sub

    Private Sub TextBoxStudentID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxStudentID.KeyPress
        'Allow only numbers on this textbox
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    'Functio to verify data
    Function Verify() As Boolean

        If TextBoxStudentID.Text.Trim() = "" Or TextBoxfName.Text.Trim() = "" Or TextBoxlName.Text.Trim() = "" Or TextBoxAddress.Text.Trim() = "" Or PictureBoxStudent.Image Is Nothing Then

            Return False

        Else

            Return True

        End If

        Return True

    End Function

    Private Sub ButtonUpdateImage_Click(sender As Object, e As EventArgs) Handles ButtonUpdateImage.Click
        Dim opf As New OpenFileDialog()
        opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif"

        If opf.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PictureBoxStudent.Image = Image.FromFile(opf.FileName)
        End If
    End Sub
End Class