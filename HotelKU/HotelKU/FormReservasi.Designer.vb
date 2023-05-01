<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReservasi
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbcaricus = New System.Windows.Forms.ComboBox()
        Me.BtnCariCus = New System.Windows.Forms.Button()
        Me.tbcaricustomer = New System.Windows.Forms.TextBox()
        Me.DGVcus = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cblistkamar = New System.Windows.Forms.ComboBox()
        Me.btncarikamar = New System.Windows.Forms.Button()
        Me.tbcarikamar = New System.Windows.Forms.TextBox()
        Me.DGVKamar = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tbKdPem = New System.Windows.Forms.TextBox()
        Me.tbnama = New System.Windows.Forms.TextBox()
        Me.tbidcus = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.DateCIN = New System.Windows.Forms.DateTimePicker()
        Me.tbhargaphari = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.BtnSImpan = New System.Windows.Forms.Button()
        Me.BtnInput = New System.Windows.Forms.Button()
        Me.DGVreservasi = New System.Windows.Forms.DataGridView()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatecheckOut = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbjnskmr = New System.Windows.Forms.TextBox()
        Me.tbnokmr = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DGVcus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DGVKamar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DGVreservasi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("ROG Fonts", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(374, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Reservasi"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.cbcaricus)
        Me.Panel1.Controls.Add(Me.BtnCariCus)
        Me.Panel1.Controls.Add(Me.tbcaricustomer)
        Me.Panel1.Controls.Add(Me.DGVcus)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(12, 61)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(394, 218)
        Me.Panel1.TabIndex = 1
        '
        'cbcaricus
        '
        Me.cbcaricus.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.cbcaricus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbcaricus.FormattingEnabled = True
        Me.cbcaricus.Items.AddRange(New Object() {"Id Customer", "Nama"})
        Me.cbcaricus.Location = New System.Drawing.Point(193, 24)
        Me.cbcaricus.Name = "cbcaricus"
        Me.cbcaricus.Size = New System.Drawing.Size(121, 24)
        Me.cbcaricus.TabIndex = 5
        '
        'BtnCariCus
        '
        Me.BtnCariCus.Location = New System.Drawing.Point(320, 24)
        Me.BtnCariCus.Name = "BtnCariCus"
        Me.BtnCariCus.Size = New System.Drawing.Size(60, 24)
        Me.BtnCariCus.TabIndex = 3
        Me.BtnCariCus.Text = "Cari"
        Me.BtnCariCus.UseVisualStyleBackColor = True
        '
        'tbcaricustomer
        '
        Me.tbcaricustomer.Location = New System.Drawing.Point(6, 26)
        Me.tbcaricustomer.Name = "tbcaricustomer"
        Me.tbcaricustomer.Size = New System.Drawing.Size(183, 22)
        Me.tbcaricustomer.TabIndex = 2
        '
        'DGVcus
        '
        Me.DGVcus.AllowUserToAddRows = False
        Me.DGVcus.AllowUserToDeleteRows = False
        Me.DGVcus.AllowUserToResizeRows = False
        Me.DGVcus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVcus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVcus.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.DGVcus.Location = New System.Drawing.Point(6, 54)
        Me.DGVcus.Name = "DGVcus"
        Me.DGVcus.RowHeadersVisible = False
        Me.DGVcus.RowTemplate.Height = 24
        Me.DGVcus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVcus.Size = New System.Drawing.Size(380, 149)
        Me.DGVcus.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column1.DataPropertyName = "id_customer"
        Me.Column1.FillWeight = 47.71573!
        Me.Column1.Frozen = True
        Me.Column1.HeaderText = "Id Customer"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 90
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "nama"
        Me.Column2.FillWeight = 152.2843!
        Me.Column2.HeaderText = "Nama"
        Me.Column2.MinimumWidth = 150
        Me.Column2.Name = "Column2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Customer"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.cblistkamar)
        Me.Panel2.Controls.Add(Me.btncarikamar)
        Me.Panel2.Controls.Add(Me.tbcarikamar)
        Me.Panel2.Controls.Add(Me.DGVKamar)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(12, 314)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(394, 256)
        Me.Panel2.TabIndex = 4
        '
        'cblistkamar
        '
        Me.cblistkamar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cblistkamar.FormattingEnabled = True
        Me.cblistkamar.Items.AddRange(New Object() {"Standard", "VIP", "Exclusive"})
        Me.cblistkamar.Location = New System.Drawing.Point(193, 24)
        Me.cblistkamar.Name = "cblistkamar"
        Me.cblistkamar.Size = New System.Drawing.Size(121, 24)
        Me.cblistkamar.TabIndex = 4
        '
        'btncarikamar
        '
        Me.btncarikamar.Location = New System.Drawing.Point(320, 24)
        Me.btncarikamar.Name = "btncarikamar"
        Me.btncarikamar.Size = New System.Drawing.Size(60, 24)
        Me.btncarikamar.TabIndex = 3
        Me.btncarikamar.Text = "Cari"
        Me.btncarikamar.UseVisualStyleBackColor = True
        '
        'tbcarikamar
        '
        Me.tbcarikamar.Location = New System.Drawing.Point(8, 25)
        Me.tbcarikamar.Name = "tbcarikamar"
        Me.tbcarikamar.Size = New System.Drawing.Size(181, 22)
        Me.tbcarikamar.TabIndex = 2
        Me.tbcarikamar.Text = "No Kamar"
        '
        'DGVKamar
        '
        Me.DGVKamar.AllowUserToAddRows = False
        Me.DGVKamar.AllowUserToDeleteRows = False
        Me.DGVKamar.AllowUserToResizeRows = False
        Me.DGVKamar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVKamar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVKamar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.Column3})
        Me.DGVKamar.Location = New System.Drawing.Point(6, 54)
        Me.DGVKamar.Name = "DGVKamar"
        Me.DGVKamar.RowHeadersVisible = False
        Me.DGVKamar.RowTemplate.Height = 24
        Me.DGVKamar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVKamar.Size = New System.Drawing.Size(380, 188)
        Me.DGVKamar.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "no_kmr"
        Me.DataGridViewTextBoxColumn1.HeaderText = "No Kamar"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "jenis_kamar"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Jenis Kamar"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "harga"
        Me.Column3.HeaderText = "Harga"
        Me.Column3.Name = "Column3"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Kamar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Id Customer"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Nama"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.tbKdPem)
        Me.Panel3.Controls.Add(Me.tbnama)
        Me.Panel3.Controls.Add(Me.tbidcus)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(415, 61)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(556, 119)
        Me.Panel3.TabIndex = 7
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(32, 20)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(125, 17)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "Kode Pembayaran"
        '
        'tbKdPem
        '
        Me.tbKdPem.Location = New System.Drawing.Point(175, 15)
        Me.tbKdPem.Name = "tbKdPem"
        Me.tbKdPem.Size = New System.Drawing.Size(149, 22)
        Me.tbKdPem.TabIndex = 11
        '
        'tbnama
        '
        Me.tbnama.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.tbnama.Enabled = False
        Me.tbnama.Location = New System.Drawing.Point(175, 71)
        Me.tbnama.Name = "tbnama"
        Me.tbnama.Size = New System.Drawing.Size(365, 22)
        Me.tbnama.TabIndex = 10
        '
        'tbidcus
        '
        Me.tbidcus.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.tbidcus.Enabled = False
        Me.tbidcus.Location = New System.Drawing.Point(175, 43)
        Me.tbidcus.Name = "tbidcus"
        Me.tbidcus.Size = New System.Drawing.Size(149, 22)
        Me.tbidcus.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 282)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(147, 29)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Pilih Kamar"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(15, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(184, 29)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Pilih Customer"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.BtnHapus)
        Me.Panel4.Controls.Add(Me.DateCIN)
        Me.Panel4.Controls.Add(Me.tbhargaphari)
        Me.Panel4.Controls.Add(Me.Label13)
        Me.Panel4.Controls.Add(Me.BtnSImpan)
        Me.Panel4.Controls.Add(Me.BtnInput)
        Me.Panel4.Controls.Add(Me.DGVreservasi)
        Me.Panel4.Controls.Add(Me.DatecheckOut)
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.tbjnskmr)
        Me.Panel4.Controls.Add(Me.tbnokmr)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Location = New System.Drawing.Point(415, 187)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(557, 382)
        Me.Panel4.TabIndex = 21
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(367, 339)
        Me.BtnHapus.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(83, 30)
        Me.BtnHapus.TabIndex = 27
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'DateCIN
        '
        Me.DateCIN.CustomFormat = "dd MMM yyyy"
        Me.DateCIN.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateCIN.Location = New System.Drawing.Point(176, 101)
        Me.DateCIN.Name = "DateCIN"
        Me.DateCIN.Size = New System.Drawing.Size(148, 22)
        Me.DateCIN.TabIndex = 26
        '
        'tbhargaphari
        '
        Me.tbhargaphari.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.tbhargaphari.Enabled = False
        Me.tbhargaphari.Location = New System.Drawing.Point(176, 70)
        Me.tbhargaphari.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbhargaphari.Name = "tbhargaphari"
        Me.tbhargaphari.Size = New System.Drawing.Size(149, 22)
        Me.tbhargaphari.TabIndex = 25
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(35, 75)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(103, 17)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Harga Per Hari"
        '
        'BtnSImpan
        '
        Me.BtnSImpan.Location = New System.Drawing.Point(457, 339)
        Me.BtnSImpan.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSImpan.Name = "BtnSImpan"
        Me.BtnSImpan.Size = New System.Drawing.Size(83, 30)
        Me.BtnSImpan.TabIndex = 23
        Me.BtnSImpan.Text = "Simpan"
        Me.BtnSImpan.UseVisualStyleBackColor = True
        '
        'BtnInput
        '
        Me.BtnInput.Location = New System.Drawing.Point(457, 125)
        Me.BtnInput.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnInput.Name = "BtnInput"
        Me.BtnInput.Size = New System.Drawing.Size(83, 30)
        Me.BtnInput.TabIndex = 21
        Me.BtnInput.Text = "Input"
        Me.BtnInput.UseVisualStyleBackColor = True
        '
        'DGVreservasi
        '
        Me.DGVreservasi.AllowUserToAddRows = False
        Me.DGVreservasi.AllowUserToDeleteRows = False
        Me.DGVreservasi.AllowUserToResizeColumns = False
        Me.DGVreservasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVreservasi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column6, Me.Column7, Me.Column8, Me.DataGridViewTextBoxColumn3, Me.Column4, Me.Column5})
        Me.DGVreservasi.Location = New System.Drawing.Point(20, 170)
        Me.DGVreservasi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DGVreservasi.Name = "DGVreservasi"
        Me.DGVreservasi.RowHeadersVisible = False
        Me.DGVreservasi.RowTemplate.Height = 24
        Me.DGVreservasi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVreservasi.Size = New System.Drawing.Size(520, 160)
        Me.DGVreservasi.TabIndex = 20
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "kd_reservasi"
        Me.Column6.HeaderText = "Kode Reservasi"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 86
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "kd_pembayaran"
        Me.Column7.HeaderText = "Kode Pembayaran"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 86
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "id_customer"
        Me.Column8.HeaderText = "Id Customer"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 86
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "no_kmr"
        Me.DataGridViewTextBoxColumn3.HeaderText = "No Kamar"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 87
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "lama_sewa"
        Me.Column4.HeaderText = "Hari"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 86
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "subtotal"
        Me.Column5.HeaderText = "Subtotal"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 86
        '
        'DatecheckOut
        '
        Me.DatecheckOut.CustomFormat = "dd MMM yyyy"
        Me.DatecheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DatecheckOut.Location = New System.Drawing.Point(175, 133)
        Me.DatecheckOut.Margin = New System.Windows.Forms.Padding(4)
        Me.DatecheckOut.Name = "DatecheckOut"
        Me.DatecheckOut.Size = New System.Drawing.Size(149, 22)
        Me.DatecheckOut.TabIndex = 17
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(32, 133)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(130, 17)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Tanggal Check Out"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(32, 106)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(118, 17)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Tanggal Check In"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(32, 44)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 17)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Jenis Kamar"
        '
        'tbjnskmr
        '
        Me.tbjnskmr.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.tbjnskmr.Enabled = False
        Me.tbjnskmr.Location = New System.Drawing.Point(175, 39)
        Me.tbjnskmr.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbjnskmr.Name = "tbjnskmr"
        Me.tbjnskmr.Size = New System.Drawing.Size(149, 22)
        Me.tbjnskmr.TabIndex = 12
        '
        'tbnokmr
        '
        Me.tbnokmr.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.tbnokmr.Enabled = False
        Me.tbnokmr.Location = New System.Drawing.Point(175, 7)
        Me.tbnokmr.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbnokmr.Name = "tbnokmr"
        Me.tbnokmr.Size = New System.Drawing.Size(149, 22)
        Me.tbnokmr.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(32, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 17)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "No Kamar"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(783, 577)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(173, 30)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "Keluar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FormReservasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(980, 614)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormReservasi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reservasi"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DGVcus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DGVKamar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.DGVreservasi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DGVcus As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnCariCus As System.Windows.Forms.Button
    Friend WithEvents tbcaricustomer As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btncarikamar As System.Windows.Forms.Button
    Friend WithEvents tbcarikamar As System.Windows.Forms.TextBox
    Friend WithEvents DGVKamar As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents cblistkamar As System.Windows.Forms.ComboBox
    Friend WithEvents tbnama As System.Windows.Forms.TextBox
    Friend WithEvents tbidcus As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents tbKdPem As System.Windows.Forms.TextBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents tbhargaphari As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents BtnSImpan As System.Windows.Forms.Button
    Friend WithEvents BtnInput As System.Windows.Forms.Button
    Friend WithEvents DGVreservasi As System.Windows.Forms.DataGridView
    Friend WithEvents DatecheckOut As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tbjnskmr As System.Windows.Forms.TextBox
    Friend WithEvents tbnokmr As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbcaricus As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateCIN As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnHapus As System.Windows.Forms.Button
End Class
