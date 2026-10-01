'Module berfungsi untuk menyimpan variabel atau script yang dapat digunakan oleh beberapa form'
'Fungsi import untuk memanggil library untuk berkomunikasi dengan SQL SERVER'
Imports System.Data.SqlClient
Module Module1
    'SqlConnection berfungsi untuk menghubungkan aplikasi dengan database'
    'SqlCommand berfungsi untuk menjalankan perintah SQL'
    'SqlDataAdapter berfungsi untuk mengisi atau menyimpan data'
    'DataSet berfungsi untuk menyimpan data sementara'
    'SqlDataReader berfungsi untuk membaca data'
    Public conn As SqlConnection
    Public cmd As SqlCommand
    Public da As SqlDataAdapter
    Public ds As DataSet
    Public rd As SqlDataReader

    Public Sub koneksi()
        Try
            conn = New SqlConnection("Data Source=LAPTOP-F6HFJFJC\SQLEXPRESS;Initial Catalog=db_crud;Integrated Security=True;Encrypt=False")
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MessageBox.Show("Koneksi Database Gagal!" & vbCrLf & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Module
