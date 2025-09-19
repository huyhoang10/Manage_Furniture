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
    public partial class ThemChamCong : Form
    {
        string connectionString = "Data Source=.;Initial Catalog=DBMS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        bool is_edit = false;
        int MaCC;
        public ThemChamCong()
        {
            InitializeComponent();
            is_edit = false;
        }
        public ThemChamCong(int macc)
        {
            InitializeComponent();
            is_edit = true;
            this.MaCC = macc;
            lblTitle.Text = "SỬA CHẤM CÔNG";

            if (is_edit)
            {
                LoadDuLieuCanSua();
            }
        }
        private void LoadDuLieuCanSua()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_LayChiTietChamCong", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaChamCong", this.MaCC);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        // Điền thông tin đã lấy được vào các control
                        cmbMaNhanVien.SelectedValue = reader["MaNV"].ToString().Trim();
                        cmbCaLam.SelectedValue = reader["MaCa"].ToString().Trim();

                        // Giả sử bạn có các control: dateNgay, dateGioVao, dateGioRa, txtGhiChu
                        dateNgayChamCong.Value = Convert.ToDateTime(reader["NgayChamCong"]);
                        dateGioVao.Value = Convert.ToDateTime(reader["GioVao"]);
                        dateGioVe.Value = Convert.ToDateTime(reader["GioRa"]);
                        txtGhiChu.Text = reader["GhiChu"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu chấm công: " + ex.Message);
                    this.Close();
                }
            }
        }


        private void ThemChamCong_Load(object sender, EventArgs e)
        {
            LoadNhanVienComboBox();
            LoadCaLamViecComboBox();
            if (is_edit)
            {
                LoadDuLieuCanSua();
            }

        }
        private void LoadNhanVienComboBox()
        {
           

            // Câu lệnh SQL để lấy các nhân viên đang hoạt động, sắp xếp theo tên
            string query = "SELECT MaNV, HoTen FROM NHANVIEN WHERE TrangThai = N'Đang làm việc' ORDER BY HoTen;";

            // Sử dụng một DataTable để chứa dữ liệu
            DataTable dtNhanVien = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // Sử dụng SqlDataAdapter để dễ dàng đổ dữ liệu vào DataTable
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.Fill(dtNhanVien);

                    // Gán dữ liệu cho ComboBox (giả sử tên là cmbNhanVien)
                    cmbMaNhanVien.DataSource = dtNhanVien;       // 1. Nguồn dữ liệu
                    cmbMaNhanVien.DisplayMember = "HoTen";       // 2. Cột sẽ hiển thị
                    cmbMaNhanVien.ValueMember = "MaNV";         // 3. Cột sẽ là giá trị thực sự

                    // 4. (Tùy chọn) Bỏ chọn mục đầu tiên
                    cmbMaNhanVien.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadCaLamViecComboBox()
        {
            // Câu lệnh SQL để lấy tất cả ca làm việc
            string query = "SELECT MaCa, TenCa FROM CALAMVIEC ORDER BY TenCa;";

            DataTable dtCaLamViec = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // Sử dụng SqlDataAdapter để dễ dàng đổ dữ liệu vào DataTable
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                    // Tự động mở kết nối, điền dữ liệu và đóng kết nối
                    adapter.Fill(dtCaLamViec);

                    // Gán dữ liệu cho ComboBox (giả sử tên là cmbCaLamViec)
                    cmbCaLam.DataSource = dtCaLamViec;
                    cmbCaLam.DisplayMember = "TenCa";   // Cột để hiển thị
                    cmbCaLam.ValueMember = "MaCa";     // Cột làm giá trị thực sự
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách ca làm việc: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ThemChamCongThuCong()
        {
            // **Ghép ngày và giờ từ các control riêng biệt**
            // Giả sử bạn có: dateNgay (chỉ lấy ngày), dateGioVao (chỉ lấy giờ), dateGioRa (chỉ lấy giờ)
            DateTime gioVao = dateNgayChamCong.Value.Date + dateGioVao.Value.TimeOfDay;
            DateTime gioRa = dateNgayChamCong.Value.Date + dateGioVe.Value.TimeOfDay;

            // Kiểm tra dữ liệu đầu vào
            if (cmbMaNhanVien.SelectedValue == null || cmbCaLam.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ nhân viên và ca làm việc.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_ThemChamCong", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Thêm các tham số
                    cmd.Parameters.AddWithValue("@MaNV", cmbMaNhanVien.SelectedValue);
                    cmd.Parameters.AddWithValue("@MaCa", cmbCaLam.SelectedValue);
                    cmd.Parameters.AddWithValue("@NgayChamCong", dateNgayChamCong.Value.Date);
                    cmd.Parameters.AddWithValue("@GioVao", gioVao);
                    cmd.Parameters.AddWithValue("@GioRa", gioRa);
                    cmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm chấm công thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    this.DialogResult = DialogResult.OK; // Đặt kết quả để form cha biết cần tải lại
                    return;
                    this.Close();
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("Lỗi từ CSDL: " + sqlEx.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void SuaChamCong()
        {
            DateTime gioVao = dateNgayChamCong.Value.Date + dateGioVao.Value.TimeOfDay;
            DateTime gioRa = dateNgayChamCong.Value.Date + dateGioVe.Value.TimeOfDay;

            if (cmbMaNhanVien.SelectedValue == null || cmbCaLam.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ nhân viên và ca làm việc.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_SuaChamCong", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Thêm các tham số (có thêm MaChamCong)
                    cmd.Parameters.AddWithValue("@MaChamCong", this.MaCC);
                    cmd.Parameters.AddWithValue("@MaNV", cmbMaNhanVien.SelectedValue);
                    cmd.Parameters.AddWithValue("@MaCa", cmbCaLam.SelectedValue);
                    cmd.Parameters.AddWithValue("@NgayChamCong", dateNgayChamCong.Value.Date);
                    cmd.Parameters.AddWithValue("@GioVao", gioVao);
                    cmd.Parameters.AddWithValue("@GioRa", gioRa);
                    cmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật chấm công thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("Lỗi từ CSDL: " + sqlEx.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (is_edit)
            {
                SuaChamCong();
            }
            else
            {
                ThemChamCongThuCong();
            }
        }
       
    }
}
