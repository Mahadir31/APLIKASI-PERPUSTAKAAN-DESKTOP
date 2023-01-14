
Imports MySql.Data.MySqlClient

Public Class LaporanPeminjaman
    Sub MunculKodeAnggota()
        Call OpenConn()
        CbKodeAnggota.Items.Clear()
        Cmd = New MySqlCommand("select * from tblanggota", Conn)
        Rd = Cmd.ExecuteReader
        Do While Rd.Read
            CbKodeAnggota.Items.Add(Rd.Item(0))
        Loop
    End Sub
    Sub RbRefresh()
        RbAnggota.Checked = False
        RbTanggal.Checked = False
        RbMinggu.Checked = False
        RbBulan.Checked = False
        RbTahun.Checked = False
        CbKodeAnggota.Text = ""
        BtnKeluar.Text = "EXIT"
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormLpPeminjaman.ShowDialog()
    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        If BtnKeluar.Text = "EXIT" Then
            Me.Close()
            MdiParent_Form.OpenVisibleTex()
            CbKodeAnggota.Text = ""
        Else
            Call RbRefresh()
        End If
    End Sub

    Private Sub LaporanPeminjaman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call MunculKodeAnggota()
        BtnKeluar.Text = "EXIT"
    End Sub

    Private Sub RbAnggota_CheckedChanged(sender As Object, e As EventArgs) Handles RbAnggota.CheckedChanged
        If RbAnggota.Checked = True Then
            BtnKeluar.Text = "&CANCEL"
        End If
    End Sub

    Private Sub RbTanggal_CheckedChanged(sender As Object, e As EventArgs) Handles RbTanggal.CheckedChanged
        If RbTanggal.Checked = True Then
            BtnKeluar.Text = "&CANCEL"
        End If
    End Sub

    Private Sub RbMinggu_CheckedChanged(sender As Object, e As EventArgs) Handles RbMinggu.CheckedChanged
        If RbMinggu.Checked = True Then
            BtnKeluar.Text = "&CANCEL"
        End If
    End Sub

    Private Sub RbBulan_CheckedChanged(sender As Object, e As EventArgs) Handles RbBulan.CheckedChanged
        If RbBulan.Checked = True Then
            BtnKeluar.Text = "&CANCEL"
        End If
    End Sub

    Private Sub RbTahun_CheckedChanged(sender As Object, e As EventArgs) Handles RbTahun.CheckedChanged
        If RbTahun.Checked = True Then
            BtnKeluar.Text = "&CANCEL"
        End If
    End Sub

    Private Sub LaporanPeminjaman_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        CbKodeAnggota.Focus()
    End Sub
End Class