Public Class FormMenuUtama
    Sub Kunci()
        LOGIN.Enabled = True
        EXITT.Enabled = False
        MASTER.Visible = False
        TRANSAKSI.Visible = False
        LAPORAN.Visible = False
        DAFTARBUKU.Visible = False
    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub FormMenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Kunci()
        lblTanggal.Text = Format(Today, "dd-MMM-yyyy")
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        LblJam.Text = TimeOfDay
    End Sub

    Private Sub EXITT_Click(sender As Object, e As EventArgs) Handles EXITT.Click
        Call Kunci()
        MdiParent_Form.Close_Form()
        TSSkodepetugas.Text = ""
        TSSnamapetugas.Text = ""
        TSSstatuspetugas.Text = ""
    End Sub

    Private Sub LPPEMINJAMAN_Click(sender As Object, e As EventArgs) Handles LPPEMINJAMAN.Click
        LaporanPeminjaman.MdiParent = Me
        LaporanPeminjaman.Show()
        MdiParent_Form.VisibleTex()
    End Sub

    Private Sub LPPENGEMBALIAN_Click(sender As Object, e As EventArgs) Handles LPPENGEMBALIAN.Click
        LaporanPengembalian.MdiParent = Me
        LaporanPengembalian.Show()
        MdiParent_Form.VisibleTex()
    End Sub

    Private Sub LOGIN_Click(sender As Object, e As EventArgs) Handles LOGIN.Click
        FormLogin.MdiParent = Me
        FormLogin.Show()
        MdiParent_Form.VisibleTex()
    End Sub

    Private Sub PEMINJAMANBUKU_Click(sender As Object, e As EventArgs) Handles PEMINJAMANBUKU.Click
        FormPeminjaman.MdiParent = Me
        FormPeminjaman.Show()
        MdiParent_Form.VisibleTex()
    End Sub

    Private Sub PENGEMBALIANBUKU_Click(sender As Object, e As EventArgs) Handles PENGEMBALIANBUKU.Click
        FormPengembalian.MdiParent = Me
        FormPengembalian.Show()
        MdiParent_Form.VisibleTex()
    End Sub

    Private Sub DAFTARBUKU_Click(sender As Object, e As EventArgs) Handles DAFTARBUKU.Click
        FormDaftarBuku.MdiParent = Me
        FormDaftarBuku.Show()
        MdiParent_Form.VisibleTex()
    End Sub

    Private Sub PETUGAS_Click(sender As Object, e As EventArgs) Handles PETUGAS.Click
        FormPetugas.MdiParent = Me
        FormPetugas.Show()
        MdiParent_Form.VisibleTex()
    End Sub

    Private Sub ANGGOTA_Click(sender As Object, e As EventArgs) Handles ANGGOTA.Click
        FormAnggota.MdiParent = Me
        FormAnggota.Show()
        MdiParent_Form.VisibleTex()
    End Sub

    Private Sub BUKU_Click(sender As Object, e As EventArgs) Handles BUKU.Click
        FormBuku.MdiParent = Me
        FormBuku.Show()
        MdiParent_Form.VisibleTex()
    End Sub

    Private Sub LOGOUT_Click(sender As Object, e As EventArgs) Handles LOGOUT.Click
        End
    End Sub
End Class
