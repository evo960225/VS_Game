Public Class pic

    Private Sub pic_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        Me.Opacity = 1
    End Sub

    Private Sub pic_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Pic1.Location = New Point((Me.Width - picBigSizeW) / 2 - 10, (Me.Height - picBigSizeH) / 2 - 20)
        Pic1.Size = New Size(picBigSizeW, picBigSizeH)
        Pic1.Image = bmpMainPic.Clone(New Rectangle(picAddX, picAddY, picBigSizeW, picBigSizeH), bmpMainPic.PixelFormat)
    End Sub

    Private Sub pic_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
        Me.Opacity = 0.85
    End Sub

End Class