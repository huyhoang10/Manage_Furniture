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
    public partial class TinhLuongChoCaNhan : Form
    {

        // Chuỗi kết nối đến CSDL của bạn
        string connectionString = CurrentUserSession.ConnectionString   ;
        public TinhLuongChoCaNhan()
        {
            InitializeComponent();
        }

        private void cmbNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TinhLuongChoCaNhan_Load(object sender, EventArgs e)
        {
            LoadNhanVienComboBox();
        }

        private void LoadNhanVienComboBox()
        {
            // Chuỗi kết nối đến CSDL của bạn


            // Câu lệnh SQL để lấy các nhân viên đang hoạt động, sắp xếp theo tên
            string query = "SELECT MaNV, HoTen FROM NHANVIEN WHERE TrangThai = N'Đang làm việc' ORDER BY HoTen;";

            DataTable dtNhanVien = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                    // Tự động mở kết nối, điền dữ liệu vào DataTable và đóng kết nối
                    adapter.Fill(dtNhanVien);

                    // Gán dữ liệu cho ComboBox (giả sử tên là cmbNhanVien)
                    cmbNhanVien.DataSource = dtNhanVien;
                    cmbNhanVien.DisplayMember = "HoTen";   // Cột để hiển thị cho người dùng
                    cmbNhanVien.ValueMember = "MaNV";     // Cột làm giá trị thực sự (giá trị ẩn)

                    // Bỏ chọn mục đầu tiên để người dùng phải chủ động chọn
                    cmbNhanVien.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra dữ liệu đầu vào
            if (cmbNhanVien.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn một nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Lấy thông tin từ các control
            string maNV = cmbNhanVien.SelectedValue.ToString();
            string tenNV = cmbNhanVien.Text; // Lấy tên để hiển thị trong thông báo
            DateTime tuNgay = dateNgayBatDau.Value.Date;
            DateTime denNgay = dateNgayKetThuc.Value.Date;

            // 3. Hỏi xác nhận người dùng
            var confirmResult = MessageBox.Show($"Bạn có chắc chắn muốn tính lương tháng cho nhân viên:\n\n{tenNV}?",
                                             "Xác nhận tính lương",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                // 4. Gọi Stored Procedure
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        
                        SqlCommand cmd = new SqlCommand("sp_TinhLuongNhanVien", conn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@MaNV", maNV);
                        cmd.Parameters.AddWithValue("@TuNgay", tuNgay);
                        cmd.Parameters.AddWithValue("@DenNgay", denNgay);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Đã tính lương thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK; // Đặt kết quả để form cha (nếu có) biết để tải lại
                        this.Close();
                    }
                    catch (SqlException sqlEx)
                    {
                        MessageBox.Show("Lỗi từ CSDL: " + sqlEx.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
