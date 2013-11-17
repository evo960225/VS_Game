Public Class FormMenage

    Private Sub Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub ButOpening_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButOpening.Click
        FormGameMain.Controls.Clear()
        Call StartOpen(FormGameMain)
    End Sub

    Private Sub ButMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButMain.Click
        FormGameMain.Controls.Clear()
        Call StartStageInit()
    End Sub

    Private Sub ButStage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButStage1.Click
        FormGameMain.Controls.Clear()
        Call gameStart()
    End Sub


    Private Sub ButStage2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButStage2.Click
        FormGameMain.Controls.Clear()
        Call gameStart()
        Call stage2Start()
    End Sub

    Private Sub ButStage3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButStage3.Click
        FormGameMain.Controls.Clear()
        Call Stage3Start()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call Men()
    End Sub
End Class