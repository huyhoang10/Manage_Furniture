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
using Manage_Furniture.ADO;
using Manage_Furniture.Controls;


namespace Manage_Furniture.Forms
{
   
    public partial class FLogin : Form
    {
        
        public FLogin()
        {
            InitializeComponent();
        }

        private async void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text.Trim();
            string password = txt_passwd.Text;

            this.Cursor = Cursors.WaitCursor;
            try
            {
                string connectionString = $"Data Source=.;Initial Catalog=DBMS;User ID={username};Password={password};Encrypt=True;TrustServerCertificate=True";

                // DÙNG 'USING' ĐỂ ĐẢM BẢO KẾT NỐI LUÔN ĐƯỢC ĐÓNG
                using (SqlConnection userConnection = new SqlConnection(connectionString))
                {
                    await userConnection.OpenAsync();

                    string hoTen = "";
                    string vaiTro = "";

                    // CÂU QUERY ĐƠN GIẢN HƠN RẤT NHIỀU
                    string query = @"
                SELECT nv.HoTen, tk.VaiTro
                FROM TAIKHOAN tk
                JOIN NHANVIEN nv ON tk.MaNV = nv.MaNV
                WHERE tk.TenDangNhap = @TenDangNhap";

                    using (SqlCommand cmd = new SqlCommand(query, userConnection))
                    {
                        cmd.Parameters.AddWithValue("@TenDangNhap", username);
                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                hoTen = reader["HoTen"].ToString();
                                vaiTro = reader["VaiTro"].ToString();
                            }
                            else
                            {
                                // Trường hợp hiếm: login SQL thành công nhưng không tìm thấy record trong bảng TAIKHOAN
                                throw new Exception("Thông tin tài khoản không được cấu hình đúng trong hệ thống.");
                            }
                        }
                    }

                    // ĐĂNG NHẬP THÀNH CÔNG -> GỌI StartSession MỘT LẦN DUY NHẤT VỚI DỮ LIỆU ĐÚNG
                    CurrentUserSession.StartSession(connectionString, username, vaiTro);
                }

                // Mở form sau
                FAdmin f = new FAdmin();
                f.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đăng nhập thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
    }
}
