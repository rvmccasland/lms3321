Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load




    End Sub

    Private Sub AddNewStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewStudentToolStripMenuItem.Click
        Dim addStudent As New AddstudentForm()
        addStudent.Show(Me)

    End Sub

    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        Close()
    End Sub



End Class