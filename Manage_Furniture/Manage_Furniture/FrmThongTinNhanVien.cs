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

namespace Manage_Furniture
{
    public partial class FrmThongTinNhanVien : Form
    {
        string MaNV;
        String connectionString = "Data Source=.;Initial Catalog=DBMS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public FrmThongTinNhanVien(String MaNV)
        {
            this.MaNV = MaNV;
            InitializeComponent();
        }

        private void FrmThongTinNhanVien_Load(object sender, EventArgs e)
        {
            // Thêm các lựa chọn cho ComboBox Giới tính
            cmbGioiTinh.Items.Add("Nam");
            cmbGioiTinh.Items.Add("Nữ");
            cmbGioiTinh.Items.Add("Khác");

            // Vô hiệu hóa control vì đây là form chỉ xem
            SetControlsReadOnly();

            // Gọi hàm để điền dữ liệu (chỉ gọi 1 lần)
            LoadChiTietNhanVien();
        }

        // Hàm phụ để vô hiệu hóa tất cả control
        private void SetControlsReadOnly()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Panel) // Giả sử các control nằm trong Panel
                {
                    foreach (Control innerControl in control.Controls)
                    {
                        innerControl.Enabled = false;
                    }
                }
                else
                {
                    control.Enabled = false;
                }
            }
            // Cho phép nút đóng hoặc các nút chức năng khác
            // btnDong.Enabled = true; 
        }

        private void LoadChiTietNhanVien()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_XemThongTinChiTietNhanVien_DayDu", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaNV", this.MaNV);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        // --- ĐIỀN THÔNG TIN CÁ NHÂN ---
                        txtMaNhanVien.Text = reader["MaNV"].ToString();
                        txtHoTen.Text = reader["HoTen"].ToString();
                        cmbGioiTinh.SelectedItem = reader["GioiTinh"].ToString();
                        dateNgaySinh.Value = Convert.ToDateTime(reader["NgaySinh"]);
                        txtSoDienThoai.Text = reader["SoDienThoai"].ToString();
                        txtDiaChi.Text = reader["DiaChi"].ToString();
                        txtEmail.Text = reader["Email"].ToString();
                        dateNgayVaoLam.Value = Convert.ToDateTime(reader["NgayVaoLam"]);
                        txtTrangThaiLamViec.Text = reader["TrangThaiLamViec"].ToString();

                        // Xử lý DateTimePicker có thể NULL
                        if (reader["NgayNghiViec"] == DBNull.Value)
                        {
                            dateNgayNghiViec.Visible = false;
                        }
                        else
                        {
                            dateNgayNghiViec.Visible = true;
                            dateNgayNghiViec.Value = Convert.ToDateTime(reader["NgayNghiViec"]);
                        }

                        // Xử lý Ảnh đại diện
                        if (reader["AnhDaiDien"] != DBNull.Value)
                        {
                            byte[] imgBytes = (byte[])reader["AnhDaiDien"];
                            using (MemoryStream ms = new MemoryStream(imgBytes))
                            {
                                pbAnhDaiDien.Image = Image.FromStream(ms);
                            }
                        }
                        else
                        {
                            pbAnhDaiDien.Image = null;
                        }

                        // --- ĐIỀN THÔNG TIN TÀI KHOẢN ---
                        txtTenDangNhap.Text = reader["TenDangNhap"] == DBNull.Value ? "Chưa có" : reader["TenDangNhap"].ToString();
                        txtVaiTro.Text = reader["VaiTro"] == DBNull.Value ? "Chưa có" : reader["VaiTro"].ToString();
                        txtTrangThai.Text = reader["TrangThaiTaiKhoan"] == DBNull.Value ? "Chưa có" : reader["TrangThaiTaiKhoan"].ToString();

                        // --- ĐIỀN THÔNG TIN CÔNG VIỆC & HỢP ĐỒNG ---
                        txtChucVu.Text = reader["ChucVu"] == DBNull.Value ? "Chưa có" : reader["ChucVu"].ToString();
                        txtPhongBan.Text = reader["PhongBan"] == DBNull.Value ? "Chưa có" : reader["PhongBan"].ToString();
                        txtLoai.Text = reader["LoaiHopDong"] == DBNull.Value ? "Chưa có" : reader["LoaiHopDong"].ToString();
                        txtLuongCoBan.Text = reader["LuongCoBan"] == DBNull.Value ? "0 VNĐ" : Convert.ToDecimal(reader["LuongCoBan"]).ToString("N0") + " VNĐ";

                        // Xử lý DateTimePicker của hợp đồng có thể NULL
                        if (reader["NgayBatDauHD"] == DBNull.Value)
                        {
                            dateNgayBatDauHopDong.Visible = false;
                        }
                        else
                        {
                            dateNgayBatDauHopDong.Visible = true;
                            dateNgayBatDauHopDong.Value = Convert.ToDateTime(reader["NgayBatDauHD"]);
                        }

                        if (reader["NgayKetThucHD"] == DBNull.Value)
                        {
                            dateNgayKetThucHD.Visible = false;
                        }
                        else
                        {
                            dateNgayKetThucHD.Visible = true;
                            dateNgayKetThucHD.Value = Convert.ToDateTime(reader["NgayKetThucHD"]);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thông tin cho nhân viên này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
