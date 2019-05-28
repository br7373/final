Public Class Form2
    Dim row1 As New Collection
    Dim row2 As New Collection

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim score As Integer
        Dim lives As Byte

        'row1.Add(picT1)
        'row1.Add(picT2)
        'row1.Add(picT3)
        'row1.Add(picT4)
        'row1.Add(picT5)
        'row1.Add(picT6)

        'row2.Add(picB1)
        'row2.Add(picB2)
        'row2.Add(picB3)
        'row2.Add(picB4)
        'row2.Add(picB5)
        'row2.Add(picB6)


        lblScore.Text = score
        lblLifeCount.Text = lives

        timerL.Enabled = False

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
            picShip.Location = New Point(picShip.Location.X - 5, 421)
        End If
        If e.KeyCode = Keys.Right Then
            picShip.Location = New Point(picShip.Location.X + 5, 421)
        End If


        If e.KeyCode = Keys.Up Then
            If picLaser.Visible = False Then
                picLaser.Top = picShip.Top
                picLaser.Left = picShip.Left
                timerL.Enabled = True
            End If
        End If
    End Sub

    Private Sub reset()
        picShip.Location = New Point(341, 421)
    End Sub

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        Dim change1 As Boolean = True

        If change1 = True Then
            picT1.Left -= 5
        ElseIf change1 = False Then
            picT1.Left += 5
        End If

        If picT1.Bounds.IntersectsWith(lblRight.Bounds) Then
            change1 = False
            picT1.Top += 2.5
        End If

        If picT1.Bounds.IntersectsWith(lblLeft.Bounds) Then
            change1 = True
            picT1.Top += 2.5
        End If



        If change1 = True Then
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



'If picT1.Bounds.IntersectsWith(lblRight.Bounds) Then
'picT1.Left += 5
'picT2.Left += 5
'picT3.Left += 5
'picT4.Left += 5
'picT5.Left += 5
'picT6.Left += 5
'End If
'If picB6.Bounds.IntersectsWith(lblLeft.Bounds) Then
'picB1.Left += 5
'picB2.Left += 5
'picB3.Left += 5
'picB4.Left += 5
'picB5.Left += 5
'picB6.Left += 5
'End If

'For i As Byte = 1 To 6
''If row1(i).Bounds.IntersectsWith(lblRight.Bounds) Or row2(i).bounds.intersectswith(lblRight.Bounds) Then
''    change1 = True
''    '  row1(i).top = row1(i).top + 2.5
''    '   row2(i).top = row2(i).top + 2.5
''ElseIf row1(i).Bounds.IntersectsWith(lblLeft.Bounds) Or row2(i).bounds.intersectswith(lblLeft.Bounds) Then
''    change1 = False
''    '   row1(i).top = row1(i).top + 2.5
''    '   row2(i).top = row2(i).top + 2.5
''End If
'If change1 = False Then
'row1(i).Left = row1(i).left + 5
'row2(i).left = row2(i).left - 5
'change1 = False
'ElseIf change1 = True Then
'row1(i).Left = row1(i).left - 5
'row2(i).left = row2(i).left + 5
'change1 = True
'End If
'Next