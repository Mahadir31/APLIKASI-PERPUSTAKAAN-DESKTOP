Imports MySql.Data.MySqlClient

Public Class Anggota
    Public KodeAnggota As String
    Public NamaAnggota As String
    Public JenisKelamin As String
    Public AlamatAnggota As String
    Public TelponAnggota As String

    Public Function Save()
        Try
            Call OpenConn()
            Dim InputData As String = "insert into tblanggota values ('" & KodeAnggota & "','" & NamaAnggota & "','" & JenisKelamin & "','" & AlamatAnggota & "', '" & TelponAnggota & "')"
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
            Dim UpdateData As String = "update tblanggota set NamaAnggota='" & NamaAnggota & "', JenisKelamin='" & JenisKelamin & "', AlamatAnggota='" & AlamatAnggota & "',TelponAnggota = '" & TelponAnggota & "' where KodeAnggota='" & KodeAnggota & "'"
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
            Dim DeleteData As String = "Delete from tblanggota where KodeAnggota ='" & KodeAnggota & "'"
            Cmd = New MySqlCommand(DeleteData, Conn)
            Cmd.ExecuteNonQuery()
            Return True

        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Shared Function SelectKodeAnggota(keyword As String)
        Call OpenConn()
        Cmd = New MySqlCommand("Select * from tblanggota where KodeAnggota='" & keyword & "'", Conn)
        Rd = Cmd.ExecuteReader()
        Rd.Read()
        If Not Rd.HasRows Then
            Return Nothing
        Else
            Dim anggota = New Anggota With {
                .KodeAnggota = Rd.Item("KodeAnggota"),
                .NamaAnggota = Rd.Item("NamaAnggota"),
                .AlamatAnggota = Rd.Item("AlamatAnggota"),
                .JenisKelamin = Rd.Item("JenisKelamin"),
                .TelponAnggota = Rd.Item("TelponAnggota")
            }
            Return anggota
        End If
    End Function

    Public Shared Sub SelectKodeAnggota_From_tblanggota(ByVal KodeAnggota As String)
        Call OpenConn()
        Cmd = New MySqlCommand("select * from tblanggota where KodeAnggota = '" & KodeAnggota & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
    End Sub

    Public Shared Sub SearchNamaAnggota(ByVal NamaAnggota As String)
        Call OpenConn()
        Da = New MySqlDataAdapter("select * from tblanggota where NamaAnggota like '%" & NamaAnggota & "%'", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "tblanggota")
        FormAnggota.DgAnggota.RowTemplate.Height = 30
        FormAnggota.DgAnggota.DataSource = Ds.Tables("tblanggota")
    End Sub
End Class
