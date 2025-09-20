using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manage_Furniture.Forms
{
    public partial class FrmThemTaiKhoan : Form
    {
        bool isEdit = false;
        string maDN_HienTai; // Tên cũ là MaDN
        String connectionString = CurrentUserSession.ConnectionString;

        // Constructor cho chế độ THÊM
        public FrmThemTaiKhoan()
        {
            InitializeComponent();
            isEdit = false;
        }

        // Constructor cho chế độ SỬA
        public FrmThemTaiKhoan(String maDN)
        {
            InitializeComponent();
            isEdit = true;
            lblTitle.Text = "Sửa thông tin tài khoản";
            this.maDN_HienTai = maDN;
        }

        private void FrmThemTaiKhoan_Load(object sender, EventArgs e)
        {
            // Luôn tải dữ liệu cho các ComboBox
            LoadVaiTro();
            LoadNhanVien();

            if (isEdit)
            {
                // Nếu là sửa, tải thông tin chi tiết của tài khoản đó lên
                LoadThongTinTaiKhoan();
                txtTenDangNhap.ReadOnly = true; // Không cho phép sửa tên đăng nhập
                cmbNhanVien.Enabled = false;   // Không cho phép đổi tài khoản cho nhân viên khác
            }
        }

        // Đã sửa lại hàm load của bạn
        private void LoadThongTinTaiKhoan()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    // Gọi SP xem chi tiết, hiệu quả hơn query view
                    SqlCommand cmd = new SqlCommand("sp_XemChiTietTaiKhoan", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TenDangNhap", this.maDN_HienTai);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtTenDangNhap.Text = reader["Tên Đăng Nhập"].ToString();
                        txtMatKhau.Text = reader["Mật Khẩu"].ToString();
                        cmbNhanVien.SelectedValue = reader["Mã Nhân Viên"];
                        cmbVaiTro.SelectedValue = reader["VaiTro"];
                        chkTrangThai.Checked = Convert.ToBoolean(reader["TrangThai"]);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải thông tin tài khoản: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

      

        private void LoadNhanVien()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // Chỉ hiển thị các nhân viên CHƯA có tài khoản để lựa chọn
                string query = "SELECT MaNV, HoTen FROM NHANVIEN WHERE MaNV NOT IN (SELECT MaNV FROM TAIKHOAN)";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbNhanVien.DataSource = dt;
                cmbNhanVien.DisplayMember = "HoTen";
                cmbNhanVien.ValueMember = "MaNV";
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
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd;

                    if (isEdit)
                    {
                        // --- LOGIC SỬA ---
                        cmd = new SqlCommand("sp_SuaTaiKhoan", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@TenDangNhap", txtTenDangNhap.Text);
                        // Chỉ truyền mật khẩu nếu người dùng có nhập vào ô mật khẩu
                        if (!string.IsNullOrEmpty(txtMatKhau.Text))
                        {
                            cmd.Parameters.AddWithValue("@MatKhau", txtMatKhau.Text);
                        }
                        cmd.Parameters.AddWithValue("@VaiTro", cmbVaiTro.SelectedValue);
                        cmd.Parameters.AddWithValue("@TrangThai", chkTrangThai.Checked);
                    }
                    else
                    {
                        // --- LOGIC THÊM ---
                        cmd = new SqlCommand("sp_ThemTaiKhoan", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@TenDangNhap", txtTenDangNhap.Text);
                        cmd.Parameters.AddWithValue("@MatKhau", txtMatKhau.Text);
                        cmd.Parameters.AddWithValue("@MaNV", cmbNhanVien.SelectedValue);
                        cmd.Parameters.AddWithValue("@VaiTro", cmbVaiTro.SelectedValue);
                    }

                    cmd.ExecuteNonQuery();
                    MessageBox.Show(isEdit ? "Cập nhật tài khoản thành công!" : "Thêm tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}