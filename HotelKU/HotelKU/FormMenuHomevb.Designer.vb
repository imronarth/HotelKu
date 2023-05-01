<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenu
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMenu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.menuakun = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuhakakses = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuLogOut = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuKeluar = New System.Windows.Forms.ToolStripMenuItem()
        Me.menufmaster = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuentrycus = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuentrypegawai = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuentrykamar = New System.Windows.Forms.ToolStripMenuItem()
        Me.menufiletransaksi = New System.Windows.Forms.ToolStripMenuItem()
        Me.menureservasi = New System.Windows.Forms.ToolStripMenuItem()
        Me.menupembayaran = New System.Windows.Forms.ToolStripMenuItem()
        Me.menufileview = New System.Windows.Forms.ToolStripMenuItem()
        Me.menureservasiview = New System.Windows.Forms.ToolStripMenuItem()
        Me.menupembayaranview = New System.Windows.Forms.ToolStripMenuItem()
        Me.menufilelaporan = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataPegawaiDanDataCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.labeluser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statusnama = New System.Windows.Forms.ToolStripStatusLabel()
        Me.labeldate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statusdate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuakun, Me.menufmaster, Me.menufiletransaksi, Me.menufileview, Me.menufilelaporan})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(712, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'menuakun
        '
        Me.menuakun.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuhakakses, Me.menuLogOut, Me.menuKeluar})
        Me.menuakun.Name = "menuakun"
        Me.menuakun.Size = New System.Drawing.Size(54, 24)
        Me.menuakun.Text = "Akun"
        '
        'menuhakakses
        '
        Me.menuhakakses.Name = "menuhakakses"
        Me.menuhakakses.Size = New System.Drawing.Size(179, 24)
        Me.menuhakakses.Text = "Buat Hak Akses"
        '
        'menuLogOut
        '
        Me.menuLogOut.Name = "menuLogOut"
        Me.menuLogOut.Size = New System.Drawing.Size(179, 24)
        Me.menuLogOut.Text = "Log Out"
        '
        'menuKeluar
        '
        Me.menuKeluar.Name = "menuKeluar"
        Me.menuKeluar.Size = New System.Drawing.Size(179, 24)
        Me.menuKeluar.Text = "Keluar"
        '
        'menufmaster
        '
        Me.menufmaster.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuentrycus, Me.menuentrypegawai, Me.menuentrykamar})
        Me.menufmaster.Name = "menufmaster"
        Me.menufmaster.Size = New System.Drawing.Size(93, 24)
        Me.menufmaster.Text = "File Master"
        '
        'menuentrycus
        '
        Me.menuentrycus.Name = "menuentrycus"
        Me.menuentrycus.Size = New System.Drawing.Size(178, 24)
        Me.menuentrycus.Text = "Entry Costumer"
        '
        'menuentrypegawai
        '
        Me.menuentrypegawai.Name = "menuentrypegawai"
        Me.menuentrypegawai.Size = New System.Drawing.Size(178, 24)
        Me.menuentrypegawai.Text = "Entry Pegawai"
        '
        'menuentrykamar
        '
        Me.menuentrykamar.Name = "menuentrykamar"
        Me.menuentrykamar.Size = New System.Drawing.Size(178, 24)
        Me.menuentrykamar.Text = "Entry Kamar"
        '
        'menufiletransaksi
        '
        Me.menufiletransaksi.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menureservasi, Me.menupembayaran})
        Me.menufiletransaksi.Name = "menufiletransaksi"
        Me.menufiletransaksi.Size = New System.Drawing.Size(107, 24)
        Me.menufiletransaksi.Text = "File Transaksi"
        '
        'menureservasi
        '
        Me.menureservasi.Name = "menureservasi"
        Me.menureservasi.Size = New System.Drawing.Size(159, 24)
        Me.menureservasi.Text = "Reservasi"
        '
        'menupembayaran
        '
        Me.menupembayaran.Name = "menupembayaran"
        Me.menupembayaran.Size = New System.Drawing.Size(159, 24)
        Me.menupembayaran.Text = "Pembayaran"
        '
        'menufileview
        '
        Me.menufileview.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menureservasiview, Me.menupembayaranview})
        Me.menufileview.Name = "menufileview"
        Me.menufileview.Size = New System.Drawing.Size(80, 24)
        Me.menufileview.Text = "File View"
        '
        'menureservasiview
        '
        Me.menureservasiview.Name = "menureservasiview"
        Me.menureservasiview.Size = New System.Drawing.Size(195, 24)
        Me.menureservasiview.Text = "View Reservasi"
        '
        'menupembayaranview
        '
        Me.menupembayaranview.Name = "menupembayaranview"
        Me.menupembayaranview.Size = New System.Drawing.Size(195, 24)
        Me.menupembayaranview.Text = "View Pembayaran"
        '
        'menufilelaporan
        '
        Me.menufilelaporan.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataPegawaiDanDataCustomerToolStripMenuItem})
        Me.menufilelaporan.Name = "menufilelaporan"
        Me.menufilelaporan.Size = New System.Drawing.Size(102, 24)
        Me.menufilelaporan.Text = "File Laporan"
        '
        'DataPegawaiDanDataCustomerToolStripMenuItem
        '
        Me.DataPegawaiDanDataCustomerToolStripMenuItem.Name = "DataPegawaiDanDataCustomerToolStripMenuItem"
        Me.DataPegawaiDanDataCustomerToolStripMenuItem.Size = New System.Drawing.Size(301, 24)
        Me.DataPegawaiDanDataCustomerToolStripMenuItem.Text = "Data Pegawai dan Data Customer"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.labeluser, Me.statusnama, Me.labeldate, Me.statusdate, Me.ToolStripDropDownButton1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 394)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(712, 29)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'labeluser
        '
        Me.labeluser.Font = New System.Drawing.Font("Unispace", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labeluser.Name = "labeluser"
        Me.labeluser.Size = New System.Drawing.Size(71, 24)
        Me.labeluser.Text = "Welcome"
        '
        'statusnama
        '
        Me.statusnama.Font = New System.Drawing.Font("Unispace", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statusnama.Name = "statusnama"
        Me.statusnama.Size = New System.Drawing.Size(490, 24)
        Me.statusnama.Spring = True
        Me.statusnama.Text = "Sistem Pemesanan Kamar Hotel"
        '
        'labeldate
        '
        Me.labeldate.Font = New System.Drawing.Font("Unispace", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labeldate.Name = "labeldate"
        Me.labeldate.Size = New System.Drawing.Size(0, 24)
        '
        'statusdate
        '
        Me.statusdate.Font = New System.Drawing.Font("Unispace", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statusdate.Name = "statusdate"
        Me.statusdate.Size = New System.Drawing.Size(107, 24)
        Me.statusdate.Text = "08 Nov 2019"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.Enabled = False
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(29, 27)
        Me.ToolStripDropDownButton1.Text = "ToolStripDropDownButton1"
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 10000
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 423)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormMenu"
        Me.Text = "Form Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents menuakun As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menufmaster As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuhakakses As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuentrycus As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuentrypegawai As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuentrykamar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuLogOut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuKeluar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents labeluser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents menufiletransaksi As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menureservasi As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menupembayaran As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents statusnama As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents labeldate As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents statusdate As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents menufileview As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menureservasiview As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menupembayaranview As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menufilelaporan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataPegawaiDanDataCustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
