<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddGradesForm
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
        Me.ComboBoxEditCourse = New System.Windows.Forms.ComboBox()
        Me.ButtonGrade = New System.Windows.Forms.Button()
        Me.TextBoxCourseDescription = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxStudentID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxExamGrade = New System.Windows.Forms.TextBox()
        Me.LabelCourseID = New System.Windows.Forms.Label()
        Me.TextBoxCreditHours = New System.Windows.Forms.TextBox()
        Me.LabelCreditHours = New System.Windows.Forms.Label()
        Me.DataGridViewStudent = New System.Windows.Forms.DataGridView()
        Me.ButtonRemoveGrade = New System.Windows.Forms.Button()
        CType(Me.DataGridViewStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBoxEditCourse
        '
        Me.ComboBoxEditCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxEditCourse.FormattingEnabled = True
        Me.ComboBoxEditCourse.Location = New System.Drawing.Point(205, 93)
        Me.ComboBoxEditCourse.Name = "ComboBoxEditCourse"
        Me.ComboBoxEditCourse.Size = New System.Drawing.Size(217, 24)
        Me.ComboBoxEditCourse.TabIndex = 45
        '
        'ButtonGrade
        '
        Me.ButtonGrade.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonGrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGrade.Location = New System.Drawing.Point(205, 308)
        Me.ButtonGrade.Name = "ButtonGrade"
        Me.ButtonGrade.Size = New System.Drawing.Size(331, 34)
        Me.ButtonGrade.TabIndex = 44
        Me.ButtonGrade.Text = "&Add Grade"
        Me.ButtonGrade.UseVisualStyleBackColor = False
        '
        'TextBoxCourseDescription
        '
        Me.TextBoxCourseDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCourseDescription.Location = New System.Drawing.Point(205, 185)
        Me.TextBoxCourseDescription.Multiline = True
        Me.TextBoxCourseDescription.Name = "TextBoxCourseDescription"
        Me.TextBoxCourseDescription.Size = New System.Drawing.Size(331, 101)
        Me.TextBoxCourseDescription.TabIndex = 41
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(65, 139)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 20)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Exam Grades"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(82, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Description"
        '
        'TextBoxStudentID
        '
        Me.TextBoxStudentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxStudentID.Location = New System.Drawing.Point(205, 52)
        Me.TextBoxStudentID.Name = "TextBoxStudentID"
        Me.TextBoxStudentID.ReadOnly = True
        Me.TextBoxStudentID.Size = New System.Drawing.Size(217, 26)
        Me.TextBoxStudentID.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(85, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 20)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Student ID"
        '
        'TextBoxExamGrade
        '
        Me.TextBoxExamGrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxExamGrade.Location = New System.Drawing.Point(205, 136)
        Me.TextBoxExamGrade.Name = "TextBoxExamGrade"
        Me.TextBoxExamGrade.Size = New System.Drawing.Size(101, 26)
        Me.TextBoxExamGrade.TabIndex = 47
        '
        'LabelCourseID
        '
        Me.LabelCourseID.AutoSize = True
        Me.LabelCourseID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCourseID.ForeColor = System.Drawing.Color.White
        Me.LabelCourseID.Location = New System.Drawing.Point(92, 97)
        Me.LabelCourseID.Name = "LabelCourseID"
        Me.LabelCourseID.Size = New System.Drawing.Size(90, 20)
        Me.LabelCourseID.TabIndex = 46
        Me.LabelCourseID.Text = "Course ID"
        '
        'TextBoxCreditHours
        '
        Me.TextBoxCreditHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCreditHours.Location = New System.Drawing.Point(465, 133)
        Me.TextBoxCreditHours.Name = "TextBoxCreditHours"
        Me.TextBoxCreditHours.Size = New System.Drawing.Size(71, 26)
        Me.TextBoxCreditHours.TabIndex = 50
        '
        'LabelCreditHours
        '
        Me.LabelCreditHours.AutoSize = True
        Me.LabelCreditHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCreditHours.ForeColor = System.Drawing.Color.White
        Me.LabelCreditHours.Location = New System.Drawing.Point(338, 136)
        Me.LabelCreditHours.Name = "LabelCreditHours"
        Me.LabelCreditHours.Size = New System.Drawing.Size(110, 20)
        Me.LabelCreditHours.TabIndex = 49
        Me.LabelCreditHours.Text = "Credit Hours"
        '
        'DataGridViewStudent
        '
        Me.DataGridViewStudent.AllowUserToAddRows = False
        Me.DataGridViewStudent.AllowUserToDeleteRows = False
        Me.DataGridViewStudent.AllowUserToResizeColumns = False
        Me.DataGridViewStudent.AllowUserToResizeRows = False
        Me.DataGridViewStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewStudent.Location = New System.Drawing.Point(560, 52)
        Me.DataGridViewStudent.Name = "DataGridViewStudent"
        Me.DataGridViewStudent.Size = New System.Drawing.Size(387, 373)
        Me.DataGridViewStudent.TabIndex = 51
        '
        'ButtonRemoveGrade
        '
        Me.ButtonRemoveGrade.BackColor = System.Drawing.Color.Red
        Me.ButtonRemoveGrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRemoveGrade.Location = New System.Drawing.Point(205, 391)
        Me.ButtonRemoveGrade.Name = "ButtonRemoveGrade"
        Me.ButtonRemoveGrade.Size = New System.Drawing.Size(331, 34)
        Me.ButtonRemoveGrade.TabIndex = 52
        Me.ButtonRemoveGrade.Text = "&Remove Grade"
        Me.ButtonRemoveGrade.UseVisualStyleBackColor = False
        '
        'AddGradesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1046, 510)
        Me.Controls.Add(Me.ButtonRemoveGrade)
        Me.Controls.Add(Me.DataGridViewStudent)
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
        Me.Name = "AddGradesForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddGradesForm"
        CType(Me.DataGridViewStudent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBoxEditCourse As ComboBox
    Friend WithEvents ButtonGrade As Button
    Friend WithEvents TextBoxCourseDescription As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxStudentID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxExamGrade As TextBox
    Friend WithEvents LabelCourseID As Label
    Friend WithEvents TextBoxCreditHours As TextBox
    Friend WithEvents LabelCreditHours As Label
    Friend WithEvents DataGridViewStudent As DataGridView
    Friend WithEvents ButtonRemoveGrade As Button
End Class
