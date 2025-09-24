using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manage_Furniture.Forms
{
    public partial class ucTrangChu : UserControl
    {
        public ucTrangChu()
        {
            InitializeComponent();
        }
        String connectionString = CurrentUserSession.ConnectionString;
        private void ucTrangChu_Load(object sender, EventArgs e)
        {
            load();
        }
        private void load()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM dbo.fn_ThongKeTongQuan()";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        lblTongNhanVien.Text = reader["TongNhanVien"].ToString();
                        lblNhanVienChinhThuc.Text = reader["NhanVienChinhThuc"].ToString();
                        lblNhanVienDaNghi.Text = reader["NhanVienDaNghi"].ToString();
                        lblNhanVienThucTap.Text = reader["NhanVienThucTap"].ToString();
                        decimal tongLuong = Convert.ToDecimal(reader["TongTienLuongDaTra"]);
                        CultureInfo culture = new CultureInfo("vi-VN");
                        lblTongLuong.Text = tongLuong.ToString("N0", culture) + " ₫";
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message);
                }
            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    // gọi thủ tục
                    SqlCommand cmd = new SqlCommand("sp_ThongKeLuongTheoThang", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Nam", DateTime.Now.Year);


                    // đổ vào data grid view

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvBangTongKet.DataSource = dt;


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message);
                }
            }


        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            load();
        }

        private void btnApDung_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    // gọi thủ tục
                    SqlCommand cmd = new SqlCommand("sp_ThongKeLuongTheoThang", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Nam", dtpNamThang.Value.Year);
                   

                    // đổ vào data grid view

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvBangTongKet.DataSource = dt;


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message);
                }
            }
        }

        private void dgvBangTongKet_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string columnName = dgvBangTongKet.Columns[e.ColumnIndex].Name;
            if (columnName == "Tổng tiền đã trả" && e.Value != null)
            {
                if (decimal.TryParse(e.Value.ToString(), out decimal value))
                {
                    CultureInfo culture = new CultureInfo("vi-VN");
                    e.Value = value.ToString("N0", culture) + " ₫";
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
