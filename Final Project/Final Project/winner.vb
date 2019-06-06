Public Class winner
    Private Sub Winner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblPrint.Text = "Congratulations! You finished with a score of " & score & " and a time of " & Format(minutes, "00") & ":" & Format(seconds, "00") & "!"
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim response As Byte 'declaring local variable
        response = MsgBox("Are you sure you want to exit?", vbYesNo) 'message box which gives the user a choice to close the program
        If response = vbYes Then 'checks if the user selected yes or no
            Close() 'closes the program
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim filename As String
        Dim filenum As Integer
        SaveFileDialog1.Title = "Save File"
        SaveFileDialog1.ShowDialog()
        filename = SaveFileDialog1.FileName
        SaveFileDialog1.DefaultExt = "txt"
        filenum = FreeFile()
        FileOpen(filenum, filename, OpenMode.Append)
        WriteLine(filenum, score, minutes, seconds)
        FileClose(filenum)
    End Sub
End Class