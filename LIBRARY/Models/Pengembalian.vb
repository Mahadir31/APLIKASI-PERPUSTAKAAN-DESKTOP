Imports MySql.Data.MySqlClient

Public Class Pengembalian
    Public NoKembali As String
    Public TglKembali As String
    Public TotalKembali As String
    Public Denda As String
    Public DiBayar As String
    Public Kembali As String
    Public KodeAnggota As String
    Public NamaPetugas As String
    Sub SaveDBKembali()
        Call OpenConn()
        Dim BukuKembali As String = "Insert into tblkembali values ('" & NoKembali & "', '" & TglKembali & "', '" & TotalKembali & "', '" & Denda & "', '" & DiBayar & "', '" & Kembali & "','" & KodeAnggota & "', '" & NamaPetugas & "')"
        Cmd = New MySqlCommand(BukuKembali, Conn)
        Cmd.ExecuteNonQuery()
    End Sub
End Class
