<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTransaksi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ComboPelangganDtl = New System.Windows.Forms.ComboBox()
        Me.ComboBukuDtl = New System.Windows.Forms.ComboBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.TextIdTransaksi = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtKodeBuku = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDescPelanggan = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtKodeTransaksi = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDescBuku = New System.Windows.Forms.TextBox()
        Me.txtPajak = New System.Windows.Forms.TextBox()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtJumlah = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboPelangganDtl
        '
        Me.ComboPelangganDtl.FormattingEnabled = True
        Me.ComboPelangganDtl.Location = New System.Drawing.Point(234, 504)
        Me.ComboPelangganDtl.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComboPelangganDtl.Name = "ComboPelangganDtl"
        Me.ComboPelangganDtl.Size = New System.Drawing.Size(157, 28)
        Me.ComboPelangganDtl.TabIndex = 99
        '
        'ComboBukuDtl
        '
        Me.ComboBukuDtl.FormattingEnabled = True
        Me.ComboBukuDtl.Location = New System.Drawing.Point(234, 376)
        Me.ComboBukuDtl.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComboBukuDtl.Name = "ComboBukuDtl"
        Me.ComboBukuDtl.Size = New System.Drawing.Size(157, 28)
        Me.ComboBukuDtl.TabIndex = 98
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.txtTotal.Location = New System.Drawing.Point(957, 436)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(248, 32)
        Me.txtTotal.TabIndex = 97
        '
        'TextIdTransaksi
        '
        Me.TextIdTransaksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.TextIdTransaksi.Location = New System.Drawing.Point(544, 183)
        Me.TextIdTransaksi.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextIdTransaksi.Name = "TextIdTransaksi"
        Me.TextIdTransaksi.Size = New System.Drawing.Size(132, 32)
        Me.TextIdTransaksi.TabIndex = 96
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(32, 248)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(182, 29)
        Me.Label8.TabIndex = 95
        Me.Label8.Text = "Kode Transaksi"
        '
        'txtKodeBuku
        '
        Me.txtKodeBuku.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.txtKodeBuku.Location = New System.Drawing.Point(402, 310)
        Me.txtKodeBuku.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtKodeBuku.Name = "txtKodeBuku"
        Me.txtKodeBuku.ReadOnly = True
        Me.txtKodeBuku.Size = New System.Drawing.Size(274, 32)
        Me.txtKodeBuku.TabIndex = 94
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(32, 310)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 29)
        Me.Label7.TabIndex = 93
        Me.Label7.Text = "Kode Buku"
        '
        'txtDescPelanggan
        '
        Me.txtDescPelanggan.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.txtDescPelanggan.Location = New System.Drawing.Point(402, 502)
        Me.txtDescPelanggan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDescPelanggan.Multiline = True
        Me.txtDescPelanggan.Name = "txtDescPelanggan"
        Me.txtDescPelanggan.ReadOnly = True
        Me.txtDescPelanggan.Size = New System.Drawing.Size(274, 96)
        Me.txtDescPelanggan.TabIndex = 92
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(28, 505)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(199, 29)
        Me.Label4.TabIndex = 91
        Me.Label4.Text = "Nama Pelanggan"
        '
        'txtKodeTransaksi
        '
        Me.txtKodeTransaksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.txtKodeTransaksi.Location = New System.Drawing.Point(402, 248)
        Me.txtKodeTransaksi.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtKodeTransaksi.Name = "txtKodeTransaksi"
        Me.txtKodeTransaksi.Size = New System.Drawing.Size(274, 32)
        Me.txtKodeTransaksi.TabIndex = 90
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(32, 170)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(191, 47)
        Me.Label6.TabIndex = 88
        Me.Label6.Text = "Transaksi"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(717, 434)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 29)
        Me.Label9.TabIndex = 87
        Me.Label9.Text = "Total"
        '
        'txtDescBuku
        '
        Me.txtDescBuku.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.txtDescBuku.Location = New System.Drawing.Point(402, 377)
        Me.txtDescBuku.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDescBuku.Multiline = True
        Me.txtDescBuku.Name = "txtDescBuku"
        Me.txtDescBuku.ReadOnly = True
        Me.txtDescBuku.Size = New System.Drawing.Size(274, 93)
        Me.txtDescBuku.TabIndex = 86
        '
        'txtPajak
        '
        Me.txtPajak.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.txtPajak.Location = New System.Drawing.Point(957, 371)
        Me.txtPajak.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPajak.Name = "txtPajak"
        Me.txtPajak.Size = New System.Drawing.Size(248, 32)
        Me.txtPajak.TabIndex = 85
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.txtSubTotal.Location = New System.Drawing.Point(957, 310)
        Me.txtSubTotal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Size = New System.Drawing.Size(248, 32)
        Me.txtSubTotal.TabIndex = 84
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(32, 377)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 29)
        Me.Label5.TabIndex = 82
        Me.Label5.Text = "Nama Buku"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(717, 373)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 29)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "Pajak"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(717, 310)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 29)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "Sub Total"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(717, 245)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 29)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "Jumlah Buku"
        '
        'txtJumlah
        '
        Me.txtJumlah.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.txtJumlah.Location = New System.Drawing.Point(957, 245)
        Me.txtJumlah.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(248, 32)
        Me.txtJumlah.TabIndex = 83
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1211, 87)
        Me.Panel1.TabIndex = 100
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label11.Location = New System.Drawing.Point(495, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(182, 40)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Transaksi"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnDelete)
        Me.GroupBox1.Controls.Add(Me.BtnAdd)
        Me.GroupBox1.Location = New System.Drawing.Point(722, 505)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(453, 154)
        Me.GroupBox1.TabIndex = 64
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Action"
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.BtnDelete.Location = New System.Drawing.Point(30, 52)
        Me.BtnDelete.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(171, 51)
        Me.BtnDelete.TabIndex = 31
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BtnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnAdd.Location = New System.Drawing.Point(242, 52)
        Me.BtnAdd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(190, 51)
        Me.BtnAdd.TabIndex = 30
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'FormTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1235, 743)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ComboPelangganDtl)
        Me.Controls.Add(Me.ComboBukuDtl)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.TextIdTransaksi)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtKodeBuku)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtDescPelanggan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtKodeTransaksi)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtDescBuku)
        Me.Controls.Add(Me.txtPajak)
        Me.Controls.Add(Me.txtSubTotal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtJumlah)
        Me.Name = "FormTransaksi"
        Me.Text = "formTransaksi"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboPelangganDtl As ComboBox
    Friend WithEvents ComboBukuDtl As ComboBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents TextIdTransaksi As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtKodeBuku As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDescPelanggan As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtKodeTransaksi As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtDescBuku As TextBox
    Friend WithEvents txtPajak As TextBox
    Friend WithEvents txtSubTotal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnAdd As Button
End Class
