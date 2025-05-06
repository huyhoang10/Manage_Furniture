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
                message = "Customer data is null.";
                return false;
            }

            // Validate input
            if (string.IsNullOrWhiteSpace(updatedCustomer.Name))
            {
                message = "Customer name cannot be empty.";
                return false;
            }

            if (!Regex.IsMatch(updatedCustomer.Phone ?? "", @"^\d{10,11}$"))
            {
                message = "Invalid phone number (must be 10–11 digits).";
                return false;
            }

            try
            {
                var existingCustomer = context.customers.FirstOrDefault(c => c.id == updatedCustomer.Id);

                if (existingCustomer == null)
                {
                    message = "Customer not found.";
                    return false;
                }

                // Update info
                existingCustomer.name = updatedCustomer.Name;
                existingCustomer.phone = updatedCustomer.Phone;
                existingCustomer.sex = updatedCustomer.Sex;
                existingCustomer.address = updatedCustomer.Address;
                existingCustomer.type = updatedCustomer.Type;

                context.SubmitChanges();

                message = "Update successful.";
                return true;
            }
            catch (Exception ex)
            {
                message = $"Error while updating: {ex.Message}";
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
                MessageBox.Show("Customer not found.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv_Customer.DataSource = result;
                return;
            }

            // Hiển thị kết quả tìm kiếm lên DataGridView
            dgv_Customer.DataSource = result;
        }
        public List<customer> FilterCustomers(string type)
        {
            var query = context.customers.AsQueryable();  // Bắt đầu với một truy vấn cơ sở dữ liệu
            if (!string.IsNullOrWhiteSpace(type))
                query = query.Where(c => c.type.ToLower() == type.ToLower());  // Lọc theo loại

            // Trả về danh sách khách hàng đã lọc
            return query.ToList();
        }
    }
}
        
  
