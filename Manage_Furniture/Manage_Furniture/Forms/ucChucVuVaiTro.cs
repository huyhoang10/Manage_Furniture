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
        }

       
        
        private void btnThemPhongBan_Click_1(object sender, EventArgs e)
        {
            FrmThemChucVu frmThemChucVu = new FrmThemChucVu();
            frmThemChucVu.ShowDialog();
            loadChucVu();


        }
        
       
        private void loadChucVu()
        {
            using (SqlConnection connection = new SqlConnection(CurrentUserSession.ConnectionString))
            {
                connection.Open();
                try
                {
                    SqlCommand command = new SqlCommand("select * from v_DanhSachChucVu", connection);
                    
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgvBangChucVu.DataSource = dataTable;
                }   
                catch(Exception ezz)
                {
                    MessageBox.Show(ezz.ToString());
                }

            }
        }
        

        private void tabChucvu_Click(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                loadChucVu();
                LoadDataCaLamViec();
                
            }

        }
        String MaCv;
        String TenCv;
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
            using (SqlConnection con = new SqlConnection(CurrentUserSession.ConnectionString))
            {
                try
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
                catch (SqlException ex) // Bắt lỗi SQL một cách cụ thể
                {
                    // Chỉ hiển thị thông báo lỗi từ SQL Server cho người dùng
                    // ex.Message sẽ chính là câu "Không thể xóa ca làm việc..."
                    MessageBox.Show(ex.Message, "Không thể thực hiện", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex) // Bắt các loại lỗi chung khác (ví dụ: mất kết nối)
                {
                    // Ghi log lỗi chi tiết cho lập trình viên xem (tùy chọn)
                    System.Diagnostics.Debug.WriteLine(ex.ToString());

                    // Hiển thị một thông báo chung chung cho người dùng
                    MessageBox.Show("Đã có lỗi không xác định xảy ra, vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }       

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
            using (SqlConnection conn = new SqlConnection(CurrentUserSession.ConnectionString))
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
            using(SqlConnection con = new SqlConnection(CurrentUserSession.ConnectionString))
            {
                try
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn xóa ca làm này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
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
                catch (SqlException ex) // Bắt lỗi SQL một cách cụ thể
                {
                    // Chỉ hiển thị thông báo lỗi từ SQL Server cho người dùng
                    // ex.Message sẽ chính là câu "Không thể xóa ca làm việc..."
                    MessageBox.Show(ex.Message, "Không thể thực hiện", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex) // Bắt các loại lỗi chung khác (ví dụ: mất kết nối)
                {
                    // Ghi log lỗi chi tiết cho lập trình viên xem (tùy chọn)
                    System.Diagnostics.Debug.WriteLine(ex.ToString());

                    // Hiển thị một thông báo chung chung cho người dùng
                    MessageBox.Show("Đã có lỗi không xác định xảy ra, vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            if(!this.DesignMode)
            {
                loadChucVu();
                LoadDataCaLamViec();
            }
        }

        private void ucChucVuVaiTro_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                // Gọi các hàm load dữ liệu lần đầu ở đây
                loadChucVu();
                LoadDataCaLamViec();
                // loadVaiTro(); // Nếu có
            }
        }

        private void btnApDung_Click(object sender, EventArgs e)
        {
            using(SqlConnection con = new SqlConnection(CurrentUserSession.ConnectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_TimKiemChucVu", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (txtTimKiem.Text.Trim() != "")
                    {
                        cmd.Parameters.AddWithValue("@Keyword", txtTimKiem.Text.Trim());
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Keyword", DBNull.Value);
                    }
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvBangChucVu.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải danh sách chức vụ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLamMoiChucVu_Click(object sender, EventArgs e)
        {
            loadChucVu();
            txtTimKiem.Clear();
            
        }
    }
}
