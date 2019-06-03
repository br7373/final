Public Class frmLVL2
    Dim row1 As New Collection
    Dim row2 As New Collection
    Private Sub FrmLVL2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        CreateGraphics.FillRectangle(New SolidBrush(Color.Green), 10, 10, 10, 10)
    End Sub

    Private Sub frmLVL2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Left Then
            picShip.Location = New Point(picShip.Location.X - 5, 421) 'moving the ship with the left arrow key
        End If
        If e.KeyCode = Keys.Right Then
            picShip.Location = New Point(picShip.Location.X + 5, 421) 'moving the ship with the right arrow key
        End If
    End Sub

End Class