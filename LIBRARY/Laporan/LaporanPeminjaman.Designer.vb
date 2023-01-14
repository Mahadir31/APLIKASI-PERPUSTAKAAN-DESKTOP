<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LaporanPeminjaman
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbPerBulan = New System.Windows.Forms.ComboBox()
        Me.dtTahun = New System.Windows.Forms.DateTimePicker()
        Me.dtPerTahun = New System.Windows.Forms.DateTimePicker()
        Me.dtPerMinggu2 = New System.Windows.Forms.DateTimePicker()
        Me.dtPerMinggu1 = New System.Windows.Forms.DateTimePicker()
        Me.BtnKeluar = New System.Windows.Forms.Button()
        Me.dtPerTanggal = New System.Windows.Forms.DateTimePicker()
        Me.RbTanggal = New System.Windows.Forms.RadioButton()
        Me.RbMinggu = New System.Windows.Forms.RadioButton()
        Me.RbBulan = New System.Windows.Forms.RadioButton()
        Me.RbTahun = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RbAnggota = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CbKodeAnggota = New System.Windows.Forms.ComboBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("News706 BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(277, 277)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 51)
        Me.Button2.TabIndex = 133
        Me.Button2.Text = "&PRINT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.BackColor = System.Drawing.Color.Transparent
        Me.Label37.Font = New System.Drawing.Font("Stencil", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.Black
        Me.Label37.Location = New System.Drawing.Point(43, 9)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(288, 64)
        Me.Label37.TabIndex = 129
        Me.Label37.Text = "LAPORAN TRANSAKSI" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PEMINJAMAN BUKU"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(216, 191)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 15)
        Me.Label2.TabIndex = 127
        Me.Label2.Text = "Tahun"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(221, 162)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 15)
        Me.Label1.TabIndex = 126
        Me.Label1.Text = "s/d"
        '
        'cbPerBulan
        '
        Me.cbPerBulan.BackColor = System.Drawing.Color.DarkGray
        Me.cbPerBulan.FormattingEnabled = True
        Me.cbPerBulan.Items.AddRange(New Object() {"--Pilih Bulan--", "Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember"})
        Me.cbPerBulan.Location = New System.Drawing.Point(108, 186)
        Me.cbPerBulan.Name = "cbPerBulan"
        Me.cbPerBulan.Size = New System.Drawing.Size(97, 21)
        Me.cbPerBulan.TabIndex = 121
        '
        'dtTahun
        '
        Me.dtTahun.CalendarMonthBackground = System.Drawing.Color.SlateGray
        Me.dtTahun.CustomFormat = "yyyy"
        Me.dtTahun.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtTahun.Location = New System.Drawing.Point(266, 187)
        Me.dtTahun.Name = "dtTahun"
        Me.dtTahun.ShowUpDown = True
        Me.dtTahun.Size = New System.Drawing.Size(97, 20)
        Me.dtTahun.TabIndex = 120
        '
        'dtPerTahun
        '
        Me.dtPerTahun.CalendarMonthBackground = System.Drawing.Color.SlateGray
        Me.dtPerTahun.CustomFormat = "yyyy"
        Me.dtPerTahun.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtPerTahun.Location = New System.Drawing.Point(108, 213)
        Me.dtPerTahun.Name = "dtPerTahun"
        Me.dtPerTahun.ShowUpDown = True
        Me.dtPerTahun.Size = New System.Drawing.Size(97, 20)
        Me.dtPerTahun.TabIndex = 119
        '
        'dtPerMinggu2
        '
        Me.dtPerMinggu2.CalendarMonthBackground = System.Drawing.Color.SlateGray
        Me.dtPerMinggu2.CustomFormat = "dd/MM/yyyy"
        Me.dtPerMinggu2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtPerMinggu2.Location = New System.Drawing.Point(266, 161)
        Me.dtPerMinggu2.Name = "dtPerMinggu2"
        Me.dtPerMinggu2.Size = New System.Drawing.Size(97, 20)
        Me.dtPerMinggu2.TabIndex = 118
        '
        'dtPerMinggu1
        '
        Me.dtPerMinggu1.CalendarMonthBackground = System.Drawing.Color.SlateGray
        Me.dtPerMinggu1.CustomFormat = "dd/MM/yyyy"
        Me.dtPerMinggu1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtPerMinggu1.Location = New System.Drawing.Point(108, 160)
        Me.dtPerMinggu1.Name = "dtPerMinggu1"
        Me.dtPerMinggu1.Size = New System.Drawing.Size(97, 20)
        Me.dtPerMinggu1.TabIndex = 117
        '
        'BtnKeluar
        '
        Me.BtnKeluar.Font = New System.Drawing.Font("News706 BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKeluar.Location = New System.Drawing.Point(12, 277)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(86, 51)
        Me.BtnKeluar.TabIndex = 116
        Me.BtnKeluar.Text = "&EXIT"
        Me.BtnKeluar.UseVisualStyleBackColor = True
        '
        'dtPerTanggal
        '
        Me.dtPerTanggal.CalendarMonthBackground = System.Drawing.Color.SlateGray
        Me.dtPerTanggal.CustomFormat = "dd/MM/yyyy"
        Me.dtPerTanggal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtPerTanggal.Location = New System.Drawing.Point(266, 111)
        Me.dtPerTanggal.Name = "dtPerTanggal"
        Me.dtPerTanggal.Size = New System.Drawing.Size(97, 20)
        Me.dtPerTanggal.TabIndex = 115
        '
        'RbTanggal
        '
        Me.RbTanggal.AutoSize = True
        Me.RbTanggal.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbTanggal.ForeColor = System.Drawing.Color.Black
        Me.RbTanggal.Location = New System.Drawing.Point(266, 88)
        Me.RbTanggal.Name = "RbTanggal"
        Me.RbTanggal.Size = New System.Drawing.Size(71, 19)
        Me.RbTanggal.TabIndex = 122
        Me.RbTanggal.TabStop = True
        Me.RbTanggal.Text = "Per &Tanggal"
        Me.RbTanggal.UseVisualStyleBackColor = True
        '
        'RbMinggu
        '
        Me.RbMinggu.AutoSize = True
        Me.RbMinggu.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbMinggu.ForeColor = System.Drawing.Color.Black
        Me.RbMinggu.Location = New System.Drawing.Point(12, 160)
        Me.RbMinggu.Name = "RbMinggu"
        Me.RbMinggu.Size = New System.Drawing.Size(70, 19)
        Me.RbMinggu.TabIndex = 123
        Me.RbMinggu.TabStop = True
        Me.RbMinggu.Text = "Per &Minggu"
        Me.RbMinggu.UseVisualStyleBackColor = True
        '
        'RbBulan
        '
        Me.RbBulan.AutoSize = True
        Me.RbBulan.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbBulan.ForeColor = System.Drawing.Color.Black
        Me.RbBulan.Location = New System.Drawing.Point(12, 186)
        Me.RbBulan.Name = "RbBulan"
        Me.RbBulan.Size = New System.Drawing.Size(63, 19)
        Me.RbBulan.TabIndex = 124
        Me.RbBulan.TabStop = True
        Me.RbBulan.Text = "Per &Bulan"
        Me.RbBulan.UseVisualStyleBackColor = True
        '
        'RbTahun
        '
        Me.RbTahun.AutoSize = True
        Me.RbTahun.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbTahun.ForeColor = System.Drawing.Color.Black
        Me.RbTahun.Location = New System.Drawing.Point(12, 213)
        Me.RbTahun.Name = "RbTahun"
        Me.RbTahun.Size = New System.Drawing.Size(64, 19)
        Me.RbTahun.TabIndex = 125
        Me.RbTahun.TabStop = True
        Me.RbTahun.Text = "Per &Tahun"
        Me.RbTahun.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.RbAnggota)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.CbKodeAnggota)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 86)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(239, 60)
        Me.GroupBox1.TabIndex = 134
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cetak Berdasarkan Kode Anggota"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(114, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(11, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = ":"
        '
        'RbAnggota
        '
        Me.RbAnggota.AutoSize = True
        Me.RbAnggota.Location = New System.Drawing.Point(6, 22)
        Me.RbAnggota.Name = "RbAnggota"
        Me.RbAnggota.Size = New System.Drawing.Size(100, 19)
        Me.RbAnggota.TabIndex = 3
        Me.RbAnggota.TabStop = True
        Me.RbAnggota.Text = "Kode Anggota"
        Me.RbAnggota.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(112, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(11, 15)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = ":"
        '
        'CbKodeAnggota
        '
        Me.CbKodeAnggota.FormattingEnabled = True
        Me.CbKodeAnggota.Location = New System.Drawing.Point(129, 21)
        Me.CbKodeAnggota.Name = "CbKodeAnggota"
        Me.CbKodeAnggota.Size = New System.Drawing.Size(94, 23)
        Me.CbKodeAnggota.TabIndex = 0
        '
        'ListView1
        '
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(12, 70)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(351, 5)
        Me.ListView1.TabIndex = 135
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'LaporanPeminjaman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(375, 340)
        Me.ControlBox = False
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RbTahun)
        Me.Controls.Add(Me.RbBulan)
        Me.Controls.Add(Me.RbMinggu)
        Me.Controls.Add(Me.RbTanggal)
        Me.Controls.Add(Me.cbPerBulan)
        Me.Controls.Add(Me.dtTahun)
        Me.Controls.Add(Me.dtPerTahun)
        Me.Controls.Add(Me.dtPerMinggu2)
        Me.Controls.Add(Me.dtPerMinggu1)
        Me.Controls.Add(Me.BtnKeluar)
        Me.Controls.Add(Me.dtPerTanggal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LaporanPeminjaman"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LaporanPeminjaman"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Label37 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbPerBulan As ComboBox
    Friend WithEvents dtTahun As DateTimePicker
    Friend WithEvents dtPerTahun As DateTimePicker
    Friend WithEvents dtPerMinggu2 As DateTimePicker
    Friend WithEvents dtPerMinggu1 As DateTimePicker
    Friend WithEvents BtnKeluar As Button
    Friend WithEvents dtPerTanggal As DateTimePicker
    Friend WithEvents RbTanggal As RadioButton
    Friend WithEvents RbMinggu As RadioButton
    Friend WithEvents RbBulan As RadioButton
    Friend WithEvents RbTahun As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents RbAnggota As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents CbKodeAnggota As ComboBox
    Friend WithEvents ListView1 As ListView
End Class
