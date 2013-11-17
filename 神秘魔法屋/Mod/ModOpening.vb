Module opening
    Public ioOpening = True
    '控制項
    Private labTit As Label
    Private labName As Label
    Private openTimer1 As Timer
    Private openTimer2 As Timer
    Private openTimer3 As Timer
    'LabelTitle
    Const LabTitSizeW = 520
    Const LabTitSizeH = 100
    Const LabTitLocX = (FormGameMain.FormGaMainSizeW - LabTitSizeW) / 2
    Const LabTitLocY = (FormGameMain.FormGaMainSizeH - LabTitSizeH) / 2 - 50
    Const LabTitFontSize = 70
    'LabelName
    Const LabNaSizeW = 600
    Const LabNaSizeH = 450
    Const LabNaLocX = (FormGameMain.FormGaMainSizeW - LabNaSizeW) / 2 - 50
    Const LabNaLocY = (FormGameMain.FormGaMainSizeH - LabNaSizeH) / 2 + 50
    Const LabNaFontSize = 50
    'Open Timer1
    Const Tim1Int = 150
    Const Tim1Delag = 1000 / Tim1Int * 1.5    '單位秒
    Const Tim1ToWhite = 25                    '單位位元
    Const Tim1ToAddY = 15
    'Open Timer2
    Const Tim2Int = 50
    Const ToVisible = 10
    Const ToUnVisible = 10
    Const Tim2Delag = 1000 / Tim2Int * 2
    'Open Timer3
    Const Tim3Int = 50
    Const Tim3ToAddX = 0.25

    Sub StartOpen(ByVal form As System.Windows.Forms.Form)
        labTit = New Label With {
                                .Name = "labTit",
                                .Text = "神秘魔法屋",
                                .Size = New Size(LabTitSizeW, LabTitSizeH),
                                .Font = New Font("標楷體", LabTitFontSize),
                                .ForeColor = Color.White,
                                .BackColor = Color.Black,
                                .Location = New Point(LabTitLocX, 0)
                                }
        labName = New Label With {
                                .Name = "labName",
                                .Text = "製作群-" & vbCrLf & Space(12) & "程式:程翊嘉" & vbCrLf & Space(12) & "繪圖:于沁安",
                                .Size = New Size(LabNaSizeW, LabNaSizeH),
                                .Font = New Font("微軟正黑體", LabNaFontSize),
                                .ForeColor = Color.White,
                                .BackColor = Color.White,
                                .Location = New Point(LabNaLocX, LabNaLocY),
                                .Visible = False
                                }

        openTimer1 = New Timer With {
                                    .Enabled = True,
                                    .Interval = Tim1Int
                                    }
        openTimer2 = New Timer With {
                                    .Interval = Tim2Int
                                    }
        openTimer3 = New Timer With {
                            .Interval = Tim3Int
                            }
        AddHandler openTimer1.Tick, AddressOf Timer1_Cilck
        AddHandler openTimer2.Tick, AddressOf Timer2_Cilck
        AddHandler openTimer3.Tick, AddressOf Timer3_Cilck
        form.Controls.Add(labTit)
        form.Controls.Add(labName)
        form.BackColor = Color.Black
    End Sub
    'Timer
    Sub Timer1_Cilck()
        Static y As Int16
        Static stay As Int16
        Static formC As Int16
        If y <= LabTitLocY Then         '場景1
            y += Tim1ToAddY
            labTit.Location = New Point(LabTitLocX, y)
        ElseIf stay <= Tim1Delag Then   '場景2
            stay += 1
        ElseIf formC < 255 Then         '場景3
            formC += Tim1ToWhite
            If formC > 255 Then formC = 255
            labTit.BackColor = Color.FromArgb(formC, formC, formC)
            FormGameMain.BackColor = Color.FromArgb(formC, formC, formC)
        Else
            openTimer1.Enabled = False
            labTit.Visible = False
            labName.Visible = True
            openTimer2.Enabled = True
            openTimer3.Enabled = True
        End If
    End Sub
    Sub Timer2_Cilck()
        Static labC As Int16 = 255
        Static io1 As Boolean
        Static stay As Int16
        If labC > 0 And Not io1 Then
            labC -= ToVisible
            If labC < 0 Then labC = 0
            labName.ForeColor = Color.FromArgb(labC, labC, labC)
            If labC = 0 Then io1 = True
        ElseIf stay <= Tim2Delag Then
            stay += 1
        ElseIf labC < 255 Then
            labC += ToUnVisible
            If labC > 255 Then labC = 255
            labName.ForeColor = Color.FromArgb(labC, labC, labC)
        Else

            Call ObjClear()
            Call StartStageInit()
        End If
    End Sub
    Sub Timer3_Cilck()
        Static labX As Double = LabNaLocX
        labX += Tim3ToAddX
        labName.Location = New Point(labX, LabNaLocY)
    End Sub
    'Clear
    Sub ObjClear()
        openTimer1.Dispose()
        openTimer2.Dispose()
        openTimer3.Dispose()
        FormGameMain.Controls.Clear()
    End Sub
End Module
