Imports System.IO

Public Class AddstudentForm
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ButtonUploadImage_Click(sender As Object, e As EventArgs) Handles ButtonUploadImage.Click
        Dim opf As New OpenFileDialog()
        opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif"

        If opf.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PictureBoxStudent.Image = Image.FromFile(opf.FileName)
        End If
    End Sub

    Private Sub ButtonCancelStudent_Click(sender As Object, e As EventArgs) Handles ButtonCancelStudent.Click
        Me.Close()
    End Sub

    Private Sub ButtonAddStudent_Click(sender As Object, e As EventArgs) Handles ButtonAddStudent.Click
        Dim student As New Student()

        Dim Student_id As Integer = TextBoxStudentID.Text
        Dim fName As String = TextBoxfName.Text
        Dim lName As String = TextBoxlName.Text
        Dim Birth_Date As Date = DateTimePicker1.Value
        Dim Address As String = TextBoxAddress.Text
        Dim eMail As String = TextBoxeMail.Text
        Dim Picture As New MemoryStream

        PictureBoxStudent.Image.Save(Picture, PictureBoxStudent.Image.RawFormat)

        If student.insertStudent(Student_id, fName, lName, Birth_Date, Address, eMail, Picture) Then

            MsgBox("New Student Added Successfully", MsgBoxStyle.Information, "Add Student")
        Else
            MsgBox("Error Adding New Student", MsgBoxStyle.Critical, "Add Student")
        End If

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub TextBoxStudentID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxStudentID.KeyPress
        'Allow only numbers on this textbox
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then

            e.Handled = True

        End If
    End Sub

    'Functio to verify data
    Function verify() As Boolean

        If TextBoxStudentID.Text.Trim() = "" Or TextBoxfName.Text.Trim() = "" Or TextBoxlName.Text.Trim() = "" Or TextBoxAddress.Text.Trim() = "" Then

            Return False

        Else

            Return True

        End If

        Return True

    End Function


End Class