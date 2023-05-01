Imports MySql.Data.MySqlClient
Public Class FormViewReservasi
    Dim statuspem As String
    Private Sub tampil()
        da = New MySqlDataAdapter("select * from reservasi", con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "reservasi")
        DGVViewReservasi.DataSource = (ds.Tables("reservasi"))
        DGVViewReservasi.ReadOnly = True
        DGVViewReservasi.AutoResizeColumns()
    End Sub

    Private Sub FormViewReservasi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        Call tampil()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If MsgBox("Anda yakin ingin keluar dari View Reservasi?", vbYesNo, "Konfirmasi") = vbNo Then Exit Sub
        Me.Close()
    End Sub

    Private Sub cboField_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboField.SelectedIndexChanged
        If cboField.SelectedIndex = 4 Or cboField.SelectedIndex = 5 Then
            cboKriteria.Items.Clear()
            cboKriteria.Items.Add("Like")
        ElseIf cboField.SelectedIndex = 6 Or cboField.SelectedIndex = 7 Then
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

    Private Sub BtnCariRes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCariRes.Click
        If txtCari.Text = "" Or cboField.SelectedIndex = -1 Or cboKriteria.SelectedIndex = -1 Then
            str = "select * from reservasi"
        ElseIf cboField.SelectedIndex = 0 Then
            If cboKriteria.SelectedIndex = 0 Then
                str = "select * from reservasi where kd_reservasi like '%" & txtCari.Text & "%'"
            Else
                str = "select * from reservasi where kd_reservasi " & cboKriteria.Text & "'" & txtCari.Text & "'"
            End If
        ElseIf cboField.SelectedIndex = 1 Then
            If cboKriteria.SelectedIndex = 0 Then
                str = "select * from reservasi where kd_pembayaran like '%" & txtCari.Text & "%'"
            Else
                str = "select * from reservasi where kd_pembayaran " & cboKriteria.Text & "'" & txtCari.Text & "'"
            End If
        ElseIf cboField.SelectedIndex = 2 Then
            If cboKriteria.SelectedIndex = 0 Then
                str = "select * from reservasi where id_customer like '%" & txtCari.Text & "%'"
            Else
                str = "select * from reservasi where id_customer " & cboKriteria.Text & "'" & txtCari.Text & "'"
            End If
        ElseIf cboField.SelectedIndex = 3 Then
            If cboKriteria.SelectedIndex = 0 Then
                str = "select * from reservasi where no_kmr like '%" & txtCari.Text & "%'"
            Else
                str = "select * from reservasi where no_kmr " & cboKriteria.Text & "'" & txtCari.Text & "'"
            End If
        ElseIf cboField.SelectedIndex = 4 Then
            str = "select * from reservasi where checkin like '%" & txtCari.Text & "%"
        ElseIf cboField.SelectedIndex = 5 Then
            str = "select * from reservasi where checkout like '%" & txtCari.Text & "%"
        ElseIf cboField.SelectedIndex = 6 Then
            If cboKriteria.SelectedIndex = 0 Then
                str = "select * from reservasi where lama_sewa like '%" & txtCari.Text & "%'"
            Else
                str = "select * from reservasi where lama_sewa " & cboKriteria.Text & "'" & txtCari.Text & "'"
            End If
        ElseIf cboField.SelectedIndex = 7 Then
            If cboKriteria.SelectedIndex = 0 Then
                str = "select * from reservasi where subtotal like '%" & txtCari.Text & "%'"
            Else
                str = "select * from reservasi where subtotal " & cboKriteria.Text & "'" & txtCari.Text & "'"
            End If
        End If
        Call koneksi()
        da = New MySqlDataAdapter(str, con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "reservasi")
        DGVViewReservasi.DataSource = (ds.Tables("reservasi"))
        DGVViewReservasi.ReadOnly = True
    End Sub

    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        kdres = DGVViewReservasi.CurrentRow.Cells(0).Value.ToString
        kdpem = DGVViewReservasi.CurrentRow.Cells(1).Value.ToString
        Try
            Call koneksi()
            str = "select * from pembayaran where kd_pembayaran='" & kdpem & "'"
            cmd = New MySqlCommand(str, con)
            dr = cmd.ExecuteReader
            dr.Read()
            statuspem = dr.Item("status")
            dr.Close()
            If statuspem = "Lunas" Then
                MsgBox("Data Reservasi Tidak Bisa Dihapus Karena Sudah Lunas", vbInformation, "Perhatian")
            Else
                If MsgBox("Menghapus Reservasi dapat " & vbCrLf & "Mengubah Total Pembayaran/Menghilangkan Pembayaran!" & vbCrLf & "Anda yakin ingin menghapus Data Reservasi " & kdres & " ?", vbYesNo, "Konfirmasi") = vbNo Then Exit Sub
                str = "delete from reservasi where kd_reservasi ='" & kdres & "'"
                cmd = New MySqlCommand(str, con)
                cmd.ExecuteNonQuery()
                str = "select kd_reservasi,kd_pembayaran from reservasi where kd_pembayaran ='" & kdpem & "'"
                cmd = New MySqlCommand(str, con)
                dr = cmd.ExecuteReader
                dr.Read()
                If Not dr.HasRows Then
                    str = "delete from pembayaran where kd_pembayaran ='" & kdpem & "'"
                    dr.Close()
                    cmd = New MySqlCommand(str, con)
                    cmd.ExecuteNonQuery()
                Else
                    dr.Close()
                End If
                MsgBox("Data Reservasi " & kdres & " Berhasil TerHapus", vbInformation, "Info")
            End If
        Catch ex As Exception
            MsgBox("Pilih Data Reservasi Terlebih Dahulu!", vbInformation, "Error")
        End Try
        kdres = ""
        kdpem = ""
        Call tampil()
    End Sub
End Class