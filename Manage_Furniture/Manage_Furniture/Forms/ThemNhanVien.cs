using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manage_Furniture.Forms
{
    public partial class FrmThemNhanVien : Form
    {
        String connectionString = "Data Source=.;Initial Catalog=DBMS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        bool is_edit = true;
        private string maNV_HienTai;
        public FrmThemNhanVien()
        {
            InitializeComponent();
            is_edit = false;
        }
        
        public FrmThemNhanVien(String MaNV)
        {
            InitializeComponent();
            lblTitle.Text = "SỬA THÔNG TIN NHÂN VIÊN";
            is_edit = true;           // << Thêm dòng này
            this.maNV_HienTai = MaNV; // << Lưu lại mã nhân viên
        }

        private void guna2ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LoadThongTinNhanVien()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_XemChiTietNhanVien", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaNV", this.maNV_HienTai);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtHoTen.Text = reader["Họ Tên"].ToString();
                        cmbGioiTinh.SelectedItem = reader["Giới Tính"].ToString();
                        dateNgaySinh.Value = Convert.ToDateTime(reader["Ngày Sinh"]);
                        txtDiaChi.Text = reader["Địa Chỉ"].ToString();
                        txtSdt.Text = reader["Số Điện Thoại"].ToString();
                        txtEmail.Text = reader["Email"].ToString();
                        txtCCCD.Text = reader["CCCD"].ToString();
                        dateNgayVaoLam.Value = Convert.ToDateTime(reader["Ngày Vào Làm"]);

                        // Chọn đúng giá trị trong ComboBox
                        cmbPhongBan.SelectedValue = reader["MaPhongBan"];
                        cmbChucVu.SelectedValue = reader["MaChucVu"];

                        // Xử lý ảnh đại diện
                        if (reader["Ảnh Đại Diện"] != DBNull.Value)
                        {
                            byte[] imgBytes = (byte[])reader["Ảnh Đại Diện"];
                            using (MemoryStream ms = new MemoryStream(imgBytes))
                            {
                                pbAnhDaiDien.Image = new Bitmap(ms);
                            }
                        }
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải thông tin nhân viên: " + ex.Message);
                    this.Close();
                }
            }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pbAnhDaiDien.Image = Image.FromFile(openFile.FileName);
            }
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateNgaySinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtSdt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateNgayVaoLam_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pbAnhDaiDien_Click(object sender, EventArgs e)
        {

        }
        private void LoadPhongBan()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT MaPhongBan, TenPhongBan FROM PHONGBAN", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbPhongBan.DataSource = dt;
                cmbPhongBan.DisplayMember = "TenPhongBan"; // Hiển thị tên
                cmbPhongBan.ValueMember = "MaPhongBan";   // Giá trị thực lưu
            }
        }

        private void LoadChucVu()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT MaChucVu, TenChucVu FROM CHUCVU", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbChucVu.DataSource = dt;
                cmbChucVu.DisplayMember = "TenChucVu"; // Hiển thị tên
                cmbChucVu.ValueMember = "MaChucVu";   // Giá trị thực lưu
            }
        }

        private void FrmThemNhanVien_Load(object sender, EventArgs e)
        {
            LoadChucVu();
            LoadPhongBan();
            if (is_edit)
            {
                LoadThongTinNhanVien();
            }
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd;

                    // Dựa vào is_edit để quyết định gọi SP nào
                    if (is_edit)
                    {
                        // --- LOGIC SỬA ---
                        cmd = new SqlCommand("sp_SuaThongTinNhanVien", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Thêm tham số @MaNV khi sửa
                        cmd.Parameters.AddWithValue("@MaNV", this.maNV_HienTai);
                    }
                    else
                    {
                        // --- LOGIC THÊM (giữ nguyên) ---
                        cmd = new SqlCommand("sp_ThemNhanVien", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                    }

                    // Các tham số chung cho cả Thêm và Sửa
                    cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
                    cmd.Parameters.AddWithValue("@GioiTinh", cmbGioiTinh.SelectedItem?.ToString());
                    cmd.Parameters.AddWithValue("@NgaySinh", dateNgaySinh.Value);
                    cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                    cmd.Parameters.AddWithValue("@SoDienThoai", txtSdt.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@MaChucVu", cmbChucVu.SelectedValue);
                    cmd.Parameters.AddWithValue("@CCCD", txtCCCD.Text);
                    cmd.Parameters.AddWithValue("@MaPhongBan", cmbPhongBan.SelectedValue);
                    cmd.Parameters.AddWithValue("@NgayVaoLam", dateNgayVaoLam.Value);

                    // Xử lý Ảnh đại diện
                    if (pbAnhDaiDien.Image != null)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            pbAnhDaiDien.Image.Save(ms, pbAnhDaiDien.Image.RawFormat);
                            cmd.Parameters.AddWithValue("@AnhDaiDien", ms.ToArray());
                        }
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@AnhDaiDien", DBNull.Value);
                    }

                    cmd.ExecuteNonQuery();

                    // Hiển thị thông báo phù hợp
                    if (is_edit)
                    {
                        MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
