<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormChangePicSum
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
        Me.NumUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.NumUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.butEnter = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.NumUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NumUpDown1
        '
        Me.NumUpDown1.Location = New System.Drawing.Point(39, 13)
        Me.NumUpDown1.Maximum = New Decimal(New Integer() {8, 0, 0, 0})
        Me.NumUpDown1.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.NumUpDown1.Name = "NumUpDown1"
        Me.NumUpDown1.Size = New System.Drawing.Size(64, 22)
        Me.NumUpDown1.TabIndex = 0
        Me.NumUpDown1.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'NumUpDown2
        '
        Me.NumUpDown2.Location = New System.Drawing.Point(39, 41)
        Me.NumUpDown2.Maximum = New Decimal(New Integer() {8, 0, 0, 0})
        Me.NumUpDown2.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.NumUpDown2.Name = "NumUpDown2"
        Me.NumUpDown2.Size = New System.Drawing.Size(64, 22)
        Me.NumUpDown2.TabIndex = 1
        Me.NumUpDown2.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'butEnter
        '
        Me.butEnter.Location = New System.Drawing.Point(119, 25)
        Me.butEnter.Name = "butEnter"
        Me.butEnter.Size = New System.Drawing.Size(54, 24)
        Me.butEnter.TabIndex = 2
        Me.butEnter.Text = "確認"
        Me.butEnter.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 12)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "寬:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 12)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "長:"
        '
        'FormChangePicSum
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(184, 71)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.butEnter)
        Me.Controls.Add(Me.NumUpDown2)
        Me.Controls.Add(Me.NumUpDown1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormChangePicSum"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "變更方塊數"
        CType(Me.NumUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NumUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumUpDown2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents butEnter As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
