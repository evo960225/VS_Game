
Module ModPicMove
    Public gameStart As Boolean
    Public gameOverTimes As Integer
    '------pic
    'Big
    Public Const AddPicX = 30                       '圖像與表單的左邊界
    Public Const AddPicY = 50                       '圖像與表單的上邊界
    Public picBigSizeH As UShort                        '圖像高度
    Public picBigSizeW As UShort                        '圖像寬度
    'Mini
    Public picSizeH As UShort                      '圖像高度
    Public picSizeW As UShort                      '圖像寬度
    Public picXSum As UShort                       'X軸按圖像
    Public picYSum As UShort                       'Y軸按圖像
    Public picSum As UShort                         '圖塊總數
    'other
    Public picNaToLo() As Integer                   '圖塊名(Name) - 圖塊位置(Location)
    Public picLoToNa() As Integer                   '圖塊位置 - 圖塊名
    Public picCli As Boolean                        '圖塊是否被按住不放
    '-------
    'bmp
    Public bmpMainAd As String                      '圖片檔位置
    Public bmpMainPic As Bitmap                     '圖片
    Public bmpMainTmp As Bitmap                     '存原圖
    Public bmpTmp As Bitmap                         '圖塊暫存
    Public picArr() As PictureBox                   '圖塊陣列
    'pos
    Public posX As Short                          '滑鼠位置X
    Public posY As Short                           '滑鼠位置Y
    Public mouCliX As Short                        '滑鼠左鍵位置X
    Public mouCliY As Short                        '滑鼠右鍵位置X
    Public picCliX As Short                        '圖塊被按下位置X
    Public picCliY As Short                        '圖塊被按下位置Y
    'Pos Click Pic
    Public picAddX As Integer
    Public picAddY As Integer
    Public picAlg As UShort

    Sub picMove(ByVal n, ByVal name, ByVal loc)             '圖像移動函數
        If n = 0 Then                                       '向北移
            swap(picLoToNa(loc), picLoToNa(loc - picXSum))
            swap(picNaToLo(name), picNaToLo(picSum - 1))
        ElseIf n = 1 Then                                   '向東移
            swap(picLoToNa(loc), picLoToNa(loc + 1))
            swap(picNaToLo(name), picNaToLo(picSum - 1))
        ElseIf n = 2 Then                                   '向南移
            swap(picLoToNa(loc), picLoToNa(loc + picXSum))
            swap(picNaToLo(name), picNaToLo(picSum - 1))
        ElseIf n = 3 Then                                   '向西移
            swap(picLoToNa(loc), picLoToNa(loc - 1))
            swap(picNaToLo(name), picNaToLo(picSum - 1))
        End If
    End Sub
    Public Sub RndPicMove()
        Dim rand As Short
        Dim name As Integer, loc As Integer
        Dim i = 1
        Randomize()
        Do Until (i > picSum * 50 And picNaToLo(picSum - 1) = picSum - 1)
            rand = Int(Rnd() * 4)
            loc = picNaToLo(picSum - 1)
            If rand = 0 Then
                If loc < picSum - picXSum Then
                    loc = loc + picXSum
                    name = picLoToNa(loc)
                Else
                    rand = -1
                End If
            ElseIf rand = 1 Then
                If loc Mod picXSum <> 0 Then
                    loc -= 1
                    name = picLoToNa(loc)
                Else
                    rand = -1
                End If
            ElseIf rand = 2 Then
                If loc >= picXSum Then
                    loc = loc - picXSum
                    name = picLoToNa(loc)
                Else
                    rand = -1
                End If
            ElseIf rand = 3 Then
                If loc Mod picXSum <> picXSum - 1 Then
                    loc += 1
                    name = picLoToNa(loc)
                Else
                    rand = -1
                End If
            End If
            Call picMove(rand, name, loc)
            i += 1
        Loop
        For i = 0 To picSum - 2
            loc = picNaToLo(i)
            picArr(i).Location = New Point(AddPicX + (loc Mod picXSum) * picSizeW, AddPicY + (loc \ picXSum) * picSizeH)
        Next
    End Sub '---------------------------rnd
    Sub picCheck(ByVal picNaToLo() As Integer, ByVal picSum As Integer)
        For i = 0 To picSum - 1
            If picNaToLo(i) <> i Then Exit Sub
        Next
        gameStart = False
        formMain.Enabled = gameStart
        formMain.TimerGame.Enabled = False
        MsgBox("恭喜過關" & vbCrLf & labTimerTime.Text, , "")
    End Sub
End Module
