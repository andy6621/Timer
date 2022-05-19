<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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

    '注意:  以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnChancel = New System.Windows.Forms.Button()
        Me.SETH = New System.Windows.Forms.TextBox()
        Me.SETM = New System.Windows.Forms.TextBox()
        Me.SETS = New System.Windows.Forms.TextBox()
        Me.GOH = New System.Windows.Forms.TextBox()
        Me.GOM = New System.Windows.Forms.TextBox()
        Me.GOS = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "0"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(339, 69)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 46)
        Me.btnStart.TabIndex = 2
        Me.btnStart.Text = "開始"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(339, 208)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 52)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "離開"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnChancel
        '
        Me.btnChancel.Location = New System.Drawing.Point(339, 136)
        Me.btnChancel.Name = "btnChancel"
        Me.btnChancel.Size = New System.Drawing.Size(75, 52)
        Me.btnChancel.TabIndex = 4
        Me.btnChancel.Text = "取消"
        Me.btnChancel.UseVisualStyleBackColor = True
        '
        'SETH
        '
        Me.SETH.Font = New System.Drawing.Font("微軟正黑體", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.SETH.Location = New System.Drawing.Point(78, 118)
        Me.SETH.Name = "SETH"
        Me.SETH.Size = New System.Drawing.Size(66, 50)
        Me.SETH.TabIndex = 5
        Me.SETH.Text = "0"
        Me.SETH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SETM
        '
        Me.SETM.Font = New System.Drawing.Font("微軟正黑體", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.SETM.Location = New System.Drawing.Point(167, 118)
        Me.SETM.Name = "SETM"
        Me.SETM.Size = New System.Drawing.Size(66, 50)
        Me.SETM.TabIndex = 5
        Me.SETM.Text = "0"
        Me.SETM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SETS
        '
        Me.SETS.Font = New System.Drawing.Font("微軟正黑體", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.SETS.Location = New System.Drawing.Point(257, 118)
        Me.SETS.Name = "SETS"
        Me.SETS.Size = New System.Drawing.Size(66, 50)
        Me.SETS.TabIndex = 5
        Me.SETS.Text = "0"
        Me.SETS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GOH
        '
        Me.GOH.Font = New System.Drawing.Font("微軟正黑體", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GOH.Location = New System.Drawing.Point(78, 207)
        Me.GOH.Name = "GOH"
        Me.GOH.Size = New System.Drawing.Size(66, 50)
        Me.GOH.TabIndex = 5
        Me.GOH.Text = "0"
        Me.GOH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GOM
        '
        Me.GOM.Font = New System.Drawing.Font("微軟正黑體", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GOM.Location = New System.Drawing.Point(167, 207)
        Me.GOM.Name = "GOM"
        Me.GOM.Size = New System.Drawing.Size(66, 50)
        Me.GOM.TabIndex = 5
        Me.GOM.Text = "0"
        Me.GOM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GOS
        '
        Me.GOS.Font = New System.Drawing.Font("微軟正黑體", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GOS.Location = New System.Drawing.Point(257, 207)
        Me.GOS.Name = "GOS"
        Me.GOS.Size = New System.Drawing.Size(66, 50)
        Me.GOS.TabIndex = 5
        Me.GOS.Text = "0"
        Me.GOS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微軟正黑體", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(86, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 40)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "時"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微軟正黑體", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(174, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 40)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "分"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("微軟正黑體", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.Location = New System.Drawing.Point(262, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 40)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "秒"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("微軟正黑體", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.Location = New System.Drawing.Point(130, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 40)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "："
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("微軟正黑體", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.Location = New System.Drawing.Point(221, 121)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 40)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "："
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("微軟正黑體", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label7.Location = New System.Drawing.Point(130, 210)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 40)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "："
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("微軟正黑體", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label8.Location = New System.Drawing.Point(221, 210)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 40)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "："
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("微軟正黑體", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label9.Location = New System.Drawing.Point(1, 121)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 40)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "設定"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("微軟正黑體", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label10.Location = New System.Drawing.Point(1, 210)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 40)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "結束"
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 289)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GOS)
        Me.Controls.Add(Me.SETS)
        Me.Controls.Add(Me.GOM)
        Me.Controls.Add(Me.SETM)
        Me.Controls.Add(Me.GOH)
        Me.Controls.Add(Me.SETH)
        Me.Controls.Add(Me.btnChancel)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Timer V1.0"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnChancel As System.Windows.Forms.Button
    Friend WithEvents SETH As System.Windows.Forms.TextBox
    Friend WithEvents SETM As System.Windows.Forms.TextBox
    Friend WithEvents SETS As System.Windows.Forms.TextBox
    Friend WithEvents GOH As System.Windows.Forms.TextBox
    Friend WithEvents GOM As System.Windows.Forms.TextBox
    Friend WithEvents GOS As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer

End Class
