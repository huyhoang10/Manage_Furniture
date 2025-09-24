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

namespace Manage_Furniture.Forms
{
    public partial class ucHopDong : UserControl
    {
        public ucHopDong()
        {
            InitializeComponent();
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            FrmThemHopDong frmThemHopDong = new FrmThemHopDong();
            frmThemHopDong.ShowDialog();
            load();
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
                    string query = "SELECT * FROM v_DanhSachHopDong";

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
        String MaHD;

        private void ucHopDong_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                load();
            }

        }

        private void dgvBangNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo rằng người dùng không nhấp vào tiêu đề cột
            {
                DataGridViewRow row = dgvBangNhanVien.Rows[e.RowIndex];
                MaHD = row.Cells[0].Value.ToString();
            }
        }

        private void btnSuaThongtin_Click(object sender, EventArgs e)
        {
            FrmThemHopDong f = new FrmThemHopDong(MaHD);
            f.ShowDialog();
            load();
        }

        private void btnApDung_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_DanhSachHopDong", con);
                cmd.CommandType = CommandType.StoredProcedure;
                if (txtTimKiem.Text.Trim() != "")
                {
                    cmd.Parameters.AddWithValue("@Keyword", txtTimKiem.Text.Trim());
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Keyword", DBNull.Value);
                }
                if (cmbLoaiHopDong.SelectedItem != null)
                {
                    cmd.Parameters.AddWithValue("@LoaiHopDong", cmbLoaiHopDong.SelectedItem.ToString());

                }
                else
                {
                    cmd.Parameters.AddWithValue("@LoaiHopDong", DBNull.Value);
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvBangNhanVien.DataSource = dt;

            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            load();
        }
    }
}
