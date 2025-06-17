<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReportData
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComboDataType = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBoxReport = New System.Windows.Forms.ComboBox()
        Me.lblMenu = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePickerEnd = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerStart = New System.Windows.Forms.DateTimePicker()
        Me.lblEndDate = New System.Windows.Forms.Label()
        Me.lblStartDate = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(16, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1003, 68)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(417, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Data Report"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ComboDataType)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.ComboBoxReport)
        Me.GroupBox2.Controls.Add(Me.lblMenu)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 105)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(480, 143)
        Me.GroupBox2.TabIndex = 38
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Type"
        '
        'ComboDataType
        '
        Me.ComboDataType.FormattingEnabled = True
        Me.ComboDataType.Items.AddRange(New Object() {"Buku", "Pembeli", "Transaksi"})
        Me.ComboDataType.Location = New System.Drawing.Point(154, 88)
        Me.ComboDataType.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComboDataType.Name = "ComboDataType"
        Me.ComboDataType.Size = New System.Drawing.Size(290, 28)
        Me.ComboDataType.TabIndex = 35
        Me.ComboDataType.Text = "Option"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(30, 94)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 20)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Data Type"
        '
        'ComboBoxReport
        '
        Me.ComboBoxReport.FormattingEnabled = True
        Me.ComboBoxReport.Items.AddRange(New Object() {"PDF", "Excel"})
        Me.ComboBoxReport.Location = New System.Drawing.Point(154, 31)
        Me.ComboBoxReport.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComboBoxReport.Name = "ComboBoxReport"
        Me.ComboBoxReport.Size = New System.Drawing.Size(290, 28)
        Me.ComboBoxReport.TabIndex = 31
        Me.ComboBoxReport.Text = "Option"
        '
        'lblMenu
        '
        Me.lblMenu.AutoSize = True
        Me.lblMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenu.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblMenu.Location = New System.Drawing.Point(30, 32)
        Me.lblMenu.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(107, 20)
        Me.lblMenu.TabIndex = 30
        Me.lblMenu.Text = "Report Type"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimePickerEnd)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerStart)
        Me.GroupBox1.Controls.Add(Me.lblEndDate)
        Me.GroupBox1.Controls.Add(Me.lblStartDate)
        Me.GroupBox1.Location = New System.Drawing.Point(530, 105)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(476, 143)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search By Date"
        '
        'DateTimePickerEnd
        '
        Me.DateTimePickerEnd.Location = New System.Drawing.Point(147, 91)
        Me.DateTimePickerEnd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DateTimePickerEnd.Name = "DateTimePickerEnd"
        Me.DateTimePickerEnd.Size = New System.Drawing.Size(298, 26)
        Me.DateTimePickerEnd.TabIndex = 33
        '
        'DateTimePickerStart
        '
        Me.DateTimePickerStart.Location = New System.Drawing.Point(147, 32)
        Me.DateTimePickerStart.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DateTimePickerStart.Name = "DateTimePickerStart"
        Me.DateTimePickerStart.Size = New System.Drawing.Size(298, 26)
        Me.DateTimePickerStart.TabIndex = 32
        '
        'lblEndDate
        '
        Me.lblEndDate.AutoSize = True
        Me.lblEndDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndDate.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblEndDate.Location = New System.Drawing.Point(36, 95)
        Me.lblEndDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEndDate.Name = "lblEndDate"
        Me.lblEndDate.Size = New System.Drawing.Size(85, 20)
        Me.lblEndDate.TabIndex = 29
        Me.lblEndDate.Text = "End Date"
        '
        'lblStartDate
        '
        Me.lblStartDate.AutoSize = True
        Me.lblStartDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartDate.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblStartDate.Location = New System.Drawing.Point(36, 35)
        Me.lblStartDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStartDate.Name = "lblStartDate"
        Me.lblStartDate.Size = New System.Drawing.Size(93, 20)
        Me.lblStartDate.TabIndex = 28
        Me.lblStartDate.Text = "Start Date"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnPrint)
        Me.GroupBox3.Location = New System.Drawing.Point(356, 258)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox3.Size = New System.Drawing.Size(336, 109)
        Me.GroupBox3.TabIndex = 40
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Aksi"
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnPrint.Location = New System.Drawing.Point(96, 43)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(142, 35)
        Me.btnPrint.TabIndex = 27
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'ReportData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ReportData"
        Me.Size = New System.Drawing.Size(1065, 402)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ComboDataType As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBoxReport As ComboBox
    Friend WithEvents lblMenu As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DateTimePickerEnd As DateTimePicker
    Friend WithEvents DateTimePickerStart As DateTimePicker
    Friend WithEvents lblEndDate As Label
    Friend WithEvents lblStartDate As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnPrint As Button
End Class
