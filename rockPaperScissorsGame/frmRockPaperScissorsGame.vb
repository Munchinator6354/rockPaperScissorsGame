Option Strict On
Option Explicit On

'Program:       rockPaperScissorsGame
'Programmer:    Ryan Isaacson / Munchinator6354
'Date           October 26, 2020
'Description    Program will pit you against the computer in the classic madness of Rock, Paper, Scissors.

Public Class frmRockPaperScissorsGame
    'Sets up our variables
    Dim intHumanChoice As Integer
    Dim intComputerChoice As Integer
    '---------------------------------------------------------------------------------------------------------------
    'Subroutine:    btnRun_Click
    'Programmer:    Ryan Isaacson / Munchinator6354
    'Date:          October 26, 2020
    'Description:   Generates the computers' weapon choice displays all outputs to the user
    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click
        'Generates random number of 1, 2, or 3 for computers choice
        intComputerChoice = CInt(Int(Rnd() * 3) + 1)

        'Shows the "And the Winner Is..." Text
        lblWinnerText.Show()

        'Reads the computer's choice and displays associated text and picture
        If intComputerChoice = 1 Then
            lblComputerChoiceOutput.Text = "Rock"
            picComputerPicture.Image = Image.FromFile("..\Images\dwayneJohnsonRock.jpg")
        ElseIf intComputerChoice = 2 Then
            lblComputerChoiceOutput.Text = "Paper"
            picComputerPicture.Image = Image.FromFile("..\Images\paper.png")
        ElseIf intComputerChoice = 3 Then
            lblComputerChoiceOutput.Text = "Scissors"
            picComputerPicture.Image = Image.FromFile("..\Images\scissors.jpg")
        End If

        'Reads the human's choice and displays associated text and picture
        If radRock.Checked = True Then
            intHumanChoice = 1
            lblHumanChoiceOutput.Text = "Rock"
            picHumanPicture.Image = Image.FromFile("..\Images\dwayneJohnsonRock.jpg")
        ElseIf radPaper.Checked = True Then
            intHumanChoice = 2
            lblHumanChoiceOutput.Text = "Paper"
            picHumanPicture.Image = Image.FromFile("..\Images\paper.png")
        ElseIf radScissors.Checked = True Then
            intHumanChoice = 3
            lblHumanChoiceOutput.Text = "Scissors"
            picHumanPicture.Image = Image.FromFile("..\Images\scissors.jpg")
        End If

        'Calls the FindWinner Subroutine to analyze the results and display a victor!
        FindWinner()
    End Sub
    '---------------------------------------------------------------------------------------------------------------
    'Subroutine:    FindWinner()
    'Programmer:    Ryan Isaacson / Munchinator6354
    'Date:          October 26, 2020
    'Description:   Confirms which player won the game
    Public Sub FindWinner()
        If intHumanChoice = intComputerChoice Then
            lblWinnerOutput.Text = "Neither Player, it's a Draw!!!"
        ElseIf intHumanChoice = 1 And intComputerChoice = 3 Then
            lblWinnerOutput.Text = "Human Player!"
        ElseIf intHumanChoice = 2 And intComputerChoice = 1 Then
            lblWinnerOutput.Text = "Human Player!"
        ElseIf intHumanChoice = 3 And intComputerChoice = 2 Then
            lblWinnerOutput.Text = "Human Player!"
        Else
            lblWinnerOutput.Text = "Computer Player!"
        End If
    End Sub
    '---------------------------------------------------------------------------------------------------------------
    'Subroutine:    btnClear_Click
    'Programmer:    Ryan Isaacson / Munchinator6354
    'Date:          October 26, 2020
    'Description:   Clears the board and resets the game.
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        radRock.Checked = True
        radPaper.Checked = False
        radScissors.Checked = False
        picComputerPicture.Image = Nothing
        picHumanPicture.Image = Nothing
        lblWinnerOutput.Text = ""
        lblWinnerText.Hide()
        btnRun.Focus()
    End Sub
    '---------------------------------------------------------------------------------------------------------------
    'Subroutine:    btnExit_Click
    'Programmer:    Ryan Isaacson / Munchinator6354
    'Date:          October 26, 2020
    'Description:   Exits the Program
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
