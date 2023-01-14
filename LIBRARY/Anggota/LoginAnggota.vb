Imports System.IO
Imports MySql.Data.MySqlClient

Public Class LoginAnggota
    Sub Buka()
        FormMenuUtama.LOGIN.Enabled = False
        FormMenuUtama.EXITT.Enabled = True
        FormMenuUtama.MASTER.Visible = False
        FormMenuUtama.TRANSAKSI.Visible = False
        FormMenuUtama.LAPORAN.Visible = False
        FormMenuUtama.DAFTARBUKU.Visible = True
        PictureBox5.Visible = False
    End Sub
    Private Sub RbLogin_CheckedChanged(sender As Object, e As EventArgs) Handles RbLogin.CheckedChanged
        If RbLogin.Checked = True Then
            Btnback.Text = "&CANCEL"
            Btnlogin.Text = "NEXT"
        Else
            Btnback.Text = "BACK"
            Btnlogin.Text = "LOGIN"
            TxtKode.Focus()
        End If
    End Sub

    Private Sub Btnback_Click(sender As Object, e As EventArgs) Handles Btnback.Click
        If Btnback.Text = "&CANCEL" Then
            RbLogin.Checked = False
        Else
            Me.Close()
        End If
    End Sub

    Private Sub TxtKode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtKode.KeyPress
        If e.KeyChar = Chr(13) Then
            Btnlogin.Focus()
        End If
    End Sub

    Private Sub Btnlogin_Click(sender As Object, e As EventArgs) Handles Btnlogin.Click
        If Btnlogin.Text = "NEXT" Then
            FormBuatAkun.ShowDialog()
            RbLogin.Checked = False
            PictureBox5.Visible = False
            Btnback.Text = "BACK"
            Btnlogin.Text = "LOGIN"
            TxtKode.Focus()
        Else
            If TxtKode.ForeColor = Color.Gray Or TxtKode.Text = "" Then
                MsgBox("Kode Anggota Tidak Boleh Kosong !", MsgBoxStyle.Exclamation, "WARNING !")
                TxtKode.Focus()
            Else
                Call OpenConn()
                Cmd = New MySqlCommand("Select * from tblanggota where KodeAnggota='" & TxtKode.Text & "'", Conn)
                Rd = Cmd.ExecuteReader()
                Rd.Read()
                If Rd.HasRows Then
                    Me.Close()
                    FormLogin.Close()
                    Call Buka()
                    MdiParent_Form.OpenVisibleTex()
                    FormMenuUtama.TSSkodepetugas.Text = Rd!KodeAnggota
                    FormMenuUtama.TSSnamapetugas.Text = Rd!NamaAnggota
                    FormMenuUtama.TSSstatuspetugas.Text = "ANGGOTA"
                    MsgBox("Kode Dengan (" & TxtKode.Text & ") Berhasil Masuk", MsgBoxStyle.Information, "INFORMATION")
                Else
                    MsgBox("KODE AGGOTA TIDAK ADA", MsgBoxStyle.Critical, "WARNING !")
                    TxtKode.ForeColor = Color.Red
                End If
            End If
        End If
    End Sub

    Private Sub LoginAnggota_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        TxtKode.Text = ""
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If TxtKode.PasswordChar = "*" Then
            TxtKode.PasswordChar = ""
            PictureBox5.Visible = True
        Else
            TxtKode.PasswordChar = "*"
        End If
    End Sub

    Private Sub TxtKode_MouseEnter(sender As Object, e As EventArgs) Handles TxtKode.MouseEnter
        If TxtKode.Text = "Cth: AGT0032" Then
            TxtKode.Text = ""
            TxtKode.PasswordChar = "*"
            TxtKode.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TxtKode_MouseLeave(sender As Object, e As EventArgs) Handles TxtKode.MouseLeave
        If TxtKode.Text = "" Then
            TxtKode.Text = "Cth: AGT0032"
            TxtKode.PasswordChar = ""
            TxtKode.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        If PictureBox5.Visible = True Then
            PictureBox5.Visible = False
            TxtKode.PasswordChar = "*"
        Else
            TxtKode.PasswordChar = ""
        End If
    End Sub
End Class