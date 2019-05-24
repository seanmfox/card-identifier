'Name: Sean Fox
'Course: CIT-161-Z03B
'Date: 5-22-19
'Program Name: Card Identifier
'Description: Chapter 2, Programming Challenge 3 - Create an application that, when a playing card is clicked, shows the name of the card


Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblAnswer.Click

    End Sub

    Private Sub PicThreeHearts_Click(sender As Object, e As EventArgs) Handles picThreeHearts.Click
        lblAnswer.Text = "Three of Hearts"
    End Sub

    Private Sub PicBlackJoker_Click(sender As Object, e As EventArgs) Handles picBlackJoker.Click
        lblAnswer.Text = "Black Joker"
    End Sub

    Private Sub PicAceDiamonds_Click(sender As Object, e As EventArgs) Handles picAceDiamonds.Click
        lblAnswer.Text = "Ace of Diamonds"
    End Sub

    Private Sub PicNineHearts_Click(sender As Object, e As EventArgs) Handles picNineHearts.Click
        lblAnswer.Text = "Nine of Hearts"
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        lblAnswer.Text = "Jack of Diamonds"
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
