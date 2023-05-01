<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormViewReservasi
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnCariRes = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboKriteria = New System.Windows.Forms.ComboBox()
        Me.DGVViewReservasi = New System.Windows.Forms.DataGridView()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cboField = New System.Windows.Forms.ComboBox()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DGVViewReservasi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("ROG Fonts", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(238, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(333, 36)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "View Reservasi"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BtnHapus)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.BtnCariRes)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.cboKriteria)
        Me.Panel1.Controls.Add(Me.DGVViewReservasi)
        Me.Panel1.Controls.Add(Me.cboField)
        Me.Panel1.Controls.Add(Me.txtCari)
        Me.Panel1.Location = New System.Drawing.Point(1, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(830, 415)
        Me.Panel1.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(544, 11)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 17)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Kriteria Cari"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(356, 11)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 17)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Field yang dicari"
        '
        'BtnCariRes
        '
        Me.BtnCariRes.Location = New System.Drawing.Point(680, 14)
        Me.BtnCariRes.Name = "BtnCariRes"
        Me.BtnCariRes.Size = New System.Drawing.Size(132, 42)
        Me.BtnCariRes.TabIndex = 7
        Me.BtnCariRes.Text = "Cari"
        Me.BtnCariRes.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 14)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(194, 17)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Ketikan kata yang akan dicari"
        '
        'cboKriteria
        '
        Me.cboKriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKriteria.FormattingEnabled = True
        Me.cboKriteria.Location = New System.Drawing.Point(548, 31)
        Me.cboKriteria.Margin = New System.Windows.Forms.Padding(4)
        Me.cboKriteria.Name = "cboKriteria"
        Me.cboKriteria.Size = New System.Drawing.Size(125, 24)
        Me.cboKriteria.TabIndex = 48
        '
        'DGVViewReservasi
        '
        Me.DGVViewReservasi.AllowUserToAddRows = False
        Me.DGVViewReservasi.AllowUserToDeleteRows = False
        Me.DGVViewReservasi.AllowUserToResizeRows = False
        Me.DGVViewReservasi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVViewReservasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVViewReservasi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.Column3, Me.Column1, Me.Column8, Me.Column2, Me.Column4, Me.Column6, Me.Column5})
        Me.DGVViewReservasi.Location = New System.Drawing.Point(5, 62)
        Me.DGVViewReservasi.Name = "DGVViewReservasi"
        Me.DGVViewReservasi.RowHeadersVisible = False
        Me.DGVViewReservasi.RowTemplate.Height = 24
        Me.DGVViewReservasi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVViewReservasi.Size = New System.Drawing.Size(817, 310)
        Me.DGVViewReservasi.TabIndex = 4
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "kd_reservasi"
        Me.Column7.HeaderText = "Kode Reservasi"
        Me.Column7.Name = "Column7"
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
        'Column8
        '
        Me.Column8.DataPropertyName = "no_kmr"
        Me.Column8.HeaderText = "No Kamar"
        Me.Column8.Name = "Column8"
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "checkin"
        Me.Column2.HeaderText = "Check In"
        Me.Column2.Name = "Column2"
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "checkout"
        Me.Column4.HeaderText = "Check Out"
        Me.Column4.Name = "Column4"
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "lama_sewa"
        Me.Column6.HeaderText = "Lama Sewa"
        Me.Column6.Name = "Column6"
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "subtotal"
        Me.Column5.HeaderText = "SubTotal"
        Me.Column5.Name = "Column5"
        '
        'cboField
        '
        Me.cboField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboField.FormattingEnabled = True
        Me.cboField.Items.AddRange(New Object() {"Kode Reservasi", "Kode Pembayaran", "Id Customer", "No Kamar", "Check In", "Check Out", "Lama Sewa", "Subtotal"})
        Me.cboField.Location = New System.Drawing.Point(360, 31)
        Me.cboField.Margin = New System.Windows.Forms.Padding(4)
        Me.cboField.Name = "cboField"
        Me.cboField.Size = New System.Drawing.Size(179, 24)
        Me.cboField.TabIndex = 47
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(5, 33)
        Me.txtCari.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(347, 22)
        Me.txtCari.TabIndex = 46
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(648, 472)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(173, 30)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "Keluar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(736, 379)
        Me.BtnHapus.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(83, 30)
        Me.BtnHapus.TabIndex = 29
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'FormViewReservasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 510)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormViewReservasi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Reservasi"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DGVViewReservasi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnCariRes As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboKriteria As System.Windows.Forms.ComboBox
    Friend WithEvents DGVViewReservasi As System.Windows.Forms.DataGridView
    Friend WithEvents cboField As System.Windows.Forms.ComboBox
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnHapus As System.Windows.Forms.Button
End Class
