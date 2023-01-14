Public Class MdiParent_Form

    Public Shared Sub VisibleTex()
        FormMenuUtama.TxtJudul.Visible = False
        FormMenuUtama.GroupBox3.Visible = False
        FormMenuUtama.GroupBox4.Visible = False
        FormMenuUtama.Label1.Visible = False
        FormMenuUtama.Label3.Visible = False
        FormMenuUtama.Label4.Visible = False
        FormMenuUtama.Label5.Visible = False
        FormMenuUtama.Label6.Visible = False
        FormMenuUtama.PictureBox1.Visible = False
        FormMenuUtama.PictureBox2.Visible = False
        FormMenuUtama.PictureBox3.Visible = False
    End Sub
    Public Shared Sub OpenVisibleTex()
        FormMenuUtama.TxtJudul.Visible = True
        FormMenuUtama.GroupBox3.Visible = True
        FormMenuUtama.GroupBox4.Visible = True
        FormMenuUtama.Label1.Visible = True
        FormMenuUtama.Label3.Visible = True
        FormMenuUtama.Label4.Visible = True
        FormMenuUtama.Label5.Visible = True
        FormMenuUtama.Label6.Visible = True
        FormMenuUtama.PictureBox1.Visible = True
        FormMenuUtama.PictureBox2.Visible = True
        FormMenuUtama.PictureBox3.Visible = True
        FormPetugas.Close()
        FormAnggota.Close()
        FormBuku.Close()
        FormPeminjaman.Close()
        FormPengembalian.Close()
        LaporanPeminjaman.Close()
        LaporanPengembalian.Close()
    End Sub

    Public Shared Sub Close_Form()
        FormPetugas.Close()
        FormAnggota.Close()
        FormBuku.Close()
        FormPeminjaman.Close()
        FormPengembalian.Close()
    End Sub

End Class
