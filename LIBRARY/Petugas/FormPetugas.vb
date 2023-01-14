Imports MySql.Data.MySqlClient
Public Class FormPetugas

    'Membuat fungsi tampil 
    Sub Tampil()

        'Memanggil koneksi pada modul koneksi
        Call OpenConn()

        'Menampilkan data yang ada pada data base ke dalam data grid view
        Da = New MySqlDataAdapter("Select * from tblpetugas", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tblpetugas")
        DgPetugas.RowTemplate.Height = 50
        DgPetugas.DataSource = Ds.Tables("tblpetugas")

        'Merubah nama kolom pada data grid view
        DgPetugas.Columns(0).HeaderText = "KODE "
        DgPetugas.Columns(1).HeaderText = "NAMA"
        DgPetugas.Columns(2).HeaderText = "PASSWORD"
        DgPetugas.Columns(3).HeaderText = "STATUS"

        'Berfungsi untuk mengosongkan text box
        TxtKode.Text = ""
        TxtNama.Text = ""
        TxtPassword.Text = ""
        CbStatus.Text = ""

        'Berfungsi untuk mengunci text box
        TxtKode.Enabled = False
        TxtNama.Enabled = False
        TxtPassword.Enabled = False
        CbStatus.Enabled = False
        PictureBox4.Enabled = False
        PictureBox5.Visible = False

        'Berfungsi untuk mengembalikan text button
        BtnInput.Enabled = True
        BtnInput.Text = "INPUT"
        BtnUpdate.Enabled = True
        BtnUpdate.Text = "UPDATE"
        BtnDelete.Enabled = True
        BtnDelete.Text = "DELETE"
        BtnExit.Text = "EXIT"
    End Sub

    'membuat fungsi isi
    Sub Isi()
        'Berfungsi untuk membuka text box
        TxtKode.Enabled = True
        TxtNama.Enabled = True
        TxtPassword.Enabled = True
        CbStatus.Enabled = True
        PictureBox4.Enabled = True
    End Sub
    Private Sub FormPetugas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'memanggil fungsi sub tampil pada form load
        Call Tampil()
    End Sub
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

        'Jika passwordchar bintang (*)
        If TxtPassword.PasswordChar = "*" Then

            'maka passwordchar ()
            TxtPassword.PasswordChar = ""

            'PictureBox5 terbuka 
            PictureBox5.Visible = True
        Else
            'jika tida passwordchar bintang (*)
            TxtPassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        If PictureBox5.Visible = True Then
            PictureBox5.Visible = False
            TxtPassword.PasswordChar = "*"
        Else
            TxtPassword.PasswordChar = ""
        End If
    End Sub

    Private Sub BtnInput_Click(sender As Object, e As EventArgs) Handles BtnInput.Click
        'Jika buton INPUT di klik 
        If BtnInput.Text = "INPUT" Then
            'Maka text buton INPUT berubah menjadi save
            BtnInput.Text = "SAVE"
            'buton update terkunci
            BtnUpdate.Enabled = False
            'buton delete terkunci
            BtnDelete.Enabled = False
            'buton exit berubah menjadi cencel
            BtnExit.Text = "&CANCEL"
            'Panggil fungsi sub isi
            Call Isi()
            TxtKode.Focus()
        Else
            'Jika text box kosong 
            If TxtKode.Text = "" Or TxtNama.Text = "" Or TxtPassword.Text = "" Or CbStatus.Text = "" Then
                'maka munculkan msgbox
                MsgBox("Pastikan Semua Filed Terisi !", MsgBoxStyle.Exclamation, "WARNING !")
                TxtKode.Focus()
            Else
                'membuat variable simpan
                Dim petugas = New Petugas With {
                    .KodePetugas = TxtKode.Text,
                    .NamaPetugas = TxtNama.Text,
                    .PasswordPetugas = TxtPassword.Text,
                    .StatusPetugas = CbStatus.Text
                }
                'panggil fungsi save pada kelas model petugas
                Dim save = petugas.Save()
                'jika penyimpanan berhasil 
                If (save) Then
                    'maka munculkan msgbox
                    MsgBox("Data Berhasil di Simpan", MsgBoxStyle.Information, "INFORMTION")
                    'panggil fungsi tampil
                    Call Tampil()
                Else
                    'Jika penyimpanan gagal, maka munculkan msgbox yang ada di bawah ini
                    MsgBox("Data Gagal di Simpan......Periksa Koneksi !", MsgBoxStyle.Critical, "Pesan")
                End If
            End If
        End If
    End Sub
    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        'jika buton update di klik
        If BtnUpdate.Text = "UPDATE" Then
            'maka buton update berubah menjadi save
            BtnUpdate.Text = "SAVE"
            'buton input terkunci
            BtnInput.Enabled = False
            'buton delete terkunci
            BtnDelete.Enabled = False
            'buton exit berubah menjadi cancel
            BtnExit.Text = "&CANCEL"
            'panggil sub isi
            Call Isi()
            TxtKode.Focus()
        Else
            'jika text box kosong 
            If TxtKode.Text = "" Or TxtNama.Text = "" Or TxtPassword.Text = "" Or CbStatus.Text = "" Then
                'maka munculkan msgbox di bawah ini
                MsgBox("Pastikan Semua Filed Terisi !", MsgBoxStyle.Exclamation, "WARNING !")
                TxtKode.Focus()
            Else
                'membuat variable update
                Dim petugas = New Petugas With {
                    .KodePetugas = TxtKode.Text,
                    .NamaPetugas = TxtNama.Text,
                    .PasswordPetugas = TxtPassword.Text,
                    .StatusPetugas = CbStatus.Text
                }
                'pangil funsi update pada kelas model petugas
                Dim update = petugas.Update()
                'jika update berhasil 
                If (update) Then
                    'maka munculkan msgbox di bawah ini
                    MsgBox("Data Berhasil di Ubah", MsgBoxStyle.Information, "INFORMATION")
                    'memangil funsi sub tampil
                    Call Tampil()
                Else
                    'jika update gagal, maka munculkan msgbox di bawah ini
                    MsgBox("Data Gagal di Ubah......Periksa Koneksi !", MsgBoxStyle.Critical, "Pesan")

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
            If TxtKode.Text = "" Or TxtNama.Text = "" Or TxtPassword.Text = "" Or CbStatus.Text = "" Then
                MsgBox("Pastikan Semua Filed Terisi !", MsgBoxStyle.Exclamation, "WARNING !")
                TxtKode.Focus()
            Else
                Dim petugas = New Petugas With {
                    .KodePetugas = TxtKode.Text
                }
                Dim delete = petugas.Delete()
                If (delete) Then
                    MsgBox("Data Berhasil di Hapus", MsgBoxStyle.Information, "INFORMATION")
                    Call Tampil()
                Else
                    MsgBox("Data Gagal di Hapus......Periksa Koneksi !", MsgBoxStyle.Critical, "Pesan")

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
            Dim hasil = Petugas.Carikode(TxtKode.Text)
            If IsNothing(hasil) Then
                MsgBox("Data tidak ada !", MsgBoxStyle.Critical, "WARNING !")
            Else
                TxtNama.Text = hasil.NamaPetugas
                TxtPassword.Text = hasil.PasswordPetugas
                CbStatus.Text = hasil.StatusPetugas
            End If
        End If
    End Sub
    Private Sub TxtKode_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtKode.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtNama.Focus()
        End If
    End Sub
    Private Sub TxtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNama.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtPassword.Focus()
        End If
    End Sub
    Private Sub TxtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPassword.KeyPress
        If e.KeyChar = Chr(13) Then
            CbStatus.Focus()
        End If
    End Sub
    Private Sub CbStatus_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CbStatus.KeyPress
        If e.KeyChar = Chr(13) Then
            BtnInput.Focus()
            BtnUpdate.Focus()
            BtnDelete.Focus()
        End If
    End Sub
End Class