Public Class Form1
    Dim time As String
    Dim alarm_set As Boolean
    Dim alarm_time1 As String
    Sub alarm_on()
        alarm_set = True
        alarm_label.Text = "Будильник установлен на"
        alarm_onoff.Text = "Выключить будильник"
    End Sub
    Sub alarm_off()
        alarm_set = False
        alarm_label.Text = "Будильник выключен"
        alarm_onoff.Text = "Включить будильник"
        alarm.Enabled = False
        ring_off.Enabled = False
    End Sub
    Sub day_change()
        Data.Text = Format(Now, "Long Date")
        weekday.Text = Format(Now, "dddd")
    End Sub
    Sub alarm_ring()
        Beep()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        day_change()
        alarm_off()
        zero_stopwatch()
        stop_stopwatch()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles clockTimer.Tick
        time = Format(Now, "HH:mm:ss")
        clock.Text = time
        If time = "00:00:00" Then day_change()
        If time = alarm_time1 And alarm_set = True Then alarm.Enabled = True : ring_off.Enabled = True
    End Sub

    Private Sub alarm_Tick(sender As Object, e As EventArgs) Handles alarm.Tick
        alarm_ring()
    End Sub

    Private Sub alarm_onoff_Click(sender As Object, e As EventArgs) Handles alarm_onoff.Click
        If alarm_set = False Then alarm_on() Else alarm_off()
        alarm_time1 = ComboBox1.SelectedItem & ":" & ComboBox2.SelectedItem & ":" & ComboBox3.SelectedItem
    End Sub

    Private Sub ring_off_Click(sender As Object, e As EventArgs) Handles ring_off.Click
        alarm.Enabled = False
    End Sub
    Enum mode
        counting
        pause
        zero
    End Enum
    Sub zero_stopwatch()
        stopwatchLabel.Text = "00:00.00"
        sec_pause = 0
        stopwatch_mode = mode.zero
        stopwatch.Enabled = False
        Button1.Text = "Запустить"
    End Sub
    Sub stop_stopwatch()
        sec_pause = sec_on_stopwatch
        stopwatch_mode = mode.pause
        stopwatch.Enabled = False
        Button1.Text = "Запустить"
    End Sub
    Sub start_stopwatch()
        sec_start = DateAndTime.Timer
        stopwatch_mode = mode.counting
        stopwatch.Enabled = True
        Button1.Text = "Остановить"
    End Sub
    Dim sec_start As Double = DateAndTime.Timer
    Dim sec_pause As Double
    Dim sec_on_stopwatch As Double
    Dim stopwatch_mode As mode
    Private Sub stopwatch_Tick(sender As Object, e As EventArgs) Handles stopwatch.Tick
        Dim stopwatchTime As Date
        Const midnight As Date = #12:00:00 AM#
        sec_on_stopwatch = DateAndTime.Timer - sec_start + sec_pause
        stopwatchTime = midnight.AddSeconds(sec_on_stopwatch)
        stopwatchLabel.Text = Format(stopwatchTime, "mm:ss.ff")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If stopwatch_mode <> mode.counting Then start_stopwatch() Else stop_stopwatch()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        zero_stopwatch()
    End Sub
End Class
