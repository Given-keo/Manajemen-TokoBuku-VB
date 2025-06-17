Imports Npgsql

Public Class DbBuku
    Dim npgsqlConn As NpgsqlConnection
    Dim cmd As NpgsqlCommand
    Dim rs As NpgsqlDataReader
    Dim adp As NpgsqlDataAdapter
    Dim query As String
    ' Mengambil data buku berdasarkan kata kunci judul
    Public Function searchBooks(titleKeyword As String) As DataTable
        Using conn As NpgsqlConnection = Dbconnnection.openconnection()
            Dim query As String = "SELECT * FROM buku WHERE nama_buku ILIKE @searchTerm AND is_deleted IS NULL ORDER BY kode_buku"
            Using command As New NpgsqlCommand(query, conn)
                Using adapter As New NpgsqlDataAdapter(command)
                    Dim resultTable As New DataTable()
                    command.Parameters.AddWithValue("@searchTerm", "%" & titleKeyword & "%")
                    adapter.Fill(resultTable)
                    Return resultTable
                End Using
            End Using
        End Using
    End Function

    ' Menutup DataReader jika masih aktif dan menutup koneksi database
    Public Sub clearConnection(reader As NpgsqlDataReader)
        If reader IsNot Nothing AndAlso Not reader.IsClosed Then
            reader.Close()
        End If
        Dbconnnection.CloseConnection()
    End Sub

    ' Mengambil semua data buku yang belum dihapus
    Public Function loadAlldata() As DataTable
        Using conn As NpgsqlConnection = Dbconnnection.openconnection()
            Dim query As String = "SELECT * FROM buku WHERE is_deleted IS NULL ORDER BY kode_buku"
            Using command As New NpgsqlCommand(query, conn)
                Using adapter As New NpgsqlDataAdapter(command)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    Return table
                End Using
            End Using
        End Using
    End Function

    ' Mengambil detail semua buku yang belum dihapus sebagai DataReader
    Friend Function getAllBooksDetail() As NpgsqlDataReader
        Try
            Dim conn As NpgsqlConnection = Dbconnnection.openconnection()
            Dim query As String = "SELECT * FROM buku WHERE is_deleted IS NULL ORDER BY kode_buku"
            Dim command As New NpgsqlCommand(query, conn)
            Dim reader As NpgsqlDataReader = command.ExecuteReader(CommandBehavior.CloseConnection)
            Return reader
        Catch ex As Exception
            Throw New Exception("Gagal mengambil data buku: " & ex.Message)
        End Try
    End Function

    ' Mengambil detail buku berdasarkan nama buku
    Friend Function getBookDetail(nama_buku As String) As NpgsqlDataReader
        Try
            Dim conn As NpgsqlConnection = Dbconnnection.openconnection()
            Dim query As String = "SELECT * FROM buku WHERE nama_buku = @nama_buku AND is_deleted IS NULL ORDER BY kode_buku"
            Using command As New NpgsqlCommand(query, conn)
                command.Parameters.AddWithValue("@nama_buku", nama_buku)
                Dim reader As NpgsqlDataReader = command.ExecuteReader(CommandBehavior.CloseConnection)
                Return reader
            End Using
        Catch ex As Exception
            Throw New Exception("Gagal mengambil detail buku: " & ex.Message)
        End Try
    End Function

    ' Menambahkan data buku baru ke database
    Public Function insert(kode_buku As String, nama_buku As String, pengarang As String, tahun_terbit As String,
                          penerbit As String, deskripsi As String, jenis_buku As String, harga As Integer, stok As Integer) As Integer
        Using conn As NpgsqlConnection = Dbconnnection.openconnection()
            Dim query As String = "INSERT INTO buku (kode_buku, nama_buku, pengarang, tahun_terbit, penerbit, deskripsi, jenis_buku, harga, stok, created_by, created_on) " &
                                 "VALUES (@kode_buku, @nama_buku, @pengarang, @tahun_terbit, @penerbit, @deskripsi, @jenis_buku, @harga, @stok, @created_by, @created_on)"
            Using command As New NpgsqlCommand(query, conn)
                command.Parameters.AddWithValue("@kode_buku", kode_buku)
                command.Parameters.AddWithValue("@nama_buku", nama_buku)
                command.Parameters.AddWithValue("@pengarang", pengarang)
                command.Parameters.AddWithValue("@tahun_terbit", tahun_terbit)
                command.Parameters.AddWithValue("@penerbit", penerbit)
                command.Parameters.AddWithValue("@deskripsi", deskripsi)
                command.Parameters.AddWithValue("@jenis_buku", jenis_buku)
                command.Parameters.AddWithValue("@harga", harga)
                command.Parameters.AddWithValue("@stok", stok)
                command.Parameters.AddWithValue("@created_by", 1)
                command.Parameters.AddWithValue("@created_on", Now())
                Return command.ExecuteNonQuery()
            End Using
        End Using
    End Function

    ' Memperbarui data buku berdasarkan ID
    Public Function update(kode_buku As String, nama_buku As String, pengarang As String, tahun_terbit As String,
                          penerbit As String, deskripsi As String, jenis_buku As String, harga As Integer, stok As Integer, id As Integer) As Integer
        Using conn As NpgsqlConnection = Dbconnnection.openconnection()
            Dim query As String = "UPDATE buku SET kode_buku = @kode_buku, nama_buku = @nama_buku, pengarang = @pengarang, tahun_terbit = @tahun_terbit, " &
                                 "penerbit = @penerbit, deskripsi = @deskripsi, jenis_buku = @jenis_buku, harga = @harga, stok = @stok, " &
                                 "modify_by = @modify_by, modify_on = @modify_on WHERE id = @id"
            Using command As New NpgsqlCommand(query, conn)
                command.Parameters.AddWithValue("@kode_buku", kode_buku)
                command.Parameters.AddWithValue("@nama_buku", nama_buku)
                command.Parameters.AddWithValue("@pengarang", pengarang)
                command.Parameters.AddWithValue("@tahun_terbit", tahun_terbit)
                command.Parameters.AddWithValue("@penerbit", penerbit)
                command.Parameters.AddWithValue("@deskripsi", deskripsi)
                command.Parameters.AddWithValue("@jenis_buku", jenis_buku)
                command.Parameters.AddWithValue("@harga", harga)
                command.Parameters.AddWithValue("@stok", stok)
                command.Parameters.AddWithValue("@modify_by", 1)
                command.Parameters.AddWithValue("@modify_on", Now())
                command.Parameters.AddWithValue("@id", id)
                Return command.ExecuteNonQuery()
            End Using
        End Using
    End Function

    ' Menandai buku sebagai dihapus berdasarkan ID
    Public Function delete(id As Integer) As Integer
        Using conn As NpgsqlConnection = Dbconnnection.openconnection()
            Dim query As String = "UPDATE buku SET is_deleted = @flagYes WHERE id = @id"
            Using command As New NpgsqlCommand(query, conn)
                command.Parameters.AddWithValue("@flagYes", 1)
                command.Parameters.AddWithValue("@id", id)
                Return command.ExecuteNonQuery()
            End Using
        End Using
    End Function

    ' Memperbarui stok buku berdasarkan ID dan jumlah terjual
    Public Function UpdateStokBuku(id_buku As Integer, jumlah_terjual As Integer) As Integer
        Using conn As NpgsqlConnection = Dbconnnection.openconnection()
            Dim query As String = "UPDATE buku SET stok = stok - @jumlah_terjual WHERE id = @id_buku AND stok >= @jumlah_terjual"
            Using command As New NpgsqlCommand(query, conn)
                command.Parameters.AddWithValue("@jumlah_terjual", jumlah_terjual)
                command.Parameters.AddWithValue("@id_buku", id_buku)
                Return command.ExecuteNonQuery()
            End Using
        End Using
    End Function

    ' Mengambil ID buku berdasarkan nama buku
    Public Function GetIdBukuByNama(nama_buku As String) As Integer
        Using conn As NpgsqlConnection = Dbconnnection.openconnection()
            Dim query As String = "SELECT id FROM buku WHERE nama_buku = @nama_buku AND is_deleted IS NULL"
            Using command As New NpgsqlCommand(query, conn)
                command.Parameters.AddWithValue("@nama_buku", nama_buku)
                Using reader As NpgsqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        Return reader.GetInt32(0)
                    End If
                End Using
            End Using
        End Using
        Return -1
    End Function

    ' Menghasilkan laporan data buku berdasarkan rentang tanggal
    Public Function generateDataReportBuku(startDate As Date, endDate As Date) As DataTable
        Using conn As NpgsqlConnection = Dbconnnection.openconnection()
            Dim query As String = "SELECT id, kode_buku, nama_buku, pengarang, tahun_terbit, penerbit, jenis_buku, harga, stok, created_on " &
                                 "FROM buku WHERE created_on BETWEEN @dateStart AND @dateEnd AND is_deleted IS NULL " &
                                 "ORDER BY created_on DESC"
            Using command As New NpgsqlCommand(query, conn)
                command.Parameters.AddWithValue("@dateStart", startDate)
                command.Parameters.AddWithValue("@dateEnd", endDate.AddDays(1))
                Using adapter As New NpgsqlDataAdapter(command)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    Return table
                End Using
            End Using
        End Using
    End Function

End Class