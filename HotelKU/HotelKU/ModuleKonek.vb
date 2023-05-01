Imports MySql.Data.MySqlClient
Module ModuleKonek
    Public con As MySqlConnection
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader
    Public da As MySqlDataAdapter
    Public ds As DataSet
    Public dt As DataTable
    Public strMenuAkses As String
    Public StrUser As String
    Public str As String
    Public strCari As String
    Public CodeCari As Boolean
    Public kdpem As String
    Public kdres As String
    Sub koneksi()
        Try
            Dim str As String = "Server=localhost;user id=root;password=;database=hotel"
            con = New MySqlConnection(str)
            If con.State = ConnectionState.Closed Then
                con.Open()
                'MsgBox("Database berhasil terkoneksi")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Module
