<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnis = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.txtkelas = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.btncari = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnreport = New System.Windows.Forms.Button()
        Me.dgvdata = New System.Windows.Forms.DataGridView()
        CType(Me.dgvdata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NAMA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(39, 250)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 28)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "KELAS"
        '
        'txtnis
        '
        Me.txtnis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnis.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnis.Location = New System.Drawing.Point(39, 127)
        Me.txtnis.Name = "txtnis"
        Me.txtnis.Size = New System.Drawing.Size(272, 31)
        Me.txtnis.TabIndex = 3
        '
        'txtnama
        '
        Me.txtnama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnama.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnama.Location = New System.Drawing.Point(39, 205)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(272, 31)
        Me.txtnama.TabIndex = 4
        '
        'txtkelas
        '
        Me.txtkelas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtkelas.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkelas.Location = New System.Drawing.Point(39, 275)
        Me.txtkelas.Name = "txtkelas"
        Me.txtkelas.Size = New System.Drawing.Size(272, 31)
        Me.txtkelas.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(150, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(295, 63)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "DATA SISWA"
        '
        'btnsimpan
        '
        Me.btnsimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsimpan.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsimpan.Location = New System.Drawing.Point(341, 121)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(104, 37)
        Me.btnsimpan.TabIndex = 7
        Me.btnsimpan.Text = "SIMPAN"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'btncari
        '
        Me.btncari.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncari.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncari.Location = New System.Drawing.Point(341, 199)
        Me.btncari.Name = "btncari"
        Me.btncari.Size = New System.Drawing.Size(104, 37)
        Me.btncari.TabIndex = 8
        Me.btncari.Text = "CARI"
        Me.btncari.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(341, 269)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(104, 37)
        Me.btnclose.TabIndex = 9
        Me.btnclose.Text = "CLOSE"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnedit.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.Location = New System.Drawing.Point(461, 121)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(104, 37)
        Me.btnedit.TabIndex = 10
        Me.btnedit.Text = "EDIT"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndelete.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(461, 199)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(104, 37)
        Me.btndelete.TabIndex = 11
        Me.btndelete.Text = "DELETE"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnreport
        '
        Me.btnreport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreport.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreport.Location = New System.Drawing.Point(461, 269)
        Me.btnreport.Name = "btnreport"
        Me.btnreport.Size = New System.Drawing.Size(104, 37)
        Me.btnreport.TabIndex = 12
        Me.btnreport.Text = "REPORT"
        Me.btnreport.UseVisualStyleBackColor = True
        '
        'dgvdata
        '
        Me.dgvdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdata.Location = New System.Drawing.Point(12, 322)
        Me.dgvdata.Name = "dgvdata"
        Me.dgvdata.RowHeadersVisible = False
        Me.dgvdata.RowHeadersWidth = 51
        Me.dgvdata.RowTemplate.Height = 24
        Me.dgvdata.Size = New System.Drawing.Size(587, 188)
        Me.dgvdata.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(608, 522)
        Me.Controls.Add(Me.dgvdata)
        Me.Controls.Add(Me.btnreport)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btncari)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtkelas)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.txtnis)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplikasi CRUD"
        CType(Me.dgvdata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtnis As TextBox
    Friend WithEvents txtnama As TextBox
    Friend WithEvents txtkelas As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnsimpan As Button
    Friend WithEvents btncari As Button
    Friend WithEvents btnclose As Button
    Friend WithEvents btnedit As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents btnreport As Button
    Friend WithEvents dgvdata As DataGridView
End Class
