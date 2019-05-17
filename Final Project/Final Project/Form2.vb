Public Class Form2
    Dim t0p As New Collection
    Dim bot As New Collection

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        t0p.Add(picT1)
        t0p.Add(picT2)
        t0p.Add(picT3)

        bot.Add(picB1)
        bot.Add(picB2)
    End Sub
    Private Sub RestartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestartToolStripMenuItem.Click
        Dim message As Byte 'declaring local variable
        message = MsgBox("Are you sure you want to restart?", vbYesNo) 'message box
        If message = vbYes Then 'if the user chooses yes, the program will restart
            Application.Restart() 'restart
        End If
    End Sub

    Private Sub CloseGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseGameToolStripMenuItem.Click
        Dim response As Byte 'declaring local variable
        response = MsgBox("Are you sure you want to exit?", vbYesNo) 'message box which gives the user a choice to close the program
        If response = vbYes Then 'checks if the user selected yes or no
            Close() 'closes the program
        End If
    End Sub

    Private Sub Form2_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Left Then
            picShip.Location = New Point(picShip.Location.X - 5, 300)
        End If
        If e.KeyCode = Keys.Right Then
            picShip.Location = New Point(picShip.Location.X + 5, 300)
        End If
    End Sub

    Private Sub reset()
        picShip.Location = New Point(250, 300)
    End Sub

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        Dim change1 As Boolean

        If change1 = False Then
            picT1.Left = picT1.Left + 5
            picT2.Left = picT2.Left + 5
            picT3.Left = picT3.Left + 5
        End If

        If change1 = True Then
            lbl1.Left = lbl1.Left - 7.5
        End If

        If lbl1.Bounds.IntersectsWith(lblRight.Bounds) Then
            change1 = True
        End If

        If lbl1.Bounds.IntersectsWith(lblLeft.Bounds) Then
            change1 = False
        End If
    End Sub
End Class