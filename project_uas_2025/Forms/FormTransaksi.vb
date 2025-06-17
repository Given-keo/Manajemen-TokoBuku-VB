Imports System.Runtime.CompilerServices.RuntimeHelpers
Imports Npgsql

Public Class FormTransaksi
    Private Sub FormTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextIdTransaksi.Visible = False
        loadItemsBuku()
        loadItemsPelanggan()
        generateCode()
    End Sub

    Private Sub generateCode()
        Dim datetime As DateTime = DateTime.Now
        Dim code As String = datetime.ToString("yyyyMMddHHmmss")
        txtKodeTransaksi.Text = code
    End Sub

    Private Sub loadItemsBuku()
        ComboBukuDtl.Items.Clear()
        ComboBukuDtl.Items.Add("")  ' Tambahkan pilihan kosong di paling atas
        Dim DbBuku As New DbBuku()
        Dim rs As NpgsqlDataReader = DbBuku.getAllBooksDetail()
        While rs.Read()
            ComboBukuDtl.Items.Add(rs.GetString(2))
        End While
        DbBuku.clearConnection(rs)
        ComboBukuDtl.SelectedIndex = 0  ' Set ke pilihan kosong
    End Sub

    Private Sub loadItemsPelanggan()
        ComboPelangganDtl.Items.Clear()
        ComboPelangganDtl.Items.Add("")  ' Tambahkan pilihan kosong di paling atas
        Dim DbPelanggan As New DbPelanggan()
        Dim rs As NpgsqlDataReader = DbPelanggan.getAllCustDetail()
        While rs.Read()
            ComboPelangganDtl.Items.Add(rs.GetString(2))
        End While
        DbPelanggan.clearConnection(rs)
        ComboPelangganDtl.SelectedIndex = 0  ' Set ke pilihan kosong
    End Sub

    Public Sub populateBuku()
        If ComboBukuDtl.SelectedIndex <= 0 Or ComboBukuDtl.SelectedItem Is Nothing Or ComboBukuDtl.SelectedItem.ToString() = "" Then
            txtDescBuku.Text = ""
            txtKodeBuku.Text = ""
            txtSubTotal.Text = ""
            txtPajak.Text = ""
            txtTotal.Text = ""
            Return
        End If

        Dim namaBuku As String = ComboBukuDtl.SelectedItem.ToString().Trim()
        Dim DbBuku As New DbBuku()
        Dim rsItem As NpgsqlDataReader = DbBuku.getBookDetail(namaBuku)
        If rsItem.Read() Then
            txtDescBuku.Text = rsItem.GetString(3) & Environment.NewLine
            txtDescBuku.Text &= "Pengarang: " & rsItem.GetString(4) & Environment.NewLine
            txtDescBuku.Text &= "Tahun Terbit: " & rsItem.GetString(5)
            txtKodeBuku.Text = rsItem.GetString(1)
            Dim harga As Double = rsItem.GetDouble(8)
            Dim jumlah As Integer
            If Not Integer.TryParse(txtJumlah.Text, jumlah) OrElse jumlah < 1 Then jumlah = 1
            Dim subtotal As Double = harga * jumlah
            txtSubTotal.Text = subtotal.ToString()

            'Hitung pajak & total
            Dim pajak As Double = subtotal * 0.1
            txtPajak.Text = pajak.ToString()
            txtTotal.Text = (subtotal + pajak).ToString()
        Else
            txtDescBuku.Text = ""
            txtKodeBuku.Text = ""
            txtSubTotal.Text = ""
            txtPajak.Text = ""
            txtTotal.Text = ""
        End If
        DbBuku.clearConnection(rsItem)
    End Sub

    Public Sub populatePelanggan()
        If ComboPelangganDtl.SelectedIndex <= 0 Or ComboPelangganDtl.SelectedItem Is Nothing Or ComboPelangganDtl.SelectedItem.ToString() = "" Then
            txtDescPelanggan.Text = ""
            Return
        End If

        Dim namaPembeli As String = ComboPelangganDtl.SelectedItem.ToString().Trim()
        Dim DbPelanggan As New DbPelanggan()
        Dim rsItem As NpgsqlDataReader = DbPelanggan.getCustDetail(namaPembeli)
        If rsItem.Read() Then
            txtDescPelanggan.Text = "Email: " & rsItem.GetString(3) & Environment.NewLine
            txtDescPelanggan.Text &= "Nomor Handphone: " & rsItem.GetString(5)
        Else
            txtDescPelanggan.Text = ""
        End If
        DbPelanggan.clearConnection(rsItem)
    End Sub

    Private Sub ComboBukuDtl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBukuDtl.SelectedIndexChanged
        populateBuku()
    End Sub

    Private Sub ComboPelangganDtl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboPelangganDtl.SelectedIndexChanged
        populatePelanggan()
    End Sub

    Private Sub txtJumlah_TextChanged(sender As Object, e As EventArgs) Handles txtJumlah.TextChanged
        If ComboBukuDtl.SelectedIndex >= 0 Then
            populateBuku()
        End If
    End Sub

    Private Sub txtSubTotal_TextChanged(sender As Object, e As EventArgs) Handles txtSubTotal.TextChanged
        Dim subtotal As Double = 0
        Double.TryParse(txtSubTotal.Text, subtotal)
        Dim pajak As Double = subtotal * 0.1
        txtPajak.Text = pajak.ToString()
        txtTotal.Text = (subtotal + pajak).ToString()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Try
            '--- Ambil input dari form ---
            Dim namaBuku As String = ComboBukuDtl.SelectedItem.ToString()
            Dim namaPelanggan As String = ComboPelangganDtl.SelectedItem.ToString()
            Dim kode_transaksi As String = txtKodeTransaksi.Text
            Dim jumlah_buku As Integer
            Integer.TryParse(txtJumlah.Text, jumlah_buku)
            Dim sub_total As Integer
            Integer.TryParse(txtSubTotal.Text, sub_total)
            Dim pajak As Integer
            Integer.TryParse(txtPajak.Text, pajak)
            Dim total As Integer
            Integer.TryParse(txtTotal.Text, total)

            '--- Ambil ID buku dan pembeli ---
            Dim id_buku As Integer = (New DbBuku).GetIdBukuByNama(namaBuku)
            Dim id_pembeli As Integer = (New DbPelanggan).GetIdPembeliByNama(namaPelanggan)

            If id_buku = -1 Or id_pembeli = -1 Then
                MessageBox.Show("Data buku atau pembeli tidak valid.")
                Exit Sub
            End If

            '--- Validasi jumlah buku ---
            If jumlah_buku <= 0 Then
                MessageBox.Show("Jumlah buku harus lebih dari 0")
                Exit Sub
            End If

            '--- Validasi stok buku ---
            Dim dbBuku As New DbBuku()
            Dim stokTersedia As Integer = dbBuku.GetStokBukuById(id_buku)
            If stokTersedia < jumlah_buku Then
                MessageBox.Show("Stok buku tidak cukup. Stok tersedia: " & stokTersedia & ", jumlah yang diminta: " & jumlah_buku)
                Exit Sub
            End If

            '--- Simpan transaksi ---
            Dim hasilInsert As Integer = (New DbTransaksi).insertTransaksi(id_pembeli, id_buku, jumlah_buku, sub_total, pajak, total, kode_transaksi)

            If hasilInsert > 0 Then
                '--- Update stok buku ---
                Dim hasilUpdate As Integer = dbBuku.UpdateStokBuku(id_buku, jumlah_buku)
                If hasilUpdate > 0 Then
                    MessageBox.Show("Transaksi berhasil dan stok buku terupdate.")

                    '----------------------'
                    ' Kirim ke ServiceAPI  '
                    '----------------------'
                    Try
                        Dim api As New ServiceAPI()
                        ' Format data yang akan dikirim (bebas, contoh pakai | dipisah) '
                        Dim prop As String = String.Join(" | ", kode_transaksi, namaBuku, namaPelanggan, jumlah_buku.ToString, sub_total.ToString, pajak.ToString, total.ToString, Now.ToString("yyyy-MM-dd HH:mm:ss"))
                        api.send("Transaksi", prop)
                    Catch exApi As Exception
                        MessageBox.Show("Transaksi tersimpan, tapi gagal kirim notifikasi API: " & exApi.Message)
                    End Try
                Else
                    MessageBox.Show("Transaksi berhasil, tapi stok buku gagal diupdate (mungkin stok kurang).")
                End If
            Else
                MessageBox.Show("Transaksi gagal disimpan.")
            End If
        Catch ex As Exception
            MessageBox.Show("Gagal melakukan transaksi: " & ex.Message)
        End Try
    End Sub

    Private Sub TextIdTransaksi_TextChanged(sender As Object, e As EventArgs) Handles TextIdTransaksi.TextChanged
        ' Kosong, sesuai kode asli
    End Sub
End Class