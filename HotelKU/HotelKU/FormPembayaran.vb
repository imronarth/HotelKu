Imports MySql.Data.MySqlClient
Public Class FormPembayaran
    Private Sub tampil()
        da = New MySqlDataAdapter("select * from upd_pembayaran", con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "upd_pembayaran")
        DGVupdpem.DataSource = (ds.Tables("upd_pembayaran"))
        DGVupdpem.ReadOnly = True
        DGVupdpem.AutoResizeColumns()
    End Sub
    Private Sub cleartulisan()
        tbkdpem.Clear()
        CbStatusPem.SelectedIndex = -1
        cbJnsPem.SelectedIndex = -1
        DTPPembayaran.Value = Today
    End Sub

    Private Sub FormPembayaran_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        Call tampil()
        DTPPembayaran.Value = Today
    End Sub

    Private Sub cmdSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSimpan.Click
        Dim datepembayaran As String = Format(DTPPembayaran.Value, "yyyy-MM-dd")
        If Len(tbkdpem.Text) = 0 Then
            MsgBox("Pilih Pembayaran Terlebih Dahulu!", vbInformation, "Perhatian")
        ElseIf CbStatusPem.SelectedIndex = -1 Or cbJnsPem.SelectedIndex = -1 Then
            MsgBox("Isi Data Dengan Lengkap!", vbInformation, "Perhatian")
        ElseIf DTPPembayaran.Value < Today Then
            MsgBox("Tanggal Pembayaran Kadauluarsa, Pilih Tanggal Lain!", vbInformation, "Perhatian")
        Else
            Call koneksi()
            str = "Update pembayaran set tgl_bayar = '" & datepembayaran & "', jenis_bayar ='" & cbJnsPem.Text & "', status ='" & CbStatusPem.Text & "' where kd_pembayaran ='" & tbkdpem.Text & "'"
            cmd = New MySqlCommand(str, con)
            cmd.ExecuteNonQuery()
            Call tampil()
            MsgBox("Data Pembayaran Berhasil TerUpdate", vbInformation, "Info")
            Call cleartulisan()
        End If
    End Sub

    Private Sub DGVupdpem_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGVupdpem.DoubleClick
        tbkdpem.Text = DGVupdpem.CurrentRow.Cells(0).Value.ToString
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If MsgBox("Anda yakin ingin keluar dari Form Pembayaran?", vbYesNo, "Konfirmasi") = vbNo Then Exit Sub
        Me.Close()
    End Sub

    Private Sub BtnCariCus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCariPem.Click
        If tbcaripem.Text = "" Or cbcaripem.SelectedIndex = -1 Then
            str = "select * from upd_pembayaran"
        ElseIf cbcaripem.SelectedIndex = 0 Then
            str = "select * from upd_pembayaran where kd_pembayaran like '%" & tbcaripem.Text & "%'"
        ElseIf cbcaripem.SelectedIndex = 1 Then
            str = "select * from upd_pembayaran where id_customer like '%" & tbcaripem.Text & "%'"
        ElseIf cbcaripem.SelectedIndex = 2 Then
            str = "select * from upd_pembayaran where nama like '%" & tbcaripem.Text & "%'"
        End If
        Call koneksi()
        da = New MySqlDataAdapter(str, con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "upd_pembayaran")
        DGVupdpem.DataSource = (ds.Tables("upd_pembayaran"))
        DGVupdpem.ReadOnly = True
    End Sub
End Class