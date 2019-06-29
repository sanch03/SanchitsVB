<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits MaterialSkin.Controls.MaterialForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnclear = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.txtaud = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pbau = New System.Windows.Forms.PictureBox()
        Me.pbus = New System.Windows.Forms.PictureBox()
        Me.pbbrit = New System.Windows.Forms.PictureBox()
        Me.pbeu = New System.Windows.Forms.PictureBox()
        Me.pbjap = New System.Windows.Forms.PictureBox()
        Me.btntheme = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.lblusd = New MaterialSkin.Controls.MaterialLabel()
        Me.lblgbp = New MaterialSkin.Controls.MaterialLabel()
        Me.lbleue = New MaterialSkin.Controls.MaterialLabel()
        Me.lbljapyen = New MaterialSkin.Controls.MaterialLabel()
        Me.lblusdtxt = New MaterialSkin.Controls.MaterialLabel()
        Me.pbchina = New System.Windows.Forms.PictureBox()
        Me.lblchren = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.lbl6 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel6 = New MaterialSkin.Controls.MaterialLabel()
        CType(Me.pbau, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbbrit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbeu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbjap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbchina, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnclear
        '
        Me.btnclear.AutoSize = True
        Me.btnclear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnclear.Depth = 0
        Me.btnclear.Icon = Nothing
        Me.btnclear.Location = New System.Drawing.Point(392, 120)
        Me.btnclear.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Primary = True
        Me.btnclear.Size = New System.Drawing.Size(63, 36)
        Me.btnclear.TabIndex = 0
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'txtaud
        '
        Me.txtaud.Depth = 0
        Me.txtaud.Hint = "Enter Amount"
        Me.txtaud.Location = New System.Drawing.Point(144, 128)
        Me.txtaud.MaxLength = 11
        Me.txtaud.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtaud.Name = "txtaud"
        Me.txtaud.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtaud.SelectedText = ""
        Me.txtaud.SelectionLength = 0
        Me.txtaud.SelectionStart = 0
        Me.txtaud.Size = New System.Drawing.Size(104, 23)
        Me.txtaud.TabIndex = 2
        Me.txtaud.TabStop = False
        Me.txtaud.UseSystemPasswordChar = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Roboto", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(24, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(424, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Foreign Exchange Converter"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbau
        '
        Me.pbau.Image = Global.Currency_Converter.My.Resources.Resources.AusFlag200wide
        Me.pbau.Location = New System.Drawing.Point(16, 112)
        Me.pbau.Name = "pbau"
        Me.pbau.Size = New System.Drawing.Size(100, 50)
        Me.pbau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbau.TabIndex = 4
        Me.pbau.TabStop = False
        '
        'pbus
        '
        Me.pbus.Image = Global.Currency_Converter.My.Resources.Resources.us_mdflag
        Me.pbus.Location = New System.Drawing.Point(16, 184)
        Me.pbus.Name = "pbus"
        Me.pbus.Size = New System.Drawing.Size(100, 50)
        Me.pbus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbus.TabIndex = 5
        Me.pbus.TabStop = False
        '
        'pbbrit
        '
        Me.pbbrit.Image = Global.Currency_Converter.My.Resources.Resources.union_jack_britain
        Me.pbbrit.Location = New System.Drawing.Point(16, 256)
        Me.pbbrit.Name = "pbbrit"
        Me.pbbrit.Size = New System.Drawing.Size(100, 50)
        Me.pbbrit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbbrit.TabIndex = 6
        Me.pbbrit.TabStop = False
        '
        'pbeu
        '
        Me.pbeu.Image = Global.Currency_Converter.My.Resources.Resources.EuroFlag
        Me.pbeu.Location = New System.Drawing.Point(16, 328)
        Me.pbeu.Name = "pbeu"
        Me.pbeu.Size = New System.Drawing.Size(100, 50)
        Me.pbeu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbeu.TabIndex = 7
        Me.pbeu.TabStop = False
        '
        'pbjap
        '
        Me.pbjap.Image = Global.Currency_Converter.My.Resources.Resources.japan_flag
        Me.pbjap.Location = New System.Drawing.Point(16, 400)
        Me.pbjap.Name = "pbjap"
        Me.pbjap.Size = New System.Drawing.Size(100, 50)
        Me.pbjap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbjap.TabIndex = 8
        Me.pbjap.TabStop = False
        '
        'btntheme
        '
        Me.btntheme.AutoSize = True
        Me.btntheme.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btntheme.Depth = 0
        Me.btntheme.Icon = Nothing
        Me.btntheme.Location = New System.Drawing.Point(392, 192)
        Me.btntheme.MouseState = MaterialSkin.MouseState.HOVER
        Me.btntheme.Name = "btntheme"
        Me.btntheme.Primary = True
        Me.btntheme.Size = New System.Drawing.Size(63, 36)
        Me.btntheme.TabIndex = 9
        Me.btntheme.Text = " Light  "
        Me.btntheme.UseVisualStyleBackColor = True
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(264, 128)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(81, 19)
        Me.MaterialLabel1.TabIndex = 10
        Me.MaterialLabel1.Text = "AU Dollars"
        '
        'lblusd
        '
        Me.lblusd.Depth = 0
        Me.lblusd.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblusd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblusd.Location = New System.Drawing.Point(128, 200)
        Me.lblusd.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblusd.Name = "lblusd"
        Me.lblusd.Size = New System.Drawing.Size(112, 19)
        Me.lblusd.TabIndex = 11
        '
        'lblgbp
        '
        Me.lblgbp.Depth = 0
        Me.lblgbp.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblgbp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblgbp.Location = New System.Drawing.Point(128, 272)
        Me.lblgbp.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblgbp.Name = "lblgbp"
        Me.lblgbp.Size = New System.Drawing.Size(112, 19)
        Me.lblgbp.TabIndex = 12
        '
        'lbleue
        '
        Me.lbleue.Depth = 0
        Me.lbleue.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lbleue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbleue.Location = New System.Drawing.Point(128, 344)
        Me.lbleue.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbleue.Name = "lbleue"
        Me.lbleue.Size = New System.Drawing.Size(112, 19)
        Me.lbleue.TabIndex = 13
        '
        'lbljapyen
        '
        Me.lbljapyen.Depth = 0
        Me.lbljapyen.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lbljapyen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbljapyen.Location = New System.Drawing.Point(128, 416)
        Me.lbljapyen.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbljapyen.Name = "lbljapyen"
        Me.lbljapyen.Size = New System.Drawing.Size(112, 19)
        Me.lbljapyen.TabIndex = 14
        '
        'lblusdtxt
        '
        Me.lblusdtxt.Depth = 0
        Me.lblusdtxt.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblusdtxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblusdtxt.Location = New System.Drawing.Point(264, 200)
        Me.lblusdtxt.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblusdtxt.Name = "lblusdtxt"
        Me.lblusdtxt.Size = New System.Drawing.Size(88, 19)
        Me.lblusdtxt.TabIndex = 15
        Me.lblusdtxt.Text = "US Dollars"
        '
        'pbchina
        '
        Me.pbchina.Image = Global.Currency_Converter.My.Resources.Resources.chinese_flag_md
        Me.pbchina.Location = New System.Drawing.Point(16, 472)
        Me.pbchina.Name = "pbchina"
        Me.pbchina.Size = New System.Drawing.Size(100, 50)
        Me.pbchina.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbchina.TabIndex = 16
        Me.pbchina.TabStop = False
        '
        'lblchren
        '
        Me.lblchren.Depth = 0
        Me.lblchren.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblchren.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblchren.Location = New System.Drawing.Point(128, 488)
        Me.lblchren.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblchren.Name = "lblchren"
        Me.lblchren.Size = New System.Drawing.Size(112, 19)
        Me.lblchren.TabIndex = 17
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(264, 272)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(88, 19)
        Me.MaterialLabel2.TabIndex = 18
        Me.MaterialLabel2.Text = "GB Pounds"
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(264, 344)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(128, 19)
        Me.MaterialLabel3.TabIndex = 19
        Me.MaterialLabel3.Text = "European Euros"
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel4.Location = New System.Drawing.Point(264, 416)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(112, 19)
        Me.MaterialLabel4.TabIndex = 20
        Me.MaterialLabel4.Text = "Japanese Yen"
        '
        'MaterialLabel5
        '
        Me.MaterialLabel5.Depth = 0
        Me.MaterialLabel5.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel5.Location = New System.Drawing.Point(264, 488)
        Me.MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel5.Name = "MaterialLabel5"
        Me.MaterialLabel5.Size = New System.Drawing.Size(120, 19)
        Me.MaterialLabel5.TabIndex = 21
        Me.MaterialLabel5.Text = "Chinese Yuan"
        '
        'lbl6
        '
        Me.lbl6.AutoSize = True
        Me.lbl6.Depth = 0
        Me.lbl6.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lbl6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl6.Location = New System.Drawing.Point(264, 520)
        Me.lbl6.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(207, 19)
        Me.lbl6.TabIndex = 22
        Me.lbl6.Text = "Data collected on 29/06/2019"
        '
        'MaterialLabel6
        '
        Me.MaterialLabel6.Depth = 0
        Me.MaterialLabel6.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel6.Location = New System.Drawing.Point(128, 128)
        Me.MaterialLabel6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel6.Name = "MaterialLabel6"
        Me.MaterialLabel6.Size = New System.Drawing.Size(16, 19)
        Me.MaterialLabel6.TabIndex = 23
        Me.MaterialLabel6.Text = "$"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 543)
        Me.Controls.Add(Me.MaterialLabel6)
        Me.Controls.Add(Me.lbl6)
        Me.Controls.Add(Me.MaterialLabel5)
        Me.Controls.Add(Me.MaterialLabel4)
        Me.Controls.Add(Me.MaterialLabel3)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.lblchren)
        Me.Controls.Add(Me.pbchina)
        Me.Controls.Add(Me.lblusdtxt)
        Me.Controls.Add(Me.lbljapyen)
        Me.Controls.Add(Me.lbleue)
        Me.Controls.Add(Me.lblgbp)
        Me.Controls.Add(Me.lblusd)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.btntheme)
        Me.Controls.Add(Me.pbjap)
        Me.Controls.Add(Me.pbeu)
        Me.Controls.Add(Me.pbbrit)
        Me.Controls.Add(Me.pbus)
        Me.Controls.Add(Me.pbau)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtaud)
        Me.Controls.Add(Me.btnclear)
        Me.Name = "Form1"
        Me.Text = "Currency Converter"
        CType(Me.pbau, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbbrit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbeu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbjap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbchina, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnclear As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents txtaud As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label1 As Label
    Friend WithEvents pbau As PictureBox
    Friend WithEvents pbus As PictureBox
    Friend WithEvents pbbrit As PictureBox
    Friend WithEvents pbeu As PictureBox
    Friend WithEvents pbjap As PictureBox
    Friend WithEvents btntheme As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblusd As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblgbp As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lbleue As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lbljapyen As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblusdtxt As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents pbchina As PictureBox
    Friend WithEvents lblchren As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lbl6 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel6 As MaterialSkin.Controls.MaterialLabel
End Class
