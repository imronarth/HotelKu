Imports MySql.Data.MySqlClient
Public Class FormReservasi
    Private Sub tampilresev()
        da = New MySqlDataAdapter("select kd_reservasi,kd_pembayaran,id_customer,no_kmr,lama_sewa,subtotal from reservasi where kd_pembayaran ='" & tbKdPem.Text & "'", con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "reservasi")
        DGVreservasi.DataSource = (ds.Tables("reservasi"))
        DGVreservasi.ReadOnly = True
        DGVreservasi.AutoResizeColumns()
    End Sub
    Private Sub clearkamar()
        tbnokmr.Clear()
        tbjnskmr.Clear()
        tbhargaphari.Clear()
        DateCIN.Value = Today
        DatecheckOut.Value = Today
    End Sub
    Private Sub TampilCustomer()
        da = New MySqlDataAdapter("select id_customer,nama from customer", con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "customer")
        DGVcus.DataSource = (ds.Tables("customer"))
        DGVcus.ReadOnly = True
    End Sub

    Private Sub TampilKamar()
        da = New MySqlDataAdapter("select * from avalkamar", con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "avalkamar")
        DGVKamar.DataSource = (ds.Tables("avalkamar"))
        DGVKamar.ReadOnly = True
        DGVKamar.Sort(DGVKamar.Columns(2), System.ComponentModel.ListSortDirection.Ascending)
    End Sub

    Private Sub FormReservasi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        Call TampilCustomer()
        Call TampilKamar()
        DateCIN.Value = Date.Today
    End Sub

    Private Sub DGVcus_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGVcus.DoubleClick
        Call koneksi()
        If DGVreservasi.RowCount = 0 Then
            cmd = New MySqlCommand("Select * from pembayaran where kd_pembayaran in (select max(kd_pembayaran) from pembayaran)", con)
            Dim urutan As String
            Dim hitung As Long
            dr = cmd.ExecuteReader
            dr.Read()
            If Not dr.HasRows Then
                urutan = "PEM" + "0001"
            Else
                hitung = Microsoft.VisualBasic.Right(dr.GetString(0), 4) + 1
                urutan = "PEM" + Microsoft.VisualBasic.Right("0000" & hitung, 4)
            End If
            dr.Close()
            tbKdPem.Text = urutan
            tbidcus.Text = DGVcus.CurrentRow.Cells(0).Value.ToString
            tbnama.Text = DGVcus.CurrentRow.Cells(1).Value.ToString
        Else
            MsgBox("Simpan Terlebih Dahulu Data Sebelumnya!", vbInformation, "Perhatian")
        End If
    End Sub

    Private Sub BtnCariCus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCariCus.Click
        If tbcaricustomer.Text = "" Or cbcaricus.SelectedIndex = -1 Then
            str = "select id_customer,nama from customer"
        ElseIf cbcaricus.SelectedIndex = 0 Then
            str = "select id_customer,nama from customer where id_customer like '%" & tbcaricustomer.Text & "%'"
        ElseIf cbcaricus.SelectedIndex = 1 Then
            str = "select id_customer,nama from customer where nama like '%" & tbcaricustomer.Text & "%'"
        End If
        Call koneksi()
        da = New MySqlDataAdapter(str, con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "customer")
        DGVcus.DataSource = (ds.Tables("customer"))
        DGVcus.ReadOnly = True
    End Sub

    Private Sub tbcarikamar_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbcarikamar.Enter
        tbcarikamar.Clear()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncarikamar.Click
        If ((cblistkamar.Text = "" And tbcarikamar.Text = "No Kamar") Or (cblistkamar.Text = "" And tbcarikamar.Text = "")) Then
            str = "select * from avalkamar"
        ElseIf cblistkamar.SelectedIndex = 0 Then
            If tbcarikamar.Text = "" Or tbcarikamar.Text = "No Kamar" Then
                str = "select * from avalkamar where no_kmr like 'STD%'"
            Else
                str = "select * from avalkamar where no_kmr like 'STD%' and no_kmr like '%" & tbcarikamar.Text & "%'"
            End If
        ElseIf cblistkamar.SelectedIndex = 1 Then
            If tbcarikamar.Text = "" Or tbcarikamar.Text = "No Kamar" Then
                str = "select * from avalkamar where no_kmr like 'VIP%'"
            Else
                str = "select * from avalkamar where no_kmr like 'VIP%' and no_kmr like '%" & tbcarikamar.Text & "%'"
            End If
        ElseIf cblistkamar.SelectedIndex = 2 Then
            If tbcarikamar.Text = "" Or tbcarikamar.Text = "No Kamar" Then
                str = "select * from avalkamar where no_kmr like 'EXC%'"
            Else
                str = "select * from avalkamar where no_kmr like 'EXC%' and no_kmr like '%" & tbcarikamar.Text & "%'"
            End If
        End If
        da = New MySqlDataAdapter(str, con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "avalkamar")
        DGVKamar.DataSource = (ds.Tables("avalkamar"))
        DGVKamar.ReadOnly = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If MsgBox("Anda yakin ingin keluar dari Form Reservasi?", vbYesNo, "Konfirmasi") = vbNo Then Exit Sub
        Me.Close()
    End Sub

    Private Sub DGVKamar_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGVKamar.DoubleClick
        tbnokmr.Text = DGVKamar.CurrentRow.Cells(0).Value.ToString
        tbjnskmr.Text = DGVKamar.CurrentRow.Cells(1).Value.ToString
        tbhargaphari.Text = DGVKamar.CurrentRow.Cells(2).Value.ToString
    End Sub

    Private Sub BtnInput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInput.Click
        Call koneksi()
        Dim jmlhari As Integer = (DatecheckOut.Value - DateCIN.Value).TotalDays
        Dim tglcheckin As String = Format(DateCIN.Value, "yyyy-MM-dd")
        Dim tglcheckout As String = Format(DatecheckOut.Value, "yyyy-MM-dd")
        Dim subtotalz As Long = Val(tbhargaphari.Text) * jmlhari
        Dim datein As Date = DateCIN.Value
        Dim dateout As Date = DatecheckOut.Value
        Dim comparedate As Integer = DateDiff("d", datein, dateout)
        If tbidcus.Text = "" Or tbKdPem.Text = "" Then
            MsgBox("Pilih Customer Terlebih Dahulu!", vbInformation, "Perhatian")
        ElseIf tbnokmr.Text = "" Then
            MsgBox("Pilih Kamar Terlebih Dahulu", vbInformation, "Perhatian")
        ElseIf DateCIN.Value < Today Then
            MsgBox("Tanggal Check In Kadaluaarsa, Pilih Tanggal Check In Lain", vbInformation, "Perhatian")
        ElseIf comparedate <= 0 Then
            MsgBox("Pilih Tanggal Check Out diatas Check In", vbInformation, "Perhatian")
        Else
            Try
                cmd = New MySqlCommand("select * from pembayaran where kd_pembayaran='" & tbKdPem.Text & "'", con)
                dr = cmd.ExecuteReader
                dr.Read()
                If Not dr.HasRows Then
                    str = "insert into pembayaran (kd_pembayaran,id_customer,total_harga,status) value ('" & tbKdPem.Text & "','" & tbidcus.Text & "','" & subtotalz & "','Belum Lunas')"
                    dr.Close()
                    cmd = New MySqlCommand(str, con)
                    cmd.ExecuteNonQuery()
                Else
                    Dim hargasementara As Long = dr.Item("total_harga")
                    Dim subtotalakhir As Long = hargasementara + subtotalz
                    str = "Update pembayaran set total_harga ='" & subtotalakhir & "' where kd_pembayaran ='" & tbKdPem.Text & "'"
                    dr.Close()
                    cmd = New MySqlCommand(str, con)
                    cmd.ExecuteNonQuery()
                End If
                cmd = New MySqlCommand("Select * from reservasi where kd_reservasi in (select max(kd_reservasi) from reservasi)", con)
                Dim urutan2 As String
                Dim hitung2 As Long
                dr = cmd.ExecuteReader
                dr.Read()
                If Not dr.HasRows Then
                    urutan2 = "RES" + "0001"
                Else
                    hitung2 = Microsoft.VisualBasic.Right(dr.GetString(0), 4) + 1
                    urutan2 = "RES" + Microsoft.VisualBasic.Right("0000" & hitung2, 4)
                End If
                str = "insert into reservasi values ('" & urutan2 & "','" & _
                                                              tbKdPem.Text & "', '" & _
                                                              tbidcus.Text & "', '" & _
                                                              tbnokmr.Text & "', '" & _
                                                              tglcheckin & " 12:00:00','" & tglcheckout & " 12:00:00','" & jmlhari & "','" & _
                                                              subtotalz & "')"
                dr.Close()
                cmd = New MySqlCommand(str, con)
                cmd.ExecuteNonQuery()
                MsgBox("Data Reservasi Berhasil Disimpan", vbInformation, "Info")
                Call clearkamar()
                Call tampilresev()
            Catch ex As Exception
                MsgBox("Data Reservasi Tidak Berhasil Diinput", vbInformation, "Error")
            End Try
        End If
    End Sub
    Private Sub clearakun()
        tbKdPem.Clear()
        tbidcus.Clear()
        tbnama.Clear()
    End Sub

    Private Sub BtnSImpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSImpan.Click
        Call clearkamar()
        Call clearakun()
        Call tampilresev()
    End Sub

    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        Try
            kdres = DGVreservasi.CurrentRow.Cells(0).Value.ToString
            kdpem = DGVreservasi.CurrentRow.Cells(1).Value.ToString
            If MsgBox("Anda yakin ingin menghapus reservasi " & kdres & " ?", vbYesNo, "Konfirmasi") = vbNo Then Exit Sub
            Call koneksi()
            str = "delete from reservasi where kd_reservasi ='" & kdres & "'"
            cmd = New MySqlCommand(str, con)
            cmd.ExecuteNonQuery()
            cmd = New MySqlCommand("select * from reservasi where kd_pembayaran='" & kdpem & "'", con)
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
        Catch ex As Exception
            MsgBox("Pilih Data Reservasi Terlebih Dahulu!", vbInformation, "Error")
        End Try
        kdres = ""
        kdpem = ""
        Call tampilresev()
    End Sub
End Class