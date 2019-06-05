Public Class frmLVL1
    Dim row1 As New Collection
    Dim row2 As New Collection
    Dim laser As New Collection
    Dim score As Integer

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'adding invaders to collections
        row1.Add(picT1)
        row1.Add(picT2)
        row1.Add(picT3)

        'adding invaders to collections
        row2.Add(picB1)
        row2.Add(picB2)
        row2.Add(picB3)

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
        End If

        If e.KeyCode = Keys.Right Then
            picShip.Location = New Point(picShip.Location.X + 5, 421) 'moving the ship with the right arrow key
        End If

        If e.KeyCode = Keys.Up Then
            If e.KeyCode = Keys.Up Then
                picLaser.Top = picShip.Top
                picLaser.Left = picShip.Left + 15
                'Do
                '
                picLaser.Top += 10
                'Loop While (picLaser.Top > 5)



            End If
        End If
    End Sub

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        Static change As Boolean
        Static counter As Byte
        Dim collision1 As Boolean

        'If picB1.Bounds.IntersectsWith(picLaser.Bounds) Then
        '    picB1.Visible = False
        '    score += 30
        'End If

        'If picB2.Bounds.IntersectsWith(picLaser.Bounds) Then
        '    picB2.Visible = False
        '    score += 30
        'End If

        If picLaser.Bounds.IntersectsWith(picB3.Bounds) Then
            picB3.Visible = False
            score += 30
        End If


        'If picLaser.Bounds.IntersectsWith(row2(i).bounds) Then
        '    row2(i).visible = False
        '    score += 30
        'End If
        lblScore.Text = score
        ' Next
        For i As Byte = 1 To 3

            If row1(i).Bounds.IntersectsWith(lblRight.Bounds) Then
                change = True
                counter += 1
            ElseIf row1(i).Bounds.IntersectsWith(lblLeft.Bounds) Then
                change = False
                counter += 1
            End If

            'makes the rows bounce back and forth
            If change = False Then
                row1(i).Left += 5
                row2(i).left -= 5
            ElseIf change = True Then
                row1(i).Left -= 5
                row2(i).left += 5
            End If

            If counter Mod 4 Then 'everytime counter reaches 4 the rows go down
                row1(i).top += 1
                row2(i).top += 1
            End If
        Next
    End Sub
End Class