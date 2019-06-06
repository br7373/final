Public Class frmLVL1
    'declaring class level variables (can be used all throughout the form)
    Dim row1 As New Collection 'collection for the top row of invaders
    Dim row2 As New Collection 'collection for the bottom row of invaders
    Dim score As Integer 'holds score
    Dim lasers(-1) As laser 'declaring array
    Dim counting As Integer 'counter variable used for lasers

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'adding invaders to collections
        row1.Add(picT1)
        row1.Add(picT2)
        row1.Add(picT3)
        row1.Add(picT4)
        row1.Add(picT5)
        row1.Add(picT6)

        'adding invaders to collections
        row2.Add(picB1)
        row2.Add(picB2)
        row2.Add(picB3)
        row2.Add(picB4)
        row2.Add(picB5)
        row2.Add(picB6)

        tmrTime.Start() 'starting timer that displays minutes : seconds to the user
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

    Private Sub frmLVL1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Left Then
            picShip.Location = New Point(picShip.Location.X - 5, 541) 'moving the ship with the left arrow key
        End If

        If e.KeyCode = Keys.Right Then
            picShip.Location = New Point(picShip.Location.X + 5, 541) 'moving the ship with the right arrow key
        End If

        If e.KeyCode = Keys.Up Then
            ReDim Preserve lasers(counting)
            Dim laser1 As New laser
            Controls.Add(laser1) 'adding laser to the form
            lasers(counting) = laser1 'using counter variable to indicate place in the array
            counting += 1 'adding to the counter variable
            tmrLaser.Enabled = True

            For x As Byte = 0 To lasers.Length - 1 'arrays start at 0 while collections start at 1
                For i As Byte = 1 To 6 'using second loop to loop through rows
                    'two loops are used because the rows are apart of a collection while the lasers are apart of an array
                    If row1(i).Bounds.IntersectsWith(lasers(x).Bounds) Then
                        row1(i).Visible = False 'making the invader that was struck with the laser invisible
                        score += 10 'adding 10 to the user's score
                    End If
                    If row2(i).Bounds.IntersectsWith(lasers(x).Bounds) Then
                        row2(i).Visible = False 'making the invader that was struck with the laser invisible
                        score += 30 'adding 30 to the user's score
                    End If
                Next
            Next
            lblScore.Text = score 'displaying score to the user
        End If
    End Sub

    Private Sub TmrLaser_Tick(sender As Object, e As EventArgs) Handles tmrLaser.Tick
        For i As Byte = 0 To lasers.Length - 1
            lasers(i).float() 'calling float function from the laser class (laser.vb)
        Next
    End Sub
    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        Static change As Boolean 'static change boolean variable used for indicating the direction the rows should be traveling
        Static counter As Byte
        Static win As Boolean

        For i As Byte = 1 To 6

            If row1(i).visible = False And row2(i).visible = False Then
                win = True
            End If

            'looping through the two row collections to check for intersections with the right and left boundaries
            If row1(i).Bounds.IntersectsWith(lblRight.Bounds) Then
                change = True 'change boolean variable is used to indicate the direction the row should be traveling
                counter += 1 'counter is used for making the rows move down
            ElseIf row1(i).Bounds.IntersectsWith(lblLeft.Bounds) Then
                change = False
                counter += 1
            End If

            'makes the rows bounce back and forth
            If change = False Then
                row1(i).Left += 5 'right
                row2(i).left -= 5 'left 
            ElseIf change = True Then
                row1(i).Left -= 5
                row2(i).left += 5
            End If

            If counter Mod 8 Then 'everytime counter reaches 4 the rows go down
                row1(i).top += 1 'down
                row2(i).top += 1 'down
            End If
        Next

        If win = True Then
            Dim response As String
            response = MsgBox("You win!", vbYesNo)
            If response = vbYes Then
                winner.Show()
                Me.Hide()
            Else
                main.Show()
                Me.Hide()
            End If

        End If
    End Sub

    Private Sub TmrTime_Tick(sender As Object, e As EventArgs) Handles tmrTime.Tick
        Dim time As Integer
        Dim seconds As Integer
        Dim minutes As Integer

        time = lblSec.Text + 1

        seconds = time Mod 60

        If seconds >= 60 Then 'when the counter hits 60, 1 gets added to minutes and the seconds counter gets reset to 0
            minutes += 1
            seconds = 0
        End If

        lblMin.Text = Format(minutes, "00") & " :"
        'puts time into minutes : seconds form
        lblSec.Text = Format(seconds, "00")
        'displaying time to the user

        'https://docs.microsoft.com/en-us/office/vba/language/reference/user-interface-help/format-function-visual-basic-for-applications

    End Sub
End Class