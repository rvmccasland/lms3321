<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManagecourseForm
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
        Me.ButtonAddCourse = New System.Windows.Forms.Button()
        Me.NumericUpDownCourseHrs = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxCourseDescription = New System.Windows.Forms.TextBox()
        Me.TextBoxCourseID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxCourseTitel = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBoxCourses = New System.Windows.Forms.ListBox()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonPrevious = New System.Windows.Forms.Button()
        Me.ButtonNext = New System.Windows.Forms.Button()
        Me.ButtonFirst = New System.Windows.Forms.Button()
        Me.ButtonLast = New System.Windows.Forms.Button()
        Me.LabelCourseTotal = New System.Windows.Forms.Label()
        CType(Me.NumericUpDownCourseHrs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonAddCourse
        '
        Me.ButtonAddCourse.BackColor = System.Drawing.Color.Lime
        Me.ButtonAddCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAddCourse.Location = New System.Drawing.Point(25, 486)
        Me.ButtonAddCourse.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.ButtonAddCourse.Name = "ButtonAddCourse"
        Me.ButtonAddCourse.Size = New System.Drawing.Size(108, 47)
        Me.ButtonAddCourse.TabIndex = 35
        Me.ButtonAddCourse.Text = "&Add"
        Me.ButtonAddCourse.UseVisualStyleBackColor = False
        '
        'NumericUpDownCourseHrs
        '
        Me.NumericUpDownCourseHrs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDownCourseHrs.Location = New System.Drawing.Point(139, 376)
        Me.NumericUpDownCourseHrs.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.NumericUpDownCourseHrs.Maximum = New Decimal(New Integer() {16, 0, 0, 0})
        Me.NumericUpDownCourseHrs.Minimum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.NumericUpDownCourseHrs.Name = "NumericUpDownCourseHrs"
        Me.NumericUpDownCourseHrs.Size = New System.Drawing.Size(80, 22)
        Me.NumericUpDownCourseHrs.TabIndex = 34
        Me.NumericUpDownCourseHrs.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(56, 375)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 20)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Hours"
        '
        'TextBoxCourseDescription
        '
        Me.TextBoxCourseDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCourseDescription.Location = New System.Drawing.Point(139, 218)
        Me.TextBoxCourseDescription.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TextBoxCourseDescription.Multiline = True
        Me.TextBoxCourseDescription.Name = "TextBoxCourseDescription"
        Me.TextBoxCourseDescription.Size = New System.Drawing.Size(328, 138)
        Me.TextBoxCourseDescription.TabIndex = 32
        '
        'TextBoxCourseID
        '
        Me.TextBoxCourseID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCourseID.Location = New System.Drawing.Point(139, 107)
        Me.TextBoxCourseID.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TextBoxCourseID.Name = "TextBoxCourseID"
        Me.TextBoxCourseID.Size = New System.Drawing.Size(211, 26)
        Me.TextBoxCourseID.TabIndex = 31
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(23, 110)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 20)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Course ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(8, 218)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Description"
        '
        'TextBoxCourseTitel
        '
        Me.TextBoxCourseTitel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCourseTitel.Location = New System.Drawing.Point(139, 159)
        Me.TextBoxCourseTitel.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TextBoxCourseTitel.Name = "TextBoxCourseTitel"
        Me.TextBoxCourseTitel.Size = New System.Drawing.Size(328, 26)
        Me.TextBoxCourseTitel.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(8, 165)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 20)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Course Title"
        '
        'ListBoxCourses
        '
        Me.ListBoxCourses.FormattingEnabled = True
        Me.ListBoxCourses.ItemHeight = 18
        Me.ListBoxCourses.Location = New System.Drawing.Point(493, 110)
        Me.ListBoxCourses.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.ListBoxCourses.Name = "ListBoxCourses"
        Me.ListBoxCourses.Size = New System.Drawing.Size(522, 382)
        Me.ListBoxCourses.TabIndex = 36
        '
        'ButtonEdit
        '
        Me.ButtonEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEdit.Location = New System.Drawing.Point(138, 486)
        Me.ButtonEdit.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(163, 47)
        Me.ButtonEdit.TabIndex = 37
        Me.ButtonEdit.Text = "&Edit"
        Me.ButtonEdit.UseVisualStyleBackColor = False
        '
        'ButtonDelete
        '
        Me.ButtonDelete.BackColor = System.Drawing.Color.Red
        Me.ButtonDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDelete.Location = New System.Drawing.Point(306, 486)
        Me.ButtonDelete.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(177, 47)
        Me.ButtonDelete.TabIndex = 38
        Me.ButtonDelete.Text = "&Remove"
        Me.ButtonDelete.UseVisualStyleBackColor = False
        '
        'ButtonPrevious
        '
        Me.ButtonPrevious.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtonPrevious.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonPrevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPrevious.Location = New System.Drawing.Point(253, 416)
        Me.ButtonPrevious.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.ButtonPrevious.Name = "ButtonPrevious"
        Me.ButtonPrevious.Size = New System.Drawing.Size(93, 47)
        Me.ButtonPrevious.TabIndex = 41
        Me.ButtonPrevious.Text = "<"
        Me.ButtonPrevious.UseVisualStyleBackColor = False
        '
        'ButtonNext
        '
        Me.ButtonNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtonNext.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNext.Location = New System.Drawing.Point(138, 416)
        Me.ButtonNext.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.ButtonNext.Name = "ButtonNext"
        Me.ButtonNext.Size = New System.Drawing.Size(105, 47)
        Me.ButtonNext.TabIndex = 40
        Me.ButtonNext.Text = ">"
        Me.ButtonNext.UseVisualStyleBackColor = False
        '
        'ButtonFirst
        '
        Me.ButtonFirst.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtonFirst.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonFirst.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonFirst.Location = New System.Drawing.Point(25, 416)
        Me.ButtonFirst.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.ButtonFirst.Name = "ButtonFirst"
        Me.ButtonFirst.Size = New System.Drawing.Size(108, 47)
        Me.ButtonFirst.TabIndex = 39
        Me.ButtonFirst.Text = "<<"
        Me.ButtonFirst.UseVisualStyleBackColor = False
        '
        'ButtonLast
        '
        Me.ButtonLast.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtonLast.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonLast.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLast.Location = New System.Drawing.Point(356, 416)
        Me.ButtonLast.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.ButtonLast.Name = "ButtonLast"
        Me.ButtonLast.Size = New System.Drawing.Size(74, 47)
        Me.ButtonLast.TabIndex = 42
        Me.ButtonLast.Text = ">>"
        Me.ButtonLast.UseVisualStyleBackColor = False
        '
        'LabelCourseTotal
        '
        Me.LabelCourseTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelCourseTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCourseTotal.ForeColor = System.Drawing.Color.White
        Me.LabelCourseTotal.Location = New System.Drawing.Point(793, 492)
        Me.LabelCourseTotal.Name = "LabelCourseTotal"
        Me.LabelCourseTotal.Size = New System.Drawing.Size(222, 41)
        Me.LabelCourseTotal.TabIndex = 47
        Me.LabelCourseTotal.Text = "Total Courses:"
        Me.LabelCourseTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ManagecourseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1081, 623)
        Me.Controls.Add(Me.LabelCourseTotal)
        Me.Controls.Add(Me.ButtonLast)
        Me.Controls.Add(Me.ButtonPrevious)
        Me.Controls.Add(Me.ButtonNext)
        Me.Controls.Add(Me.ButtonFirst)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonEdit)
        Me.Controls.Add(Me.ListBoxCourses)
        Me.Controls.Add(Me.ButtonAddCourse)
        Me.Controls.Add(Me.NumericUpDownCourseHrs)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxCourseDescription)
        Me.Controls.Add(Me.TextBoxCourseID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxCourseTitel)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "ManagecourseForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ManagecourseForm"
        CType(Me.NumericUpDownCourseHrs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonAddCourse As Button
    Friend WithEvents NumericUpDownCourseHrs As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxCourseDescription As TextBox
    Friend WithEvents TextBoxCourseID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxCourseTitel As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBoxCourses As ListBox
    Friend WithEvents ButtonEdit As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonPrevious As Button
    Friend WithEvents ButtonNext As Button
    Friend WithEvents ButtonFirst As Button
    Friend WithEvents ButtonLast As Button
    Friend WithEvents LabelCourseTotal As Label
End Class
