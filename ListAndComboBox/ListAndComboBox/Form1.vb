Public Class Form1
    Private Sub Btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Dim myitem
        myitem = InputBox("Enter your Item")
        ListBox1.Items.Add(myitem)
        ComboBox1.Items.Add(myitem)
    End Sub

    Private Sub Btnremove_Click(sender As Object, e As EventArgs) Handles btnremove.Click
        Dim myitem
        myitem = InputBox("Enter your Item for Deletion")
        ListBox1.Items.Remove(myitem)
        ComboBox1.Items.Remove(myitem)
    End Sub
End Class
