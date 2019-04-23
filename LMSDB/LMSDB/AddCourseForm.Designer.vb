<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddCourseForm
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
        Me.TextBoxCourseDescription = New System.Windows.Forms.TextBox()
        Me.TextBoxCourseID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxCourseTitel = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NumericUpDownCourseHrs = New System.Windows.Forms.NumericUpDown()
        Me.ButtonAddCourse = New System.Windows.Forms.Button()
        CType(Me.NumericUpDownCourseHrs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxCourseDescription
        '
        Me.TextBoxCourseDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCourseDescription.Location = New System.Drawing.Point(114, 112)
        Me.TextBoxCourseDescription.Multiline = True
        Me.TextBoxCourseDescription.Name = "TextBoxCourseDescription"
        Me.TextBoxCourseDescription.Size = New System.Drawing.Size(502, 101)
        Me.TextBoxCourseDescription.TabIndex = 23
        '
        'TextBoxCourseID
        '
        Me.TextBoxCourseID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCourseID.Location = New System.Drawing.Point(114, 30)
        Me.TextBoxCourseID.Name = "TextBoxCourseID"
        Me.TextBoxCourseID.Size = New System.Drawing.Size(502, 26)
        Me.TextBoxCourseID.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(12, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 20)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Course ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Description"
        '
        'TextBoxCourseTitel
        '
        Me.TextBoxCourseTitel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCourseTitel.Location = New System.Drawing.Point(114, 67)
        Me.TextBoxCourseTitel.Name = "TextBoxCourseTitel"
        Me.TextBoxCourseTitel.Size = New System.Drawing.Size(502, 26)
        Me.TextBoxCourseTitel.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Course Title"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 225)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 20)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Hours"
        '
        'NumericUpDownCourseHrs
        '
        Me.NumericUpDownCourseHrs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDownCourseHrs.Location = New System.Drawing.Point(114, 224)
        Me.NumericUpDownCourseHrs.Maximum = New Decimal(New Integer() {16, 0, 0, 0})
        Me.NumericUpDownCourseHrs.Minimum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.NumericUpDownCourseHrs.Name = "NumericUpDownCourseHrs"
        Me.NumericUpDownCourseHrs.Size = New System.Drawing.Size(48, 22)
        Me.NumericUpDownCourseHrs.TabIndex = 25
        Me.NumericUpDownCourseHrs.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'ButtonAddCourse
        '
        Me.ButtonAddCourse.BackColor = System.Drawing.Color.Lime
        Me.ButtonAddCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAddCourse.Location = New System.Drawing.Point(114, 287)
        Me.ButtonAddCourse.Name = "ButtonAddCourse"
        Me.ButtonAddCourse.Size = New System.Drawing.Size(502, 34)
        Me.ButtonAddCourse.TabIndex = 26
        Me.ButtonAddCourse.Text = "&Add"
        Me.ButtonAddCourse.UseVisualStyleBackColor = False
        '
        'AddCourseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(688, 340)
        Me.Controls.Add(Me.ButtonAddCourse)
        Me.Controls.Add(Me.NumericUpDownCourseHrs)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxCourseDescription)
        Me.Controls.Add(Me.TextBoxCourseID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxCourseTitel)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AddCourseForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddCourseForm"
        CType(Me.NumericUpDownCourseHrs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxCourseDescription As TextBox
    Friend WithEvents TextBoxCourseID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxCourseTitel As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents NumericUpDownCourseHrs As NumericUpDown
    Friend WithEvents ButtonAddCourse As Button
End Class
