Imports MaterialSkin

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.DARK
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue800, Primary.Blue900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)

    End Sub

    Private Sub Btntheme_Click(sender As Object, e As EventArgs) Handles btntheme.Click
        If SkinManager.Theme = MaterialSkinManager.Themes.DARK Then
            SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
            Label1.ForeColor = Color.Black
            btntheme.Text = " Dark   "
        Else
            SkinManager.Theme = MaterialSkinManager.Themes.DARK
            Label1.ForeColor = Color.White
            btntheme.Text = " Light  "
        End If
    End Sub

    Private Sub MaterialSingleLineTextField1_TextChanged(sender As Object, e As EventArgs) Handles txtaud.TextChanged
        Dim aud
        If txtaud.Text <> "" Then
            If IsNumeric(txtaud.Text) = True Then
                aud = FormatCurrency(txtaud.Text, , , TriState.True, TriState.True)
                lblusd.Text = "$ " & Format((aud * 0.7), "0.00")
                lblgbp.Text = "£ " & Format((aud * 0.55), "0.00")
                lbleue.Text = "€ " & Format((aud * 0.62), "0.00")
                lbljapyen.Text = "¥ " & Format((aud * 75.75), "0.00")
                lblchren.Text = "¥ " & Format((aud * 4.82), "0.00")
            Else
                txtaud.Text = ""
                lblusd.Text = ""
                lblgbp.Text = ""
                lbleue.Text = ""
                lbljapyen.Text = ""
                lblchren.Text = ""
            End If
        Else
            lblusd.Text = ""
            lblusd.Text = ""
            lblgbp.Text = ""
            lbleue.Text = ""
            lbljapyen.Text = ""
            lblchren.Text = ""
        End If
    End Sub

    Private Sub Btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtaud.Text = ""
    End Sub
End Class
