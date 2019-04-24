<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RemoveGrade
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
        Me.DataGridViewStudentScore = New System.Windows.Forms.DataGridView()
        Me.ButtonRemoveGrade = New System.Windows.Forms.Button()
        CType(Me.DataGridViewStudentScore, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewStudentScore
        '
        Me.DataGridViewStudentScore.AllowUserToAddRows = False
        Me.DataGridViewStudentScore.AllowUserToDeleteRows = False
        Me.DataGridViewStudentScore.AllowUserToResizeColumns = False
        Me.DataGridViewStudentScore.AllowUserToResizeRows = False
        Me.DataGridViewStudentScore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewStudentScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewStudentScore.Location = New System.Drawing.Point(24, 12)
        Me.DataGridViewStudentScore.Name = "DataGridViewStudentScore"
        Me.DataGridViewStudentScore.Size = New System.Drawing.Size(995, 373)
        Me.DataGridViewStudentScore.TabIndex = 52
        '
        'ButtonRemoveGrade
        '
        Me.ButtonRemoveGrade.BackColor = System.Drawing.Color.Red
        Me.ButtonRemoveGrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRemoveGrade.Location = New System.Drawing.Point(24, 404)
        Me.ButtonRemoveGrade.Name = "ButtonRemoveGrade"
        Me.ButtonRemoveGrade.Size = New System.Drawing.Size(995, 34)
        Me.ButtonRemoveGrade.TabIndex = 53
        Me.ButtonRemoveGrade.Text = "&Remove Grade"
        Me.ButtonRemoveGrade.UseVisualStyleBackColor = False
        '
        'RemoveGrade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1049, 450)
        Me.Controls.Add(Me.ButtonRemoveGrade)
        Me.Controls.Add(Me.DataGridViewStudentScore)
        Me.Name = "RemoveGrade"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RemoveGrade"
        CType(Me.DataGridViewStudentScore, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridViewStudentScore As DataGridView
    Friend WithEvents ButtonRemoveGrade As Button
End Class
