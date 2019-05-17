<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.weekday = New System.Windows.Forms.Label()
        Me.Data = New System.Windows.Forms.Label()
        Me.clock = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.alarm_label = New System.Windows.Forms.Label()
        Me.ring_off = New System.Windows.Forms.Button()
        Me.alarm_onoff = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.stopwatchLabel = New System.Windows.Forms.Label()
        Me.clockTimer = New System.Windows.Forms.Timer(Me.components)
        Me.alarm = New System.Windows.Forms.Timer(Me.components)
        Me.stopwatch = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.weekday)
        Me.GroupBox1.Controls.Add(Me.Data)
        Me.GroupBox1.Controls.Add(Me.clock)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(470, 118)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Часы"
        '
        'weekday
        '
        Me.weekday.AutoSize = True
        Me.weekday.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.weekday.Location = New System.Drawing.Point(297, 70)
        Me.weekday.Name = "weekday"
        Me.weekday.Size = New System.Drawing.Size(0, 31)
        Me.weekday.TabIndex = 2
        Me.weekday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Data
        '
        Me.Data.AutoSize = True
        Me.Data.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Data.Location = New System.Drawing.Point(6, 70)
        Me.Data.Name = "Data"
        Me.Data.Size = New System.Drawing.Size(0, 31)
        Me.Data.TabIndex = 1
        '
        'clock
        '
        Me.clock.AutoSize = True
        Me.clock.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clock.Location = New System.Drawing.Point(154, 16)
        Me.clock.Name = "clock"
        Me.clock.Size = New System.Drawing.Size(0, 39)
        Me.clock.TabIndex = 0
        Me.clock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.ComboBox3)
        Me.GroupBox2.Controls.Add(Me.ComboBox2)
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.alarm_label)
        Me.GroupBox2.Controls.Add(Me.ring_off)
        Me.GroupBox2.Controls.Add(Me.alarm_onoff)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Location = New System.Drawing.Point(12, 137)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(232, 179)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Будильник"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(148, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(12, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = ":"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(79, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(12, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = ":"
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59"})
        Me.ComboBox3.Location = New System.Drawing.Point(166, 42)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(45, 21)
        Me.ComboBox3.TabIndex = 6
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59"})
        Me.ComboBox2.Location = New System.Drawing.Point(97, 42)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(45, 21)
        Me.ComboBox2.TabIndex = 5
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        Me.ComboBox1.Location = New System.Drawing.Point(28, 42)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(45, 21)
        Me.ComboBox1.TabIndex = 4
        '
        'alarm_label
        '
        Me.alarm_label.AutoSize = True
        Me.alarm_label.Location = New System.Drawing.Point(58, 16)
        Me.alarm_label.Name = "alarm_label"
        Me.alarm_label.Size = New System.Drawing.Size(115, 13)
        Me.alarm_label.TabIndex = 0
        Me.alarm_label.Text = "Будильник выключен"
        Me.alarm_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ring_off
        '
        Me.ring_off.BackColor = System.Drawing.SystemColors.Control
        Me.ring_off.ForeColor = System.Drawing.Color.Black
        Me.ring_off.Location = New System.Drawing.Point(27, 122)
        Me.ring_off.Name = "ring_off"
        Me.ring_off.Size = New System.Drawing.Size(178, 36)
        Me.ring_off.TabIndex = 3
        Me.ring_off.Text = "Выключить звонок"
        Me.ring_off.UseVisualStyleBackColor = False
        '
        'alarm_onoff
        '
        Me.alarm_onoff.BackColor = System.Drawing.SystemColors.Control
        Me.alarm_onoff.ForeColor = System.Drawing.Color.Black
        Me.alarm_onoff.Location = New System.Drawing.Point(27, 74)
        Me.alarm_onoff.Name = "alarm_onoff"
        Me.alarm_onoff.Size = New System.Drawing.Size(178, 42)
        Me.alarm_onoff.TabIndex = 2
        Me.alarm_onoff.Text = "Включить будильник"
        Me.alarm_onoff.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.stopwatchLabel)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Location = New System.Drawing.Point(250, 137)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(232, 179)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Секундомер"
        '
        'Button2
        '
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(118, 84)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 61)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Сбросить"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(37, 84)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 61)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Запустить"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'stopwatchLabel
        '
        Me.stopwatchLabel.AutoSize = True
        Me.stopwatchLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stopwatchLabel.Location = New System.Drawing.Point(60, 32)
        Me.stopwatchLabel.Name = "stopwatchLabel"
        Me.stopwatchLabel.Size = New System.Drawing.Size(0, 31)
        Me.stopwatchLabel.TabIndex = 0
        Me.stopwatchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'clockTimer
        '
        Me.clockTimer.Enabled = True
        Me.clockTimer.Interval = 1000
        '
        'alarm
        '
        Me.alarm.Interval = 1000
        '
        'stopwatch
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(498, 328)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Alarm Clock"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents clock As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents clockTimer As System.Windows.Forms.Timer
    Friend WithEvents Data As System.Windows.Forms.Label
    Friend WithEvents weekday As System.Windows.Forms.Label
    Friend WithEvents ring_off As System.Windows.Forms.Button
    Friend WithEvents alarm_onoff As System.Windows.Forms.Button
    Friend WithEvents alarm_label As System.Windows.Forms.Label
    Friend WithEvents alarm As System.Windows.Forms.Timer
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents stopwatchLabel As System.Windows.Forms.Label
    Friend WithEvents stopwatch As System.Windows.Forms.Timer
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
