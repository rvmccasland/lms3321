Imports System.IO
Imports MySql.Data.MySqlClient

Public Class StudentListForm

    Dim Student As New Student()

    Private Sub StudentListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim command As New MySqlCommand("SELECT Student_id, fName, lName, Birth_Date, Gender, Address, eMail, Picture FROM ldbmsrev.student ORDER BY Student_id;")

        DataGridViewStudentList.ReadOnly = True

        Dim picCol As New DataGridViewImageColumn()

        DataGridViewStudentList.RowTemplate.Height = 80

        DataGridViewStudentList.DataSource = Student.GetStudentsList(command)

        picCol = DataGridViewStudentList.Columns(7)

        picCol.ImageLayout = DataGridViewImageCellLayout.Zoom

        DataGridViewStudentList.AllowUserToAddRows = False


    End Sub

    Private Sub DataGridViewStudentList_DoubleClick(sender As Object, e As EventArgs) Handles DataGridViewStudentList.DoubleClick
        'Display the selected  row data into update, delete student form on double click

        Dim updateDeleteStudForm As New UpdateDeleteStudentForm()

        updateDeleteStudForm.TextBoxStudentID.Text = DataGridViewStudentList.CurrentRow.Cells(0).Value.ToString()
        updateDeleteStudForm.TextBoxfName.Text = DataGridViewStudentList.CurrentRow.Cells(1).Value.ToString()
        updateDeleteStudForm.TextBoxlName.Text = DataGridViewStudentList.CurrentRow.Cells(2).Value.ToString()
        updateDeleteStudForm.DateTimePicker1.Value = DataGridViewStudentList.CurrentRow.Cells(3).Value

        'Gender edit
        If DataGridViewStudentList.CurrentRow.Cells(4).Value.ToString() = "Female" Then
            updateDeleteStudForm.RadioButtonFemale.Checked = True
        End If

        updateDeleteStudForm.TextBoxAddress.Text = DataGridViewStudentList.CurrentRow.Cells(5).Value.ToString()
        updateDeleteStudForm.TextBoxeMail.Text = DataGridViewStudentList.CurrentRow.Cells(6).Value.ToString()

        Dim pic As Byte()
        pic = DataGridViewStudentList.CurrentRow.Cells(7).Value
        Dim picture As New MemoryStream(pic)
        updateDeleteStudForm.PictureBoxStudent.Image = Image.FromStream(picture)

        updateDeleteStudForm.Show()

    End Sub

    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click

        Dim command As New MySqlCommand("SELECT Student_id, fName, lName, Birth_Date, Gender, Address, eMail, Picture FROM ldbmsrev.student ORDER BY Student_id;")

        DataGridViewStudentList.ReadOnly = True

        Dim picCol As New DataGridViewImageColumn()

        DataGridViewStudentList.RowTemplate.Height = 80

        DataGridViewStudentList.DataSource = Student.GetStudentsList(command)

        picCol = DataGridViewStudentList.Columns(7)

        picCol.ImageLayout = DataGridViewImageCellLayout.Zoom

        DataGridViewStudentList.AllowUserToAddRows = False


    End Sub
End Class