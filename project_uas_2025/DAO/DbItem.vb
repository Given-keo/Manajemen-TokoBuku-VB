Imports Npgsql

Public Class DbItem
    Dim npgsqlConn As NpgsqlConnection
    Dim cmd As NpgsqlCommand
    Dim rs As NpgsqlDataReader
    Dim adp As NpgsqlDataAdapter
    Dim query As String

    Public Function loadAlldata() As DataTable
        query = "SELECT * FROM buku WHERE isdelete IS NULL"
        npgsqlConn = Dbconnnection.openconnection()
        cmd = New NpgsqlCommand(query, npgsqlConn)
        adp = New NpgsqlDataAdapter(cmd)
        Dim table As New DataTable()
        adp.Fill(table)
        Return table
    End Function

    Public Sub UpdateStok(kodeBuku As String, jumlahDibeli As Integer)
        Dim conn As NpgsqlConnection = Dbconnnection.openconnection()
        Dim cmd As New NpgsqlCommand("UPDATE buku SET stok = stok - @jumlah, modify_on = NOW() WHERE kode_buku = @kode", conn)
        cmd.Parameters.AddWithValue("@jumlah", jumlahDibeli)
        cmd.Parameters.AddWithValue("@kode", kodeBuku)
        cmd.ExecuteNonQuery()
    End Sub

    Public Sub InsertTransaction(kodeBuku As String, jumlah As Integer, total As Decimal, idPembeli As Integer, createdBy As Integer)
        Dim conn As NpgsqlConnection = Dbconnnection.openconnection()
        Dim cmd As New NpgsqlCommand("SELECT transaksi(@kode_buku, @id_pembeli, @jumlah, @created_by)", conn)
        cmd.Parameters.AddWithValue("@kode_buku", kodeBuku)
        cmd.Parameters.AddWithValue("@id_pembeli", idPembeli)
        cmd.Parameters.AddWithValue("@jumlah", jumlah)
        cmd.Parameters.AddWithValue("@created_by", createdBy)

        cmd.ExecuteNonQuery()
    End Sub


End Class
