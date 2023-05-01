Imports MySql.Data.MySqlClient
Public Class FormEntryPegawai
    Dim tgl As String
    Private Sub Clean()
        txtidpeg.Text = "" : optPria.Checked = 0 : optWanita.Checked = 0 : txtnama.Text = "" : txtnohp.Text = "" : txtjabatan.Text = ""
        txtAlamat.Clear()
        DateTimePicker1.Value = "01-01-2000"
    End Sub
    Private Sub cmdSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSimpan.Click
        If MsgBox("Anda yakin data sudah benar?", vbYesNo, "Konfirmasi") = vbNo Then Exit Sub
        If Len(txtidpeg.Text) <> 7 Then MsgBox("Id Pegawai harus 7 karakter!", vbExclamation, "Perhatian") : Exit Sub
        Call koneksi()
        Try
            tgl = Format(DateTimePicker1.Value, "yyyy-MM-dd")
            cmd = New MySqlCommand("select * from pegawai where id_peg='" & txtidpeg.Text & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = False Then 'Mode Tambah Data
                str = "insert into pegawai values ('" & txtidpeg.Text & "','" & _
                                                          txtnama.Text & "', '" & _
                                                          IIf(optPria.Checked = True, "L", "P") & "', '" & _
                                                          tgl & "', '" & _
                                                          txtnohp.Text & "','" & _
                                                          txtjabatan.Text & "','" & _
                                                          txtAlamat.Text & "')"
                dr.Close()
                cmd = New MySqlCommand(str, con)
                cmd.ExecuteNonQuery()
                MsgBox("Data Pegawai Berhasil Disimpan", vbInformation, "Info")
                Call Clean()
            Else 'Mode Edit Data
                dr.Close()
                If MsgBox("Data sudah ada sebelumnya, anda ingin mengupdate?", vbYesNo, "Konfirmasi") = vbNo Then Exit Sub
                str = "Update pegawai set nama='" & _
                                          txtnama.Text & "', jk='" & _
                                          IIf(optPria.Checked = True, "L", "P") & _
                                          "', tgl_lahir='" & tgl & "', no_hp='" & txtnohp.Text & "', alamat='" & txtAlamat.Text & "', jabatan='" & _
                                          txtjabatan.Text & "' Where id_peg='" & txtidpeg.Text & "'"
                cmd = New MySqlCommand(str, con)
                cmd.ExecuteNonQuery()
                MsgBox("Data Pegawai Berhasil TerUpdate", vbInformation, "Info")
                Call Clean()
            End If
        Catch ex As Exception
            MsgBox("Data Pegawai Tidak Berhasil Disimpan", vbInformation, "Error")
        End Try
        Call Tampil()
    End Sub
    Private Sub Cari()
        If CodeCari = False Then strCari = InputBox("Masukkan Id Pegawai atau Nama!", "Cari Data")
        Call koneksi()
        If strCari <> "" Then
            If Val(strCari) <> 0 Or CodeCari = True Then 'Pencarian by id pegawai
                cmd = New MySqlCommand("select * from pegawai where id_peg = '" & strCari & "'", con)
            Else 'Pencarian by Nama
                cmd = New MySqlCommand("select * from pegawai where nama like '%" & strCari & "%'", con)
            End If
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = False Then
                MsgBox("Data tidak ditemukan", vbInformation, "Info")
            Else 'Data ditemukan
                txtidpeg.Text = dr.Item(0)
                txtnama.Text = dr.Item("nama")
                If dr.Item(2) = "L" Then optPria.Checked = True Else optWanita.Checked = True
                DateTimePicker1.Value = CDate(dr.Item("tgl_lahir"))
                txtnohp.Text = dr.Item("no_hp")
                txtjabatan.Text = dr.Item("jabatan")
                txtAlamat.Text = dr.Item("alamat")
            End If
            dr.Close() : txtnama.Focus() : strCari = "" : CodeCari = False
        ElseIf DialogResult.Cancel Then
        End If
    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        If MsgBox("Anda yakin ingin keluar dari form Entry Pegawai?", vbYesNo, "Konfirmasi") = vbNo Then Exit Sub
        Me.Close()
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Call Clean()
    End Sub

    Private Sub btnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCari.Click
        Call Cari()
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        If Len(txtidpeg.Text) <> 7 Then MsgBox("Lakukan pencarian dahulu!", vbExclamation, "Perhatian") : Exit Sub
        If MsgBox("Anda yakin ingin menghapus?", vbYesNo, "Konfirmasi") = vbNo Then Exit Sub
        Call koneksi()
        str = "delete from pegawai where id_peg ='" & txtidpeg.Text & "'"
        cmd = New MySqlCommand(str, con)
        cmd.ExecuteNonQuery()
        MsgBox("Data Pegawai Berhasil TerHapus", vbInformation, "Info")
        Call Clean()
        Call Tampil()
    End Sub

    Private Sub Tampil()
        da = New MySqlDataAdapter("select * from pegawai", con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "pegawai")
        DGVPegawai.DataSource = (ds.Tables("pegawai"))
        DGVPegawai.ReadOnly = True
        DGVPegawai.AutoResizeColumns()
    End Sub

    Private Sub FormPendPegawai_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        Call Tampil()
    End Sub

    Private Sub btnrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefresh.Click
        Call koneksi()
        cmd = New MySqlCommand("Select * from pegawai where id_peg in (select max(id_peg) from pegawai)", con)
        Dim urutan As String
        Dim hitung As Long
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            urutan = "945" + "0001"
        Else
            hitung = Microsoft.VisualBasic.Right(dr.GetString(0), 4) + 1
            urutan = "945" + Microsoft.VisualBasic.Right("0000" & hitung, 4)
        End If
        txtidpeg.Text = urutan
        txtnama.Focus()
        Call koneksi()
        Call Tampil()
    End Sub
End Class