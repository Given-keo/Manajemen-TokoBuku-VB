Imports Npgsql

Public Class DbRecord
    Dim npgsqlConn As NpgsqlConnection
    Dim cmd As NpgsqlCommand
    Dim rs As NpgsqlDataReader
    Dim adp As NpgsqlDataAdapter
    Dim query As String

    Public Function loadAlldata() As DataTable

        query = "SELECT * FROM transactions" 'query database'
        npgsqlConn = Dbconnnection.openconnection 'pembukaan koneksi'
        cmd = New NpgsqlCommand(query, npgsqlConn) 'eksekusi query berdasarkan koneksi'
        adp = New NpgsqlDataAdapter(cmd) 'mengambil data hasil query'
        Dim table As New DataTable() 'definisi tabel penampungan'
        adp.Fill(table) 'data ditampung di table'

        Return table
    End Function

End Class
