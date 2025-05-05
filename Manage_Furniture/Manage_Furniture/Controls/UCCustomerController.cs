using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Manage_Furniture.ADO;
using Manage_Furniture.Models;
namespace Manage_Furniture.Controls
{
    
    internal class UCCustomerController
    {
        mananger_furnitureDataContext context = new mananger_furnitureDataContext();
        
        public Customerclass GetCustomerFromRow(DataGridViewRow row)
        {
            return new Customerclass
            {
                Id = Convert.ToInt32(row.Cells["col_id"].Value),
                Name = row.Cells["col_name"].Value?.ToString(),
                Phone = row.Cells["col_phone"].Value?.ToString(),
                Sex = row.Cells["col_sex"].Value?.ToString(),
                Address = row.Cells["col_address"].Value?.ToString(),
                Type = row.Cells["col_type"].Value?.ToString()
            };
        }
        public bool UpdateCustomer(Customerclass updatedCustomer, out string message)
        {
            if (updatedCustomer == null)
            {
                message = "Dữ liệu khách hàng bị rỗng.";
                return false;
            }

            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(updatedCustomer.Name))
            {
                message = "Tên khách hàng không được để trống.";
                return false;
            }

            if (!Regex.IsMatch(updatedCustomer.Phone ?? "", @"^\d{10,11}$"))
            {
                message = "Số điện thoại không hợp lệ (chỉ cho phép 10-11 chữ số).";
                return false;
            }

            try
            {
                var existingCustomer = context.customers.FirstOrDefault(c => c.id == updatedCustomer.Id);

                if (existingCustomer == null)
                {
                    message = "Không tìm thấy khách hàng cần cập nhật.";
                    return false;
                }

                // Cập nhật thông tin
                existingCustomer.name = updatedCustomer.Name;
                existingCustomer.phone = updatedCustomer.Phone;
                existingCustomer.sex = updatedCustomer.Sex;
                existingCustomer.address = updatedCustomer.Address;
                existingCustomer.type = updatedCustomer.Type;

                context.SubmitChanges();

                message = "Cập nhật thành công.";
                return true;
            }
            catch (Exception ex)
            {
                message = $"Lỗi khi cập nhật: {ex.Message}";
                return false;
            }
        }
        public void SearchCustomersByPhone(String txt_SearchPhone, DataGridView dgv_Customer)
        {
            string phoneNumber = txt_SearchPhone.Trim();
            Customerclass cc = new Customerclass();
            // Kiểm tra nếu số điện thoại không rỗng
            if (string.IsNullOrEmpty(phoneNumber))
            {
                // Nếu rỗng, hiển thị tất cả khách hàng
                dgv_Customer.DataSource = cc.GetAllCustomers();
                return;
            }

            // Tìm kiếm khách hàng theo số điện thoại
            List<customer> result = cc.SearchCustomersByPhone(phoneNumber);

            // Nếu không tìm thấy khách hàng
            if (result.Count == 0)
            {
                MessageBox.Show("Không tìm thấy khách hàng.", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv_Customer.DataSource = result; // Không có kết quả, xóa DataGridView
                return;
            }

            // Hiển thị kết quả tìm kiếm lên DataGridView
            dgv_Customer.DataSource = result;
        }
        public List<customer> FilterCustomers(string name, string phone, string sex, string address, string type)
        {
            var query = context.customers.AsQueryable();

            if (!string.IsNullOrWhiteSpace(name))
                query = query.Where(c => c.name.Contains(name));

            if (!string.IsNullOrWhiteSpace(phone))
                query = query.Where(c => c.phone.Contains(phone));

            if (!string.IsNullOrWhiteSpace(sex))
                query = query.Where(c => c.sex == sex);

            if (!string.IsNullOrWhiteSpace(address))
                query = query.Where(c => c.address.Contains(address));

            if (!string.IsNullOrWhiteSpace(type))
                query = query.Where(c => c.type.ToLower() == type.ToLower());


            return query.ToList();
        }
    }
}
        
  
