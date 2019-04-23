<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.STUDENTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaticsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditDeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageStudentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.COURSEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewCourseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveCourseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditCourseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageCoursesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SCOREToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecordNewGradesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PROGRAMSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TEACHERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewTeacherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.STUDENTToolStripMenuItem, Me.COURSEToolStripMenuItem, Me.SCOREToolStripMenuItem, Me.PROGRAMSToolStripMenuItem, Me.TEACHERToolStripMenuItem, Me.EXITToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'STUDENTToolStripMenuItem
        '
        Me.STUDENTToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewStudentToolStripMenuItem, Me.StudentListToolStripMenuItem, Me.StaticsToolStripMenuItem, Me.EditDeleteToolStripMenuItem, Me.ManageStudentsToolStripMenuItem})
        Me.STUDENTToolStripMenuItem.Name = "STUDENTToolStripMenuItem"
        Me.STUDENTToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.STUDENTToolStripMenuItem.Text = "STUDENTS"
        '
        'AddNewStudentToolStripMenuItem
        '
        Me.AddNewStudentToolStripMenuItem.Name = "AddNewStudentToolStripMenuItem"
        Me.AddNewStudentToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.AddNewStudentToolStripMenuItem.Text = "Add New Student"
        '
        'StudentListToolStripMenuItem
        '
        Me.StudentListToolStripMenuItem.Name = "StudentListToolStripMenuItem"
        Me.StudentListToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.StudentListToolStripMenuItem.Text = "Student List"
        '
        'StaticsToolStripMenuItem
        '
        Me.StaticsToolStripMenuItem.Name = "StaticsToolStripMenuItem"
        Me.StaticsToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.StaticsToolStripMenuItem.Text = "Statistics"
        '
        'EditDeleteToolStripMenuItem
        '
        Me.EditDeleteToolStripMenuItem.Name = "EditDeleteToolStripMenuItem"
        Me.EditDeleteToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.EditDeleteToolStripMenuItem.Text = "Edit / Delete"
        '
        'ManageStudentsToolStripMenuItem
        '
        Me.ManageStudentsToolStripMenuItem.Name = "ManageStudentsToolStripMenuItem"
        Me.ManageStudentsToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.ManageStudentsToolStripMenuItem.Text = "Manage Students"
        '
        'COURSEToolStripMenuItem
        '
        Me.COURSEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewCourseToolStripMenuItem, Me.RemoveCourseToolStripMenuItem, Me.EditCourseToolStripMenuItem, Me.ManageCoursesToolStripMenuItem})
        Me.COURSEToolStripMenuItem.Name = "COURSEToolStripMenuItem"
        Me.COURSEToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.COURSEToolStripMenuItem.Text = "COURSES"
        '
        'AddNewCourseToolStripMenuItem
        '
        Me.AddNewCourseToolStripMenuItem.Name = "AddNewCourseToolStripMenuItem"
        Me.AddNewCourseToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.AddNewCourseToolStripMenuItem.Text = "Add New Course"
        '
        'RemoveCourseToolStripMenuItem
        '
        Me.RemoveCourseToolStripMenuItem.Name = "RemoveCourseToolStripMenuItem"
        Me.RemoveCourseToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.RemoveCourseToolStripMenuItem.Text = "Remove Course"
        '
        'EditCourseToolStripMenuItem
        '
        Me.EditCourseToolStripMenuItem.Name = "EditCourseToolStripMenuItem"
        Me.EditCourseToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.EditCourseToolStripMenuItem.Text = "Edit Course"
        '
        'ManageCoursesToolStripMenuItem
        '
        Me.ManageCoursesToolStripMenuItem.Name = "ManageCoursesToolStripMenuItem"
        Me.ManageCoursesToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.ManageCoursesToolStripMenuItem.Text = "Manage Courses"
        '
        'SCOREToolStripMenuItem
        '
        Me.SCOREToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RecordNewGradesToolStripMenuItem})
        Me.SCOREToolStripMenuItem.Name = "SCOREToolStripMenuItem"
        Me.SCOREToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.SCOREToolStripMenuItem.Text = "GRADES"
        '
        'RecordNewGradesToolStripMenuItem
        '
        Me.RecordNewGradesToolStripMenuItem.Name = "RecordNewGradesToolStripMenuItem"
        Me.RecordNewGradesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RecordNewGradesToolStripMenuItem.Text = "Record New Grades"
        '
        'PROGRAMSToolStripMenuItem
        '
        Me.PROGRAMSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewProgramToolStripMenuItem})
        Me.PROGRAMSToolStripMenuItem.Name = "PROGRAMSToolStripMenuItem"
        Me.PROGRAMSToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.PROGRAMSToolStripMenuItem.Text = "PROGRAMS"
        '
        'AddNewProgramToolStripMenuItem
        '
        Me.AddNewProgramToolStripMenuItem.Name = "AddNewProgramToolStripMenuItem"
        Me.AddNewProgramToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.AddNewProgramToolStripMenuItem.Text = "Add New Program"
        '
        'TEACHERToolStripMenuItem
        '
        Me.TEACHERToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewTeacherToolStripMenuItem})
        Me.TEACHERToolStripMenuItem.Name = "TEACHERToolStripMenuItem"
        Me.TEACHERToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.TEACHERToolStripMenuItem.Text = "TEACHERS"
        '
        'AddNewTeacherToolStripMenuItem
        '
        Me.AddNewTeacherToolStripMenuItem.Name = "AddNewTeacherToolStripMenuItem"
        Me.AddNewTeacherToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.AddNewTeacherToolStripMenuItem.Text = "Add New Teacher"
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.EXITToolStripMenuItem.Text = "EXIT"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(22, 20)
        Me.ToolStripMenuItem1.Text = " "
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents STUDENTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents COURSEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SCOREToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewStudentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PROGRAMSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TEACHERToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewCourseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RecordNewGradesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewProgramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewTeacherToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EXITToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StaticsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditDeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageStudentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveCourseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EditCourseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageCoursesToolStripMenuItem As ToolStripMenuItem
End Class
