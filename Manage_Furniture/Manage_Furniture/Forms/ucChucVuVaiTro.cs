using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Manage_Furniture.Forms
{
    public partial class ucChucVuVaiTro : UserControl
    {
  
        public ucChucVuVaiTro()
        {
            InitializeComponent();
            loadChucVu();
            loadVaiTro();
            LoadDataCaLamViec();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnApDung_Click(object sender, EventArgs e)
        {

        }

        private void dgvBangNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThemPhongBan_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void btnThemPhongBan_Click_1(object sender, EventArgs e)
        {
            FrmThemChucVu frmThemChucVu = new FrmThemChucVu();
            frmThemChucVu.ShowDialog();
            loadChucVu();


        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            FrmThemVaiTro f = new FrmThemVaiTro();
            f.ShowDialog();
            loadVaiTro();
           
        }
        String connectionString = "Data Source=.;Initial Catalog=DBMS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        private void tabPage2_Click(object sender, EventArgs e)
        {
           
        }
        private void loadChucVu()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // thủ tục lấy danh sách
                SqlCommand command = new SqlCommand("sp_LayDanhSachChucVu", connection);
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvBangChucVu.DataSource = dataTable;

            }
        }
        private void loadVaiTro()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // thủ tục lấy danh sách
                SqlCommand command = new SqlCommand("sp_LayDanhSachVaiTro", connection);
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvBangVaiTro.DataSource = dataTable;

            }
        }


        private void tabChucvu_Click(object sender, EventArgs e)
        {
            loadChucVu();
            LoadDataCaLamViec();
            loadVaiTro();

        }
        String MaCv;
        String TenCv;
        String MaVT;
        String TenVT;
        private void dgvBangChucVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy row đang click
                DataGridViewRow row = dgvBangChucVu.Rows[e.RowIndex];

                MaCv = row.Cells[0].Value.ToString();
                TenCv = row.Cells[1].Value.ToString();
               


            }
        }
        
           


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FrmThemChucVu frmThemChucVu = new FrmThemChucVu(MaCv, TenCv);
            frmThemChucVu.ShowDialog();
            loadChucVu();
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                // Cập nhật phòng ban bằng cách gọi thủ tục lưu trữ  
                SqlCommand cmd = new SqlCommand("sp_XoaChucVu", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaChucVu", MaCv);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa chúc vụ thành công!");
                con.Close();
                loadChucVu();
            }
        }

        private void btnApDung_Click_1(object sender, EventArgs e)
        {

        }

       

        private void dgvBangVaiTro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
            if (e.RowIndex >= 0)
            {
                // Lấy row đang click
                DataGridViewRow row = dgvBangVaiTro.Rows[e.RowIndex];

                MaVT = row.Cells[0].Value.ToString();
                TenVT = row.Cells[1].Value.ToString();



            }

        }
        private void btnSuaVaiTro_Click(object sender, EventArgs e)
        {
            FrmThemVaiTro f = new FrmThemVaiTro(MaVT, TenVT);
            f.ShowDialog();
            loadVaiTro();
        }

        private void btnXoaVaiTro_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                // Cập nhật phòng ban bằng cách gọi thủ tục lưu trữ  
                SqlCommand cmd = new SqlCommand("sp_XoaVaiTro", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaVaiTro", MaVT);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa vai trò thành công!");
                con.Close();
                loadVaiTro();
            }

        }

        private void btnThemCaLam_Click(object sender, EventArgs e)
        {
            ThemCaLam themCaLam = new ThemCaLam();
            themCaLam.ShowDialog();
            LoadDataCaLamViec();

        }
        private void LoadDataCaLamViec()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_TimKiemCaLamViec", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Lấy từ khóa từ TextBox và truyền vào tham số
                    string keyword = txtTimKiemCaLam.Text.Trim();
                    cmd.Parameters.AddWithValue("@Keyword", string.IsNullOrEmpty(keyword) ? (object)DBNull.Value : keyword);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);


                    dgvCaLam.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
       

        private void btnApDungCaLam_Click(object sender, EventArgs e)
        {
            LoadDataCaLamViec();
        }

        string MaCa;
        private void dgvCaLam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCaLam.Rows[e.RowIndex];
                MaCa = row.Cells[0].Value.ToString();

            }
        }
        private void btnSuaCaLam_Click(object sender, EventArgs e)
        {
            ThemCaLam themCaLam = new ThemCaLam(MaCa);

            themCaLam.ShowDialog();
            LoadDataCaLamViec();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            using(SqlConnection con = new SqlConnection(connectionString))
            {
                if(MessageBox.Show("Bạn có chắc chắn muốn xóa ca làm này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }

                con.Open();
                // Cập nhật phòng ban bằng cách gọi thủ tục lưu trữ  
                SqlCommand cmd = new SqlCommand("sp_XoaCaLamViec", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaCa", MaCa);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa ca làm thành công!");
                con.Close();
                LoadDataCaLamViec();
            }
        }
    }
}
