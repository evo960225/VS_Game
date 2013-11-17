Public Class 意見

    Private Sub 意見_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LabReturn.Text = "不管是有關BUG或是建議" & vbCrLf & "都歡迎使用者提出問題"

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FileOpen(3, "re.txt", OpenMode.Append)
        PrintLine(3, Now & "->")
        PrintLine(3, TextBox1.Text)
        FileClose(3)
        Me.Close()
    End Sub
End Class