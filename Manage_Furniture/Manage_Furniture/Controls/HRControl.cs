using Manage_Furniture.Models;
using System.Collections.Generic;
using System.Linq;
using Manage_Furniture.ADO;
using System.Windows.Forms;
using ClosedXML.Excel;
using System;
using System.IO;

namespace Manage_Furniture.Controls
{
    internal class HRControl
    {
        private manager_furnitureDataContext db = new manager_furnitureDataContext();

        public List<EmployeeModel> GetAll(string status = null)
        {
            var query = db.employees.AsQueryable();

            if (!string.IsNullOrEmpty(status))
            {
                query = query.Where(e => e.status.Equals(status));
            }

            var result = query.Select(e => new EmployeeModel(
                e.id.ToString(),
                e.name,
                e.phone,
                e.sex,
                e.address,
                e.salary.ToString(),
                e.password,
                e.status
            )).ToList();

            // Định dạng lại salary sau khi lấy từ DB
            return result.Select(emp => new EmployeeModel(
                emp.Id,
                emp.Name,
                emp.Phone,
                emp.Sex,
                emp.Address,
                decimal.TryParse(emp.Salary, out decimal salary) ? salary.ToString("N0") : "0", // Định dạng sau khi lấy dữ liệu
                emp.Password,
                emp.Status
            )).ToList();
        }
        public bool IsEmployeeIdExists(string id)
        {
            return db.employees.Any(e => e.id.ToString() == id);
        }
    

        public void AddEmployee(EmployeeModel emp)

        {
            // Kiểm tra xem id đã tồn tại trong cơ sở dữ liệu chưa
            var existingEmp = db.employees.FirstOrDefault(e => e.id.ToString() == emp.Id);
            if (existingEmp != null)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;  // Không thêm nhân viên mới
            }
            var newEmp = new employee
            {
                id = int.Parse(emp.Id),  // Convert string to int for id
                name = emp.Name,
                phone = emp.Phone,
                sex = emp.Sex,
                address = emp.Address,
                salary = decimal.Parse(emp.Salary.Replace(",", "")),
                password = emp.Password,
                status = emp.Status
            };

            db.employees.InsertOnSubmit(newEmp);
            db.SubmitChanges();
        }
        public bool IsPhoneExists(string phone, string excludeId = null)
        {
            if (string.IsNullOrEmpty(excludeId))
            {
                return db.employees.Any(e => e.phone == phone);
            }
            else
            {
                return db.employees.Any(e => e.phone == phone && e.id.ToString() != excludeId);
            }
        }

        public void BlockEmployee(int id)  // Use int for id
        {
            var emp = db.employees.FirstOrDefault(e => e.id == id);  // Ensure id is of type int
            if (emp != null)
            {
                emp.status = "Inactive";  // Update the status to "Inactive"
                db.SubmitChanges();  // Save changes to the database
            }
        }
        public void UnblockEmployee(int id)  // Use int for id
        {
            var emp = db.employees.FirstOrDefault(e => e.id == id);  // Ensure id is of type int
            if (emp != null)
            {
                emp.status = "Active";  // Update the status to "Active"
                db.SubmitChanges();  // Save changes to the database
            }
        }
        public bool DeleteEmployee(int id)
        {
            try
            {
                var employee = db.employees.FirstOrDefault(emp => emp.id == id);
                if (employee == null) return false;

                db.employees.DeleteOnSubmit(employee);
                db.SubmitChanges(); // Không cần db.employees.Context
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void UpdateEmployee(EmployeeModel emp)
        {
            var existing = db.employees.FirstOrDefault(e => e.id == int.Parse(emp.Id));  // Convert string to int for id
            if (existing != null)
            {
                existing.name = emp.Name;
                existing.phone = emp.Phone;
                existing.sex = emp.Sex;
                existing.address = emp.Address;
                existing.salary = decimal.Parse(emp.Salary.Replace(",", ""));
                existing.status = emp.Status;
                existing.password = emp.Password;  // Update password if needed

                db.SubmitChanges();
            }
        }

        public List<EmployeeModel> SearchEmployees(string keyword)
        {
            var query = db.employees.AsQueryable();

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                query = query.Where(e =>
                    e.id.ToString().Contains(keyword) ||  // Convert id to string for search (if id is int)
                    e.name.Contains(keyword) ||
                    e.phone.Contains(keyword) ||
                    e.address.Contains(keyword)
                );
            }

            // Lấy danh sách nhân viên từ cơ sở dữ liệu
            var employees = query.ToList();

            // Định dạng salary trong bộ nhớ
            return employees.Select(e => new EmployeeModel(
                e.id.ToString(),  // Convert id to string to match EmployeeModel constructor
                e.name,
                e.phone,
                e.sex,
                e.address,
                e.salary.HasValue ? e.salary.Value.ToString("N0") : "0",
                e.password,
                e.status
            )).ToList();
        }
        public void ExportEmployeesToExcel(List<EmployeeModel> employees)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Employees");

                // Tiêu đề cột
                worksheet.Cell(1, 1).Value = "ID";
                worksheet.Cell(1, 2).Value = "Name";
                worksheet.Cell(1, 3).Value = "Phone";
                worksheet.Cell(1, 4).Value = "Sex";
                worksheet.Cell(1, 5).Value = "Address";
                worksheet.Cell(1, 6).Value = "Salary";
                worksheet.Cell(1, 7).Value = "Password";
                worksheet.Cell(1, 8).Value = "Status";

                // Đổ dữ liệu
                for (int i = 0; i < employees.Count; i++)
                {
                    var emp = employees[i];
                    worksheet.Cell(i + 2, 1).Value = emp.Id;
                    worksheet.Cell(i + 2, 2).Value = emp.Name;
                    worksheet.Cell(i + 2, 3).Value = emp.Phone;
                    worksheet.Cell(i + 2, 4).Value = emp.Sex;
                    worksheet.Cell(i + 2, 5).Value = emp.Address;
                    worksheet.Cell(i + 2, 6).Value = emp.Salary;
                    worksheet.Cell(i + 2, 7).Value = emp.Password;
                    worksheet.Cell(i + 2, 8).Value = emp.Status;
                }

                // Auto fit
                worksheet.Columns().AdjustToContents();

                // Lưu file
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel Workbook (*.xlsx)|*.xlsx",
                    Title = "Save Employees Excel File"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        workbook.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("Export successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error while saving Excel: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }
        }
    }

}
