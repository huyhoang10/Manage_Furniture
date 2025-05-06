using System;
using System.Windows.Forms;
using Manage_Furniture.Models;
using System.Linq;
using Manage_Furniture.Controls;
using Manage_Furniture.ADO;
using System.Drawing;
using System.Collections.Generic;

namespace Manage_Furniture.Controls
{
    public partial class ucHR : UserControl
    {
        private HRControl controller = new HRControl();

        public ucHR()
        {
            InitializeComponent();
        }

        private void ucHumanResourceManagement_Load(object sender, EventArgs e)
        {
            dgvView.AutoGenerateColumns = true;
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            dgvView.DataSource = null;
            dgvView.DataSource = controller.GetAll("Active"); // Lấy danh sách nhân viên từ cơ sở dữ liệu
            var employees = controller.GetAll();

            // Tuỳ chỉnh header cột (nếu cần)
            var activeEmployees = employees.Where(e => e.Status == "Active").ToList();
            var inactiveEmployees = employees.Where(e => e.Status == "Inactive").ToList();

            // Cập nhật số liệu
            txtTotalE.Text = employees.Count.ToString();
            txtEActive.Text = activeEmployees.Count.ToString();
            txtEInactive.Text = inactiveEmployees.Count.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text) || string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã NV và Tên.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            EmployeeModel newEmp = new EmployeeModel(
                txtId.Text,
                txtName.Text,
                txtPhone.Text,
                txtSex.Text,
                txtAddress.Text,
                txtSalary.Text,
                txtPassword.Text,
                "Active" // Mặc định trạng thái là Active
            );

            controller.AddEmployee(newEmp);  // Lưu nhân viên vào database
            RefreshGrid();  // Cập nhật lại Grid
            ClearInputs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xoá.", "Chưa chọn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Chuyển đổi id sang kiểu int
            int id = Convert.ToInt32(dgvView.SelectedRows[0].Cells["Id"].Value);
            controller.DeleteEmployee(id);  // Cập nhật trạng thái nhân viên thành Inactive
            RefreshGrid();  // Cập nhật lại Grid
            MessageBox.Show("Đã xoá nhân viên!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ClearInputs()
        {
            txtId.Clear();
            txtName.Clear();
            txtPhone.Clear();
            txtSex.Clear();
            txtAddress.Clear();
            txtSalary.Clear();
        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            btnActive.FillColor = Color.Green;  // Thay đổi màu nền
            btnInactive.FillColor = Color.White;
            btnAll.FillColor = Color.White;

            var activeEmployees = controller.GetAll("Active");
            dgvView.DataSource = null;
            dgvView.DataSource = activeEmployees;
        }

        private void btnInactive_Click(object sender, EventArgs e)
        {
            btnInactive.FillColor = Color.Green;  // Thay đổi màu nền
            btnActive.FillColor = Color.White;
            btnAll.FillColor = Color.White;

            var inactiveEmployees = controller.GetAll("Inactive");
            dgvView.DataSource = null;
            dgvView.DataSource = inactiveEmployees;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            var results = controller.SearchEmployees(keyword);  // Tìm kiếm nhân viên theo từ khoá
            dgvView.DataSource = null;
            dgvView.DataSource = results;
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = cmbFilter.SelectedItem.ToString();

            // Lấy toàn bộ danh sách nhân viên
            List<EmployeeModel> list = controller.GetAll("Active");

            if (selected == "Man" || selected == "Female")
            {
                list = list.Where(emp =>
                    emp.Sex.Equals(selected, StringComparison.OrdinalIgnoreCase)
                ).ToList();
            }
            else if (selected == "< 100$")
            { 
                
                list = list.Where(emp =>
                    decimal.TryParse(emp.Salary.Replace(",", ""), out decimal salary) && salary < 100
                ).ToList();
            }

            else if (selected == "100$ – 500$")
            {
               
                list = list.Where(emp =>
                    decimal.TryParse(emp.Salary.Replace(",", ""), out decimal salary) && salary >= 100 && salary <= 500
                ).ToList();
            }
            else if (selected == "> 500$")
            {
                list = list.Where(emp =>
                    decimal.TryParse(emp.Salary.Replace(",", ""), out decimal salary) && salary > 500
                ).ToList();
            }
            else if (selected == "All")
            {
                // Không cần lọc gì cả
                list = controller.GetAll("Active");
            }
            // Nếu là "All" thì không lọc gì

            dgvView.DataSource = null;
            dgvView.DataSource = list;
        }


        private void dgvView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvView.Rows[e.RowIndex];

                // Gán giá trị lên TextBox
                txtId.Text = row.Cells["Id"].Value?.ToString();
                txtName.Text = row.Cells["Name"].Value?.ToString();
                txtPhone.Text = row.Cells["Phone"].Value?.ToString();
                txtSex.Text = row.Cells["Sex"].Value?.ToString();
                txtAddress.Text = row.Cells["Address"].Value?.ToString();
                txtSalary.Text = row.Cells["Salary"].Value?.ToString();
                txtPassword.Text = row.Cells["password"].Value?.ToString();
                txtId.Enabled = false;  // Mã NV không được chỉnh sửa
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            btnAll.FillColor = Color.Green;  // Thay đổi màu nền
            btnActive.FillColor = Color.White;
            btnInactive.FillColor = Color.White;

            var allEmployees = controller.GetAll();  // Lấy tất cả nhân viên
            dgvView.DataSource = null;
            dgvView.DataSource = allEmployees;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn một hàng trong DataGridView chưa
            if (dgvView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên để chỉnh sửa.", "Chưa chọn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy id của nhân viên được chọn từ DataGridView
            string id = dgvView.SelectedRows[0].Cells["Id"].Value.ToString();

            // Lấy nhân viên từ cơ sở dữ liệu theo id
            var employee = controller.GetAll().FirstOrDefault(ee => ee.Id.ToString() == id);

            if (employee == null)
            {
                MessageBox.Show("Nhân viên không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tạo đối tượng EmployeeModel từ các TextBox và giữ nguyên trạng thái (status) cũ
            EmployeeModel updatedEmployee = new EmployeeModel(
                id,  // Giữ nguyên id vì đây là khóa chính
                txtName.Text,
                txtPhone.Text,
                txtSex.Text,
                txtAddress.Text,
                txtSalary.Text,
                employee.Status,
                txtPassword.Text
               
            );

            // Gọi controller để cập nhật thông tin nhân viên trong cơ sở dữ liệu
            controller.UpdateEmployee(updatedEmployee);

            // Cập nhật lại grid
            RefreshGrid();

            // Thông báo thành công
            MessageBox.Show("Thông tin nhân viên đã được cập nhật!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear các input sau khi cập nhật
            ClearInputs();
        }


    }
}
