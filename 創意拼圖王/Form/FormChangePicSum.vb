Public Class FormChangePicSum

    Private Sub FormChangePicSum_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        NumUpDown1.Value = picXSum
        NumUpDown2.Value = picYSum
    End Sub

    Private Sub NumUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumUpDown1.ValueChanged
        If NumUpDown1.Value = 2 And NumUpDown2.Value = 2 Then NumUpDown2.Value = 3
    End Sub

    Private Sub NumUpDown2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumUpDown2.ValueChanged
        If NumUpDown1.Value = 2 And NumUpDown2.Value = 2 Then NumUpDown1.Value = 3
    End Sub

    Private Sub butEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butEnter.Click
        picXSum = NumUpDown1.Value
        picYSum = NumUpDown2.Value
        Call FormMain.init()
        Me.Close()
    End Sub
End Class