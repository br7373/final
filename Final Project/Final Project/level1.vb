Public Class frmLVL1
    Dim row1 As New Collection
    Dim row2 As New Collection
    Dim laser As New Collection
    Dim score As Integer
    Dim lasers As Byte

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timerL.Enabled = False 'disabling the laser timer 
        'timerLaser.Enabled = False

        'adding invaders to collections
        row1.Add(picT1)
        row1.Add(picT2)
        row1.Add(picT3)

        'adding invaders to collections
        row2.Add(picB1)
        row2.Add(picB2)
        row2.Add(picB3)

        lblScore.Text = score 'displaying the score to the user     black = 10pts purple = 30pts

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

    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Left Then
            picShip.Location = New Point(picShip.Location.X - 5, 421) 'moving the ship with the left arrow key
            picLaser.Top = picShip.Top
            picLaser.Left = picShip.Left + 15
        End If
        If e.KeyCode = Keys.Right Then
            picShip.Location = New Point(picShip.Location.X + 5, 421) 'moving the ship with the right arrow key
            picLaser.Top = picShip.Top
            picLaser.Left = picShip.Left + 15
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
        Static counter As Byte

        For i As Byte = 1 To 3

            If picLaser.Bounds.IntersectsWith(row1(i).Bounds) Or picLaser.Bounds.IntersectsWith(row2(i).bounds) Then
                picLaser.Top = picShip.Top
                picLaser.Left = picShip.Left + 15
                timerL.Enabled = False
            End If

            If picLaser.Bounds.IntersectsWith(row1(i).bounds) Then
                row1(i).visible = False
                score += 10
            ElseIf picLaser.Bounds.IntersectsWith(row2(i).bounds) Then
                row2(i).visible = False
                score += 30
            End If

            If row1(i).Bounds.IntersectsWith(lblRight.Bounds) Then
                change = True
                counter += 1
            ElseIf row1(i).Bounds.IntersectsWith(lblLeft.Bounds) Then
                change = False
                counter += 1
            End If

            If change = False Then
                row1(i).Left += 5
                row2(i).left -= 5
            ElseIf change = True Then
                row1(i).Left -= 5
                row2(i).left += 5
            End If

            If counter Mod 4 Then
                row1(i).top += 1
                row2(i).top += 1
            End If

        Next


    End Sub
    Private Sub TimerL_Tick(sender As Object, e As EventArgs) Handles timerL.Tick
        If picLaser.Visible = True Then
            picLaser.Top -= 1
            ' If picLaser.Top <= 0 Then
            ' picLaser.Visible = False
            'End If
        End If
    End Sub
End Class