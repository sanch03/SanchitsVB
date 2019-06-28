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
        Me.txturl = New System.Windows.Forms.TextBox()
        Me.btngo = New System.Windows.Forms.Button()
        Me.btnback = New System.Windows.Forms.Button()
        Me.btnforward = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'txturl
        '
        Me.txturl.AcceptsReturn = True
        Me.txturl.Location = New System.Drawing.Point(112, 12)
        Me.txturl.Name = "txturl"
        Me.txturl.Size = New System.Drawing.Size(1037, 20)
        Me.txturl.TabIndex = 0
        '
        'btngo
        '
        Me.btngo.Location = New System.Drawing.Point(1161, 11)
        Me.btngo.Name = "btngo"
        Me.btngo.Size = New System.Drawing.Size(42, 23)
        Me.btngo.TabIndex = 1
        Me.btngo.Text = "GO"
        Me.btngo.UseVisualStyleBackColor = True
        '
        'btnback
        '
        Me.btnback.Location = New System.Drawing.Point(12, 10)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(27, 23)
        Me.btnback.TabIndex = 2
        Me.btnback.Text = "🡄"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'btnforward
        '
        Me.btnforward.Location = New System.Drawing.Point(45, 9)
        Me.btnforward.Name = "btnforward"
        Me.btnforward.Size = New System.Drawing.Size(27, 23)
        Me.btnforward.TabIndex = 3
        Me.btnforward.Text = "🡆"
        Me.btnforward.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(78, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(27, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "↻"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(12, 39)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(1191, 713)
        Me.WebBrowser1.TabIndex = 5
        Me.WebBrowser1.Url = New System.Uri("https://www.google.com.au", System.UriKind.Absolute)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1215, 764)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnforward)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.btngo)
        Me.Controls.Add(Me.txturl)
        Me.Name = "Form1"
        Me.Text = "Web Browser (Made by Sanchit)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txturl As TextBox
    Friend WithEvents btngo As Button
    Friend WithEvents btnback As Button
    Friend WithEvents btnforward As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents WebBrowser1 As WebBrowser
End Class
