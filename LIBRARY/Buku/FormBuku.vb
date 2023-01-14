Imports MySql.Data.MySqlClient

Public Class FormBuku
    Sub Tampil()
        Call OpenConn()
        Da = New MySqlDataAdapter("Select * from tblbuku", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tblbuku")
        DgBuku.RowTemplate.Height = 50
        DgBuku.DataSource = Ds.Tables("tblbuku")

        DgBuku.Columns(0).HeaderText = "KODE BUKU"
        DgBuku.Columns(1).HeaderText = "JUDUL"
        DgBuku.Columns(2).HeaderText = "PENGARANG"
        DgBuku.Columns(3).HeaderText = "PENERBIT"
        DgBuku.Columns(4).HeaderText = "THN TERBIT"
        DgBuku.Columns(5).HeaderText = "STOK"


        BtnInput.Enabled = True
        BtnInput.Text = "INPUT"
        BtnUpdate.Enabled = True
        BtnUpdate.Text = "UPDATE"
        BtnDelete.Enabled = True
        BtnDelete.Text = "DELETE"
        BtnExit.Text = "EXIT"

        TxtKode.Text = ""
        TxtJudul.Text = ""
        TxtPengarang.Text = ""
        TxtPenerbit.Text = ""
        CbTahun.Text = ""
        TxtStok.Text = ""
        txtcari.Text = ""

        TxtKode.Enabled = False
        TxtJudul.Enabled = False
        TxtPengarang.Enabled = False
        TxtPenerbit.Enabled = False
        CbTahun.Enabled = False
        TxtStok.Enabled = False
        TxtCari.Enabled = False

        Dim Tahun As String
        Tahun = Date.Now().Year
        CbTahun.Items.Clear()
        With CbTahun
            While Tahun >= 2005
                .Items.Add(Tahun)
                Tahun = Tahun - 1
            End While
        End With
    End Sub
    Sub Isi()
        TxtKode.Enabled = True
        TxtJudul.Enabled = True
        TxtPengarang.Enabled = True
        TxtPenerbit.Enabled = True
        CbTahun.Enabled = True
        TxtStok.Enabled = True
        TxtCari.Enabled = True
    End Sub

    Private Sub FormBuku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Tampil()
    End Sub

    Private Sub BtnInput_Click(sender As Object, e As EventArgs) Handles BtnInput.Click
        If BtnInput.Text = "INPUT" Then
            BtnInput.Text = "SAVE"
            BtnUpdate.Enabled = False
            BtnDelete.Enabled = False
            BtnExit.Text = "&CANCEL"
            Call Isi()
            TxtKode.Focus()
        Else
            If TxtKode.Text = "" Or TxtJudul.Text = "" Or TxtPengarang.Text = "" Or TxtPenerbit.Text = "" Or CbTahun.Text = "" Or TxtStok.Text = "" Then
                MsgBox("Pastikan Semua Filed Terisi !", MsgBoxStyle.Exclamation, "WARNING !")
                TxtKode.Focus()
            Else
                Dim buku = New Buku With {
                       .KodeBuku = TxtKode.Text,
                       .JudulBuku = TxtJudul.Text,
                       .PengarangBuku = TxtPengarang.Text,
                       .Penerbit = TxtPenerbit.Text,
                       .TahunBuku = CbTahun.Text,
                       .StokBuku = TxtStok.Text
                   }
                Dim tersimpan = buku.Save()
                If (tersimpan) Then
                    MsgBox("Data Berhasil di Simpan", MsgBoxStyle.Information, "Information")
                    Call Tampil()
                Else
                    MsgBox("Data Gagal di Simpan......Periksa Koneksi !", MsgBoxStyle.Critical, "Pesan")
                End If

            End If
        End If
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If BtnUpdate.Text = "UPDATE" Then
            BtnUpdate.Text = "SAVE"
            BtnInput.Enabled = False
            BtnDelete.Enabled = False
            BtnExit.Text = "&CANCEL"
            Call Isi()
            TxtKode.Focus()
        Else
            If TxtKode.Text = "" Or TxtJudul.Text = "" Or TxtPengarang.Text = "" Or TxtPenerbit.Text = "" Or CbTahun.Text = "" Or TxtStok.Text = "" Then
                MsgBox("Pastikan Semua Filed Terisi !", MsgBoxStyle.Exclamation, "WARNING !")
                TxtKode.Focus()
            Else
                Dim buku = New Buku With {
                       .KodeBuku = TxtKode.Text,
                       .JudulBuku = TxtJudul.Text,
                       .PengarangBuku = TxtPengarang.Text,
                       .Penerbit = TxtPenerbit.Text,
                       .TahunBuku = CbTahun.Text,
                       .StokBuku = TxtStok.Text
                   }
                Dim Update = buku.Update()
                If (Update) Then
                    MsgBox("Data Berhasil di Update", MsgBoxStyle.Information, "Information")
                    Call Tampil()
                Else
                    MsgBox("Data Gagal di Update......Periksa Koneksi !", MsgBoxStyle.Critical, "Pesan")
                End If

            End If
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If BtnDelete.Text = "DELETE" Then
            BtnDelete.Text = "SAVE"
            BtnInput.Enabled = False
            BtnUpdate.Enabled = False
            BtnExit.Text = "&CANCEL"
            Call Isi()
            TxtKode.Focus()
        Else
            If TxtKode.Text = "" Or TxtJudul.Text = "" Or TxtPengarang.Text = "" Or TxtPenerbit.Text = "" Or CbTahun.Text = "" Or TxtStok.Text = "" Then
                MsgBox("Pastikan Semua Filed Terisi !", MsgBoxStyle.Exclamation, "WARNING !")
                TxtKode.Focus()
            Else
                Dim buku = New Buku With {
                       .KodeBuku = TxtKode.Text
                   }
                Dim Delete = buku.Delete()
                If (Delete) Then
                    MsgBox("Data Berhasil di Simpan", MsgBoxStyle.Information, "Information")
                    Call Tampil()
                Else
                    MsgBox("Data Gagal di Simpan......Periksa Koneksi !", MsgBoxStyle.Critical, "Pesan")
                End If

            End If
        End If
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        If BtnExit.Text = "EXIT" Then
            Me.Close()
            MdiParent_Form.OpenVisibleTex()
        Else
            Call Tampil()
        End If
    End Sub

    Private Sub TxtKode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtKode.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim hasil = Buku.SearchKode(TxtKode.Text)
            If IsNothing(hasil) Then
                MsgBox("Data tidak ada", MsgBoxStyle.Critical, "WARNING !")
            Else
                TxtJudul.Text = hasil.JudulBuku
                TxtPengarang.Text = hasil.PengarangBuku
                TxtPenerbit.Text = hasil.TahunBuku
                CbTahun.Text = hasil.TahunBuku
                TxtStok.Text = hasil.StokBuku
            End If
        End If
    End Sub

    Private Sub TxtCari_TextChanged(sender As Object, e As EventArgs) Handles TxtCari.TextChanged
        Call OpenConn()
        Da = New MySqlDataAdapter("select * from tblbuku where JudulBuku  like '%" & TxtCari.Text & "%' or PengarangBuku  like '%" & TxtCari.Text & "%'  or KodeBuku  like '%" & TxtCari.Text & "%'", Conn)
                    Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "tblbuku")
        DgBuku.RowTemplate.Height = 50
        DgBuku.DataSource = Ds.Tables("tblbuku")
    End Sub

    Private Sub DgBuku_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgBuku.CellClick
        Dim i As Integer
        i = DgBuku.CurrentRow.Index
        Call OpenConn()
        Cmd = New MySqlCommand("Select * From tblbuku Where KodeBuku = '" & DgBuku.Item(0, i).Value & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()

        On Error Resume Next
        TxtKode.Text = Rd.Item(0)
        TxtJudul.Text = Rd.Item(1)
        TxtPengarang.Text = Rd.Item(2)
        TxtPenerbit.Text = Rd.Item(3)
        CbTahun.Text = Rd.Item(4)
        TxtStok.Text = Rd.Item(5)
        TxtCari.Text = ""
        TxtCari.Focus()
    End Sub

    Private Sub TxtKode_MouseClick(sender As Object, e As MouseEventArgs) Handles TxtKode.MouseClick
        If TxtKode.Text = "" Then
            TxtCari.Enabled = False
        End If
    End Sub

    Private Sub TxtKode_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtKode.KeyDown
        If e.KeyCode = (13) Then
            TxtJudul.Focus()
        End If
    End Sub

    Private Sub TxtJudul_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtJudul.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtPengarang.Focus()
        End If
    End Sub

    Private Sub TxtPengarang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPengarang.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtPenerbit.Focus()
        End If
    End Sub

    Private Sub TxtPenerbit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPenerbit.KeyPress
        If e.KeyChar = Chr(13) Then
            CbTahun.Focus()
        End If
    End Sub

    Private Sub CbTahun_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CbTahun.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtStok.Focus()
        End If
    End Sub
End Class