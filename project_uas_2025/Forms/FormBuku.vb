Public Class FormBuku

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Try
            Dim DbBuku As New DbBuku()
            Dim api As New ServiceAPI()


            If String.IsNullOrEmpty(txtId.Text) Then 'kondisi jika id kosong' 
                DbBuku.insert(
                    txtKode.Text,
                    txtJudul.Text,
                    txtPenulis.Text,
                    txtTahun.Text,
                    txtPenerbit.Text,      'PENERBIT di posisi ke-5
                    txtDeskripsi.Text,     'DESKRIPSI di posisi ke-6
                    ComboGenre.Text,
                    CInt(txtHarga.Text),
                    CInt(txtStok.Text)
                )

                MessageBox.Show("Data Berhasil Ditambahkan")
                Dim prop As String = String.Join(" | ", txtKode.Text, txtJudul.Text, txtDeskripsi.Text, txtPenulis.Text, txtPenerbit.Text, "Given Keo")

                api.send("Buku", prop)

            Else
                Dim id As Integer = CInt(txtId.Text)
                Dim kode_buku As String = txtKode.Text
                Dim nama_buku As String = txtJudul.Text
                Dim pengarang As String = txtPenulis.Text
                Dim tahun_terbit As String = txtTahun.Text
                Dim penerbit As String = txtPenerbit.Text
                Dim deskripsi As String = txtDeskripsi.Text
                Dim jenis_buku As String = ComboGenre.Text
                Dim harga As Integer = 0
                Integer.TryParse(txtHarga.Text, harga)
                Dim stok As Integer = 0
                Integer.TryParse(txtStok.Text, stok)

                DbBuku.update(
                    kode_buku,
                    nama_buku,
                    pengarang,
                    tahun_terbit,
                    penerbit,
                    deskripsi,
                    jenis_buku,
                    harga,
                    stok,
                    id
                )

                MessageBox.Show("Data Berhasil Diupdate")
            End If

            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Failed to insert:" & ex.Message)

        End Try
    End Sub

    Private Sub FormBuku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtId.Visible = False
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim DbItem As New DbBuku()
        If String.IsNullOrEmpty(txtId.Text) Then 'kondisi jika id kosong' 
            MessageBox.Show("Data is not exist")
        Else
            Dim id As String = txtId.Text
            DbItem.delete(CInt(id))
            MessageBox.Show("Data has been delete succesfully")
            Hide()
        End If
    End Sub
End Class