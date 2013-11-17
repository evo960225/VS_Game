Module ModStage4 '*********未開放**********
    'Form
    Private txtPoswod(ansSum - 1) As TextBox
    Private lab提示(ansSum - 1) As Label
    Private butEnter As Button
    Private labTime As Label
    Private timer As Timer
    'Other
    Private tim As Short = TimeMax
    Private ansRnd As Short
    'Text
    Private Const TxtLocX = 200
    Private Const TxtLocY = 200
    Private Const TxtSizeH = 100
    Private Const TxtSizeW = 100
    Private Const TxtFontPt = 60
    'lab
    Private Const Lab提SizeH = TxtSizeH
    Private Const Lab提SizeW = TxtSizeW
    Private Const Lab提LocX = TxtLocX
    Private Const Lab提LocY = TxtLocY + TxtSizeH
    Private Const LabTiX = 600
    Private Const LabTiY = 600
    '
    Private Const TimeMax = 30
    Private Const ansSum = 4

    Public Sub stage4Start()
        stage = 4
        ansRnd = Int(Rnd() * 9000) + 1000
        '///////////////////////////////////////////
        For i = 0 To 3
            txtPoswod(i) = New TextBox With {
                .Name = "sText" & i,
                .Location = New Point(TxtLocX + TxtSizeW * i, TxtLocY),
                .Size = New Size(TxtSizeW, TxtSizeH),
                .Font = New Font("Arial", TxtFontPt, FontStyle.Bold),
                .Multiline = True,
                .MaxLength = 1,
                .TextAlign = HorizontalAlignment.Center,
                .TabIndex = i
            }
            '
            '
            lab提示(i) = New Label With {
                .Name = "lab提示" & i,
                .Location = New Point(Lab提LocX + Lab提SizeW * i, Lab提LocY),
                .Size = New Point(Lab提SizeW, Lab提SizeH)
            }

            AddHandler txtPoswod(i).TextChanged, AddressOf txt_Change
            AddHandler txtPoswod(i).KeyDown, AddressOf txt_KeyDown
            AddHandler txtPoswod(i).MouseClick, AddressOf txt_MouseClick
        Next
        '///////////////////////////////////////////
        labTime = New Label With {
            .Name = "labTime",
            .Location = New Point(LabTiX, LabTiY)
            }

        timer = New Timer With {
            .Enabled = True,
            .Interval = 1000
            }

        butEnter = New Button With {.Name = "butEnter",
                                   .Text = "確認",
                                   .Location = New Point(500, 500)
                                    }
        FormGameMain.Controls.AddRange(txtPoswod)
        FormGameMain.Controls.AddRange(lab提示)
        FormGameMain.Controls.Add(butEnter)
        FormGameMain.Controls.Add(labTime)
        AddHandler butEnter.Click, AddressOf but_Enter
        AddHandler timer.Tick, AddressOf timer_Tick
        txtPoswod(0).Focus()
    End Sub

    Public Sub timer_Tick()
        tim -= 1
        labTime.Text = tim
        If tim = 0 Then
            timer.Enabled = False
            Call FormGameMain.gameOver()
        End If
    End Sub

    Private Sub txt_KeyDown(ByVal sender As System.Object, ByVal e As KeyEventArgs)
        If Len(sender.text) = 1 And (e.KeyCode >= 48 And e.KeyCode <= 57 Or e.KeyCode >= 96 And e.KeyCode <= 105) Then
            sender.text = ""
        End If
        If e.KeyCode = Keys.Left Then
            If sender.tabindex <> 0 Then
                txtPoswod(sender.tabindex - 1).Focus()
            End If
        ElseIf e.KeyCode = Keys.Right Then
            If sender.tabindex <> ansSum - 1 Then
                txtPoswod(sender.tabindex + 1).Focus()
            End If
        ElseIf e.KeyCode = Keys.Enter Then
            Call but_Enter()
        End If
    End Sub

    Private Sub txt_Change(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not IsNumeric(sender.text) Then
            sender.text = ""
        End If
        If Len(sender.text) = 1 Then
            If sender.tabindex <> ansSum - 1 Then
                txtPoswod(sender.tabindex + 1).Focus()
            Else
                butEnter.Focus()
            End If
        End If

    End Sub

    Private Sub but_Enter()
        Dim tmpAns As Short
        For i = 0 To ansSum - 1
            tmpAns &= txtPoswod(i).Text
            If txtPoswod(i).Text > Mid(CStr(ansRnd), i + 1, 1) Then
                lab提示(i).Text = "Down"
            ElseIf txtPoswod(i).Text < Mid(CStr(ansRnd), i + 1, 1) Then
                lab提示(i).Text = "up"
            Else
                lab提示(i).Text = "-"
            End If
        Next
        If tmpAns = ansRnd Then
            timer.Enabled = False
            Call FormGameMain.gameEnd()
        Else
            MsgBox("有誤", , "")
            txtPoswod(0).Focus()
        End If
    End Sub

    Private Sub txt_MouseClick(ByVal sender As System.Object, ByVal e As MouseEventArgs)
        sender.text = ""
    End Sub
End Module
