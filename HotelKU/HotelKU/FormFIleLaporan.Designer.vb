<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFIleLaporan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormFIleLaporan))
        Me.btnDataKwn = New System.Windows.Forms.Button()
        Me.AXCKaryawan = New AxCrystal.AxCrystalReport()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblstatusdatakaryawan = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnDataCustom = New System.Windows.Forms.Button()
        Me.lblstatuscustom = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.AXCKaryawan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDataKwn
        '
        Me.btnDataKwn.Location = New System.Drawing.Point(70, 93)
        Me.btnDataKwn.Name = "btnDataKwn"
        Me.btnDataKwn.Size = New System.Drawing.Size(155, 50)
        Me.btnDataKwn.TabIndex = 0
        Me.btnDataKwn.Text = "Data Karyawan"
        Me.btnDataKwn.UseVisualStyleBackColor = True
        '
        'AXCKaryawan
        '
        Me.AXCKaryawan.Enabled = True
        Me.AXCKaryawan.Location = New System.Drawing.Point(269, 137)
        Me.AXCKaryawan.Name = "AXCKaryawan"
        Me.AXCKaryawan.OcxState = CType(resources.GetObject("AXCKaryawan.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AXCKaryawan.Size = New System.Drawing.Size(28, 28)
        Me.AXCKaryawan.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("ROG Fonts", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(189, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(284, 36)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "File Laporan"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lblstatusdatakaryawan)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.AXCKaryawan)
        Me.Panel1.Controls.Add(Me.btnDataKwn)
        Me.Panel1.Location = New System.Drawing.Point(13, 66)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(300, 168)
        Me.Panel1.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 10.2!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(89, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 19)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Tidak Tersedia"
        '
        'lblstatusdatakaryawan
        '
        Me.lblstatusdatakaryawan.AutoSize = True
        Me.lblstatusdatakaryawan.Font = New System.Drawing.Font("Times New Roman", 10.2!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstatusdatakaryawan.Location = New System.Drawing.Point(114, 57)
        Me.lblstatusdatakaryawan.Name = "lblstatusdatakaryawan"
        Me.lblstatusdatakaryawan.Size = New System.Drawing.Size(69, 19)
        Me.lblstatusdatakaryawan.TabIndex = 7
        Me.lblstatusdatakaryawan.Text = "Tersedia"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(50, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(203, 22)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Laporan Data Karyawan"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.btnDataCustom)
        Me.Panel2.Controls.Add(Me.lblstatuscustom)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(336, 66)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(300, 168)
        Me.Panel2.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 10.2!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(106, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 19)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Tidak Tersedia"
        '
        'btnDataCustom
        '
        Me.btnDataCustom.Location = New System.Drawing.Point(81, 93)
        Me.btnDataCustom.Name = "btnDataCustom"
        Me.btnDataCustom.Size = New System.Drawing.Size(155, 50)
        Me.btnDataCustom.TabIndex = 8
        Me.btnDataCustom.Text = "Data Customer"
        Me.btnDataCustom.UseVisualStyleBackColor = True
        '
        'lblstatuscustom
        '
        Me.lblstatuscustom.AutoSize = True
        Me.lblstatuscustom.Font = New System.Drawing.Font("Times New Roman", 10.2!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstatuscustom.Location = New System.Drawing.Point(121, 57)
        Me.lblstatuscustom.Name = "lblstatuscustom"
        Me.lblstatuscustom.Size = New System.Drawing.Size(69, 19)
        Me.lblstatuscustom.TabIndex = 8
        Me.lblstatuscustom.Text = "Tersedia"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(52, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(197, 22)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Laporan Data Customer"
        '
        'FormFIleLaporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(646, 247)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormFIleLaporan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "File Laporan"
        CType(Me.AXCKaryawan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDataKwn As System.Windows.Forms.Button
    Friend WithEvents AXCKaryawan As AxCrystal.AxCrystalReport
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblstatusdatakaryawan As System.Windows.Forms.Label
    Friend WithEvents btnDataCustom As System.Windows.Forms.Button
    Friend WithEvents lblstatuscustom As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
