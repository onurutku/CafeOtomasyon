<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.portlar_ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.boudrate_ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.sayi_Label3 = New System.Windows.Forms.Label()
        Me.okunan_Label4 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.gonder_TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'portlar_ComboBox1
        '
        Me.portlar_ComboBox1.FormattingEnabled = True
        Me.portlar_ComboBox1.Location = New System.Drawing.Point(7, 7)
        Me.portlar_ComboBox1.Name = "portlar_ComboBox1"
        Me.portlar_ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.portlar_ComboBox1.TabIndex = 1
        Me.portlar_ComboBox1.Text = "Serial Port Seç..."
        '
        'boudrate_ComboBox2
        '
        Me.boudrate_ComboBox2.FormattingEnabled = True
        Me.boudrate_ComboBox2.Items.AddRange(New Object() {"110", "300", "600", "1200", "2400", "4800", "9600", "14400", "19200", "38400", "57600", "115200", "128000", "256000"})
        Me.boudrate_ComboBox2.Location = New System.Drawing.Point(7, 34)
        Me.boudrate_ComboBox2.Name = "boudrate_ComboBox2"
        Me.boudrate_ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.boudrate_ComboBox2.TabIndex = 4
        Me.boudrate_ComboBox2.Text = "BoudRate Seç..."
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(7, 62)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(121, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Bağlan"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'sayi_Label3
        '
        Me.sayi_Label3.AutoSize = True
        Me.sayi_Label3.Location = New System.Drawing.Point(134, 67)
        Me.sayi_Label3.Name = "sayi_Label3"
        Me.sayi_Label3.Size = New System.Drawing.Size(13, 13)
        Me.sayi_Label3.TabIndex = 7
        Me.sayi_Label3.Text = "0"
        '
        'okunan_Label4
        '
        Me.okunan_Label4.AutoSize = True
        Me.okunan_Label4.Location = New System.Drawing.Point(169, 67)
        Me.okunan_Label4.Name = "okunan_Label4"
        Me.okunan_Label4.Size = New System.Drawing.Size(76, 13)
        Me.okunan_Label4.TabIndex = 8
        Me.okunan_Label4.Text = "Kişi Ziyaret Etti"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'gonder_TextBox1
        '
        Me.gonder_TextBox1.Location = New System.Drawing.Point(251, 65)
        Me.gonder_TextBox1.Name = "gonder_TextBox1"
        Me.gonder_TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.gonder_TextBox1.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(939, 607)
        Me.Controls.Add(Me.gonder_TextBox1)
        Me.Controls.Add(Me.okunan_Label4)
        Me.Controls.Add(Me.sayi_Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.boudrate_ComboBox2)
        Me.Controls.Add(Me.portlar_ComboBox1)
        Me.Name = "Form1"
        Me.Text = "G&O"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents portlar_ComboBox1 As ComboBox
    Friend WithEvents boudrate_ComboBox2 As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents sayi_Label3 As Label
    Friend WithEvents okunan_Label4 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Timer2 As Timer
    Friend WithEvents gonder_TextBox1 As TextBox
End Class
