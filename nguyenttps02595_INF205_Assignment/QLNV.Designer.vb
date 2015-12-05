<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QLNV
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtMaNV = New System.Windows.Forms.TextBox()
        Me.txtTenNV = New System.Windows.Forms.TextBox()
        Me.TxTPassNV = New System.Windows.Forms.TextBox()
        Me.TxtChucVuNV = New System.Windows.Forms.TextBox()
        Me.txtSodt = New System.Windows.Forms.TextBox()
        Me.TxTDiaChiNV = New System.Windows.Forms.TextBox()
        Me.TxtLoaiNV = New System.Windows.Forms.ComboBox()
        Me.dgvNhanVien = New System.Windows.Forms.DataGridView()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.BtnXoa = New System.Windows.Forms.Button()
        Me.BtnSua = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.Btn_Thoat = New System.Windows.Forms.Button()
        CType(Me.dgvNhanVien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã NV"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Loại NV"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Tên NV"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Mật Mã"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Số Điện Thoại"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 223)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Địa Chỉ"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 150)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Chức Vụ"
        '
        'txtMaNV
        '
        Me.txtMaNV.Location = New System.Drawing.Point(114, 9)
        Me.txtMaNV.Name = "txtMaNV"
        Me.txtMaNV.Size = New System.Drawing.Size(199, 20)
        Me.txtMaNV.TabIndex = 1
        '
        'txtTenNV
        '
        Me.txtTenNV.Location = New System.Drawing.Point(114, 77)
        Me.txtTenNV.Name = "txtTenNV"
        Me.txtTenNV.Size = New System.Drawing.Size(199, 20)
        Me.txtTenNV.TabIndex = 1
        '
        'TxTPassNV
        '
        Me.TxTPassNV.Location = New System.Drawing.Point(114, 111)
        Me.TxTPassNV.Name = "TxTPassNV"
        Me.TxTPassNV.Size = New System.Drawing.Size(199, 20)
        Me.TxTPassNV.TabIndex = 1
        '
        'TxtChucVuNV
        '
        Me.TxtChucVuNV.Location = New System.Drawing.Point(114, 147)
        Me.TxtChucVuNV.Name = "TxtChucVuNV"
        Me.TxtChucVuNV.Size = New System.Drawing.Size(199, 20)
        Me.TxtChucVuNV.TabIndex = 1
        '
        'txtSodt
        '
        Me.txtSodt.Location = New System.Drawing.Point(114, 183)
        Me.txtSodt.Name = "txtSodt"
        Me.txtSodt.Size = New System.Drawing.Size(199, 20)
        Me.txtSodt.TabIndex = 1
        '
        'TxTDiaChiNV
        '
        Me.TxTDiaChiNV.Location = New System.Drawing.Point(114, 219)
        Me.TxTDiaChiNV.Name = "TxTDiaChiNV"
        Me.TxTDiaChiNV.Size = New System.Drawing.Size(199, 20)
        Me.TxTDiaChiNV.TabIndex = 1
        '
        'TxtLoaiNV
        '
        Me.TxtLoaiNV.FormattingEnabled = True
        Me.TxtLoaiNV.Items.AddRange(New Object() {"QL", "NV"})
        Me.TxtLoaiNV.Location = New System.Drawing.Point(114, 45)
        Me.TxtLoaiNV.Name = "TxtLoaiNV"
        Me.TxtLoaiNV.Size = New System.Drawing.Size(199, 21)
        Me.TxtLoaiNV.TabIndex = 2
        '
        'dgvNhanVien
        '
        Me.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNhanVien.Location = New System.Drawing.Point(319, 12)
        Me.dgvNhanVien.Name = "dgvNhanVien"
        Me.dgvNhanVien.Size = New System.Drawing.Size(426, 226)
        Me.dgvNhanVien.TabIndex = 3
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(25, 255)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 23)
        Me.btnThem.TabIndex = 4
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'BtnXoa
        '
        Me.BtnXoa.Location = New System.Drawing.Point(106, 255)
        Me.BtnXoa.Name = "BtnXoa"
        Me.BtnXoa.Size = New System.Drawing.Size(75, 23)
        Me.BtnXoa.TabIndex = 4
        Me.BtnXoa.Text = "Xóa"
        Me.BtnXoa.UseVisualStyleBackColor = True
        '
        'BtnSua
        '
        Me.BtnSua.Location = New System.Drawing.Point(187, 255)
        Me.BtnSua.Name = "BtnSua"
        Me.BtnSua.Size = New System.Drawing.Size(75, 23)
        Me.BtnSua.TabIndex = 4
        Me.BtnSua.Text = "Sửa"
        Me.BtnSua.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(268, 255)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(75, 23)
        Me.BtnClear.TabIndex = 4
        Me.BtnClear.Text = "Nhập lại"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'Btn_Thoat
        '
        Me.Btn_Thoat.Location = New System.Drawing.Point(349, 255)
        Me.Btn_Thoat.Name = "Btn_Thoat"
        Me.Btn_Thoat.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Thoat.TabIndex = 4
        Me.Btn_Thoat.Text = "Thoát"
        Me.Btn_Thoat.UseVisualStyleBackColor = True
        '
        'QLNV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 298)
        Me.Controls.Add(Me.Btn_Thoat)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnSua)
        Me.Controls.Add(Me.BtnXoa)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.dgvNhanVien)
        Me.Controls.Add(Me.TxtLoaiNV)
        Me.Controls.Add(Me.TxTDiaChiNV)
        Me.Controls.Add(Me.txtSodt)
        Me.Controls.Add(Me.TxtChucVuNV)
        Me.Controls.Add(Me.TxTPassNV)
        Me.Controls.Add(Me.txtTenNV)
        Me.Controls.Add(Me.txtMaNV)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "QLNV"
        Me.Text = "Quản Lý Nhân Viên"
        CType(Me.dgvNhanVien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtMaNV As System.Windows.Forms.TextBox
    Friend WithEvents txtTenNV As System.Windows.Forms.TextBox
    Friend WithEvents TxTPassNV As System.Windows.Forms.TextBox
    Friend WithEvents TxtChucVuNV As System.Windows.Forms.TextBox
    Friend WithEvents txtSodt As System.Windows.Forms.TextBox
    Friend WithEvents TxTDiaChiNV As System.Windows.Forms.TextBox
    Friend WithEvents TxtLoaiNV As System.Windows.Forms.ComboBox
    Friend WithEvents dgvNhanVien As System.Windows.Forms.DataGridView
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents BtnXoa As System.Windows.Forms.Button
    Friend WithEvents BtnSua As System.Windows.Forms.Button
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents Btn_Thoat As System.Windows.Forms.Button

End Class
