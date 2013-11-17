Module ModStage2Sub
    'PicMini
    Private picMiniBoColor = Color.DimGray
    Private picMiniBoSize = 4
    Private picMiniLocX = 700
    Private picMiniLocY = 50
    Private picMiniSizeW = 200
    Private picMiniSizeH = 200
    'Mouse
    Private MouPicCli As Boolean             '宣告stage2用來確認MouseDown/MouseUP
    Private MouCliX, MouCliY As Integer      'MouseDown的位置
    Private picCliX, picCliY As Integer      '被點選pic的位置
    Private x, y As Integer                  '暫存用
    '背景
    Private labBack As Label
    Private backColor As Color = Color.Khaki
    'PicAdr
    Public picLoToNa(butXSum - 1, butYSum - 1) As Short    'stage2的圖片陣列,已存入picArr(變數)圖片控制項的位置
    Public picNaToLo(picXSum * picYSum - 1) As Integer
    Private picNESW As UShort                '方向

    'Start
    Public Sub stage2Start()
        stage = 2
        picArr(picSum - 1).Dispose()
        labInfor.Text = "現在請移動碎片，試圖" & vbCrLf & "把它組合正確吧~"
        Call AddLabBake()
        Call AddMiniPic()
        Call stage2AddHeadler()
    End Sub
    'Add 控制向 + 事件
    Public Sub AddminiPic()
        Dim bmpTmp As New Bitmap(ImageAdr & AnsArr(ansRnd) & "mini.jpg")
        '****加框****
        For i = 0 To 199
            For j = 0 To picMiniBoSize - 1
                bmpTmp.SetPixel(0 + j, i, picMiniBoColor)
                bmpTmp.SetPixel(199 - j, i, picMiniBoColor)
                bmpTmp.SetPixel(i, 0 + j, picMiniBoColor)
                bmpTmp.SetPixel(i, 199 - j, picMiniBoColor)
            Next
        Next
        '****Add****
        Dim pic As New PictureBox With {.Name = "pic",
                                        .Image = bmpTmp,
                                        .Size = New Size(picMiniSizeW, picMiniSizeH),
                                        .Location = New Point(picMiniLocX, picMiniLocY)}
        FormGameMain.Controls.Add(pic)
    End Sub
    Public Sub AddLabBake()
        labBack = New Label With {.Name = "back",
                                .Location = New Point(Addx, Addy),
                                .Size = New Size(butW * butXSum, butH * butYSum),
                                  .BackColor = backColor
                                 }
        FormGameMain.Controls.Add(labBack)
    End Sub
    Public Sub stage2AddHeadler()
        Dim i As UShort
        For i = 0 To picSum - 1
            AddHandler picArr(i).MouseDown, AddressOf picMouseDown
            AddHandler picArr(i).MouseMove, AddressOf picMouseMove
            AddHandler picArr(i).MouseUp, AddressOf picMouseUp
        Next
    End Sub
    'Mouse  事件
    Public Sub picMouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim point As POINTAPI
        GetCursorPos(point)
        MouCliX = point.x
        MouCliY = point.y
        picCliX = DirectCast(sender, System.Object).Location.X
        picCliY = DirectCast(sender, System.Object).Location.y
        MouPicCli = True
    End Sub
    Public Sub picMouseMove(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If MouPicCli = True Then
            Dim point As POINTAPI
            Dim name As Integer
            Dim loc As Integer
            Dim senX, senY As Integer

            GetCursorPos(point)
            x = point.x
            y = point.y
            senX = DirectCast(sender, System.Object).location.x
            senY = DirectCast(sender, System.Object).location.y
            name = Mid(sender.name, 4)
            loc = picNaToLo(name)
            '
            If loc >= picXSum Then
                If picLoToNa(loc Mod picXSum, loc \ picXSum - 1) = 15 And y < MouCliY Then   '------------*****0
                    If picCliY - senY <= picH Then
                        sender.location = New Point(picCliX, picCliY + (y - MouCliY))
                    End If
                End If
            End If
            If loc Mod picXSum <> picXSum - 1 Then
                If picLoToNa(loc Mod picXSum + 1, loc \ picXSum) = 15 And x > MouCliX Then   '------------*****1
                    If senX - picCliX <= picW Then
                        sender.location = New Point(picCliX + (x - MouCliX), picCliY)
                    End If
                End If
            End If
            If loc < (picXSum - 1) * picYSum Then
                If picLoToNa(loc Mod picXSum, loc \ picXSum + 1) = 15 And y > MouCliY Then  '------------*****2
                    If senY - picCliY <= picH Then
                        sender.location = New Point(picCliX, picCliY + (y - MouCliY))
                    End If
                End If
            End If
            If loc Mod picXSum <> 0 Then
                If picLoToNa(loc Mod picXSum - 1, loc \ picXSum) = 15 And x < MouCliX Then   '------------*****3
                    If picCliX - senX <= picW Then

                        sender.location = New Point(picCliX + (x - MouCliX), picCliY)
                    End If
                End If
            End If
        End If
    End Sub
    Public Sub picMouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim name, loc, x, y As Integer
        Dim n As Short = -1
        name = Mid(sender.name, 4)
        loc = picNaToLo(name)
        x = DirectCast(sender, System.Object).location.x
        y = DirectCast(sender, System.Object).location.y
        If picCliY - y > picH / 2 Then
            n = 0
        ElseIf x - picCliX > picW / 2 Then
            n = 1
        ElseIf y - picCliY > picH / 2 Then
            n = 2
        ElseIf picCliX - x > picW / 2 Then
            n = 3
        End If
        Call picMove(n, name, loc)

        If picNaToLo(15) = 15 Then Call picCheck()
        loc = picNaToLo(name)
        x = AddPicX + (loc Mod picXSum) * picW
        y = AddPicY + (loc \ picXSum) * picH
        sender.location = New Point(x, y)
        MouPicCli = False
    End Sub
    Public Sub picMove(ByVal n, ByVal name, ByVal loc)             '圖像移動函數
        If n = 0 Then                                       '向北移
            sawp(picNaToLo(name), picNaToLo(picSum - 1))
            sawp(picLoToNa(loc Mod picXSum, loc \ picXSum), picLoToNa(loc Mod picXSum, loc \ picXSum - 1))
        ElseIf n = 1 Then                                   '向東移
            sawp(picNaToLo(name), picNaToLo(picSum - 1))
            sawp(picLoToNa(loc Mod picXSum, loc \ picXSum), picLoToNa(loc Mod picXSum + 1, loc \ picXSum))
        ElseIf n = 2 Then                                   '向南移
            sawp(picNaToLo(name), picNaToLo(picSum - 1))
            sawp(picLoToNa(loc Mod picXSum, loc \ picXSum), picLoToNa(loc Mod picXSum, loc \ picXSum + 1))
        ElseIf n = 3 Then                                   '向西移
            sawp(picNaToLo(name), picNaToLo(picSum - 1))
            sawp(picLoToNa(loc Mod picXSum, loc \ picXSum), picLoToNa(loc Mod picXSum - 1, loc \ picXSum))
        End If
    End Sub
    'Pic
    Public Sub RndPicMove()
        Dim rand As Short
        Dim name As Integer, loc As Integer
        Dim i = 1
        Randomize()
        Do Until (i > 1000 And picNaToLo(picSum - 1) = picSum - 1)
            rand = Rnd() * 4
            loc = picNaToLo(picSum - 1)
            If rand = 0 Then
                If loc > picXSum Then
                    name = picLoToNa((loc - picXSum) Mod picXSum, (loc - picXSum) \ picXSum)
                Else
                    rand = -1
                End If
            ElseIf rand = 1 Then
                If loc Mod picXSum <> picXSum - 1 Then
                    name = picLoToNa((loc + 1) Mod picXSum, (loc + 1) \ picXSum)
                Else
                    rand = -1
                End If
            ElseIf rand = 2 Then
                If loc <= picSum - picXSum - 1 Then
                    name = picLoToNa((loc + picXSum) Mod picXSum, (loc + picXSum) \ picXSum)
                Else
                    rand = -1
                End If
            ElseIf rand = 3 Then
                If loc Mod picXSum <> 0 Then
                    name = picLoToNa((loc - 1) Mod picXSum, (loc - 1) \ picXSum)
                Else
                    rand = -1
                End If
            End If
            Call picMove(rand, name, loc)
            i += 1
        Loop
        For i = 0 To picSum - 1
            loc = picNaToLo(i)
            picArr(i).Location = New Point(AddPicX + (loc Mod picXSum) * picW, AddPicY + (loc \ picXSum) * picH)
        Next
    End Sub
    Sub picCheck()
        For i = 0 To picSum - 1
            If picNaToLo(i) <> i Then Exit Sub
        Next
        MsgBox("恭喜過關", , "")
        FormGameMain.Controls.Clear()
        Call Stage3Start()
    End Sub
End Module
