Imports MySql.Data.MySqlClient

Public Class Peminjaman
    Public NoPinjam As String
    Public TglPinjam As String
    Public JamPinjam As String
    Public KodeAnggota As String
    Public ItemPinjam As String
    Public TotalPinjam As String
    Public NamaPetugas As String


    Sub SaveDBPinjam()
        Call OpenConn()
        Dim PinjamBuku As String = "Insert into tblpinjam values ('" & NoPinjam & "', '" & TglPinjam & "', '" & JamPinjam & "', '" & KodeAnggota & "', '" &
                                                                             ItemPinjam & "', '" & TotalPinjam & "', '" & NamaPetugas & "')"
        Cmd = New MySqlCommand(PinjamBuku, Conn)
        Cmd.ExecuteNonQuery()
    End Sub
    Public Shared Sub SelectKodeAnggota_From_tblpinjam(ByVal KodeAnggota As String)
        Call OpenConn()
        Cmd = New MySqlCommand("select KodeAnggota from tblpinjam where KodeAnggota = '" & KodeAnggota & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
    End Sub
    Public Shared Sub SelectSUMTotalPinjam_From_tblpinjam(ByVal KodeAnggota As String)
        Call OpenConn()
        Cmd = New MySqlCommand("Select SUM(TotalPinjam) As meet from tblpinjam where KodeAnggota = '" & KodeAnggota & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
    End Sub
    Public Shared Sub SelectTotalPinjam_From_tblpinjam(ByVal NoPinjam As String)
        Call OpenConn()
        Cmd = New MySqlCommand("select TotalPinjam from tblpinjam where NoPinjam= '" & NoPinjam & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
    End Sub
    Public Shared Sub Updatetblpinjam_Set_TotalPinjam(ByVal TotalPinjam As Integer, ByVal NoPinjam As String)
        Call OpenConn()
        Dim UpdatePinjam As String = "update tblpinjam set totalPinjam= '" & TotalPinjam & "' where NoPinjam= '" & NoPinjam & "'"
        Cmd = New MySqlCommand(UpdatePinjam, Conn)
        Cmd.ExecuteNonQuery()
    End Sub
End Class
