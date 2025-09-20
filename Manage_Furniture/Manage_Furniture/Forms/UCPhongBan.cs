using Manage_Furniture.ADO;
using Manage_Furniture.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Manage_Furniture.Forms
{
    public partial class UCPhongBan : UserControl
    {
      
       
        public UCPhongBan()
        {
            InitializeComponent();
           
        }
        String connectionString = CurrentUserSession.ConnectionString;
        private void UCOrder_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                load();
            }
                
        }
        private void load()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM vw_PhongBan_NhanVien";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvBangNhanVien.DataSource = dt;
                    con.Close();
                }
                catch(Exception ezx)
                {
                    MessageBox.Show(ezx.ToString());
                }
                
            }

        }
        private void btnThemPhongBan_Click(object sender, EventArgs e)
        {
            FrmThemPhongBan themPhongBan = new FrmThemPhongBan();
            themPhongBan.ShowDialog();
            load();


        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
        }

        private void dgvBangNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        String maPB = "";
        String tenPB = "";
        private void dgvBangNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            using(SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                // Cập nhật phòng ban bằng cách gọi thủ tục lưu trữ  
                SqlCommand cmd = new SqlCommand("sp_XoaPhongBan", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaPhongBan", maPB);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa phòng ban thành công!");
                con.Close();
                load();
            }
        }

        private void dgvBangNhanVien_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvBangNhanVien_CellClick_2(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra người dùng có click vào header không
            if (e.RowIndex >= 0)
            {
                // Lấy row đang click
                DataGridViewRow row = dgvBangNhanVien.Rows[e.RowIndex];

                String maNV = row.Cells[0].Value.ToString();
                maPB = maNV;
                String tenNV = row.Cells[1].Value.ToString();
                tenPB = tenNV;
                // In ra console hoặc dùng cho form khác
                Console.WriteLine($"Mã NV: {maNV}, Họ tên: {tenNV}");

                
            }
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            FrmThemPhongBan themPhongBan = new FrmThemPhongBan(maPB, tenPB);
            themPhongBan.ShowDialog();
            load();
        }

        private void btnApDung_Click(object sender, EventArgs e)
        {
            using(SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_TimKiemPhongBan", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TenPhongBan", txtTimKiem.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvBangNhanVien.DataSource = dt;
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
        }
    }
}