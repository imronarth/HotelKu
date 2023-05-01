Public Class FormMenu

    Private Sub CheckOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuentrykamar.Click
        FormEntryKamar.Show()
        FormEntryKamar.MdiParent = Me
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuKeluar.Click
        If MsgBox("Anda yakin ingin keluar dari Aplikasi Pemsanan Hotel ?", vbYesNo, "Konfirmasi") = vbNo Then Exit Sub
        Me.Close()
    End Sub

    Private Sub StripLogOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuLogOut.Click
        If MsgBox("Anda yakin ingin Log Out ?", vbYesNo, "Konfirmasi") = vbNo Then Exit Sub
        FormLogin.Show()
        FormLogin.tbuser.Focus()
        Me.Close()
    End Sub


    Private Sub LabStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DaftarCostumerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuentrycus.Click
        FormDaftarCustomer.Show()
        FormDaftarCustomer.MdiParent = Me
    End Sub

    Private Sub BuatHakAksesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuhakakses.Click
        Formhakakses.Show()
        Formhakakses.MdiParent = Me
    End Sub

    Private Sub PendaftarPegawaiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormEntryPegawai.Show()
        FormEntryPegawai.MdiParent = Me
    End Sub

    Private Sub StatusStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles StatusStrip1.ItemClicked

    End Sub

    Private Sub FormMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Strings.Mid(strMenuAkses, 1, 1) = "1" Then menuakun.Visible = True Else menuakun.Visible = False
        If Strings.Mid(strMenuAkses, 2, 1) = "1" Then menuhakakses.Visible = True Else menuhakakses.Visible = False
        If Strings.Mid(strMenuAkses, 3, 1) = "1" Then menufmaster.Visible = True Else menufmaster.Visible = False
        If Strings.Mid(strMenuAkses, 4, 1) = "1" Then menuentrycus.Visible = True Else menuentrycus.Visible = False
        If Strings.Mid(strMenuAkses, 5, 1) = "1" Then menuentrypegawai.Visible = True Else menuentrypegawai.Visible = False
        If Strings.Mid(strMenuAkses, 6, 1) = "1" Then menuentrykamar.Visible = True Else menuentrykamar.Visible = False
        If Strings.Mid(strMenuAkses, 7, 1) = "1" Then menufiletransaksi.Visible = True Else menufiletransaksi.Visible = False
        If Strings.Mid(strMenuAkses, 8, 1) = "1" Then menureservasi.Visible = True Else menureservasi.Visible = False
        If Strings.Mid(strMenuAkses, 9, 1) = "1" Then menupembayaran.Visible = True Else menupembayaran.Visible = False
        If Strings.Mid(strMenuAkses, 10, 1) = "1" Then menufileview.Visible = True Else menufileview.Visible = False
        If Strings.Mid(strMenuAkses, 11, 1) = "1" Then menureservasiview.Visible = True Else menureservasiview.Visible = False
        If Strings.Mid(strMenuAkses, 12, 1) = "1" Then menupembayaranview.Visible = True Else menupembayaranview.Visible = False
        If Strings.Mid(strMenuAkses, 13, 1) = "1" Then menufilelaporan.Visible = True Else menufilelaporan.Visible = False
        labeluser.Text = labeluser.Text & Space(1) & StrUser
    End Sub

    Private Sub menukamar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormEntryKamar.Show()
        FormEntryKamar.MdiParent = Me
    End Sub

    Private Sub menuentrypegawwai_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuentrypegawai.Click
        FormEntryPegawai.Show()
        FormEntryPegawai.MdiParent = Me
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If statusnama.Text = "Sistem Pemesanan Kamar Hotel" Then
            statusnama.Text = "By Imron"
        Else
            statusnama.Text = "Sistem Pemesanan Kamar Hotel"
        End If
    End Sub

    Private Sub Timer1_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        statusdate.Text = Format(Now, "dd MMM yyyy | HH:mm:ss")
    End Sub

    Private Sub menureservasi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menureservasi.Click
        FormReservasi.Show()
        FormReservasi.MdiParent = Me
    End Sub

    Private Sub menupembayaran_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menupembayaran.Click
        FormPembayaran.Show()
        FormPembayaran.MdiParent = Me
    End Sub

    Private Sub menureservasiview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menureservasiview.Click
        FormViewReservasi.Show()
        FormViewReservasi.MdiParent = Me
    End Sub

    Private Sub menupembayaranview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menupembayaranview.Click
        FormViewPembayaran.Show()
        FormViewPembayaran.MdiParent = Me
    End Sub

    Private Sub DataPegawaiDanDataCustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataPegawaiDanDataCustomerToolStripMenuItem.Click
        FormFIleLaporan.Show()
        FormFIleLaporan.MdiParent = Me
    End Sub
End Class