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
    public partial class FrmThemVaiTro : Form
    {

        bool is_edit = true;
        string mavt;
        String connectionString = "Data Source=.;Initial Catalog=DBMS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        public FrmThemVaiTro()
        {
            InitializeComponent();
            is_edit = false;
        }
        public FrmThemVaiTro(String MaVT,String tenVT)
        {
            InitializeComponent();
            title.Text= "SỬA VAI TRÒ";
            mavt = MaVT;
            MessageBox.Show(mavt);
            txtTenPhongBan.Text = tenVT;
        }

        private void FrmThemVaiTro_Load(object sender, EventArgs e)
        {

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (!is_edit)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand("sp_ThemVaiTro", connection);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@TenVaiTro", txtTenPhongBan.Text);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Thêm vai trò thành công");
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
                    SqlCommand command = new SqlCommand("sp_SuaVaiTro", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@TenVaiTroMoi", txtTenPhongBan.Text);
                    command.Parameters.AddWithValue("@MaVaiTro", mavt);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Sửa vai trò thành công");
                    this.Close();

                    return;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
