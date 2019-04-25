<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentGradesForm
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
        Me.DataGridViewStudentGrades = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridViewStudentGrades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewStudentGrades
        '
        Me.DataGridViewStudentGrades.AllowUserToAddRows = False
        Me.DataGridViewStudentGrades.AllowUserToDeleteRows = False
        Me.DataGridViewStudentGrades.AllowUserToResizeColumns = False
        Me.DataGridViewStudentGrades.AllowUserToResizeRows = False
        Me.DataGridViewStudentGrades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewStudentGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewStudentGrades.Location = New System.Drawing.Point(136, 39)
        Me.DataGridViewStudentGrades.Name = "DataGridViewStudentGrades"
        Me.DataGridViewStudentGrades.Size = New System.Drawing.Size(529, 373)
        Me.DataGridViewStudentGrades.TabIndex = 67
        '
        'StudentGradesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridViewStudentGrades)
        Me.Name = "StudentGradesForm"
        Me.Text = "StudentGradesForm"
        CType(Me.DataGridViewStudentGrades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridViewStudentGrades As DataGridView
End Class
