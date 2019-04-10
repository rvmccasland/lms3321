<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentForm
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
        Me.Button_Save = New System.Windows.Forms.Button()
        Me.Button_Update = New System.Windows.Forms.Button()
        Me.Button_Delete = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox_Student_id = New System.Windows.Forms.TextBox()
        Me.TextBox_fName = New System.Windows.Forms.TextBox()
        Me.TextBox_lName = New System.Windows.Forms.TextBox()
        Me.TextBox_Date_of_Birth = New System.Windows.Forms.TextBox()
        Me.Button_Close = New System.Windows.Forms.Button()
        Me.Button_Refresh = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button_Save
        '
        Me.Button_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Save.Location = New System.Drawing.Point(64, 259)
        Me.Button_Save.Name = "Button_Save"
        Me.Button_Save.Size = New System.Drawing.Size(124, 41)
        Me.Button_Save.TabIndex = 0
        Me.Button_Save.Text = "Save"
        Me.Button_Save.UseVisualStyleBackColor = True
        '
        'Button_Update
        '
        Me.Button_Update.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Update.Location = New System.Drawing.Point(225, 259)
        Me.Button_Update.Name = "Button_Update"
        Me.Button_Update.Size = New System.Drawing.Size(124, 41)
        Me.Button_Update.TabIndex = 6
        Me.Button_Update.Text = "Update"
        Me.Button_Update.UseVisualStyleBackColor = True
        '
        'Button_Delete
        '
        Me.Button_Delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Delete.Location = New System.Drawing.Point(384, 259)
        Me.Button_Delete.Name = "Button_Delete"
        Me.Button_Delete.Size = New System.Drawing.Size(124, 41)
        Me.Button_Delete.TabIndex = 7
        Me.Button_Delete.Text = "Delete"
        Me.Button_Delete.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(64, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Student ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(64, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(64, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Last Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(64, 210)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Date of Birth"
        '
        'TextBox_Student_id
        '
        Me.TextBox_Student_id.Location = New System.Drawing.Point(225, 66)
        Me.TextBox_Student_id.Name = "TextBox_Student_id"
        Me.TextBox_Student_id.Size = New System.Drawing.Size(447, 20)
        Me.TextBox_Student_id.TabIndex = 13
        '
        'TextBox_fName
        '
        Me.TextBox_fName.Location = New System.Drawing.Point(225, 115)
        Me.TextBox_fName.Name = "TextBox_fName"
        Me.TextBox_fName.Size = New System.Drawing.Size(447, 20)
        Me.TextBox_fName.TabIndex = 14
        '
        'TextBox_lName
        '
        Me.TextBox_lName.Location = New System.Drawing.Point(225, 168)
        Me.TextBox_lName.Name = "TextBox_lName"
        Me.TextBox_lName.Size = New System.Drawing.Size(447, 20)
        Me.TextBox_lName.TabIndex = 15
        '
        'TextBox_Date_of_Birth
        '
        Me.TextBox_Date_of_Birth.Location = New System.Drawing.Point(225, 212)
        Me.TextBox_Date_of_Birth.Name = "TextBox_Date_of_Birth"
        Me.TextBox_Date_of_Birth.Size = New System.Drawing.Size(447, 20)
        Me.TextBox_Date_of_Birth.TabIndex = 16
        '
        'Button_Close
        '
        Me.Button_Close.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Close.Location = New System.Drawing.Point(548, 259)
        Me.Button_Close.Name = "Button_Close"
        Me.Button_Close.Size = New System.Drawing.Size(124, 41)
        Me.Button_Close.TabIndex = 17
        Me.Button_Close.Text = "Close"
        Me.Button_Close.UseVisualStyleBackColor = True
        '
        'Button_Refresh
        '
        Me.Button_Refresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Refresh.Location = New System.Drawing.Point(804, 259)
        Me.Button_Refresh.Name = "Button_Refresh"
        Me.Button_Refresh.Size = New System.Drawing.Size(124, 41)
        Me.Button_Refresh.TabIndex = 18
        Me.Button_Refresh.Text = "Refresh"
        Me.Button_Refresh.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(690, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(304, 30)
        Me.ListBox1.TabIndex = 19
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(690, 66)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(304, 166)
        Me.DataGridView1.TabIndex = 20
        '
        'StudentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 661)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button_Refresh)
        Me.Controls.Add(Me.Button_Close)
        Me.Controls.Add(Me.TextBox_Date_of_Birth)
        Me.Controls.Add(Me.TextBox_lName)
        Me.Controls.Add(Me.TextBox_fName)
        Me.Controls.Add(Me.TextBox_Student_id)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button_Delete)
        Me.Controls.Add(Me.Button_Update)
        Me.Controls.Add(Me.Button_Save)
        Me.Name = "StudentForm"
        Me.Text = "StudentForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_Save As Button
    Friend WithEvents Button_Update As Button
    Friend WithEvents Button_Delete As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox_Student_id As TextBox
    Friend WithEvents TextBox_fName As TextBox
    Friend WithEvents TextBox_lName As TextBox
    Friend WithEvents TextBox_Date_of_Birth As TextBox
    Friend WithEvents Button_Close As Button
    Friend WithEvents Button_Refresh As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
