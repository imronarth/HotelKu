<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEntryKamar
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
        Me.txtnokamar = New System.Windows.Forms.TextBox()
        Me.cmdSimpan = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.DGVKamar = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbjnskamar = New System.Windows.Forms.ComboBox()
        Me.txtharga = New System.Windows.Forms.TextBox()
        Me.cbauto = New System.Windows.Forms.CheckBox()
        CType(Me.DGVKamar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No Kamar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Harga"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jenis Kamar"
        '
        'txtnokamar
        '
        Me.txtnokamar.Location = New System.Drawing.Point(111, 40)
        Me.txtnokamar.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnokamar.MaxLength = 6
        Me.txtnokamar.Name = "txtnokamar"
        Me.txtnokamar.Size = New System.Drawing.Size(159, 22)
        Me.txtnokamar.TabIndex = 59
        '
        'cmdSimpan
        '
        Me.cmdSimpan.Location = New System.Drawing.Point(392, 13)
        Me.cmdSimpan.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdSimpan.Name = "cmdSimpan"
        Me.cmdSimpan.Size = New System.Drawing.Size(80, 28)
        Me.cmdSimpan.TabIndex = 97
        Me.cmdSimpan.Text = "&Simpan"
        Me.cmdSimpan.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(392, 126)
        Me.btnBatal.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(80, 28)
        Me.btnBatal.TabIndex = 102
        Me.btnBatal.Text = "&Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(392, 90)
        Me.btnHapus.Margin = New System.Windows.Forms.Padding(4)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(80, 28)
        Me.btnHapus.TabIndex = 101
        Me.btnHapus.Text = "&Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnCari
        '
        Me.btnCari.Location = New System.Drawing.Point(392, 54)
        Me.btnCari.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(80, 28)
        Me.btnCari.TabIndex = 100
        Me.btnCari.Text = "&Cari"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(286, 355)
        Me.btnKeluar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(186, 28)
        Me.btnKeluar.TabIndex = 104
        Me.btnKeluar.Text = "&Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'DGVKamar
        '
        Me.DGVKamar.AllowUserToAddRows = False
        Me.DGVKamar.AllowUserToDeleteRows = False
        Me.DGVKamar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVKamar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVKamar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.DGVKamar.Location = New System.Drawing.Point(15, 159)
        Me.DGVKamar.Name = "DGVKamar"
        Me.DGVKamar.RowHeadersVisible = False
        Me.DGVKamar.RowTemplate.Height = 24
        Me.DGVKamar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVKamar.Size = New System.Drawing.Size(457, 189)
        Me.DGVKamar.TabIndex = 103
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "no_kmr"
        Me.Column1.HeaderText = "No Kamar"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "jenis_kamar"
        Me.Column2.HeaderText = "Jenis Kamar"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "harga"
        Me.Column3.HeaderText = "Harga"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "status"
        Me.Column4.HeaderText = "Status"
        Me.Column4.Name = "Column4"
        '
        'cbjnskamar
        '
        Me.cbjnskamar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.cbjnskamar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbjnskamar.FormattingEnabled = True
        Me.cbjnskamar.Items.AddRange(New Object() {"Standard", "VIP", "Exclusive"})
        Me.cbjnskamar.Location = New System.Drawing.Point(111, 71)
        Me.cbjnskamar.Name = "cbjnskamar"
        Me.cbjnskamar.Size = New System.Drawing.Size(159, 24)
        Me.cbjnskamar.TabIndex = 106
        '
        'txtharga
        '
        Me.txtharga.Location = New System.Drawing.Point(111, 102)
        Me.txtharga.Margin = New System.Windows.Forms.Padding(4)
        Me.txtharga.Name = "txtharga"
        Me.txtharga.Size = New System.Drawing.Size(245, 22)
        Me.txtharga.TabIndex = 107
        '
        'cbauto
        '
        Me.cbauto.AutoSize = True
        Me.cbauto.Location = New System.Drawing.Point(276, 73)
        Me.cbauto.Name = "cbauto"
        Me.cbauto.Size = New System.Drawing.Size(59, 21)
        Me.cbauto.TabIndex = 108
        Me.cbauto.Text = "Auto"
        Me.cbauto.UseVisualStyleBackColor = True
        '
        'FormEntryKamar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 398)
        Me.Controls.Add(Me.cbauto)
        Me.Controls.Add(Me.txtharga)
        Me.Controls.Add(Me.cbjnskamar)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.DGVKamar)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.cmdSimpan)
        Me.Controls.Add(Me.txtnokamar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormEntryKamar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Entry Kamar"
        CType(Me.DGVKamar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtnokamar As System.Windows.Forms.TextBox
    Friend WithEvents cmdSimpan As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnCari As System.Windows.Forms.Button
    Friend WithEvents btnKeluar As System.Windows.Forms.Button
    Friend WithEvents DGVKamar As System.Windows.Forms.DataGridView
    Friend WithEvents cbjnskamar As System.Windows.Forms.ComboBox
    Friend WithEvents txtharga As System.Windows.Forms.TextBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cbauto As System.Windows.Forms.CheckBox
End Class
