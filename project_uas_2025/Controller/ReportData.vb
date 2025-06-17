Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports NPOI.SS.UserModel
Imports NPOI.XSSF.UserModel
Imports System.IO

Public Class ReportData

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim starts As Integer = CInt(DateTimePickerStart.Value.ToString("yyyyMMdd"))
        Dim ends As Integer = CInt(DateTimePickerEnd.Value.ToString("yyyyMMdd"))
        Dim reportType = ComboBoxReport.SelectedItem

        If reportType Is Nothing OrElse reportType = "" Then
            MessageBox.Show("Invalid report type!")
        ElseIf ComboDataType.SelectedItem Is Nothing OrElse ComboDataType.SelectedItem = "" Then
            MessageBox.Show("Invalid data type!")
        ElseIf starts > ends Then
            MessageBox.Show("Invalid Date: Start date must be lower than end date", "Info", MessageBoxButtons.OK)
        Else
            Dim dataReport As DataTable = Nothing
            Dim dataType = ComboDataType.SelectedItem

            If dataType = "Buku" Then
                Dim DbBuku = New DbBuku()
                dataReport = DbBuku.generateDataReportBuku(DateTimePickerStart.Value.Date, DateTimePickerEnd.Value.Date)

            ElseIf dataType = "Pembeli" Then
                Dim DbPelanggan = New DbPelanggan()
                dataReport = DbPelanggan.generateDataReportPembeli(DateTimePickerStart.Value.Date, DateTimePickerEnd.Value.Date)

            ElseIf dataType = "Transaksi" Then
                Dim DbTransaksi = New DbTransaksi()
                dataReport = DbTransaksi.generateDataReportTransaksi(DateTimePickerStart.Value.Date, DateTimePickerEnd.Value.Date)
            End If

            If dataReport IsNot Nothing AndAlso dataReport.Rows.Count > 0 Then
                Dim filename = generateFilename()
                If reportType = "PDF" Then
                    filename &= ".pdf"
                    ExportToPDF(dataReport, filename)
                    MessageBox.Show("PDF File Created!" & vbNewLine & "file: " & filename)
                Else
                    filename &= ".xlsx"
                    ExportToExcel(dataReport, filename)
                    MessageBox.Show("Excel File Created!" & vbNewLine & "file: " & filename)
                End If
            Else
                MessageBox.Show("No data following the selected date range.")
            End If
        End If
    End Sub

    Function generateFilename() As String
        Dim basePath As String = "C:\Mata-Kuliah\Pemrograman Visual 1\Sample\"
        If Not Directory.Exists(basePath) Then
            Directory.CreateDirectory(basePath)
        End If
        Return Path.Combine(basePath, Date.Now.ToString("yyyyMMddHHmmss"))
    End Function

    Sub ExportToPDF(dt As DataTable, filepath As String)
        ' Pastikan folder ada
        Dim folderPath As String = Path.GetDirectoryName(filepath)
        If Not Directory.Exists(folderPath) Then
            Directory.CreateDirectory(folderPath)
        End If

        Dim doc As New Document(PageSize.A4, 10, 10, 10, 10)
        PdfWriter.GetInstance(doc, New FileStream(filepath, FileMode.Create))
        doc.Open()

        Dim titleFont As Font = FontFactory.GetFont("Helvetica", CStr(14), Font.Bold)
        doc.Add(New Paragraph("Laporan Transaksi", titleFont))
        doc.Add(New Paragraph("Tanggal: " & DateTimePickerStart.Value.ToShortDateString() &
                              " - " & DateTimePickerEnd.Value.ToShortDateString()))
        doc.Add(New Paragraph(" "))

        Dim table As New PdfPTable(dt.Columns.Count)
        table.WidthPercentage = 100

        ' Header
        For Each col As DataColumn In dt.Columns
            table.AddCell(New Phrase(col.ColumnName, FontFactory.GetFont("Arial", CStr(10), Font.Bold)))
        Next

        ' Rows
        For Each row As DataRow In dt.Rows
            For Each cell In row.ItemArray
                table.AddCell(cell.ToString())
            Next
        Next

        doc.Add(table)
        doc.Close()
    End Sub

    Sub ExportToExcel(dt As DataTable, filePath As String)
        ' Pastikan folder ada
        Dim folderPath As String = Path.GetDirectoryName(filePath)
        If Not Directory.Exists(folderPath) Then
            Directory.CreateDirectory(folderPath)
        End If

        Dim workbook As New XSSFWorkbook()
        Dim sheet As ISheet = workbook.CreateSheet("Report")

        ' Header
        Dim headerRow = sheet.CreateRow(0)
        For col = 0 To dt.Columns.Count - 1
            headerRow.CreateCell(col).SetCellValue(dt.Columns(col).ColumnName)
        Next

        ' Data Rows
        For i = 0 To dt.Rows.Count - 1
            Dim row = sheet.CreateRow(i + 1)
            For j = 0 To dt.Columns.Count - 1
                row.CreateCell(j).SetCellValue(dt.Rows(i)(j).ToString())
            Next
        Next

        ' Autosize columns
        For col = 0 To dt.Columns.Count - 1
            sheet.AutoSizeColumn(col)
        Next

        Using fs As New FileStream(filePath, FileMode.Create, FileAccess.Write)
            workbook.Write(fs)
        End Using
    End Sub

End Class
