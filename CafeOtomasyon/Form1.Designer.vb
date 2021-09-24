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
        Dim IdLabel As System.Windows.Forms.Label
        Dim SayiLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.portlar_ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.boudrate_ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.sayi_Label3 = New System.Windows.Forms.Label()
        Me.okunan_Label4 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.tarihvesaat_Label1 = New System.Windows.Forms.Label()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.DataSet1 = New CafeOtomasyon.DataSet1()
        Me.TablocukBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TablocukTableAdapter = New CafeOtomasyon.DataSet1TableAdapters.tablocukTableAdapter()
        Me.TableAdapterManager = New CafeOtomasyon.DataSet1TableAdapters.TableAdapterManager()
        Me.TablocukBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TablocukBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.yeni_button = New System.Windows.Forms.ToolStripButton()
        Me.TablocukDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.SayiTextBox = New System.Windows.Forms.TextBox()
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        IdLabel = New System.Windows.Forms.Label()
        SayiLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TablocukBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TablocukBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TablocukBindingNavigator.SuspendLayout()
        CType(Me.TablocukDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(190, 461)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(18, 13)
        IdLabel.TabIndex = 12
        IdLabel.Text = "id:"
        '
        'SayiLabel
        '
        SayiLabel.AutoSize = True
        SayiLabel.Location = New System.Drawing.Point(190, 487)
        SayiLabel.Name = "SayiLabel"
        SayiLabel.Size = New System.Drawing.Size(28, 13)
        SayiLabel.TabIndex = 14
        SayiLabel.Text = "sayi:"
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Location = New System.Drawing.Point(190, 514)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(31, 13)
        DateLabel.TabIndex = 16
        DateLabel.Text = "date:"
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
        Me.boudrate_ComboBox2.Location = New System.Drawing.Point(134, 7)
        Me.boudrate_ComboBox2.Name = "boudrate_ComboBox2"
        Me.boudrate_ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.boudrate_ComboBox2.TabIndex = 4
        Me.boudrate_ComboBox2.Text = "BoudRate Seç..."
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(263, 7)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(121, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Bağlan"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'sayi_Label3
        '
        Me.sayi_Label3.AutoSize = True
        Me.sayi_Label3.Location = New System.Drawing.Point(390, 10)
        Me.sayi_Label3.Name = "sayi_Label3"
        Me.sayi_Label3.Size = New System.Drawing.Size(13, 13)
        Me.sayi_Label3.TabIndex = 7
        Me.sayi_Label3.Text = "0"
        '
        'okunan_Label4
        '
        Me.okunan_Label4.AutoSize = True
        Me.okunan_Label4.Location = New System.Drawing.Point(425, 10)
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
        Me.Timer2.Interval = 10
        '
        'tarihvesaat_Label1
        '
        Me.tarihvesaat_Label1.Location = New System.Drawing.Point(508, 10)
        Me.tarihvesaat_Label1.Name = "tarihvesaat_Label1"
        Me.tarihvesaat_Label1.Size = New System.Drawing.Size(235, 23)
        Me.tarihvesaat_Label1.TabIndex = 9
        Me.tarihvesaat_Label1.Text = "tarih ve saat"
        '
        'Timer3
        '
        Me.Timer3.Enabled = True
        Me.Timer3.Interval = 1000
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TablocukBindingSource
        '
        Me.TablocukBindingSource.DataMember = "tablocuk"
        Me.TablocukBindingSource.DataSource = Me.DataSet1
        '
        'TablocukTableAdapter
        '
        Me.TablocukTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tablocukTableAdapter = Me.TablocukTableAdapter
        Me.TableAdapterManager.UpdateOrder = CafeOtomasyon.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TablocukBindingNavigator
        '
        Me.TablocukBindingNavigator.AddNewItem = Nothing
        Me.TablocukBindingNavigator.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TablocukBindingNavigator.AutoSize = False
        Me.TablocukBindingNavigator.BindingSource = Me.TablocukBindingSource
        Me.TablocukBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TablocukBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TablocukBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.TablocukBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorDeleteItem, Me.TablocukBindingNavigatorSaveItem, Me.yeni_button})
        Me.TablocukBindingNavigator.Location = New System.Drawing.Point(7, 31)
        Me.TablocukBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TablocukBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TablocukBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TablocukBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TablocukBindingNavigator.Name = "TablocukBindingNavigator"
        Me.TablocukBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TablocukBindingNavigator.Size = New System.Drawing.Size(287, 29)
        Me.TablocukBindingNavigator.TabIndex = 10
        Me.TablocukBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(29, 26)
        Me.BindingNavigatorCountItem.Text = "/ {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Toplam öğe sayısı"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 26)
        Me.BindingNavigatorDeleteItem.Text = "Sil"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 26)
        Me.BindingNavigatorMoveFirstItem.Text = "Başa taşı"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 26)
        Me.BindingNavigatorMovePreviousItem.Text = "Öne taşı"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 29)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Konum"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Geçerli konum"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 29)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 26)
        Me.BindingNavigatorMoveNextItem.Text = "Arkaya taşı"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 26)
        Me.BindingNavigatorMoveLastItem.Text = "Sona taşı"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 29)
        '
        'TablocukBindingNavigatorSaveItem
        '
        Me.TablocukBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TablocukBindingNavigatorSaveItem.Image = CType(resources.GetObject("TablocukBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TablocukBindingNavigatorSaveItem.Name = "TablocukBindingNavigatorSaveItem"
        Me.TablocukBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 26)
        Me.TablocukBindingNavigatorSaveItem.Text = "Veriyi Sakla"
        '
        'yeni_button
        '
        Me.yeni_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.yeni_button.Image = CType(resources.GetObject("yeni_button.Image"), System.Drawing.Image)
        Me.yeni_button.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.yeni_button.Name = "yeni_button"
        Me.yeni_button.Size = New System.Drawing.Size(23, 26)
        Me.yeni_button.Text = "ToolStripButton1"
        '
        'TablocukDataGridView
        '
        Me.TablocukDataGridView.AutoGenerateColumns = False
        Me.TablocukDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TablocukDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.TablocukDataGridView.DataSource = Me.TablocukBindingSource
        Me.TablocukDataGridView.Location = New System.Drawing.Point(7, 63)
        Me.TablocukDataGridView.Name = "TablocukDataGridView"
        Me.TablocukDataGridView.Size = New System.Drawing.Size(610, 515)
        Me.TablocukDataGridView.TabIndex = 10
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.DividerWidth = 1
        Me.DataGridViewTextBoxColumn1.FillWeight = 200.0!
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 200
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "sayi"
        Me.DataGridViewTextBoxColumn2.FillWeight = 200.0!
        Me.DataGridViewTextBoxColumn2.HeaderText = "sayi"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "date"
        Me.DataGridViewTextBoxColumn3.FillWeight = 200.0!
        Me.DataGridViewTextBoxColumn3.HeaderText = "date"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 200
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(297, 36)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(211, 20)
        Me.DateTimePicker1.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(514, 35)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TablocukBindingSource, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(227, 458)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IdTextBox.TabIndex = 13
        '
        'SayiTextBox
        '
        Me.SayiTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TablocukBindingSource, "sayi", True))
        Me.SayiTextBox.Location = New System.Drawing.Point(227, 484)
        Me.SayiTextBox.Name = "SayiTextBox"
        Me.SayiTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SayiTextBox.TabIndex = 15
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TablocukBindingSource, "date", True))
        Me.DateDateTimePicker.Location = New System.Drawing.Point(227, 510)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DateDateTimePicker.TabIndex = 17
        '
        'Timer4
        '
        Me.Timer4.Enabled = True
        Me.Timer4.Interval = 59000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 582)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TablocukDataGridView)
        Me.Controls.Add(Me.TablocukBindingNavigator)
        Me.Controls.Add(Me.tarihvesaat_Label1)
        Me.Controls.Add(Me.okunan_Label4)
        Me.Controls.Add(Me.sayi_Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.boudrate_ComboBox2)
        Me.Controls.Add(Me.portlar_ComboBox1)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(SayiLabel)
        Me.Controls.Add(Me.SayiTextBox)
        Me.Controls.Add(DateLabel)
        Me.Controls.Add(Me.DateDateTimePicker)
        Me.Name = "Form1"
        Me.Text = "G&O"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TablocukBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TablocukBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TablocukBindingNavigator.ResumeLayout(False)
        Me.TablocukBindingNavigator.PerformLayout()
        CType(Me.TablocukDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents tarihvesaat_Label1 As Label
    Friend WithEvents Timer3 As Timer
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents TablocukBindingSource As BindingSource
    Friend WithEvents TablocukTableAdapter As DataSet1TableAdapters.tablocukTableAdapter
    Friend WithEvents TableAdapterManager As DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents TablocukBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents TablocukBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents TablocukDataGridView As DataGridView
    Friend WithEvents yeni_button As ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents SayiTextBox As TextBox
    Friend WithEvents DateDateTimePicker As DateTimePicker
    Friend WithEvents Timer4 As Timer
End Class
