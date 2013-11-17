
Module ModStage3
    'Card
    Private Const CardHandCount = 5
    Private Const CardLocX = 150
    Private Const CardPlyLocY = 500
    Private Const CardComLocY = 50
    Private Const CardSizeW = 100
    Private Const CardSizeH = 100
    Private Const CardDistanceLocX = CardSizeW + 50
    Private Const CardMaxNum = 5
    Private Const CardMinNum = 1
    Private Const CardNumRange = CardMaxNum - CardMinNum + 1
    Private Const CardImageType = ".gif"
    'CardTemp
    Private Const CardTmpPlyLocX = (FormGameMain.FormGaMainSizeW) / 2 + 100
    Private Const CardTmpPlyLocY = (FormGameMain.FormGaMainSizeH - CardSizeH) / 2 - 20
    Private Const CardTmpComLocX = (FormGameMain.FormGaMainSizeW) / 2 - CardSizeW - 100
    Private Const CardTmpComLocY = CardTmpPlyLocY
    'Picture
    Private picCardCom(CardHandCount - 1) As PictureBox
    Private picCardPlyer(CardHandCount - 1) As PictureBox
    Private picCardComTmp As PictureBox
    Private picCardPlyTmp As PictureBox
    '控制項

    Private labPlyPoint As Label
    Private labComPoint As Label
    Private bmpCard As Bitmap
    Private bmpNum As Bitmap
    'Label Info
    Private labInfor As Label
    Private Const InfoLocX = (FormGameMain.FormGaMainSizeW) / 2 - 200
    Private Const InfoLocY = (FormGameMain.FormGaMainSizeH) / 2 + 50
    Private Const InfoFontSize = 20
    'Label IsGetPoint
    Private labIsGetpo As Label
    Private Const IsGetpoLocX = InfoLocY - 90
    Private Const IsGetpoLocY = 430
    'BackLabel
    Private back As Label
    Private Const baSizeW = 800
    Private Const baSizeH = 600
    Private Const baLocX = 100
    Private Const baLocY = 25
    Private backCol As Color = Color.FromArgb(220, 220, 220, 100)
    'Card Class
    Private ImageArr() As String = {"水", "木", "火"}
    Private plyCard(CardHandCount - 1) As Card
    Private comCard(CardHandCount - 1) As Card
    Private CardPlyused(Cards.CardSum - 1) As Card
    Private CardComused(Cards.CardSum - 1) As Card
    Private CardMain As Cards
    'game
    Private plyPoint As Integer
    Private comPoint As Integer
    Private round As Integer

    '/////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////
    'Start
    Public Sub Stage3Start()
        stage = 3
        Call AddCards()
        Call AddCardPlyer()
        Call AddCardCom()
        Call AddCardplyTmp()
        Call AddCardComTmp()
        Call AddLabel()
        Call AddInfo()
        Call AddLabIsGetpo()
        Call AddBackGr()
        Call InitVar()
        提示1.Show()
    End Sub
    Private Sub InitVar()
        plyPoint = 0
        comPoint = 0
        round = 0
    End Sub
    'Add
    Private Sub AddBackGr()
        back = New Label With {.Name = "back",
                             .Location = New Point(baLocX, baLocY),
                             .Size = New Size(baSizeW, baSizeH),
                             .BackColor = backCol}
        FormGameMain.Controls.Add(back)
    End Sub
    Private Sub AddCards()
        CardMain = New Cards
    End Sub
    Private Sub AddCardPlyer()
        Dim adr As String
        For i = 0 To CardHandCount - 1
            plyCard(i) = CardMain.SelectCard
            adr = ImageAdr & plyCard(i).Element & plyCard(i).Num & CardImageType
            picCardPlyer(i) = New PictureBox With {.Name = "picCardP" & i,
                                                   .Cursor = Cursors.Hand,
                                                   .Location = New Point(CardLocX + CardDistanceLocX * i, CardPlyLocY),
                                                   .Size = New Size(CardSizeW, CardSizeH),
                                                   .Tag = i,
                                                  .Image = New Bitmap(adr)
                                                 }
            AddHandler picCardPlyer(i).Click, AddressOf Pic_Click
        Next

        FormGameMain.Controls.AddRange(picCardPlyer)
    End Sub
    Private Sub AddCardCom()
        Dim adr As String
        adr = ImageAdr & "未知" & CardImageType
        For i = 0 To CardHandCount - 1
            comCard(i) = CardMain.SelectCard
            picCardCom(i) = New PictureBox With {.Name = "picCardC" & i,
                                                 .Location = New Point(CardLocX + CardDistanceLocX * i, CardComLocY),
                                                 .Size = New Size(CardSizeW, CardSizeH),
                                                    .Image = New Bitmap(adr)
                                                 }
        Next
        FormGameMain.Controls.AddRange(picCardCom)
    End Sub
    Private Sub AddCardplyTmp()
        picCardPlyTmp = New PictureBox With {.Name = "picPlyTmp",
                                           .Location = New Point(CardTmpPlyLocX, CardTmpPlyLocY),
                                           .Size = New Size(CardSizeW, CardSizeH),
                                             .BackColor = backCol
                                           }
        FormGameMain.Controls.Add(picCardPlyTmp)
    End Sub
    Private Sub AddCardComTmp()
        picCardComTmp = New PictureBox With {.Name = "picComTmp",
                                           .Location = New Point(CardTmpComLocX, CardTmpComLocY),
                                           .Size = New Size(CardSizeW, CardSizeH),
                                             .BackColor = backCol
                                           }
        FormGameMain.Controls.Add(picCardComTmp)
    End Sub
    Private Sub AddLabel()
        labPlyPoint = New Label With {.Name = "labply",
                                     .Location = New Point(FormGameMain.FormGaMainSizeW - 250, FormGameMain.FormGaMainSizeH / 2 - 25),
                                     .Text = "玩家得點:0",
                                      .BackColor = Color.FromArgb(200, 0, 0, 0),
                                      .ForeColor = Color.White,
                                      .Font = New Font("微軟正黑體", 15),
                                      .AutoSize = True}
        FormGameMain.Controls.Add(labPlyPoint)
        labComPoint = New Label With {.Name = "labcom",
                                        .Location = New Point(150, FormGameMain.FormGaMainSizeH / 2 - 25),
                                        .Text = "電腦得點:0",
                                      .BackColor = Color.FromArgb(200, 0, 0, 0),
                                      .ForeColor = Color.White,
                                      .Font = New Font("微軟正黑體", 15),
                                      .AutoSize = True}
        FormGameMain.Controls.Add(labComPoint)
    End Sub
    Private Sub AddInfo()
        labInfor = New Label With {.Name = "labInfor",
                                 .AutoSize = True,
                                 .BackColor = Color.FromArgb(200, 0, 0, 0),
                                 .ForeColor = Color.White,
                                   .Font = New Font("微軟正黑體", InfoFontSize),
                                   .Text = "電腦的牌" & Space(26) & "玩家的牌"
                                 }
        labInfor.Location = New Point(InfoLocX, InfoLocY)
        FormGameMain.Controls.Add(labInfor)
    End Sub
    Private Sub AddLabIsGetpo()
        labIsGetpo = New Label With {.Name = "labIsGetPo",
                         .AutoSize = True,
                         .BackColor = Color.FromArgb(200, 0, 0, 0),
                         .ForeColor = Color.White,
                           .Font = New Font("微軟正黑體", InfoFontSize)
                         }
        labIsGetpo.Location = New Point(430, InfoLocY - 90)
        FormGameMain.Controls.Add(labIsGetpo)
    End Sub

    'picClick
    Private Sub Pic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not IsNothing(sender.Image) Then
            Dim ComSelect As Integer
            Dim plyGet As Boolean

            ComSelect = AI2Select()

            picCardPlyTmp.Image = sender.image
            picCardComTmp.Image = New Bitmap(comCard(ComSelect).ImageURL)

            plyGet = IsPlyGetPoint(plyCard(sender.Tag).ElementNum, plyCard(sender.Tag).Num, comCard(ComSelect).ElementNum, comCard(ComSelect).Num)
            Call makeUpCard(sender.Tag, ComSelect, plyGet)
            Call LabChange()
            Call IsPlyWin()
            Call Game_Round(plyCard(sender.Tag), comCard(ComSelect))
        End If
    End Sub
    Private Sub Game_Round(ByVal PlySelectCard, ByVal ComSelectCard)
        CardPlyused(round) = PlySelectCard
        CardComused(round) = ComSelectCard
        round += 1
    End Sub
    Private Function IsPlyGetPoint(ByVal plyEle, ByVal plyNum, ByVal comEle, ByVal comNum)
        Dim plyWin As Boolean
        If plyEle = 1 And comEle = 0 Or _
                plyEle = 2 And comEle = 1 Or _
                plyEle = 0 And comEle = 2 Then
            plyWin = True
        ElseIf plyEle = comEle Then
            If plyNum > comNum Then
                plyWin = True
            End If
        End If
        If plyWin Then
            plyPoint += 1
            Call Info("玩家得點!!")
        Else
            comPoint += 1
            Call Info("電腦得點!!")
        End If
        Return plyWin
    End Function
    Private Sub Info(ByVal st As String)
        labIsGetpo.Text = st
    End Sub
    Private Sub makeUpCard(ByVal p, ByVal c, ByVal plyGetPoint)
        If CardMain.GetUnused <> 0 Then
            If plyGetPoint Then
                comCard(c) = CardMain.SelectCard
            Else
                plyCard(p) = CardMain.SelectCard
                picCardPlyer(p).Image = New Bitmap(plyCard(p).ImageURL)
            End If
        Else
            If plyGetPoint Then
                picCardCom(c).Image = Nothing
                picCardCom(c) = Nothing
                FormGameMain.Controls.Remove(picCardCom(c))
                comCard(c).noed()
            Else
                picCardPlyer(p).Image = Nothing
                picCardPlyer(p) = Nothing
                FormGameMain.Controls.Remove(picCardPlyer(p))
                plyCard(p).noed()
            End If
        End If
    End Sub
    Private Sub LabChange()
        labPlyPoint.Text = "玩家得點:" & plyPoint
        labComPoint.Text = "電腦得點:" & comPoint
    End Sub
    Private Sub IsPlyWin()
        Dim io As Boolean
        Dim i As Integer
        Dim ply, com As Integer
        For i = 0 To CardHandCount - 1
            If (Not IsNothing(picCardPlyer(i))) Then
                ply += 1
            End If
            If (Not IsNothing(picCardCom(i))) Then
                com += 1
            End If
        Next
        If ply = 0 Or com = 0 Or plyPoint = 8 Or comPoint = 8 Then io = True
        If io Then
            plyPoint += ply : comPoint += com
            Call LabChange()
            If plyPoint > comPoint Then
                Call FormGameMain.gameEnd()
            Else
                Call FormGameMain.gameOver()
            End If
            FormGameMain.Controls.Remove(picCardPlyTmp)
            FormGameMain.Controls.Remove(picCardComTmp)
        End If
    End Sub
    'AI Login
    Private Function AI1Select()
        Return AiLo1()
    End Function
    Private Function AI2Select()
        Dim s As Integer = -1

        If round <= 2 Then
            If round > 0 Then s = AILo6()
            If s = -1 Then s = AILo5()
            If s = -1 Then Return AiLo1()
            Return s
        Else
            s = AILo6()
            If Int(Rnd() * 2) = 1 And s = -1 Then s = AiLo4()
            If s = -1 Then s = AiLo3()
            If s = -1 Then s = AiLo1()
            Return s
        End If
        Return AiLo1()
    End Function
    Private Function AiLo1() '亂數演算
        Dim AIselect As Integer
        AIselect = Int(Rnd() * CardHandCount)
        While comCard(AIselect).no
            AIselect = Int(Rnd() * CardHandCount)
        End While
        Return AIselect
    End Function
    Private Function AiLo2() '取數值最小
        Dim min As Integer = CardMaxNum
        Dim AiSelect As Integer
        For i = 0 To CardHandCount - 1
            If comCard(i).Num < min And Not comCard(i).no Then
                AiSelect = i
                min = comCard(i).Num
            End If
        Next
        Return AiSelect
    End Function
    Private Function AiLo3() '機率法(總牌剩十)
        Dim ele As Integer
        Dim AiSelect As Integer
        Dim a, b, c As Integer
        For i = 0 To CardHandCount - 1
            If Not IsNothing(plyCard(i)) Then
                Select Case plyCard(i).ElementNum
                    Case 0
                        a += 1
                    Case 1
                        b += 1
                    Case 2
                        c += 1
                End Select
            End If
        Next
        If a > b And a > c Then
            ele = 1
        ElseIf b > a And b > c Then
            ele = 2
        Else
            ele = 0
        End If
        For i = 0 To CardHandCount - 1
            If Not IsNothing(comCard(i)) Then
                If comCard(i).ElementNum = ele And comCard(i).Num > comCard(AiSelect).Num Then
                    AiSelect = i
                    If Not comCard(i).no Then Return AiSelect
                End If
            End If
        Next
        Return -1
    End Function
    Private Function AiLo4() '****防治玩家重複出同張卡****
        If round >= 2 Then
            If CardPlyused(round - 2).ElementNum = CardPlyused(round - 1).ElementNum And _
                CardPlyused(round - 2).Num = CardPlyused(round - 1).Num Then
                Dim ele As Integer
                Dim AiSelect As Integer = -1
                Select Case CardPlyused(round - 1).ElementNum
                    Case 0 : ele = 1
                    Case 1 : ele = 2
                    Case 2 : ele = 0
                End Select
                For i = 0 To CardHandCount - 1
                    If comCard(i).ElementNum = ele And plyCard(i).ElementNum = ele Then
                        AiSelect = i
                        If Not comCard(i).no Then Return AiSelect
                    End If
                Next
                For i = 0 To CardHandCount - 1
                    If comCard(i).ElementNum = CardPlyused(round - 1).ElementNum And comCard(i).Num > CardPlyused(round - 1).Num Then
                        AiSelect = i
                        If Not comCard(i).no Then Return AiSelect
                    End If
                Next
            End If
        End If
        Return -1
    End Function
    Private Function AILo5() '去最大數牌
        Dim max As Integer
        Dim AiSelect As Integer
        For i = 0 To CardHandCount - 1
            If comCard(i).Num > max And Not comCard(i).no Then
                AiSelect = i
                max = comCard(i).Num
            End If
        Next
        Return AiSelect
    End Function
    Private Function AILo6() '對數值最大牌
        If CardPlyused(round - 1).Num = CardMaxNum Then
            Dim ele As Integer, AiSelect As Integer
            Select Case CardPlyused(round - 1).ElementNum
                Case 0 : ele = 1
                Case 1 : ele = 2
                Case 2 : ele = 0
            End Select
            For i = 0 To CardHandCount - 1
                If comCard(i).ElementNum = ele Then
                    AiSelect = i
                    If Not comCard(i).no Then Return AiSelect
                End If
            Next
        End If
        Return -1
    End Function
    'Card
    Private Class Cards
        Public Const CardSum = 15
        Private cardUnused As Integer = CardSum
        Private Card(CardSum - 1) As Card
        Public Sub New()
            For i = 0 To CardSum - 1
                Card(i) = New Card With {.Element = ImageArr(i \ CardNumRange),
                                         .ElementNum = i \ CardNumRange,
                                         .Num = i Mod CardNumRange + CardMinNum,
                                         .ImageURL = ImageAdr & .Element & .Num & CardImageType
                                          }
            Next
        End Sub
        Public Function GetUnused()
            Return cardUnused
        End Function
        Public Function SelectCard()
            Dim se As Integer
            Dim tmp As Card
            se = Int(Rnd() * cardUnused)
            Card(se).use()
            tmp = Card(se) : Card(se) = Card(cardUnused - 1) : Card(cardUnused - 1) = tmp
            cardUnused -= 1
            Return tmp
        End Function
    End Class
    Private Class Card
        Public Num As Short
        Public Element As String
        Public ElementNum As Short
        Public ImageURL As String
        Private used As Boolean
        Public no As Boolean
        Public Sub use()
            used = True
        End Sub
        Public Function GetUsed()
            Return used
        End Function
        Public Sub noed()
            no = True
        End Sub


    End Class
    'Menage
    Public Sub Men()
        FormMenage.ListBox1.Items.Clear()
        FormMenage.ListBox2.Items.Clear()
        For i = 0 To round - 1
            FormMenage.ListBox1.Items.Add(CardPlyused(i).Element & " " & CardPlyused(i).Num)
            FormMenage.ListBox2.Items.Add(CardComused(i).Element & " " & CardComused(i).Num)
        Next
    End Sub
End Module
