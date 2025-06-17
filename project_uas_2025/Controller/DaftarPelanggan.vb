Public Class DaftarPelanggan
    Private Sub loadData()
        Try
            Dim DbItem As New DbPelanggan()
            Dim table As DataTable = DbItem.loadAlldata()
            infoGridView.DataSource = table
            infoGridView.Columns("id").Visible = False
            infoGridView.Columns("is_deleted").Visible = False
        Catch ex As Exception
            MessageBox.Show("Gagal memuat data: " & ex.Message)
        End Try
    End Sub

    Private Sub DaftarPelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub

    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        Try
            Dim searchTerm As String = searchTxt.Text.Trim()
            Dim DbPelanggan As New DbPelanggan()
            Dim resultTable As DataTable = DbPelanggan.searchCustomers(searchTerm)

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
                MessageBox.Show("Tidak ditemukan pelanggan dengan nama '" & searchTerm & "'", "Informasi",
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
        FormPelanggan.Show()
    End Sub

    ' Perbaikan: tambahkan Handles
    Private Sub infoGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles infoGridView.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = infoGridView.Rows(e.RowIndex)
            Dim Input As New FormPelanggan()
            Input.txtKode.Text = row.Cells("kode").Value.ToString()
            Input.txtNama.Text = row.Cells("nama").Value.ToString()
            Input.txtAlamat.Text = row.Cells("alamat").Value.ToString()
            Input.txtId.Text = row.Cells("id").Value.ToString()
            Input.txtNoHp.Text = row.Cells("no_handphone").Value.ToString()
            Input.txtEmail.Text = row.Cells("email").Value.ToString()
            Input.Show()
        End If
    End Sub

    Private Sub infoGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles infoGridView.CellContentClick
        ' opsional
    End Sub
End Class
