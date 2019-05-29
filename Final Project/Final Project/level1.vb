Public Class Form2
    Dim row1 As New Collection
    Dim row2 As New Collection
    Dim score As Integer
    Dim lives As Byte = 2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        timerL.Enabled = False 'disabling the laser timer 

        'adding invaders to collections
        row1.Add(picT1)
        row1.Add(picT2)
        row1.Add(picT3)
        row1.Add(picT4)
        row1.Add(picT5)
        row1.Add(picT6)

        row2.Add(picB1)
        row2.Add(picB2)
        row2.Add(picB3)
        row2.Add(picB4)
        row2.Add(picB5)
        row2.Add(picB6)

        lblScore.Text = score 'displaying the score to the user     black = 10pts purple = 30pts
        lblLifeCount.Text = lives 'displaying amount of lives to the user
    End Sub
    Private Sub scores()
        For i As Byte = 1 To 6
            If picLaser.Bounds.IntersectsWith(row2(i).bounds) Then
                score += 30
            End If
            If picLaser.Bounds.IntersectsWith(row1(i).bounds) Then
                score += 10
            End If
        Next
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

    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Left Then
            picShip.Location = New Point(picShip.Location.X - 5, 421) 'moving the ship with the left arrow key
        End If
        If e.KeyCode = Keys.Right Then
            picShip.Location = New Point(picShip.Location.X + 5, 421) 'moving the ship with the right arrow key
        End If

        If e.KeyCode = Keys.Up Then
            If picLaser.Visible = True Then
                picLaser.Top = picShip.Top
                picLaser.Left = picShip.Left + 15
                timerL.Enabled = True
            End If
        End If
    End Sub

    Private Sub reset()
        picShip.Location = New Point(341, 421)
    End Sub

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        Static change As Boolean

        scores()

        'If row1(i).Bounds.IntersectsWith(lblRight.Bounds) Then
        '    change = True
        'ElseIf row1(i).Bounds.IntersectsWith(lblLeft.Bounds) Then
        '    change = False
        'End If
        'If picT1.Bounds.IntersectsWith(lblLeft.Bounds) Or picT6.Bounds.IntersectsWith(lblRight.Bounds) Then
        '    change = False
        'ElseIf picB6.Bounds.IntersectsWith(lblRight.Bounds) Or picB1.Bounds.IntersectsWith(lblLeft.Bounds) Then
        '    change = True
        'End If

        If picLaser.Bounds.IntersectsWith(picShip.Bounds) Then
            reset()
            lives -= 1
            MsgBox("You have " & lives & "left!")
        End If


        For i As Byte = 1 To 6
            If row1(i).Bounds.IntersectsWith(lblRight.Bounds) Then
                change = True
            ElseIf row1(i).Bounds.IntersectsWith(lblLeft.Bounds) Then
                change = False
            End If
            If change = False Then
                row1(i).Left += 5
                row2(i).left -= 5
            ElseIf change = True Then
                row1(i).Left -= 5
                row2(i).left += 5
            End If
        Next

        If change = True Then
            lblTest.Text = "True"
        Else
            lblTest.Text = "False"
        End If
    End Sub
    Private Sub TimerL_Tick(sender As Object, e As EventArgs) Handles timerL.Tick
        If picLaser.Visible = True Then
            picLaser.Top -= 1
            If picLaser.Top <= 0 Then
                picLaser.Visible = False
            End If
        End If
    End Sub
End Class