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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
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
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(4, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 21)
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
        Me.btnStart.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnStart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnStart.Location = New System.Drawing.Point(174, 30)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(50, 30)
        Me.btnStart.TabIndex = 2
        Me.btnStart.Text = "開始"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExit.Location = New System.Drawing.Point(174, 102)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(50, 30)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "離開"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnChancel
        '
        Me.btnChancel.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnChancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnChancel.Location = New System.Drawing.Point(174, 66)
        Me.btnChancel.Name = "btnChancel"
        Me.btnChancel.Size = New System.Drawing.Size(50, 30)
        Me.btnChancel.TabIndex = 4
        Me.btnChancel.Text = "清除"
        Me.btnChancel.UseVisualStyleBackColor = True
        '
        'SETH
        '
        Me.SETH.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.SETH.Location = New System.Drawing.Point(45, 47)
        Me.SETH.MaxLength = 2
        Me.SETH.Name = "SETH"
        Me.SETH.Size = New System.Drawing.Size(29, 29)
        Me.SETH.TabIndex = 5
        Me.SETH.Text = "0"
        Me.SETH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SETM
        '
        Me.SETM.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.SETM.Location = New System.Drawing.Point(92, 47)
        Me.SETM.MaxLength = 2
        Me.SETM.Name = "SETM"
        Me.SETM.Size = New System.Drawing.Size(29, 29)
        Me.SETM.TabIndex = 5
        Me.SETM.Text = "0"
        Me.SETM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SETS
        '
        Me.SETS.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.SETS.Location = New System.Drawing.Point(139, 47)
        Me.SETS.MaxLength = 2
        Me.SETS.Name = "SETS"
        Me.SETS.Size = New System.Drawing.Size(29, 29)
        Me.SETS.TabIndex = 5
        Me.SETS.Text = "0"
        Me.SETS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GOH
        '
        Me.GOH.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GOH.Location = New System.Drawing.Point(45, 92)
        Me.GOH.MaxLength = 2
        Me.GOH.Name = "GOH"
        Me.GOH.Size = New System.Drawing.Size(29, 29)
        Me.GOH.TabIndex = 5
        Me.GOH.Text = "0"
        Me.GOH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GOM
        '
        Me.GOM.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GOM.Location = New System.Drawing.Point(92, 92)
        Me.GOM.MaxLength = 2
        Me.GOM.Name = "GOM"
        Me.GOM.Size = New System.Drawing.Size(29, 29)
        Me.GOM.TabIndex = 5
        Me.GOM.Text = "0"
        Me.GOM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GOS
        '
        Me.GOS.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GOS.Location = New System.Drawing.Point(139, 92)
        Me.GOS.MaxLength = 2
        Me.GOS.Name = "GOS"
        Me.GOS.Size = New System.Drawing.Size(29, 29)
        Me.GOS.TabIndex = 5
        Me.GOS.Text = "0"
        Me.GOS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(53, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "時"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(100, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "分"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(147, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "秒"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.Location = New System.Drawing.Point(69, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 21)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "："
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.Location = New System.Drawing.Point(116, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 21)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "："
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label7.Location = New System.Drawing.Point(69, 95)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 21)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "："
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label8.Location = New System.Drawing.Point(116, 95)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 21)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "："
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(5, 54)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 17)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "設定"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(5, 95)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 17)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "計時"
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(230, 136)
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
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
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
