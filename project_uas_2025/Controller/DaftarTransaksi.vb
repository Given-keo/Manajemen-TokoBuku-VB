Public Class DaftarTransaksi
    Private Sub loadData()
        Try
            Dim DbTransaksi As New DbTransaksi()
            Dim table As DataTable = DbTransaksi.loadAlldata()
            infoGridView.DataSource = table

            ' Sembunyikan kolom ID yang tidak ingin ditampilkan
            infoGridView.Columns("id").Visible = False
            infoGridView.Columns("is_deleted").Visible = False
            infoGridView.Columns("id_pembeli").Visible = False
            infoGridView.Columns("id_buku").Visible = False

            ' Optional: Atur mode kolom agar lebih rapi
            infoGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        Catch ex As Exception
            MessageBox.Show("Gagal memuat data: " & ex.Message)
        End Try
    End Sub

    Private Sub DaftarTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub

    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        Try
            Dim searchTerm As String = searchTxt.Text.Trim()

            If String.IsNullOrWhiteSpace(searchTerm) Then
                MessageBox.Show("Silakan masukkan kata kunci pencarian", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning)
                searchTxt.Focus()
                Return
            End If

            Dim DbTransaksi As New DbTransaksi()
            Dim resultTable As DataTable = DbTransaksi.SearchTransaksi(searchTerm)

            If resultTable.Rows.Count > 0 Then
                infoGridView.DataSource = resultTable
                infoGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            Else
                MessageBox.Show("Tidak ditemukan transaksi dengan kata '" & searchTerm & "'", "Informasi",
                              MessageBoxButtons.OK, MessageBoxIcon.Information)
                loadData()
            End If
        Catch ex As Exception
            MessageBox.Show("Error saat mencari: " & ex.Message)
        End Try
    End Sub

    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        searchTxt.Clear()
        loadData()
    End Sub

    Private Sub InputBtn_Click(sender As Object, e As EventArgs) Handles InputBtn.Click
        FormTransaksi.Show()
    End Sub



    Private Sub infoGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles infoGridView.CellContentClick

    End Sub
End Class
