Imports iTextSharp.text
Imports System.Runtime.CompilerServices.RuntimeHelpers

Public Class FormPelanggan
    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click

        Try
            Dim DbPelanggan As New DbPelanggan()
            Dim api As New ServiceAPI()
            Dim kode As String = txtKode.Text
            Dim nama As String = txtNama.Text
            Dim alamat As String = txtAlamat.Text
            Dim no_handphone As String = txtNoHp.Text
            Dim email As String = txtEmail.Text

            If String.IsNullOrEmpty(txtId.Text) Then 'kondisi jika id kosong' 
                DbPelanggan.insert(kode, nama, alamat, no_handphone, email)
                MessageBox.Show("Data Berhasil Ditambahkan")
                Dim prop As String = String.Join(" | ", txtKode.Text, txtNama.Text, txtAlamat.Text, txtNoHp.Text, txtEmail.Text, "1124160177")

                api.send("Pembeli", prop)

            Else
                Dim id As String = txtId.Text
                DbPelanggan.update(kode, nama, alamat, no_handphone, email, CInt(id))
                MessageBox.Show("Data Berhasil Diupdate")
            End If

            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Failed to insert:" & ex.Message)

        End Try
    End Sub

    Private Sub Input_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtId.Visible = False
        'If String.IsNullOrEmpty(txtId.Text) Then 'kondisi jika id kosong' 
        '    BtnDelete.Hide()
        'Else
        '    BtnDelete.Show()
        'End If
    End Sub



    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim DbItem As New DbPelanggan()
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