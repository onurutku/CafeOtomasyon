Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim portlar = System.IO.Ports.SerialPort.GetPortNames()
        For Each port In portlar
            Try
                portlar_ComboBox1.Items.Clear()
                portlar_ComboBox1.Items.Add(port)
            Catch ex As Exception
            End Try
        Next
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim portlar = System.IO.Ports.SerialPort.GetPortNames()
        For Each port In portlar
            Try
                portlar_ComboBox1.Items.Clear()
                portlar_ComboBox1.Items.Add(port)
            Catch ex As Exception
            End Try
        Next
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer2.Enabled = True
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        SerialPort1.PortName = portlar_ComboBox1.Text
        SerialPort1.BaudRate = boudrate_ComboBox2.Text
        SerialPort1.Open()
        Dim okunan = SerialPort1.ReadLine()
        If okunan = 1 Then
            Dim sonuc = sayi_Label3.Text + 1
            sayi_Label3.Text = sonuc
        End If
        SerialPort1.Close()
    End Sub
End Class
