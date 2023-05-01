<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDaftarCustomer
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
        Me.txtidcos = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtnoktp = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtnohp = New System.Windows.Forms.TextBox()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.DGVcustomer = New System.Windows.Forms.DataGridView()
        Me.optWanita = New System.Windows.Forms.RadioButton()
        Me.optPria = New System.Windows.Forms.RadioButton()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btnrefresh = New System.Windows.Forms.Button()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DGVcustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(83, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Jenis Kelamin"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tanggal Lahir"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Id Customer"
        '
        'txtidcos
        '
        Me.txtidcos.Location = New System.Drawing.Point(135, 20)
        Me.txtidcos.MaxLength = 7
        Me.txtidcos.Name = "txtidcos"
        Me.txtidcos.Size = New System.Drawing.Size(286, 22)
        Me.txtidcos.TabIndex = 20
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(135, 48)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(286, 22)
        Me.txtnama.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(66, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 17)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "No KTP"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(72, 175)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 17)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Alamat"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(86, 273)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 17)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Email"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(79, 303)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 17)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "No HP"
        '
        'txtnoktp
        '
        Me.txtnoktp.Location = New System.Drawing.Point(134, 144)
        Me.txtnoktp.MaxLength = 16
        Me.txtnoktp.Name = "txtnoktp"
        Me.txtnoktp.Size = New System.Drawing.Size(213, 22)
        Me.txtnoktp.TabIndex = 29
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(134, 270)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(286, 22)
        Me.txtemail.TabIndex = 30
        '
        'txtnohp
        '
        Me.txtnohp.Location = New System.Drawing.Point(134, 298)
        Me.txtnohp.Name = "txtnohp"
        Me.txtnohp.Size = New System.Drawing.Size(239, 22)
        Me.txtnohp.TabIndex = 31
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(134, 173)
        Me.txtAlamat.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAlamat.Size = New System.Drawing.Size(352, 90)
        Me.txtAlamat.TabIndex = 38
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(498, 542)
        Me.btnKeluar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(168, 28)
        Me.btnKeluar.TabIndex = 49
        Me.btnKeluar.Text = "&Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(576, 137)
        Me.btnBatal.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(80, 28)
        Me.btnBatal.TabIndex = 48
        Me.btnBatal.Text = "&Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(576, 101)
        Me.btnHapus.Margin = New System.Windows.Forms.Padding(4)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(80, 28)
        Me.btnHapus.TabIndex = 47
        Me.btnHapus.Text = "&Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnCari
        '
        Me.btnCari.Location = New System.Drawing.Point(576, 65)
        Me.btnCari.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(80, 28)
        Me.btnCari.TabIndex = 46
        Me.btnCari.Text = "&Cari"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(576, 26)
        Me.btnSimpan.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(80, 28)
        Me.btnSimpan.TabIndex = 45
        Me.btnSimpan.Text = "&Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'DGVcustomer
        '
        Me.DGVcustomer.AllowUserToAddRows = False
        Me.DGVcustomer.AllowUserToDeleteRows = False
        Me.DGVcustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVcustomer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.DGVcustomer.Location = New System.Drawing.Point(13, 349)
        Me.DGVcustomer.Margin = New System.Windows.Forms.Padding(4)
        Me.DGVcustomer.Name = "DGVcustomer"
        Me.DGVcustomer.RowHeadersVisible = False
        Me.DGVcustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVcustomer.Size = New System.Drawing.Size(643, 185)
        Me.DGVcustomer.TabIndex = 50
        '
        'optWanita
        '
        Me.optWanita.AutoSize = True
        Me.optWanita.Location = New System.Drawing.Point(197, 82)
        Me.optWanita.Margin = New System.Windows.Forms.Padding(4)
        Me.optWanita.Name = "optWanita"
        Me.optWanita.Size = New System.Drawing.Size(68, 21)
        Me.optWanita.TabIndex = 65
        Me.optWanita.TabStop = True
        Me.optWanita.Text = "Wanita"
        Me.optWanita.UseCompatibleTextRendering = True
        Me.optWanita.UseVisualStyleBackColor = True
        '
        'optPria
        '
        Me.optPria.AutoSize = True
        Me.optPria.Location = New System.Drawing.Point(135, 82)
        Me.optPria.Margin = New System.Windows.Forms.Padding(4)
        Me.optPria.Name = "optPria"
        Me.optPria.Size = New System.Drawing.Size(50, 21)
        Me.optPria.TabIndex = 64
        Me.optPria.TabStop = True
        Me.optPria.Text = "Pria"
        Me.optPria.UseCompatibleTextRendering = True
        Me.optPria.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(135, 110)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(193, 22)
        Me.DateTimePicker1.TabIndex = 66
        Me.DateTimePicker1.Value = New Date(2000, 1, 1, 0, 0, 0, 0)
        '
        'btnrefresh
        '
        Me.btnrefresh.Location = New System.Drawing.Point(576, 319)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnrefresh.TabIndex = 102
        Me.btnrefresh.Text = "Refresh"
        Me.btnrefresh.UseVisualStyleBackColor = True
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "id_customer"
        Me.Column1.HeaderText = "Id Customer"
        Me.Column1.MinimumWidth = 50
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 80
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "nama"
        Me.Column2.FillWeight = 50.0!
        Me.Column2.HeaderText = "Nama"
        Me.Column2.MinimumWidth = 100
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 200
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "jk"
        Me.Column3.HeaderText = "Jenis Kelamin"
        Me.Column3.MinimumWidth = 45
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
        Me.Column5.DataPropertyName = "no_ktp"
        Me.Column5.HeaderText = "No KTP"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "alamat"
        Me.Column6.HeaderText = "Alamat"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 150
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "email"
        Me.Column7.HeaderText = "Email"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "no_hp"
        Me.Column8.HeaderText = "No Hp"
        Me.Column8.Name = "Column8"
        '
        'FormDaftarCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 574)
        Me.Controls.Add(Me.btnrefresh)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.optWanita)
        Me.Controls.Add(Me.optPria)
        Me.Controls.Add(Me.DGVcustomer)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.txtAlamat)
        Me.Controls.Add(Me.txtnohp)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.txtnoktp)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.txtidcos)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormDaftarCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Entry Customer"
        CType(Me.DGVcustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtidcos As System.Windows.Forms.TextBox
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtnoktp As System.Windows.Forms.TextBox
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents txtnohp As System.Windows.Forms.TextBox
    Friend WithEvents txtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents btnKeluar As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnCari As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents DGVcustomer As System.Windows.Forms.DataGridView
    Friend WithEvents optWanita As System.Windows.Forms.RadioButton
    Friend WithEvents optPria As System.Windows.Forms.RadioButton
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnrefresh As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
