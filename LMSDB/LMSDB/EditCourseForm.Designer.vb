<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditCourseForm
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
        Me.components = New System.ComponentModel.Container()
        Me.ButtonEditCourse = New System.Windows.Forms.Button()
        Me.NumericUpDownCourseHrs = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxCourseDescription = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxCourseTitel = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxEditCourse = New System.Windows.Forms.ComboBox()
        Me.CourseBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LdbmsrevDataSet1 = New LMSDB.ldbmsrevDataSet1()
        Me.LdbmsrevDataSet = New LMSDB.ldbmsrevDataSet()
        Me.LdbmsrevDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CourseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CourseTableAdapter = New LMSDB.ldbmsrevDataSetTableAdapters.courseTableAdapter()
        Me.CourseBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CourseTableAdapter1 = New LMSDB.ldbmsrevDataSet1TableAdapters.courseTableAdapter()
        CType(Me.NumericUpDownCourseHrs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CourseBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LdbmsrevDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LdbmsrevDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LdbmsrevDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CourseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CourseBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonEditCourse
        '
        Me.ButtonEditCourse.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonEditCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEditCourse.Location = New System.Drawing.Point(208, 270)
        Me.ButtonEditCourse.Name = "ButtonEditCourse"
        Me.ButtonEditCourse.Size = New System.Drawing.Size(502, 34)
        Me.ButtonEditCourse.TabIndex = 35
        Me.ButtonEditCourse.Text = "&Edit"
        Me.ButtonEditCourse.UseVisualStyleBackColor = False
        '
        'NumericUpDownCourseHrs
        '
        Me.NumericUpDownCourseHrs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDownCourseHrs.Location = New System.Drawing.Point(208, 225)
        Me.NumericUpDownCourseHrs.Maximum = New Decimal(New Integer() {16, 0, 0, 0})
        Me.NumericUpDownCourseHrs.Minimum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.NumericUpDownCourseHrs.Name = "NumericUpDownCourseHrs"
        Me.NumericUpDownCourseHrs.Size = New System.Drawing.Size(48, 22)
        Me.NumericUpDownCourseHrs.TabIndex = 34
        Me.NumericUpDownCourseHrs.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(121, 225)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 20)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Hours"
        '
        'TextBoxCourseDescription
        '
        Me.TextBoxCourseDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCourseDescription.Location = New System.Drawing.Point(208, 111)
        Me.TextBoxCourseDescription.Multiline = True
        Me.TextBoxCourseDescription.Name = "TextBoxCourseDescription"
        Me.TextBoxCourseDescription.Size = New System.Drawing.Size(502, 101)
        Me.TextBoxCourseDescription.TabIndex = 32
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(12, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(181, 20)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Selected Course Title"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(88, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Description"
        '
        'TextBoxCourseTitel
        '
        Me.TextBoxCourseTitel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCourseTitel.Location = New System.Drawing.Point(208, 63)
        Me.TextBoxCourseTitel.Name = "TextBoxCourseTitel"
        Me.TextBoxCourseTitel.Size = New System.Drawing.Size(502, 26)
        Me.TextBoxCourseTitel.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(88, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 20)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Course Title"
        '
        'ComboBoxEditCourse
        '
        Me.ComboBoxEditCourse.DataSource = Me.CourseBindingSource2
        Me.ComboBoxEditCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxEditCourse.FormattingEnabled = True
        Me.ComboBoxEditCourse.Location = New System.Drawing.Point(208, 33)
        Me.ComboBoxEditCourse.Name = "ComboBoxEditCourse"
        Me.ComboBoxEditCourse.Size = New System.Drawing.Size(502, 24)
        Me.ComboBoxEditCourse.TabIndex = 36
        '
        'CourseBindingSource2
        '
        Me.CourseBindingSource2.DataMember = "course"
        Me.CourseBindingSource2.DataSource = Me.LdbmsrevDataSet1
        '
        'LdbmsrevDataSet1
        '
        Me.LdbmsrevDataSet1.DataSetName = "ldbmsrevDataSet1"
        Me.LdbmsrevDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LdbmsrevDataSet
        '
        Me.LdbmsrevDataSet.DataSetName = "ldbmsrevDataSet"
        Me.LdbmsrevDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LdbmsrevDataSetBindingSource
        '
        Me.LdbmsrevDataSetBindingSource.DataSource = Me.LdbmsrevDataSet
        Me.LdbmsrevDataSetBindingSource.Position = 0
        '
        'CourseBindingSource
        '
        Me.CourseBindingSource.DataMember = "course"
        Me.CourseBindingSource.DataSource = Me.LdbmsrevDataSetBindingSource
        '
        'CourseTableAdapter
        '
        Me.CourseTableAdapter.ClearBeforeFill = True
        '
        'CourseBindingSource1
        '
        Me.CourseBindingSource1.DataMember = "course"
        Me.CourseBindingSource1.DataSource = Me.LdbmsrevDataSetBindingSource
        '
        'CourseTableAdapter1
        '
        Me.CourseTableAdapter1.ClearBeforeFill = True
        '
        'EditCourseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(811, 352)
        Me.Controls.Add(Me.ComboBoxEditCourse)
        Me.Controls.Add(Me.ButtonEditCourse)
        Me.Controls.Add(Me.NumericUpDownCourseHrs)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxCourseDescription)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxCourseTitel)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EditCourseForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditCourseForm"
        CType(Me.NumericUpDownCourseHrs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CourseBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LdbmsrevDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LdbmsrevDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LdbmsrevDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CourseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CourseBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonEditCourse As Button
    Friend WithEvents NumericUpDownCourseHrs As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxCourseDescription As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxCourseTitel As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxEditCourse As ComboBox
    Friend WithEvents LdbmsrevDataSet As ldbmsrevDataSet
    Friend WithEvents LdbmsrevDataSetBindingSource As BindingSource
    Friend WithEvents CourseBindingSource As BindingSource
    Friend WithEvents CourseTableAdapter As ldbmsrevDataSetTableAdapters.courseTableAdapter
    Friend WithEvents CourseBindingSource1 As BindingSource
    Friend WithEvents LdbmsrevDataSet1 As ldbmsrevDataSet1
    Friend WithEvents CourseBindingSource2 As BindingSource
    Friend WithEvents CourseTableAdapter1 As ldbmsrevDataSet1TableAdapters.courseTableAdapter
End Class
