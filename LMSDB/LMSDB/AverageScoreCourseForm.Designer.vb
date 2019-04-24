<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AverageScoreCourseForm
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
        Me.DataGridViewAVGCourse = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridViewAVGCourse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewAVGCourse
        '
        Me.DataGridViewAVGCourse.AllowUserToAddRows = False
        Me.DataGridViewAVGCourse.AllowUserToDeleteRows = False
        Me.DataGridViewAVGCourse.AllowUserToResizeColumns = False
        Me.DataGridViewAVGCourse.AllowUserToResizeRows = False
        Me.DataGridViewAVGCourse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewAVGCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewAVGCourse.Location = New System.Drawing.Point(136, 39)
        Me.DataGridViewAVGCourse.Name = "DataGridViewAVGCourse"
        Me.DataGridViewAVGCourse.Size = New System.Drawing.Size(529, 373)
        Me.DataGridViewAVGCourse.TabIndex = 66
        '
        'AverageScoreCourseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridViewAVGCourse)
        Me.Name = "AverageScoreCourseForm"
        Me.Text = "AverageScoreCourseForm"
        CType(Me.DataGridViewAVGCourse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridViewAVGCourse As DataGridView
End Class
