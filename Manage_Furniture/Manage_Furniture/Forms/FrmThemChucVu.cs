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
    public partial class FrmThemChucVu : Form
    {
        bool is_edit = true;
        public FrmThemChucVu()
        {
            InitializeComponent();
            is_edit = false;
        }
        
        public FrmThemChucVu(String MaCv, String TenCv)
        {
            InitializeComponent();
            title.Text = "SỬA CHỨC VỤ";
            txtMaPhongBan.Text = MaCv;
            txtTenPhongBan.Text = TenCv;
        }
        String connectionString = CurrentUserSession.ConnectionString;
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (!is_edit)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand("sp_ThemChucVu", connection);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@TenChucVu", txtTenPhongBan.Text);
                        command.Parameters.AddWithValue("@MaChucVu", txtMaPhongBan.Text);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Thêm chức vụ thành công");
                        this.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }



                }
                return;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("sp_SuaChucVu", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@TenChucVuMoi", txtTenPhongBan.Text);
                    command.Parameters.AddWithValue("@MaChucVu", txtMaPhongBan.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Sửa chức vụ thành công");
                    this.Close();

                    return;

                }
                 catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void FrmThemChucVu_Load(object sender, EventArgs e)
        {

        }
    }
}
