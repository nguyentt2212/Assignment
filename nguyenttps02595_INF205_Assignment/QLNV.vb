Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class QLNV
    Dim database As New DataTable

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Câu truy vấn để get dữ liệu
        Dim NhanVien As SqlDataAdapter = New SqlDataAdapter("select * from NhanVien", connect)
        'Kết nối mở ra
        connect.Open()
        'Đổ dữ liệu vào đối tượng database
        NhanVien.Fill(database)
        'Hiển thị dữ liệu ra Datagridview
        dgvNhanVien.DataSource = database.DefaultView
        connect.Close()
    End Sub

    Private Sub dgvNhanVien_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvNhanVien.CellContentClick
        Dim index As Integer = dgvNhanVien.CurrentCell.RowIndex
        txtMaNV.Text = dgvNhanVien.Item(0, index).Value
        txtLoaiNV.Text = dgvNhanVien.Item(1, index).Value
        txtTenNV.Text = dgvNhanVien.Item(2, index).Value
        txtPassNV.Text = dgvNhanVien.Item(3, index).Value
        txtChucVuNV.Text = dgvNhanVien.Item(4, index).Value
        txtSodt.Text = dgvNhanVien.Item(5, index).Value
        txtDiaChiNV.Text = dgvNhanVien.Item(6, index).Value
    End Sub
    
    Private Sub Btn_Thoat_Click(sender As Object, e As EventArgs) Handles Btn_Thoat.Click
        Me.Close()
        database.Clear()
        connect.Close()
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        'Tạo query câu truy vấn Insert into
        Dim Them As String = "insert into NhanVien values (@Ma_NV,@Loai_NV,@Ten_NV,@MatKhau_NV,@ChucVu_NV,@SDT_NV,@DiaChi_NV)"
        'Tạo đối tượng để thực thi câu truy vấn với DB ONline
        Dim ExecuteQuery1 As New SqlCommand(Them, connect)
        'Kết nối mở ra
        connect.Open()

        Try
            'Truyền giá trị trong các ô textbox cho các biến tương ứng
            ExecuteQuery1.Parameters.AddWithValue("@Ma_NV", txtMaNV.Text)
            ExecuteQuery1.Parameters.AddWithValue("@Loai_NV", TxtLoaiNV.Text)
            ExecuteQuery1.Parameters.AddWithValue("@Ten_NV", txtTenNV.Text)
            ExecuteQuery1.Parameters.AddWithValue("@MatKhau_NV", TxTPassNV.Text)
            ExecuteQuery1.Parameters.AddWithValue("@ChucVu_NV", TxtChucVuNV.Text)
            ExecuteQuery1.Parameters.AddWithValue("@SDT_NV", txtSodt.Text)
            ExecuteQuery1.Parameters.AddWithValue("@DiaChi_NV", TxTDiaChiNV.Text)



            MessageBox.Show("Thêm thành công")
            ExecuteQuery1.ExecuteNonQuery() 'Exucute là ghi dữ liệu vào Database
        Catch ex As Exception
            'Nếu thêm không được thì hiển thị thông báo
            MessageBox.Show("Không thêm được!")

        End Try
        'Load lại bản
        Dim Query3 As SqlDataAdapter = New SqlDataAdapter("select * from NhanVien", connect)
        database.Clear()
        Query3.Fill(database)
        dgvNhanVien.DataSource = database.DefaultView
        connect.Close()
    End Sub

    
    Private Sub BtnSua_Click(sender As Object, e As EventArgs) Handles BtnSua.Click
        connect.Open()
        Dim Stradd1 As String = "Update NhanVien set Ma_NV = @Ma_NV, Loai_NV = @Loai_NV, Ten_NV = @Ten_NV, MatKhau_NV = @MatKhau_NV, ChucVu_NV = @ChucVu_NV, SDT_NV = @SDT_NV, DiaChi_NV = @DiaChi_NV where Ma_NV = @Ma_NV"
        Dim com As New SqlCommand(Stradd1, connect)
        Try
            com.Parameters.AddWithValue("@Ma_NV", txtMaNV.Text)
            com.Parameters.AddWithValue("@Loai_NV", TxtLoaiNV.Text)
            com.Parameters.AddWithValue("@Ten_NV", txtTenNV.Text)
            com.Parameters.AddWithValue("@MatKhau_NV", TxTPassNV.Text)
            com.Parameters.AddWithValue("@ChucVu_NV", TxtChucVuNV.Text)
            com.Parameters.AddWithValue("@SDT_NV", txtSodt.Text)
            com.Parameters.AddWithValue("@DiaChi_NV", TxTDiaChiNV.Text)
            com.ExecuteNonQuery()
            connect.Close()
            MessageBox.Show("Sửa Thành Công")
        Catch ex As Exception
            MessageBox.Show("Sửa Không Thành Công")
        End Try
        dgvNhanVien.DataSource = database
        dgvNhanVien.DataSource = Nothing
        Loaddata()
    End Sub

    Private Sub Loaddata()

        Dim Query1 As SqlDataAdapter = New SqlDataAdapter("select * from NhanVien", connect)

        connect.Open()
        Query1.Fill(database)
        dgvNhanVien.DataSource = database.DefaultView

        connect.Close()
    End Sub


    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        txtMaNV.Clear()
        'txtLoaiNV.Clear()
        txtTenNV.Clear()
        TxTPassNV.Clear()
        TxtChucVuNV.Clear()
        txtSodt.Clear()
        TxTDiaChiNV.Clear()
    End Sub

    Private Sub BtnXoa_Click(sender As Object, e As EventArgs) Handles BtnXoa.Click
        connect.Open()
        Dim xoadl As String = "Delete from NhanVien Where Ma_NV = @Ma_NV"
        Dim lenh As New SqlCommand(xoadl, connect)
        Try
            lenh.Parameters.AddWithValue("@Ma_NV", txtMaNV.Text)
            lenh.ExecuteNonQuery()
            connect.Close()
            MessageBox.Show("Xóa Thành Công")
        Catch ex As Exception
            MessageBox.Show("Xoá không thành công")
        End Try
        database.Clear()
        dgvNhanVien.DataSource = database
        dgvNhanVien.DataSource = Nothing
        Loaddata()
    End Sub
End Class
