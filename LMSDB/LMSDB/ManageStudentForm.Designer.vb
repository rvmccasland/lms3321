<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageStudentForm
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
        Me.DataGridViewStudentList = New System.Windows.Forms.DataGridView()
        Me.GroupBoxGender = New System.Windows.Forms.GroupBox()
        Me.RadioButtonFemale = New System.Windows.Forms.RadioButton()
        Me.RadioButtonMale = New System.Windows.Forms.RadioButton()
        Me.LabelGender = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBoxlName = New System.Windows.Forms.TextBox()
        Me.TextBoxStudentID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ButtonRemove = New System.Windows.Forms.Button()
        Me.ButtonAddStudent = New System.Windows.Forms.Button()
        Me.PictureBoxStudent = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxeMail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxAddress = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxfName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.LabelSearch = New System.Windows.Forms.Label()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.ButtonReset = New System.Windows.Forms.Button()
        Me.ButtonUpload = New System.Windows.Forms.Button()
        Me.ButtonDownload = New System.Windows.Forms.Button()
        Me.LabelStudentTotal = New System.Windows.Forms.Label()
        Me.ButtonSearch = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.DataGridViewStudentList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxGender.SuspendLayout()
        CType(Me.PictureBoxStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewStudentList
        '
        Me.DataGridViewStudentList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewStudentList.Location = New System.Drawing.Point(485, 45)
        Me.DataGridViewStudentList.Name = "DataGridViewStudentList"
        Me.DataGridViewStudentList.Size = New System.Drawing.Size(782, 411)
        Me.DataGridViewStudentList.TabIndex = 1
        '
        'GroupBoxGender
        '
        Me.GroupBoxGender.Controls.Add(Me.RadioButtonFemale)
        Me.GroupBoxGender.Controls.Add(Me.RadioButtonMale)
        Me.GroupBoxGender.Location = New System.Drawing.Point(177, 155)
        Me.GroupBoxGender.Name = "GroupBoxGender"
        Me.GroupBoxGender.Size = New System.Drawing.Size(198, 41)
        Me.GroupBoxGender.TabIndex = 39
        Me.GroupBoxGender.TabStop = False
        '
        'RadioButtonFemale
        '
        Me.RadioButtonFemale.AutoSize = True
        Me.RadioButtonFemale.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonFemale.ForeColor = System.Drawing.Color.White
        Me.RadioButtonFemale.Location = New System.Drawing.Point(106, 9)
        Me.RadioButtonFemale.Name = "RadioButtonFemale"
        Me.RadioButtonFemale.Size = New System.Drawing.Size(86, 24)
        Me.RadioButtonFemale.TabIndex = 1
        Me.RadioButtonFemale.TabStop = True
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
        Me.LabelGender.Location = New System.Drawing.Point(102, 168)
        Me.LabelGender.Name = "LabelGender"
        Me.LabelGender.Size = New System.Drawing.Size(69, 20)
        Me.LabelGender.TabIndex = 38
        Me.LabelGender.Text = "Gender"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(105, 129)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 37
        '
        'TextBoxlName
        '
        Me.TextBoxlName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxlName.Location = New System.Drawing.Point(105, 90)
        Me.TextBoxlName.Name = "TextBoxlName"
        Me.TextBoxlName.Size = New System.Drawing.Size(366, 26)
        Me.TextBoxlName.TabIndex = 36
        '
        'TextBoxStudentID
        '
        Me.TextBoxStudentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxStudentID.Location = New System.Drawing.Point(105, 8)
        Me.TextBoxStudentID.Name = "TextBoxStudentID"
        Me.TextBoxStudentID.Size = New System.Drawing.Size(366, 26)
        Me.TextBoxStudentID.TabIndex = 35
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(3, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 20)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Student ID"
        '
        'ButtonRemove
        '
        Me.ButtonRemove.BackColor = System.Drawing.Color.Red
        Me.ButtonRemove.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonRemove.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonRemove.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonRemove.Location = New System.Drawing.Point(740, 498)
        Me.ButtonRemove.Name = "ButtonRemove"
        Me.ButtonRemove.Size = New System.Drawing.Size(122, 40)
        Me.ButtonRemove.TabIndex = 33
        Me.ButtonRemove.Text = "&Remove"
        Me.ButtonRemove.UseVisualStyleBackColor = False
        '
        'ButtonAddStudent
        '
        Me.ButtonAddStudent.BackColor = System.Drawing.Color.Blue
        Me.ButtonAddStudent.FlatAppearance.BorderColor = System.Drawing.Color.Yellow
        Me.ButtonAddStudent.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonAddStudent.Location = New System.Drawing.Point(492, 498)
        Me.ButtonAddStudent.Name = "ButtonAddStudent"
        Me.ButtonAddStudent.Size = New System.Drawing.Size(118, 40)
        Me.ButtonAddStudent.TabIndex = 32
        Me.ButtonAddStudent.Text = "&Add"
        Me.ButtonAddStudent.UseVisualStyleBackColor = False
        '
        'PictureBoxStudent
        '
        Me.PictureBoxStudent.BackColor = System.Drawing.Color.Black
        Me.PictureBoxStudent.Location = New System.Drawing.Point(105, 344)
        Me.PictureBoxStudent.Name = "PictureBoxStudent"
        Me.PictureBoxStudent.Size = New System.Drawing.Size(227, 163)
        Me.PictureBoxStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxStudent.TabIndex = 30
        Me.PictureBoxStudent.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(3, 344)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 20)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Picture"
        '
        'TextBoxeMail
        '
        Me.TextBoxeMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxeMail.Location = New System.Drawing.Point(105, 312)
        Me.TextBoxeMail.Name = "TextBoxeMail"
        Me.TextBoxeMail.Size = New System.Drawing.Size(366, 26)
        Me.TextBoxeMail.TabIndex = 28
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(3, 312)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 20)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "eMail"
        '
        'TextBoxAddress
        '
        Me.TextBoxAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAddress.Location = New System.Drawing.Point(105, 204)
        Me.TextBoxAddress.Multiline = True
        Me.TextBoxAddress.Name = "TextBoxAddress"
        Me.TextBoxAddress.Size = New System.Drawing.Size(366, 102)
        Me.TextBoxAddress.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(3, 204)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 20)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(3, 130)
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
        Me.Label2.Location = New System.Drawing.Point(3, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 20)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Last Name"
        '
        'TextBoxfName
        '
        Me.TextBoxfName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxfName.Location = New System.Drawing.Point(105, 45)
        Me.TextBoxfName.Name = "TextBoxfName"
        Me.TextBoxfName.Size = New System.Drawing.Size(366, 26)
        Me.TextBoxfName.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 20)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "First Name"
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSearch.Location = New System.Drawing.Point(909, 8)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(224, 26)
        Me.TextBoxSearch.TabIndex = 41
        '
        'LabelSearch
        '
        Me.LabelSearch.AutoSize = True
        Me.LabelSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSearch.ForeColor = System.Drawing.Color.White
        Me.LabelSearch.Location = New System.Drawing.Point(773, 14)
        Me.LabelSearch.Name = "LabelSearch"
        Me.LabelSearch.Size = New System.Drawing.Size(110, 20)
        Me.LabelSearch.TabIndex = 40
        Me.LabelSearch.Text = "Search Data"
        '
        'ButtonEdit
        '
        Me.ButtonEdit.BackColor = System.Drawing.Color.Magenta
        Me.ButtonEdit.FlatAppearance.BorderColor = System.Drawing.Color.Yellow
        Me.ButtonEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonEdit.Location = New System.Drawing.Point(616, 498)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(118, 40)
        Me.ButtonEdit.TabIndex = 42
        Me.ButtonEdit.Text = "&Edit"
        Me.ButtonEdit.UseVisualStyleBackColor = False
        '
        'ButtonReset
        '
        Me.ButtonReset.BackColor = System.Drawing.Color.Black
        Me.ButtonReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonReset.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonReset.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonReset.Location = New System.Drawing.Point(868, 497)
        Me.ButtonReset.Name = "ButtonReset"
        Me.ButtonReset.Size = New System.Drawing.Size(122, 40)
        Me.ButtonReset.TabIndex = 43
        Me.ButtonReset.Text = "Reset"
        Me.ButtonReset.UseVisualStyleBackColor = False
        '
        'ButtonUpload
        '
        Me.ButtonUpload.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUpload.Location = New System.Drawing.Point(104, 507)
        Me.ButtonUpload.Name = "ButtonUpload"
        Me.ButtonUpload.Size = New System.Drawing.Size(114, 23)
        Me.ButtonUpload.TabIndex = 44
        Me.ButtonUpload.Text = "&Upload"
        Me.ButtonUpload.UseVisualStyleBackColor = True
        '
        'ButtonDownload
        '
        Me.ButtonDownload.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDownload.Location = New System.Drawing.Point(224, 507)
        Me.ButtonDownload.Name = "ButtonDownload"
        Me.ButtonDownload.Size = New System.Drawing.Size(108, 23)
        Me.ButtonDownload.TabIndex = 45
        Me.ButtonDownload.Text = "&Download"
        Me.ButtonDownload.UseVisualStyleBackColor = True
        '
        'LabelStudentTotal
        '
        Me.LabelStudentTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelStudentTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelStudentTotal.ForeColor = System.Drawing.Color.White
        Me.LabelStudentTotal.Location = New System.Drawing.Point(1045, 453)
        Me.LabelStudentTotal.Name = "LabelStudentTotal"
        Me.LabelStudentTotal.Size = New System.Drawing.Size(222, 41)
        Me.LabelStudentTotal.TabIndex = 46
        Me.LabelStudentTotal.Text = "Total Students:"
        Me.LabelStudentTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonSearch
        '
        Me.ButtonSearch.BackColor = System.Drawing.Color.Yellow
        Me.ButtonSearch.FlatAppearance.BorderColor = System.Drawing.Color.Yellow
        Me.ButtonSearch.ForeColor = System.Drawing.Color.Black
        Me.ButtonSearch.Location = New System.Drawing.Point(1149, 2)
        Me.ButtonSearch.Name = "ButtonSearch"
        Me.ButtonSearch.Size = New System.Drawing.Size(118, 40)
        Me.ButtonSearch.TabIndex = 47
        Me.ButtonSearch.Text = "&Search"
        Me.ButtonSearch.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(479, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(286, 25)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "STUDENT MANAGEMENT"
        '
        'ManageStudentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1279, 541)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ButtonSearch)
        Me.Controls.Add(Me.LabelStudentTotal)
        Me.Controls.Add(Me.ButtonDownload)
        Me.Controls.Add(Me.ButtonUpload)
        Me.Controls.Add(Me.ButtonReset)
        Me.Controls.Add(Me.ButtonEdit)
        Me.Controls.Add(Me.TextBoxSearch)
        Me.Controls.Add(Me.LabelSearch)
        Me.Controls.Add(Me.GroupBoxGender)
        Me.Controls.Add(Me.LabelGender)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TextBoxlName)
        Me.Controls.Add(Me.TextBoxStudentID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ButtonRemove)
        Me.Controls.Add(Me.ButtonAddStudent)
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
        Me.Controls.Add(Me.DataGridViewStudentList)
        Me.Name = "ManageStudentForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ManageStudentForm"
        CType(Me.DataGridViewStudentList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxGender.ResumeLayout(False)
        Me.GroupBoxGender.PerformLayout()
        CType(Me.PictureBoxStudent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewStudentList As DataGridView
    Friend WithEvents GroupBoxGender As GroupBox
    Friend WithEvents RadioButtonFemale As RadioButton
    Friend WithEvents RadioButtonMale As RadioButton
    Friend WithEvents LabelGender As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBoxlName As TextBox
    Friend WithEvents TextBoxStudentID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ButtonRemove As Button
    Friend WithEvents ButtonAddStudent As Button
    Friend WithEvents PictureBoxStudent As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxeMail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxAddress As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxfName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents LabelSearch As Label
    Friend WithEvents ButtonEdit As Button
    Friend WithEvents ButtonReset As Button
    Friend WithEvents ButtonUpload As Button
    Friend WithEvents ButtonDownload As Button
    Friend WithEvents LabelStudentTotal As Label
    Friend WithEvents ButtonSearch As Button
    Friend WithEvents Label8 As Label
End Class
