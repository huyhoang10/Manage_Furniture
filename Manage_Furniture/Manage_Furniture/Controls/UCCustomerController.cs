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
using ClosedXML.Excel;
using System.IO;

namespace Manage_Furniture.Controls
{
    
    internal class UCCustomerController
    {
        public static manager_furnitureDataContext db = new manager_furnitureDataContext();
        
        public Customerclass GetCustomerFromRow(DataGridViewRow row)
        {
            return new Customerclass
            {
                Id = row.Cells[0].Value?.ToString(),//Id = row.Cells["col_id"].Value?.ToString(),
                //Name = row.Cells["col_name"].Value?.ToString(),
                //Phone = row.Cells["col_phone"].Value?.ToString(),
                //Sex = row.Cells["col_sex"].Value?.ToString(),
                //Address = row.Cells["col_address"].Value?.ToString(),
                //Type = row.Cells["col_type"].Value?.ToString()
                Name = row.Cells[1].Value?.ToString(),
                Phone = row.Cells[2].Value?.ToString(),
                Sex = row.Cells[3].Value?.ToString(),
                Address = row.Cells[4].Value?.ToString(),
                Type = row.Cells[5].Value?.ToString()
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
                int customerId = Convert.ToInt32(updatedCustomer.Id);

                // Kiểm tra trùng số điện thoại (trừ chính khách hàng đang chỉnh sửa)
                bool isDuplicatePhone = db.customers.Any(c =>
                    c.phone == updatedCustomer.Phone && c.id != customerId);

                if (isDuplicatePhone)
                {
                    message = "This phone number is already in use by another customer.";
                    return false;
                }

                var existingCustomer = db.customers.FirstOrDefault(c => c.id == customerId);

                if (existingCustomer == null)
                {
                    message = "Customer not found.";
                    return false;
                }
                var customerWithSamePhone = db.customers
                    .FirstOrDefault(c => c.phone == updatedCustomer.Phone && c.id.ToString() != updatedCustomer.Id);
                if (customerWithSamePhone != null)
                {
                    message = "Phone number already exists.";
                    return false;
                }
                // Update info
                existingCustomer.name = updatedCustomer.Name;
                existingCustomer.phone = updatedCustomer.Phone;
                existingCustomer.sex = updatedCustomer.Sex;
                existingCustomer.address = updatedCustomer.Address;
                existingCustomer.type = updatedCustomer.Type;

                db.SubmitChanges();

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
            var query = db.customers.AsQueryable();  // Bắt đầu với một truy vấn cơ sở dữ liệu
            if (!string.IsNullOrWhiteSpace(type))
                query = query.Where(c => c.type.ToLower() == type.ToLower());  // Lọc theo loại

            // Trả về danh sách khách hàng đã lọc
            return query.ToList();
        }
        public void ExportCustomersToExcel(List<customer> customers)
        {
            using (SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "Excel files (*.xlsx)|*.xlsx",
                Title = "Save Customer List"
            })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    // Tạo workbook mới
                    using (var workbook = new XLWorkbook())
                    {
                        // Thêm worksheet vào workbook
                        var worksheet = workbook.Worksheets.Add("Customers");

                        // Header
                        worksheet.Cell(1, 1).Value = "ID";
                        worksheet.Cell(1, 2).Value = "Name";
                        worksheet.Cell(1, 3).Value = "Phone";
                        worksheet.Cell(1, 4).Value = "Sex";
                        worksheet.Cell(1, 5).Value = "Address";
                        worksheet.Cell(1, 6).Value = "Type";

                        // Dữ liệu
                        for (int i = 0; i < customers.Count; i++)
                        {
                            worksheet.Cell(i + 2, 1).Value = customers[i].id;
                            worksheet.Cell(i + 2, 2).Value = customers[i].name;
                            worksheet.Cell(i + 2, 3).Value = customers[i].phone;
                            worksheet.Cell(i + 2, 4).Value = customers[i].sex;
                            worksheet.Cell(i + 2, 5).Value = customers[i].address;
                            worksheet.Cell(i + 2, 6).Value = customers[i].type;
                        }

                        // Lưu file
                        workbook.SaveAs(sfd.FileName);
                        MessageBox.Show("Export successful!", "Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
        
  
