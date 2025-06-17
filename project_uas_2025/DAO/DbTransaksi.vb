Imports Npgsql

Public Class DbTransaksi
    Public Function insertTransaksi(
    id_pembeli As Integer,
    id_buku As Integer,
    jumlah_buku As Integer,
    sub_total As Integer,
    pajak As Integer,
    total As Integer,
    kode_transaksi As String
) As Integer

        Dim npgsqlConn As NpgsqlConnection = Dbconnnection.openconnection()
        Dim query As String = "INSERT INTO transaksi (id_pembeli, id_buku, jumlah_buku, sub_total, pajak, total, kode_transaksi, created_by, created_on, is_deleted) " &
                          "VALUES (@id_pembeli, @id_buku, @jumlah_buku, @sub_total, @pajak, @total, @kode_transaksi, @created_by, @created_on, @is_deleted)"
        Dim cmd As New NpgsqlCommand(query, npgsqlConn)
        cmd.Parameters.AddWithValue("@id_pembeli", id_pembeli)
        cmd.Parameters.AddWithValue("@id_buku", id_buku)
        cmd.Parameters.AddWithValue("@jumlah_buku", jumlah_buku)
        cmd.Parameters.AddWithValue("@sub_total", sub_total)
        cmd.Parameters.AddWithValue("@pajak", pajak)
        cmd.Parameters.AddWithValue("@total", total)
        cmd.Parameters.AddWithValue("@kode_transaksi", kode_transaksi)
        cmd.Parameters.AddWithValue("@created_by", 1) ' Ganti dengan user login jika ada sistem user
        cmd.Parameters.AddWithValue("@created_on", Now())
        cmd.Parameters.AddWithValue("@is_deleted", 0) ' Default aktif

        Dim result As Integer
        result = cmd.ExecuteNonQuery()
        Dbconnnection.CloseConnection()
        Return result

    End Function
    Public Function loadAlldata() As DataTable
        Dim dt As New DataTable
        Dim conn = Dbconnnection.openconnection()
        Dim query As String = "
        SELECT
            t.id,
            t.kode_transaksi,
            t.jumlah_buku,
            t.sub_total,
            t.pajak,
            t.total,
            t.created_on,
            t.is_deleted,
            p.id AS id_pembeli,
            p.nama AS nama_pembeli,
            b.id AS id_buku,
            b.nama_buku,
            b.kode_buku,
            p.kode AS kode_pembeli
        FROM
            transaksi t
            INNER JOIN pembeli p ON t.id_pembeli = p.id
            INNER JOIN buku b ON t.id_buku = b.id
        WHERE
            t.is_deleted = 0
        ORDER BY
            t.created_on DESC;
    "
        Dim da As New NpgsqlDataAdapter(query, conn)
        da.Fill(dt)
        Dbconnnection.CloseConnection()
        Return dt
    End Function
    Public Function SearchTransaksi(searchTerm As String) As DataTable
        Dim dt As New DataTable
        Dim conn = Dbconnnection.openconnection()
        Dim query As String = "
        SELECT
            t.id,
            t.kode_transaksi,
            t.jumlah_buku,
            t.sub_total,
            t.pajak,
            t.total,
            t.created_on,
            t.is_deleted,
            p.id AS id_pembeli,
            p.nama AS nama_pembeli,
            b.id AS id_buku,
            b.nama_buku,
            b.kode_buku,
            p.kode AS kode_pembeli
        FROM
            transaksi t
            INNER JOIN pembeli p ON t.id_pembeli = p.id
            INNER JOIN buku b ON t.id_buku = b.id
        WHERE
            t.is_deleted = 0
            AND (t.kode_transaksi ILIKE @search OR p.nama ILIKE @search OR b.nama_buku ILIKE @search)
        ORDER BY
            t.created_on DESC;
    "
        Dim da As New NpgsqlDataAdapter(query, conn)
        da.SelectCommand.Parameters.AddWithValue("@search", "%" & searchTerm & "%")
        da.Fill(dt)
        Dbconnnection.CloseConnection()
        Return dt
    End Function
    Public Function generateDataReportTransaksi(startDate As Date, endDate As Date) As DataTable
        Dim conn = Dbconnnection.openconnection()
        Dim query As String = "SELECT t.kode_transaksi, t.jumlah_buku, t.sub_total, t.pajak, t.total, t.created_on, " &
                          "p.kode AS kode_pembeli, p.nama AS nama_pembeli, " &
                          "b.kode_buku, b.nama_buku " &
                          "FROM transaksi t " &
                          "INNER JOIN pembeli p ON t.id_pembeli = p.id " &
                          "INNER JOIN buku b ON t.id_buku = b.id " &
                          "WHERE t.created_on BETWEEN @dateStart AND @dateEnd AND t.is_deleted = 0 " &
                          "ORDER BY t.created_on DESC"
        Dim cmd As New NpgsqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@dateStart", startDate)
        cmd.Parameters.AddWithValue("@dateEnd", endDate.AddDays(1))
        Dim adapter As New NpgsqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        Dbconnnection.CloseConnection()
        Return table
    End Function

End Class
