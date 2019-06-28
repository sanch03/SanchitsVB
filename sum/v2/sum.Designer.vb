<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sum
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
        Me.textnum1 = New System.Windows.Forms.TextBox()
        Me.textnum2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblAns = New System.Windows.Forms.Label()
        Me.BtnCal = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'textnum1
        '
        Me.textnum1.Location = New System.Drawing.Point(91, 191)
        Me.textnum1.Name = "textnum1"
        Me.textnum1.Size = New System.Drawing.Size(126, 20)
        Me.textnum1.TabIndex = 0
        '
        'textnum2
        '
        Me.textnum2.Location = New System.Drawing.Point(332, 191)
        Me.textnum2.Name = "textnum2"
        Me.textnum2.Size = New System.Drawing.Size(126, 20)
        Me.textnum2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(263, 186)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "+"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(486, 188)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "="
        '
        'LblAns
        '
        Me.LblAns.BackColor = System.Drawing.SystemColors.Info
        Me.LblAns.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblAns.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAns.Location = New System.Drawing.Point(547, 191)
        Me.LblAns.Name = "LblAns"
        Me.LblAns.Size = New System.Drawing.Size(117, 21)
        Me.LblAns.TabIndex = 5
        '
        'BtnCal
        '
        Me.BtnCal.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnCal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCal.Location = New System.Drawing.Point(339, 281)
        Me.BtnCal.Name = "BtnCal"
        Me.BtnCal.Size = New System.Drawing.Size(115, 47)
        Me.BtnCal.TabIndex = 6
        Me.BtnCal.Text = "Calculate"
        Me.BtnCal.UseVisualStyleBackColor = False
        '
        'sum
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnCal)
        Me.Controls.Add(Me.LblAns)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.textnum2)
        Me.Controls.Add(Me.textnum1)
        Me.Name = "sum"
        Me.Text = "Sum"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents textnum1 As TextBox
    Friend WithEvents textnum2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LblAns As Label
    Friend WithEvents BtnCal As Button
End Class
