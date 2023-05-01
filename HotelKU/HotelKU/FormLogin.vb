Imports MySql.Data.MySqlClient
Public Class FormLogin
    Private Sub clruserpass()
        tbpass.Text = "" : tbuser.Text = ""
    End Sub

    Private Sub Login()
        Call koneksi()
        cmd = New MySqlCommand("select * from login where user='" & tbuser.Text & _
                               "' and pass='" & tbpass.Text & "'", con)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = False Then
            MsgBox("Username dan Password Salah", vbInformation, "Info")
            dr.Close()
        Else 'Data ditemukan
            StrUser = dr.Item("user")
            strMenuAkses = dr.Item("hakakses")
            tbuser.Text = "" : tbpass.Text = ""
            FormMenu.Show()
            Me.Hide()
            dr.Close()
        End If
    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        If MsgBox("Anda yakin ingin keluar dari Aplikasi Pemsanan Hotel? ", vbYesNo, "Konfirmasi") = vbNo Then Exit Sub
        Me.Close()
    End Sub

    Private Sub BtnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLogin.Click
        Call Login()
    End Sub

    Private Sub BtnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDel.Click
        Call clruserpass()
    End Sub

    Private Sub tbuser_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbuser.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            Call Login()
        End If
    End Sub

    Private Sub tbuser_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbuser.TextChanged

    End Sub

    Private Sub tbpass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbpass.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            Call Login()
        End If
    End Sub

    Private Sub cbshowpwd_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbshowpwd.CheckedChanged
        If cbshowpwd.Checked = True Then
            tbpass.PasswordChar = ""
        Else
            tbpass.PasswordChar = "*"
        End If
    End Sub
End Class
