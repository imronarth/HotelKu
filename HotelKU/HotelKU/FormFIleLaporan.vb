Public Class FormFIleLaporan

    Private Sub btnDataKwn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDataKwn.Click
        AXCKaryawan.ReportFileName = "Laporan/DataKaryawan.rpt"
        AXCKaryawan.WindowState = Crystal.WindowStateConstants.crptMaximized
        AXCKaryawan.RetrieveDataFiles()
        AXCKaryawan.Action = 1
    End Sub

    Private Sub FormFIleLaporan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Strings.Mid(strMenuAkses, 14, 1) = "1" Then
            btnDataKwn.Visible = True
            Label3.Visible = False
        Else
            btnDataKwn.Visible = False
            lblstatusdatakaryawan.Visible = False
        End If
        If Strings.Mid(strMenuAkses, 15, 1) = "1" Then
            btnDataCustom.Visible = True
            Label5.Visible = False
        Else
            btnDataCustom.Visible = False
            lblstatuscustom.Visible = False
        End If
    End Sub

    Private Sub btnDataCustom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDataCustom.Click
        AXCKaryawan.ReportFileName = "Laporan/DataCustomer.rpt"
        AXCKaryawan.WindowState = Crystal.WindowStateConstants.crptMaximized
        AXCKaryawan.RetrieveDataFiles()
        AXCKaryawan.Action = 1
    End Sub
End Class