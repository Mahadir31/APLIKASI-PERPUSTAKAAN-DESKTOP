Imports System.Reflection
Imports System.Web.UI.WebControls
Imports System.Windows.Forms.VisualStyles
Imports MySql.Data.MySqlClient
Public Class FormLogin
    Sub Buka()
        FormMenuUtama.LOGIN.Enabled = False
        FormMenuUtama.EXITT.Enabled = True
        FormMenuUtama.MASTER.Visible = True
        FormMenuUtama.TRANSAKSI.Visible = True
        FormMenuUtama.LAPORAN.Visible = True
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtKode.Text = ""
        TxtPassword.Text = ""
    End Sub

    Private Sub BtnChek_Click(sender As Object, e As EventArgs)
        If TxtPassword.PasswordChar = "*" Then
            TxtPassword.PasswordChar = ""
        Else
            TxtPassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub Btnback_Click(sender As Object, e As EventArgs) Handles Btnback.Click
        If Btnback.Text = "&CANCEL" Then
            RbLogin.Checked = False
        Else
            Me.Close()
            MdiParent_Form.OpenVisibleTex()
            FormMenuUtama.EXITT.Enabled = True
        End If

    End Sub

    Private Sub Btnlogin_Click(sender As Object, e As EventArgs) Handles Btnlogin.Click
        If Btnlogin.Text = "NEXT" Then
            LoginAnggota.ShowDialog()
            RbLogin.Checked = False
            Btnback.Text = "BACK"
            Btnlogin.Text = "LOGIN"
            TxtKode.Focus()
        Else
            If TxtKode.Text = "" Or TxtPassword.Text = "" Then
                MsgBox("Kode Petugas Atau Password Tidak Boleh Kosong !!!", MsgBoxStyle.Exclamation, "WARNING")
                TxtKode.Focus()
            Else
                Call OpenConn()
                Cmd = New MySqlCommand("select * from tblpetugas where KodePetugas = '" & TxtKode.Text & "' and PasswordPetugas ='" & TxtPassword.Text & "'", Conn)
                Rd = Cmd.ExecuteReader
                Rd.Read()
                If Rd.HasRows Then
                    Me.Close()
                    Call Buka()
                    MdiParent_Form.OpenVisibleTex()
                    FormMenuUtama.TSSkodepetugas.Text = Rd!KodePetugas
                    FormMenuUtama.TSSnamapetugas.Text = Rd!NamaPetugas
                    FormMenuUtama.TSSstatuspetugas.Text = Rd!StatusPetugas
                    If FormMenuUtama.TSSstatuspetugas.Text = "KEPALA" Then
                        FormMenuUtama.PETUGAS.Visible = True
                    Else
                        FormMenuUtama.PETUGAS.Visible = False
                    End If
                Else
                    MsgBox("Kode Petugas Atau password SALAH !!!", MsgBoxStyle.Exclamation, "PRIKSA KEMBALI")
                End If
            End If
        End If
    End Sub

    Private Sub TxtKode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtKode.KeyPress
        If e.KeyChar = Chr(13) Then
            Call OpenConn()
            Cmd = New MySqlCommand("Select * from tblpetugas where KodePetugas='" & TxtKode.Text & "'", Conn)
            Rd = Cmd.ExecuteReader()
            Rd.Read()
            If Not Rd.HasRows Then
                MsgBox("KODE PETUGAS TIDAK ADA")
                TxtKode.ForeColor = Color.Red
            Else
                TxtPassword.Focus()
                TxtKode.ForeColor = Color.Black
            End If
        End If
    End Sub

    Private Sub TxtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPassword.KeyPress
        If e.KeyChar = Chr(13) Then
            Call OpenConn()
            Cmd = New MySqlCommand("Select * from tblpetugas where PasswordPetugas='" & TxtPassword.Text & "'", Conn)
            Rd = Cmd.ExecuteReader()
            Rd.Read()
            If Not Rd.HasRows Then
                MsgBox("PASSWORD PETUGAS TIDAK ADA")
                TxtPassword.ForeColor = Color.Red
            Else
                Btnlogin.Focus()
                TxtPassword.ForeColor = Color.Black
                TxtPassword.PasswordChar = "*"
                PictureBox5.Visible = False
            End If
        End If
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

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If TxtPassword.PasswordChar = "*" Then
            PictureBox5.Visible = True
            TxtPassword.PasswordChar = ""
        Else
            TxtPassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        If PictureBox5.Visible = True Then
            TxtPassword.PasswordChar = "*"
            PictureBox5.Visible = False
        Else
            TxtPassword.PasswordChar = ""
        End If
    End Sub

    Private Sub FormLogin_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        TxtKode.Focus()
    End Sub
End Class