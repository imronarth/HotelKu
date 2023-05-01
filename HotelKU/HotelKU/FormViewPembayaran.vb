Imports MySql.Data.MySqlClient
Public Class FormViewPembayaran
    Private Sub tampil()
        da = New MySqlDataAdapter("select * from pembayaran", con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "pembayaran")
        DGVViewReservasi.DataSource = (ds.Tables("pembayaran"))
        DGVViewReservasi.ReadOnly = True
        DGVViewReservasi.AutoResizeColumns()
    End Sub

    Private Sub FormViewPembayaran_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        Call tampil()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If MsgBox("Anda yakin ingin keluar dari View Pembayaran?", vbYesNo, "Konfirmasi") = vbNo Then Exit Sub
        Me.Close()
    End Sub

    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        kdpem = DGVViewReservasi.CurrentRow.Cells(0).Value.ToString
        Dim statusstring As String = DGVViewReservasi.CurrentRow.Cells(5).Value.ToString
        Try
            If statusstring <> "Lunas" Then
                If MsgBox("Penghapusan Pembayaran Mengakibatkan Data" & vbCrLf & "Pada Reservasi Terhapus!" & vbCrLf & "Anda yakin ingin menghapus Data Pembayaran " & kdpem & "?", vbYesNo, "Konfirmasi") = vbNo Then Exit Sub
                Call koneksi()
                str = "delete from pembayaran where kd_pembayaran ='" & kdpem & "'"
                cmd = New MySqlCommand(str, con)
                cmd.ExecuteNonQuery()
                MsgBox("Data Pembayaran " & kdpem & " Berhasil TerHapus", vbInformation, "Info")
            Else
                MsgBox("Data Pembayaran Tidak Bisa Dihapus Karena Sudah Lunas", vbInformation, "Perhatian")
            End If
        Catch ex As Exception
            MsgBox("Pilih Data Pembayaran Terlebih Dahulu!", vbInformation, "Error")
        End Try
    End Sub

    Private Sub cboField_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboField.SelectedIndexChanged
        If cboField.SelectedIndex = 3 Then
            cboKriteria.Items.Clear()
            cboKriteria.Items.Add("Like")
            cboKriteria.Items.Add("=")
            cboKriteria.Items.Add(">")
            cboKriteria.Items.Add("<")
            cboKriteria.Items.Add(">=")
            cboKriteria.Items.Add("<=")
            cboKriteria.Items.Add("<>")
        Else
            cboKriteria.Items.Clear()
            cboKriteria.Items.Add("Like")
            cboKriteria.Items.Add("=")
        End If
    End Sub

    Private Sub BtnCariCus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCariCus.Click
        If txtCari.Text = "" Or cboField.SelectedIndex = -1 Or cboKriteria.SelectedIndex = -1 Then
            str = "select * from pembayaran"
        ElseIf cboField.SelectedIndex = 0 Then
            If cboKriteria.SelectedIndex = 0 Then
                str = "select * from pembayaran where kd_pembayaran like '%" & txtCari.Text & "%'"
            Else
                str = "select * from pembayaran where kd_pembayaran " & cboKriteria.Text & "'" & txtCari.Text & "'"
            End If
        ElseIf cboField.SelectedIndex = 1 Then
            If cboKriteria.SelectedIndex = 0 Then
                str = "select * from pembayaran where id_customer like '%" & txtCari.Text & "%'"
            Else
                str = "select * from pembayaran where id_customer " & cboKriteria.Text & "'" & txtCari.Text & "'"
            End If
        ElseIf cboField.SelectedIndex = 2 Then
            If cboKriteria.SelectedIndex = 0 Then
                str = "select * from pembayaran where tgl_bayar like '%" & txtCari.Text & "%'"
            Else
                str = "select * from pembayaran where tgl_bayar " & cboKriteria.Text & "'" & txtCari.Text & "'"
            End If
        ElseIf cboField.SelectedIndex = 3 Then
            If cboKriteria.SelectedIndex = 0 Then
                str = "select * from pembayaran where total_harga like '%" & txtCari.Text & "%'"
            Else
                str = "select * from pembayaran where total_harga " & cboKriteria.Text & "'" & txtCari.Text & "'"
            End If
        ElseIf cboField.SelectedIndex = 4 Then
            If cboKriteria.SelectedIndex = 0 Then
                str = "select * from pembayaran where jenis_bayar like '%" & txtCari.Text & "%'"
            Else
                str = "select * from pembayaran where jenis_bayar " & cboKriteria.Text & "'" & txtCari.Text & "'"
            End If
        ElseIf cboField.SelectedIndex = 5 Then
            If cboKriteria.SelectedIndex = 0 Then
                str = "select * from pembayaran where status like '%" & txtCari.Text & "%'"
            Else
                str = "select * from pembayaran where status " & cboKriteria.Text & "'" & txtCari.Text & "'"
            End If
        End If
        Call koneksi()
        da = New MySqlDataAdapter(str, con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "pembayaran")
        DGVViewReservasi.DataSource = (ds.Tables("pembayaran"))
        DGVViewReservasi.ReadOnly = True
    End Sub
End Class