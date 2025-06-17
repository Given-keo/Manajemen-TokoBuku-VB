Public Class Form1

    Private Sub LoadMenu(control As UserControl)
        PanelContent.Controls.Clear()
        control.Dock = DockStyle.Fill
        PanelContent.Controls.Add(control)
    End Sub

    Private Sub ManajemenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManajemenToolStripMenuItem.Click
        LoadMenu(New DaftarBuku)
    End Sub

    Private Sub ManajemenKategoriToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManajemenKategoriToolStripMenuItem.Click
        LoadMenu(New DaftarPelanggan)
    End Sub

    Private Sub TransaksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransaksiToolStripMenuItem.Click
        LoadMenu(New DaftarTransaksi)
    End Sub

    Private Sub LaporanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanToolStripMenuItem.Click
        LoadMenu(New ReportData)
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        LoadMenu(New homeControl)
    End Sub

End Class
