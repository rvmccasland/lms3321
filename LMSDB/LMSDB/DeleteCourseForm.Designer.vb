<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteCourseForm
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
        Me.TextBoxCourseID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ButtonDeleteCourse = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBoxCourseID
        '
        Me.TextBoxCourseID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCourseID.Location = New System.Drawing.Point(157, 50)
        Me.TextBoxCourseID.Name = "TextBoxCourseID"
        Me.TextBoxCourseID.Size = New System.Drawing.Size(236, 26)
        Me.TextBoxCourseID.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(12, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(139, 20)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Enter Course ID"
        '
        'ButtonDeleteCourse
        '
        Me.ButtonDeleteCourse.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonDeleteCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDeleteCourse.Location = New System.Drawing.Point(413, 47)
        Me.ButtonDeleteCourse.Name = "ButtonDeleteCourse"
        Me.ButtonDeleteCourse.Size = New System.Drawing.Size(106, 34)
        Me.ButtonDeleteCourse.TabIndex = 27
        Me.ButtonDeleteCourse.Text = "&Delete"
        Me.ButtonDeleteCourse.UseVisualStyleBackColor = False
        '
        'DeleteCourseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(570, 145)
        Me.Controls.Add(Me.ButtonDeleteCourse)
        Me.Controls.Add(Me.TextBoxCourseID)
        Me.Controls.Add(Me.Label7)
        Me.Name = "DeleteCourseForm"
        Me.Text = "RemoveCourseForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxCourseID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ButtonDeleteCourse As Button
End Class
