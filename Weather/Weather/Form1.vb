Imports MaterialSkin
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.DARK
        SkinManager.ColorScheme = New ColorScheme(Primary.Red800, Primary.Red900, Primary.BlueGrey500, Accent.Red200, TextShade.WHITE)
    End Sub

    Private Sub Rbtnlight_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnlight.CheckedChanged
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
    End Sub

    Private Sub Rbtndark_CheckedChanged(sender As Object, e As EventArgs) Handles rbtndark.CheckedChanged
        SkinManager.Theme = MaterialSkinManager.Themes.DARK
    End Sub

    Private Sub Btnrain_Click(sender As Object, e As EventArgs) Handles btnrain.Click
        pbrain.Visible = True
    End Sub

    Private Sub Btnsun_Click(sender As Object, e As EventArgs) Handles btnsun.Click
        pbsun.Visible = True
    End Sub

    Private Sub Btnwind_Click(sender As Object, e As EventArgs) Handles btnwind.Click
        pbwind.Visible = True
    End Sub

    Private Sub Btnhide_Click(sender As Object, e As EventArgs) Handles btnhide.Click
        pbrain.Visible = False
        pbsun.Visible = False
        pbwind.Visible = False

    End Sub

    Private Sub Btnshow_Click(sender As Object, e As EventArgs) Handles btnshow.Click
        pbrain.Visible = True
        pbsun.Visible = True
        pbwind.Visible = True
    End Sub

    Private Sub Btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Close()
    End Sub
End Class

