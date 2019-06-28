<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.lbl0 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl0
        '
        Me.lbl0.AutoSize = True
        Me.lbl0.BackColor = System.Drawing.Color.Transparent
        Me.lbl0.Font = New System.Drawing.Font("Unispace", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl0.ForeColor = System.Drawing.Color.White
        Me.lbl0.Location = New System.Drawing.Point(16, 8)
        Me.lbl0.Name = "lbl0"
        Me.lbl0.Size = New System.Drawing.Size(165, 42)
        Me.lbl0.TabIndex = 1
        Me.lbl0.Text = "Sources"
        '
        'lbl1
        '
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl1.Location = New System.Drawing.Point(24, 64)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(152, 48)
        Me.lbl1.TabIndex = 12
        Me.lbl1.Text = "Data Source:"
        Me.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(472, 16)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Data Source: https://en.wikipedia.org/wiki/List_of_highest_mountains_on_Earth"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(448, 232)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Images: & VBnewline & hey"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(529, 541)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.lbl0)
        Me.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Name = "Form2"
        Me.Text = "Top 5 Mountains: Sources (By Sanchit)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl0 As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
