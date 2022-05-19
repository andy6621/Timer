Public Class Form1

    Dim blnTimerWork As Boolean = False
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim DayString, TimeString As String '用來顯示日期與時間字串變數
        'DayString = Format(Now, "Long Date") '指定DayString為時間格式為有西元年的日期
        DayString = Format(Now, "yyyy/MM/dd") '指定DayString為時間格式為有西元年的日期
        'TimeString = Format(Now, "AMPM(hh:mm:ss)") 'Format(Now, "AMPM hh:mm:ss") '指定TimeString為時間格式AMPM hh:mm:ss
        TimeString = TimeOfDay.ToString("tt h:mm:ss ")
        Label1.Text = DayString + Space(1) + TimeString '將結果Show在Label1(space(1)為空一格)

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim DayString, TimeString As String '用來顯示日期與時間字串變數
        'DayString = Format(Now, "Long Date") '指定DayString為時間格式為有西元年的日期
        DayString = Format(Now, "yyyy/MM/dd") '指定DayString為時間格式為有西元年的日期
        'TimeString = Format(Now, "AMPM(hh:mm:ss)") 'Format(Now, "AMPM hh:mm:ss") '指定TimeString為時間格式AMPM hh:mm:ss
        TimeString = TimeOfDay.ToString("tt h:mm:ss ")
        Label1.Text = DayString + Space(1) + TimeString '將結果Show在Label1(space(1)為空一格)
        If blnTimerWork = True Then
            GOS.Text = "0" : GOM.Text = "0" : GOH.Text = "0"
            Timer2.Interval = 1000
            Timer2.Enabled = True
            Timer2.Start()
            blnTimerWork = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
       
        blnTimerWork = True
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If SETH.Text = GOH.Text _
         And SETM.Text = GOM.Text And SETM.Text = GOM.Text _
         And SETS.Text = GOS.Text Then

            Timer2.Stop()
            Timer2.Enabled = False
            MessageBox.Show("時間到了")
        Else
            If (Integer.Parse(GOS.Text) + 1) > 60 Then
                GOS.Text = "0"
                If (Integer.Parse(GOM.Text) + 1) > 60 Then
                    GOM.Text = "0"
                    GOH.Text = Integer.Parse(GOH.Text) + 1
                Else
                    GOM.Text = Integer.Parse(GOM.Text) + 1
                End If
            Else
                GOS.Text = Integer.Parse(GOS.Text) + 1
            End If
            End If
    End Sub

    Private Sub btnChancel_Click(sender As Object, e As EventArgs) Handles btnChancel.Click
        If Timer2.Enabled = True Then
            Timer2.Stop()
            Timer2.Enabled = False
            MessageBox.Show("計時器取消")
        End If
    End Sub
End Class
