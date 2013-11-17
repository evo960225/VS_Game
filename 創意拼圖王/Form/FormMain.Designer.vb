<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.遊戲ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.新遊戲ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.變更圖片ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.設定ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.圖片大小ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.長ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolMenuY300 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolMenuY400 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolMenuY500 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolMenuY600 = New System.Windows.Forms.ToolStripMenuItem()
        Me.寬ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolMenuX300 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolMenuX400 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolMenuX500 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolMenuX600 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolMenuX700 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolMenuX800 = New System.Windows.Forms.ToolStripMenuItem()
        Me.方塊數ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me._2x3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me._2x4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me._2x5ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me._3x3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me._3x4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me._3x5ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me._4x3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me._4x4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me._4x5ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me._5x2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me._5x3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me._5x4ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me._5x5ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.其他ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.顯示模式ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.左上ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.上ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.右上ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.左ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.中ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.右ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.左下ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.下ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.右下ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.其他ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.顯示ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.框線ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.反白ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.模式ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.遊玩模式ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.繪圖模式ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.說明ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.關於ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.作者ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.意見反饋ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimerGame = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.遊戲ToolStripMenuItem, Me.設定ToolStripMenuItem, Me.顯示ToolStripMenuItem, Me.模式ToolStripMenuItem, Me.說明ToolStripMenuItem, Me.關於ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1008, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '遊戲ToolStripMenuItem
        '
        Me.遊戲ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.新遊戲ToolStripMenuItem, Me.變更圖片ToolStripMenuItem})
        Me.遊戲ToolStripMenuItem.Name = "遊戲ToolStripMenuItem"
        Me.遊戲ToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.遊戲ToolStripMenuItem.Text = "遊戲"
        '
        '新遊戲ToolStripMenuItem
        '
        Me.新遊戲ToolStripMenuItem.Enabled = False
        Me.新遊戲ToolStripMenuItem.Name = "新遊戲ToolStripMenuItem"
        Me.新遊戲ToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.新遊戲ToolStripMenuItem.Text = "新遊戲"
        '
        '變更圖片ToolStripMenuItem
        '
        Me.變更圖片ToolStripMenuItem.Name = "變更圖片ToolStripMenuItem"
        Me.變更圖片ToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.變更圖片ToolStripMenuItem.Text = "變更圖片"
        '
        '設定ToolStripMenuItem
        '
        Me.設定ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.圖片大小ToolStripMenuItem, Me.方塊數ToolStripMenuItem, Me.顯示模式ToolStripMenuItem})
        Me.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem"
        Me.設定ToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.設定ToolStripMenuItem.Text = "設定"
        '
        '圖片大小ToolStripMenuItem
        '
        Me.圖片大小ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.長ToolStripMenuItem, Me.寬ToolStripMenuItem})
        Me.圖片大小ToolStripMenuItem.Name = "圖片大小ToolStripMenuItem"
        Me.圖片大小ToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.圖片大小ToolStripMenuItem.Text = "圖片大小"
        '
        '長ToolStripMenuItem
        '
        Me.長ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolMenuY300, Me.ToolMenuY400, Me.ToolMenuY500, Me.ToolMenuY600})
        Me.長ToolStripMenuItem.Name = "長ToolStripMenuItem"
        Me.長ToolStripMenuItem.Size = New System.Drawing.Size(86, 22)
        Me.長ToolStripMenuItem.Text = "長"
        '
        'ToolMenuY300
        '
        Me.ToolMenuY300.Checked = True
        Me.ToolMenuY300.CheckOnClick = True
        Me.ToolMenuY300.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolMenuY300.Name = "ToolMenuY300"
        Me.ToolMenuY300.Size = New System.Drawing.Size(95, 22)
        Me.ToolMenuY300.Text = "300"
        '
        'ToolMenuY400
        '
        Me.ToolMenuY400.CheckOnClick = True
        Me.ToolMenuY400.Name = "ToolMenuY400"
        Me.ToolMenuY400.Size = New System.Drawing.Size(95, 22)
        Me.ToolMenuY400.Text = "400"
        '
        'ToolMenuY500
        '
        Me.ToolMenuY500.CheckOnClick = True
        Me.ToolMenuY500.Name = "ToolMenuY500"
        Me.ToolMenuY500.Size = New System.Drawing.Size(95, 22)
        Me.ToolMenuY500.Text = "500"
        '
        'ToolMenuY600
        '
        Me.ToolMenuY600.Name = "ToolMenuY600"
        Me.ToolMenuY600.Size = New System.Drawing.Size(95, 22)
        Me.ToolMenuY600.Text = "600"
        '
        '寬ToolStripMenuItem
        '
        Me.寬ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolMenuX300, Me.ToolMenuX400, Me.ToolMenuX500, Me.ToolMenuX600, Me.ToolMenuX700, Me.ToolMenuX800})
        Me.寬ToolStripMenuItem.Name = "寬ToolStripMenuItem"
        Me.寬ToolStripMenuItem.Size = New System.Drawing.Size(86, 22)
        Me.寬ToolStripMenuItem.Text = "寬"
        '
        'ToolMenuX300
        '
        Me.ToolMenuX300.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ToolMenuX300.Checked = True
        Me.ToolMenuX300.CheckOnClick = True
        Me.ToolMenuX300.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolMenuX300.Name = "ToolMenuX300"
        Me.ToolMenuX300.Size = New System.Drawing.Size(95, 22)
        Me.ToolMenuX300.Text = "300"
        '
        'ToolMenuX400
        '
        Me.ToolMenuX400.CheckOnClick = True
        Me.ToolMenuX400.Name = "ToolMenuX400"
        Me.ToolMenuX400.Size = New System.Drawing.Size(95, 22)
        Me.ToolMenuX400.Text = "400"
        '
        'ToolMenuX500
        '
        Me.ToolMenuX500.CheckOnClick = True
        Me.ToolMenuX500.Name = "ToolMenuX500"
        Me.ToolMenuX500.Size = New System.Drawing.Size(95, 22)
        Me.ToolMenuX500.Text = "500"
        '
        'ToolMenuX600
        '
        Me.ToolMenuX600.Name = "ToolMenuX600"
        Me.ToolMenuX600.Size = New System.Drawing.Size(95, 22)
        Me.ToolMenuX600.Text = "600"
        '
        'ToolMenuX700
        '
        Me.ToolMenuX700.Name = "ToolMenuX700"
        Me.ToolMenuX700.Size = New System.Drawing.Size(95, 22)
        Me.ToolMenuX700.Text = "700"
        '
        'ToolMenuX800
        '
        Me.ToolMenuX800.Name = "ToolMenuX800"
        Me.ToolMenuX800.Size = New System.Drawing.Size(95, 22)
        Me.ToolMenuX800.Text = "800"
        '
        '方塊數ToolStripMenuItem
        '
        Me.方塊數ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me._2x3ToolStripMenuItem, Me._2x4ToolStripMenuItem, Me._2x5ToolStripMenuItem, Me._3x3ToolStripMenuItem, Me._3x4ToolStripMenuItem, Me._3x5ToolStripMenuItem, Me._4x3ToolStripMenuItem, Me._4x4ToolStripMenuItem, Me._4x5ToolStripMenuItem, Me._5x2ToolStripMenuItem, Me._5x3ToolStripMenuItem, Me._5x4ToolStripMenuItem2, Me._5x5ToolStripMenuItem, Me.其他ToolStripMenuItem})
        Me.方塊數ToolStripMenuItem.Name = "方塊數ToolStripMenuItem"
        Me.方塊數ToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.方塊數ToolStripMenuItem.Text = "方塊數"
        '
        '_2x3ToolStripMenuItem
        '
        Me._2x3ToolStripMenuItem.Name = "_2x3ToolStripMenuItem"
        Me._2x3ToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me._2x3ToolStripMenuItem.Text = "2x3"
        '
        '_2x4ToolStripMenuItem
        '
        Me._2x4ToolStripMenuItem.Name = "_2x4ToolStripMenuItem"
        Me._2x4ToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me._2x4ToolStripMenuItem.Text = "2x4"
        '
        '_2x5ToolStripMenuItem
        '
        Me._2x5ToolStripMenuItem.Name = "_2x5ToolStripMenuItem"
        Me._2x5ToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me._2x5ToolStripMenuItem.Text = "2x5"
        '
        '_3x3ToolStripMenuItem
        '
        Me._3x3ToolStripMenuItem.Name = "_3x3ToolStripMenuItem"
        Me._3x3ToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me._3x3ToolStripMenuItem.Text = "3x3"
        '
        '_3x4ToolStripMenuItem
        '
        Me._3x4ToolStripMenuItem.Name = "_3x4ToolStripMenuItem"
        Me._3x4ToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me._3x4ToolStripMenuItem.Text = "3x4"
        '
        '_3x5ToolStripMenuItem
        '
        Me._3x5ToolStripMenuItem.Name = "_3x5ToolStripMenuItem"
        Me._3x5ToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me._3x5ToolStripMenuItem.Text = "3x5"
        '
        '_4x3ToolStripMenuItem
        '
        Me._4x3ToolStripMenuItem.Name = "_4x3ToolStripMenuItem"
        Me._4x3ToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me._4x3ToolStripMenuItem.Text = "4x3"
        '
        '_4x4ToolStripMenuItem
        '
        Me._4x4ToolStripMenuItem.Name = "_4x4ToolStripMenuItem"
        Me._4x4ToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me._4x4ToolStripMenuItem.Text = "4x4"
        '
        '_4x5ToolStripMenuItem
        '
        Me._4x5ToolStripMenuItem.Name = "_4x5ToolStripMenuItem"
        Me._4x5ToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me._4x5ToolStripMenuItem.Text = "4x5"
        '
        '_5x2ToolStripMenuItem
        '
        Me._5x2ToolStripMenuItem.Name = "_5x2ToolStripMenuItem"
        Me._5x2ToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me._5x2ToolStripMenuItem.Text = "5x2"
        '
        '_5x3ToolStripMenuItem
        '
        Me._5x3ToolStripMenuItem.Name = "_5x3ToolStripMenuItem"
        Me._5x3ToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me._5x3ToolStripMenuItem.Text = "5x3"
        '
        '_5x4ToolStripMenuItem2
        '
        Me._5x4ToolStripMenuItem2.Name = "_5x4ToolStripMenuItem2"
        Me._5x4ToolStripMenuItem2.Size = New System.Drawing.Size(98, 22)
        Me._5x4ToolStripMenuItem2.Text = "5x4"
        '
        '_5x5ToolStripMenuItem
        '
        Me._5x5ToolStripMenuItem.Name = "_5x5ToolStripMenuItem"
        Me._5x5ToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me._5x5ToolStripMenuItem.Text = "5x5"
        '
        '其他ToolStripMenuItem
        '
        Me.其他ToolStripMenuItem.Name = "其他ToolStripMenuItem"
        Me.其他ToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.其他ToolStripMenuItem.Text = "其他"
        '
        '顯示模式ToolStripMenuItem
        '
        Me.顯示模式ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.左上ToolStripMenuItem, Me.上ToolStripMenuItem, Me.右上ToolStripMenuItem, Me.左ToolStripMenuItem, Me.中ToolStripMenuItem, Me.右ToolStripMenuItem, Me.左下ToolStripMenuItem, Me.下ToolStripMenuItem, Me.右下ToolStripMenuItem, Me.其他ToolStripMenuItem1})
        Me.顯示模式ToolStripMenuItem.Name = "顯示模式ToolStripMenuItem"
        Me.顯示模式ToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.顯示模式ToolStripMenuItem.Text = "顯示圖片的位置"
        '
        '左上ToolStripMenuItem
        '
        Me.左上ToolStripMenuItem.Checked = True
        Me.左上ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.左上ToolStripMenuItem.Name = "左上ToolStripMenuItem"
        Me.左上ToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.左上ToolStripMenuItem.Tag = "0"
        Me.左上ToolStripMenuItem.Text = "左上"
        '
        '上ToolStripMenuItem
        '
        Me.上ToolStripMenuItem.Name = "上ToolStripMenuItem"
        Me.上ToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.上ToolStripMenuItem.Tag = "1"
        Me.上ToolStripMenuItem.Text = "上"
        '
        '右上ToolStripMenuItem
        '
        Me.右上ToolStripMenuItem.Name = "右上ToolStripMenuItem"
        Me.右上ToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.右上ToolStripMenuItem.Tag = "2"
        Me.右上ToolStripMenuItem.Text = "右上"
        '
        '左ToolStripMenuItem
        '
        Me.左ToolStripMenuItem.Name = "左ToolStripMenuItem"
        Me.左ToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.左ToolStripMenuItem.Tag = "3"
        Me.左ToolStripMenuItem.Text = "左"
        '
        '中ToolStripMenuItem
        '
        Me.中ToolStripMenuItem.Name = "中ToolStripMenuItem"
        Me.中ToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.中ToolStripMenuItem.Tag = "4"
        Me.中ToolStripMenuItem.Text = "中"
        '
        '右ToolStripMenuItem
        '
        Me.右ToolStripMenuItem.Name = "右ToolStripMenuItem"
        Me.右ToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.右ToolStripMenuItem.Tag = "5"
        Me.右ToolStripMenuItem.Text = "右"
        '
        '左下ToolStripMenuItem
        '
        Me.左下ToolStripMenuItem.Name = "左下ToolStripMenuItem"
        Me.左下ToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.左下ToolStripMenuItem.Tag = "6"
        Me.左下ToolStripMenuItem.Text = "左下"
        '
        '下ToolStripMenuItem
        '
        Me.下ToolStripMenuItem.Name = "下ToolStripMenuItem"
        Me.下ToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.下ToolStripMenuItem.Tag = "7"
        Me.下ToolStripMenuItem.Text = "下"
        '
        '右下ToolStripMenuItem
        '
        Me.右下ToolStripMenuItem.Name = "右下ToolStripMenuItem"
        Me.右下ToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.右下ToolStripMenuItem.Tag = "8"
        Me.右下ToolStripMenuItem.Text = "右下"
        '
        '其他ToolStripMenuItem1
        '
        Me.其他ToolStripMenuItem1.Name = "其他ToolStripMenuItem1"
        Me.其他ToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.其他ToolStripMenuItem1.Tag = "9"
        Me.其他ToolStripMenuItem1.Text = "其他"
        Me.其他ToolStripMenuItem1.Visible = False
        '
        '顯示ToolStripMenuItem
        '
        Me.顯示ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.框線ToolStripMenuItem, Me.反白ToolStripMenuItem})
        Me.顯示ToolStripMenuItem.Name = "顯示ToolStripMenuItem"
        Me.顯示ToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.顯示ToolStripMenuItem.Text = "顯示"
        '
        '框線ToolStripMenuItem
        '
        Me.框線ToolStripMenuItem.Enabled = False
        Me.框線ToolStripMenuItem.Name = "框線ToolStripMenuItem"
        Me.框線ToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.框線ToolStripMenuItem.Text = "框線(未開放)"
        '
        '反白ToolStripMenuItem
        '
        Me.反白ToolStripMenuItem.Name = "反白ToolStripMenuItem"
        Me.反白ToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.反白ToolStripMenuItem.Text = "負片"
        '
        '模式ToolStripMenuItem
        '
        Me.模式ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.遊玩模式ToolStripMenuItem, Me.繪圖模式ToolStripMenuItem})
        Me.模式ToolStripMenuItem.Name = "模式ToolStripMenuItem"
        Me.模式ToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.模式ToolStripMenuItem.Text = "模式"
        '
        '遊玩模式ToolStripMenuItem
        '
        Me.遊玩模式ToolStripMenuItem.Checked = True
        Me.遊玩模式ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.遊玩模式ToolStripMenuItem.Name = "遊玩模式ToolStripMenuItem"
        Me.遊玩模式ToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.遊玩模式ToolStripMenuItem.Text = "遊玩模式"
        '
        '繪圖模式ToolStripMenuItem
        '
        Me.繪圖模式ToolStripMenuItem.Enabled = False
        Me.繪圖模式ToolStripMenuItem.Name = "繪圖模式ToolStripMenuItem"
        Me.繪圖模式ToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.繪圖模式ToolStripMenuItem.Text = "繪圖模式(未開放)"
        '
        '說明ToolStripMenuItem
        '
        Me.說明ToolStripMenuItem.Name = "說明ToolStripMenuItem"
        Me.說明ToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.說明ToolStripMenuItem.Text = "說明"
        Me.說明ToolStripMenuItem.Visible = False
        '
        '關於ToolStripMenuItem
        '
        Me.關於ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.作者ToolStripMenuItem, Me.意見反饋ToolStripMenuItem})
        Me.關於ToolStripMenuItem.Name = "關於ToolStripMenuItem"
        Me.關於ToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.關於ToolStripMenuItem.Text = "關於"
        '
        '作者ToolStripMenuItem
        '
        Me.作者ToolStripMenuItem.Name = "作者ToolStripMenuItem"
        Me.作者ToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.作者ToolStripMenuItem.Text = "作者"
        '
        '意見反饋ToolStripMenuItem
        '
        Me.意見反饋ToolStripMenuItem.Name = "意見反饋ToolStripMenuItem"
        Me.意見反饋ToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.意見反饋ToolStripMenuItem.Text = "意見反饋"
        '
        'TimerGame
        '
        '
        '
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1008, 681)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = ""
        Me.Opacity = 0.95R
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "創意拼圖王"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents 設定ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 圖片大小ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 長ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolMenuY300 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolMenuY400 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolMenuY500 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 寬ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolMenuX300 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolMenuX400 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolMenuX500 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 方塊數ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents _3x3ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents _4x4ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents _5x5ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 顯示ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 框線ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 反白ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 遊戲ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 新遊戲ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 模式ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolMenuY600 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolMenuX600 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents _2x5ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents _5x2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents _3x4ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents _4x3ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents _5x3ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents _3x5ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents _4x5ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents _5x4ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents _2x3ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents _2x4ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 遊玩模式ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 繪圖模式ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolMenuX700 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolMenuX800 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 其他ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 變更圖片ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TimerGame As System.Windows.Forms.Timer
    Friend WithEvents 顯示模式ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 左上ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 中ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 其他ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 說明ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 關於ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 作者ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 意見反饋ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 上ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 右上ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 左ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 右ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 左下ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 下ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 右下ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
