<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DaftarPelanggan
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.InputBtn = New System.Windows.Forms.Button()
        Me.ResetBtn = New System.Windows.Forms.Button()
        Me.infoGridView = New System.Windows.Forms.DataGridView()
        Me.SearchBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.searchTxt = New System.Windows.Forms.TextBox()
        CType(Me.infoGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InputBtn
        '
        Me.InputBtn.BackColor = System.Drawing.Color.DarkSlateGray
        Me.InputBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.InputBtn.Location = New System.Drawing.Point(659, 12)
        Me.InputBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.InputBtn.Name = "InputBtn"
        Me.InputBtn.Size = New System.Drawing.Size(139, 37)
        Me.InputBtn.TabIndex = 20
        Me.InputBtn.Text = "Add Customer"
        Me.InputBtn.UseVisualStyleBackColor = False
        '
        'ResetBtn
        '
        Me.ResetBtn.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ResetBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ResetBtn.Location = New System.Drawing.Point(399, 12)
        Me.ResetBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ResetBtn.Name = "ResetBtn"
        Me.ResetBtn.Size = New System.Drawing.Size(121, 37)
        Me.ResetBtn.TabIndex = 21
        Me.ResetBtn.Text = "Reset"
        Me.ResetBtn.UseVisualStyleBackColor = False
        '
        'infoGridView
        '
        Me.infoGridView.BackgroundColor = System.Drawing.Color.LightGray
        Me.infoGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.infoGridView.Location = New System.Drawing.Point(12, 64)
        Me.infoGridView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.infoGridView.Name = "infoGridView"
        Me.infoGridView.RowHeadersWidth = 62
        Me.infoGridView.Size = New System.Drawing.Size(1037, 327)
        Me.infoGridView.TabIndex = 24
        '
        'SearchBtn
        '
        Me.SearchBtn.Location = New System.Drawing.Point(528, 12)
        Me.SearchBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(121, 37)
        Me.SearchBtn.TabIndex = 19
        Me.SearchBtn.Text = "Search"
        Me.SearchBtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 21)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 20)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Cari Pelanggan"
        '
        'searchTxt
        '
        Me.searchTxt.Location = New System.Drawing.Point(141, 18)
        Me.searchTxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.searchTxt.Name = "searchTxt"
        Me.searchTxt.Size = New System.Drawing.Size(249, 26)
        Me.searchTxt.TabIndex = 22
        '
        'DaftarPelanggan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.InputBtn)
        Me.Controls.Add(Me.ResetBtn)
        Me.Controls.Add(Me.infoGridView)
        Me.Controls.Add(Me.SearchBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.searchTxt)
        Me.Name = "DaftarPelanggan"
        Me.Size = New System.Drawing.Size(1093, 437)
        CType(Me.infoGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents InputBtn As Button
    Friend WithEvents ResetBtn As Button
    Friend WithEvents infoGridView As DataGridView
    Friend WithEvents SearchBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents searchTxt As TextBox
End Class
