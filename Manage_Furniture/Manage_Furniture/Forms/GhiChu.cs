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
    public partial class GhiChu : Form
    {
        int Mabl;
        public GhiChu(string Mabl)
        {
            InitializeComponent();

            this.Mabl =  int.Parse(Mabl);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        String connectionString = CurrentUserSession.ConnectionString;
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            using(SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_ThemGhiChuBangLuong", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text);
                    cmd.Parameters.AddWithValue("@MaBangLuong", Mabl);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật ghi chú thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật ghi chú: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
