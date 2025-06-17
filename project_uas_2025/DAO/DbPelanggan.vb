Imports Npgsql

Public Class DbPelanggan
    Dim npgsqlConn As NpgsqlConnection
    Dim cmd As NpgsqlCommand
    Dim rs As NpgsqlDataReader
    Dim adp As NpgsqlDataAdapter
    Dim query As String

    Public Function searchCustomers(titleKeyword As String) As DataTable
        npgsqlConn = Dbconnnection.openconnection()
        query = "SELECT * FROM pembeli " &
                "WHERE nama ILIKE @searchTerm " &
                "AND is_deleted IS NULL " &
                "ORDER BY kode"
        cmd = New NpgsqlCommand(query, npgsqlConn)
        adp = New NpgsqlDataAdapter(cmd) 'mengambil data hasil query'
        Dim resultTable As New DataTable()
        cmd.Parameters.AddWithValue("@searchTerm", "%" & titleKeyword.ToLower() & "%")
        adp.Fill(resultTable)
        Return resultTable
    End Function
    Friend Function getAllCustDetail() As NpgsqlDataReader
        Try
            npgsqlConn = Dbconnnection.openconnection()
            query = "SELECT * FROM pembeli where is_deleted is NULL order by kode"
            cmd = New NpgsqlCommand(query, npgsqlConn)
            rs = cmd.ExecuteReader()
            Return rs
        Catch ex As Exception
            MessageBox.Show("Gagal mengambil data: " & ex.Message)
            Return rs
        End Try
    End Function
    Friend Function getCustDetail(nama As String) As NpgsqlDataReader
        Try
            npgsqlConn = Dbconnnection.openconnection()
            query = "SELECT * FROM pembeli where is_deleted is NULL AND nama = @nama order by kode"
            cmd = New NpgsqlCommand(query, npgsqlConn)
            cmd.Parameters.AddWithValue("@nama", nama)
            rs = cmd.ExecuteReader()
            Return rs
        Catch ex As Exception
            MessageBox.Show("Gagal mengambil data: " & ex.Message)
            Return rs
        End Try
    End Function
    Public Sub clearConnection(activeRs As NpgsqlDataReader)
        If activeRs.IsClosed = False Then
            activeRs.Close()
        End If
        Dbconnnection.CloseConnection()
    End Sub
    Public Function loadAlldata() As DataTable

        query = "SELECT * FROM pembeli where is_deleted is null order by kode" 'query database'
        npgsqlConn = Dbconnnection.openconnection 'pembukaan koneksi'
        cmd = New NpgsqlCommand(query, npgsqlConn) 'eksekusi query berdasarkan koneksi'
        adp = New NpgsqlDataAdapter(cmd) 'mengambil data hasil query'
        Dim table As New DataTable() 'definisi tabel penampungan'
        adp.Fill(table) 'data ditampung di table'

        Return table
    End Function
    Public Function insert(kode As String, nama As String, alamat As String, no_handphone As String,
                           email As String) As Integer 'memberikan value'
        npgsqlConn = Dbconnnection.openconnection()
        query = "insert into pembeli (kode, nama, alamat, no_handphone, email, created_by, created_on)"
        query = query & " Values (@kode, @nama, @alamat, @no_handphone, @email, @created_by, @created_on)" 'query insert'
        cmd = New NpgsqlCommand(query, npgsqlConn)
        cmd.Parameters.AddWithValue("@kode", kode)
        cmd.Parameters.AddWithValue("@nama", nama)
        cmd.Parameters.AddWithValue("@alamat", alamat)
        cmd.Parameters.AddWithValue("@no_handphone", no_handphone)
        cmd.Parameters.AddWithValue("@email", email)
        cmd.Parameters.AddWithValue("@created_by", 1)
        cmd.Parameters.AddWithValue("@created_on", Now())
        Dim result As Integer
        result = cmd.ExecuteNonQuery()
        Dbconnnection.CloseConnection()
        Return result
    End Function
    Public Function update(kode As String, nama As String, alamat As String, no_handphone As String,
                           email As String, id As Integer) As Integer
        query = "UPDATE pembeli SET kode = @kode, nama = @nama, alamat = @alamat, " &
                "no_handphone = @no_handphone, email = @email, modify_by = @modify_by, modify_on = @modify_on " &
                "WHERE id = @id"
        npgsqlConn = Dbconnnection.openconnection() 'pembukaan koneksi'
        cmd = New NpgsqlCommand(query, npgsqlConn)
        cmd.Parameters.AddWithValue("@kode", kode)
        cmd.Parameters.AddWithValue("@nama", nama)
        cmd.Parameters.AddWithValue("@alamat", alamat)
        cmd.Parameters.AddWithValue("@no_handphone", no_handphone)
        cmd.Parameters.AddWithValue("@email", email)
        cmd.Parameters.AddWithValue("@modify_by", 1)
        cmd.Parameters.AddWithValue("@modify_on", Now())
        cmd.Parameters.AddWithValue("@id", id)
        Dim result As Integer
        result = cmd.ExecuteNonQuery()
        Dbconnnection.CloseConnection()
        Return result
    End Function
    Public Function delete(id As Integer) As Integer
        query = "UPDATE pembeli set is_deleted = @flagYes "
        query = query & "where id = @id"
        npgsqlConn = Dbconnnection.openconnection()
        cmd = New NpgsqlCommand(query, npgsqlConn)
        cmd.Parameters.AddWithValue("@flagYes", 1)
        cmd.Parameters.AddWithValue("@id", id)
        Dim result As Integer
        result = cmd.ExecuteNonQuery()
        Dbconnnection.CloseConnection()
        Return result
    End Function
    Public Function GetIdPembeliByNama(nama As String) As Integer
        Dim npgsqlConn As NpgsqlConnection = Dbconnnection.openconnection()
        Dim query As String = "SELECT id FROM pembeli WHERE nama = @nama"
        Dim cmd As New NpgsqlCommand(query, npgsqlConn)
        cmd.Parameters.AddWithValue("@nama", nama)
        Dim id As Integer = -1
        Dim rs As NpgsqlDataReader = cmd.ExecuteReader()
        If rs.Read() Then
            id = rs.GetInt32(0)
        End If
        rs.Close()
        Dbconnnection.CloseConnection()
        Return id
    End Function
    Public Function generateDataReportPembeli(startDate As Date, endDate As Date) As DataTable
        Dim conn = Dbconnnection.openconnection()
        Dim query As String = "SELECT id, kode, nama, alamat, no_handphone, email, created_on " &
                          "FROM pembeli " &
                          "WHERE created_on BETWEEN @dateStart AND @dateEnd AND (is_deleted IS NULL OR is_deleted = 0) " &
                          "ORDER BY created_on DESC"
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
