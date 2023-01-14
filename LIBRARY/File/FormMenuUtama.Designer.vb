<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMenuUtama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblTanggal = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TxtJudul = New System.Windows.Forms.Label()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TRASAKSIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LOGIN = New System.Windows.Forms.ToolStripMenuItem()
        Me.EXITT = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.LOGOUT = New System.Windows.Forms.ToolStripMenuItem()
        Me.MASTER = New System.Windows.Forms.ToolStripMenuItem()
        Me.PETUGAS = New System.Windows.Forms.ToolStripMenuItem()
        Me.ANGGOTA = New System.Windows.Forms.ToolStripMenuItem()
        Me.BUKU = New System.Windows.Forms.ToolStripMenuItem()
        Me.TRANSAKSI = New System.Windows.Forms.ToolStripMenuItem()
        Me.PEMINJAMANBUKU = New System.Windows.Forms.ToolStripMenuItem()
        Me.PENGEMBALIANBUKU = New System.Windows.Forms.ToolStripMenuItem()
        Me.LAPORAN = New System.Windows.Forms.ToolStripMenuItem()
        Me.LPPEMINJAMAN = New System.Windows.Forms.ToolStripMenuItem()
        Me.LPPENGEMBALIAN = New System.Windows.Forms.ToolStripMenuItem()
        Me.DAFTARBUKU = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSSkodepetugas = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSSnamapetugas = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSSstatuspetugas = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.FILEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LblJam = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTanggal
        '
        Me.lblTanggal.AutoSize = True
        Me.lblTanggal.BackColor = System.Drawing.Color.Transparent
        Me.lblTanggal.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTanggal.Location = New System.Drawing.Point(51, 16)
        Me.lblTanggal.Name = "lblTanggal"
        Me.lblTanggal.Size = New System.Drawing.Size(158, 31)
        Me.lblTanggal.TabIndex = 8
        Me.lblTanggal.Text = "29-Oct-2022"
        Me.lblTanggal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblTanggal)
        Me.GroupBox4.Location = New System.Drawing.Point(560, 612)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(260, 58)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        '
        'TxtJudul
        '
        Me.TxtJudul.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtJudul.AutoSize = True
        Me.TxtJudul.Font = New System.Drawing.Font("Times New Roman", 50.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtJudul.Location = New System.Drawing.Point(155, 65)
        Me.TxtJudul.Name = "TxtJudul"
        Me.TxtJudul.Size = New System.Drawing.Size(1057, 76)
        Me.TxtJudul.TabIndex = 5
        Me.TxtJudul.Text = "MENU UTAMA PERPUSTAKAAN"
        Me.TxtJudul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer
        '
        Me.Timer.Enabled = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.DarkOrange
        Me.MenuStrip1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.TRASAKSIToolStripMenuItem, Me.MASTER, Me.TRANSAKSI, Me.LAPORAN, Me.DAFTARBUKU})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1276, 39)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.BackgroundImage = Global.LIBRARY.My.Resources.Resources.book_5003
        Me.ToolStripMenuItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(34, 35)
        Me.ToolStripMenuItem1.Text = "     "
        '
        'TRASAKSIToolStripMenuItem
        '
        Me.TRASAKSIToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LOGIN, Me.EXITT, Me.ToolStripMenuItem2, Me.LOGOUT})
        Me.TRASAKSIToolStripMenuItem.Image = Global.LIBRARY.My.Resources.Resources.list_6220__3_
        Me.TRASAKSIToolStripMenuItem.Name = "TRASAKSIToolStripMenuItem"
        Me.TRASAKSIToolStripMenuItem.Size = New System.Drawing.Size(45, 35)
        Me.TRASAKSIToolStripMenuItem.Text = "FILE"
        Me.TRASAKSIToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'LOGIN
        '
        Me.LOGIN.Name = "LOGIN"
        Me.LOGIN.Size = New System.Drawing.Size(127, 22)
        Me.LOGIN.Text = "LOGIN"
        '
        'EXITT
        '
        Me.EXITT.Name = "EXITT"
        Me.EXITT.Size = New System.Drawing.Size(127, 22)
        Me.EXITT.Text = "EXIT"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(124, 6)
        '
        'LOGOUT
        '
        Me.LOGOUT.Name = "LOGOUT"
        Me.LOGOUT.Size = New System.Drawing.Size(127, 22)
        Me.LOGOUT.Text = "LOGOUT"
        '
        'MASTER
        '
        Me.MASTER.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PETUGAS, Me.ANGGOTA, Me.BUKU})
        Me.MASTER.Image = Global.LIBRARY.My.Resources.Resources.black_mac_folder_13646
        Me.MASTER.Name = "MASTER"
        Me.MASTER.Size = New System.Drawing.Size(71, 35)
        Me.MASTER.Text = "MASTER"
        Me.MASTER.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'PETUGAS
        '
        Me.PETUGAS.Name = "PETUGAS"
        Me.PETUGAS.Size = New System.Drawing.Size(136, 22)
        Me.PETUGAS.Text = "PETUGAS"
        '
        'ANGGOTA
        '
        Me.ANGGOTA.Name = "ANGGOTA"
        Me.ANGGOTA.Size = New System.Drawing.Size(136, 22)
        Me.ANGGOTA.Text = "ANGGOTA"
        '
        'BUKU
        '
        Me.BUKU.Name = "BUKU"
        Me.BUKU.Size = New System.Drawing.Size(136, 22)
        Me.BUKU.Text = "BUKU"
        '
        'TRANSAKSI
        '
        Me.TRANSAKSI.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PEMINJAMANBUKU, Me.PENGEMBALIANBUKU})
        Me.TRANSAKSI.Image = Global.LIBRARY.My.Resources.Resources.wallet_and_coin_8722
        Me.TRANSAKSI.Name = "TRANSAKSI"
        Me.TRANSAKSI.Size = New System.Drawing.Size(92, 35)
        Me.TRANSAKSI.Text = "TRANSAKSI"
        Me.TRANSAKSI.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'PEMINJAMANBUKU
        '
        Me.PEMINJAMANBUKU.Name = "PEMINJAMANBUKU"
        Me.PEMINJAMANBUKU.Size = New System.Drawing.Size(210, 22)
        Me.PEMINJAMANBUKU.Text = "PEMINJAMAN BUKU"
        '
        'PENGEMBALIANBUKU
        '
        Me.PENGEMBALIANBUKU.Name = "PENGEMBALIANBUKU"
        Me.PENGEMBALIANBUKU.Size = New System.Drawing.Size(210, 22)
        Me.PENGEMBALIANBUKU.Text = "PENGEMBALIAN BUKU"
        '
        'LAPORAN
        '
        Me.LAPORAN.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LPPEMINJAMAN, Me.LPPENGEMBALIAN})
        Me.LAPORAN.Image = Global.LIBRARY.My.Resources.Resources.pdf_download_2620
        Me.LAPORAN.Name = "LAPORAN"
        Me.LAPORAN.Size = New System.Drawing.Size(81, 35)
        Me.LAPORAN.Text = "LAPORAN"
        Me.LAPORAN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'LPPEMINJAMAN
        '
        Me.LPPEMINJAMAN.Name = "LPPEMINJAMAN"
        Me.LPPEMINJAMAN.Size = New System.Drawing.Size(191, 22)
        Me.LPPEMINJAMAN.Text = "LP PEMINJAMAN"
        '
        'LPPENGEMBALIAN
        '
        Me.LPPENGEMBALIAN.Name = "LPPENGEMBALIAN"
        Me.LPPENGEMBALIAN.Size = New System.Drawing.Size(191, 22)
        Me.LPPENGEMBALIAN.Text = "LP PENGEMBALIAN"
        '
        'DAFTARBUKU
        '
        Me.DAFTARBUKU.Image = Global.LIBRARY.My.Resources.Resources.opened_book_3160
        Me.DAFTARBUKU.Name = "DAFTARBUKU"
        Me.DAFTARBUKU.Size = New System.Drawing.Size(106, 35)
        Me.DAFTARBUKU.Text = "DAFTAR BUKU"
        Me.DAFTARBUKU.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(293, 277)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(273, 23)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "PERPUSTAKAAN BAROKAH"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(291, 300)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(481, 31)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "UNIVERSITAS NAHDLATUL ULAMA"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(165, 353)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(634, 45)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "KAMPUS PERADABAN BANGSA"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(435, 420)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(476, 17)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Alamat : Jalan Pendidikan No 06 Mataram - 83125, Telp.(0370)6170869"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(489, 443)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(388, 17)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Website : www.unu.ntb.ac.id  |  Email : unu.ntb@gmail.com"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.DodgerBlue
        Me.StatusStrip1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel4, Me.TSSkodepetugas, Me.ToolStripStatusLabel5, Me.TSSnamapetugas, Me.ToolStripStatusLabel6, Me.TSSstatuspetugas})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 702)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1276, 22)
        Me.StatusStrip1.TabIndex = 19
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(101, 17)
        Me.ToolStripStatusLabel1.Text = "KELOMPOK III /"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(199, 17)
        Me.ToolStripStatusLabel2.Text = "MICROSOFT VISUAL STUDIO II /"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(28, 17)
        Me.ToolStripStatusLabel3.Text = "___"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(49, 17)
        Me.ToolStripStatusLabel4.Text = "KODE :"
        '
        'TSSkodepetugas
        '
        Me.TSSkodepetugas.ForeColor = System.Drawing.Color.White
        Me.TSSkodepetugas.Name = "TSSkodepetugas"
        Me.TSSkodepetugas.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(65, 17)
        Me.ToolStripStatusLabel5.Text = "__NAMA :"
        '
        'TSSnamapetugas
        '
        Me.TSSnamapetugas.ForeColor = System.Drawing.Color.White
        Me.TSSnamapetugas.Name = "TSSnamapetugas"
        Me.TSSnamapetugas.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripStatusLabel6
        '
        Me.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
        Me.ToolStripStatusLabel6.Size = New System.Drawing.Size(75, 17)
        Me.ToolStripStatusLabel6.Text = "__STATUS :"
        '
        'TSSstatuspetugas
        '
        Me.TSSstatuspetugas.ForeColor = System.Drawing.Color.White
        Me.TSSstatuspetugas.Name = "TSSstatuspetugas"
        Me.TSSstatuspetugas.Size = New System.Drawing.Size(0, 17)
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = Global.LIBRARY.My.Resources.Resources.output_onlinepngtools__1_
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(996, 200)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(226, 233)
        Me.PictureBox3.TabIndex = 21
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.LIBRARY.My.Resources.Resources.LOGO_UNU_NTB
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(792, 211)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(200, 200)
        Me.PictureBox2.TabIndex = 20
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.LIBRARY.My.Resources.Resources.book_and_studen_logo_free_vector_removebg_preview
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(156, 213)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 140)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'FILEToolStripMenuItem
        '
        Me.FILEToolStripMenuItem.Image = Global.LIBRARY.My.Resources.Resources.list_6220__3_
        Me.FILEToolStripMenuItem.Name = "FILEToolStripMenuItem"
        Me.FILEToolStripMenuItem.Size = New System.Drawing.Size(45, 35)
        Me.FILEToolStripMenuItem.Text = "FILE"
        Me.FILEToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'LToolStripMenuItem
        '
        Me.LToolStripMenuItem.BackgroundImage = Global.LIBRARY.My.Resources.Resources.opened_book_3160
        Me.LToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LToolStripMenuItem.Enabled = False
        Me.LToolStripMenuItem.Name = "LToolStripMenuItem"
        Me.LToolStripMenuItem.ShowShortcutKeys = False
        Me.LToolStripMenuItem.Size = New System.Drawing.Size(34, 35)
        Me.LToolStripMenuItem.Text = "     "
        '
        'LblJam
        '
        Me.LblJam.AutoSize = True
        Me.LblJam.BackColor = System.Drawing.Color.Transparent
        Me.LblJam.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblJam.Location = New System.Drawing.Point(72, 16)
        Me.LblJam.Name = "LblJam"
        Me.LblJam.Size = New System.Drawing.Size(116, 31)
        Me.LblJam.TabIndex = 9
        Me.LblJam.Text = "00:00:00"
        Me.LblJam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LblJam)
        Me.GroupBox3.Location = New System.Drawing.Point(560, 548)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(260, 58)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        '
        'FormMenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1276, 724)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtJudul)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormMenuUtama"
        Me.Text = "FormMenuUtama"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTanggal As Label
    Friend WithEvents Timer As Timer
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TxtJudul As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TRASAKSIToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MASTER As ToolStripMenuItem
    Friend WithEvents FILEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LOGIN As ToolStripMenuItem
    Friend WithEvents EXITT As ToolStripMenuItem
    Friend WithEvents PETUGAS As ToolStripMenuItem
    Friend WithEvents ANGGOTA As ToolStripMenuItem
    Friend WithEvents BUKU As ToolStripMenuItem
    Friend WithEvents TRANSAKSI As ToolStripMenuItem
    Friend WithEvents PEMINJAMANBUKU As ToolStripMenuItem
    Friend WithEvents PENGEMBALIANBUKU As ToolStripMenuItem
    Friend WithEvents LAPORAN As ToolStripMenuItem
    Friend WithEvents LPPEMINJAMAN As ToolStripMenuItem
    Friend WithEvents LPPENGEMBALIAN As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents TSSkodepetugas As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As ToolStripStatusLabel
    Friend WithEvents TSSnamapetugas As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel6 As ToolStripStatusLabel
    Friend WithEvents TSSstatuspetugas As ToolStripStatusLabel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DAFTARBUKU As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents LOGOUT As ToolStripMenuItem
    Friend WithEvents LblJam As Label
    Friend WithEvents GroupBox3 As GroupBox
End Class
