Public Class Form1
    Private Sub Btnload_Click(sender As Object, e As EventArgs) Handles btnload.Click
        If OFGSelectImage.ShowDialog = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OFGSelectImage.FileName)
        End If
    End Sub
End Class
