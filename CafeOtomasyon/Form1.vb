Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Bu kod satırı 'DataSet1.tablocuk' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
        Me.TablocukTableAdapter.Fill(Me.DataSet1.tablocuk)
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

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        tarihvesaat_Label1.Text = DateAndTime.Now.ToString()
        Try
            If DateAndTime.Now.Hour.ToString() = 17 And DateAndTime.Now.Minute.ToString() = 44 And DateAndTime.Now.Second.ToString() = 59 Then
                Me.TablocukBindingSource.AddNew()
                DateDateTimePicker.Value = DateAndTime.Now
                SayiTextBox.Text = sayi_Label3.Text
                Me.TablocukBindingSource.EndEdit()
                'Me.Validate()
                Me.TableAdapterManager.UpdateAll(Me.DataSet1)
                SayiTextBox.Text = 0
                MessageBox.Show("Hello World")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub TablocukBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TablocukBindingNavigatorSaveItem.Click
        DateDateTimePicker.Value = DateAndTime.Now
        SayiTextBox.Text = sayi_Label3.Text
        Me.TablocukBindingSource.EndEdit()
        'Me.Validate()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)
    End Sub
    Private Sub yeni_button_Click(sender As Object, e As EventArgs) Handles yeni_button.Click
        Me.TablocukBindingSource.AddNew()
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Try
            SerialPort1.PortName = portlar_ComboBox1.Text
            SerialPort1.BaudRate = boudrate_ComboBox2.Text
            SerialPort1.Open()
            Dim okunan = SerialPort1.ReadLine()
            If okunan = 1 Then
                Dim sonuc = sayi_Label3.Text + 1
                sayi_Label3.Text = sonuc
            End If
            SerialPort1.Close()
            'SerialPort1.WriteLine(gonder_TextBox1.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
