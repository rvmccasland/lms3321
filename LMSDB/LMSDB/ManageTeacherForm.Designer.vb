<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageTeacherForm
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
        Me.TextBoxlName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxfName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxTeacherID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridViewTeacherList = New System.Windows.Forms.DataGridView()
        Me.ButtonReset = New System.Windows.Forms.Button()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.ButtonRemove = New System.Windows.Forms.Button()
        Me.ButtonAddTeacher = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ButtonSearch = New System.Windows.Forms.Button()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.LabelSearch = New System.Windows.Forms.Label()
        CType(Me.DataGridViewTeacherList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxlName
        '
        Me.TextBoxlName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxlName.Location = New System.Drawing.Point(114, 181)
        Me.TextBoxlName.Name = "TextBoxlName"
        Me.TextBoxlName.Size = New System.Drawing.Size(366, 26)
        Me.TextBoxlName.TabIndex = 40
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 20)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Last Name"
        '
        'TextBoxfName
        '
        Me.TextBoxfName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxfName.Location = New System.Drawing.Point(114, 136)
        Me.TextBoxfName.Name = "TextBoxfName"
        Me.TextBoxfName.Size = New System.Drawing.Size(366, 26)
        Me.TextBoxfName.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 20)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "First Name"
        '
        'TextBoxTeacherID
        '
        Me.TextBoxTeacherID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTeacherID.Location = New System.Drawing.Point(114, 94)
        Me.TextBoxTeacherID.Name = "TextBoxTeacherID"
        Me.TextBoxTeacherID.Size = New System.Drawing.Size(366, 26)
        Me.TextBoxTeacherID.TabIndex = 42
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 20)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Teacher ID"
        '
        'DataGridViewTeacherList
        '
        Me.DataGridViewTeacherList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewTeacherList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewTeacherList.Location = New System.Drawing.Point(486, 93)
        Me.DataGridViewTeacherList.Name = "DataGridViewTeacherList"
        Me.DataGridViewTeacherList.Size = New System.Drawing.Size(358, 258)
        Me.DataGridViewTeacherList.TabIndex = 43
        '
        'ButtonReset
        '
        Me.ButtonReset.BackColor = System.Drawing.Color.Black
        Me.ButtonReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonReset.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonReset.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonReset.Location = New System.Drawing.Point(722, 379)
        Me.ButtonReset.Name = "ButtonReset"
        Me.ButtonReset.Size = New System.Drawing.Size(122, 40)
        Me.ButtonReset.TabIndex = 47
        Me.ButtonReset.Text = "Reset"
        Me.ButtonReset.UseVisualStyleBackColor = False
        '
        'ButtonEdit
        '
        Me.ButtonEdit.BackColor = System.Drawing.Color.Magenta
        Me.ButtonEdit.FlatAppearance.BorderColor = System.Drawing.Color.Yellow
        Me.ButtonEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonEdit.Location = New System.Drawing.Point(470, 380)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(118, 40)
        Me.ButtonEdit.TabIndex = 46
        Me.ButtonEdit.Text = "&Edit"
        Me.ButtonEdit.UseVisualStyleBackColor = False
        '
        'ButtonRemove
        '
        Me.ButtonRemove.BackColor = System.Drawing.Color.Red
        Me.ButtonRemove.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonRemove.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonRemove.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonRemove.Location = New System.Drawing.Point(594, 380)
        Me.ButtonRemove.Name = "ButtonRemove"
        Me.ButtonRemove.Size = New System.Drawing.Size(122, 40)
        Me.ButtonRemove.TabIndex = 45
        Me.ButtonRemove.Text = "&Remove"
        Me.ButtonRemove.UseVisualStyleBackColor = False
        '
        'ButtonAddTeacher
        '
        Me.ButtonAddTeacher.BackColor = System.Drawing.Color.Blue
        Me.ButtonAddTeacher.FlatAppearance.BorderColor = System.Drawing.Color.Yellow
        Me.ButtonAddTeacher.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonAddTeacher.Location = New System.Drawing.Point(346, 380)
        Me.ButtonAddTeacher.Name = "ButtonAddTeacher"
        Me.ButtonAddTeacher.Size = New System.Drawing.Size(118, 40)
        Me.ButtonAddTeacher.TabIndex = 44
        Me.ButtonAddTeacher.Text = "&Add"
        Me.ButtonAddTeacher.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(287, 25)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "TEACHER MANAGEMENT"
        '
        'ButtonSearch
        '
        Me.ButtonSearch.BackColor = System.Drawing.Color.Yellow
        Me.ButtonSearch.FlatAppearance.BorderColor = System.Drawing.Color.Yellow
        Me.ButtonSearch.ForeColor = System.Drawing.Color.Black
        Me.ButtonSearch.Location = New System.Drawing.Point(710, 27)
        Me.ButtonSearch.Name = "ButtonSearch"
        Me.ButtonSearch.Size = New System.Drawing.Size(118, 40)
        Me.ButtonSearch.TabIndex = 53
        Me.ButtonSearch.Text = "&Search"
        Me.ButtonSearch.UseVisualStyleBackColor = False
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSearch.Location = New System.Drawing.Point(470, 33)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(224, 26)
        Me.TextBoxSearch.TabIndex = 52
        '
        'LabelSearch
        '
        Me.LabelSearch.AutoSize = True
        Me.LabelSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSearch.ForeColor = System.Drawing.Color.White
        Me.LabelSearch.Location = New System.Drawing.Point(334, 39)
        Me.LabelSearch.Name = "LabelSearch"
        Me.LabelSearch.Size = New System.Drawing.Size(110, 20)
        Me.LabelSearch.TabIndex = 51
        Me.LabelSearch.Text = "Search Data"
        '
        'ManageTeacherForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(856, 450)
        Me.Controls.Add(Me.ButtonSearch)
        Me.Controls.Add(Me.TextBoxSearch)
        Me.Controls.Add(Me.LabelSearch)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ButtonReset)
        Me.Controls.Add(Me.ButtonEdit)
        Me.Controls.Add(Me.ButtonRemove)
        Me.Controls.Add(Me.ButtonAddTeacher)
        Me.Controls.Add(Me.DataGridViewTeacherList)
        Me.Controls.Add(Me.TextBoxTeacherID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxlName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxfName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ManageTeacherForm"
        Me.Text = "ManageTeacherForm"
        CType(Me.DataGridViewTeacherList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxlName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxfName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxTeacherID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridViewTeacherList As DataGridView
    Friend WithEvents ButtonReset As Button
    Friend WithEvents ButtonEdit As Button
    Friend WithEvents ButtonRemove As Button
    Friend WithEvents ButtonAddTeacher As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents ButtonSearch As Button
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents LabelSearch As Label
End Class
