<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaticsForm
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
        Me.PanelTotal = New System.Windows.Forms.Panel()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.PanelMale = New System.Windows.Forms.Panel()
        Me.LabelMale = New System.Windows.Forms.Label()
        Me.PanelFemale = New System.Windows.Forms.Panel()
        Me.LabelFemale = New System.Windows.Forms.Label()
        Me.PanelTotal.SuspendLayout()
        Me.PanelMale.SuspendLayout()
        Me.PanelFemale.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelTotal
        '
        Me.PanelTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.PanelTotal.Controls.Add(Me.LabelTotal)
        Me.PanelTotal.Location = New System.Drawing.Point(-2, 0)
        Me.PanelTotal.Name = "PanelTotal"
        Me.PanelTotal.Size = New System.Drawing.Size(804, 159)
        Me.PanelTotal.TabIndex = 0
        '
        'LabelTotal
        '
        Me.LabelTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotal.ForeColor = System.Drawing.Color.White
        Me.LabelTotal.Location = New System.Drawing.Point(3, 9)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(798, 144)
        Me.LabelTotal.TabIndex = 0
        Me.LabelTotal.Text = "Total Students: 100"
        Me.LabelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelMale
        '
        Me.PanelMale.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.PanelMale.Controls.Add(Me.LabelMale)
        Me.PanelMale.Location = New System.Drawing.Point(-2, 156)
        Me.PanelMale.Name = "PanelMale"
        Me.PanelMale.Size = New System.Drawing.Size(402, 150)
        Me.PanelMale.TabIndex = 0
        '
        'LabelMale
        '
        Me.LabelMale.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMale.ForeColor = System.Drawing.Color.White
        Me.LabelMale.Location = New System.Drawing.Point(3, 6)
        Me.LabelMale.Name = "LabelMale"
        Me.LabelMale.Size = New System.Drawing.Size(399, 134)
        Me.LabelMale.TabIndex = 1
        Me.LabelMale.Text = "Male: 50%"
        Me.LabelMale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelFemale
        '
        Me.PanelFemale.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.PanelFemale.Controls.Add(Me.LabelFemale)
        Me.PanelFemale.Location = New System.Drawing.Point(400, 156)
        Me.PanelFemale.Name = "PanelFemale"
        Me.PanelFemale.Size = New System.Drawing.Size(402, 150)
        Me.PanelFemale.TabIndex = 1
        '
        'LabelFemale
        '
        Me.LabelFemale.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFemale.ForeColor = System.Drawing.Color.White
        Me.LabelFemale.Location = New System.Drawing.Point(0, 0)
        Me.LabelFemale.Name = "LabelFemale"
        Me.LabelFemale.Size = New System.Drawing.Size(399, 134)
        Me.LabelFemale.TabIndex = 2
        Me.LabelFemale.Text = "Female: 50%"
        Me.LabelFemale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StaticsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 305)
        Me.Controls.Add(Me.PanelFemale)
        Me.Controls.Add(Me.PanelMale)
        Me.Controls.Add(Me.PanelTotal)
        Me.Name = "StaticsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StaticsForm"
        Me.PanelTotal.ResumeLayout(False)
        Me.PanelMale.ResumeLayout(False)
        Me.PanelFemale.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelTotal As Panel
    Friend WithEvents PanelMale As Panel
    Friend WithEvents PanelFemale As Panel
    Friend WithEvents LabelTotal As Label
    Friend WithEvents LabelMale As Label
    Friend WithEvents LabelFemale As Label
End Class
