Imports MySql.Data.MySqlClient
Public Class FormPeminjaman
    Sub Tampilkan()
        Call MunculKodeAnggota()
        Call NamaBuku()
        LblNama.Text = ""
        LblKelamin.Text = ""
        LblAlamat.Text = ""
        LblTelpon.Text = ""
        LblBuku.Text = ""
        kodeanggota.Text = ""
        LblPengarang.Text = ""
        LblTotalBuku.Text = "0"
        LblKodeBuku.Text = ""
        txtJumlah.Text = ""
        LblPenerbit.Text = ""
        TxtCari.Text = ""
        Lbltelahpinjam.Text = "0"
        kodeanggota.Enabled = True
        Input.Enabled = True
        txtJumlah.Enabled = True
        TxtCari.Enabled = True
    End Sub
    Sub Mati()
        Call BuatKolom()
        LblNama.Enabled = False
        LblKelamin.Enabled = False
        LblAlamat.Enabled = False
        LblTelpon.Enabled = False
        LblBuku.Enabled = False
        kodeanggota.Enabled = False
        LblPengarang.Enabled = False
        LblTotalBuku.Enabled = False
        LblKodeBuku.Enabled = False
        txtJumlah.Enabled = False
        LblPenerbit.Enabled = False
        Input.Enabled = False
        TxtCari.Enabled = False

        LblNamaPetugas.Text = FormMenuUtama.TSSnamapetugas.Text

        BtnInput.Text = "INPUT"
        BtnExit.Text = "EXIT"

        kodeanggota.Text = ""
        LblNama.Text = ""
        LblKelamin.Text = ""
        LblAlamat.Text = ""
        LblTelpon.Text = ""
        LblBuku.Text = ""
        kodeanggota.Text = ""
        LblPengarang.Text = ""
        LblTotalBuku.Text = ""
        LblKodeBuku.Text = ""
        txtJumlah.Text = ""
        LblPenerbit.Text = ""
        Lbltelahpinjam.Text = ""
        TxtCari.Text = ""
        dgtelahpinjam.Columns.Clear()
        DgNamaBuku.Columns.Clear()
    End Sub
    Sub NoOtomatis()
        Call OpenConn()
        Cmd = New MySqlCommand("select NoPinjam from tblpinjam order by NoPinjam desc", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows = True Then
            LblNoPinjam.Text = "PJ" + Format(Today, "yyMMdd") + "01"
        Else
            If Microsoft.VisualBasic.Mid(Rd.Item("NoPinjam"), 3, 6) = Format(Today, "yyMMdd") Then
                LblNoPinjam.Text = "PJ" + Format(Microsoft.VisualBasic.Right(Rd.Item("NoPinjam"), 8) + 1, "00")
            Else
                LblNoPinjam.Text = "PJ" + Format(Today, "yyMMdd") + "01"
            End If
        End If
    End Sub
    Sub MunculKodeAnggota()
        Call OpenConn()
        kodeanggota.Items.Clear()
        Cmd = New MySqlCommand("select * from tblanggota", Conn)
        Rd = Cmd.ExecuteReader
        Do While Rd.Read
            kodeanggota.Items.Add(Rd.Item(0))
        Loop
    End Sub

    Sub CekPinjaman()
        Call OpenConn()
        Da = New MySqlDataAdapter("select tblbuku.KodeBuku,JudulBuku,JumlahBuku,TglPinjam from tblanggota,tblpinjam,tblbuku,tbldetailpinjam where tblbuku.KodeBuku = tbldetailpinjam.KodeBuku And tblpinjam.NoPinjam = 
                                   tbldetailpinjam.NoPinjam And tblanggota.KodeAnggota = tblpinjam.KodeAnggota And tblanggota.KodeAnggota = '" & kodeanggota.Text & "' AND tbldetailpinjam.JumlahBuku>0", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "Pinjam")
        dgtelahpinjam.RowTemplate.Height = 30
        dgtelahpinjam.DataSource = Ds.Tables("Pinjam")
        Lbltelahpinjam.Text = dgtelahpinjam.RowCount
        dgtelahpinjam.Columns(0).HeaderText = "KODE BUKU"
        dgtelahpinjam.Columns(1).HeaderText = "JUDUL BUKU"
        dgtelahpinjam.Columns(2).HeaderText = "JUMLAH BUKU"
        dgtelahpinjam.Columns(3).HeaderText = "TGL PINJAM"
    End Sub
    Sub BuatKolom()
        dgPinjam.Columns.Clear()
        dgPinjam.Columns.Add("Kode", "KODE BUKU")
        dgPinjam.Columns.Add("Judul", "JUDUL")
        dgPinjam.Columns.Add("Pengarang", "PENGARANG")
        dgPinjam.Columns.Add("Penerbit", "PENERBIT")
        dgPinjam.Columns.Add("Jumlah", "JUMLAH")
        dgPinjam.RowTemplate.Height = 40
    End Sub
    Private Sub FormPeminjaman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbltanggal.Text = Today
    End Sub
    Private Sub kodeanggota_SelectedIndexChanged(sender As Object, e As EventArgs) Handles kodeanggota.SelectedIndexChanged
        Dim hasil = Anggota.SelectKodeAnggota(kodeanggota.Text)
        If IsNothing(hasil) Then
            MsgBox("Data tidak ada")
        Else
            LblNama.Text = hasil.NamaAnggota
            LblKelamin.Text = hasil.JenisKelamin
            LblAlamat.Text = hasil.AlamatAnggota
            LblTelpon.Text = hasil.TelponAnggota
            Call CekPinjaman()
        End If
    End Sub
    Private Sub Input_Click(sender As Object, e As EventArgs) Handles Input.Click
        If txtJumlah.Text = "" Then
            MsgBox("BUku YAng Di Pinja Tidak Ada !", MsgBoxStyle.Exclamation, "WARNING !")
        Else
            If Val(Lbltelahpinjam.Text) + (LblTotalBuku.Text) >= 5 Or Val(LblTotalBuku.Text) + Val(txtJumlah.Text) > 5 Then
                MsgBox("Buku Yang Dipinjam Melebihi Maksimal !", MsgBoxStyle.Critical, "WARNING !")
                Call Tampilkan()
                BtnExit.Text = "&CANCEL"
            Else
                dgPinjam.Rows.Add(New String() {LblKodeBuku.Text, LblBuku.Text, LblPengarang.Text, LblPenerbit.Text, txtJumlah.Text})
                LblKodeBuku.Text = ""
                LblBuku.Text = ""
                LblPengarang.Text = ""
                LblPenerbit.Text = ""
                txtJumlah.Text = ""
                Dim sum As Decimal = 0
                For i = 0 To dgPinjam.Rows.Count - 1
                    sum += dgPinjam.Rows(i).Cells(4).Value
                Next
                LblTotalBuku.Text = sum
            End If
        End If
    End Sub
    Private Sub Tambah_Click(sender As Object, e As EventArgs) Handles BtnInput.Click
        If BtnInput.Text = "INPUT" Then
            BtnInput.Text = "SAVE"
            BtnExit.Text = "&CANCEL"
            Call Tampilkan()
        Else
            If kodeanggota.Text = "" Or LblTotalBuku.Text = "0" Then
                MsgBox("Transaksi Tidak Ada, silahkan lakukan transaksi terlebih dhulu !", MsgBoxStyle.Exclamation, "WARNING !")
            Else
                Call OpenConn()
                Dim peminjaman = New Peminjaman()
                peminjaman.NoPinjam = LblNoPinjam.Text
                peminjaman.TglPinjam = Format(Today, "yyyy-MM-dd")
                peminjaman.JamPinjam = lbljam.Text
                peminjaman.KodeAnggota = kodeanggota.Text
                peminjaman.ItemPinjam = LblTotalBuku.Text
                peminjaman.TotalPinjam = LblTotalBuku.Text
                peminjaman.NamaPetugas = FormMenuUtama.TSSnamapetugas.Text

                peminjaman.SaveDBPinjam()

                For Baris As Integer = 0 To dgPinjam.Rows.Count - 1
                    Buku.SaveDetailPinjam(LblNoPinjam.Text, dgPinjam.Rows(Baris).Cells(0).Value, dgPinjam.Rows(Baris).Cells(4).Value)

                    Buku.SelectKodeBuku(dgPinjam.Rows(Baris).Cells(0).Value)

                    Buku.UpdateStokBuku_From_tblbuku(dgPinjam.Rows(Baris).Cells(0).Value, Rd.Item("StokBuku") - dgPinjam.Rows(Baris).Cells(4).Value)
                Next
                MsgBox("Nama : " & LblNama.Text & ", Dengan Kode : " & kodeanggota.Text & ", Berhasil Meminjam " & LblTotalBuku.Text & " Buah Buku", MsgBoxStyle.Information, "Transaksi Telah Berhasil Disimpan")
                Call Mati()
            End If
        End If
    End Sub
    Private Sub Keluar_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        If BtnExit.Text = "EXIT" Then
            MdiParent_Form.OpenVisibleTex()
            Me.Close()
        Else
            Call Mati()
            BtnInput.Enabled = True
        End If
    End Sub
    Private Sub FormPeminjaman_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Call Mati()
        Call NoOtomatis()
        kodeanggota.Text = ""
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbljam.Text = TimeOfDay
    End Sub
    Sub NamaBuku()
        Call OpenConn()
        Da = New MySqlDataAdapter("Select KodeBuku, JudulBuku, PengarangBuku, Penerbit, TahunBuku from tblbuku", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tblbuku")
        DgNamaBuku.RowTemplate.Height = 40
        DgNamaBuku.DataSource = Ds.Tables("tblbuku")

        DgNamaBuku.Columns(0).HeaderText = "KODE BUKU"
        DgNamaBuku.Columns(1).HeaderText = "JUDUL"
        DgNamaBuku.Columns(2).HeaderText = "PENGARANG"
        DgNamaBuku.Columns(3).HeaderText = "PENERBIT"
        DgNamaBuku.Columns(4).HeaderText = "TERBIT"
    End Sub

    Private Sub DgNamaBuku_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgNamaBuku.CellClick
        Dim i As Integer
        i = DgNamaBuku.CurrentRow.Index
        Call OpenConn()
        Cmd = New MySqlCommand("Select * From tblbuku Where KodeBuku = '" & DgNamaBuku.Item(0, i).Value & "'", Conn)
                Rd = Cmd.ExecuteReader
        Rd.Read()

        On Error Resume Next
        LblKodeBuku.Text = Rd.Item(0)
        LblBuku.Text = Rd.Item(1)
        LblPengarang.Text = Rd.Item(2)
        LblPenerbit.Text = Rd.Item(3)
        txtJumlah.Text = True
        txtJumlah.Text = "1"

    End Sub

    Private Sub TxtCari_TextChanged(sender As Object, e As EventArgs) Handles TxtCari.TextChanged
        Call OpenConn()
        Da = New MySqlDataAdapter("select * from tblbuku where JudulBuku  like '%" & TxtCari.Text & "%' or PengarangBuku  like '%" & TxtCari.Text & "%'", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "tblbuku")
        DgNamaBuku.DataSource = Ds.Tables("tblbuku")
        DgNamaBuku.RowTemplate.Height = 40
    End Sub

    Private Sub DgNamaBuku_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgNamaBuku.CellContentClick

    End Sub
End Class