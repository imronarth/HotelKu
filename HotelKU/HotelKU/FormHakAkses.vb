Imports MySql.Data.MySqlClient
Public Class Formhakakses
    Dim strKodeAkses As String
    Private Sub CentangHakAkses()
        If cbakun.Checked = True Then strKodeAkses = 1 Else strKodeAkses = 0
        If cbBuatAkun.Checked = True Then strKodeAkses = strKodeAkses & 1 Else strKodeAkses = strKodeAkses & 0
        If cbfmaster.Checked = True Then strKodeAkses = strKodeAkses & 1 Else strKodeAkses = strKodeAkses & 0
        If cbEntryCustom.Checked = True Then strKodeAkses = strKodeAkses & 1 Else strKodeAkses = strKodeAkses & 0
        If cbEnPeg.Checked = True Then strKodeAkses = strKodeAkses & 1 Else strKodeAkses = strKodeAkses & 0
        If cbentryKamar.Checked = True Then strKodeAkses = strKodeAkses & 1 Else strKodeAkses = strKodeAkses & 0
        If cbFileTransaksi.Checked = True Then strKodeAkses = strKodeAkses & 1 Else strKodeAkses = strKodeAkses & 0
        If cbReservasi.Checked = True Then strKodeAkses = strKodeAkses & 1 Else strKodeAkses = strKodeAkses & 0
        If cbPembayaran.Checked = True Then strKodeAkses = strKodeAkses & 1 Else strKodeAkses = strKodeAkses & 0
        If cbFileView.Checked = True Then strKodeAkses = strKodeAkses & 1 Else strKodeAkses = strKodeAkses & 0
        If cbviewreservasi.Checked = True Then strKodeAkses = strKodeAkses & 1 Else strKodeAkses = strKodeAkses & 0
        If cbViewPembayaran.Checked = True Then strKodeAkses = strKodeAkses & 1 Else strKodeAkses = strKodeAkses & 0
        If cbfilelap.Checked = True Then strKodeAkses = strKodeAkses & 1 Else strKodeAkses = strKodeAkses & 0
        If cblapKaryawan.Checked = True Then strKodeAkses = strKodeAkses & 1 Else strKodeAkses = strKodeAkses & 0
        If cblapCustomer.Checked = True Then strKodeAkses = strKodeAkses & 1 Else strKodeAkses = strKodeAkses & 0
    End Sub

    Private Sub Pencarian()
        If CodeCari = False Then strCari = InputBox("Masukkan User Name atau ID Pegawai!", "Cari Data")
        Call koneksi()
        If strCari <> "" Then
            If Val(strCari) <> 0 Or CodeCari = True Then 'Pencarian by id pegawai
                cmd = New MySqlCommand("select * from login where id_peg = '" & strCari & "'", con)
            Else 'Pencarian by Nama
                cmd = New MySqlCommand("select * from login where user like '%" & strCari & "%'", con)
            End If
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = False Then
                MsgBox("Data tidak ditemukan", vbInformation, "Info")
            Else 'Data ditemukan
                txtUserBuat.Text = dr.Item(0)
                Txtidpega.Text = dr.Item("id_peg")
                txtPassBuat.Text = dr.Item("pass")
                If Strings.Left(dr.Item("hakakses"), 1) = "1" Then cbakun.Checked = True Else cbakun.Checked = False
                If Strings.Mid(dr.Item("hakakses"), 2, 1) = "1" Then cbBuatAkun.Checked = True Else cbBuatAkun.Checked = False
                If Strings.Mid(dr.Item("hakakses"), 3, 1) = "1" Then cbfmaster.Checked = True Else cbfmaster.Checked = False
                If Strings.Mid(dr.Item("hakakses"), 4, 1) = "1" Then cbEntryCustom.Checked = True Else cbEntryCustom.Checked = False
                If Strings.Mid(dr.Item("hakakses"), 5, 1) = "1" Then cbEnPeg.Checked = True Else cbEnPeg.Checked = False
                If Strings.Mid(dr.Item("hakakses"), 6, 1) = "1" Then cbentryKamar.Checked = True Else cbentryKamar.Checked = False
                If Strings.Mid(dr.Item("hakakses"), 7, 1) = "1" Then cbFileTransaksi.Checked = True Else cbFileTransaksi.Checked = False
                If Strings.Mid(dr.Item("hakakses"), 8, 1) = "1" Then cbReservasi.Checked = True Else cbReservasi.Checked = False
                If Strings.Mid(dr.Item("hakakses"), 9, 1) = "1" Then cbPembayaran.Checked = True Else cbPembayaran.Checked = False
                If Strings.Mid(dr.Item("hakakses"), 10, 1) = "1" Then cbFileView.Checked = True Else cbFileView.Checked = False
                If Strings.Mid(dr.Item("hakakses"), 11, 1) = "1" Then cbviewreservasi.Checked = True Else cbviewreservasi.Checked = False
                If Strings.Mid(dr.Item("hakakses"), 12, 1) = "1" Then cbViewPembayaran.Checked = True Else cbViewPembayaran.Checked = False
                If Strings.Mid(dr.Item("hakakses"), 13, 1) = "1" Then cbfilelap.Checked = True Else cbfilelap.Checked = False
                If Strings.Mid(dr.Item("hakakses"), 14, 1) = "1" Then cblapKaryawan.Checked = True Else cblapKaryawan.Checked = False
                If Strings.Mid(dr.Item("hakakses"), 15, 1) = "1" Then cblapCustomer.Checked = True Else cblapCustomer.Checked = False
            End If
        ElseIf DialogResult.Cancel Then
        End If
        dr.Close() : txtUserBuat.Focus() ': strCari = "" : CodeCari = False
    End Sub
    Private Sub Bersih()
        txtUserBuat.Clear() : txtPassBuat.Clear() : Txtidpega.Clear()
        cbakun.Checked = False
        cbBuatAkun.Checked = False
        cbfmaster.Checked = False
        cbEntryCustom.Checked = False
        cbEnPeg.Checked = False
        cbentryKamar.Checked = False
        cbFileTransaksi.Checked = False
        cbReservasi.Checked = False
        cbPembayaran.Checked = False
        cbFileView.Checked = False
        cbviewreservasi.Checked = False
        cbViewPembayaran.Checked = False
        cbfilelap.Checked = False
        cblapCustomer.Checked = False
        cblapKaryawan.Checked = False
        txtUserBuat.Focus()
    End Sub
    Private Sub tampil()
        da = New MySqlDataAdapter("select id_peg,user,hakakses from login", con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "login")
        DGVHakAkses.DataSource = (ds.Tables("login"))
        DGVHakAkses.ReadOnly = True
        DGVHakAkses.AutoResizeColumns()
        DGVHakAkses.Sort(DGVHakAkses.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
    End Sub

    Private Sub btnKeluar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        If MsgBox("Anda yakin ingin keluar dari form Hak Akses?", vbYesNo, "Konfirmasi") = vbNo Then Exit Sub
        Me.Close()
    End Sub

    Private Sub btnBatal_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Call Bersih()
    End Sub

    Private Sub btnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCari.Click
        Call Pencarian()
    End Sub

    Private Sub cmdSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSimpan.Click
        If MsgBox("Anda yakin data sudah benar?", vbYesNo, "Konfirmasi") = vbNo Then Exit Sub
        If Len(Txtidpega.Text) <> 7 Then MsgBox("Id Pegawai harus 7 karakter!", vbExclamation, "Perhatian") : Exit Sub
        Call koneksi()
        Try
            Dim str As String
            cmd = New MySqlCommand("select * from login where user='" & txtUserBuat.Text & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            Call CentangHakAkses()
            If dr.HasRows = False Then 'Mode Tambah Data
                str = "insert into login values ('" & txtUserBuat.Text & "','" & _
                                                         txtPassBuat.Text & "','" & strKodeAkses & "','" & Txtidpega.Text & "')"
                dr.Close()
                cmd = New MySqlCommand(str, con)
                cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil Disimpan", vbInformation, "Info")
                Call Bersih()
            Else 'Mode Edit Data
                dr.Close()
                If MsgBox("Data sudah ada sebelumnya, anda ingin mengupdate?", vbYesNo, "Konfirmasi") = vbNo Then Exit Sub
                str = "Update login set password='" & txtPassBuat.Text & _
                                    "', hakakses='" & strKodeAkses & "' Where user='" & txtUserBuat.Text & "'"
                cmd = New MySqlCommand(str, con)
                cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil TerUpdate", vbInformation, "Info")
                Call Bersih()
            End If
        Catch ex As Exception
            MsgBox("Buat Akun Pegawai di Entry Pegawai terlebih dahulu", vbInformation, "Error")
        End Try
        Call tampil()
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        If txtUserBuat.Text = "" Or Txtidpega.Text = "" Then MsgBox("Lakukan pencarian dahulu!", vbExclamation, "Warning") : Exit Sub
        If MsgBox("Anda yakin ingin menghapus?", vbYesNo, "Konfirmasi") = vbNo Then Exit Sub
        Call koneksi()
        str = "delete from login where User ='" & txtUserBuat.Text & "' AND id_peg='" & Txtidpega.Text & "'"
        cmd = New MySqlCommand(str, con)
        cmd.ExecuteNonQuery()
        MsgBox("Data Hak Akses Berhasil TerHapus", vbInformation, "Info")
        Call Bersih()
        Call tampil()
    End Sub

    Private Sub cbshowpwd_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbshowpwd.CheckedChanged
        If cbshowpwd.Checked = True Then
            txtPassBuat.PasswordChar = ""
        Else
            txtPassBuat.PasswordChar = "*"
        End If
    End Sub

    Private Sub Formhakakses_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        Call tampil()
    End Sub
End Class