
Public Class FormMain
    Public Const AddPicX = 30                       '圖像與表單的左邊界
    Public Const AddPicY = 50                       '圖像與表單的上邊界

    'Start
    Private Sub FormMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Start()
    End Sub
    Public Sub init()       '**變更設定**初始化
        Dim checkBmp As Boolean

        If bmpMainPic.Width >= picBigSizeW And bmpMainPic.Height >= picBigSizeH Then
            checkBmp = True
        ElseIf bmpMainPic.Width >= 300 And bmpMainPic.Height >= 300 Then
            picBigSizeW = (bmpMainPic.Width \ 100) * 100
            picBigSizeH = (bmpMainPic.Height \ 100) * 100
            Call toolItemCheck(寬ToolStripMenuItem, picBigSizeW.ToString, picBigSizeW)
            Call toolItemCheck(長ToolStripMenuItem, picBigSizeH.ToString, picBigSizeH)
            checkBmp = True
        Else
            MsgBox("圖片過小!!", , "警告")
        End If
        '/////////////////////////////////////////////////////////////////////////////////////
        If checkBmp Then

            Dim i As Integer

            If 新遊戲ToolStripMenuItem.Enabled = True Then clearPic(Me, picArr)
            '//*********************PicSize
            picSizeH = picBigSizeH / picYSum                       '圖像高度
            picSizeW = picBigSizeW / picXSum                         '圖像寬度
            picSum = picXSum * picYSum

            Call picShowLoc(picAlg)

            ReDim picArr(picSum - 1)
            ReDim picNaToLo(picSum - 1)
            ReDim picLoToNa(picSum - 1)

            '//****************pic
            For i = 0 To picSum - 2
                bmpTmp = bmpMainPic.Clone(New RectangleF(picAddX + picSizeW * (i Mod picXSum), picAddY + picSizeH * (i \ picXSum), picSizeW, picSizeH), bmpMainPic.PixelFormat)
                picArr(i) = New PictureBox With {
                    .Name = "pic" & CStr(i),
                    .Location = New Point(AddPicX + picSizeW * (i Mod picXSum), AddPicY + picSizeH * (i \ picXSum)),
                    .Size = New Size(picSizeW, picSizeH),
                    .Image = bmpTmp
                    }
                Me.Controls.Add(picArr(i))
                AddHandler picArr(i).MouseDown, AddressOf picMouseDown
                AddHandler picArr(i).MouseMove, AddressOf picMouseMove
                AddHandler picArr(i).MouseUp, AddressOf picMouseUp
                picNaToLo(i) = i                '圖像名稱對應位置設值,且照順序
                picLoToNa(i) = i               '圖像位置對應名稱設值,且照順序
            Next
            picNaToLo(i) = i                'picsum-1圖像名稱對應位置設值,且照順序
            picLoToNa(i) = i               'picsum-1圖像位置對應名稱設值,且照順序

            '//*************mini
            Me.Controls.Remove(miniPic)
            Call addMiniPic()
            '//*************lab
            Call addLabMiniPicInfo()
            Call addLabTimerTime()
            '//*************其他
            gameStart = False
            TimerGame.Enabled = False
            反白ToolStripMenuItem.Checked = False
            If Microsoft.VisualBasic.Right(bmpMainAd, 3) = "bmp" Then
                反白ToolStripMenuItem.Enabled = False
                反白ToolStripMenuItem.Text = "負片(bmp檔無法執行)"
            Else
                反白ToolStripMenuItem.Enabled = True
                反白ToolStripMenuItem.Text = "負片"
            End If
            '//

            新遊戲ToolStripMenuItem.Enabled = True
        Else
            新遊戲ToolStripMenuItem.Enabled = False
        End If

    End Sub
    'PicMove
    Public Sub picMouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim point As POINTAPI
        GetCursorPos(point)
        mouCliX = point.x
        mouCliY = point.y
        picCliX = DirectCast(sender, System.Object).Location.X
        picCliY = DirectCast(sender, System.Object).Location.y
        picCli = True
    End Sub
    Public Sub picMouseMove(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If picCli = True Then
            Dim point As POINTAPI
            Dim name As Integer
            Dim loc As Integer
            Dim senX, senY As Integer

            GetCursorPos(point)
            posX = point.x
            posY = point.y
            senX = DirectCast(sender, System.Object).location.x
            senY = DirectCast(sender, System.Object).location.y
            name = Mid(sender.name, 4)
            loc = picNaToLo(name)
            '
            If loc >= picXSum Then
                If picLoToNa(loc - picXSum) = picSum - 1 And posY < mouCliY Then   '------------*****0
                    If picCliY - senY <= picSizeH Then
                        sender.location = New Point(picCliX, picCliY + (posY - mouCliY))
                    End If
                End If
            End If
            If loc Mod picXSum <> picXSum - 1 Then
                If picLoToNa(loc + 1) = picSum - 1 And posX > mouCliX Then   '------------*****1
                    If senX - picCliX <= picSizeW Then
                        sender.location = New Point(picCliX + (posX - mouCliX), picCliY)
                    End If
                End If
            End If
            If loc < picXSum * (picYSum - 1) Then
                If picLoToNa(loc + picXSum) = picSum - 1 And posY > mouCliY Then  '------------*****2
                    If senY - picCliY <= picSizeH Then
                        sender.location = New Point(picCliX, picCliY + (posY - mouCliY))
                    End If
                End If
            End If
            If loc Mod picXSum <> 0 Then
                If picLoToNa(loc - 1) = picSum - 1 And posX < mouCliX Then   '------------*****3
                    If picCliX - senX <= picSizeW Then
                        sender.location = New Point(picCliX + (posX - mouCliX), picCliY)
                    End If
                End If
            End If
        End If
    End Sub
    Public Sub picMouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If picCli = True Then
            Dim name, loc, x, y As Integer
            Dim n As Short = -1
            name = Mid(sender.name, 4)
            loc = picNaToLo(name)
            x = DirectCast(sender, System.Object).location.x
            y = DirectCast(sender, System.Object).location.y
            If picCliY - y > picSizeH / 2 Then
                n = 0
            ElseIf x - picCliX > picSizeW / 2 Then
                n = 1
            ElseIf y - picCliY > picSizeH / 2 Then
                n = 2
            ElseIf picCliX - x > picSizeW / 2 Then
                n = 3
            End If
            Call picMove(n, name, loc)

            If picNaToLo(picSum - 1) = picSum - 1 And gameStart Then Call picCheck(picNaToLo, picSum)
            loc = picNaToLo(name)
            x = AddPicX + (loc Mod picXSum) * picSizeW
            y = AddPicY + (loc \ picXSum) * picSizeH
            sender.location = New Point(x, y)

            If gameStart And TimerGame.Enabled = False Then TimerGame.Enabled = True

            picCli = False
        End If
    End Sub

    Private Sub 新遊戲ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 新遊戲ToolStripMenuItem.Click
        Call RndPicMove()
        gameStart = True
        gameOverTimes = 0
        TimerGame.Enabled = gameStart
    End Sub
    'tool
    Private Sub ToolMenuX_Change_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolMenuX300.Click, ToolMenuX400.Click, ToolMenuX500.Click, ToolMenuX600.Click, ToolMenuX700.Click, ToolMenuX800.Click
        Call toolItemCheck(寬ToolStripMenuItem, sender.ToString, picBigSizeW)
        Call init()
    End Sub
    Private Sub ToolMenuY_Change_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolMenuY300.Click, ToolMenuY400.Click, ToolMenuY500.Click, ToolMenuY600.Click
        Call toolItemCheck(長ToolStripMenuItem, sender.ToString, picBigSizeH)
        Call init()
    End Sub
    Private Sub ToolStripSum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _2x3ToolStripMenuItem.Click, _2x4ToolStripMenuItem.Click, _2x5ToolStripMenuItem.Click, _
                                                                                                       _3x3ToolStripMenuItem.Click, _3x4ToolStripMenuItem.Click, _3x5ToolStripMenuItem.Click, _
                                                                                                       _4x3ToolStripMenuItem.Click, _4x4ToolStripMenuItem.Click, _4x5ToolStripMenuItem.Click, _
                                                                                                       _5x2ToolStripMenuItem.Click, _5x3ToolStripMenuItem.Click, _5x4ToolStripMenuItem2.Click, _5x5ToolStripMenuItem.Click
        For Each a In 方塊數ToolStripMenuItem.DropDownItems
            If sender.ToString = a.ToString() Then
                a.checked = True
                Dim arr() = Split(sender.ToString, "x")
                picXSum = arr(0)
                picYSum = arr(1)
                Call init()
            Else
                a.checked = False
            End If
        Next
    End Sub
    Private Sub 其他ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 其他ToolStripMenuItem.Click
        FormChangePicSum.Show()
    End Sub
    Private Sub 變更圖片ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 變更圖片ToolStripMenuItem.Click
        Call Change_PicAdr()
    End Sub
    Private Sub 反白ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 反白ToolStripMenuItem.Click
        Dim bmpTmp As Bitmap
        Dim colors As Color
        clearPic(Me, picArr)

        bmpTmp = New Bitmap(picSizeW, picSizeH)
        For i = 0 To picSum - 2
            bmpTmp = picArr(i).Image
            For j = 0 To picSizeH - 1
                For k = 0 To picSizeW - 1
                    colors = bmpTmp.GetPixel(k, j)
                    bmpTmp.SetPixel(k, j, Color.FromArgb(255 - colors.R, 255 - colors.G, 255 - colors.B))
                Next
            Next
        Next
        Me.Controls.AddRange(picArr)

        反白ToolStripMenuItem.Checked = IIf(sender.checked = False, True, False)

    End Sub
    Private Sub 作者ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 作者ToolStripMenuItem.Click
        關於.Show()
    End Sub
    Private Sub 意見反饋ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 意見反饋ToolStripMenuItem.Click
        意見.Show()
    End Sub
    Private Sub 圖位ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 左上ToolStripMenuItem.Click, 上ToolStripMenuItem.Click, 右上ToolStripMenuItem.Click, _
                                                                                                            左ToolStripMenuItem.Click, 中ToolStripMenuItem.Click, 右ToolStripMenuItem.Click, _
                                                                                                            左下ToolStripMenuItem.Click, 下ToolStripMenuItem.Click, 右下ToolStripMenuItem.Click

        Call picShowLoc(sender.tag)
        picAlg = sender.tag
        Call init()
        Call toolItemCheck(顯示模式ToolStripMenuItem, sender.ToString, sender.ToString)
    End Sub
    Public Sub picShowLoc(ByVal tag)
        Select Case tag
            Case 0, 3, 6
                picAddX = 0
            Case 1, 4, 7
                picAddX = Int((bmpMainPic.Width - picBigSizeW) / 2)
            Case 2, 5, 8
                picAddX = bmpMainPic.Width - picBigSizeW - 1
        End Select
        Select Case tag
            Case 0, 1, 2
                picAddY = 0
            Case 3, 4, 5
                picAddY = Int((bmpMainPic.Height - picBigSizeH) / 2)
            Case 6, 7, 8
                picAddY = bmpMainPic.Height - picBigSizeH - 1
        End Select
    End Sub

    Private Sub TimerGame_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerGame.Tick
        gameOverTimes += 1
        labTimerTime.Text = "花費時間:" & vbCrLf & gameOverTimes \ 600 & ":" & (gameOverTimes \ 10 Mod 60).ToString("0#") & "," & gameOverTimes Mod 10
        If gameOverTimes = 1000000000 Then
            TimerGame.Enabled = False
        End If
    End Sub

    Private Sub form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        FileOpen(1, "Options.ini", OpenMode.Output)
        PrintLine(1, "開啟圖片->" & bmpMainAd)
        PrintLine(1, "圖片大小:" & picBigSizeW & "*" & picBigSizeH)
        PrintLine(1, "方塊數:" & picXSum & "*" & picYSum)
        FileClose(1)
    End Sub
End Class

