Imports MySql.Data.MySqlClient
Public Class FormEntryKamar
    Private Sub Pencarian()
        strCari = InputBox("Masukkan Id Kamar", "Cari Data")
        If strCari <> "" Then
            Call koneksi()
            cmd = New MySqlCommand("select * from kamar where no_kmr like '%" & strCari & "%'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then
                txtnokamar.Text = dr.Item(0)
                cbjnskamar.Text = dr.Item("jenis_kamar")
                txtharga.Text = CStr(dr.Item("harga"))
            Else 'Data ditemukan
                MsgBox("Data tidak ditemukan", vbInformation, "Info")
            End If
            dr.Close() : txtnokamar.Focus() : strCari = ""
        ElseIf DialogResult.Cancel Then
        End If
    End Sub
    Private Sub Cls()
        txtharga.Text = "" : txtnokamar.Text = "" : cbjnskamar.SelectedIndex = -1
    End Sub
    Private Sub Tampil()
        da = New MySqlDataAdapter("select * from kamar", con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "kamar")
        DGVKamar.DataSource = (ds.Tables("kamar"))
        DGVKamar.ReadOnly = True
        DGVKamar.AutoResizeColumns()
        DGVKamar.Sort(DGVKamar.Columns(2), System.ComponentModel.ListSortDirection.Ascending)
    End Sub
    Private Sub DelData()
        If Len(txtnokamar.Text) <> 6 Then MsgBox("Lakukan pencarian dahulu!", vbExclamation, "Perhatian") : Exit Sub
        If MsgBox("Anda yakin ingin menghapus?", vbYesNo, "Konfirmasi") = vbNo Then Exit Sub
        Call koneksi()
        str = "delete from kamar where no_kmr = '" & txtnokamar.Text & "'"
        cmd = New MySqlCommand(str, con)
        cmd.ExecuteNonQuery()
        MsgBox("Data Kamar Berhasil TerHapus", vbInformation, "Info")
        Call Cls()
    End Sub

    Private Sub FormEntryKamar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        Call Tampil()
    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        If MsgBox("Anda yakin ingin keluar dari form Entry Kamar?", vbYesNo, "Konfirmasi") = vbNo Then Exit Sub
        Me.Close()
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Call Cls()
    End Sub

    Private Sub cmdSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSimpan.Click
        If MsgBox("Anda yakin data sudah benar?", vbYesNo, "Konfirmasi") = vbNo Then Exit Sub
        If Len(txtnokamar.Text) <> 6 Then MsgBox("No Kamar harus 5 karakter!", vbExclamation, "Perhatian") : Exit Sub
        Call koneksi()
        Try
            cmd = New MySqlCommand("select * from kamar where no_kmr='" & txtnokamar.Text & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = False Then 'Mode Tambah Data
                str = "insert into kamar values ('" & txtnokamar.Text & "','" & _
                                                          cbjnskamar.Text & "', '" & _
                                                          txtharga.Text & "','Belum Terisi')"
                dr.Close()
                cmd = New MySqlCommand(str, con)
                cmd.ExecuteNonQuery()
                MsgBox("Data Kamar Berhasil Disimpan", vbInformation, "Info")
                Call Cls()
            Else 'Mode Edit Data
                dr.Close()
                If MsgBox("Data sudah ada sebelumnya, anda ingin mengupdate?", vbYesNo, "Konfirmasi") = vbNo Then Exit Sub
                str = "Update kamar set jenis_kamar='" & _
                                          cbjnskamar.Text & _
                                          "', harga='" & txtharga.Text & "' Where no_kmr='" & txtnokamar.Text & "'"
                cmd = New MySqlCommand(str, con)
                cmd.ExecuteNonQuery()
                MsgBox("Data Kamar Berhasil TerUpdate", vbInformation, "Info")
                Call Cls()
            End If
        Catch ex As Exception
            MsgBox("Data Kamar Tidak Berhasil Disimpan", vbInformation, "Error")
        End Try
        Call Tampil()
    End Sub

    Private Sub cbjnskamar_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbjnskamar.SelectedIndexChanged
        Call koneksi()
        Dim urutan As String
        Dim hitung As Long
        If cbjnskamar.SelectedIndex = 0 And cbauto.Checked = True Then
            cmd = New MySqlCommand("Select * from kamarstd where no_kmr in (select max(no_kmr) from kamarstd)", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If Not dr.HasRows Then
                urutan = "STD" + "001"
                txtharga.Focus()
            Else
                hitung = Microsoft.VisualBasic.Right(dr.GetString(0), 3) + 1
                urutan = "STD" + Microsoft.VisualBasic.Right("0000" & hitung, 3)
                txtharga.Text = dr.Item("harga")
            End If
            txtnokamar.Text = urutan
        ElseIf cbjnskamar.SelectedIndex = 1 And cbauto.Checked = True Then
            cmd = New MySqlCommand("Select * from kamarvip where no_kmr in (select max(no_kmr) from kamarvip)", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If Not dr.HasRows Then
                urutan = "VIP" + "001"
                txtharga.Focus()
            Else
                hitung = Microsoft.VisualBasic.Right(dr.GetString(0), 3) + 1
                urutan = "VIP" + Microsoft.VisualBasic.Right("0000" & hitung, 3)
                txtharga.Text = dr.Item("harga")
            End If
            txtnokamar.Text = urutan
        ElseIf cbjnskamar.SelectedIndex = 2 And cbauto.Checked = True Then
            cmd = New MySqlCommand("Select * from kamarexc where no_kmr in (select max(no_kmr) from kamarexc)", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If Not dr.HasRows Then
                urutan = "EXC" + "001"
                txtharga.Focus()
            Else
                hitung = Microsoft.VisualBasic.Right(dr.GetString(0), 3) + 1
                urutan = "EXC" + Microsoft.VisualBasic.Right("0000" & hitung, 3)
                txtharga.Text = dr.Item("harga")
            End If
            txtnokamar.Text = urutan
        End If
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        Call DelData()
        Call Cls()
        Call Tampil()
    End Sub

    Private Sub btnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCari.Click
        If cbauto.Checked = True Then
            MsgBox("Matikan Fitur Auto Terlebih Dahulu!", vbInformation, "Perhatian")
        Else
            Call Pencarian()
        End If
    End Sub
End Class