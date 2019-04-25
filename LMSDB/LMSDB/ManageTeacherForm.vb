
Imports MySql.Data.MySqlClient

Public Class ManageTeacherForm

    Dim db As New MYSQL_DB_()
    Dim TeacherManage As New TEACHER()

    Private Sub ManageTeacherForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim command As New MySqlCommand("SELECT Teacher_id, fName, lName FROM ldbmsrev.teacher ORDER BY Teacher_id;")
        FillGrid(command)



    End Sub

    Private Sub TextBoxSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxSearch.KeyPress

    End Sub

    Sub FillGrid(ByVal command As MySqlCommand)

        DataGridViewTeacherList.ReadOnly = True

        'Dim picCol As New DataGridViewImageColumn()

        DataGridViewTeacherList.RowTemplate.Height = 40

        DataGridViewTeacherList.DataSource = TeacherManage.GetTeacherList(command)

        DataGridViewTeacherList.AllowUserToAddRows = False

    End Sub

    Private Sub DataGridViewTeacherList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewTeacherList.CellContentClick
        TextBoxTeacherID.Text = DataGridViewTeacherList.CurrentRow.Cells(0).Value.ToString()
        TextBoxfName.Text = DataGridViewTeacherList.CurrentRow.Cells(1).Value.ToString()
        TextBoxlName.Text = DataGridViewTeacherList.CurrentRow.Cells(2).Value.ToString()

    End Sub

    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click

        DataGridViewTeacherList.ReadOnly = True

        DataGridViewTeacherList.RowTemplate.Height = 40

        DataGridViewTeacherList.DataSource = SearchGetTeacherList()

        DataGridViewTeacherList.AllowUserToAddRows = False

    End Sub

    Function SearchGetTeacherList() As DataTable
        'Dim db As New MYSQL_DB_()
        Dim command As New MySqlCommand("SELECT Teacher_id, fName, lName FROM ldbmsrev.teacher WHERE concat (fName,lName) LIKE '%" & TextBoxSearch.Text & "%'")
        command.Connection = db.getConnection

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        Return table

    End Function

    Private Sub TextBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearch.TextChanged
        DataGridViewTeacherList.ReadOnly = True

        DataGridViewTeacherList.RowTemplate.Height = 40

        DataGridViewTeacherList.DataSource = SearchGetTeacherList()

        DataGridViewTeacherList.AllowUserToAddRows = False
    End Sub

    Function Verify() As Boolean

        If TextBoxTeacherID.Text.Trim() = "" Or TextBoxfName.Text.Trim() = "" Or TextBoxlName.Text.Trim() = "" Then

            Return False

        Else

            Return True

        End If

        Return True

    End Function

    Private Sub ButtonAddTeacher_Click(sender As Object, e As EventArgs) Handles ButtonAddTeacher.Click
        Try
            Dim Teacher As New TEACHER()
            Dim Teacher_id As String = TextBoxTeacherID.Text
            Dim fName As String = TextBoxfName.Text
            Dim lName As String = TextBoxlName.Text


            If Verify() Then

                If Teacher.InsertTeacher(Teacher_id, fName, lName) Then
                    MsgBox("New Teacher Added Successfully", MsgBoxStyle.Information, "Add Teacher")
                    Dim command As New MySqlCommand("SELECT Teacher_id, fName, lName FROM ldbmsrev.teacher ORDER BY Teacher_id;")
                    FillGrid(command)
                    ButtonReset.PerformClick()
                Else
                    MsgBox("Error Adding New Teacher", MsgBoxStyle.Critical, "Add Teacher")
                End If
            Else
                MsgBox("Empty Fields", MsgBoxStyle.Critical, "Add Teacher")
            End If

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally

        End Try

    End Sub

    Private Sub ButtonRemove_Click(sender As Object, e As EventArgs) Handles ButtonRemove.Click

        Try

            Dim Teacher_idRemove As Integer = Convert.ToInt32(TextBoxTeacherID.Text)

            'Delete precaution
            If MsgBox("Are you sure you want to delete ? ", MsgBoxStyle.YesNo, "Delete Teacher") = MsgBoxResult.Yes Then

                If TeacherManage.DeleteTeacher(Teacher_idRemove) Then
                    MsgBox("Teacher Data Deleted", MsgBoxStyle.Information, "Delete Teacher")

                    Dim command As New MySqlCommand("SELECT Teacher_id, fName, lName FROM ldbmsrev.teacher ORDER BY Teacher_id;")
                    FillGrid(command)

                    ButtonReset.PerformClick()

                Else
                    MsgBox("Teacher Data Not Deleted", MsgBoxStyle.Information, "Delete Teacher")

                End If
            End If
        Catch ex As Exception
            MsgBox("Please enter a valid Teacher ID", MsgBoxStyle.Information, "Delete Teacher")

        End Try




    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        Try
            Dim TeacherEdit As New TEACHER()
            Dim Teacher_id As String = TextBoxTeacherID.Text
            Dim fName As String = TextBoxfName.Text
            Dim lName As String = TextBoxlName.Text

            If Verify() Then

                If TeacherEdit.UpdateTeacher(Teacher_id, fName, lName) Then
                    MsgBox("Teacher Edited Successfully", MsgBoxStyle.Information, "Edit Teacher")
                    ButtonReset.PerformClick()
                    Dim command As New MySqlCommand("SELECT Teacher_id, fName, lName FROM ldbmsrev.teacher ORDER BY Teacher_id;")
                    FillGrid(command)
                Else
                    MsgBox("Error Editing Teacher", MsgBoxStyle.Critical, "Edit Teacher")
                End If
            Else
                MsgBox("Empty Fields", MsgBoxStyle.Critical, "Edit Teacher")
            End If

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally

        End Try



    End Sub

    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click

        TextBoxTeacherID.Text = ""
        TextBoxfName.Text = ""
        TextBoxlName.Text = ""

    End Sub

    Private Sub TextBoxTeacherID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxTeacherID.KeyPress
        'Allow only numbers on this textbox
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

End Class