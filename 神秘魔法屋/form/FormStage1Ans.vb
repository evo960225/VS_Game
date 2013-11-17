Public Class FormstageAns1
    'radio options
    Private Const OpaddX As Integer = 30        '宣告常數-redio左側預留空格
    Private Const OpaddY As Integer = 50        '宣告常數-redio上側預留空格
    Private Const OpW As Integer = 60           '宣告常數-redio高
    Private Const OpH As Integer = 30           '宣告常數-redio寬
    'formShow timer
    Private Const timShowOpAdd = 0.25
    Private Const timShowIntFPS = 24
    'formHide timer
    Private Const timHideOpAdd = -0.25
    Private Const timHideIntFPS = 24
    Private op(AnsArr.Length - 1) As RadioButton       'radio陣列

    Private Sub FormstageAns1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call optionAdd()
        'My.Computer.Audio.Play("C:\Waterfall.wav",
        'AudioPlayMode.WaitToComplete)
        op(0).Checked = True                    '第一選項表示已選
        Call timerShowAdd()
    End Sub

    Private Sub ButEnt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButEnt.Click
        Me.Close()
        For i = 0 To AnsArr.Length - 1
            If op(i).Checked Then ans1 = i : Call stage1RecallAns()
        Next
    End Sub

    Private Sub optionAdd()
        Dim i As UShort
        For i = 0 To AnsArr.Length - 1
            '------------------------------設定動態radio屬性
            op(i) = New RadioButton With { _
                                        .Name = "re" & i,
                                        .Size = New Point(OpW, OpH),
                                        .Location = New Point(OpaddX, OpaddY + OpH * i),
                                        .Text = AnsArr(i)
                                    }
            Me.Controls.Add(op(i))
        Next
    End Sub
    Private Sub timerShowAdd()
        Dim tim As New Timer With {
            .Interval = 1000 / timShowIntFPS,
            .Enabled = True}
        AddHandler tim.Tick, AddressOf timerFormShow

    End Sub

    Private Sub timerFormShow(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Static Al As Double = 0
        If Al > 1 Then Al = 1 : sender.dispose()
        Al += timShowOpAdd
        Me.Opacity = Al
    End Sub
End Class