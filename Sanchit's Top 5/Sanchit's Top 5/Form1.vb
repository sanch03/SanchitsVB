Public Class Form1

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("Data Source: https://en.wikipedia.org/wiki/List_of_highest_mountains_on_Earth
Images:
https://en.wikipedia.org/wiki/Mount_Everest
https://en.wikipedia.org/wiki/K2
https://en.wikipedia.org/wiki/Kangchenjunga
https://en.wikipedia.org/wiki/Lhotse
https://en.wikipedia.org/wiki/Makalu")
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        PictureBox1.Visible = True
        lbl1.Visible = True
        lbl12.Visible = True
        btn2.Enabled = True
    End Sub
    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        PictureBox2.Visible = True
        lbl2.Visible = True
        lbl22.Visible = True
        btn3.Enabled = True
    End Sub
    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        PictureBox3.Visible = True
        lbl3.Visible = True
        lbl32.Visible = True
        btn4.Enabled = True
    End Sub
    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        PictureBox4.Visible = True
        lbl4.Visible = True
        lbl42.Visible = True
        btn5.Enabled = True
    End Sub
    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        PictureBox5.Visible = True
        lbl5.Visible = True
        lbl52.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        PictureBox1.Visible = True
        lbl1.Visible = True
        lbl12.Visible = True
        btn2.Enabled = True

        PictureBox2.Visible = True
        lbl2.Visible = True
        lbl22.Visible = True
        btn3.Enabled = True

        PictureBox3.Visible = True
        lbl3.Visible = True
        lbl32.Visible = True
        btn4.Enabled = True

        PictureBox4.Visible = True
        lbl4.Visible = True
        lbl42.Visible = True
        btn5.Enabled = True

        PictureBox5.Visible = True
        lbl5.Visible = True
        lbl52.Visible = True


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Restart()
    End Sub

End Class