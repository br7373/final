Public Class frmLVL2
    Dim row1 As New Collection
    Dim row2 As New Collection
    Dim laser As New Collection
    Dim lasers As Byte = 20
    '   Dim c As Integer
    'Dim lasercount As Byte

    Private Sub FrmLVL2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timerL.Enabled = False


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

        laser.Add(PictureBox1)
        laser.Add(PictureBox2)
        laser.Add(PictureBox3)
        laser.Add(PictureBox4)
        laser.Add(PictureBox5)
        laser.Add(PictureBox6)
        laser.Add(PictureBox7)
        laser.Add(PictureBox8)
        laser.Add(PictureBox9)
        laser.Add(PictureBox10)
        laser.Add(PictureBox11)
        laser.Add(PictureBox12)
        laser.Add(PictureBox13)
        laser.Add(PictureBox14)
        laser.Add(PictureBox15)
        laser.Add(PictureBox16)
        laser.Add(PictureBox17)
        laser.Add(PictureBox18)
        laser.Add(PictureBox19)
        laser.Add(PictureBox20)

        lblTest.Text = lasers
    End Sub

    Private Sub frmLVL2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        '  lasers = 20 - c

        'CreateGraphics.FillRectangle(New SolidBrush(Color.Green), 10, 10, 10, 10)

        If e.KeyCode = Keys.Left Then
            picShip.Location = New Point(picShip.Location.X - 5, 610) 'moving the ship with the left arrow key
        End If

        If e.KeyCode = Keys.Right Then
            picShip.Location = New Point(picShip.Location.X + 5, 610) 'moving the ship with the right arrow key
        End If

        If e.KeyCode = Keys.Up Then
            For i As Byte = 1 To 20
                If laser(i).Visible = True Then
                    laser(i).Top = picShip.Top
                    laser(i).Left = picShip.Left + 15
                    timerL.Enabled = True
                    lasers -= 1
                End If
            Next
        End If
    End Sub

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        Static change As Boolean
        Static counter As Integer
        Static score As Integer

        For i As Byte = 1 To 6

            For x As Byte = 1 To 20
                If laser(x).Bounds.IntersectsWith(row1(i).Bounds) Or laser(x).Bounds.IntersectsWith(row2(i).bounds) Then
                    laser(x).Top = picShip.Top
                    laser(x).Left = picShip.Left + 15
                    timerL.Enabled = False
                End If

                If laser(x).Bounds.IntersectsWith(row1(i).bounds) Then
                    row1(i).visible = False
                    score += 10
                ElseIf laser(x).Bounds.IntersectsWith(row2(i).bounds) Then
                    row2(i).visible = False
                    score += 30
                End If
            Next

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

            If counter Mod 2 Then
                row1(i).top += 1
                row2(i).top += 1
            End If

        Next

    End Sub

    Private Sub TimerL_Tick(sender As Object, e As EventArgs) Handles timerL.Tick
        For i As Byte = 1 To 20
            If laser(i).Visible = True Then
                laser(i).Top -= 1
            End If
        Next
    End Sub
End Class