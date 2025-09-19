using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manage_Furniture
{
    public partial class FrmThemGiaoDichLuong : Form
    {
        String connectionString = "Data Source=.;Initial Catalog=DBMS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        bool is_edit = false;
        public FrmThemGiaoDichLuong()
        {
            InitializeComponent();
            is_edit = false;
        }
        int MaGD;
        public FrmThemGiaoDichLuong(int MaGD)
        {
            InitializeComponent();
            is_edit = true;
            this.MaGD = MaGD;
            lblTitle.Text = "SỬA GIAO DỊCH LƯƠNG";
        }


        private void LoadNhanVienComboBox()
        {
            // Câu lệnh SQL để lấy các nhân viên đang hoạt động, sắp xếp theo tên
            string query = "SELECT MaNV, HoTen FROM NHANVIEN WHERE TrangThai = N'Đang làm việc' ORDER BY HoTen;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // Sử dụng SqlDataAdapter để dễ dàng đổ dữ liệu vào DataTable
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dtNhanVien = new DataTable();

                    // Mở kết nối và điền dữ liệu
                    conn.Open();
                    adapter.Fill(dtNhanVien);

                    // Gán dữ liệu cho ComboBox
                    cmbMaNhanVien.DataSource = dtNhanVien;       // Nguồn dữ liệu
                    cmbMaNhanVien.DisplayMember = "HoTen";       // Cột sẽ hiển thị cho người dùng
                    cmbMaNhanVien.ValueMember = "MaNV";         // Cột sẽ là giá trị thực sự khi chọn

                    // (Tùy chọn) Bỏ chọn mục đầu tiên để trông chuyên nghiệp hơn
                    cmbMaNhanVien.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cmbMaNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmThemGiaoDichLuong_Load(object sender, EventArgs e)
        {
            LoadNhanVienComboBox();
            if (is_edit)
            {
                LoadDuLieuGiaoDich();
            }
        }
        private void LoadDuLieuGiaoDich()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT MaNV, LoaiGiaoDich, SoTien, NgayGiaoDich, LyDo FROM GIAODICH_LUONG WHERE MaGiaoDich = @MaGD";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaGD", this.MaGD);
                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        // Điền thông tin vào các control
                        cmbMaNhanVien.SelectedValue = reader["MaNV"];
                        cmbLoaiGiaoDich.SelectedItem = reader["LoaiGiaoDich"].ToString();
                        txtSoTien.Text = reader["SoTien"].ToString();
                        dateNgayGiaoDich.Value = Convert.ToDateTime(reader["NgayGiaoDich"]);
                        txtLyDo.Text = reader["LyDo"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thông tin giao dịch.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu đầu vào trước
            if (cmbMaNhanVien.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(txtSoTien.Text, out decimal soTien) || soTien <= 0)
            {
                MessageBox.Show("Số tiền không hợp lệ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbLoaiGiaoDich.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn loại giao dịch.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Dựa vào biến is_edit để gọi hàm Thêm hoặc Sửa
            if (is_edit)
            {
                SuaGiaoDich();
            }
            else
            {
                ThemGiaoDich();
            }
            
        }
        private void ThemGiaoDich()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("sp_ThemGiaoDichLuong", conn);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.Parameters.AddWithValue("@MaNV", cmbMaNhanVien.SelectedValue.ToString());
                adapter.SelectCommand.Parameters.AddWithValue("@SoTien", decimal.Parse(txtSoTien.Text));
                adapter.SelectCommand.Parameters.AddWithValue("@NgayGiaoDich", dateNgayGiaoDich.Value);
                adapter.SelectCommand.Parameters.AddWithValue("@LyDo", txtLyDo.Text);
                adapter.SelectCommand.Parameters.AddWithValue("@LoaiGiaoDich", cmbLoaiGiaoDich.SelectedItem.ToString());

                try
                {
                    conn.Open();
                    adapter.SelectCommand.ExecuteNonQuery();
                    MessageBox.Show("Thêm giao dịch lương thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm giao dịch lương: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void SuaGiaoDich()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_SuaGiaoDichLuong", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Thêm các tham số (có thêm MaGiaoDich)
                cmd.Parameters.AddWithValue("@MaGiaoDich", this.MaGD);
                cmd.Parameters.AddWithValue("@MaNV", cmbMaNhanVien.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@LoaiGiaoDich", cmbLoaiGiaoDich.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@SoTien", decimal.Parse(txtSoTien.Text));
                cmd.Parameters.AddWithValue("@NgayGiaoDich", dateNgayGiaoDich.Value);
                cmd.Parameters.AddWithValue("@LyDo", txtLyDo.Text);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật giao dịch thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK; // Đặt kết quả để form cha biết cần tải lại
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật giao dịch: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
