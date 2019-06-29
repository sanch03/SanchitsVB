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
        Me.lbl1 = New MaterialSkin.Controls.MaterialLabel()
        Me.btnrain = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnsun = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnwind = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialDivider1 = New MaterialSkin.Controls.MaterialDivider()
        Me.pbrain = New System.Windows.Forms.PictureBox()
        Me.pbsun = New System.Windows.Forms.PictureBox()
        Me.pbwind = New System.Windows.Forms.PictureBox()
        Me.btnhide = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnshow = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnclose = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.rbtndark = New MaterialSkin.Controls.MaterialRadioButton()
        Me.rbtnlight = New MaterialSkin.Controls.MaterialRadioButton()
        CType(Me.pbrain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbsun, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbwind, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl1
        '
        Me.lbl1.Depth = 0
        Me.lbl1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lbl1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl1.Location = New System.Drawing.Point(216, 72)
        Me.lbl1.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(344, 24)
        Me.lbl1.TabIndex = 0
        Me.lbl1.Text = "Click each button to see the weather conditions. "
        '
        'btnrain
        '
        Me.btnrain.AutoSize = True
        Me.btnrain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnrain.Depth = 0
        Me.btnrain.Icon = Nothing
        Me.btnrain.Location = New System.Drawing.Point(88, 120)
        Me.btnrain.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnrain.Name = "btnrain"
        Me.btnrain.Primary = True
        Me.btnrain.Size = New System.Drawing.Size(75, 36)
        Me.btnrain.TabIndex = 2
        Me.btnrain.Text = "Raining"
        Me.btnrain.UseVisualStyleBackColor = True
        '
        'btnsun
        '
        Me.btnsun.AutoSize = True
        Me.btnsun.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnsun.Depth = 0
        Me.btnsun.Icon = Nothing
        Me.btnsun.Location = New System.Drawing.Point(368, 120)
        Me.btnsun.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnsun.Name = "btnsun"
        Me.btnsun.Primary = True
        Me.btnsun.Size = New System.Drawing.Size(69, 36)
        Me.btnsun.TabIndex = 3
        Me.btnsun.Text = " Sunny "
        Me.btnsun.UseVisualStyleBackColor = True
        '
        'btnwind
        '
        Me.btnwind.AutoSize = True
        Me.btnwind.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnwind.Depth = 0
        Me.btnwind.Icon = Nothing
        Me.btnwind.Location = New System.Drawing.Point(648, 120)
        Me.btnwind.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnwind.Name = "btnwind"
        Me.btnwind.Primary = True
        Me.btnwind.Size = New System.Drawing.Size(67, 36)
        Me.btnwind.TabIndex = 4
        Me.btnwind.Text = " Windy "
        Me.btnwind.UseVisualStyleBackColor = True
        '
        'MaterialDivider1
        '
        Me.MaterialDivider1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider1.Depth = 0
        Me.MaterialDivider1.Location = New System.Drawing.Point(0, 0)
        Me.MaterialDivider1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider1.Name = "MaterialDivider1"
        Me.MaterialDivider1.Size = New System.Drawing.Size(75, 23)
        Me.MaterialDivider1.TabIndex = 5
        Me.MaterialDivider1.Text = "MaterialDivider1"
        '
        'pbrain
        '
        Me.pbrain.Image = Global.Weather.My.Resources.Resources.very_rainy_day
        Me.pbrain.Location = New System.Drawing.Point(24, 176)
        Me.pbrain.Name = "pbrain"
        Me.pbrain.Size = New System.Drawing.Size(208, 160)
        Me.pbrain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbrain.TabIndex = 6
        Me.pbrain.TabStop = False
        Me.pbrain.Visible = False
        '
        'pbsun
        '
        Me.pbsun.Image = Global.Weather.My.Resources.Resources.sunny_beach_400x250
        Me.pbsun.Location = New System.Drawing.Point(296, 176)
        Me.pbsun.Name = "pbsun"
        Me.pbsun.Size = New System.Drawing.Size(208, 160)
        Me.pbsun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbsun.TabIndex = 7
        Me.pbsun.TabStop = False
        Me.pbsun.Visible = False
        '
        'pbwind
        '
        Me.pbwind.Image = Global.Weather.My.Resources.Resources.windy_day
        Me.pbwind.Location = New System.Drawing.Point(568, 176)
        Me.pbwind.Name = "pbwind"
        Me.pbwind.Size = New System.Drawing.Size(208, 160)
        Me.pbwind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbwind.TabIndex = 8
        Me.pbwind.TabStop = False
        Me.pbwind.Visible = False
        '
        'btnhide
        '
        Me.btnhide.AutoSize = True
        Me.btnhide.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnhide.Depth = 0
        Me.btnhide.Icon = Nothing
        Me.btnhide.Location = New System.Drawing.Point(616, 376)
        Me.btnhide.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnhide.Name = "btnhide"
        Me.btnhide.Primary = True
        Me.btnhide.Size = New System.Drawing.Size(79, 36)
        Me.btnhide.TabIndex = 9
        Me.btnhide.Text = "Hide All"
        Me.btnhide.UseVisualStyleBackColor = True
        '
        'btnshow
        '
        Me.btnshow.AutoSize = True
        Me.btnshow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnshow.Depth = 0
        Me.btnshow.Icon = Nothing
        Me.btnshow.Location = New System.Drawing.Point(512, 376)
        Me.btnshow.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnshow.Name = "btnshow"
        Me.btnshow.Primary = True
        Me.btnshow.Size = New System.Drawing.Size(88, 36)
        Me.btnshow.TabIndex = 10
        Me.btnshow.Text = "Show All"
        Me.btnshow.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.AutoSize = True
        Me.btnclose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnclose.Depth = 0
        Me.btnclose.Icon = Nothing
        Me.btnclose.Location = New System.Drawing.Point(712, 376)
        Me.btnclose.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Primary = True
        Me.btnclose.Size = New System.Drawing.Size(63, 36)
        Me.btnclose.TabIndex = 11
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'rbtndark
        '
        Me.rbtndark.AutoSize = True
        Me.rbtndark.Checked = True
        Me.rbtndark.Depth = 0
        Me.rbtndark.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rbtndark.Location = New System.Drawing.Point(24, 384)
        Me.rbtndark.Margin = New System.Windows.Forms.Padding(0)
        Me.rbtndark.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rbtndark.MouseState = MaterialSkin.MouseState.HOVER
        Me.rbtndark.Name = "rbtndark"
        Me.rbtndark.Ripple = True
        Me.rbtndark.Size = New System.Drawing.Size(57, 30)
        Me.rbtndark.TabIndex = 12
        Me.rbtndark.TabStop = True
        Me.rbtndark.Text = "Dark"
        Me.rbtndark.UseVisualStyleBackColor = True
        '
        'rbtnlight
        '
        Me.rbtnlight.AutoSize = True
        Me.rbtnlight.Depth = 0
        Me.rbtnlight.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rbtnlight.Location = New System.Drawing.Point(104, 384)
        Me.rbtnlight.Margin = New System.Windows.Forms.Padding(0)
        Me.rbtnlight.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rbtnlight.MouseState = MaterialSkin.MouseState.HOVER
        Me.rbtnlight.Name = "rbtnlight"
        Me.rbtnlight.Ripple = True
        Me.rbtnlight.Size = New System.Drawing.Size(60, 30)
        Me.rbtnlight.TabIndex = 13
        Me.rbtnlight.Text = "Light"
        Me.rbtnlight.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 430)
        Me.Controls.Add(Me.rbtnlight)
        Me.Controls.Add(Me.rbtndark)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnshow)
        Me.Controls.Add(Me.btnhide)
        Me.Controls.Add(Me.pbwind)
        Me.Controls.Add(Me.pbsun)
        Me.Controls.Add(Me.pbrain)
        Me.Controls.Add(Me.MaterialDivider1)
        Me.Controls.Add(Me.btnwind)
        Me.Controls.Add(Me.btnsun)
        Me.Controls.Add(Me.btnrain)
        Me.Controls.Add(Me.lbl1)
        Me.Name = "Form1"
        Me.Text = "Weather Conditions (By Sanchit)"
        CType(Me.pbrain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbsun, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbwind, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btnrain As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnsun As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnwind As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialDivider1 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents pbrain As PictureBox
    Friend WithEvents pbsun As PictureBox
    Friend WithEvents pbwind As PictureBox
    Friend WithEvents btnhide As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnshow As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnclose As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents rbtndark As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents rbtnlight As MaterialSkin.Controls.MaterialRadioButton
End Class
