Imports CrystalDecisions.CrystalReports.Engine
Public Class FormLpPeminjaman
    Private Sub FormLpPeminjaman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Lap As New ReportDocument
        Lap.Load("..\..\LpPeminjaman.rpt")
        If LaporanPeminjaman.RbAnggota.Checked = True Then
            CRV.SelectionFormula = "totext({tblpinjam1.KodeAnggota})='" & LaporanPeminjaman.CbKodeAnggota.SelectedItem & "'"
        ElseIf LaporanPeminjaman.RbTanggal.Checked = True Then
            Lap.SetParameterValue("Tanggal1", LaporanPeminjaman.dtPerTanggal.Text)
            Lap.SetParameterValue("Tanggal2", LaporanPeminjaman.dtPerTanggal.Text)
        ElseIf LaporanPeminjaman.RbMinggu.Checked = True Then
            Lap.SetParameterValue("Tanggal1", LaporanPeminjaman.dtPerMinggu1.Text)
            Lap.SetParameterValue("Tanggal2", LaporanPeminjaman.dtPerMinggu2.Text)
        ElseIf LaporanPeminjaman.RbBulan.Checked = True Then
            CRV.SelectionFormula = "Month({tblpinjam1.TglPinjam})=" & LaporanPeminjaman.cbPerBulan.SelectedIndex & " and Year({tblpinjam1.TglPinjam})=" & Format(LaporanPeminjaman.dtTahun.Value, "yyyy") & ""
        ElseIf LaporanPeminjaman.RbTahun.Checked = True Then
            CRV.SelectionFormula = "Year({tblpinjam1.TglPinjam})=" & Format(LaporanPeminjaman.dtPerTahun.Value, "yyyy") & ""
        End If

        CRV.ReportSource = Lap
    End Sub
End Class