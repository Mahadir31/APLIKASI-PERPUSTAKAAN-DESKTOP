Imports CrystalDecisions.CrystalReports.Engine
Public Class FormLpPengembalian
    Private Sub FormLpPengembalian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Lap As New ReportDocument
        Lap.Load("..\..\LpPngembalia.rpt")
        If LaporanPengembalian.RbAnggota.Checked = True Then
            CRV.SelectionFormula = "totext({tblkembali1.KodeAnggota})='" & LaporanPengembalian.CbKodeAnggota.SelectedItem & "'"
        ElseIf LaporanPengembalian.RbTanggal.Checked = True Then
            Lap.SetParameterValue("Tanggal1", LaporanPengembalian.dtPerTanggal.Text)
            Lap.SetParameterValue("Tanggal2", LaporanPengembalian.dtPerTanggal.Text)
        ElseIf LaporanPengembalian.RbMinggu.Checked = True Then
            Lap.SetParameterValue("Tanggal1", LaporanPengembalian.dtPerMinggu1.Text)
            Lap.SetParameterValue("Tanggal2", LaporanPengembalian.dtPerMinggu2.Text)
        ElseIf LaporanPengembalian.RbBulan.Checked = True Then
            CRV.SelectionFormula = "Month({tblkembali1.TglKembali})=" & LaporanPengembalian.cbPerBulan.SelectedIndex & " and Year({tblkembali1.TglKembali})=" & Format(LaporanPengembalian.dtTahun.Value, "yyyy") & ""
        ElseIf LaporanPengembalian.RbTahun.Checked = True Then
            CRV.SelectionFormula = "Year({tblkembali1.TglKembali})=" & Format(LaporanPengembalian.dtPerTahun.Value, "yyyy") & ""
        End If

        CRV.ReportSource = Lap
    End Sub
End Class