Public Class laser
    Inherits PictureBox
    Public Sub New()
        Me.Size = New Size(10, 30)
        Me.Location = frmLVL1.picShip.Location
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Me.BackgroundImage = My.Resources.laser
    End Sub
    Public Sub float()
        Me.Top -= 10
    End Sub
End Class
