<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DaftarBuku
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.searchTxt = New System.Windows.Forms.TextBox()
        Me.ResetBtn = New System.Windows.Forms.Button()
        Me.InputBtn = New System.Windows.Forms.Button()
        Me.SearchBtn = New System.Windows.Forms.Button()
        Me.infoGridView = New System.Windows.Forms.DataGridView()
        CType(Me.infoGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 34)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 20)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Cari Buku"
        '
        'searchTxt
        '
        Me.searchTxt.Location = New System.Drawing.Point(115, 31)
        Me.searchTxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.searchTxt.Name = "searchTxt"
        Me.searchTxt.Size = New System.Drawing.Size(249, 26)
        Me.searchTxt.TabIndex = 15
        '
        'ResetBtn
        '
        Me.ResetBtn.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ResetBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ResetBtn.Location = New System.Drawing.Point(406, 25)
        Me.ResetBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ResetBtn.Name = "ResetBtn"
        Me.ResetBtn.Size = New System.Drawing.Size(121, 37)
        Me.ResetBtn.TabIndex = 12
        Me.ResetBtn.Text = "Reset"
        Me.ResetBtn.UseVisualStyleBackColor = False
        '
        'InputBtn
        '
        Me.InputBtn.BackColor = System.Drawing.Color.DarkSlateGray
        Me.InputBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.InputBtn.Location = New System.Drawing.Point(688, 25)
        Me.InputBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.InputBtn.Name = "InputBtn"
        Me.InputBtn.Size = New System.Drawing.Size(121, 37)
        Me.InputBtn.TabIndex = 10
        Me.InputBtn.Text = "Add Book"
        Me.InputBtn.UseVisualStyleBackColor = False
        '
        'SearchBtn
        '
        Me.SearchBtn.Location = New System.Drawing.Point(547, 25)
        Me.SearchBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(121, 37)
        Me.SearchBtn.TabIndex = 9
        Me.SearchBtn.Text = "Search"
        Me.SearchBtn.UseVisualStyleBackColor = True
        '
        'infoGridView
        '
        Me.infoGridView.BackgroundColor = System.Drawing.Color.LightGray
        Me.infoGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.infoGridView.Location = New System.Drawing.Point(14, 77)
        Me.infoGridView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.infoGridView.Name = "infoGridView"
        Me.infoGridView.RowHeadersWidth = 62
        Me.infoGridView.Size = New System.Drawing.Size(1037, 327)
        Me.infoGridView.TabIndex = 18
        '
        'DaftarBuku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.InputBtn)
        Me.Controls.Add(Me.ResetBtn)
        Me.Controls.Add(Me.infoGridView)
        Me.Controls.Add(Me.SearchBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.searchTxt)
        Me.Name = "DaftarBuku"
        Me.Size = New System.Drawing.Size(1091, 453)
        CType(Me.infoGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents searchTxt As TextBox
    Friend WithEvents ResetBtn As Button
    Friend WithEvents InputBtn As Button
    Friend WithEvents SearchBtn As Button
    Friend WithEvents infoGridView As DataGridView
End Class
