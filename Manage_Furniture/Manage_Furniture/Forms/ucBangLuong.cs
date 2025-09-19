using Manage_Furniture.ADO;
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
    public partial class ucBangLuong : UserControl
    {
        String connectionString = "Data Source=.;Initial Catalog=DBMS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        public ucBangLuong()
        {
            InitializeComponent();
        }

        private void cmbTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnApDung_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void btnThemPhongBan_Click(object sender, EventArgs e)
        {
            ThemLoaiTien f = new ThemLoaiTien();
            f.ShowDialog();

        }

        private void btnThemChamCong_Click(object sender, EventArgs e)
        {

        }

        private void btnThemPhongBan_Click_1(object sender, EventArgs e)
        {
            FrmThemGiaoDichLuong f = new FrmThemGiaoDichLuong();
            f.ShowDialog();

        }

        private void tabQLLuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            dateTuNgay.Checked = false;
            dateDenNgay.Checked = false;
            ConfigureComboBoxLoaiGiaoDich();
            TimKiemVaHienThi();
            loadBangLuong();
        }
        private void TimKiemVaHienThi()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_TimKiemGiaoDichLuong", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Lấy các giá trị từ bộ lọc
                        string keyword = txtTimKiem.Text.Trim();

                        // Thêm các tham số vào command
                        cmd.Parameters.AddWithValue("@Keyword", string.IsNullOrEmpty(keyword) ? (object)DBNull.Value : keyword);
                        if (dateTuNgay.Checked && dateDenNgay.Checked)
                        {
                            // Nếu có, lấy giá trị ngày tháng
                            cmd.Parameters.AddWithValue("@TuNgay", dateTuNgay.Value.Date);
                            cmd.Parameters.AddWithValue("@DenNgay", dateDenNgay.Value.Date);
                        }
                        else
                        {
                            // Nếu không, gửi NULL để bỏ qua bộ lọc
                            cmd.Parameters.AddWithValue("@TuNgay", (object)DBNull.Value);
                            cmd.Parameters.AddWithValue("@DenNgay", (object)DBNull.Value);
                        }
                        cmd.Parameters.AddWithValue("@TrangThai", cmbTrangThai.SelectedValue);

                        // **MỚI: Thêm tham số cho Loại Giao Dịch**
                        cmd.Parameters.AddWithValue("@LoaiGiaoDich", cmbLoai.SelectedValue);


                        // Thực thi và đổ dữ liệu
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvGiaoDich.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tabQuanLyGDL_Click(object sender, EventArgs e)
        {

            TimKiemVaHienThi();
            loadBangLuong();


        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            // 1. Xóa trắng ô tìm kiếm
            txtTimKiem.Clear();

            // 2. Đặt lại ComboBox Loại giao dịch về "Tất cả" (index 0)
            if (cmbLoai.Items.Count > 0)
                cmbLoai.SelectedIndex = 0;

            // 3. Đặt lại ComboBox Trạng thái về "Hoạt động" (index 1)
            if (cmbTrangThai.Items.Count > 1)
                cmbTrangThai.SelectedIndex = 1;

            // 4. Bỏ check các DateTimePicker
            dateTuNgay.Checked = false;
            dateDenNgay.Checked = false;
            TimKiemVaHienThi();

        }

        private void btnApDungLuong_Click(object sender, EventArgs e)
        {
            TimKiemVaHienThi();
        }
        public class LoaiGiaoDichItem
        {
            public string Text { get; set; }
            public object Value { get; set; }
        }
        private void ConfigureComboBoxLoaiGiaoDich()
        {
            var dataSource = new List<LoaiGiaoDichItem>();
            dataSource.Add(new LoaiGiaoDichItem { Text = "Tất cả các loại", Value = DBNull.Value });
            dataSource.Add(new LoaiGiaoDichItem { Text = "Thưởng", Value = "Thưởng" });
            dataSource.Add(new LoaiGiaoDichItem { Text = "Phạt", Value = "Phạt" });
            dataSource.Add(new LoaiGiaoDichItem { Text = "Tạm ứng", Value = "Tạm ứng" });

            // 3 dòng quan trọng:
            cmbLoai.DataSource = dataSource;
            cmbLoai.DisplayMember = "Text";     // Cho ComboBox biết cột nào để HIỂN THỊ
            cmbLoai.ValueMember = "Value";      // **LỖI THƯỜNG Ở ĐÂY:** Cho ComboBox biết cột nào là GIÁ TRỊ THỰC SỰ

            cmbLoai.SelectedIndex = 0;
        }
        String selectedMaGD; // Dùng để lưu mã nhân viên đang được chọn

        private void dgvGiaoDich_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvGiaoDich.Rows[e.RowIndex];
                // Lưu lại mã nhân viên của hàng đang được chọn
                this.selectedMaGD = row.Cells[0].Value.ToString();
            }
        }

        private void btnXoaGiaoDich_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_XoaMemGiaoDichLuong", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        if (string.IsNullOrEmpty(selectedMaGD))
                        {
                            MessageBox.Show("Vui lòng nhập mã giao dịch cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        cmd.Parameters.AddWithValue("@MaGiaoDich", selectedMaGD);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xoá thành công");
                        TimKiemVaHienThi();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xóa giao dịch: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSuaThongTinGiaoDich_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedMaGD))
            {
                MessageBox.Show("Vui lòng chọn giao dịch cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int MaGD = int.Parse(selectedMaGD);
            FrmThemGiaoDichLuong f = new FrmThemGiaoDichLuong(MaGD);
            f.ShowDialog();

        }

        private void btnTinhLuongCaNhan_Click(object sender, EventArgs e)
        {
            TinhLuongChoCaNhan f = new TinhLuongChoCaNhan();
            f.ShowDialog();

        }
        private void loadBangLuong()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("select * from vw_ChiTietBangLuong", conn))
                    {

                        cmd.CommandType = CommandType.Text;

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvBangLuong.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async  void btnThemChamCong_Click_1(object sender, EventArgs e)
        {
            // Cân nhắc thêm một thông báo để người dùng biết quá trình đang bắt đầu
            MessageBox.Show("Bắt đầu quá trình tính lương hàng loạt. Vui lòng chờ trong giây lát...",
                            "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            try
            {
                // Dùng 'using' cho cả connection để đảm bảo nó luôn được đóng
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    await conn.OpenAsync(); // Mở kết nối bất đồng bộ

                    using (SqlCommand cmd = new SqlCommand("sp_TinhLuongHangLoat", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Tăng thời gian chờ lên 5 phút (300 giây)
                        cmd.CommandTimeout = 300;

                        // Lấy giá trị ngày tháng từ control trên form của bạn
                        // Ví dụ: DateTime dateTuNgay = dtpTuNgay.Value;
                        //       DateTime dateDenNgay = dtpDenNgay.Value;
                     
                        cmd.Parameters.AddWithValue("@TuNgay", dateLuongTuNgay.Value);
                        cmd.Parameters.AddWithValue("@DenNgay", dateLuongDenNgay.Value);

                        // Thực thi bất đồng bộ, không làm treo giao diện
                        await cmd.ExecuteNonQueryAsync();

                        MessageBox.Show("Tính lương hàng loạt thành công!", "Hoàn Tất",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Load lại dữ liệu sau khi hoàn tất
                        loadBangLuong();
                    }
                }
            }
            catch (Exception ex)
            {
                // Nếu có lỗi, hiển thị thông báo chi tiết
                MessageBox.Show("Đã xảy ra lỗi trong quá trình tính lương:\n" + ex.Message,
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        String MaBL;
        private void dgvBangLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBangLuong.Rows[e.RowIndex];
                // Lưu lại mã nhân viên của hàng đang được chọn
                this.MaBL = row.Cells[0].Value.ToString();
            }
        }

        private void btnXacNhanThanhToan_Click(object sender, EventArgs e)
        {
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_XacNhanThanhToanLuong", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        if (string.IsNullOrEmpty(MaBL))
                        {
                            MessageBox.Show("Vui lòng nhập mã bảng lương cần xác nhận.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        cmd.Parameters.AddWithValue("@MaBangLuong", MaBL);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xác nhận thành công");
                        loadBangLuong();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xác nhận bảng lương: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoaBangLuong_Click(object sender, EventArgs e)
        {
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_XoaBangLuong", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        if (string.IsNullOrEmpty(MaBL))
                        {
                            MessageBox.Show("Vui lòng nhập mã bảng lương cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        cmd.Parameters.AddWithValue("@MaBangLuong", MaBL);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xoá thành công");
                        loadBangLuong();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xóa bảng lương: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
