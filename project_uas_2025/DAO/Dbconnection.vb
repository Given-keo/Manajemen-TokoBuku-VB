Imports Npgsql

Public Class Dbconnnection
    Private Shared host As String = "host=Localhost;port=5432;"
    Private Shared credentials As String = "username=postgres;password=;"
    Private Shared dbDetail As String = "database=postgres"
    Private Shared endpoint As String = host & credentials & dbDetail
    Private Shared connectionDb As NpgsqlConnection
    'fungsi untuk membuka koneksi
    Public Shared Function openconnection() As NpgsqlConnection
        Try
            connectionDb = New NpgsqlConnection(endpoint)
            connectionDb.Open()
            Return connectionDb
        Catch ex As Exception
            MessageBox.Show("koneksi Gagal: " & ex.Message)
            Return Nothing
        End Try
    End Function
    'fungsi untuk menutup koneksi
    Public Shared Sub CloseConnection()
        If connectionDb IsNot Nothing AndAlso connectionDb.State = ConnectionState.Open Then
            connectionDb.Close()
        End If
    End Sub
End Class
