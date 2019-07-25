Imports MaterialSkin
Public Class Form1
    Dim NumberOfSquares As Integer = 0
    Dim RandomNumber As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.DARK
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue800, Primary.Blue900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)


    End Sub

    Private Sub Theme1_CheckedChanged(sender As Object, e As EventArgs) Handles theme1.CheckedChanged
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
    End Sub

    Private Sub Themedark_CheckedChanged(sender As Object, e As EventArgs) Handles themedark.CheckedChanged
        SkinManager.Theme = MaterialSkinManager.Themes.DARK
    End Sub

    Private Sub Btnpfp1_Click(sender As Object, e As EventArgs) Handles btnpfp1.Click
        If OFG.ShowDialog = DialogResult.OK Then
            pbp1.Image = Image.FromFile(OFG.FileName)
        End If
    End Sub
    Private Sub Btnpfp2_Click(sender As Object, e As EventArgs) Handles btnpfp2.Click
        If OFG.ShowDialog = DialogResult.OK Then
            pbp2.Image = Image.FromFile(OFG.FileName)
        End If
    End Sub
    Private Sub pic1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic1.Click
        'The tag property of a picture box tells us if it has been clicked
        'on previously.
        'If the picture box has not been clicked yet, then its tag
        ' should be "" or empty and so we can proceed to make an image
        'in this box, depending on which player's
        'turn it currently is.
        If pic1.Tag = "" Then
            'make the box's image be the same as the one
            'next to the player's name
            If lblturn.Text = txtp1.Text Then
                pic1.Image = pbp1.Image
                'set the Tag so that pic1 box cannot be clicked
                'again later in the game
                pic1.Tag = "1"
                'Increase the count of Squares that have
                'been clicked by 1
                NumberOfSquares = NumberOfSquares + 1
                'Check for End of Game Conditions by calling the
                'Checking Subroutine
                CheckForEndOfGame()
                'set the game to next do Player2's Turn
                lblturn.Text = txtp2.Text
            Else
                'it must be Player 2 clicking on the box
                'and so put their image in there.
                pic1.Image = pbp2.Image
                'set the Tag so that pic1 box cannot be
                'clicked again later in the game
                pic1.Tag = "2"
                'Increase the count of Squares that
                'have been clicked by 1
                NumberOfSquares = NumberOfSquares + 1
                'Check for End of Game Conditions by calling the
                'Checking Subroutine
                CheckForEndOfGame()
                'set the game to next do Player1's Turn
                lblturn.Text = txtp1.Text
            End If
        End If
    End Sub    Private Sub pic2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic2.Click

        If pic2.Tag = "" Then
            If lblturn.Text = txtp1.Text Then
                pic2.Image = pbp1.Image
                pic2.Tag = "1"
                NumberOfSquares = NumberOfSquares + 1
                'Check for End of Game Conditions by calling the
                'Checking Subroutine
                CheckForEndOfGame()
                lblturn.Text = txtp2.Text
            Else
                pic2.Image = pbp2.Image
                pic2.Tag = "2"
                NumberOfSquares = NumberOfSquares + 1
                'Check for End of Game Conditions by calling the
                'Checking Subroutine
                CheckForEndOfGame()
                lblturn.Text = txtp1.Text
            End If
        End If
    End Sub
    Private Sub pic3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic3.Click

        If pic3.Tag = "" Then
            If lblturn.Text = txtp1.Text Then
                pic3.Image = pbp1.Image
                pic3.Tag = "1"
                NumberOfSquares = NumberOfSquares + 1
                'Check for End of Game Conditions by calling the
                'Checking Subroutine
                CheckForEndOfGame()
                lblturn.Text = txtp2.Text
            Else
                pic3.Image = pbp2.Image
                pic3.Tag = "2"
                NumberOfSquares = NumberOfSquares + 1
                'Check for End of Game Conditions by calling the
                'Checking Subroutine
                CheckForEndOfGame()
                lblturn.Text = txtp1.Text
            End If
        End If
    End Sub
    Private Sub pic4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic4.Click

        If pic4.Tag = "" Then
            If lblturn.Text = txtp1.Text Then
                pic4.Image = pbp1.Image
                pic4.Tag = "1"
                NumberOfSquares = NumberOfSquares + 1
                'Check for End of Game Conditions by calling the
                'Checking Subroutine
                CheckForEndOfGame()
                lblturn.Text = txtp2.Text
            Else
                pic4.Image = pbp2.Image
                pic4.Tag = "2"
                NumberOfSquares = NumberOfSquares + 1
                'Check for End of Game Conditions by calling the
                'Checking Subroutine
                CheckForEndOfGame()
                lblturn.Text = txtp1.Text
            End If
        End If
    End Sub
    Private Sub pic5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic5.Click

        If pic5.Tag = "" Then
            If lblturn.Text = txtp1.Text Then
                pic5.Image = pbp1.Image
                pic5.Tag = "1"
                NumberOfSquares = NumberOfSquares + 1
                'Check for End of Game Conditions by calling the
                'Checking Subroutine
                CheckForEndOfGame()
                lblturn.Text = txtp2.Text
            Else
                pic5.Image = pbp2.Image
                pic5.Tag = "2"
                NumberOfSquares = NumberOfSquares + 1
                'Check for End of Game Conditions by calling the
                'Checking Subroutine
                CheckForEndOfGame()
                lblturn.Text = txtp1.Text
            End If
        End If
    End Sub
    Private Sub pic6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic6.Click

        If pic6.Tag = "" Then
            If lblturn.Text = txtp1.Text Then
                pic6.Image = pbp1.Image
                pic6.Tag = "1"
                NumberOfSquares = NumberOfSquares + 1
                'Check for End of Game Conditions by calling the
                'Checking Subroutine
                CheckForEndOfGame()
                lblturn.Text = txtp2.Text
            Else
                pic6.Image = pbp2.Image
                pic6.Tag = "2"
                NumberOfSquares = NumberOfSquares + 1
                'Check for End of Game Conditions by calling the
                'Checking Subroutine
                CheckForEndOfGame()
                lblturn.Text = txtp1.Text
            End If
        End If
    End Sub
    Private Sub pic7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic7.Click

        If pic7.Tag = "" Then
            If lblturn.Text = txtp1.Text Then
                pic7.Image = pbp1.Image
                pic7.Tag = "1"
                NumberOfSquares = NumberOfSquares + 1
                'Check for End of Game Conditions by calling the
                'Checking Subroutine
                CheckForEndOfGame()
                lblturn.Text = txtp2.Text
            Else
                pic7.Image = pbp2.Image
                pic7.Tag = "2"
                NumberOfSquares = NumberOfSquares + 1
                'Check for End of Game Conditions by calling the
                'Checking Subroutine
                CheckForEndOfGame()
                lblturn.Text = txtp1.Text
            End If
        End If
    End Sub
    Private Sub pic8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic8.Click

        If pic8.Tag = "" Then
            If lblturn.Text = txtp1.Text Then
                pic8.Image = pbp1.Image
                pic8.Tag = "1"
                NumberOfSquares = NumberOfSquares + 1
                'Check for End of Game Conditions by calling the
                'Checking Subroutine
                CheckForEndOfGame()
                lblturn.Text = txtp2.Text
            Else
                pic8.Image = pbp2.Image
                pic8.Tag = "2"
                NumberOfSquares = NumberOfSquares + 1
                'Check for End of Game Conditions by calling the
                'Checking Subroutine
                CheckForEndOfGame()
                lblturn.Text = txtp1.Text
            End If
        End If
    End Sub
    Private Sub pic9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic9.Click

        If pic9.Tag = "" Then
            If lblturn.Text = txtp1.Text Then
                pic9.Image = pbp1.Image
                pic9.Tag = "1"
                NumberOfSquares = NumberOfSquares + 1
                'Check for End of Game Conditions by calling the
                'Checking Subroutine
                CheckForEndOfGame()
                lblturn.Text = txtp2.Text
            Else
                pic9.Image = pbp2.Image
                pic9.Tag = "2"
                NumberOfSquares = NumberOfSquares + 1
                'Check for End of Game Conditions by calling the
                'Checking Subroutine
                CheckForEndOfGame()
                lblturn.Text = txtp1.Text
            End If
        End If
    End Sub
    Public Sub CheckForEndOfGame()
        ' 1 2 3
        ' 4 5 6
        ' 7 8 9
        'Eight combos in the grid for each Player = 16 checks
        ' Plus the check for all nine full but no winner.
        'Check if Player 1 has the top 3 squares filled in
        'a continuous horizontal row
        If pic1.Tag = "1" And pic2.Tag = "1" And pic3.Tag = "1" Then
            MsgBox(
                "*** " & txtp1.Text & " Wins! ***"
                )
            Exit Sub
        End If
        'Check if Player 2 has the top 3 squares filled in
        'a continuous horizontal row
        If pic1.Tag = "2" And pic2.Tag = "2" And pic3.Tag = "2" Then
            MsgBox("*** " & txtp2.Text & " Wins! ***")
            Exit Sub
        End If
        'Check if Player 1 has the Middle 3 squares filled in
        'a continuous horizontal row
        If pic4.Tag = "1" And pic5.Tag = "1" And pic6.Tag = "1" Then
            MsgBox("*** " & txtp1.Text & " Wins! ***")
            Exit Sub
        End If
        'Check if Player 2 has the Middle 3 squares filled in
        'a continuous horizontal row
        If pic4.Tag = "2" And pic5.Tag = "2" And pic6.Tag = "2" Then
            MsgBox("*** " & txtp2.Text & " Wins! ***")
            Exit Sub
        End If
        'ADD IN THE CODE FOR THE OTHER 12 COMBINATIONS HERE
        If NumberOfSquares = 9 Then
            MsgBox("*** Game Over - No Winner ***")
            Exit Sub
        End If
        If pic7.Tag = "1" And pic8.Tag = "1" And pic9.Tag = "1" Then
            MsgBox("*** " & txtp1.Text & " Wins! ***")
            Exit Sub
        End If
        'Check if Player 2 has the Middle 3 squares filled in
        'a continuous horizontal row
        If pic7.Tag = "2" And pic8.Tag = "2" And pic9.Tag = "2" Then
            MsgBox("*** " & txtp2.Text & " Wins! ***")
            Exit Sub
        End If
        If pic1.Tag = "1" And pic4.Tag = "1" And pic7.Tag = "1" Then
            MsgBox("*** " & txtp1.Text & " Wins! ***")
            Exit Sub
        End If
        'Check if Player 2 has the Middle 3 squares filled in
        'a continuous horizontal row
        If pic1.Tag = "2" And pic4.Tag = "2" And pic7.Tag = "2" Then
            MsgBox("*** " & txtp2.Text & " Wins! ***")
            Exit Sub
        End If
        If pic2.Tag = "1" And pic5.Tag = "1" And pic8.Tag = "1" Then
            MsgBox("*** " & txtp1.Text & " Wins! ***")
            Exit Sub
        End If
        'Check if Player 2 has the Middle 3 squares filled in
        'a continuous horizontal row
        If pic2.Tag = "2" And pic5.Tag = "2" And pic8.Tag = "2" Then
            MsgBox("*** " & txtp2.Text & " Wins! ***")
            Exit Sub
        End If
        If pic3.Tag = "1" And pic6.Tag = "1" And pic9.Tag = "1" Then
            MsgBox("*** " & txtp1.Text & " Wins! ***")
            Exit Sub
        End If
        'Check if Player 2 has the Middle 3 squares filled in
        'a continuous horizontal row
        If pic3.Tag = "2" And pic6.Tag = "2" And pic9.Tag = "2" Then
            MsgBox("*** " & txtp2.Text & " Wins! ***")
            Exit Sub
        End If
        If pic1.Tag = "1" And pic5.Tag = "1" And pic9.Tag = "1" Then
            MsgBox("*** " & txtp1.Text & " Wins! ***")
            Exit Sub
        End If
        'Check if Player 2 has the Middle 3 squares filled in
        'a continuous horizontal row
        If pic1.Tag = "2" And pic5.Tag = "2" And pic9.Tag = "2" Then
            MsgBox("*** " & txtp2.Text & " Wins! ***")
            Exit Sub
        End If
        If pic3.Tag = "1" And pic5.Tag = "1" And pic7.Tag = "1" Then
            MsgBox("*** " & txtp1.Text & " Wins! ***")
            Exit Sub
        End If
        'Check if Player 2 has the Middle 3 squares filled in
        'a continuous horizontal row
        If pic3.Tag = "2" And pic5.Tag = "2" And pic7.Tag = "2" Then
            MsgBox("*** " & txtp2.Text & " Wins! ***")
            Exit Sub
        End If
    End Sub

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        pic1.Enabled = True
        pic2.Enabled = True
        pic3.Enabled = True
        pic4.Enabled = True
        pic5.Enabled = True
        pic6.Enabled = True
        pic7.Enabled = True
        pic8.Enabled = True
        pic9.Enabled = True
        btnpfp1.Enabled = False
        btnpfp2.Enabled = False
        txtp1.Enabled = False
        txtp2.Enabled = False
        Randomize()
        'We have set it here to do Numbers between 1 and 2 using:
        'RandomNumber = Rnd() * 1 + 1

        RandomNumber = Rnd() * 1 + 1
        'Now depending on whether we obtain 1 or 2 for our random Number,
        'Set the lblTurn on the Form to either Player 1 or Player 2 
        If RandomNumber = 1 Then
            lblturn.Text = txtp1.Text
        Else
            lblturn.Text = txtp2.Text
        End If
        lblturn.Visible = True


    End Sub
End Class