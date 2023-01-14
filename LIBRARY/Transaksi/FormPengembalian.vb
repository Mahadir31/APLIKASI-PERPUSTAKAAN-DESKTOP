Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing

Public Class FormPengembalian
    Sub Tampil()
        LblKodeBuku.Text = ""
        JumlahPinjam.Text = ""
        LblNamaAnggota.Text = ""
        LblJudulBuku.Text = ""
        LblNoPinjam.Text = ""
        LblTglPinjam.Text = ""
        LblLamaPinjam.Text = ""
        LblDenda.Text = ""
        kodeanggota.Text = ""
        LblTelahPinjam.Text = ""
        LblTotalKembali.Text = ""
        BtnExit.Text = "EXIT"
    End Sub
    Sub TampilGrid1()
        dgpengembalian.Columns.Add("Kode", "KODE BUKU")
        dgpengembalian.Columns.Add("Nomor", "NO PINJAM")
        dgpengembalian.Columns.Add("Judul", "JUDUL BUKU")
        dgpengembalian.Columns.Add("Jumlah", "JUMLAH KEMBALI")
        dgpengembalian.Columns.Add("Tanggal", "TGL PINJAM")
        dgpengembalian.Columns.Add("Lama", "LAMA PINJAM")
        dgpengembalian.Columns.Add("Denda", "DENDA")
        dgpengembalian.RowTemplate.Height = 50
        dgpengembalian.Columns(2).Width = 175
        dgpengembalian.Columns(4).Width = 75
        dgpengembalian.Columns(6).Width = 75
    End Sub

    Sub NoOtomatis()
        Call OpenConn()
        Cmd = New MySqlCommand("select NoKembali from tblkembali order by NoKembali desc", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows = True Then
            LblNomorKembali.Text = "NK" + Format(Today, "yyMMdd") + "01"
        Else
            If Microsoft.VisualBasic.Mid(Rd.Item("NoKembali"), 3, 6) = Format(Today, "yyMMdd") Then
                LblNomorKembali.Text = "NK" + Format(Microsoft.VisualBasic.Right(Rd.Item("NoKembali"), 8) + 1, "00")
            Else
                LblNomorKembali.Text = "NK" + Format(Today, "yyMMdd") + "01"
            End If
        End If
    End Sub
    Sub Pinjaman()
        Call OpenConn()
        Da = New MySqlDataAdapter("select tblbuku.KodeBuku,JudulBuku,JumlahBuku,TglPinjam from tblanggota,tblpinjam,tblbuku,tbldetailpinjam where tblbuku.KodeBuku = tbldetailpinjam.KodeBuku And tblpinjam.NoPinjam = tbldetailpinjam.NoPinjam And tblanggota.KodeAnggota = tblpinjam.KodeAnggota And tblanggota.KodeAnggota = '" & kodeanggota.Text & "' AND tbldetailpinjam.JumlahBuku>0", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "Detail")
        dgKembali.RowTemplate.Height = 50
        dgKembali.DataSource = Ds.Tables("Detail")
        dgKembali.AllowUserToAddRows = False
        LblTotalKembali.Text = dgKembali.RowCount & String.Format(" Buku")
        dgKembali.Columns(0).Width = 110
        dgKembali.Columns(1).Width = 200
        dgKembali.Columns(2).Width = 80

        dgKembali.Columns(0).HeaderText = "KODE BUKU"
        dgKembali.Columns(1).HeaderText = "JUDUL BUKU"
        dgKembali.Columns(2).HeaderText = "JUMLAH"
        dgKembali.Columns(3).HeaderText = "TGL PINJAM"

    End Sub
    Sub CariData()
        Anggota.SelectKodeAnggota_From_tblanggota(kodeanggota.Text)
        If Rd.HasRows Then
            LblNamaAnggota.Text = Rd.Item("NamaAnggota")
            Peminjaman.SelectKodeAnggota_From_tblpinjam(kodeanggota.Text)
            If Rd.HasRows Then
                Peminjaman.SelectSUMTotalPinjam_From_tblpinjam(kodeanggota.Text)
                LblTelahPinjam.Text = Rd.Item(0)
                Call Pinjaman()
            End If
        End If
    End Sub
    Sub Hapus()
        LblKodeBuku.Text = ""
        LblJudulBuku.Text = ""
        LblNoPinjam.Text = ""
        LblTglPinjam.Text = ""
        LblLamaPinjam.Text = ""
        LblDenda.Text = ""
        JumlahPinjam.Text = ""
    End Sub
    Sub TotalDenda()
        Dim subtot As Integer = 0
        For I As Integer = 0 To dgpengembalian.Rows.Count - 1
            subtot += Val(dgpengembalian.Rows(I).Cells(6).Value)
            LblTotalDenda.Text = subtot
        Next
    End Sub
    Sub TotalKembali()
        Dim subtot As Integer = 0
        For I As Integer = 0 To dgpengembalian.Rows.Count - 1
            subtot += Val(dgpengembalian.Rows(I).Cells(3).Value)
            LblJumlahKembali.Text = subtot & String.Format(" Buku")
        Next
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
    Private Sub FormPengembalian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call MunculKodeAnggota()
        Call TampilGrid1()
        dgKembali.Columns.Clear()
        LblJumlahKembali.Text = ""
        LblTotalDenda.Text = ""
        txtBayar.Text = ""
        lblKembalian.Text = ""
        Call Tampil()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LblJam.Text = TimeOfDay
    End Sub

    Private Sub FormPengembalian_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Call NoOtomatis()
        kodeanggota.Focus()
        dgKembali.Columns.Clear()
        LblTglKembali.Text = Today
        LblPetugas.Text = FormMenuUtama.TSSnamapetugas.Text
    End Sub

    Private Sub Input_Click(sender As Object, e As EventArgs) Handles Input.Click
        BtnExit.Text = "&CANCEL"
        If kodeanggota.Text = "" Or LblKodeBuku.Text = "" Or JumlahPinjam.Text = "" Then
            MsgBox("Pastikan Buku Yang Mau di Kembalikan !", MsgBoxStyle.Exclamation, "WARNING !")
        Else
            dgpengembalian.Rows.Add(New String() {LblKodeBuku.Text, LblNoPinjam.Text, LblJudulBuku.Text, JumlahPinjam.Text, LblTglPinjam.Text, LblLamaPinjam.Text, LblDenda.Text})
            Call Hapus()
            Call TotalDenda()
            Call TotalKembali()
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If kodeanggota.Text = "" Or LblTotalDenda.Text = "" Or lblKembalian.Text = "" Then
            MsgBox("Transaksi Tidak Ada, Silahkan lakukan Transaksi Terlebih Dahulu !", MsgBoxStyle.Exclamation, "WARNING !")
        Else
            Call OpenConn()
            Dim pengembalian = New Pengembalian()
            pengembalian.NoKembali = LblNomorKembali.Text
            pengembalian.TglKembali = Format(Today, "yyyy-MM-dd")
            pengembalian.TotalKembali = LblJumlahKembali.Text
            pengembalian.Denda = LblTotalDenda.Text
            pengembalian.DiBayar = txtBayar.Text
            pengembalian.Kembali = lblKembalian.Text
            pengembalian.KodeAnggota = kodeanggota.Text
            pengembalian.NamaPetugas = FormMenuUtama.TSSnamapetugas.Text

            pengembalian.SaveDBKembali()

            For Baris As Integer = 0 To dgpengembalian.Rows.Count - 1

                Buku.SaveDetailKembali(LblNomorKembali.Text, dgpengembalian.Rows(Baris).Cells(0).Value, dgpengembalian.Rows(Baris).Cells(3).Value)

                Buku.SelectKodeBuku(dgpengembalian.Rows(Baris).Cells(0).Value)

                Buku.UpdateStokBuku_From_tblbuku(dgpengembalian.Rows(Baris).Cells(0).Value, Rd.Item("StokBuku") + dgpengembalian.Rows(Baris).Cells(3).Value)

                Buku.SelectJumlahBuku_From_DetailPinjam(dgpengembalian.Rows(Baris).Cells(0).Value, dgpengembalian.Rows(Baris).Cells(1).Value)

                If Rd.HasRows Then
                    Buku.UpdateDetailPinjam_Set_JumlahBuku(Rd.Item(0) - dgpengembalian.Rows(Baris).Cells(3).Value, dgpengembalian.Rows(Baris).Cells(0).Value, dgpengembalian.Rows(Baris).Cells(1).Value)

                End If
                Peminjaman.SelectTotalPinjam_From_tblpinjam(dgpengembalian.Rows(Baris).Cells(1).Value)

                If Rd.HasRows Then
                    Peminjaman.Updatetblpinjam_Set_TotalPinjam(Rd.Item(0) - dgpengembalian.Rows(Baris).Cells(3).Value, dgpengembalian.Rows(Baris).Cells(1).Value)

                End If
            Next
            Call NoOtomatis()
            dgKembali.Columns.Clear()
            dgpengembalian.Rows.Clear()
            LblTotalDenda.Text = ""
            txtBayar.Text = ""
            lblKembalian.Text = ""
            kodeanggota.Focus()
            MsgBox("Nama : " & LblNamaAnggota.Text & ", Dengan Kode : " & kodeanggota.Text & ", Berhasil Mengembalikan " & LblJumlahKembali.Text & " Buah Buku", MsgBoxStyle.Information, "Transaksi Telah Berhasil Disimpan")
            Call Tampil()
            LblJumlahKembali.Text = ""
        End If
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        If BtnExit.Text = "EXIT" Then
            Me.Close()
            MdiParent_Form.OpenVisibleTex()
            dgpengembalian.Columns.Clear()
        Else
            Call Tampil()
            dgKembali.Columns.Clear()
            dgpengembalian.Rows.Clear()
            LblJumlahKembali.Text = ""
            LblTotalDenda.Text = ""
            txtBayar.Text = ""
            lblKembalian.Text = ""
            kodeanggota.Focus()
        End If
    End Sub

    Private Sub txtBayar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBayar.KeyPress
        If e.KeyChar = Chr(13) Then
            If Val(txtBayar.Text) < Val(LblDenda.Text) Then
                MsgBox("Pembayaran Kurang")
                txtBayar.Focus()
            ElseIf Val(txtBayar.Text) = Val(LblDenda.Text) Then
                lblKembalian.Text = 0
                BtnSave.Focus()
            Else
                lblKembalian.Text = Val(txtBayar.Text) - Val(LblTotalDenda.Text)
                lblKembalian.Text = lblKembalian.Text
                BtnSave.Focus()
            End If
        End If
    End Sub

    Private Sub kodeanggota_SelectedIndexChanged(sender As Object, e As EventArgs) Handles kodeanggota.SelectedIndexChanged
        Dim hasil = Anggota.SelectKodeAnggota(kodeanggota.Text)
        If IsNothing(hasil) Then
            MsgBox("Data tidak ada")
        Else
            BtnExit.Text = "&CANCEL"
            dgKembali.Columns.Clear()
            Call CariData()
        End If
    End Sub

    Private Sub dgKembali_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgKembali.CellClick
        Call OpenConn()
        Dim i As Integer
        i = dgKembali.CurrentRow.Index
        Cmd = New MySqlCommand("select distinct tblbuku.KodeBuku,tbldetailpinjam.NoPinjam,JudulBuku,JumlahBuku,TglPinjam from tblanggota,tblpinjam,tblbuku,tbldetailpinjam where tblbuku.KodeBuku = tbldetailpinjam.KodeBuku And tblpinjam.NoPinjam = tbldetailpinjam.NoPinjam And tblanggota.KodeAnggota = tblpinjam.KodeAnggota And tblanggota.KodeAnggota = '" & kodeanggota.Text & "' AND tbldetailpinjam.KodeBuku = '" & dgKembali.Rows(i).Cells(0).Value & "' and tbldetailpinjam.JumlahBuku>0", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            MsgBox("Kode Buku Bukan Yang Di Pinjam !")
            Call Hapus()
            Call CariData()
        Else
            LblKodeBuku.Text = Rd.Item(0)
            LblNoPinjam.Text = Rd.Item(1)
            LblJudulBuku.Text = Rd.Item(2)
            JumlahPinjam.Text = Rd.Item(3)
            LblTglPinjam.Text = Rd.Item(4)
            LblLamaPinjam.Text = DateDiff(DateInterval.Day, Rd.Item(4), Today())
            If LblLamaPinjam.Text > 5 Then
                LblDenda.Text = Val((LblLamaPinjam.Text) - 5) * 1000
            Else
                LblDenda.Text = 0
            End If
            Input.Focus()
        End If
    End Sub
End Class