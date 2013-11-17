Module Start_Stage

    '控制項
    Private labTit As Label
    Private butStart As Label
    Private butExit As Label
    Private timTit As Timer
    Private timButMove As Timer
    'Label Title
    Const LabTitSizeW = 515
    Const LabTitLocX = (FormGameMain.FormGaMainSizeW - LabTitSizeW) / 2
    Const LabTitLocY = 100
    Const LabTitFontSize = 70
    'Buttom Start
    Const ButStartSizeW = 300
    Const ButStartSizeH = 80
    Const ButSatrtLocX = (FormGameMain.FormGaMainSizeW - ButStartSizeW) / 2
    Const ButSatrtLocY = 350
    Const ButSatrtFontSize = 25
    'Buttom Exit
    Const ButExitSizeW = ButStartSizeW
    Const ButExitSizeH = ButStartSizeH
    Const ButExitLocX = ButSatrtLocX
    Const ButExitLocY = 450
    Const ButExitFontSize = ButSatrtFontSize

    Const MusicPath = "Music/按鈕5.wav"

    Public Sub StartStageInit()
        ioOpening = False
        FormGameMain.BackColor = Color.AliceBlue
        FormGameMain.BackgroundImage = New Bitmap(FormBackImageAdr)
        Call StartStageObjAdd()
    End Sub
    Private Sub StartStageObjAdd()
        labTit = New Label With {.Name = "labTit",
                      .Text = "神秘魔法屋",
                      .Location = New Point(LabTitLocX, LabTitLocY),
                      .AutoSize = True,
                                 .BackColor = Color.FromArgb(170, 0, 0, 0),
                      .Font = New Font("標楷體", LabTitFontSize, FontStyle.Bold),
        .ForeColor = Color.Black
                      }
        butStart = New Label With {.Name = "butStart",
                                   .TextAlign = ContentAlignment.MiddleCenter,
                                    .Text = "開始遊戲",
                                    .Location = New Point(ButSatrtLocX, ButSatrtLocY),
                                    .Size = New Size(ButStartSizeW, ButStartSizeH),
                                    .Font = New Font("微軟正黑體", ButSatrtFontSize),
                                    .BackColor = Color.FromArgb(180, 0, 0, 0),
                                    .ForeColor = Color.White
                                   }
        butExit = New Label With {
                                    .Name = "butExit",
                                    .TextAlign = ContentAlignment.MiddleCenter,
                                    .Text = "離開遊戲",
                                    .Location = New Point(ButExitLocX, ButExitLocY),
                                    .Size = New Size(ButExitSizeW, ButExitSizeH),
                                    .Font = New Font("微軟正黑體", ButExitFontSize),
                                    .BackColor = Color.FromArgb(180, 0, 0, 0),
                                    .ForeColor = Color.White
                                    }

        timTit = New Timer With {.Enabled = True,
                                 .Interval = 100
                                }
        timButMove = New Timer With {
                                .Enabled = True,
                                .Interval = 100
                                }
        FormGameMain.Controls.Add(labTit)
        FormGameMain.Controls.Add(butStart)
        FormGameMain.Controls.Add(butExit)
        AddHandler butStart.Click, AddressOf ObjClearToStage1
        AddHandler butExit.Click, AddressOf Exitform
        AddHandler butStart.MouseMove, AddressOf but_be_cover
        AddHandler butExit.MouseMove, AddressOf but_be_cover
        AddHandler butStart.MouseLeave, AddressOf but_be_leave
        AddHandler butExit.MouseLeave, AddressOf but_be_leave
        AddHandler timTit.Tick, AddressOf LabTitMove
    End Sub
    'Move
    Private Sub LabTitMove()
        Static col As Integer = 0
        col += 10
        If col > 255 Then col = 255 : timTit.Enabled = False
        labTit.ForeColor = Color.FromArgb(col, col, col)
    End Sub
    Private Sub ButMove()
        Static col As Integer = 255
    End Sub
    'Buttom
    Private Sub but_be_cover(ByVal sender As Object, ByVal e As EventArgs)
        sender.backcolor = Color.FromArgb(255, Color.Black)
        My.Computer.Audio.Play(MusicPath)
    End Sub
    Private Sub but_be_leave(ByVal sender As Object, ByVal e As EventArgs)
        sender.backcolor = Color.FromArgb(180, Color.Black)
        My.Computer.Audio.Play(MusicPath)
    End Sub
    Private Sub ObjClearToStage1()
        FormGameMain.Controls.Clear()
        timTit.Enabled = False
        timButMove.Enabled = False
        Call gameStart()
    End Sub
    Private Sub Exitform()
        FormGameMain.Close()
    End Sub
End Module
