Module ModStage1Sub
    '--------------------------------------------------------------------------第1關
    'buttom
    Public Const Addx = 50                         '按鈕與表單的左邊界
    Public Const Addy = 30                         '按鈕與表單的上邊界
    Public Const butH = 150                         '按鈕高度
    Public Const butW = 150                         '按鈕寬度
    Public Const butXSum = 4                        'X軸按鈕數
    Public Const butYSum = 4                        'Y軸按鈕數
    Public Const butSum = butXSum * butYSum
    'Stage1
    Public Const MaxClick As Short = 5              'stage1的最大點擊數
    Public Const butColorA = 230
    'label Information  (點擊數顯示)
    Private Const labInfoLocX = 670
    Private Const labInfoLocY = 550
    '---------------------------------------------------------------------------第2關
    'pic
    Public Const AddPicX = 50                         '圖像與表單的左邊界
    Public Const AddPicY = 30                         '圖像與表單的上邊界
    Public Const picH = 150                         '圖像高度
    Public Const picW = 150                         '圖像寬度
    Public Const picXSum = 4                        'X軸按圖像
    Public Const picYSum = 4                        'Y軸按圖像
    Public Const picSum = picXSum * picYSum
    Public Const picBoSize = 1
    Public picBoColor = Color.Gold
    '------------------------------------------------------------------------------
    Public butArr(butXSum * butYSum - 1) As System.Windows.Forms.Button         '宣告按鈕陣列
    Public picArr(picXSum * picYSum - 1) As PictureBox                          '宣告圖片陣列
    Public labInfor As Label
    'Var
    Public stage As Short = 0                   '關數
    Public cli As Short = 0                     'stage1點擊數
    Public ans1 As UShort                       '答案回傳
    Public ansRnd As UShort                     'stage1五張圖的亂數(0~4)
    'BapBit
    Public bmpMain As Bitmap
    'Arr
    Public AnsArr() As String = {"星星", "月亮", "太陽", "雲", "花"}          '答案陣列
    Public colorArr() As Color = {Color.Chartreuse, Color.Gold, Color.Goldenrod, Color.AntiqueWhite, Color.Brown,
                                  Color.Chocolate, Color.Red, Color.Green, Color.Orange, Color.Lime, Color.SkyBlue,
                                  Color.Teal, Color.Tomato, Color.Transparent, Color.White, Color.Yellow, Color.YellowGreen}        '答案陣列
    '/////////////////////////////////////////////////////////////////////////////////////////////////////////////
    'Start
    Public Sub gameStart()                  '遊戲開始時
        stage = 1                                                   '第1關
        Randomize(Now.Millisecond)                                  '以毫秒當亂數
        ansRnd = Int(Rnd() * AnsArr.Length)                         '產生亂數
        bmpMain = New Bitmap(ImageAdr & AnsArr(ansRnd) & ".jpg")    '載入圖片
        Call ClearArrRank2(picLoToNa, -1)                           '初始陣列
        Call butArrAdd()
        Call picArrAdd()
        Call RndPicMove()                                           '圖片亂數移動
        Call labInfoAdd()
        提示1.Show()
    End Sub
    'Form Add
    Private Sub butArrAdd() '--------------------------------------------'建立按鈕陣列
        Dim i, j As Integer                     '迴圈用變數
        Dim indx As Integer                     '宣告索引位置(i*4+j)
        For i = 0 To butYSum - 1
            For j = 0 To butXSum - 1
                indx = i * 4 + j
                butArr(indx) = New Button With { _
                        .Name = "but" & CStr(j + i * butXSum),
                        .Width = butW,
                        .Height = butH,
                        .Location = New Point(Addx + j * 150, Addy + i * 150),
                        .FlatStyle = FlatStyle.Flat,
                        .BackColor = Color.FromArgb(butColorA, colorArr(Int(Rnd() * colorArr.Length)))
                }
                butArr(indx).FlatAppearance.BorderSize = 0                          '無外框
                AddHandler butArr(indx).MouseClick, AddressOf butArr_MouseClick     '新增按鈕事件
            Next
        Next
        FormGameMain.Controls.AddRange(butArr)                                      '按鈕增加至表單
    End Sub
    Private Sub picArrAdd() '----------------------------------------------建立圖像陣列
        Dim bmpTmp As Bitmap
        For i = 0 To picSum - 1                                     '按照名稱放pic
            picNaToLo(i) = i                                        '圖像名稱對應位置設值,且照順序
            picLoToNa(i Mod picXSum, i \ picXSum) = i               '圖像位置對應名稱設值,且照順序
            bmpTmp = bmpMain.Clone(New RectangleF((i Mod picXSum) * 150, (i \ picXSum) * 150, picW, picH), bmpMain.PixelFormat)
            For j = 0 To 149
                For k = 0 To picBoSize - 1
                    bmpTmp.SetPixel(j, 0 + k, picBoColor)
                    bmpTmp.SetPixel(j, 149 - k, picBoColor)
                    bmpTmp.SetPixel(0 + k, j, picBoColor)
                    bmpTmp.SetPixel(149 - k, j, picBoColor)
                Next
            Next
            '----------------------------設定圖像屬性
            picArr(i) = New PictureBox With { _
                    .Name = "pic" & CStr(i),
                    .Width = picW,
                    .Height = picH,
                    .Image = bmpTmp
            }
        Next
        FormGameMain.Controls.AddRange(picArr)                '圖像增加至表單
    End Sub
    Private Sub labInfoAdd()
        labInfor = New Label With {.Name = "labinfor", .Location = New Point(labInfoLocX, labInfoLocY),
                                   .Text = "您可以點選" & MaxClick & "格方塊",
                                    .AutoSize = True,
                                   .BackColor = Color.Black,
                                   .ForeColor = Color.White,
                                   .Font = New Font("微軟正黑體", 20)
                          }    '宣告cli資訊標籤
        FormGameMain.Controls.Add(labInfor)                     '標籤(按鍵次數)增加至表單
    End Sub
    'Stage 事件
    Private Sub butArr_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) '當動態按鈕被按時(隱藏)
        If cli < MaxClick Then                                      '按鈕點選次數<=最大點選次數
            FormGameMain.Controls.Remove(sender)                    '按鈕移除
            cli += 1                                                '按按鍵次數增加
            labInfor.Text = "您可以再點選" & MaxClick - cli & "格方塊"               'lab資訊更新
            If cli = MaxClick Then Call stage1PlayerAns() '按鈕點選次數=最大點選次數,則呼叫"猜猜我是誰Form"
        End If
    End Sub
    Private Sub stage1PlayerAns() '猜圖片是啥,選項視窗
        FormstageAns1.Show()
        FormstageAns1.Focus()
    End Sub
    Public Sub stage1RecallAns()
        If ans1 <> ansRnd Then
            Call FormGameMain.gameOver()
        Else
            Call butRemove()
            Call stage2Start()
        End If
    End Sub
    Private Sub butRemove()
        For i = 0 To butSum - 1
            FormGameMain.Controls.Remove(butArr(i))
        Next
    End Sub
End Module