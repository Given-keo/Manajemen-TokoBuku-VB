Public Class DaftarBuku
    Private Sub loadData()
        Try
            Dim DbBuku As New DbBuku()
            Dim table As DataTable = DbBuku.loadAlldata()
            infoGridView.DataSource = table
            infoGridView.Columns("id").Visible = False 'umpetin id'
            infoGridView.Columns("is_deleted").Visible = False 'umpetin 
        Catch ex As Exception
            MessageBox.Show("Gagal memuat data: " & ex.Message)
        End Try
    End Sub

    Private Sub Data_Management_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub

    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        Try
            Dim searchTerm As String = searchTxt.Text.Trim()

            Dim DbBuku As New DbBuku()
            Dim resultTable As DataTable = DbBuku.searchBooks(searchTerm)

            ' Validasi input kosong
            If String.IsNullOrWhiteSpace(searchTerm) Then
                MessageBox.Show("Silakan masukkan kata kunci pencarian", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning)
                searchTxt.Focus()
                Return
            End If

            If resultTable.Rows.Count > 0 Then
                infoGridView.DataSource = resultTable
                infoGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            Else
                MessageBox.Show("Tidak ditemukan buku dengan judul '" & searchTerm & "'", "Informasi",
                              MessageBoxButtons.OK, MessageBoxIcon.Information)
                loadData() ' Tampilkan semua data jika tidak ada hasil
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
        FormBuku.Show()
    End Sub

    Private Sub infoGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles infoGridView.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = infoGridView.Rows(e.RowIndex)
            Dim Input As New FormBuku()
            Input.txtKode.Text = row.Cells("kode_buku").Value.ToString()
            Input.txtJudul.Text = row.Cells("nama_buku").Value.ToString()
            Input.txtPenulis.Text = row.Cells("pengarang").Value.ToString()
            Input.txtPenerbit.Text = row.Cells("penerbit").Value.ToString()
            Input.txtId.Text = row.Cells("id").Value.ToString()
            Input.txtTahun.Text = row.Cells("tahun_terbit").Value.ToString()
            Input.txtHarga.Text = row.Cells("harga").Value.ToString()
            Input.txtStok.Text = row.Cells("stok").Value.ToString()
            Input.txtDeskripsi.Text = row.Cells("deskripsi").Value.ToString()
            Input.Show()
        End If
    End Sub

    Private Sub infoGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles infoGridView.CellContentClick

    End Sub
End Class
