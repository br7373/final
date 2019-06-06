Public Class winner
    Private Sub Winner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim score As Integer
        Dim minutes As Integer
        Dim seconds As Integer
        lblPrint.Text = "Congratulations! You finished with a score of " & score & " and a time of " & Format(minutes, "00") & ":" & Format(seconds, "00") & "!"
    End Sub
End Class