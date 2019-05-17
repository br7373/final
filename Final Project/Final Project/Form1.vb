Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim response As Byte 'declaring local variable
        response = MsgBox("Are you sure you want to exit?", vbYesNo) 'message box which gives the user a choice to close the program
        If response = vbYes Then 'checks if the user selected yes or no
            Close() 'closes the program
        End If
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Form2.Show() 'showing the game form
        Me.Hide() 'hiding the main form
    End Sub

    Private Sub btnHow_Click(sender As Object, e As EventArgs) Handles btnHow.Click
        Form3.Show() 'shows the how to play form
    End Sub
End Class
