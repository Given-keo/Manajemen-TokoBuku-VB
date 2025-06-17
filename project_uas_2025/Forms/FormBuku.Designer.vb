<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBuku
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
        Me.txtPenerbit = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.ComboGenre = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDeskripsi = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.txtStok = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtKode = New System.Windows.Forms.TextBox()
        Me.txtTahun = New System.Windows.Forms.TextBox()
        Me.txtPenulis = New System.Windows.Forms.TextBox()
        Me.txtJudul = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtPenerbit
        '
        Me.txtPenerbit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.txtPenerbit.Location = New System.Drawing.Point(248, 614)
        Me.txtPenerbit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPenerbit.Name = "txtPenerbit"
        Me.txtPenerbit.Size = New System.Drawing.Size(277, 32)
        Me.txtPenerbit.TabIndex = 66
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(71, 618)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 29)
        Me.Label10.TabIndex = 65
        Me.Label10.Text = "Penerbit"
        '
        'txtId
        '
        Me.txtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.txtId.Location = New System.Drawing.Point(401, 151)
        Me.txtId.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(121, 32)
        Me.txtId.TabIndex = 64
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnDelete)
        Me.GroupBox1.Controls.Add(Me.BtnAdd)
        Me.GroupBox1.Location = New System.Drawing.Point(659, 432)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(453, 154)
        Me.GroupBox1.TabIndex = 63
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
        'ComboGenre
        '
        Me.ComboGenre.FormattingEnabled = True
        Me.ComboGenre.Items.AddRange(New Object() {"Petualangan", "Aksi", "Fantasi", "Novel", "Fabel", "Horror", "Thriller"})
        Me.ComboGenre.Location = New System.Drawing.Point(887, 218)
        Me.ComboGenre.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComboGenre.Name = "ComboGenre"
        Me.ComboGenre.Size = New System.Drawing.Size(223, 28)
        Me.ComboGenre.TabIndex = 62
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(60, 134)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 47)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "Buku"
        '
        'txtDeskripsi
        '
        Me.txtDeskripsi.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.txtDeskripsi.Location = New System.Drawing.Point(248, 478)
        Me.txtDeskripsi.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDeskripsi.Multiline = True
        Me.txtDeskripsi.Name = "txtDeskripsi"
        Me.txtDeskripsi.Size = New System.Drawing.Size(277, 106)
        Me.txtDeskripsi.TabIndex = 60
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(71, 484)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 29)
        Me.Label9.TabIndex = 59
        Me.Label9.Text = "Deskripsi"
        '
        'txtHarga
        '
        Me.txtHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.txtHarga.Location = New System.Drawing.Point(887, 275)
        Me.txtHarga.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(223, 32)
        Me.txtHarga.TabIndex = 58
        '
        'txtStok
        '
        Me.txtStok.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.txtStok.Location = New System.Drawing.Point(887, 341)
        Me.txtStok.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtStok.Name = "txtStok"
        Me.txtStok.Size = New System.Drawing.Size(223, 32)
        Me.txtStok.TabIndex = 57
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(653, 281)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 29)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "Harga"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(653, 220)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 29)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "Kategori"
        '
        'txtKode
        '
        Me.txtKode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.txtKode.Location = New System.Drawing.Point(384, 218)
        Me.txtKode.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtKode.Name = "txtKode"
        Me.txtKode.Size = New System.Drawing.Size(140, 32)
        Me.txtKode.TabIndex = 54
        '
        'txtTahun
        '
        Me.txtTahun.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.txtTahun.Location = New System.Drawing.Point(384, 404)
        Me.txtTahun.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTahun.Name = "txtTahun"
        Me.txtTahun.Size = New System.Drawing.Size(140, 32)
        Me.txtTahun.TabIndex = 53
        '
        'txtPenulis
        '
        Me.txtPenulis.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.txtPenulis.Location = New System.Drawing.Point(248, 344)
        Me.txtPenulis.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPenulis.Name = "txtPenulis"
        Me.txtPenulis.Size = New System.Drawing.Size(277, 32)
        Me.txtPenulis.TabIndex = 52
        '
        'txtJudul
        '
        Me.txtJudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.txtJudul.Location = New System.Drawing.Point(248, 281)
        Me.txtJudul.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtJudul.Name = "txtJudul"
        Me.txtJudul.Size = New System.Drawing.Size(277, 32)
        Me.txtJudul.TabIndex = 51
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(71, 224)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 29)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Kode Buku"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(653, 347)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 29)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Stok"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(71, 410)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 29)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Tahun Terbit"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(71, 349)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 29)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Penulis"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(71, 284)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 29)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Judul"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Location = New System.Drawing.Point(27, 22)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1133, 87)
        Me.Panel1.TabIndex = 67
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label11.Location = New System.Drawing.Point(369, 23)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(402, 40)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Data Manajemen Buku"
        '
        'FormBuku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1172, 687)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtPenerbit)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ComboGenre)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtDeskripsi)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.txtStok)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtKode)
        Me.Controls.Add(Me.txtTahun)
        Me.Controls.Add(Me.txtPenulis)
        Me.Controls.Add(Me.txtJudul)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormBuku"
        Me.Text = "formBuku"
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPenerbit As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents ComboGenre As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDeskripsi As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtStok As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtKode As TextBox
    Friend WithEvents txtTahun As TextBox
    Friend WithEvents txtPenulis As TextBox
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label11 As Label
End Class
