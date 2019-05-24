Public Class level1
    Private Sub btnNextLVL_Click(sender As Object, e As EventArgs) Handles btnNextLVL.Click
        Form5.Show() 'showing the game form
        Me.Hide() 'hiding the main form
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Dim response As Byte 'declaring local variable
        response = MsgBox("Are you sure you want to exit?", vbYesNo) 'message box which gives the user a choice to close the program
        If response = vbYes Then 'checks if the user selected yes or no
            Close() 'closes the program
        End If
    End Sub
End Class