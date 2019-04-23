Imports System.IO
Imports MySql.Data.MySqlClient

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
                    PictureBoxStudent.Image.Save(Picture, PictureBoxStudent.Image.RawFormat)

                    If student.InsertStudent(Student_id, fName, lName, Birth_Date, Gender, Address, eMail, Picture) Then

                        MsgBox("New Student Added Successfully", MsgBoxStyle.Information, "Add Student")
                    Else
                        MsgBox("Error Adding New Student", MsgBoxStyle.Critical, "Add Student")
                    End If
                Else
                    MsgBox("Empty Fields", MsgBoxStyle.Critical, "Add Student")
                End If
            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally

        End Try

        'clear fields  after Add
        TextBoxStudentID.Text = ""
        TextBoxfName.Text = ""
        TextBoxlName.Text = ""
        TextBoxAddress.Text = ""
        TextBoxeMail.Text = ""
        DateTimePicker1.Value = Date.Now
        PictureBoxStudent.Image = Nothing


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




End Class