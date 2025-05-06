using Manage_Furniture.Models;
using System.Collections.Generic;
using System.Linq;
using System;


namespace Manage_Furniture.Controls
{
    internal class HRControl
    {
        private List<EmployeeModel> employees = new List<EmployeeModel>();

        public HRControl()
        {
            // Gọi phương thức EmployeeController() trong constructor để thêm dữ liệu giả khi khởi tạo
            EmployeeController();
        }

        public void EmployeeController()
        {
            // Fake data
            employees.Add(new EmployeeModel("NV001", "Nguyễn Văn A", "0912345678", "Man", "Hà Nội", "10,000,000", "Active"));
            employees.Add(new EmployeeModel("NV002", "Trần Thị B", "0987654321", "Female", "TP.HCM", "9,500,000", "Inactive"));
            employees.Add(new EmployeeModel("NV003", "Lê Văn C", "0909123456", "Man", "Đà Nẵng", "11,000,000", "Active"));
            employees.Add(new EmployeeModel("NV004", "Phạm Thị D", "0932123456", "Female", "Cần Thơ", "8,800,000", "Inactive"));
        }

        public List<EmployeeModel> GetAll(string status = null)
        {
            if (!string.IsNullOrEmpty(status))
            {
                // Lọc dữ liệu theo trạng thái
                return employees.Where(e => e.Status.Equals(status, StringComparison.OrdinalIgnoreCase)).ToList();
            }
            return employees;
        }

        public void AddEmployee(EmployeeModel emp)
        {
            employees.Add(emp);
        }

        public void DeleteEmployee(string id)
        {
            var emp = employees.Find(e => e.Id == id);
            if (emp != null)
            {
                employees.Remove(emp);
            }
        }
        public List<EmployeeModel> SearchEmployees(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
            {
                return employees;
            }

            return employees.Where(e =>
                 e.Id.ToLower().Contains(keyword.ToLower()) ||
                 e.Name.ToLower().Contains(keyword.ToLower()) ||
                 e.Phone.ToLower().Contains(keyword.ToLower()) ||
                 e.Address.ToLower().Contains(keyword.ToLower())
             ).ToList();

        }

    }
}
