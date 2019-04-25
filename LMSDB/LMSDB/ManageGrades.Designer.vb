<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageGrades
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
        Me.ButtonRemoveGrade = New System.Windows.Forms.Button()
        Me.TextBoxCreditHours = New System.Windows.Forms.TextBox()
        Me.LabelCreditHours = New System.Windows.Forms.Label()
        Me.TextBoxExamGrade = New System.Windows.Forms.TextBox()
        Me.LabelCourseID = New System.Windows.Forms.Label()
        Me.ComboBoxEditCourse = New System.Windows.Forms.ComboBox()
        Me.ButtonGrade = New System.Windows.Forms.Button()
        Me.TextBoxCourseDescription = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxStudentID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewManageScore = New System.Windows.Forms.DataGridView()
        Me.ButtonShowStudents = New System.Windows.Forms.Button()
        Me.ButtonShowGrades = New System.Windows.Forms.Button()
        Me.ButtonAverage = New System.Windows.Forms.Button()
        Me.ButtonAVGstudent = New System.Windows.Forms.Button()
        CType(Me.DataGridViewManageScore, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonRemoveGrade
        '
        Me.ButtonRemoveGrade.BackColor = System.Drawing.Color.Red
        Me.ButtonRemoveGrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRemoveGrade.Location = New System.Drawing.Point(147, 311)
        Me.ButtonRemoveGrade.Name = "ButtonRemoveGrade"
        Me.ButtonRemoveGrade.Size = New System.Drawing.Size(331, 34)
        Me.ButtonRemoveGrade.TabIndex = 64
        Me.ButtonRemoveGrade.Text = "&Remove Grade"
        Me.ButtonRemoveGrade.UseVisualStyleBackColor = False
        '
        'TextBoxCreditHours
        '
        Me.TextBoxCreditHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCreditHours.Location = New System.Drawing.Point(407, 96)
        Me.TextBoxCreditHours.Name = "TextBoxCreditHours"
        Me.TextBoxCreditHours.Size = New System.Drawing.Size(71, 26)
        Me.TextBoxCreditHours.TabIndex = 63
        '
        'LabelCreditHours
        '
        Me.LabelCreditHours.AutoSize = True
        Me.LabelCreditHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCreditHours.ForeColor = System.Drawing.Color.White
        Me.LabelCreditHours.Location = New System.Drawing.Point(280, 99)
        Me.LabelCreditHours.Name = "LabelCreditHours"
        Me.LabelCreditHours.Size = New System.Drawing.Size(110, 20)
        Me.LabelCreditHours.TabIndex = 62
        Me.LabelCreditHours.Text = "Credit Hours"
        '
        'TextBoxExamGrade
        '
        Me.TextBoxExamGrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxExamGrade.Location = New System.Drawing.Point(147, 99)
        Me.TextBoxExamGrade.Name = "TextBoxExamGrade"
        Me.TextBoxExamGrade.Size = New System.Drawing.Size(101, 26)
        Me.TextBoxExamGrade.TabIndex = 61
        '
        'LabelCourseID
        '
        Me.LabelCourseID.AutoSize = True
        Me.LabelCourseID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCourseID.ForeColor = System.Drawing.Color.White
        Me.LabelCourseID.Location = New System.Drawing.Point(34, 60)
        Me.LabelCourseID.Name = "LabelCourseID"
        Me.LabelCourseID.Size = New System.Drawing.Size(90, 20)
        Me.LabelCourseID.TabIndex = 60
        Me.LabelCourseID.Text = "Course ID"
        '
        'ComboBoxEditCourse
        '
        Me.ComboBoxEditCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxEditCourse.FormattingEnabled = True
        Me.ComboBoxEditCourse.Location = New System.Drawing.Point(147, 56)
        Me.ComboBoxEditCourse.Name = "ComboBoxEditCourse"
        Me.ComboBoxEditCourse.Size = New System.Drawing.Size(217, 24)
        Me.ComboBoxEditCourse.TabIndex = 59
        '
        'ButtonGrade
        '
        Me.ButtonGrade.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonGrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGrade.Location = New System.Drawing.Point(147, 271)
        Me.ButtonGrade.Name = "ButtonGrade"
        Me.ButtonGrade.Size = New System.Drawing.Size(331, 34)
        Me.ButtonGrade.TabIndex = 58
        Me.ButtonGrade.Text = "&Add Grade"
        Me.ButtonGrade.UseVisualStyleBackColor = False
        '
        'TextBoxCourseDescription
        '
        Me.TextBoxCourseDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCourseDescription.Location = New System.Drawing.Point(147, 148)
        Me.TextBoxCourseDescription.Multiline = True
        Me.TextBoxCourseDescription.Name = "TextBoxCourseDescription"
        Me.TextBoxCourseDescription.Size = New System.Drawing.Size(331, 101)
        Me.TextBoxCourseDescription.TabIndex = 57
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(7, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 20)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "Exam Grades"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(24, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Description"
        '
        'TextBoxStudentID
        '
        Me.TextBoxStudentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxStudentID.Location = New System.Drawing.Point(147, 15)
        Me.TextBoxStudentID.Name = "TextBoxStudentID"
        Me.TextBoxStudentID.ReadOnly = True
        Me.TextBoxStudentID.Size = New System.Drawing.Size(217, 26)
        Me.TextBoxStudentID.TabIndex = 54
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(27, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 20)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Student ID"
        '
        'DataGridViewManageScore
        '
        Me.DataGridViewManageScore.AllowUserToAddRows = False
        Me.DataGridViewManageScore.AllowUserToDeleteRows = False
        Me.DataGridViewManageScore.AllowUserToResizeColumns = False
        Me.DataGridViewManageScore.AllowUserToResizeRows = False
        Me.DataGridViewManageScore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewManageScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewManageScore.Location = New System.Drawing.Point(510, 56)
        Me.DataGridViewManageScore.Name = "DataGridViewManageScore"
        Me.DataGridViewManageScore.Size = New System.Drawing.Size(529, 373)
        Me.DataGridViewManageScore.TabIndex = 65
        '
        'ButtonShowStudents
        '
        Me.ButtonShowStudents.Location = New System.Drawing.Point(510, 15)
        Me.ButtonShowStudents.Name = "ButtonShowStudents"
        Me.ButtonShowStudents.Size = New System.Drawing.Size(187, 23)
        Me.ButtonShowStudents.TabIndex = 66
        Me.ButtonShowStudents.Text = "Show Students"
        Me.ButtonShowStudents.UseVisualStyleBackColor = True
        '
        'ButtonShowGrades
        '
        Me.ButtonShowGrades.Location = New System.Drawing.Point(852, 12)
        Me.ButtonShowGrades.Name = "ButtonShowGrades"
        Me.ButtonShowGrades.Size = New System.Drawing.Size(187, 23)
        Me.ButtonShowGrades.TabIndex = 67
        Me.ButtonShowGrades.Text = "Show Grades"
        Me.ButtonShowGrades.UseVisualStyleBackColor = True
        '
        'ButtonAverage
        '
        Me.ButtonAverage.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonAverage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAverage.Location = New System.Drawing.Point(147, 360)
        Me.ButtonAverage.Name = "ButtonAverage"
        Me.ButtonAverage.Size = New System.Drawing.Size(331, 34)
        Me.ButtonAverage.TabIndex = 68
        Me.ButtonAverage.Text = "A&Verage Score By Course"
        Me.ButtonAverage.UseVisualStyleBackColor = False
        '
        'ButtonAVGstudent
        '
        Me.ButtonAVGstudent.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonAVGstudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAVGstudent.Location = New System.Drawing.Point(147, 413)
        Me.ButtonAVGstudent.Name = "ButtonAVGstudent"
        Me.ButtonAVGstudent.Size = New System.Drawing.Size(331, 34)
        Me.ButtonAVGstudent.TabIndex = 69
        Me.ButtonAVGstudent.Text = "AV&erage Score By Student"
        Me.ButtonAVGstudent.UseVisualStyleBackColor = False
        '
        'ManageGrades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1083, 502)
        Me.Controls.Add(Me.ButtonAVGstudent)
        Me.Controls.Add(Me.ButtonAverage)
        Me.Controls.Add(Me.ButtonShowGrades)
        Me.Controls.Add(Me.ButtonShowStudents)
        Me.Controls.Add(Me.DataGridViewManageScore)
        Me.Controls.Add(Me.ButtonRemoveGrade)
        Me.Controls.Add(Me.TextBoxCreditHours)
        Me.Controls.Add(Me.LabelCreditHours)
        Me.Controls.Add(Me.TextBoxExamGrade)
        Me.Controls.Add(Me.LabelCourseID)
        Me.Controls.Add(Me.ComboBoxEditCourse)
        Me.Controls.Add(Me.ButtonGrade)
        Me.Controls.Add(Me.TextBoxCourseDescription)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxStudentID)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ManageGrades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ManageGrades"
        CType(Me.DataGridViewManageScore, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonRemoveGrade As Button
    Friend WithEvents TextBoxCreditHours As TextBox
    Friend WithEvents LabelCreditHours As Label
    Friend WithEvents TextBoxExamGrade As TextBox
    Friend WithEvents LabelCourseID As Label
    Friend WithEvents ComboBoxEditCourse As ComboBox
    Friend WithEvents ButtonGrade As Button
    Friend WithEvents TextBoxCourseDescription As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxStudentID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridViewManageScore As DataGridView
    Friend WithEvents ButtonShowStudents As Button
    Friend WithEvents ButtonShowGrades As Button
    Friend WithEvents ButtonAverage As Button
    Friend WithEvents ButtonAVGstudent As Button
End Class
