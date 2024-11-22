Imports System.Diagnostics

Public Class Form1
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' Atur View ListView ke Details
        ListView1.View = View.Details

        ' Tambah kolom ke ListView
        ListView1.Columns.Add("Process Name", 200)
        ListView1.Columns.Add("Process ID", 100)

        ' Panggil fungsi untuk memuat proses
        LoadProcesses()
    End Sub

    Private Sub LoadProcesses()
        ' Kosongkan ListView sebelum mengisi
        ListView1.Items.Clear()

        ' Ambil semua proses yang sedang berjalan
        Dim processes() As Process = Process.GetProcesses()

        ' Tambahkan setiap proses ke ListView
        For Each proc As Process In processes
            Dim item As New ListViewItem(proc.ProcessName)
            item.SubItems.Add(proc.Id.ToString())
            ListView1.Items.Add(item)
        Next
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRefresh.Click
        ' Panggil fungsi untuk memuat proses saat tombol refresh diklik
        LoadProcesses()
    End Sub
End Class