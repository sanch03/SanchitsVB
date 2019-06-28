<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txttxt = New System.Windows.Forms.TextBox()
        Me.txtpos = New System.Windows.Forms.TextBox()
        Me.txtnum = New System.Windows.Forms.TextBox()
        Me.txtfinal = New System.Windows.Forms.TextBox()
        Me.btnsub = New System.Windows.Forms.Button()
        Me.btnenter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Phrase Entered:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(225, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Position to start extracting:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(268, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Number of characters to extract:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 239)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Extracted Phrase:"
        '
        'txttxt
        '
        Me.txttxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttxt.Location = New System.Drawing.Point(301, 62)
        Me.txttxt.Name = "txttxt"
        Me.txttxt.ReadOnly = True
        Me.txttxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txttxt.Size = New System.Drawing.Size(261, 26)
        Me.txttxt.TabIndex = 4
        '
        'txtpos
        '
        Me.txtpos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpos.Location = New System.Drawing.Point(301, 116)
        Me.txtpos.Name = "txtpos"
        Me.txtpos.Size = New System.Drawing.Size(81, 26)
        Me.txtpos.TabIndex = 5
        '
        'txtnum
        '
        Me.txtnum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnum.Location = New System.Drawing.Point(301, 173)
        Me.txtnum.Name = "txtnum"
        Me.txtnum.Size = New System.Drawing.Size(81, 26)
        Me.txtnum.TabIndex = 6
        '
        'txtfinal
        '
        Me.txtfinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfinal.HideSelection = False
        Me.txtfinal.Location = New System.Drawing.Point(301, 239)
        Me.txtfinal.Name = "txtfinal"
        Me.txtfinal.ReadOnly = True
        Me.txtfinal.Size = New System.Drawing.Size(261, 26)
        Me.txtfinal.TabIndex = 7
        '
        'btnsub
        '
        Me.btnsub.Location = New System.Drawing.Point(301, 340)
        Me.btnsub.Name = "btnsub"
        Me.btnsub.Size = New System.Drawing.Size(119, 23)
        Me.btnsub.TabIndex = 8
        Me.btnsub.Text = "Extract Phrase"
        Me.btnsub.UseVisualStyleBackColor = True
        '
        'btnenter
        '
        Me.btnenter.Location = New System.Drawing.Point(161, 340)
        Me.btnenter.Name = "btnenter"
        Me.btnenter.Size = New System.Drawing.Size(119, 23)
        Me.btnenter.TabIndex = 9
        Me.btnenter.Text = "Enter Phrase"
        Me.btnenter.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 450)
        Me.Controls.Add(Me.btnenter)
        Me.Controls.Add(Me.btnsub)
        Me.Controls.Add(Me.txtfinal)
        Me.Controls.Add(Me.txtnum)
        Me.Controls.Add(Me.txtpos)
        Me.Controls.Add(Me.txttxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "String"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txttxt As TextBox
    Friend WithEvents txtpos As TextBox
    Friend WithEvents txtnum As TextBox
    Friend WithEvents txtfinal As TextBox
    Friend WithEvents btnsub As Button
    Friend WithEvents btnenter As Button
End Class
