﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BMICalc
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btncalc = New System.Windows.Forms.Button()
        Me.txthei = New System.Windows.Forms.TextBox()
        Me.txtwei = New System.Windows.Forms.TextBox()
        Me.txtbmi = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(74, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Height (m)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(74, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Weight (kg)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(74, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "BMI"
        '
        'btncalc
        '
        Me.btncalc.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btncalc.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncalc.Location = New System.Drawing.Point(78, 309)
        Me.btncalc.Name = "btncalc"
        Me.btncalc.Size = New System.Drawing.Size(230, 48)
        Me.btncalc.TabIndex = 3
        Me.btncalc.Text = "Calculate BMI"
        Me.btncalc.UseVisualStyleBackColor = False
        '
        'txthei
        '
        Me.txthei.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthei.Location = New System.Drawing.Point(208, 79)
        Me.txthei.Name = "txthei"
        Me.txthei.Size = New System.Drawing.Size(100, 26)
        Me.txthei.TabIndex = 4
        '
        'txtwei
        '
        Me.txtwei.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtwei.Location = New System.Drawing.Point(208, 138)
        Me.txtwei.Name = "txtwei"
        Me.txtwei.Size = New System.Drawing.Size(100, 26)
        Me.txtwei.TabIndex = 5
        '
        'txtbmi
        '
        Me.txtbmi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbmi.Location = New System.Drawing.Point(208, 203)
        Me.txtbmi.Name = "txtbmi"
        Me.txtbmi.ReadOnly = True
        Me.txtbmi.Size = New System.Drawing.Size(100, 26)
        Me.txtbmi.TabIndex = 6
        '
        'BMICalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 450)
        Me.Controls.Add(Me.txtbmi)
        Me.Controls.Add(Me.txtwei)
        Me.Controls.Add(Me.txthei)
        Me.Controls.Add(Me.btncalc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "BMICalc"
        Me.Text = "BMI Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btncalc As Button
    Friend WithEvents txthei As TextBox
    Friend WithEvents txtwei As TextBox
    Friend WithEvents txtbmi As TextBox
End Class
