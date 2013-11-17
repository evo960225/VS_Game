<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenage
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
        Me.ButStage1 = New System.Windows.Forms.Button()
        Me.ButStage2 = New System.Windows.Forms.Button()
        Me.ButStage3 = New System.Windows.Forms.Button()
        Me.ButStage4 = New System.Windows.Forms.Button()
        Me.ButMain = New System.Windows.Forms.Button()
        Me.ButOpening = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'ButStage1
        '
        Me.ButStage1.Location = New System.Drawing.Point(37, 114)
        Me.ButStage1.Name = "ButStage1"
        Me.ButStage1.Size = New System.Drawing.Size(71, 32)
        Me.ButStage1.TabIndex = 0
        Me.ButStage1.Text = "跳至第1關"
        Me.ButStage1.UseVisualStyleBackColor = True
        '
        'ButStage2
        '
        Me.ButStage2.Location = New System.Drawing.Point(37, 152)
        Me.ButStage2.Name = "ButStage2"
        Me.ButStage2.Size = New System.Drawing.Size(71, 32)
        Me.ButStage2.TabIndex = 1
        Me.ButStage2.Text = "跳至第2關"
        Me.ButStage2.UseVisualStyleBackColor = True
        '
        'ButStage3
        '
        Me.ButStage3.Location = New System.Drawing.Point(37, 190)
        Me.ButStage3.Name = "ButStage3"
        Me.ButStage3.Size = New System.Drawing.Size(71, 32)
        Me.ButStage3.TabIndex = 2
        Me.ButStage3.Text = "跳至第3關"
        Me.ButStage3.UseVisualStyleBackColor = True
        '
        'ButStage4
        '
        Me.ButStage4.Location = New System.Drawing.Point(37, 228)
        Me.ButStage4.Name = "ButStage4"
        Me.ButStage4.Size = New System.Drawing.Size(71, 32)
        Me.ButStage4.TabIndex = 3
        Me.ButStage4.Text = "跳至第4關"
        Me.ButStage4.UseVisualStyleBackColor = True
        '
        'ButMain
        '
        Me.ButMain.Location = New System.Drawing.Point(37, 67)
        Me.ButMain.Name = "ButMain"
        Me.ButMain.Size = New System.Drawing.Size(100, 32)
        Me.ButMain.TabIndex = 4
        Me.ButMain.Text = "跳至主畫面"
        Me.ButMain.UseVisualStyleBackColor = True
        '
        'ButOpening
        '
        Me.ButOpening.Enabled = False
        Me.ButOpening.Location = New System.Drawing.Point(37, 29)
        Me.ButOpening.Name = "ButOpening"
        Me.ButOpening.Size = New System.Drawing.Size(100, 32)
        Me.ButOpening.TabIndex = 0
        Me.ButOpening.Text = "跳至開始動畫"
        Me.ButOpening.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(401, 228)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(37, 32)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 12
        Me.ListBox1.Location = New System.Drawing.Point(160, 65)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(63, 208)
        Me.ListBox1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(163, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 12)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "player"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(251, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 12)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "com"
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 12
        Me.ListBox2.Location = New System.Drawing.Point(239, 67)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(58, 208)
        Me.ListBox2.TabIndex = 9
        '
        'FormMenage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 323)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButOpening)
        Me.Controls.Add(Me.ButMain)
        Me.Controls.Add(Me.ButStage4)
        Me.Controls.Add(Me.ButStage3)
        Me.Controls.Add(Me.ButStage2)
        Me.Controls.Add(Me.ButStage1)
        Me.Name = "FormMenage"
        Me.Text = "開發人員命令"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButStage1 As System.Windows.Forms.Button
    Friend WithEvents ButStage2 As System.Windows.Forms.Button
    Friend WithEvents ButStage3 As System.Windows.Forms.Button
    Friend WithEvents ButStage4 As System.Windows.Forms.Button
    Friend WithEvents ButMain As System.Windows.Forms.Button
    Friend WithEvents ButOpening As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
End Class
