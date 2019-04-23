<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddstudentForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxfName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxAddress = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxeMail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBoxStudent = New System.Windows.Forms.PictureBox()
        Me.ButtonUploadImage = New System.Windows.Forms.Button()
        Me.ButtonCancelStudent = New System.Windows.Forms.Button()
        Me.ButtonAddStudent = New System.Windows.Forms.Button()
        Me.TextBoxStudentID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxlName = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.LabelGender = New System.Windows.Forms.Label()
        Me.GroupBoxGender = New System.Windows.Forms.GroupBox()
        Me.RadioButtonMale = New System.Windows.Forms.RadioButton()
        Me.RadioButtonFemale = New System.Windows.Forms.RadioButton()
        CType(Me.PictureBoxStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxGender.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name"
        '
        'TextBoxfName
        '
        Me.TextBoxfName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxfName.Location = New System.Drawing.Point(114, 49)
        Me.TextBoxfName.Name = "TextBoxfName"
        Me.TextBoxfName.Size = New System.Drawing.Size(502, 26)
        Me.TextBoxfName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Last Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Birth Date"
        '
        'TextBoxAddress
        '
        Me.TextBoxAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAddress.Location = New System.Drawing.Point(114, 181)
        Me.TextBoxAddress.Multiline = True
        Me.TextBoxAddress.Name = "TextBoxAddress"
        Me.TextBoxAddress.Size = New System.Drawing.Size(502, 102)
        Me.TextBoxAddress.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Address"
        '
        'TextBoxeMail
        '
        Me.TextBoxeMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxeMail.Location = New System.Drawing.Point(114, 293)
        Me.TextBoxeMail.Name = "TextBoxeMail"
        Me.TextBoxeMail.Size = New System.Drawing.Size(502, 26)
        Me.TextBoxeMail.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(12, 293)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "eMail"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(12, 348)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Picture"
        '
        'PictureBoxStudent
        '
        Me.PictureBoxStudent.BackColor = System.Drawing.Color.Black
        Me.PictureBoxStudent.Location = New System.Drawing.Point(114, 348)
        Me.PictureBoxStudent.Name = "PictureBoxStudent"
        Me.PictureBoxStudent.Size = New System.Drawing.Size(227, 163)
        Me.PictureBoxStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxStudent.TabIndex = 11
        Me.PictureBoxStudent.TabStop = False
        '
        'ButtonUploadImage
        '
        Me.ButtonUploadImage.Location = New System.Drawing.Point(114, 510)
        Me.ButtonUploadImage.Name = "ButtonUploadImage"
        Me.ButtonUploadImage.Size = New System.Drawing.Size(227, 23)
        Me.ButtonUploadImage.TabIndex = 12
        Me.ButtonUploadImage.Text = "&Upload Image"
        Me.ButtonUploadImage.UseVisualStyleBackColor = True
        '
        'ButtonCancelStudent
        '
        Me.ButtonCancelStudent.BackColor = System.Drawing.Color.Red
        Me.ButtonCancelStudent.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonCancelStudent.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonCancelStudent.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonCancelStudent.Location = New System.Drawing.Point(494, 410)
        Me.ButtonCancelStudent.Name = "ButtonCancelStudent"
        Me.ButtonCancelStudent.Size = New System.Drawing.Size(122, 40)
        Me.ButtonCancelStudent.TabIndex = 14
        Me.ButtonCancelStudent.Text = "&Cancel"
        Me.ButtonCancelStudent.UseVisualStyleBackColor = False
        '
        'ButtonAddStudent
        '
        Me.ButtonAddStudent.BackColor = System.Drawing.Color.Blue
        Me.ButtonAddStudent.FlatAppearance.BorderColor = System.Drawing.Color.Yellow
        Me.ButtonAddStudent.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonAddStudent.Location = New System.Drawing.Point(347, 410)
        Me.ButtonAddStudent.Name = "ButtonAddStudent"
        Me.ButtonAddStudent.Size = New System.Drawing.Size(118, 40)
        Me.ButtonAddStudent.TabIndex = 13
        Me.ButtonAddStudent.Text = "&Add"
        Me.ButtonAddStudent.UseVisualStyleBackColor = False
        '
        'TextBoxStudentID
        '
        Me.TextBoxStudentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxStudentID.Location = New System.Drawing.Point(114, 12)
        Me.TextBoxStudentID.Name = "TextBoxStudentID"
        Me.TextBoxStudentID.Size = New System.Drawing.Size(502, 26)
        Me.TextBoxStudentID.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(12, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 20)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Student ID"
        '
        'TextBoxlName
        '
        Me.TextBoxlName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxlName.Location = New System.Drawing.Point(114, 94)
        Me.TextBoxlName.Name = "TextBoxlName"
        Me.TextBoxlName.Size = New System.Drawing.Size(502, 26)
        Me.TextBoxlName.TabIndex = 17
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(114, 133)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 18
        '
        'LabelGender
        '
        Me.LabelGender.AutoSize = True
        Me.LabelGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelGender.ForeColor = System.Drawing.Color.White
        Me.LabelGender.Location = New System.Drawing.Point(343, 144)
        Me.LabelGender.Name = "LabelGender"
        Me.LabelGender.Size = New System.Drawing.Size(69, 20)
        Me.LabelGender.TabIndex = 19
        Me.LabelGender.Text = "Gender"
        '
        'GroupBoxGender
        '
        Me.GroupBoxGender.Controls.Add(Me.RadioButtonFemale)
        Me.GroupBoxGender.Controls.Add(Me.RadioButtonMale)
        Me.GroupBoxGender.Location = New System.Drawing.Point(418, 131)
        Me.GroupBoxGender.Name = "GroupBoxGender"
        Me.GroupBoxGender.Size = New System.Drawing.Size(198, 41)
        Me.GroupBoxGender.TabIndex = 20
        Me.GroupBoxGender.TabStop = False
        '
        'RadioButtonMale
        '
        Me.RadioButtonMale.AutoSize = True
        Me.RadioButtonMale.Checked = True
        Me.RadioButtonMale.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonMale.ForeColor = System.Drawing.Color.White
        Me.RadioButtonMale.Location = New System.Drawing.Point(17, 9)
        Me.RadioButtonMale.Name = "RadioButtonMale"
        Me.RadioButtonMale.Size = New System.Drawing.Size(65, 24)
        Me.RadioButtonMale.TabIndex = 0
        Me.RadioButtonMale.TabStop = True
        Me.RadioButtonMale.Text = "Male"
        Me.RadioButtonMale.UseVisualStyleBackColor = True
        '
        'RadioButtonFemale
        '
        Me.RadioButtonFemale.AutoSize = True
        Me.RadioButtonFemale.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonFemale.ForeColor = System.Drawing.Color.White
        Me.RadioButtonFemale.Location = New System.Drawing.Point(88, 9)
        Me.RadioButtonFemale.Name = "RadioButtonFemale"
        Me.RadioButtonFemale.Size = New System.Drawing.Size(86, 24)
        Me.RadioButtonFemale.TabIndex = 1
        Me.RadioButtonFemale.TabStop = True
        Me.RadioButtonFemale.Text = "Female"
        Me.RadioButtonFemale.UseVisualStyleBackColor = True
        '
        'AddstudentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(728, 543)
        Me.Controls.Add(Me.GroupBoxGender)
        Me.Controls.Add(Me.LabelGender)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TextBoxlName)
        Me.Controls.Add(Me.TextBoxStudentID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ButtonCancelStudent)
        Me.Controls.Add(Me.ButtonAddStudent)
        Me.Controls.Add(Me.ButtonUploadImage)
        Me.Controls.Add(Me.PictureBoxStudent)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBoxeMail)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBoxAddress)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxfName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AddstudentForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddstudentForm"
        CType(Me.PictureBoxStudent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxGender.ResumeLayout(False)
        Me.GroupBoxGender.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxfName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxAddress As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxeMail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBoxStudent As PictureBox
    Friend WithEvents ButtonUploadImage As Button
    Friend WithEvents ButtonCancelStudent As Button
    Friend WithEvents ButtonAddStudent As Button
    Friend WithEvents TextBoxStudentID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxlName As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents LabelGender As Label
    Friend WithEvents GroupBoxGender As GroupBox
    Friend WithEvents RadioButtonFemale As RadioButton
    Friend WithEvents RadioButtonMale As RadioButton
End Class
