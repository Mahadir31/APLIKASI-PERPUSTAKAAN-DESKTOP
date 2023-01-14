Imports MySql.Data.MySqlClient

Public Class FormAnggota
    Sub Tampil()
        'Memanggil koneksi Dari Modul Koneksi
        Call OpenConn()

        'Untuk Menampilkan Data yang Ada pada DataBase Kedalam DataGridView
        Da = New MySqlDataAdapter("Select * from tblanggota", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tblanggota")
        DgAnggota.RowTemplate.Height = 30
        DgAnggota.DataSource = Ds.Tables("tblanggota")

        'UNtuk Merubah Nama Kolom Pada DataGridView
        DgAnggota.Columns(0).HeaderText = "KODE"
        DgAnggota.Columns(1).HeaderText = "NAMA"
        DgAnggota.Columns(2).HeaderText = "KELAMIN"
        DgAnggota.Columns(3).HeaderText = "ALAMAT"
        DgAnggota.Columns(4).HeaderText = "TELPON"

        'Untuk Menetapkan Nama Pada Button 
        BtnInput.Enabled = True
        BtnInput.Text = "INPUT"
        BtnUpdate.Enabled = True
        BtnUpdate.Text = "UPDATE"
        BtnDelete.Enabled = True
        BtnDelete.Text = "DELETE"
        BtnExit.Text = "EXIT"

        'Untuk Mengosongkan TextBox
        TxtKode.Text = ""
        TxtNama.Text = ""
        CbKelamin.Text = ""
        TxtAlamat.Text = ""
        TxtTelpon.Text = ""
        TxtCari.Text = ""

        'Untuk Mengunci TextBox
        TxtKode.Enabled = False
        TxtNama.Enabled = False
        CbKelamin.Enabled = False
        TxtAlamat.Enabled = False
        TxtTelpon.Enabled = False
        TxtCari.Enabled = False
    End Sub

    'Untuk Membuka TextBox
    Sub Isi()
        TxtKode.Enabled = True
        TxtNama.Enabled = True
        CbKelamin.Enabled = True
        TxtAlamat.Enabled = True
        TxtTelpon.Enabled = True
        TxtCari.Enabled = True
    End Sub
    Private Sub FormAnggota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'untuk Memanggil Sub Tampil
        Call Tampil()
    End Sub
    Private Sub BtnInput_Click(sender As Object, e As EventArgs) Handles BtnInput.Click
        'JIka Button INPUT DiClick
        If BtnInput.Text = "INPUT" Then

            'Maka Text Button INPUT Berubah Menjadi SAVE
            BtnInput.Text = "SAVE"

            'Untuk Mengunci Button UPDATE Ketika Button INPUT Di Click
            BtnUpdate.Enabled = False

            'Untuk Mengunci Button DELETE Ketika Button INPUT Di Click
            BtnDelete.Enabled = False

            'Mengubah Text Button EXIT Menjadi CANCEL Ketika Button INPUT DiClick 
            BtnExit.Text = "&CANCEL"

            'Memanggil Sub Isi Ketika BUtton INPUT DiClick
            Call Isi()

            'Untuk MemFocuskan TextKOde Ketika Button INPUT Di Click
            TxtKode.Focus()
        Else

            'Untuk Mencegah TextBox Kosong Ketika Melakukan Penyimpanan Data / JIka TextBox Kosong
            If TxtKode.Text = "" Or TxtNama.Text = "" Or CbKelamin.Text = "" Or TxtAlamat.Text = "" Or TxtTelpon.Text = "" Then

                'Untuk Memunculkan MsgBox Apabila TextBox Kosong Ketika Melakukan Penyimpanan Data
                MsgBox("Pastikan Semua Filed Terisi !", MsgBoxStyle.Exclamation, "WARNING !")

                'Untuk MemFocuskan TextKOde Ketika Button INPUT Di Click
                TxtKode.Focus()
            Else
                'Membuat Variable Untuk Melakukan Penyimpanan Data
                Dim anggota = New Anggota With {
                        .KodeAnggota = TxtKode.Text,
                        .NamaAnggota = TxtNama.Text,
                        .JenisKelamin = CbKelamin.Text,
                        .AlamatAnggota = TxtAlamat.Text,
                        .TelponAnggota = TxtTelpon.Text
                    }

                'Memanggil Fungsi Save Yang Ada Pada Celas Model Anggota
                Dim Simpan = anggota.Save()

                'Jika Penyimpana Data Berhasi 
                If (Simpan) Then

                    'Memunculkan MsgBox Ketika Penyimpanan Data Berhasil
                    MsgBox("Data Berhasil di Simpan", MsgBoxStyle.Information, "Information")

                    'Memanggil Sub Tampil Ketika Penyimpanan Data Selesai
                    Call Tampil()
                Else
                    'Memunculkan MsgBox Ketika Gagal Melakukan Penyimpanan Data
                    MsgBox("Data Gagal di Simpan......Periksa Koneksi !", MsgBoxStyle.Critical, "Pesan")
                End If

            End If
        End If
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        'Jika Button UPDATE DiClick 
        If BtnUpdate.Text = "UPDATE" Then

            'Maka Text Button UPDATE Berubah Menjadi SAVE
            BtnUpdate.Text = "SAVE"

            'Untuk Mengunci Button INPUT Ketika Button UPDATE DiClick 
            BtnInput.Enabled = False

            'Untuk Mengunci Button INPUT Ketika Button UPDATE DiClick
            BtnDelete.Enabled = False

            'Mengubah Text Button EXIT Menjadi CANCEL Ketika Button UPDATE DiClick
            BtnExit.Text = "&CANCEL"

            'Memanggil Sub Isi Ketika BUtton UPDATE DiClick
            Call Isi()

            'Untuk MemFocuskan TextKOde Ketika Button UPDATE Di Click
            TxtKode.Focus()
        Else
            'Untuk Mencegah TextBox Kosong Ketika Melakukan PengUpdatean Data / JIka TextBox Kosong
            If TxtKode.Text = "" Or TxtNama.Text = "" Or CbKelamin.Text = "" Or TxtAlamat.Text = "" Or TxtTelpon.Text = "" Then

                'Untuk Memunculkan MsgBox Apabila TextBox Kosong Ketika Melakukan PengUpdatean Data
                MsgBox("Pastikan Semua Filed Terisi !", MsgBoxStyle.Exclamation, "WARNING !")

                'Untuk MemFocuskan TextKOde Ketika Button UPDATE DiClick
                TxtKode.Focus()
            Else
                'Membuat Variable Untuk Melakukan PengUpdatean Data
                Dim anggota = New Anggota With {
                        .KodeAnggota = TxtKode.Text,
                        .NamaAnggota = TxtNama.Text,
                        .JenisKelamin = CbKelamin.Text,
                        .AlamatAnggota = TxtAlamat.Text,
                        .TelponAnggota = TxtTelpon.Text
                    }

                'Memanggil Fungsi Update Yang Ada Pada Celas Model Anggota
                Dim Update = anggota.Update()

                'Jika PengUpdatean Data Berhasil
                If (Update) Then

                    'Memunculkan MsgBox Ketika PengUpdatean Data Berhasil
                    MsgBox("Data Berhasil di Ubah", MsgBoxStyle.Information, "Information")

                    'Memanggil Sub Tampil Ketika PengUpdatean Data Selesai
                    Call Tampil()
                Else

                    'Memunculkan MsgBox Ketika Gagal Melakukan PengUpdatean Data
                    MsgBox("Data Gagal di Ubah......Periksa Koneksi !", MsgBoxStyle.Critical, "Pesan")
                End If

            End If
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        'Jika 
        If BtnDelete.Text = "DELETE" Then
            BtnDelete.Text = "SAVE"
            BtnInput.Enabled = False
            BtnUpdate.Enabled = False
            BtnExit.Text = "&CANCEL"
            Call Isi()
            TxtKode.Focus()
        Else
            If TxtKode.Text = "" Or TxtNama.Text = "" Or CbKelamin.Text = "" Or TxtAlamat.Text = "" Or TxtTelpon.Text = "" Then
                MsgBox("Pastikan Semua Filed Terisi !", MsgBoxStyle.Exclamation, "WARNING !")
                TxtKode.Focus()
            Else
                Dim anggota = New Anggota With {
                    .KodeAnggota = TxtKode.Text
                    }
                Dim Delete = anggota.Delete()
                If (Delete) Then
                    MsgBox("Data Berhasil di Hapus", MsgBoxStyle.Information, "Information")
                    Call Tampil()
                Else
                    MsgBox("Data Gagal di Hapus......Periksa Koneksi !", MsgBoxStyle.Critical, "Pesan")
                End If
            End If
        End If
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        'Jika Text Button EXIT
        If BtnExit.Text = "EXIT" Then

            'Maka FormAnggota Keluar (Ketika Button Exit DiClick)
            Me.Close()

            'Memanggil Variable OpenVisibleTex
            'Untuk Memunculkan Text/Desain Pada Form Menu utama
            MdiParent_Form.OpenVisibleTex()
        Else
            'Tapi Jia Text Button CENCEL 
            'Panggil Sub Tampil (Jika DiClick)
            Call Tampil()
        End If
    End Sub
    Private Sub TxtKode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtKode.KeyPress
        If e.KeyChar = Chr(13) Then

            'Memanggil Variable SelectKodeAnggota Pada Class Model Anggota
            Dim hasil = Anggota.SelectKodeAnggota(TxtKode.Text)

            'Jika Bukan Kode Anggota / Jika Kode Anggota Tidak Ada
            If IsNothing(hasil) Then

                'Maka Munculkan MsgBox 
                MsgBox("Data tidak ada", MsgBoxStyle.Critical, "WARNING !")
            Else
                'Jika Kode Anggota Benar / Jika Kode Anggota Ada
                'Munculkan Data KeDalam TexBox Bedasarkan Kode Anggota
                TxtNama.Text = hasil.NamaAnggota
                CbKelamin.Text = hasil.JenisKelamin
                TxtAlamat.Text = hasil.AlamatAnggota
                TxtTelpon.Text = hasil.TelponAnggota
            End If
        End If
    End Sub

    Private Sub TxtCari_TextChanged(sender As Object, e As EventArgs) Handles TxtCari.TextChanged
        'Memanggil Fungsi SearchNamaAnggota Pada Class Model Anggota
        Anggota.SearchNamaAnggota(TxtCari.Text)
    End Sub

    Private Sub DgAnggota_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgAnggota.CellClick
        Dim i As Integer
        i = DgAnggota.CurrentRow.Index
        Call OpenConn()
        Cmd = New MySqlCommand("Select * From tblanggota Where KodeAnggota = '" & DgAnggota.Item(0, i).Value & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()

        On Error Resume Next
        TxtKode.Text = Rd.Item(0)
        TxtNama.Text = Rd.Item(1)
        CbKelamin.Text = Rd.Item(2)
        TxtAlamat.Text = Rd.Item(3)
        TxtTelpon.Text = Rd.Item(4)
        TxtCari.Text = ""
        TxtCari.Focus()
    End Sub

    Private Sub TxtKode_MouseClick(sender As Object, e As MouseEventArgs) Handles TxtKode.MouseClick
        If TxtKode.Text = "" Then
            TxtCari.Enabled = False
        End If
    End Sub

    Private Sub FormAnggota_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        CbKelamin.Text = ""
    End Sub

    Private Sub TxtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNama.KeyPress
        If e.KeyChar = Chr(13) Then
            CbKelamin.Focus()
        End If
    End Sub

    Private Sub TxtKode_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtKode.KeyDown
        If e.KeyCode = (13) Then
            TxtNama.Focus()
        End If
    End Sub

    Private Sub CbKelamin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CbKelamin.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtAlamat.Focus()
        End If
    End Sub

    Private Sub TxtAlamat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAlamat.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtTelpon.Focus()
        End If
    End Sub
End Class