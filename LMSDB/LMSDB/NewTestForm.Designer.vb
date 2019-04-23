<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewTestForm
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
        Me.TextBoxStudentId = New System.Windows.Forms.TextBox()
        Me.TextBoxCreditHours = New System.Windows.Forms.TextBox()
        Me.TextBoxExamAVG = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelGPA = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxStudentId
        '
        Me.TextBoxStudentId.Location = New System.Drawing.Point(119, 66)
        Me.TextBoxStudentId.Name = "TextBoxStudentId"
        Me.TextBoxStudentId.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxStudentId.TabIndex = 0
        '
        'TextBoxCreditHours
        '
        Me.TextBoxCreditHours.Location = New System.Drawing.Point(410, 66)
        Me.TextBoxCreditHours.Name = "TextBoxCreditHours"
        Me.TextBoxCreditHours.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxCreditHours.TabIndex = 1
        '
        'TextBoxExamAVG
        '
        Me.TextBoxExamAVG.Location = New System.Drawing.Point(265, 66)
        Me.TextBoxExamAVG.Name = "TextBoxExamAVG"
        Me.TextBoxExamAVG.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxExamAVG.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(119, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Stduent ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(262, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Exam Average"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(407, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Credit Hours"
        '
        'LabelGPA
        '
        Me.LabelGPA.AutoSize = True
        Me.LabelGPA.Location = New System.Drawing.Point(437, 285)
        Me.LabelGPA.Name = "LabelGPA"
        Me.LabelGPA.Size = New System.Drawing.Size(35, 13)
        Me.LabelGPA.TabIndex = 6
        Me.LabelGPA.Text = "GPA :"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(122, 132)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(388, 150)
        Me.DataGridView1.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(608, 62)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'NewTestForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.LabelGPA)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxExamAVG)
        Me.Controls.Add(Me.TextBoxCreditHours)
        Me.Controls.Add(Me.TextBoxStudentId)
        Me.Name = "NewTestForm"
        Me.Text = "NewTestForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxStudentId As TextBox
    Friend WithEvents TextBoxCreditHours As TextBox
    Friend WithEvents TextBoxExamAVG As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LabelGPA As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
End Class
