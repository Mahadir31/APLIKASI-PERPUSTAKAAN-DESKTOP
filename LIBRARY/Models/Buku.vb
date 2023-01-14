Imports MySql.Data.MySqlClient

Public Class Buku
    Public KodeBuku As String
    Public JudulBuku As String
    Public PengarangBuku As String
    Public Penerbit As String
    Public TahunBuku As Integer
    Public StokBuku As Integer

    Public Shared Function SearchKode(keyword As String)
        Call OpenConn()
        Cmd = New MySqlCommand("Select * from tblbuku where KodeBuku='" & keyword & "'", Conn)
        Rd = Cmd.ExecuteReader()
        Rd.Read()
        If Not Rd.HasRows Then
            Return Nothing
        Else
            Dim buku = New Buku With {
                .JudulBuku = Rd.Item("JudulBuku"),
                .PengarangBuku = Rd.Item("PengarangBuku"),
                .Penerbit = Rd.Item("Penerbit"),
                .TahunBuku = Rd.Item("TahunBuku"),
                .StokBuku = Rd.Item("StokBuku"),
                .KodeBuku = Rd.Item("KodeBuku")
            }
            Return buku
        End If
    End Function

    Public Function Save()
        Try
            Call OpenConn()
            Dim InputData As String = "Insert into tblbuku values ('" & KodeBuku & "','" & JudulBuku & "','" & PengarangBuku & "','" &
                                                                        Penerbit & "', '" & TahunBuku & "','" & StokBuku & "')"
            Cmd = New MySqlCommand(InputData, Conn)
            Cmd.ExecuteNonQuery()
            Return True

        Catch ex As Exception
            Return False
        End Try


    End Function
    Public Function Update()
        Try
            Call OpenConn()
            Dim UpdateData As String = "update tblbuku set JudulBuku='" & JudulBuku & "', PengarangBuku='" & PengarangBuku & "', Penerbit='" &
                                       Penerbit & "', TahunBuku='" & TahunBuku & "', StokBuku='" & StokBuku & "' where KodeBuku='" & KodeBuku & "'"
            Cmd = New MySqlCommand(UpdateData, Conn)
            Cmd.ExecuteNonQuery()
            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function
    Public Function Delete()
        Try
            Call OpenConn()
            Dim DeleteData As String = "Delete from tblbuku where KodeBuku ='" & KodeBuku & "'"
            Cmd = New MySqlCommand(DeleteData, Conn)
            Cmd.ExecuteNonQuery()
            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function
    Public Shared Sub UpdateStokBuku_From_tblbuku(ByVal KodeBuku As String, ByVal Stok As Integer)
        Call OpenConn()
        Dim KurangiStok As String = "update tblbuku set StokBuku = '" & Stok & "' where KodeBuku =  '" & KodeBuku & "'"
        Cmd = New MySqlCommand(KurangiStok, Conn)
        Cmd.ExecuteNonQuery()
    End Sub
    Public Shared Sub SaveDetailPinjam(ByVal NoPinjam As String, ByVal KodeBuku As String, ByVal JumlahBuku As Integer)
        Call OpenConn()
        Dim SimpanDetailPinjam As String = "Insert into tbldetailpinjam values ('" & NoPinjam & "', '" & KodeBuku & "', '" & JumlahBuku & "')"
        Cmd = New MySqlCommand(SimpanDetailPinjam, Conn)
        Cmd.ExecuteNonQuery()
    End Sub
    Public Shared Sub SelectJumlahBuku_From_DetailPinjam(ByVal KodeBuku As String, ByVal NoPinjam As String)
        Call OpenConn()
        Cmd = New MySqlCommand("select JumlahBuku from tbldetailpinjam where KodeBuku= '" & KodeBuku & "' and NoPinjam= '" & NoPinjam & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
    End Sub
    Public Shared Sub UpdateDetailPinjam_Set_JumlahBuku(ByVal JumlahBuku As Integer, ByVal KodeBuku As String, ByVal Nopinjam As String)
        Call OpenConn()
        Dim UpdateDetailPinjam As String = "update tbldetailpinjam set JumlahBuku= '" & JumlahBuku & "' Where KodeBuku= '" & KodeBuku & "' and NoPinjam= '" & Nopinjam & "'"
        Cmd = New MySqlCommand(UpdateDetailPinjam, Conn)
        Cmd.ExecuteNonQuery()
    End Sub
    Public Shared Sub SelectKodeBuku(ByVal KodeBuku As String)
        Call OpenConn()
        Cmd = New MySqlCommand("select * from tblbuku where KodeBuku = '" & KodeBuku & "'", Conn)
        Rd = Cmd.ExecuteReader()
        Rd.Read()
    End Sub
    Public Shared Sub SaveDetailKembali(ByVal NoKembali As String, ByVal kodeBuku As String, ByVal JumlahBuku As String)
        Call OpenConn()
        Dim SimpanDetailKembali As String = "Insert into tbldetailkembali values ('" & NoKembali & "', '" & kodeBuku & "', '" & JumlahBuku & "')"
        Cmd = New MySqlCommand(SimpanDetailKembali, Conn)
        Cmd.ExecuteNonQuery()
    End Sub
End Class
