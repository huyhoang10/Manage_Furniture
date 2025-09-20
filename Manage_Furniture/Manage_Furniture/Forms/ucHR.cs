



using System;
using System.Windows.Forms;

using System.Linq;
using Manage_Furniture.Controls;
using Manage_Furniture.ADO;
using System.Drawing;
using System.Collections.Generic;
using Manage_Furniture.Forms;
using System.Runtime.CompilerServices;
using DocumentFormat.OpenXml.Bibliography;
using Microsoft.VisualBasic;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Data.SqlClient;
using System.Data;

namespace Manage_Furniture.Controls
{
    public partial class ucHR : UserControl
    {

        String connectionString = CurrentUserSession.ConnectionString;
        String selectedMaNV; // Dùng để lưu mã nhân viên đang được chọn

        public ucHR()
        {
            InitializeComponent();
        }

        private void ucHR_Load(object sender, EventArgs e)
        {
           
        }

        // --- HÀM TẢI DỮ LIỆU CHÍNH (ĐÃ ĐƯỢC THAM SỐ HÓA) ---
        private void load(string tenNV,string maCV, string maPB, string loaiHD, string trangThai)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter("sp_LocNhanVien", connection);
                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                    adapter.SelectCommand.Parameters.AddWithValue("@MaChucVu", (object)maCV ?? DBNull.Value);
                    adapter.SelectCommand.Parameters.AddWithValue("@MaPhongBan", (object)maPB ?? DBNull.Value);
                    adapter.SelectCommand.Parameters.AddWithValue("@LoaiHopDong", (object)loaiHD ?? DBNull.Value);
                    adapter.SelectCommand.Parameters.AddWithValue("@TrangThai", (object)trangThai ?? DBNull.Value);
                    adapter.SelectCommand.Parameters.AddWithValue("@TenNhanVien", (object)tenNV ?? DBNull.Value);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgvBangNhanVien.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi tải dữ liệu: " + ex.Message);
                }
            }
        }

        // --- CÁC HÀM TẢI DỮ LIỆU CHO COMBOBOX (TỪ DB) ---
        private void LoadChucVu()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT MaChucVu, TenChucVu FROM CHUCVU", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow dr = dt.NewRow();
                dr["MaChucVu"] = DBNull.Value;
                dr["TenChucVu"] = "--- Tất cả chức vụ ---";
                dt.Rows.InsertAt(dr, 0);
                cmbChucVu.DataSource = dt;
                cmbChucVu.DisplayMember = "TenChucVu";
                cmbChucVu.ValueMember = "MaChucVu";
            }
        }

        private void LoadPhongBan()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT MaPhongBan, TenPhongBan FROM PHONGBAN", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow dr = dt.NewRow();
                dr["MaPhongBan"] = DBNull.Value;
                dr["TenPhongBan"] = "--- Tất cả phòng ban ---";
                dt.Rows.InsertAt(dr, 0);
                cmbPhongBan.DataSource = dt;
                cmbPhongBan.DisplayMember = "TenPhongBan";
                cmbPhongBan.ValueMember = "MaPhongBan";
            }
        }

        // --- SỰ KIỆN CHO CÁC NÚT BẤM VÀ DATAGRIDVIEW ---
        private void btnApDung_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ ComboBox load từ DB
            string maCV = cmbChucVu.SelectedValue == DBNull.Value ? null : cmbChucVu.SelectedValue.ToString();
            string maPB = cmbPhongBan.SelectedValue == DBNull.Value ? null : cmbPhongBan.SelectedValue.ToString();
            String tenNV = txtTimKiem.Text;
            // Lấy giá trị từ ComboBox fix cứng dựa trên vị trí (index)
            string loaiHD = cmbLoaiNhanVien.SelectedIndex <= 0 ? null : cmbLoaiNhanVien.SelectedItem.ToString();
            string trangThai = cmbTrangThaiNhanVien.SelectedIndex <= 0 ? null : cmbTrangThaiNhanVien.SelectedItem.ToString();

            // Gọi hàm load với các tham số đã chọn
            load(tenNV,maCV, maPB, loaiHD, trangThai);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            // Thiết lập lại các ComboBox về giá trị "Tất cả"
            cmbChucVu.SelectedIndex = 0;
            cmbPhongBan.SelectedIndex = 0;
            cmbLoaiNhanVien.SelectedIndex = 0;

            // Mặc định trạng thái là "Đang làm việc"
            cmbTrangThaiNhanVien.SelectedItem = "Đang làm việc";

            // Tải lại DataGridView với bộ lọc mặc định
            btnApDung_Click(null, null);
        }

        private void dgvBangNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBangNhanVien.Rows[e.RowIndex];
                // Lưu lại mã nhân viên của hàng đang được chọn
                this.selectedMaNV = row.Cells["Mã NV"].Value.ToString();
            }
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            FrmThemNhanVien f = new FrmThemNhanVien();
            f.ShowDialog();
            // Sau khi form thêm đóng lại, làm mới danh sách về trạng thái mặc định
            btnLamMoi_Click(null, null);
        }

        private void btnSuaThongtin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.selectedMaNV))
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để sửa.", "Chưa chọn nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FrmThemNhanVien f = new FrmThemNhanVien(this.selectedMaNV);
            f.ShowDialog();
            // Sau khi form sửa đóng lại, làm mới danh sách
            btnLamMoi_Click(null, null);
        }

        private void btnThoiViec_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.selectedMaNV))
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để cho thôi việc.", "Chưa chọn nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string hoTen = dgvBangNhanVien.Rows[dgvBangNhanVien.CurrentRow.Index].Cells["Họ Tên"].Value.ToString();

            DialogResult confirmResult = MessageBox.Show($"Bạn có chắc chắn muốn cho nhân viên '{hoTen}' (Mã: {this.selectedMaNV}) thôi việc không?",
                                                          "Xác nhận thôi việc", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("sp_SaThaiNhanVien", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaNV", this.selectedMaNV);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cập nhật trạng thái thôi việc cho nhân viên thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnLamMoi_Click(null, null); // Làm mới danh sách
                    }
                    catch (SqlException sqlEx)
                    {
                        MessageBox.Show("Lỗi từ CSDL: " + sqlEx.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.selectedMaNV))
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để xem chi tiết.", "Chưa chọn nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FrmThongTinNhanVien f = new FrmThongTinNhanVien(this.selectedMaNV);
            f.ShowDialog();
        }

        private void ucHR_Load_1(object sender, EventArgs e)
        {

            if (!DesignMode)
            {


                LoadChucVu();
                LoadPhongBan();

                // Thêm mục "Tất cả..." vào đầu các ComboBox đã có item sẵn từ giao diện
                cmbLoaiNhanVien.Items.Insert(0, "--- Tất cả loại HĐ ---");
                cmbTrangThaiNhanVien.Items.Insert(0, "--- Tất cả trạng thái ---");

                // Thiết lập trạng thái mặc định và tải dữ liệu lần đầu
                btnLamMoi_Click(null, null);
            }
        }
    }
}
