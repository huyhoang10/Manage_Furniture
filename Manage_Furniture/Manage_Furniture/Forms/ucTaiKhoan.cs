using Manage_Furniture.Controls;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace Manage_Furniture.Forms
{
    public partial class ucTaiKhoan : UserControl
    {
      
        public ucTaiKhoan()
        {
            InitializeComponent();
           
        }

        private void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {
            FrmThemTaiKhoan f = new FrmThemTaiKhoan();
            f.ShowDialog();
            load();

        }

        private void ucTaiKhoan_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                load();
                LoadVaiTro();
            }

        }
        private void LoadVaiTro()
        {
            using (var con = new SqlConnection(CurrentUserSession.ConnectionString))
            {
                using (var cmd = new SqlCommand("sp_LayDanhSachRole", con) { CommandType = CommandType.StoredProcedure })
                {
                    var da = new SqlDataAdapter(cmd);
                    var dt = new DataTable();
                    da.Fill(dt);

                    cmbVaiTro.DataSource = dt;
                    cmbVaiTro.DisplayMember = "TenVaiTro";
                    cmbVaiTro.ValueMember = "TenVaiTro";
                }
            }
            var dataSource = new List<KeyValuePair<string, int>>
            {
                new KeyValuePair<string, int>("Đang hoạt động", 1),
                new KeyValuePair<string, int>("Đã khóa", 0)
            };

            // Gán danh sách này làm nguồn dữ liệu
            cmbTrangThai.DataSource = dataSource;

            // Chỉ định cái nào để hiển thị, cái nào là giá trị
            cmbTrangThai.DisplayMember = "Key";
            cmbTrangThai.ValueMember = "Value";

            // Bỏ chọn mục đầu tiên (tùy chọn)
            cmbTrangThai.SelectedIndex = -1;
        }
        String connectionString = CurrentUserSession.ConnectionString;
        private void load()
        {
            // Sử dụng khối 'using' để đảm bảo kết nối được đóng tự động
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    // Câu lệnh SQL để truy vấn dữ liệu từ View
                    string query = "SELECT * FROM v_DanhSachTaiKhoan";

                    // SqlDataAdapter là cầu nối để lấy dữ liệu từ DB vào DataTable
                    SqlDataAdapter da = new SqlDataAdapter(query, con);

                    // DataTable là một bảng dữ liệu ảo trong bộ nhớ
                    DataTable dt = new DataTable();

                    // Đổ dữ liệu từ Adapter vào DataTable
                    da.Fill(dt);

                    // Gán DataTable làm nguồn dữ liệu cho DataGridView
                    // Giả sử DataGridView của bạn có tên là 'dgvTaiKhoan'
                    dgvBangNhanVien.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải danh sách tài khoản: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        String MaDN;
        private void dgvBangNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo rằng người dùng không nhấp vào tiêu đề cột
            {
                DataGridViewRow row = dgvBangNhanVien.Rows[e.RowIndex];

                MaDN = row.Cells[0].Value.ToString();

            }
        }

        private void btnSuaThongtin_Click(object sender, EventArgs e)
        {
            FrmThemTaiKhoan f = new FrmThemTaiKhoan(MaDN);
            f.ShowDialog();
            load();
        }

        private void btnXoaTaiKhoan_Click(object sender, EventArgs e)
        {
            if(MaDN == null)
            {
                MessageBox.Show("Vui lòng chọn tài khoản để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            using(SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_XoaTaiKhoan", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TenDangNhap", MaDN);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa tài khoản: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnKichHoat_Click(object sender, EventArgs e)
        {
            if (MaDN == null)
            {
                MessageBox.Show("Vui lòng chọn tài khoản để kích hoạt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_KichHoatLaiTaiKhoan", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TenDangNhap", MaDN);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kích hoạt tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi kích hoạt tài khoản: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnApDung_Click(object sender, EventArgs e)
        {
           using(SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_DanhSachTaiKhoan", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    if(!string.IsNullOrEmpty(txtTimKiem.Text))
                        cmd.Parameters.AddWithValue("@Keyword", txtTimKiem.Text);
                   if (cmbVaiTro.SelectedValue != null)
                        cmd.Parameters.AddWithValue("@VaiTro", cmbVaiTro.SelectedValue.ToString());
                    if (cmbTrangThai.SelectedIndex != -1)
                    {
                       cmd.Parameters.AddWithValue("@TrangThai", cmbTrangThai.SelectedValue);
                    }
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvBangNhanVien.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lọc tài khoản: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            load();
            txtTimKiem.Clear();
            cmbTrangThai.SelectedIndex = -1;
            cmbVaiTro.SelectedIndex = -1;
            MaDN = null;

        }
    }
}
