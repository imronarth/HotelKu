Imports MySql.Data.MySqlClient
Public Class FormDaftarCustomer
    Private Sub Clean()
        txtnama.Text = "" : optPria.Checked = 0 : optWanita.Checked = 0 : txtidcos.Text = "" : txtnohp.Text = "" : txtnoktp.Text = "" : txtAlamat.Text = "" : txtemail.Text = ""
        DateTimePicker1.Value = "01-01-2000"
    End Sub
    Private Sub tampilcos2()
        da = New MySqlDataAdapter("select * from customer", con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "customer")
        DGVcustomer.DataSource = (ds.Tables("customer"))
        DGVcustomer.ReadOnly = True
        DGVcustomer.AutoResizeColumns()
    End Sub

    Private Sub btnrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefresh.Click
        Call koneksi()
        cmd = New MySqlCommand("Select * from customer where id_customer in (select max(id_customer) from customer)", con)
        Dim urutan As String
        Dim hitung As Long
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            urutan = "677" + "0001"
        Else
            hitung = Microsoft.VisualBasic.Right(dr.GetString(0), 4) + 1
            urutan = "677" + Microsoft.VisualBasic.Right("0000" & hitung, 4)
        End If
        txtidcos.Text = urutan
        txtnama.Focus()
        Call koneksi()
        Call tampilcos2()
    End Sub

    Private Sub FormDaftarCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        Call tampilcos2()
    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        If MsgBox("Anda yakin ingin keluar dari form Entry customer?", vbYesNo, "Konfirmasi") = vbNo Then Exit Sub
        Me.Close()
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Call Clean()
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        Dim tgl As String
        If MsgBox("Anda yakin data sudah benar?", vbYesNo, "Konfirmasi") = vbNo Then Exit Sub
        If Len(txtidcos.Text) <> 7 Then MsgBox("Id Customer harus 7 karakter!", vbExclamation, "Perhatian") : Exit Sub
        If Len(txtnoktp.Text) <> 16 Then MsgBox("No KTP harus 16 karakter!", vbExclamation, "Perhatian") : Exit Sub
        Call koneksi()
        Try
            tgl = Format(DateTimePicker1.Value, "yyyy-MM-dd")
            cmd = New MySqlCommand("select * from customer where id_customer='" & txtidcos.Text & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = False Then 'Mode Tambah Data
                str = "insert into customer values ('" & txtidcos.Text & "','" & _
                                                          txtnama.Text & "', '" & _
                                                          IIf(optPria.Checked = True, "L", "P") & "', '" & _
                                                          tgl & "', '" & _
                                                          txtnoktp.Text & "','" & txtAlamat.Text & "','" & txtemail.Text & "','" & _
                                                          txtnohp.Text & "')"
                dr.Close()
                cmd = New MySqlCommand(str, con)
                cmd.ExecuteNonQuery()
                MsgBox("Data Customer Berhasil Disimpan", vbInformation, "Info")
                Call Clean()
            Else 'Mode Edit Data
                dr.Close()
                If MsgBox("Data sudah ada sebelumnya, anda ingin mengupdate?", vbYesNo, "Konfirmasi") = vbNo Then Exit Sub
                str = "Update customer set nama='" & _
                                          txtnama.Text & "', jk='" & _
                                          IIf(optPria.Checked = True, "L", "P") & _
                                          "', tgl_lahir='" & tgl & "', no_ktp='" & txtnoktp.Text & "', alamat='" & txtAlamat.Text & "', email='" & txtemail.Text & "', no_hp='" & _
                                          txtnohp.Text & "' Where id_customer='" & txtidcos.Text & "'"
                cmd = New MySqlCommand(str, con)
                cmd.ExecuteNonQuery()
                MsgBox("Data customer Berhasil TerUpdate", vbInformation, "Info")
                Call Clean()
            End If
        Catch ex As Exception
            MsgBox("Data customer Tidak Berhasil Disimpan", vbInformation, "Error")
        End Try
        Call tampilcos2()
    End Sub
    Private Sub Pencarian()
        If CodeCari = False Then strCari = InputBox("Masukkan Id Customer atau Nama!", "Cari Data")
        Call koneksi()
        If strCari <> "" Then
            If Val(strCari) <> 0 Or CodeCari = True Then 'Pencarian by id_customer
                cmd = New MySqlCommand("select * from customer where id_customer= '" & strCari & "'", con)
            Else 'Pencarian by Nama
                cmd = New MySqlCommand("select * from customer where nama like '%" & strCari & "%'", con)
            End If
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = False Then
                MsgBox("Data tidak ditemukan", vbInformation, "Info")
            Else 'Data ditemukan
                txtidcos.Text = dr.Item(0)
                txtnama.Text = dr.Item("nama")
                If dr.Item(2) = "L" Then optPria.Checked = True Else optWanita.Checked = True
                DateTimePicker1.Value = CDate(dr.Item("tgl_lahir"))
                txtnoktp.Text = dr.Item("no_ktp")
                txtAlamat.Text = dr.Item("alamat")
                txtemail.Text = dr.Item("email")
                txtnohp.Text = dr.Item("no_hp")
            End If
            dr.Close() : txtnama.Focus() : strCari = "" : CodeCari = False
        ElseIf DialogResult.Cancel Then
        End If
    End Sub

    Private Sub btnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCari.Click
        Call Pencarian()
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        If Len(txtidcos.Text) <> 7 Then MsgBox("Lakukan pencarian dahulu!", vbExclamation, "Perhatian") : Exit Sub
        If MsgBox("Anda yakin ingin menghapus?", vbYesNo, "Konfirmasi") = vbNo Then Exit Sub
        Call koneksi()
        str = "delete from customer where id_customer ='" & txtidcos.Text & "'"
        cmd = New MySqlCommand(str, con)
        cmd.ExecuteNonQuery()
        MsgBox("Data Customer Berhasil TerHapus", vbInformation, "Info")
        Call Clean()
        Call tampilcos2()
    End Sub
End Class