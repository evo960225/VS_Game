Imports System.Windows.Forms

Public Class 提示1

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Dialog1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If stage = 1 Then Label1.Text = "請點選方塊顯示方塊下的圖" & vbCrLf & "並猜出方塊下的碎片拼圖為某物"
        If stage = 3 Then
            Me.Size = New Size(730, 250)
            Label1.Font = New Font("微軟正黑體", 13, FontStyle.Bold)
            OK_Button.Location = New Point(630, 180)
            Label1.Text = "玩家及電腦個有5張牌" & vbCrLf _
                     & "所有牌的元素分為'水'、'火'、'土' 另外還包含的數字1~5" & vbCrLf _
                     & "遊戲開始每回合，雙方各出一張牌，並比對雙方的元素->[水勝火、火勝木、木勝水]" & vbCrLf _
                     & "如遇到同元素(例:水對水)則以數字大小比較" & vbCrLf _
                     & "(例: 玩家-水5 > 電腦-水3 ，則玩家得1點)" & vbCrLf _
                     & "贏方也可繼續持有原本出的那張卡" & vbCrLf _
                      & "最後(得點+剩餘牌數)最多者獲勝~!!"
            Me.StartPosition = FormStartPosition.CenterScreen
        End If

    End Sub
End Class
