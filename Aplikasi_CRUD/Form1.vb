Imports System.Data.SqlClient
Imports System.Resources
Public Class Form1


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btncari.Click
        If txtnis.Text.Trim() = "" Then
            MessageBox.Show("Masukkan NIS yang ingin dicari!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtnis.Focus()
            Exit Sub
        End If

        Try
            koneksi()
            Dim sql As String = "SELECT NIS, Nama, Kelas FROM tb_crud WHERE NIS = @nis"
            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@nis", txtnis.Text.Trim())
            rd = cmd.ExecuteReader
            If rd.Read() Then
                txtnama.Text = rd("Nama").ToString()
                txtkelas.Text = rd("Kelas").ToString()
            Else
                MessageBox.Show("Data siswa tidak ditemukan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtnama.Clear()
                txtkelas.Clear()
                rd.Close()
            End If
            rd.Close()

        Catch ex As Exception
            MessageBox.Show("Pencarian Gagal!" & vbCrLf & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Dim jawab As DialogResult = MessageBox.Show("Apakah anda yakin ingin keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If jawab = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
    End Sub

    Private Sub TampilData()
        Try
            koneksi()
            da = New SqlDataAdapter("SELECT NIS, Nama, Kelas FROM tb_crud order by NIS", conn)
            ds = New DataSet()
            da.Fill(ds, "tb_crud")
            dgvdata.DataSource = ds.Tables("tb_crud")
            dgvdata.Columns("NIS").HeaderText = "Nis"
            dgvdata.Columns("Nama").HeaderText = "Nama Siswa"
            dgvdata.Columns("Kelas").HeaderText = "Kelas Siswa"
            dgvdata.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        Catch ex As Exception
            MessageBox.Show("Gagal Menampilkan Data!" & vbCrLf & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn IsNot Nothing AndAlso
                conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub bersihkan()
        txtnama.Clear()
        txtnis.Clear()
        txtkelas.Clear()
        txtnis.Focus()
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If txtnis.Text.Trim() = "" Then
            MessageBox.Show("NIS belum terisi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtnis.Focus()
            Exit Sub
        End If

        If txtnama.Text.Trim() = "" Then
            MessageBox.Show("Nama belum terisi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtnama.Focus()
            Exit Sub
        End If

        If txtkelas.Text.Trim() = "" Then
            MessageBox.Show("Kelas belum terisi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtkelas.Focus()
            Exit Sub
        End If

        Try
            koneksi()
            Dim cek As String = ("SELECT * FROM tb_crud WHERE NIS = @NIS")
            cmd = New SqlCommand(cek, conn)
            cmd.Parameters.AddWithValue("@NIS", txtnis.Text.Trim())

            Dim jumlah As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            If jumlah > 0 Then
                MessageBox.Show("NIS tersebut sudah terdaftar!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            'Simpan Data'
            Dim sql As String = "INSERT INTO tb_crud (NIS, Nama, Kelas)" & "VALUES(@Nis, @nama, @kelas)"
            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@NIS", txtnis.Text.Trim())
            cmd.Parameters.AddWithValue("@Nama", txtnama.Text.Trim())
            cmd.Parameters.AddWithValue("@Kelas", txtkelas.Text.Trim())
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data siswa berhasil disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            bersihkan()
        Catch ex As Exception
            MessageBox.Show("Data gagal disimpan!" & vbCrLf & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn IsNot Nothing AndAlso
                conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click

    End Sub

    Private Sub btnreport_Click(sender As Object, e As EventArgs) Handles btnreport.Click

    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        If txtnis.Text.Trim() = "" Then
            MessageBox.Show("Masukkan NIS terlebih dahulu!")
            txtnis.Focus()
            Exit Sub
        End If
        Try
            koneksi()
            Dim sql As String = "UPDATE tb_crud SET Nama = @nama, Kelas = @kelas WHERE NIS = @nis"
            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@nis", txtnis.Text.Trim())
            cmd.Parameters.AddWithValue("@nama", txtnama.Text.Trim())
            cmd.Parameters.AddWithValue("@kelas", txtkelas.Text.Trim())
            Dim hasil As Integer = cmd.ExecuteNonQuery
            If hasil > 0 Then
                MessageBox.Show("Data berhasil diperbarui", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData()
                bersihkan()
            Else
                MessageBox.Show("Data dengan NIS tersebut tidak ditemukan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Data gagal diperbarui!" & vbCrLf & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn IsNot Nothing AndAlso
                conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub
End Class
