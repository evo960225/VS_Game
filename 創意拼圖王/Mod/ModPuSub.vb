Module ModPuSub
    Public Declare Function GetCursorPos Lib "user32" Alias "GetCursorPos" (ByRef lpPoint As POINTAPI) As Long
    Public openFile As System.Windows.Forms.OpenFileDialog
    'miniPic
    Public miniPic As PictureBox
    Public Const MiniPicSizeW = 100
    Public Const MiniPicSizeH = 100
    Public Const AddMiniX = 20
    Public Const AddMiniY = 20
    Public miniPicLocX As Int16
    Public miniPicLocY As Int16
    'Bitmap
    Dim miniBmp As Bitmap
    Dim tmpBmp As Bitmap
    'Label
    Public labMiniPicInfo As New Label
    Public labTimerTime As New Label

    Public Sub swap(ByRef a, ByRef b)
        Dim tmp
        tmp = a : a = b : b = tmp
    End Sub
    Public Structure POINTAPI
        Dim x As Integer
        Dim y As Integer
    End Structure

    Public Sub Start()
        '前置
        FileOpen(1, "Options.ini", OpenMode.Input)
        Dim tmp As String
        Dim tmpAd As String
        Dim arr() As String, brr() As String

        tmpAd = Application.StartupPath & "\Image"
        openFile = New System.Windows.Forms.OpenFileDialog
        openFile.InitialDirectory = tmpAd
        openFile.Filter = "(*.bmp;*.jpg;*.jpeg;*.png;*.gif)|*.bmp;*.jpg;*.jpeg;*.png;*.gif"
        '
        ' 圖片
        '
        tmp = LineInput(1)
        arr = Split(tmp, "->")
        bmpMainAd = arr(1)

        Try
            bmpMainPic = New Bitmap(bmpMainAd)
        Catch e As Exception
            Dim err As String

            MsgBox("圖片位置錯誤!!" & vbCrLf & "請變更拼圖圖片位置", , "錯誤")
            openFile.InitialDirectory = Application.StartupPath
            err = openFile.ShowDialog
            bmpMainAd = openFile.FileName
            If err = "1" Then bmpMainPic = New Bitmap(bmpMainAd) Else formMain.Close()
        End Try
        '
        '圖片大小
        '
        tmp = LineInput(1)
        arr = Split(tmp, ":")
        brr = Split(arr(1), "*")
        '--長
        For Each a In FormMain.長ToolStripMenuItem.DropDownItems
            If brr(1) = a.ToString() Then
                a.checked = True
            Else
                a.checked = False
            End If
        Next
        '--寬
        For Each a In FormMain.寬ToolStripMenuItem.DropDownItems
            If brr(0) = a.ToString() Then
                a.checked = True
            Else
                a.checked = False
            End If
        Next
        picBigSizeW = brr(0)
        picBigSizeH = brr(1)
        '
        '塊數
        '
        tmp = LineInput(1)
        arr = Split(tmp, ":")
        brr = Split(arr(1), "*")
        picXSum = brr(0)
        picYSum = brr(1)
        For Each a In FormMain.方塊數ToolStripMenuItem.DropDownItems
            If brr(0) & "x" & brr(1) = a.ToString() Or a.ToString = "其他" Then
                a.checked = True
                Exit For
            Else
                a.checked = False
            End If
        Next

        Call FormMain.init()
        FileClose(1)
    End Sub

    Public Sub Change_PicAdr()
        Dim err As String
        err = openFile.ShowDialog
        bmpMainAd = openFile.FileName

        If err = "1" Then
            bmpMainPic.Dispose()
            bmpMainPic = New Bitmap(bmpMainAd)
            Call FormMain.init()
        End If
    End Sub

    Public Sub clearPic(ByRef form As System.Windows.Forms.Form, ByRef arr() As PictureBox)
        For Each i In arr
            form.Controls.Remove(i)
        Next
    End Sub

    Public Sub addMiniPic()
        Dim addX As Double, addY As Double
        Dim x As Integer = 0, y As Integer = 0
        Dim colors As Color

        miniPic = New PictureBox
        addY = picBigSizeH / MiniPicSizeH
        addX = picBigSizeW / MiniPicSizeW
        If addX < addY Then addX = addY

        miniBmp = New Bitmap(MiniPicSizeW, MiniPicSizeH)
        For i = 0 To picBigSizeH - 1 Step addX
            x = 0
            For j = 0 To picBigSizeW - 1 Step addX
                colors = bmpMainPic.GetPixel(j + picAddX, i + picAddY)
                miniBmp.SetPixel(x, y, colors)
                x += 1
            Next
            y += 1
        Next
        miniPicLocX = AddPicX + picBigSizeW + AddMiniX
        miniPicLocY = AddPicY + AddMiniY

        miniPic.Image = miniBmp
        miniPic.Location = New Point(miniPicLocX, miniPicLocY)
        miniPic.Size = New Point(MiniPicSizeW, MiniPicSizeH)

        AddHandler miniPic.MouseHover, AddressOf miniPic_Hover
        AddHandler miniPic.MouseLeave, AddressOf miniPic_Leave
        AddHandler miniPic.MouseClick, AddressOf miniPIc_Click

        FormMain.Controls.Add(miniPic)
    End Sub

    Sub miniPic_Hover(ByVal sender As System.Object, ByVal e As EventArgs)
        tmpBmp = New Bitmap(miniBmp)
        For i = 0 To MiniPicSizeW - 1
            For j = 0 To MiniPicSizeH - 1
                If i = 0 Or j = 0 Or i = miniPic.Size.Width - 1 Or j = miniPic.Size.Height - 1 Then tmpBmp.SetPixel(i, j, Color.Black)
            Next
        Next
        sender.Image = tmpBmp
    End Sub
    Sub miniPic_Leave(ByVal sender As System.Object, ByVal e As EventArgs)
        sender.image = miniBmp
    End Sub
    Sub miniPic_Click()
        pic.Show()
        pic.Focus()
    End Sub

    Public Sub toolItemCheck(ByVal ToolStripMenuItem As System.Object, ByVal ItemTostring As String, ByRef obj As Object)
        For Each a In ToolStripMenuItem.DropDownItems
            If ItemTostring = a.ToString() Then
                a.checked = True
                obj = ItemTostring.ToString
            Else
                a.checked = False
            End If
        Next
    End Sub

    Public Sub addLabMiniPicInfo()
        With labMiniPicInfo
            .Name = "labMiniPicInfo"
            .Size = New Size(150, 80)
            .Location = New Point(miniPicLocX, 50)
            .Text = "參考圖片點我!!"
            .Font = New Font("微軟正黑體", 12)
        End With
        FormMain.Controls.Add(labMiniPicInfo)
    End Sub
    Public Sub addLabTimerTime()
        With labTimerTime
            .Name = "labMiniPicInfo"
            .Size = New Size(100, 100)
            .Location = New Point(miniPicLocX + 10, 180)
            .Text = "花費時間:"
            .Font = New Font("微軟正黑體", 12)
        End With
        FormMain.Controls.Add(labTimerTime)
    End Sub
End Module
