<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits MaterialSkin.Controls.MaterialForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtp1 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtp2 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.btnpfp1 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnpfp2 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.theme1 = New MaterialSkin.Controls.MaterialRadioButton()
        Me.themedark = New MaterialSkin.Controls.MaterialRadioButton()
        Me.OFG = New System.Windows.Forms.OpenFileDialog()
        Me.MaterialRaisedButton1 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.lblturn = New MaterialSkin.Controls.MaterialLabel()
        Me.pic5 = New System.Windows.Forms.PictureBox()
        Me.pic4 = New System.Windows.Forms.PictureBox()
        Me.pic7 = New System.Windows.Forms.PictureBox()
        Me.pic8 = New System.Windows.Forms.PictureBox()
        Me.pic9 = New System.Windows.Forms.PictureBox()
        Me.pic6 = New System.Windows.Forms.PictureBox()
        Me.pic3 = New System.Windows.Forms.PictureBox()
        Me.pic2 = New System.Windows.Forms.PictureBox()
        Me.pic1 = New System.Windows.Forms.PictureBox()
        Me.pbp2 = New System.Windows.Forms.PictureBox()
        Me.pbp1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnreset = New MaterialSkin.Controls.MaterialRaisedButton()
        CType(Me.pic5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbp2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbp1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtp1
        '
        Me.txtp1.Depth = 0
        Me.txtp1.Hint = ""
        Me.txtp1.Location = New System.Drawing.Point(392, 88)
        Me.txtp1.MaxLength = 32767
        Me.txtp1.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtp1.Name = "txtp1"
        Me.txtp1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtp1.SelectedText = ""
        Me.txtp1.SelectionLength = 0
        Me.txtp1.SelectionStart = 0
        Me.txtp1.Size = New System.Drawing.Size(224, 23)
        Me.txtp1.TabIndex = 1
        Me.txtp1.TabStop = False
        Me.txtp1.Text = "Player 1 Name"
        Me.txtp1.UseSystemPasswordChar = False
        '
        'txtp2
        '
        Me.txtp2.Depth = 0
        Me.txtp2.Hint = ""
        Me.txtp2.Location = New System.Drawing.Point(392, 256)
        Me.txtp2.MaxLength = 32767
        Me.txtp2.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtp2.Name = "txtp2"
        Me.txtp2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtp2.SelectedText = ""
        Me.txtp2.SelectionLength = 0
        Me.txtp2.SelectionStart = 0
        Me.txtp2.Size = New System.Drawing.Size(224, 23)
        Me.txtp2.TabIndex = 2
        Me.txtp2.TabStop = False
        Me.txtp2.Text = "Player 2 Name"
        Me.txtp2.UseSystemPasswordChar = False
        '
        'btnpfp1
        '
        Me.btnpfp1.AutoSize = True
        Me.btnpfp1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnpfp1.Depth = 0
        Me.btnpfp1.Icon = Nothing
        Me.btnpfp1.Location = New System.Drawing.Point(520, 176)
        Me.btnpfp1.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnpfp1.Name = "btnpfp1"
        Me.btnpfp1.Primary = True
        Me.btnpfp1.Size = New System.Drawing.Size(76, 36)
        Me.btnpfp1.TabIndex = 14
        Me.btnpfp1.Text = "Change"
        Me.btnpfp1.UseVisualStyleBackColor = True
        '
        'btnpfp2
        '
        Me.btnpfp2.AutoSize = True
        Me.btnpfp2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnpfp2.Depth = 0
        Me.btnpfp2.Icon = Nothing
        Me.btnpfp2.Location = New System.Drawing.Point(520, 336)
        Me.btnpfp2.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnpfp2.Name = "btnpfp2"
        Me.btnpfp2.Primary = True
        Me.btnpfp2.Size = New System.Drawing.Size(76, 36)
        Me.btnpfp2.TabIndex = 15
        Me.btnpfp2.Text = "Change"
        Me.btnpfp2.UseVisualStyleBackColor = True
        '
        'theme1
        '
        Me.theme1.AutoSize = True
        Me.theme1.Depth = 0
        Me.theme1.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.theme1.Location = New System.Drawing.Point(488, 424)
        Me.theme1.Margin = New System.Windows.Forms.Padding(0)
        Me.theme1.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.theme1.MouseState = MaterialSkin.MouseState.HOVER
        Me.theme1.Name = "theme1"
        Me.theme1.Ripple = True
        Me.theme1.Size = New System.Drawing.Size(60, 30)
        Me.theme1.TabIndex = 16
        Me.theme1.Text = "Light"
        Me.theme1.UseVisualStyleBackColor = True
        '
        'themedark
        '
        Me.themedark.AutoSize = True
        Me.themedark.Checked = True
        Me.themedark.Depth = 0
        Me.themedark.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.themedark.Location = New System.Drawing.Point(568, 424)
        Me.themedark.Margin = New System.Windows.Forms.Padding(0)
        Me.themedark.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.themedark.MouseState = MaterialSkin.MouseState.HOVER
        Me.themedark.Name = "themedark"
        Me.themedark.Ripple = True
        Me.themedark.Size = New System.Drawing.Size(57, 30)
        Me.themedark.TabIndex = 17
        Me.themedark.TabStop = True
        Me.themedark.Text = "Dark"
        Me.themedark.UseVisualStyleBackColor = True
        '
        'OFG
        '
        Me.OFG.FileName = "OpenFileDialog1"
        '
        'MaterialRaisedButton1
        '
        Me.MaterialRaisedButton1.AutoSize = True
        Me.MaterialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialRaisedButton1.Depth = 0
        Me.MaterialRaisedButton1.Icon = Nothing
        Me.MaterialRaisedButton1.Location = New System.Drawing.Point(24, 424)
        Me.MaterialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton1.Name = "MaterialRaisedButton1"
        Me.MaterialRaisedButton1.Primary = True
        Me.MaterialRaisedButton1.Size = New System.Drawing.Size(64, 36)
        Me.MaterialRaisedButton1.TabIndex = 18
        Me.MaterialRaisedButton1.Text = "Start"
        Me.MaterialRaisedButton1.UseVisualStyleBackColor = True
        '
        'lblturn
        '
        Me.lblturn.AutoSize = True
        Me.lblturn.Depth = 0
        Me.lblturn.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblturn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblturn.Location = New System.Drawing.Point(160, 432)
        Me.lblturn.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblturn.Name = "lblturn"
        Me.lblturn.Size = New System.Drawing.Size(108, 19)
        Me.lblturn.TabIndex = 19
        Me.lblturn.Text = "MaterialLabel1"
        Me.lblturn.Visible = False
        '
        'pic5
        '
        Me.pic5.Enabled = False
        Me.pic5.Location = New System.Drawing.Point(160, 224)
        Me.pic5.Name = "pic5"
        Me.pic5.Size = New System.Drawing.Size(64, 64)
        Me.pic5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic5.TabIndex = 13
        Me.pic5.TabStop = False
        '
        'pic4
        '
        Me.pic4.Enabled = False
        Me.pic4.Location = New System.Drawing.Point(56, 224)
        Me.pic4.Name = "pic4"
        Me.pic4.Size = New System.Drawing.Size(64, 64)
        Me.pic4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic4.TabIndex = 12
        Me.pic4.TabStop = False
        '
        'pic7
        '
        Me.pic7.Enabled = False
        Me.pic7.Location = New System.Drawing.Point(56, 328)
        Me.pic7.Name = "pic7"
        Me.pic7.Size = New System.Drawing.Size(64, 64)
        Me.pic7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic7.TabIndex = 11
        Me.pic7.TabStop = False
        '
        'pic8
        '
        Me.pic8.Enabled = False
        Me.pic8.Location = New System.Drawing.Point(160, 328)
        Me.pic8.Name = "pic8"
        Me.pic8.Size = New System.Drawing.Size(64, 64)
        Me.pic8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic8.TabIndex = 10
        Me.pic8.TabStop = False
        '
        'pic9
        '
        Me.pic9.Enabled = False
        Me.pic9.Location = New System.Drawing.Point(264, 328)
        Me.pic9.Name = "pic9"
        Me.pic9.Size = New System.Drawing.Size(64, 64)
        Me.pic9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic9.TabIndex = 9
        Me.pic9.TabStop = False
        '
        'pic6
        '
        Me.pic6.Enabled = False
        Me.pic6.Location = New System.Drawing.Point(264, 224)
        Me.pic6.Name = "pic6"
        Me.pic6.Size = New System.Drawing.Size(64, 64)
        Me.pic6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic6.TabIndex = 8
        Me.pic6.TabStop = False
        '
        'pic3
        '
        Me.pic3.Enabled = False
        Me.pic3.Location = New System.Drawing.Point(264, 120)
        Me.pic3.Name = "pic3"
        Me.pic3.Size = New System.Drawing.Size(64, 64)
        Me.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic3.TabIndex = 7
        Me.pic3.TabStop = False
        '
        'pic2
        '
        Me.pic2.Enabled = False
        Me.pic2.Location = New System.Drawing.Point(160, 120)
        Me.pic2.Name = "pic2"
        Me.pic2.Size = New System.Drawing.Size(64, 64)
        Me.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic2.TabIndex = 6
        Me.pic2.TabStop = False
        '
        'pic1
        '
        Me.pic1.Enabled = False
        Me.pic1.Location = New System.Drawing.Point(56, 120)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(64, 64)
        Me.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic1.TabIndex = 5
        Me.pic1.TabStop = False
        '
        'pbp2
        '
        Me.pbp2.Image = Global.Naughts_and_Crosses.My.Resources.Resources.number_digit_2_png_transparent_images_transparent_backgrounds_Number_2_PNG_images_free_download_PNG14949
        Me.pbp2.Location = New System.Drawing.Point(392, 296)
        Me.pbp2.Name = "pbp2"
        Me.pbp2.Size = New System.Drawing.Size(120, 120)
        Me.pbp2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbp2.TabIndex = 4
        Me.pbp2.TabStop = False
        '
        'pbp1
        '
        Me.pbp1.Image = Global.Naughts_and_Crosses.My.Resources.Resources.blue_circle_number_1
        Me.pbp1.Location = New System.Drawing.Point(392, 128)
        Me.pbp1.Name = "pbp1"
        Me.pbp1.Size = New System.Drawing.Size(120, 120)
        Me.pbp1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbp1.TabIndex = 3
        Me.pbp1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(24, 88)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(336, 328)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnreset
        '
        Me.btnreset.AutoSize = True
        Me.btnreset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnreset.Depth = 0
        Me.btnreset.Icon = Nothing
        Me.btnreset.Location = New System.Drawing.Point(96, 424)
        Me.btnreset.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Primary = True
        Me.btnreset.Size = New System.Drawing.Size(62, 36)
        Me.btnreset.TabIndex = 20
        Me.btnreset.Text = "Reset"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 474)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.lblturn)
        Me.Controls.Add(Me.MaterialRaisedButton1)
        Me.Controls.Add(Me.themedark)
        Me.Controls.Add(Me.theme1)
        Me.Controls.Add(Me.btnpfp2)
        Me.Controls.Add(Me.btnpfp1)
        Me.Controls.Add(Me.pic5)
        Me.Controls.Add(Me.pic4)
        Me.Controls.Add(Me.pic7)
        Me.Controls.Add(Me.pic8)
        Me.Controls.Add(Me.pic9)
        Me.Controls.Add(Me.pic6)
        Me.Controls.Add(Me.pic3)
        Me.Controls.Add(Me.pic2)
        Me.Controls.Add(Me.pic1)
        Me.Controls.Add(Me.pbp2)
        Me.Controls.Add(Me.pbp1)
        Me.Controls.Add(Me.txtp2)
        Me.Controls.Add(Me.txtp1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pic5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbp2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbp1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtp1 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtp2 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents pbp1 As PictureBox
    Friend WithEvents pbp2 As PictureBox
    Friend WithEvents pic1 As PictureBox
    Friend WithEvents pic2 As PictureBox
    Friend WithEvents pic3 As PictureBox
    Friend WithEvents pic6 As PictureBox
    Friend WithEvents pic9 As PictureBox
    Friend WithEvents pic8 As PictureBox
    Friend WithEvents pic7 As PictureBox
    Friend WithEvents pic4 As PictureBox
    Friend WithEvents pic5 As PictureBox
    Friend WithEvents btnpfp1 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnpfp2 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents theme1 As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents themedark As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents OFG As OpenFileDialog
    Friend WithEvents MaterialRaisedButton1 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents lblturn As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btnreset As MaterialSkin.Controls.MaterialRaisedButton
End Class
