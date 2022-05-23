Public Class Form1

    Dim blnTimerWork As Boolean = False
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim DayString, TimeString As String '用來顯示日期與時間字串變數
        'DayString = Format(Now, "Long Date") '指定DayString為時間格式為有西元年的日期
        DayString = Format(Now, "yyyy/MM/dd") '指定DayString為時間格式為有西元年的日期
        'TimeString = Format(Now, "AMPM(hh:mm:ss)") 'Format(Now, "AMPM hh:mm:ss") '指定TimeString為時間格式AMPM hh:mm:ss
        TimeString = TimeOfDay.ToString("tt h:mm:ss ")
        Label1.Text = DayString + Space(1) + TimeString '將結果Show在Label1(space(1)為空一格)

        Try
            Dim FileNum As Integer
            Dim strTemp As String
            FileNum = FreeFile()
            FileOpen(FileNum, My.Computer.FileSystem.CurrentDirectory() & "\TIMER.ini", OpenMode.Input)

            Do Until EOF(FileNum)
                strTemp = LineInput(FileNum)

                If InStr(1, strTemp, "SETH.Text") Then
                    SETH.Text = Mid(strTemp, 11, strTemp.Length)
                ElseIf InStr(1, strTemp, "SETM.Text") Then
                    SETM.Text = Mid(strTemp, 11, strTemp.Length)
                ElseIf InStr(1, strTemp, "SETS.Text") Then
                    SETS.Text = Mid(strTemp, 11, strTemp.Length)
                ElseIf InStr(1, strTemp, "GOH.Text") Then
                    GOH.Text = Mid(strTemp, 10, strTemp.Length)
                ElseIf InStr(1, strTemp, "GOM.Text") Then
                    GOM.Text = Mid(strTemp, 10, strTemp.Length)
                ElseIf InStr(1, strTemp, "GOS.Text") Then
                    GOS.Text = Mid(strTemp, 10, strTemp.Length)
                End If
            Loop

            FileClose(FileNum)
        Catch ex As Exception

        End Try

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim DayString, TimeString As String '用來顯示日期與時間字串變數
        'DayString = Format(Now, "Long Date") '指定DayString為時間格式為有西元年的日期
        DayString = Format(Now, "yyyy/MM/dd") '指定DayString為時間格式為有西元年的日期
        'TimeString = Format(Now, "AMPM(hh:mm:ss)") 'Format(Now, "AMPM hh:mm:ss") '指定TimeString為時間格式AMPM hh:mm:ss
        TimeString = TimeOfDay.ToString("tt h:mm:ss ")
        Label1.Text = DayString + Space(1) + TimeString '將結果Show在Label1(space(1)為空一格)
        If blnTimerWork = True Then
            ' GOS.Text = "0" : GOM.Text = "0" : GOH.Text = "0"
            Timer2.Interval = 1000
            Timer2.Enabled = True
            Timer2.Start()
            blnTimerWork = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Dim FileNum As Integer
        Dim strTemp As String
        Dim strTemp2 As String = ""
        Dim DayString, TimeString As String '用來顯示日期與時間字串變數
        FileNum = FreeFile()
        FileOpen(FileNum, My.Computer.FileSystem.CurrentDirectory() & "\TIMER.ini", OpenMode.Output)
        DayString = Format(Now, "yyyy/MM/dd") '指定DayString為時間格式為有西元年的日期
        TimeString = TimeOfDay.ToString("tt h:mm:ss ")
        strTemp = "," + DayString + Space(1) + TimeString '將結果Show在Label1(space(1)為空一格)
        PrintLine(FileNum, strTemp)
        strTemp2 &= strTemp & vbNewLine

        'SET
        strTemp = "SETH.Text=" & SETH.Text
        PrintLine(FileNum, strTemp)
        strTemp = "SETM.Text=" & SETM.Text
        PrintLine(FileNum, strTemp)
        strTemp = "SETS.Text=" & SETS.Text
        PrintLine(FileNum, strTemp)

        'GO
        strTemp = "GOH.Text=" & GOH.Text
        PrintLine(FileNum, strTemp)
        strTemp = "GOM.Text=" & GOM.Text
        PrintLine(FileNum, strTemp)
        strTemp = "GOS.Text=" & GOS.Text
        PrintLine(FileNum, strTemp)


        'If CheckBox1.Checked = True Then
        '    strTemp = CheckBox1.Name & "=True"
        '    PrintLine(FileNum, strTemp)
        'End If

        'If COMPORTSAVE.Checked = True Then
        '    strTemp = COMPORTSAVE.Name & "=True"
        '    PrintLine(FileNum, strTemp)
        'End If

        'If strWorKCOMPort <> "" Then
        '    strTemp = strWorKCOMPort
        '    PrintLine(FileNum, strTemp)
        'End If

        'Select Case (TabControl1.SelectedIndex)
        '    Case 0
        '        strTemp = "TabControl1.SelectedIndex=0"
        '        PrintLine(FileNum, strTemp)
        '    Case 1
        '        strTemp = "TabControl1.SelectedIndex=1"
        '        PrintLine(FileNum, strTemp)
        '    Case 2
        '        strTemp = "TabControl1.SelectedIndex=2"
        '        PrintLine(FileNum, strTemp)
        'End Select

      


        'For index As Integer = 0 To REG.Count - 1
        '    If REG(index).BackColor = Color.Yellow Then
        '        strTemp = REG(index).Name & "=" & "Color.Yellow"
        '        PrintLine(FileNum, strTemp)
        '    ElseIf REG(index).BackColor = Color.Pink Then
        '        strTemp = REG(index).Name & "=" & "Color.Pink"
        '        PrintLine(FileNum, strTemp)
        '    ElseIf REG(index).BackColor = Color.LightBlue Then
        '        strTemp = REG(index).Name & "=" & "Color.LightBlue"
        '        PrintLine(FileNum, strTemp)
        '        'ElseIf REG(index).BackColor = Color.Empty Then
        '        '    strTemp = REG(index).Name
        '        '    PrintLine(FileNum, strTemp)
        '    End If
        '    'strTemp = TextBox1.Text & "," & Mid(REG(index).Name, 4, 2) & "," & REG(index).Text
        '    'PrintLine(FileNum, strTemp)
        '    'strTemp2 &= strTemp & vbNewLine
        'Next

        FileClose(FileNum)

        Me.Close()

    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim S As Integer = 0 : Dim G As Integer = 0

        S = (Integer.Parse(SETH.Text) * 60 * 60) + (Integer.Parse(SETM.Text) * 60) + Integer.Parse(SETS.Text)
        G = (Integer.Parse(GOH.Text) * 60 * 60) + (Integer.Parse(GOM.Text) * 60) + Integer.Parse(GOS.Text)
        'If G >= S Then
        '    MsgBox("計時時間比設定時間長", vbCritical)
        'Else
        If Integer.Parse(SETH.Text) > 59 Then
            MsgBox("時鐘設定錯誤>59", vbCritical + MsgBoxStyle.MsgBoxSetForeground)
            'InputBox("時鐘設定錯誤>59", "", , Me.Location.X, Me.Location.Y) '但是InputBox可以调整位置
            SETH.Text = "59"
        ElseIf Integer.Parse(SETM.Text) > 59 Then
            MsgBox("分鐘設定錯誤>59", vbCritical + MsgBoxStyle.MsgBoxSetForeground)
            SETM.Text = "59"
        ElseIf Integer.Parse(SETS.Text) > 59 Then
            MsgBox("秒鐘設定錯誤>59", vbCritical + MsgBoxStyle.MsgBoxSetForeground)
            SETS.Text = "59"
        ElseIf Integer.Parse(GOH.Text) > 59 Then
            MsgBox("計時時鐘設定錯誤>59", vbCritical + MsgBoxStyle.MsgBoxSetForeground)
            GOH.Text = "0"
        ElseIf Integer.Parse(GOM.Text) > 59 Then
            MsgBox("計時分鐘設定錯誤>59", vbCritical + MsgBoxStyle.MsgBoxSetForeground)
            GOM.Text = "0"
        ElseIf Integer.Parse(GOS.Text) > 59 Then
            MsgBox("計時秒鐘設定錯誤>59", vbCritical + MsgBoxStyle.MsgBoxSetForeground)
            GOS.Text = "0"
        Else
            GOH.Text = "0" : GOM.Text = "0" : GOS.Text = "0"
            blnTimerWork = True
            btnChancel.Text = "停止"
            btnChancel.BackColor = Color.Yellow
            Me.BackColor = Color.Red

            '  Me.TopMost = True
        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If SETH.Text = GOH.Text _
         And SETM.Text = GOM.Text And SETM.Text = GOM.Text _
         And SETS.Text = GOS.Text Then

            Timer2.Stop()
            Timer2.Enabled = False
            btnChancel.Text = "清除"
            btnChancel.BackColor = Color.Empty
            MsgBox("計時器，時間已經到了", vbCritical + MsgBoxStyle.MsgBoxSetForeground)

            btnChancel.BackColor = Color.Empty
            Me.BackColor = Color.Empty
            '  Me.TopMost = False
        Else
            GOS.Text = Integer.Parse(GOS.Text) + 1

            If (Integer.Parse(GOS.Text)) >= 60 Then
                GOS.Text = "0"
                If (Integer.Parse(GOM.Text) + 1) >= 60 Then
                    GOM.Text = "0"
                    GOH.Text = Integer.Parse(GOH.Text) + 1
                Else
                    GOM.Text = Integer.Parse(GOM.Text) + 1
                End If


            End If

            'If btnChancel.BackColor = Color.Red Then
            '    btnChancel.BackColor = Color.Empty
            'Else
            '    btnChancel.BackColor = Color.Red
            'End If

            If Me.BackColor = Color.Red Then
                Me.BackColor = Color.Empty
            Else
                Me.BackColor = Color.Red
            End If


        End If
    End Sub

    Private Sub btnChancel_Click(sender As Object, e As EventArgs) Handles btnChancel.Click
        If Timer2.Enabled = True Then
            Timer2.Stop()
            Timer2.Enabled = False
            btnChancel.Text = "清除"
            btnChancel.BackColor = Color.Empty
            MsgBox("計時器已經取消", vbCritical + MsgBoxStyle.MsgBoxSetForeground)
        Else
            GOH.Text = "0" : GOM.Text = "0" : GOS.Text = "0"
        End If

        btnChancel.BackColor = Color.Empty
        Me.BackColor = Color.Empty

    End Sub

    Private Sub SETH_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SETH.KeyPress
        If Asc(e.KeyChar) = 13 Then
            CheckKeyin(sender)
        End If
    End Sub
    Sub CheckKeyin(ByVal Keyin As Object)
        If Integer.Parse(Keyin.Text) > 59 Then
            Keyin.Text = "0"
        End If
    End Sub
End Class
