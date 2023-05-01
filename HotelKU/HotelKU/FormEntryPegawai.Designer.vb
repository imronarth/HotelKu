<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEntryPegawai
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtidpeg = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.txtnohp = New System.Windows.Forms.TextBox()
        Me.txtjabatan = New System.Windows.Forms.TextBox()
        Me.optWanita = New System.Windows.Forms.RadioButton()
        Me.optPria = New System.Windows.Forms.RadioButton()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DGVPegawai = New System.Windows.Forms.DataGridView()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.cmdSimpan = New System.Windows.Forms.Button()
        Me.btnrefresh = New System.Windows.Forms.Button()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DGVPegawai, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id Pegawai"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jenis Kelamin"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tanggal Lahir"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Jabatan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(33, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "No Hp"
        '
        'txtidpeg
        '
        Me.txtidpeg.Location = New System.Drawing.Point(162, 20)
        Me.txtidpeg.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidpeg.MaxLength = 7
        Me.txtidpeg.Name = "txtidpeg"
        Me.txtidpeg.Size = New System.Drawing.Size(108, 22)
        Me.txtidpeg.TabIndex = 58
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(162, 53)
        Me.txtnama.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(347, 22)
        Me.txtnama.TabIndex = 59
        '
        'txtnohp
        '
        Me.txtnohp.Location = New System.Drawing.Point(162, 139)
        Me.txtnohp.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnohp.MaxLength = 20
        Me.txtnohp.Name = "txtnohp"
        Me.txtnohp.Size = New System.Drawing.Size(193, 22)
        Me.txtnohp.TabIndex = 60
        '
        'txtjabatan
        '
        Me.txtjabatan.Location = New System.Drawing.Point(162, 171)
        Me.txtjabatan.Margin = New System.Windows.Forms.Padding(4)
        Me.txtjabatan.Name = "txtjabatan"
        Me.txtjabatan.Size = New System.Drawing.Size(347, 22)
        Me.txtjabatan.TabIndex = 61
        '
        'optWanita
        '
        Me.optWanita.AutoSize = True
        Me.optWanita.Location = New System.Drawing.Point(224, 85)
        Me.optWanita.Margin = New System.Windows.Forms.Padding(4)
        Me.optWanita.Name = "optWanita"
        Me.optWanita.Size = New System.Drawing.Size(68, 21)
        Me.optWanita.TabIndex = 63
        Me.optWanita.TabStop = True
        Me.optWanita.Text = "Wanita"
        Me.optWanita.UseCompatibleTextRendering = True
        Me.optWanita.UseVisualStyleBackColor = True
        '
        'optPria
        '
        Me.optPria.AutoSize = True
        Me.optPria.Location = New System.Drawing.Point(162, 85)
        Me.optPria.Margin = New System.Windows.Forms.Padding(4)
        Me.optPria.Name = "optPria"
        Me.optPria.Size = New System.Drawing.Size(50, 21)
        Me.optPria.TabIndex = 62
        Me.optPria.TabStop = True
        Me.optPria.Text = "Pria"
        Me.optPria.UseCompatibleTextRendering = True
        Me.optPria.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(162, 110)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(193, 22)
        Me.DateTimePicker1.TabIndex = 64
        Me.DateTimePicker1.Value = New Date(2000, 1, 1, 0, 0, 0, 0)
        '
        'DGVPegawai
        '
        Me.DGVPegawai.AllowUserToAddRows = False
        Me.DGVPegawai.AllowUserToDeleteRows = False
        Me.DGVPegawai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPegawai.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.DGVPegawai.Location = New System.Drawing.Point(35, 322)
        Me.DGVPegawai.Name = "DGVPegawai"
        Me.DGVPegawai.RowHeadersVisible = False
        Me.DGVPegawai.RowTemplate.Height = 24
        Me.DGVPegawai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVPegawai.Size = New System.Drawing.Size(605, 150)
        Me.DGVPegawai.TabIndex = 65
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(472, 483)
        Me.btnKeluar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(185, 28)
        Me.btnKeluar.TabIndex = 100
        Me.btnKeluar.Text = "&Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(578, 128)
        Me.btnBatal.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(80, 28)
        Me.btnBatal.TabIndex = 99
        Me.btnBatal.Text = "&Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(578, 92)
        Me.btnHapus.Margin = New System.Windows.Forms.Padding(4)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(80, 28)
        Me.btnHapus.TabIndex = 98
        Me.btnHapus.Text = "&Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnCari
        '
        Me.btnCari.Location = New System.Drawing.Point(578, 56)
        Me.btnCari.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(80, 28)
        Me.btnCari.TabIndex = 97
        Me.btnCari.Text = "&Cari"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'cmdSimpan
        '
        Me.cmdSimpan.Location = New System.Drawing.Point(578, 14)
        Me.cmdSimpan.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdSimpan.Name = "cmdSimpan"
        Me.cmdSimpan.Size = New System.Drawing.Size(80, 28)
        Me.cmdSimpan.TabIndex = 96
        Me.cmdSimpan.Text = "&Simpan"
        Me.cmdSimpan.UseVisualStyleBackColor = True
        '
        'btnrefresh
        '
        Me.btnrefresh.Location = New System.Drawing.Point(565, 293)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnrefresh.TabIndex = 101
        Me.btnrefresh.Text = "Refresh"
        Me.btnrefresh.UseVisualStyleBackColor = True
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(162, 201)
        Me.txtAlamat.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAlamat.Size = New System.Drawing.Size(352, 90)
        Me.txtAlamat.TabIndex = 102
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(33, 204)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 17)
        Me.Label7.TabIndex = 103
        Me.Label7.Text = "Alamat"
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "id_peg"
        Me.Column1.HeaderText = "Id Pegawai"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "nama"
        Me.Column2.HeaderText = "Nama"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "jk"
        Me.Column3.HeaderText = "Jenis Kelamin"
        Me.Column3.MinimumWidth = 50
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 60
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "tgl_lahir"
        Me.Column4.HeaderText = "Tanggal Lahir"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "no_hp"
        Me.Column5.HeaderText = "No HP"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "alamat"
        Me.Column6.HeaderText = "Alamat"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "jabatan"
        Me.Column7.HeaderText = "Jabatan"
        Me.Column7.Name = "Column7"
        '
        'FormEntryPegawai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 529)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtAlamat)
        Me.Controls.Add(Me.btnrefresh)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.cmdSimpan)
        Me.Controls.Add(Me.DGVPegawai)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.optWanita)
        Me.Controls.Add(Me.optPria)
        Me.Controls.Add(Me.txtjabatan)
        Me.Controls.Add(Me.txtnohp)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.txtidpeg)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormEntryPegawai"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Entry Pegawai"
        CType(Me.DGVPegawai, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtidpeg As System.Windows.Forms.TextBox
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents txtnohp As System.Windows.Forms.TextBox
    Friend WithEvents txtjabatan As System.Windows.Forms.TextBox
    Friend WithEvents optWanita As System.Windows.Forms.RadioButton
    Friend WithEvents optPria As System.Windows.Forms.RadioButton
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DGVPegawai As System.Windows.Forms.DataGridView
    Friend WithEvents btnKeluar As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnCari As System.Windows.Forms.Button
    Friend WithEvents cmdSimpan As System.Windows.Forms.Button
    Friend WithEvents btnrefresh As System.Windows.Forms.Button
    Friend WithEvents txtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
