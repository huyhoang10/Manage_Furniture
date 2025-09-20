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
using Manage_Furniture.Forms;

namespace Manage_Furniture
{
    public partial class FrmThemPhongBan : Form
    {
        Boolean isEditMode = false;
        public FrmThemPhongBan()

        {
            // Fix: Assign the string to the correct property of the Guna2HtmlLabel control  
            InitializeComponent();
            title.Text = "THÊM PHÒNG BAN"; // Assuming lblTitle is the Guna2HtmlLabel control  
        }

        public FrmThemPhongBan(string maPhongBan, string tenPhongBan)
        {
            InitializeComponent();
            txtMaPhongBan.Text = maPhongBan;
            txtTenPhongBan.Text = tenPhongBan;
            title.Text = "SỬA PHÒNG BAN";
            isEditMode = true;

        }
        String connectionString = CurrentUserSession.ConnectionString;
        private void FrmThemPhongBan_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (isEditMode)
            {
                // Chế độ sửa
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    // Cập nhật phòng ban bằng cách gọi thủ tục lưu trữ  
                    SqlCommand cmd = new SqlCommand("sp_SuaPhongBan", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaPhongBan", txtMaPhongBan.Text);
                    cmd.Parameters.AddWithValue("@TenPhongBanMoi", txtTenPhongBan.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật phòng ban thành công!");
                    con.Close();
                    this.Close();
                }
                return;
            }
            
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                // Thêm phòng ban bằng cách gọi thủ tục lưu trữ  
                SqlCommand cmd = new SqlCommand("sp_ThemPhongBan", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TenPhongBan", txtTenPhongBan.Text);
                cmd.Parameters.AddWithValue("@MaPhongBan", txtMaPhongBan.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm phòng ban thành công!");
                con.Close();
                this.Close();
                return;
            }
        }
    }
}
