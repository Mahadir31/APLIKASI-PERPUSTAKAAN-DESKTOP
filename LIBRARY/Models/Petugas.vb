Imports MySql.Data.MySqlClient

Public Class Petugas
    Public KodePetugas As String
    Public NamaPetugas As String
    Public PasswordPetugas As String
    Public StatusPetugas As String
    Public Function Save()
        Try
            Call OpenConn()
            Dim InputData As String = "insert into tblpetugas values ('" & KodePetugas & "','" & NamaPetugas & "','" & PasswordPetugas & "','" & StatusPetugas & "')"
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
            Dim UpdateData As String = "update tblpetugas set NamaPetugas='" & NamaPetugas & "', passwordPetugas='" & PasswordPetugas & "', StatusPetugas='" &
                StatusPetugas & "' where KodePetugas='" & KodePetugas & "'"
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
            Dim DeleteData As String = "delete from tblpetugas where KodePetugas='" & KodePetugas & "'"
            Cmd = New MySqlCommand(DeleteData, Conn)
            Cmd.ExecuteNonQuery()
            Return True

        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Shared Function Carikode(keyword As String)
        Call OpenConn()
        Cmd = New MySqlCommand("Select * from tblpetugas where KodePetugas='" & keyword & "'", Conn)
        Rd = Cmd.ExecuteReader()
        Rd.Read()
        If Not Rd.HasRows Then
            Return Nothing
        Else
            Dim petugas = New Petugas With {
                .KodePetugas = Rd.Item("KodePetugas"),
                .NamaPetugas = Rd.Item("NamaPetugas"),
                .PasswordPetugas = Rd.Item("PasswordPetugas"),
                .StatusPetugas = Rd.Item("StatusPetugas")
            }
            Return petugas
        End If
    End Function
End Class
