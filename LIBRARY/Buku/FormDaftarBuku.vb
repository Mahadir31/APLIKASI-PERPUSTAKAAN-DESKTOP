Imports MySql.Data.MySqlClient

Public Class FormDaftarBuku
    Private Sub DaftarBuku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call OpenConn()
        Da = New MySqlDataAdapter("Select * from tblbuku", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tblbuku")
        DgNamaBuku.RowTemplate.Height = 50
        DgNamaBuku.DataSource = Ds.Tables("tblbuku")

        DgNamaBuku.Columns(0).HeaderText = "KODE BUKU"
        DgNamaBuku.Columns(1).HeaderText = "JUDUL BUKU"
        DgNamaBuku.Columns(2).HeaderText = "PENGARANG"
        DgNamaBuku.Columns(3).HeaderText = "PENERBIT"
        DgNamaBuku.Columns(4).HeaderText = "TAHUN TERBIT"
        DgNamaBuku.Columns(5).HeaderText = "STOK"
    End Sub

    Private Sub TxtCari_TextChanged(sender As Object, e As EventArgs) Handles TxtCari.TextChanged
        Call OpenConn()
        Da = New MySqlDataAdapter("select * from tblbuku where JudulBuku  like '%" & TxtCari.Text & "%' or PengarangBuku  like '%" & TxtCari.Text & "%'", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "tblbuku")
        DgNamaBuku.RowTemplate.Height = 50
        DgNamaBuku.DataSource = Ds.Tables("tblbuku")
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
        MdiParent_Form.OpenVisibleTex()
    End Sub
End Class