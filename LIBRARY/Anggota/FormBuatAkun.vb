Imports MySql.Data.MySqlClient

Public Class FormBuatAkun
    Sub Isi()
        If TxtKode.ForeColor = Color.Gray Then
            Bintang1.Visible = True
        Else
            Bintang1.Visible = False
        End If
        If TxtNama.ForeColor = Color.Gray Then
            Bintang2.Visible = True
        Else
            Bintang2.Visible = False
        End If
        If CbKelamin.ForeColor = Color.Gray Then
            Bintang3.Visible = True
        Else
            Bintang3.Visible = False
        End If
        If TxtAlamat.ForeColor = Color.Gray Then
            Bintang4.Visible = True
        Else
            Bintang4.Visible = False
        End If
        If TxtTelp.ForeColor = Color.Gray Then
            Bintang5.Visible = True
        Else
            Bintang5.Visible = False
        End If
    End Sub
    Sub Kosong()
        TxtKode.Text = ""
        TxtNama.Text = ""
        CbKelamin.Text = ""
        TxtAlamat.Text = ""
        TxtTelp.Text = ""
        Bintang1.Visible = False
        Bintang2.Visible = False
        Bintang3.Visible = False
        Bintang4.Visible = False
        Bintang5.Visible = False
    End Sub
    Private Sub Btnback_Click(sender As Object, e As EventArgs) Handles Btnback.Click
        Me.Close()
    End Sub

    Private Sub Btnlogin_Click(sender As Object, e As EventArgs) Handles Btnlogin.Click
        If TxtKode.ForeColor = Color.Gray Or TxtNama.ForeColor = Color.Gray Or CbKelamin.ForeColor = Color.Gray Or TxtAlamat.ForeColor = Color.Gray Or TxtTelp.ForeColor = Color.Gray Then
            MsgBox("Pastikan Semua Filed Terisi !", MsgBoxStyle.Exclamation, "WARNING !")
            Call Isi()
        Else
            Try
                Call OpenConn()
                Dim InputData As String = "insert into tblanggota values ('" & TxtKode.Text & "','" &
                    TxtNama.Text & "','" & CbKelamin.Text & "','" & TxtAlamat.Text & "', '" & TxtTelp.Text & "')"
                Cmd = New MySqlCommand(InputData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Pembuatan Akun Berhasil Disimpan", MsgBoxStyle.Information, "Information")
                Call Kosong()
            Catch ex As Exception
                MsgBox("Pembuatan Akun Gagal Disimpan, Periksa Koneksi !", MsgBoxStyle.Critical, "Pesan")
            End Try
        End If

    End Sub

    Private Sub TxtKode_MouseEnter(sender As Object, e As EventArgs) Handles TxtKode.MouseEnter
        If TxtKode.Text = "Cth: AGT0032" Then
            TxtKode.Text = ""
            TxtKode.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TxtKode_MouseLeave(sender As Object, e As EventArgs) Handles TxtKode.MouseLeave
        If TxtKode.Text = "" Then
            TxtKode.Text = "Cth: AGT0032"
            TxtKode.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub TxtNama_MouseEnter(sender As Object, e As EventArgs) Handles TxtNama.MouseEnter
        If TxtNama.Text = "Cth: MAHADIR MUHAMAD" Then
            TxtNama.Text = ""
            TxtNama.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TxtNama_MouseLeave(sender As Object, e As EventArgs) Handles TxtNama.MouseLeave
        If TxtNama.Text = "" Then
            TxtNama.Text = "Cth: MAHADIR MUHAMAD"
            TxtNama.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub CbKelamin_MouseEnter(sender As Object, e As EventArgs) Handles CbKelamin.MouseEnter
        If CbKelamin.Text = "**Jenis Kelamin**" Then
            CbKelamin.Text = ""
            CbKelamin.ForeColor = Color.Black
        End If
    End Sub

    Private Sub CbKelamin_MouseLeave(sender As Object, e As EventArgs) Handles CbKelamin.MouseLeave
        If CbKelamin.Text = "" Then
            CbKelamin.Text = "**Jenis Kelamin**"
            CbKelamin.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub TxtAlamat_MouseEnter(sender As Object, e As EventArgs) Handles TxtAlamat.MouseEnter
        If TxtAlamat.Text = "Cth: Lembar, Jembatan Gantung" Then
            TxtAlamat.Text = ""
            TxtAlamat.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TxtAlamat_MouseLeave(sender As Object, e As EventArgs) Handles TxtAlamat.MouseLeave
        If TxtAlamat.Text = "" Then
            TxtAlamat.Text = "Cth: Lembar, Jembatan Gantung"
            TxtAlamat.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub TxtTelp_MouseEnter(sender As Object, e As EventArgs) Handles TxtTelp.MouseEnter
        If TxtTelp.Text = "Cth: 087849605827" Then
            TxtTelp.Text = ""
            TxtTelp.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TxtTelp_MouseLeave(sender As Object, e As EventArgs) Handles TxtTelp.MouseLeave
        If TxtTelp.Text = "" Then
            TxtTelp.Text = "Cth: 087849605827"
            TxtTelp.ForeColor = Color.Gray
        End If
    End Sub
End Class