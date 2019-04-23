Imports System.Drawing.Imaging
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class ManageStudentForm
    Dim db As New MYSQL_DB_()
    Dim Student As New Student()

    Private Sub ManageStudentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim command As New MySqlCommand("SELECT Student_id, fName, lName, Birth_Date, Gender, Address, eMail, Picture FROM ldbmsrev.student ORDER BY Student_id;")
        FillGrid(command)

        'Display Total Count of Students.
        'LabelStudentTotal.Text = LabelStudentTotal.Text & " " & DataGridViewStudentList.Rows.Count


    End Sub
    Private Sub TextBoxStudentID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxStudentID.KeyPress
        'Allow only numbers on this textbox
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    'Sub to fill the datagridview
    Sub FillGrid(ByVal command As MySqlCommand)

        DataGridViewStudentList.ReadOnly = True

        Dim picCol As New DataGridViewImageColumn()

        DataGridViewStudentList.RowTemplate.Height = 80

        DataGridViewStudentList.DataSource = Student.GetStudentsList(command)

        picCol = DataGridViewStudentList.Columns(7)

        picCol.ImageLayout = DataGridViewImageCellLayout.Zoom

        DataGridViewStudentList.AllowUserToAddRows = False
        'Display Total Count of Students.
        LabelStudentTotal.Text = " Total Students: " & DataGridViewStudentList.Rows.Count

    End Sub

    Private Sub DataGridViewStudentList_Click(sender As Object, e As EventArgs) Handles DataGridViewStudentList.Click
        TextBoxStudentID.Text = DataGridViewStudentList.CurrentRow.Cells(0).Value.ToString()
        TextBoxfName.Text = DataGridViewStudentList.CurrentRow.Cells(1).Value.ToString()
        TextBoxlName.Text = DataGridViewStudentList.CurrentRow.Cells(2).Value.ToString()
        DateTimePicker1.Value = DataGridViewStudentList.CurrentRow.Cells(3).Value

        'Gender edit
        If DataGridViewStudentList.CurrentRow.Cells(4).Value.ToString() = "Female" Then
            RadioButtonFemale.Checked = True
        Else
            RadioButtonMale.Checked = True
        End If

        TextBoxAddress.Text = DataGridViewStudentList.CurrentRow.Cells(5).Value.ToString()
        TextBoxeMail.Text = DataGridViewStudentList.CurrentRow.Cells(6).Value.ToString()

        Dim pic As Byte()
        pic = DataGridViewStudentList.CurrentRow.Cells(7).Value
        Dim picture As New MemoryStream(pic)
        PictureBoxStudent.Image = Image.FromStream(picture)


    End Sub

    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click
        '        Dim command As New MySqlCommand("SELECT Student_id, fName, lName, Birth_Date, Gender, Address, eMail, Picture FROM ldbmsrev.student WHERE CONCAT('fName','lName','Address') LIKE '%" & TextBoxSearch.Text & "%'")

        DataGridViewStudentList.ReadOnly = True

        Dim picCol As New DataGridViewImageColumn()

        DataGridViewStudentList.RowTemplate.Height = 80

        DataGridViewStudentList.DataSource = SearchGetStudentsList()

        picCol = DataGridViewStudentList.Columns(7)

        picCol.ImageLayout = DataGridViewImageCellLayout.Zoom

        DataGridViewStudentList.AllowUserToAddRows = False


    End Sub
    Function SearchGetStudentsList() As DataTable
        'Dim db As New MYSQL_DB_()
        Dim command As New MySqlCommand("SELECT Student_id, fName, lName, Birth_Date, Gender, Address, eMail, Picture FROM ldbmsrev.student WHERE concat (fName,lName) LIKE '%" & TextBoxSearch.Text & "%'")
        command.Connection = db.getConnection

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        Return table

    End Function

    Private Sub TextBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearch.TextChanged

        DataGridViewStudentList.ReadOnly = True

        Dim picCol As New DataGridViewImageColumn()

        DataGridViewStudentList.RowTemplate.Height = 80

        DataGridViewStudentList.DataSource = SearchGetStudentsList()

        picCol = DataGridViewStudentList.Columns(7)

        picCol.ImageLayout = DataGridViewImageCellLayout.Zoom

        DataGridViewStudentList.AllowUserToAddRows = False

        'Display Total Count of Students.
        LabelStudentTotal.Text = " Sub Total Students: " & DataGridViewStudentList.Rows.Count

    End Sub

    Private Sub ButtonUpload_Click(sender As Object, e As EventArgs) Handles ButtonUpload.Click
        Dim opf As New OpenFileDialog()
        opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif"

        If opf.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PictureBoxStudent.Image = Image.FromFile(opf.FileName)
        End If
    End Sub

    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click

        TextBoxStudentID.Text = ""
        TextBoxfName.Text = ""
        TextBoxlName.Text = ""
        TextBoxAddress.Text = ""
        TextBoxeMail.Text = ""
        PictureBoxStudent.Image = Nothing
        RadioButtonMale.Checked = True
        DateTimePicker1.Value = Date.Now

    End Sub

    Private Sub ButtonDownload_Click(sender As Object, e As EventArgs) Handles ButtonDownload.Click

        Dim Savefile As New SaveFileDialog()
        Savefile.FileName = "Student_" & TextBoxStudentID.Text

        If PictureBoxStudent.Image Is Nothing Then
            MsgBox("No Image Selected")
        Else
            If Savefile.ShowDialog() = Windows.Forms.DialogResult.OK Then
                PictureBoxStudent.Image.Save(Savefile.FileName & "." & ImageFormat.Jpeg.ToString())
            End If
        End If
    End Sub

    Function Verify() As Boolean

        If TextBoxStudentID.Text.Trim() = "" Or TextBoxfName.Text.Trim() = "" Or TextBoxlName.Text.Trim() = "" Or TextBoxAddress.Text.Trim() = "" Or PictureBoxStudent.Image Is Nothing Then

            Return False

        Else

            Return True

        End If

        Return True

    End Function


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
                        Dim command As New MySqlCommand("SELECT Student_id, fName, lName, Birth_Date, Gender, Address, eMail, Picture FROM ldbmsrev.student ORDER BY Student_id;")
                        FillGrid(command)
                        ButtonReset.PerformClick()
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

    End Sub

    Private Sub ButtonRemove_Click(sender As Object, e As EventArgs) Handles ButtonRemove.Click
        'Delete Student
        Try

            Dim Student_idRemove As Integer = Convert.ToInt32(TextBoxStudentID.Text)

            'Delete precaution
            If MsgBox("Are you sure you want to delete this student? ", MsgBoxStyle.YesNo, "Delete Student") = MsgBoxResult.Yes Then

                If Student.DeleteStudent(Student_idRemove) Then
                    MsgBox("Student Data Deleted", MsgBoxStyle.Information, "Delete Student")

                    Dim command As New MySqlCommand("SELECT Student_id, fName, lName, Birth_Date, Gender, Address, eMail, Picture FROM ldbmsrev.student ORDER BY Student_id;")
                    FillGrid(Command)

                    ButtonReset.PerformClick()

                Else
                    MsgBox("Student Data Not Deleted", MsgBoxStyle.Information, "Delete Student")

                End If
            End If
        Catch ex As Exception
            MsgBox("Please enter a valid student ID", MsgBoxStyle.Information, "Delete Student")

        End Try
    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
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
                        ButtonReset.PerformClick()
                        Dim command As New MySqlCommand("SELECT Student_id, fName, lName, Birth_Date, Gender, Address, eMail, Picture FROM ldbmsrev.student ORDER BY Student_id;")
                        FillGrid(command)
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

End Class