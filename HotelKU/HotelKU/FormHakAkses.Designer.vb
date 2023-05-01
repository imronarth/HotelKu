<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formhakakses
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cbReservasi = New System.Windows.Forms.CheckBox()
        Me.cbEnPeg = New System.Windows.Forms.CheckBox()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.cmdSimpan = New System.Windows.Forms.Button()
        Me.cbEntryCustom = New System.Windows.Forms.CheckBox()
        Me.cbBuatAkun = New System.Windows.Forms.CheckBox()
        Me.cbfmaster = New System.Windows.Forms.CheckBox()
        Me.cbakun = New System.Windows.Forms.CheckBox()
        Me.txtPassBuat = New System.Windows.Forms.TextBox()
        Me.txtUserBuat = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txtidpega = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbFileTransaksi = New System.Windows.Forms.CheckBox()
        Me.cbentryKamar = New System.Windows.Forms.CheckBox()
        Me.cbPembayaran = New System.Windows.Forms.CheckBox()
        Me.cbshowpwd = New System.Windows.Forms.CheckBox()
        Me.DGVHakAkses = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbFileView = New System.Windows.Forms.CheckBox()
        Me.cbViewPembayaran = New System.Windows.Forms.CheckBox()
        Me.cbviewreservasi = New System.Windows.Forms.CheckBox()
        Me.cbfilelap = New System.Windows.Forms.CheckBox()
        Me.cblapKaryawan = New System.Windows.Forms.CheckBox()
        Me.cblapCustomer = New System.Windows.Forms.CheckBox()
        CType(Me.DGVHakAkses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbReservasi
        '
        Me.cbReservasi.AutoSize = True
        Me.cbReservasi.Location = New System.Drawing.Point(348, 180)
        Me.cbReservasi.Name = "cbReservasi"
        Me.cbReservasi.Size = New System.Drawing.Size(93, 21)
        Me.cbReservasi.TabIndex = 97
        Me.cbReservasi.Text = "Reservasi"
        Me.cbReservasi.UseVisualStyleBackColor = True
        '
        'cbEnPeg
        '
        Me.cbEnPeg.AutoSize = True
        Me.cbEnPeg.Location = New System.Drawing.Point(201, 207)
        Me.cbEnPeg.Name = "cbEnPeg"
        Me.cbEnPeg.Size = New System.Drawing.Size(120, 21)
        Me.cbEnPeg.TabIndex = 96
        Me.cbEnPeg.Text = "Entry Pegawai"
        Me.cbEnPeg.UseVisualStyleBackColor = True
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(326, 533)
        Me.btnKeluar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(168, 28)
        Me.btnKeluar.TabIndex = 95
        Me.btnKeluar.Text = "&Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(405, 494)
        Me.btnBatal.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(80, 28)
        Me.btnBatal.TabIndex = 94
        Me.btnBatal.Text = "&Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(405, 458)
        Me.btnHapus.Margin = New System.Windows.Forms.Padding(4)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(80, 28)
        Me.btnHapus.TabIndex = 93
        Me.btnHapus.Text = "&Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnCari
        '
        Me.btnCari.Location = New System.Drawing.Point(405, 422)
        Me.btnCari.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(80, 28)
        Me.btnCari.TabIndex = 92
        Me.btnCari.Text = "&Cari"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'cmdSimpan
        '
        Me.cmdSimpan.Location = New System.Drawing.Point(405, 377)
        Me.cmdSimpan.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdSimpan.Name = "cmdSimpan"
        Me.cmdSimpan.Size = New System.Drawing.Size(80, 28)
        Me.cmdSimpan.TabIndex = 91
        Me.cmdSimpan.Text = "&Simpan"
        Me.cmdSimpan.UseVisualStyleBackColor = True
        '
        'cbEntryCustom
        '
        Me.cbEntryCustom.AutoSize = True
        Me.cbEntryCustom.Location = New System.Drawing.Point(201, 180)
        Me.cbEntryCustom.Name = "cbEntryCustom"
        Me.cbEntryCustom.Size = New System.Drawing.Size(127, 21)
        Me.cbEntryCustom.TabIndex = 90
        Me.cbEntryCustom.Text = "Entry Customer"
        Me.cbEntryCustom.UseVisualStyleBackColor = True
        '
        'cbBuatAkun
        '
        Me.cbBuatAkun.AutoSize = True
        Me.cbBuatAkun.Location = New System.Drawing.Point(47, 180)
        Me.cbBuatAkun.Name = "cbBuatAkun"
        Me.cbBuatAkun.Size = New System.Drawing.Size(130, 21)
        Me.cbBuatAkun.TabIndex = 89
        Me.cbBuatAkun.Text = "Buat Hak Akses"
        Me.cbBuatAkun.UseVisualStyleBackColor = True
        '
        'cbfmaster
        '
        Me.cbfmaster.AutoSize = True
        Me.cbfmaster.Location = New System.Drawing.Point(181, 153)
        Me.cbfmaster.Name = "cbfmaster"
        Me.cbfmaster.Size = New System.Drawing.Size(99, 21)
        Me.cbfmaster.TabIndex = 88
        Me.cbfmaster.Text = "File Master"
        Me.cbfmaster.UseVisualStyleBackColor = True
        '
        'cbakun
        '
        Me.cbakun.AutoSize = True
        Me.cbakun.Location = New System.Drawing.Point(28, 153)
        Me.cbakun.Name = "cbakun"
        Me.cbakun.Size = New System.Drawing.Size(62, 21)
        Me.cbakun.TabIndex = 87
        Me.cbakun.Text = "Akun"
        Me.cbakun.UseVisualStyleBackColor = True
        '
        'txtPassBuat
        '
        Me.txtPassBuat.Location = New System.Drawing.Point(117, 82)
        Me.txtPassBuat.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassBuat.Name = "txtPassBuat"
        Me.txtPassBuat.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassBuat.Size = New System.Drawing.Size(287, 22)
        Me.txtPassBuat.TabIndex = 86
        '
        'txtUserBuat
        '
        Me.txtUserBuat.Location = New System.Drawing.Point(118, 52)
        Me.txtUserBuat.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUserBuat.MaxLength = 10
        Me.txtUserBuat.Name = "txtUserBuat"
        Me.txtUserBuat.Size = New System.Drawing.Size(286, 22)
        Me.txtUserBuat.TabIndex = 85
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 87)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 17)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 57)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 17)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "Username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 29)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "Buat Akses Menu"
        '
        'Txtidpega
        '
        Me.Txtidpega.Location = New System.Drawing.Point(118, 114)
        Me.Txtidpega.Margin = New System.Windows.Forms.Padding(4)
        Me.Txtidpega.MaxLength = 7
        Me.Txtidpega.Name = "Txtidpega"
        Me.Txtidpega.Size = New System.Drawing.Size(105, 22)
        Me.Txtidpega.TabIndex = 99
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 117)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 17)
        Me.Label4.TabIndex = 98
        Me.Label4.Text = "Id Pegawai"
        '
        'cbFileTransaksi
        '
        Me.cbFileTransaksi.AutoSize = True
        Me.cbFileTransaksi.Location = New System.Drawing.Point(325, 153)
        Me.cbFileTransaksi.Name = "cbFileTransaksi"
        Me.cbFileTransaksi.Size = New System.Drawing.Size(118, 21)
        Me.cbFileTransaksi.TabIndex = 100
        Me.cbFileTransaksi.Text = "File Transaksi"
        Me.cbFileTransaksi.UseVisualStyleBackColor = True
        '
        'cbentryKamar
        '
        Me.cbentryKamar.AutoSize = True
        Me.cbentryKamar.Location = New System.Drawing.Point(201, 234)
        Me.cbentryKamar.Name = "cbentryKamar"
        Me.cbentryKamar.Size = New System.Drawing.Size(108, 21)
        Me.cbentryKamar.TabIndex = 101
        Me.cbentryKamar.Text = "Entry Kamar"
        Me.cbentryKamar.UseVisualStyleBackColor = True
        '
        'cbPembayaran
        '
        Me.cbPembayaran.AutoSize = True
        Me.cbPembayaran.Location = New System.Drawing.Point(348, 207)
        Me.cbPembayaran.Name = "cbPembayaran"
        Me.cbPembayaran.Size = New System.Drawing.Size(110, 21)
        Me.cbPembayaran.TabIndex = 103
        Me.cbPembayaran.Text = "Pembayaran"
        Me.cbPembayaran.UseVisualStyleBackColor = True
        '
        'cbshowpwd
        '
        Me.cbshowpwd.AutoSize = True
        Me.cbshowpwd.Location = New System.Drawing.Point(420, 82)
        Me.cbshowpwd.Name = "cbshowpwd"
        Me.cbshowpwd.Size = New System.Drawing.Size(64, 21)
        Me.cbshowpwd.TabIndex = 104
        Me.cbshowpwd.Text = "Show"
        Me.cbshowpwd.UseVisualStyleBackColor = True
        '
        'DGVHakAkses
        '
        Me.DGVHakAkses.AllowUserToAddRows = False
        Me.DGVHakAkses.AllowUserToDeleteRows = False
        Me.DGVHakAkses.AllowUserToResizeRows = False
        Me.DGVHakAkses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVHakAkses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVHakAkses.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.DGVHakAkses.Location = New System.Drawing.Point(29, 377)
        Me.DGVHakAkses.Name = "DGVHakAkses"
        Me.DGVHakAkses.RowHeadersVisible = False
        Me.DGVHakAkses.RowTemplate.Height = 24
        Me.DGVHakAkses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVHakAkses.Size = New System.Drawing.Size(367, 150)
        Me.DGVHakAkses.TabIndex = 105
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "id_peg"
        Me.Column1.HeaderText = "Id Pegawai"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "user"
        Me.Column2.HeaderText = "Username"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "hakakses"
        Me.Column3.HeaderText = "Hak Akses"
        Me.Column3.Name = "Column3"
        '
        'cbFileView
        '
        Me.cbFileView.AutoSize = True
        Me.cbFileView.Location = New System.Drawing.Point(28, 269)
        Me.cbFileView.Name = "cbFileView"
        Me.cbFileView.Size = New System.Drawing.Size(85, 21)
        Me.cbFileView.TabIndex = 106
        Me.cbFileView.Text = "File View"
        Me.cbFileView.UseVisualStyleBackColor = True
        '
        'cbViewPembayaran
        '
        Me.cbViewPembayaran.AutoSize = True
        Me.cbViewPembayaran.Location = New System.Drawing.Point(47, 323)
        Me.cbViewPembayaran.Name = "cbViewPembayaran"
        Me.cbViewPembayaran.Size = New System.Drawing.Size(143, 21)
        Me.cbViewPembayaran.TabIndex = 107
        Me.cbViewPembayaran.Text = "View Pembayaran"
        Me.cbViewPembayaran.UseVisualStyleBackColor = True
        '
        'cbviewreservasi
        '
        Me.cbviewreservasi.AutoSize = True
        Me.cbviewreservasi.Location = New System.Drawing.Point(47, 296)
        Me.cbviewreservasi.Name = "cbviewreservasi"
        Me.cbviewreservasi.Size = New System.Drawing.Size(126, 21)
        Me.cbviewreservasi.TabIndex = 108
        Me.cbviewreservasi.Text = "View Reservasi"
        Me.cbviewreservasi.UseVisualStyleBackColor = True
        '
        'cbfilelap
        '
        Me.cbfilelap.AutoSize = True
        Me.cbfilelap.Location = New System.Drawing.Point(243, 269)
        Me.cbfilelap.Name = "cbfilelap"
        Me.cbfilelap.Size = New System.Drawing.Size(109, 21)
        Me.cbfilelap.TabIndex = 109
        Me.cbfilelap.Text = "File Laporan"
        Me.cbfilelap.UseVisualStyleBackColor = True
        '
        'cblapKaryawan
        '
        Me.cblapKaryawan.AutoSize = True
        Me.cblapKaryawan.Location = New System.Drawing.Point(263, 296)
        Me.cblapKaryawan.Name = "cblapKaryawan"
        Me.cblapKaryawan.Size = New System.Drawing.Size(126, 21)
        Me.cblapKaryawan.TabIndex = 110
        Me.cblapKaryawan.Text = "Data Karyawan"
        Me.cblapKaryawan.UseVisualStyleBackColor = True
        '
        'cblapCustomer
        '
        Me.cblapCustomer.AutoSize = True
        Me.cblapCustomer.Location = New System.Drawing.Point(263, 323)
        Me.cblapCustomer.Name = "cblapCustomer"
        Me.cblapCustomer.Size = New System.Drawing.Size(124, 21)
        Me.cblapCustomer.TabIndex = 111
        Me.cblapCustomer.Text = "Data Customer"
        Me.cblapCustomer.UseVisualStyleBackColor = True
        '
        'Formhakakses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 580)
        Me.Controls.Add(Me.cblapCustomer)
        Me.Controls.Add(Me.cblapKaryawan)
        Me.Controls.Add(Me.cbfilelap)
        Me.Controls.Add(Me.cbviewreservasi)
        Me.Controls.Add(Me.cbViewPembayaran)
        Me.Controls.Add(Me.cbFileView)
        Me.Controls.Add(Me.DGVHakAkses)
        Me.Controls.Add(Me.cbshowpwd)
        Me.Controls.Add(Me.cbPembayaran)
        Me.Controls.Add(Me.cbentryKamar)
        Me.Controls.Add(Me.cbFileTransaksi)
        Me.Controls.Add(Me.Txtidpega)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbReservasi)
        Me.Controls.Add(Me.cbEnPeg)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.cmdSimpan)
        Me.Controls.Add(Me.cbEntryCustom)
        Me.Controls.Add(Me.cbBuatAkun)
        Me.Controls.Add(Me.cbfmaster)
        Me.Controls.Add(Me.cbakun)
        Me.Controls.Add(Me.txtPassBuat)
        Me.Controls.Add(Me.txtUserBuat)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Formhakakses"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrasi Hak Akses"
        CType(Me.DGVHakAkses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbReservasi As System.Windows.Forms.CheckBox
    Friend WithEvents cbEnPeg As System.Windows.Forms.CheckBox
    Friend WithEvents btnKeluar As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnCari As System.Windows.Forms.Button
    Friend WithEvents cmdSimpan As System.Windows.Forms.Button
    Friend WithEvents cbEntryCustom As System.Windows.Forms.CheckBox
    Friend WithEvents cbBuatAkun As System.Windows.Forms.CheckBox
    Friend WithEvents cbfmaster As System.Windows.Forms.CheckBox
    Friend WithEvents cbakun As System.Windows.Forms.CheckBox
    Friend WithEvents txtPassBuat As System.Windows.Forms.TextBox
    Friend WithEvents txtUserBuat As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txtidpega As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbFileTransaksi As System.Windows.Forms.CheckBox
    Friend WithEvents cbentryKamar As System.Windows.Forms.CheckBox
    Friend WithEvents cbPembayaran As System.Windows.Forms.CheckBox
    Friend WithEvents cbshowpwd As System.Windows.Forms.CheckBox
    Friend WithEvents DGVHakAkses As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cbFileView As System.Windows.Forms.CheckBox
    Friend WithEvents cbViewPembayaran As System.Windows.Forms.CheckBox
    Friend WithEvents cbviewreservasi As System.Windows.Forms.CheckBox
    Friend WithEvents cbfilelap As System.Windows.Forms.CheckBox
    Friend WithEvents cblapKaryawan As System.Windows.Forms.CheckBox
    Friend WithEvents cblapCustomer As System.Windows.Forms.CheckBox
End Class
