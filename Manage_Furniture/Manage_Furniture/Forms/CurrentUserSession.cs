using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Furniture.Forms
{
    public static class CurrentUserSession
    {
        // Chỉ giữ duy nhất chuỗi kết nối
        public static string ConnectionString { get; private set; }

        // Các thông tin bổ sung nếu bạn muốn
        public static string TenDangNhap { get; private set; }
        public static string Vaitro { get; private set; }

        public static void StartSession(string connectionString, string tenDangNhap, string hoTen)
        {
            ConnectionString = connectionString;
            TenDangNhap = tenDangNhap;
            Vaitro = hoTen;
        }

        public static void EndSession()
        {
            ConnectionString = null;
            TenDangNhap = null;
            Vaitro = null;
        }
    }
}
