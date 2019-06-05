Public Class frmLVL2
    Dim row1 As New Collection
    Dim row2 As New Collection
    'Dim laser As New Collection
    Dim lasers As Byte = 20
    Dim score As Integer
    Dim i As Byte = 1
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

        lblScore.Text = score
    End Sub

    Private Sub frmLVL2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Left Then
            picShip.Location = New Point(picShip.Location.X - 5, 610) 'moving the ship with the left arrow key
        End If

        If e.KeyCode = Keys.Right Then
            picShip.Location = New Point(picShip.Location.X + 5, 610) 'moving the ship with the right arrow key
        End If

        If e.KeyCode = Keys.Up Then
            PictureBox1.Top = picShip.Top
            PictureBox1.Left = picShip.Left + 15
            Do
                PictureBox1.Top -= 10
                'laser(i).top -= 10
            Loop While (PictureBox1.Top > 5)
        End If
    End Sub

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        Static change As Boolean
        Static counter As Integer

        For i As Byte = 1 To 6

            If PictureBox1.Bounds.IntersectsWith(row1(i).Bounds) Or PictureBox1.Bounds.IntersectsWith(row2(i).bounds) Then
                PictureBox1.Top = picShip.Top
                PictureBox1.Left = picShip.Left + 15
                timerL.Enabled = False
            End If

            If PictureBox1.Bounds.IntersectsWith(row1(i).bounds) Then
                row1(i).visible = False
                score += 10
            ElseIf PictureBox1.Bounds.IntersectsWith(row2(i).bounds) Then
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

            If counter Mod 2 Then
                row1(i).top += 1
                row2(i).top += 1
            End If
        Next
    End Sub
End Class