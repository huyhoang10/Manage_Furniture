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
    public partial class ThemCaLam : Form
    {
        String connectionString = "Data Source=.;Initial Catalog=DBMS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        bool is_edit = false;
        string MaCa;

        public ThemCaLam()
        {
            InitializeComponent();
            is_edit = false;
            btnXacNhan.Text = "THÊM";

        }
        public ThemCaLam(string maca)
        {
            InitializeComponent();
            is_edit = true;
            this.MaCa = maca;
            lblTitle.Text = "SỬA CA LÀM";
            btnXacNhan.Text = "LƯU";
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
                    SqlCommand cmd = new SqlCommand("sp_LayChiTietCaLam", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaCa", this.MaCa);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtMaCa.Text = reader["MaCa"].ToString().Trim();
                        txtTenCa.Text = reader["TenCa"].ToString().Trim();

                        // SỬA LỖI TẠI ĐÂY:
                        // Bước 1: Lấy giá trị Time (kết quả là một TimeSpan) từ CSDL
                        TimeSpan gioBatDau = (TimeSpan)reader["GioBatDau"];
                        TimeSpan gioKetThuc = (TimeSpan)reader["GioKetThuc"];

                        // Bước 2: Lấy một ngày cơ sở (ví dụ: ngày hôm nay lúc 0 giờ)
                        DateTime ngayCoSo = DateTime.Today;

                        // Bước 3: Ghép ngày và giờ lại với nhau để tạo thành một DateTime hoàn chỉnh
                        dateNgayVao.Value = ngayCoSo + gioBatDau;
                        dateNgayRa.Value = ngayCoSo + gioKetThuc;

                        // Sửa lại tên cột cho đúng
                        txtPhatTienTre.Text = reader["PhatDiTre"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu chi tiết: " + ex.Message);
                }
            }
        }

        private void ThemCaLam_Load(object sender, EventArgs e)
        {

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            // Tách biệt logic Thêm và Sửa
            if (is_edit)
            {
                SuaCaLamViec();
            }
            else
            {
                ThemCaLamViec();
            }
        }
        private void ThemCaLamViec()
        {
            // Kiểm tra dữ liệu an toàn
            if (!ValidateInput(out string maCa, out string tenCa, out DateTime gioBatDau, out DateTime gioKetThuc, out decimal phatDiTre))
            {
                return; // Dừng lại nếu dữ liệu không hợp lệ
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_ThemCaLamViec", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@MaCa", maCa);
                    cmd.Parameters.AddWithValue("@TenCa", tenCa);
                    cmd.Parameters.AddWithValue("@GioBatDau", gioBatDau);
                    cmd.Parameters.AddWithValue("@GioKetThuc", gioKetThuc);
                    cmd.Parameters.AddWithValue("@PhatDiTre", phatDiTre);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm ca làm việc mới thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show(sqlEx.Message, "Lỗi từ CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Hàm xử lý logic Sửa
        private void SuaCaLamViec()
        {
            if (!ValidateInput(out string maCa, out string tenCa, out DateTime gioBatDau, out DateTime gioKetThuc, out decimal phatDiTre))
            {
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_SuaCaLamViec", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@MaCa", maCa); // `maCa` lúc này là mã gốc không đổi
                    cmd.Parameters.AddWithValue("@TenCa", tenCa);
                    cmd.Parameters.AddWithValue("@GioBatDau", gioBatDau);
                    cmd.Parameters.AddWithValue("@GioKetThuc", gioKetThuc);
                    cmd.Parameters.AddWithValue("@PhatDiTre", phatDiTre);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật ca làm việc thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show(sqlEx.Message, "Lỗi từ CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private bool ValidateInput(out string maCa, out string tenCa, out DateTime gioBatDau, out DateTime gioKetThuc, out decimal phatDiTre)
        {
            // Khởi tạo các biến out
            maCa = txtMaCa.Text.Trim();
            tenCa = txtTenCa.Text.Trim();
            gioBatDau = dateNgayVao.Value;
            gioKetThuc = dateNgayRa.Value;
            phatDiTre = 0;

            if (string.IsNullOrEmpty(maCa) || string.IsNullOrEmpty(tenCa))
            {
                MessageBox.Show("Mã ca và Tên ca không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // SỬA LỖI: Dùng TryParse để chuyển đổi an toàn
            if (!decimal.TryParse(txtPhatTienTre.Text, out phatDiTre))
            {
                MessageBox.Show("Tiền phạt phải là một con số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

    }
}
