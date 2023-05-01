<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPembayaran
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbcaripem = New System.Windows.Forms.ComboBox()
        Me.tbcaripem = New System.Windows.Forms.TextBox()
        Me.BtnCariPem = New System.Windows.Forms.Button()
        Me.DGVupdpem = New System.Windows.Forms.DataGridView()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tbkdpem = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdSimpan = New System.Windows.Forms.Button()
        Me.CbStatusPem = New System.Windows.Forms.ComboBox()
        Me.cbJnsPem = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DTPPembayaran = New System.Windows.Forms.DateTimePicker()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DGVupdpem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.cbcaripem)
        Me.Panel1.Controls.Add(Me.tbcaripem)
        Me.Panel1.Controls.Add(Me.BtnCariPem)
        Me.Panel1.Controls.Add(Me.DGVupdpem)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(12, 59)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(735, 265)
        Me.Panel1.TabIndex = 0
        '
        'cbcaripem
        '
        Me.cbcaripem.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.cbcaripem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbcaripem.FormattingEnabled = True
        Me.cbcaripem.Items.AddRange(New Object() {"Kode Pembayaran", "Id Customer", "Nama"})
        Me.cbcaripem.Location = New System.Drawing.Point(427, 23)
        Me.cbcaripem.Name = "cbcaripem"
        Me.cbcaripem.Size = New System.Drawing.Size(226, 24)
        Me.cbcaripem.TabIndex = 6
        '
        'tbcaripem
        '
        Me.tbcaripem.Location = New System.Drawing.Point(15, 25)
        Me.tbcaripem.Name = "tbcaripem"
        Me.tbcaripem.Size = New System.Drawing.Size(406, 22)
        Me.tbcaripem.TabIndex = 5
        '
        'BtnCariPem
        '
        Me.BtnCariPem.Location = New System.Drawing.Point(659, 23)
        Me.BtnCariPem.Name = "BtnCariPem"
        Me.BtnCariPem.Size = New System.Drawing.Size(60, 24)
        Me.BtnCariPem.TabIndex = 4
        Me.BtnCariPem.Text = "Cari"
        Me.BtnCariPem.UseVisualStyleBackColor = True
        '
        'DGVupdpem
        '
        Me.DGVupdpem.AllowUserToAddRows = False
        Me.DGVupdpem.AllowUserToDeleteRows = False
        Me.DGVupdpem.AllowUserToResizeRows = False
        Me.DGVupdpem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVupdpem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVupdpem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.Column1, Me.Column2, Me.Column4, Me.Column5})
        Me.DGVupdpem.Location = New System.Drawing.Point(15, 53)
        Me.DGVupdpem.Name = "DGVupdpem"
        Me.DGVupdpem.RowHeadersVisible = False
        Me.DGVupdpem.RowTemplate.Height = 24
        Me.DGVupdpem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVupdpem.Size = New System.Drawing.Size(704, 200)
        Me.DGVupdpem.TabIndex = 3
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "kd_pembayaran"
        Me.Column3.HeaderText = "Kode Pembayaran"
        Me.Column3.Name = "Column3"
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column1.DataPropertyName = "id_customer"
        Me.Column1.FillWeight = 47.71573!
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
        'Column4
        '
        Me.Column4.DataPropertyName = "total_harga"
        Me.Column4.HeaderText = "Total Harga"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "status"
        Me.Column5.HeaderText = "Status"
        Me.Column5.Name = "Column5"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Pembayaran"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("ROG Fonts", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(258, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(276, 36)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pembayaran"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(13, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(217, 29)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Pilih Pembayaran"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.tbkdpem)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.cmdSimpan)
        Me.Panel2.Controls.Add(Me.CbStatusPem)
        Me.Panel2.Controls.Add(Me.cbJnsPem)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.DTPPembayaran)
        Me.Panel2.Location = New System.Drawing.Point(12, 330)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(735, 165)
        Me.Panel2.TabIndex = 3
        '
        'tbkdpem
        '
        Me.tbkdpem.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.tbkdpem.Enabled = False
        Me.tbkdpem.Location = New System.Drawing.Point(191, 32)
        Me.tbkdpem.Name = "tbkdpem"
        Me.tbkdpem.Size = New System.Drawing.Size(141, 22)
        Me.tbkdpem.TabIndex = 100
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 17)
        Me.Label6.TabIndex = 99
        Me.Label6.Text = "Kode Pembayaran"
        '
        'cmdSimpan
        '
        Me.cmdSimpan.Location = New System.Drawing.Point(649, 131)
        Me.cmdSimpan.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdSimpan.Name = "cmdSimpan"
        Me.cmdSimpan.Size = New System.Drawing.Size(80, 28)
        Me.cmdSimpan.TabIndex = 98
        Me.cmdSimpan.Text = "&Simpan"
        Me.cmdSimpan.UseVisualStyleBackColor = True
        '
        'CbStatusPem
        '
        Me.CbStatusPem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.CbStatusPem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbStatusPem.FormattingEnabled = True
        Me.CbStatusPem.Items.AddRange(New Object() {"Lunas", "Tertunda"})
        Me.CbStatusPem.Location = New System.Drawing.Point(191, 118)
        Me.CbStatusPem.Name = "CbStatusPem"
        Me.CbStatusPem.Size = New System.Drawing.Size(141, 24)
        Me.CbStatusPem.TabIndex = 18
        '
        'cbJnsPem
        '
        Me.cbJnsPem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.cbJnsPem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbJnsPem.FormattingEnabled = True
        Me.cbJnsPem.Items.AddRange(New Object() {"Tunai", "Kredit"})
        Me.cbJnsPem.Location = New System.Drawing.Point(191, 88)
        Me.cbJnsPem.Name = "cbJnsPem"
        Me.cbJnsPem.Size = New System.Drawing.Size(141, 24)
        Me.cbJnsPem.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(155, 17)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Update Pembayaran"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 17)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Jenis Pembayaran"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 17)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Status"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 65)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(144, 17)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Tanggal Pembayaran"
        '
        'DTPPembayaran
        '
        Me.DTPPembayaran.CustomFormat = "dd MMM yyyy"
        Me.DTPPembayaran.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPPembayaran.Location = New System.Drawing.Point(191, 60)
        Me.DTPPembayaran.Name = "DTPPembayaran"
        Me.DTPPembayaran.Size = New System.Drawing.Size(141, 22)
        Me.DTPPembayaran.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(574, 502)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(173, 30)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "Keluar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FormPembayaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(759, 536)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormPembayaran"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Pembayaran"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DGVupdpem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents DGVupdpem As System.Windows.Forms.DataGridView
    Friend WithEvents DTPPembayaran As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents CbStatusPem As System.Windows.Forms.ComboBox
    Friend WithEvents cbJnsPem As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmdSimpan As System.Windows.Forms.Button
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbkdpem As System.Windows.Forms.TextBox
    Friend WithEvents BtnCariPem As System.Windows.Forms.Button
    Friend WithEvents tbcaripem As System.Windows.Forms.TextBox
    Friend WithEvents cbcaripem As System.Windows.Forms.ComboBox
End Class
