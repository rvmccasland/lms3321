<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateDeleteStudentForm
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
        Me.GroupBoxGender = New System.Windows.Forms.GroupBox()
        Me.RadioButtonFemale = New System.Windows.Forms.RadioButton()
        Me.RadioButtonMale = New System.Windows.Forms.RadioButton()
        Me.LabelGender = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBoxlName = New System.Windows.Forms.TextBox()
        Me.TextBoxStudentID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxfName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonRemoveStudent = New System.Windows.Forms.Button()
        Me.ButtonEditStudent = New System.Windows.Forms.Button()
        Me.PictureBoxStudent = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxeMail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxAddress = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ButtonUpdateImage = New System.Windows.Forms.Button()
        Me.GroupBoxGender.SuspendLayout()
        CType(Me.PictureBoxStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxGender
        '
        Me.GroupBoxGender.Controls.Add(Me.RadioButtonFemale)
        Me.GroupBoxGender.Controls.Add(Me.RadioButtonMale)
        Me.GroupBoxGender.Location = New System.Drawing.Point(425, 140)
        Me.GroupBoxGender.Name = "GroupBoxGender"
        Me.GroupBoxGender.Size = New System.Drawing.Size(198, 41)
        Me.GroupBoxGender.TabIndex = 30
        Me.GroupBoxGender.TabStop = False
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
        Me.RadioButtonFemale.Text = "Female"
        Me.RadioButtonFemale.UseVisualStyleBackColor = True
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
        'LabelGender
        '
        Me.LabelGender.AutoSize = True
        Me.LabelGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelGender.ForeColor = System.Drawing.Color.White
        Me.LabelGender.Location = New System.Drawing.Point(350, 153)
        Me.LabelGender.Name = "LabelGender"
        Me.LabelGender.Size = New System.Drawing.Size(69, 20)
        Me.LabelGender.TabIndex = 29
        Me.LabelGender.Text = "Gender"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(121, 142)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 28
        '
        'TextBoxlName
        '
        Me.TextBoxlName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxlName.Location = New System.Drawing.Point(121, 103)
        Me.TextBoxlName.Name = "TextBoxlName"
        Me.TextBoxlName.Size = New System.Drawing.Size(502, 26)
        Me.TextBoxlName.TabIndex = 27
        '
        'TextBoxStudentID
        '
        Me.TextBoxStudentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxStudentID.Location = New System.Drawing.Point(121, 21)
        Me.TextBoxStudentID.Name = "TextBoxStudentID"
        Me.TextBoxStudentID.Size = New System.Drawing.Size(502, 26)
        Me.TextBoxStudentID.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(19, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 20)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Student ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(19, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 20)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Birth Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(19, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 20)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Last Name"
        '
        'TextBoxfName
        '
        Me.TextBoxfName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxfName.Location = New System.Drawing.Point(121, 58)
        Me.TextBoxfName.Name = "TextBoxfName"
        Me.TextBoxfName.Size = New System.Drawing.Size(502, 26)
        Me.TextBoxfName.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(19, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 20)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "First Name"
        '
        'ButtonRemoveStudent
        '
        Me.ButtonRemoveStudent.BackColor = System.Drawing.Color.Red
        Me.ButtonRemoveStudent.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonRemoveStudent.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonRemoveStudent.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonRemoveStudent.Location = New System.Drawing.Point(501, 416)
        Me.ButtonRemoveStudent.Name = "ButtonRemoveStudent"
        Me.ButtonRemoveStudent.Size = New System.Drawing.Size(122, 40)
        Me.ButtonRemoveStudent.TabIndex = 39
        Me.ButtonRemoveStudent.Text = "&Remove"
        Me.ButtonRemoveStudent.UseVisualStyleBackColor = False
        '
        'ButtonEditStudent
        '
        Me.ButtonEditStudent.BackColor = System.Drawing.Color.Blue
        Me.ButtonEditStudent.FlatAppearance.BorderColor = System.Drawing.Color.Yellow
        Me.ButtonEditStudent.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonEditStudent.Location = New System.Drawing.Point(354, 416)
        Me.ButtonEditStudent.Name = "ButtonEditStudent"
        Me.ButtonEditStudent.Size = New System.Drawing.Size(118, 40)
        Me.ButtonEditStudent.TabIndex = 38
        Me.ButtonEditStudent.Text = "&Edit"
        Me.ButtonEditStudent.UseVisualStyleBackColor = False
        '
        'PictureBoxStudent
        '
        Me.PictureBoxStudent.BackColor = System.Drawing.Color.Black
        Me.PictureBoxStudent.Location = New System.Drawing.Point(121, 354)
        Me.PictureBoxStudent.Name = "PictureBoxStudent"
        Me.PictureBoxStudent.Size = New System.Drawing.Size(227, 163)
        Me.PictureBoxStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxStudent.TabIndex = 36
        Me.PictureBoxStudent.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(19, 354)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 20)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Picture"
        '
        'TextBoxeMail
        '
        Me.TextBoxeMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxeMail.Location = New System.Drawing.Point(121, 299)
        Me.TextBoxeMail.Name = "TextBoxeMail"
        Me.TextBoxeMail.Size = New System.Drawing.Size(502, 26)
        Me.TextBoxeMail.TabIndex = 34
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(19, 299)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 20)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "eMail"
        '
        'TextBoxAddress
        '
        Me.TextBoxAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAddress.Location = New System.Drawing.Point(121, 187)
        Me.TextBoxAddress.Multiline = True
        Me.TextBoxAddress.Name = "TextBoxAddress"
        Me.TextBoxAddress.Size = New System.Drawing.Size(502, 102)
        Me.TextBoxAddress.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(19, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 20)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Address"
        '
        'ButtonUpdateImage
        '
        Me.ButtonUpdateImage.Location = New System.Drawing.Point(121, 518)
        Me.ButtonUpdateImage.Name = "ButtonUpdateImage"
        Me.ButtonUpdateImage.Size = New System.Drawing.Size(227, 23)
        Me.ButtonUpdateImage.TabIndex = 40
        Me.ButtonUpdateImage.Text = "&Update Picture"
        Me.ButtonUpdateImage.UseVisualStyleBackColor = True
        '
        'UpdateDeleteStudentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 553)
        Me.Controls.Add(Me.ButtonUpdateImage)
        Me.Controls.Add(Me.ButtonRemoveStudent)
        Me.Controls.Add(Me.ButtonEditStudent)
        Me.Controls.Add(Me.PictureBoxStudent)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBoxeMail)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBoxAddress)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBoxGender)
        Me.Controls.Add(Me.LabelGender)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TextBoxlName)
        Me.Controls.Add(Me.TextBoxStudentID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxfName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "UpdateDeleteStudentForm"
        Me.Text = "UpdateDeleteStudentForm"
        Me.GroupBoxGender.ResumeLayout(False)
        Me.GroupBoxGender.PerformLayout()
        CType(Me.PictureBoxStudent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBoxGender As GroupBox
    Friend WithEvents RadioButtonFemale As RadioButton
    Friend WithEvents RadioButtonMale As RadioButton
    Friend WithEvents LabelGender As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBoxlName As TextBox
    Friend WithEvents TextBoxStudentID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxfName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonRemoveStudent As Button
    Friend WithEvents ButtonEditStudent As Button
    Friend WithEvents PictureBoxStudent As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxeMail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxAddress As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ButtonUpdateImage As Button
End Class
