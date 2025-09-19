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
using Manage_Furniture.ADO;
using Manage_Furniture.Controls;
using Manage_Furniture.Forms;

namespace Manage_Furniture.Controls
{
    public partial class ucChamCong : UserControl
    {
        string connectionString = "Data Source=.;Initial Catalog=DBMS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public ucChamCong()
        {
            InitializeComponent();
        }

        // Sự kiện Load của UserControl
        private void ucChamCong_Load(object sender, EventArgs e)
        {
            
        }

        // Hàm thiết lập ban đầu
        private void load()
        {
            // Cấu hình các ComboBox lọc
            ConfigureFilterComboBoxes();
            // Đặt các bộ lọc về trạng thái mặc định
            ResetFilters();
            // Tải dữ liệu lần đầu
            ApplyFilter();
        }

        #region Cấu hình và Tải dữ liệu

        private void ConfigureFilterComboBoxes()
        {
            // --- Cấu hình ComboBox Ca Làm Việc ---
            // Thêm mục "Tất cả"
            DataTable dtCaLam = new DataTable();
            dtCaLam.Columns.Add("MaCa", typeof(string));
            dtCaLam.Columns.Add("TenCa", typeof(string));
            dtCaLam.Rows.Add(DBNull.Value, "Tất cả ca");
            // Tải dữ liệu từ DB
            SqlDataAdapter daCaLam = new SqlDataAdapter("SELECT MaCa, TenCa FROM CALAMVIEC", connectionString);
            daCaLam.Fill(dtCaLam);
            cmbCaLam.DataSource = dtCaLam;
            cmbCaLam.DisplayMember = "TenCa";
            cmbCaLam.ValueMember = "MaCa";

            // --- Cấu hình ComboBox Trạng Thái ---
            DataTable dtTrangThai = new DataTable();
            dtTrangThai.Columns.Add("Value", typeof(object));
            dtTrangThai.Columns.Add("Text", typeof(string));
            dtTrangThai.Rows.Add(DBNull.Value, "Tất cả");
            dtTrangThai.Rows.Add(1, "Hoạt động");
            dtTrangThai.Rows.Add(0, "Đã hủy");
            cmbTrangThai.DataSource = dtTrangThai;
            cmbTrangThai.DisplayMember = "Text";
            cmbTrangThai.ValueMember = "Value";
        }

        // Hàm chính để tải dữ liệu dựa trên các bộ lọc
        private void ApplyFilter()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_LocDanhSachChamCong", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Thêm các tham số từ control, xử lý trường hợp không lọc
                    cmd.Parameters.AddWithValue("@NgayChamCong", dateNgayChamCong.Checked ? (object)dateNgayChamCong.Value.Date : DBNull.Value);
                    cmd.Parameters.AddWithValue("@Keyword", string.IsNullOrWhiteSpace(txtNhanVien.Text) ? (object)DBNull.Value : txtNhanVien.Text.Trim());
                    cmd.Parameters.AddWithValue("@MaCa", cmbCaLam.SelectedValue);
                    cmd.Parameters.AddWithValue("@TrangThai", cmbTrangThai.SelectedValue);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvBangNhanVien.DataSource = dt;
                   
                    dgvBangNhanVien.Columns["Mã Chấm Công"].Visible = false;

                    dgvBangNhanVien.Columns["Trạng Thái"].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Hàm để xóa trắng/đặt lại các bộ lọc
        private void ResetFilters()
        {
            txtNhanVien.Clear();
            dateNgayChamCong.Checked = false; // Bỏ tick
            cmbCaLam.SelectedIndex = 0; // Chọn "[-- Tất cả ca --]"
            cmbTrangThai.SelectedIndex = 0; // Chọn "[-- Tất cả TT --]"
        }

        #endregion

        #region Sự kiện các nút bấm

        private void btnApDung_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            
        }

        private void btnThemChamCong_Click(object sender, EventArgs e)
        {
            ThemChamCong themChamCongForm = new ThemChamCong(); // Mở form ở chế độ Thêm
            if (themChamCongForm.ShowDialog() == DialogResult.OK)
            {
                ApplyFilter(); // Tải lại dữ liệu sau khi thêm thành công
            }
        }

        private void btnSuaThongTin_Click(object sender, EventArgs e)
        {
            
        }

        #endregion

        private void ucChamCong_Load_1(object sender, EventArgs e)
        {
            load();
        }

        private void btnApDung_Click_1(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        int maChamCong = -1; // Biến lưu mã chấm công đang được chọn
        private void dgvBangNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                // Lấy mã chấm công từ dòng được chọn
                maChamCong = Convert.ToInt32(dgvBangNhanVien.Rows[e.RowIndex].Cells[0].Value);
            }
        }
        

        private void btnSuaThongtin_Click_1(object sender, EventArgs e)
        {
           
            if (maChamCong == -1)
            {
                MessageBox.Show("Vui lòng chọn một bản ghi để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ThemChamCong themChamCongForm = new ThemChamCong(maChamCong);
            themChamCongForm.ShowDialog();


            ApplyFilter();
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
               
            {
                if (maChamCong == -1)
                {
                    MessageBox.Show("Vui lòng chọn một bản ghi để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_XoaChamCong", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    // Thêm tham số MaChamCong
                    cmd.Parameters.AddWithValue("@MaChamCong", maChamCong);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa chấm công thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ApplyFilter(); // Tải lại dữ liệu sau khi xóa thành công
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("Lỗi từ CSDL: " + sqlEx.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLamMoi_Click_1(object sender, EventArgs e)
        {
            ResetFilters();
            ApplyFilter();
        }
    }
}