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
    public partial class FrmThemHopDong : Form
    {
        bool isEdit = false;
        string maHD_HienTai;


        public FrmThemHopDong()
        {
            InitializeComponent();
        }
        public FrmThemHopDong(String maHD)
        {
            InitializeComponent();
            isEdit = true;
            // lblTitle là một Label trên form của bạn để hiển thị tiêu đề
            lblTitle.Text = "Sửa thông tin hợp đồng";
            this.maHD_HienTai = maHD;
        }
        String connectionString = "Data Source=.;Initial Catalog=DBMS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        private void FrmThemHopDong_Load(object sender, EventArgs e)
        {
            LoadNhanVien();

            // Thêm các loại hợp đồng vào ComboBox
            cmbLoaiHopDong.Items.Add("Nhân viên chính thức");
            cmbLoaiHopDong.Items.Add("Nhân viên thực tập");
            cmbLoaiHopDong.SelectedIndex = 0; // Chọn sẵn giá trị mặc định

            if (isEdit)
            {
                // Nếu là sửa, tải thông tin hợp đồng lên form
                LoadThongTinHopDong();
                txtMaHopDong.ReadOnly = true;
                cmbNhanVien.Enabled = false; // Không cho sửa nhân viên của hợp đồng
            }
        }

        private void LoadNhanVien()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // Chỉ hiển thị các nhân viên đang làm việc
                string query = "SELECT MaNV, HoTen FROM NHANVIEN WHERE TrangThai = N'Đang làm việc'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbNhanVien.DataSource = dt;
                cmbNhanVien.DisplayMember = "HoTen";
                cmbNhanVien.ValueMember = "MaNV";
            }
        }
        private void LoadThongTinHopDong()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_XemChiTietHopDong", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaHopDong", this.maHD_HienTai);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtMaHopDong.Text = reader["MaHopDong"].ToString();
                        cmbNhanVien.SelectedValue = reader["MaNV"];
                        cmbLoaiHopDong.SelectedItem = reader["LoaiHopDong"].ToString();
                        dateNgayBatDau.Value = Convert.ToDateTime(reader["NgayBatDau"]);

                        if (reader["NgayKetThuc"] != DBNull.Value)
                        {
                            dateNgayKetThuc.Value = Convert.ToDateTime(reader["NgayKetThuc"]);
                        }
                        txtLuongCoBan.Text = reader["MucLuongCoBan"].ToString();
                        txtTongKhauTru.Text = reader["TongKhauTru"].ToString();
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải thông tin hợp đồng: " + ex.Message);
                }
            }
        }


        private void btnDongY_Click(object sender, EventArgs e)
        {
            // (Bạn nên thêm kiểm tra dữ liệu đầu vào ở đây)
            // Ví dụ: kiểm tra xem Lương và Khấu trừ có phải là số không.

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd;

                    if (isEdit)
                    {
                        cmd = new SqlCommand("sp_SuaHopDong", con);
                        cmd.Parameters.AddWithValue("@MaHopDong", this.maHD_HienTai);
                    }
                    else
                    {
                        cmd = new SqlCommand("sp_ThemHopDong", con);
                        cmd.Parameters.AddWithValue("@MaNV", cmbNhanVien.SelectedValue);
                    }

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@LoaiHopDong", cmbLoaiHopDong.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@NgayBatDau", dateNgayBatDau.Value);
                    cmd.Parameters.AddWithValue("@NgayKetThuc", dateNgayKetThuc.Value);
                    cmd.Parameters.AddWithValue("@MucLuongCoBan", Convert.ToDecimal(txtLuongCoBan.Text));
                    // Lấy giá trị tổng khấu trừ từ TextBox do người dùng nhập
                    cmd.Parameters.AddWithValue("@TongKhauTru", Convert.ToDecimal(txtTongKhauTru.Text));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show(isEdit ? "Cập nhật hợp đồng thành công!" : "Thêm hợp đồng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
