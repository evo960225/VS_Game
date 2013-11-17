
Public Class FormGameMain
    Public Const FormGaMainSizeW = 1000
    Public Const FormGaMainSizeH = 700
    Private Const menagePossword = "~etara"

    Public Sub gameEnd()
        MsgBox("恭喜你~全破了!!" & vbCrLf & "thank you playing~", , )
        MsgBox("您獲得管理員密碼!!!" & vbCrLf & "在程式輸入'~etara'即可開啟!!!", , "驚喜!!!")
        Call Init()
    End Sub


    Public Sub gameOver()
        MsgBox("喔喔~你失敗了...", , "")
        Call Init()
    End Sub

    Private Sub Init()
        ReDim butArr(butXSum * butYSum - 1)         '初始化按鈕陣列
        ReDim picArr(butXSum * butYSum - 1)         '初始化圖像陣列
        ReDim picNaToLo(picSum - 1)                 '初始化圖像名稱對應位置
        ReDim picLoToNa(picXSum - 1, picYSum - 1)   '初始化圖像位置對應名稱
        cli = 0                                     'STAGE1點擊數歸0
        stage = 0
        Me.Controls.Clear()                         '表單清空
        Call StartStageInit()
    End Sub

    Private Sub FormGameMain_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        If ioOpening Then
            Call ObjClear()
            Call StartStageInit()
        End If

    End Sub

    Private Sub FormGameMain_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        Static dx As Integer = 1
        If e.KeyChar = Mid(menagePossword, dx, 1) Then
            dx += 1
            If dx > menagePossword.Length Then
                FormMenage.Show()
                dx = 1
            End If
        Else
            dx = 1
        End If
    End Sub

    Private Sub FormGameMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call StartOpen(Me)
    End Sub

End Class
