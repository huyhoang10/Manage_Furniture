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

        public void ucHumanResourceManagement_Load(object sender, EventArgs e)
        {
            dgvView.AutoGenerateColumns = true; // Đảm bảo tự động tạo cột bị tắt
                                                 
            //if (!dgvView.Columns.Contains("STT"))
            //{
            //    DataGridViewTextBoxColumn sttColumn = new DataGridViewTextBoxColumn();
            //    sttColumn.Name = "STT";
            //    sttColumn.HeaderText = "STT";
            //    sttColumn.ReadOnly = true;
            //    dgvView.Columns.Insert(0, sttColumn); // Thêm vào cột đầu tiên
            //}
        

            RefreshGrid();
        }

        private void RefreshGrid()
        {
            cmbSex.DrawMode = DrawMode.OwnerDrawFixed;
            cmbSex.ItemHeight = 56; 

            cmbSex.DrawItem += (s, e) =>
            {
                if (e.Index < 0) return;
                e.DrawBackground();
                string text = cmbSex.Items[e.Index].ToString();
                e.Graphics.DrawString(text, cmbSex.Font, Brushes.Black, e.Bounds);
                e.DrawFocusRectangle();
            };
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
            cmbFilter.SelectedIndex = 0;
            cmbSex.SelectedIndex = 0;
        }

        private string GenerateUniqueId()
        {
            Random rnd = new Random();
            string id;
            do
            {
                id = rnd.Next(100000, 999999).ToString();
            }
            while (controller.IsEmployeeIdExists(id)); // Kiểm tra trong DB
            return id;
        }
        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Random ID nếu cần (và không nhập tay)
            string generatedId = GenerateUniqueId();

            // Kiểm tra tên
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            // Kiểm tra số điện thoại
            if (string.IsNullOrWhiteSpace(txtPhone.Text) || !txtPhone.Text.All(char.IsDigit) || txtPhone.Text.Length < 9)
            {
                MessageBox.Show("Số điện thoại không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Kiểm tra số điện thoại đã tồn tại
            if (controller.IsPhoneExists(txtPhone.Text.Trim()))
            {
                MessageBox.Show("Số điện thoại đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // Kiểm tra giới tính (ComboBox)
            if (string.IsNullOrWhiteSpace(cmbSex.Text) || (cmbSex.Text != "Male" && cmbSex.Text != "Female"))
            {
                MessageBox.Show("Vui lòng chọn giới tính.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra địa chỉ
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra lương
            if (!decimal.TryParse(txtSalary.Text.Replace(",", ""), out decimal salary) || salary <= 0)
            {
                MessageBox.Show("Lương phải là số dương hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra mật khẩu
            if (string.IsNullOrWhiteSpace(txtPassword.Text) || txtPassword.Text.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo model và gọi thêm
            EmployeeModel newEmp = new EmployeeModel(
                generatedId,
                txtName.Text,
                txtPhone.Text,
                cmbSex.Text,
                txtAddress.Text,
                salary.ToString("N0"), // Lưu lương theo định dạng có dấu phẩy
                txtPassword.Text,
                "Active"
            );

            controller.AddEmployee(newEmp);
            RefreshGrid();
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
            
            txtName.Clear();
            txtPhone.Clear();
            cmbSex.Refresh();
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
            btnAll.FillColor = Color.Green;
            btnActive.FillColor = Color.White;
            string keyword = txtSearch.Text.Trim();
            var results = controller.SearchEmployees(keyword);  // Tìm kiếm nhân viên theo từ khoá
            dgvView.DataSource = null;
            dgvView.DataSource = results;
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAll.FillColor = Color.Green;  // Thay đổi màu nền
            btnActive.FillColor = Color.White;
            string selected = cmbFilter.SelectedItem.ToString();
            // Lấy toàn bộ danh sách nhân viên
            List<EmployeeModel> list = controller.GetAll();

            if (selected == "Male" || selected == "Female")
            {
                list = list.Where(emp =>
                    emp.Sex.Equals(selected, StringComparison.OrdinalIgnoreCase)
                ).ToList();
            }
            //else if (selected == "< 100$")
            //{
            //    list = list.Where(emp =>
            //        decimal.TryParse(emp.Salary.Replace(",", ""), out decimal salary) && salary < 100
            //    ).ToList();
            //}

            //else if (selected == "100$ – 500$")
            //{
            //    list = list.Where(emp =>
            //        decimal.TryParse(emp.Salary.Replace(",", ""), out decimal salary) && salary >= 100 && salary <= 500
            //    ).ToList();
            //}
            //else if (selected == "> 500$")
            //{
            //    list = list.Where(emp =>
            //        decimal.TryParse(emp.Salary.Replace(",", ""), out decimal salary) && salary > 500
            //    ).ToList();
            //}
            else if (selected == "All")
            {
                // Không cần lọc gì cả
                list = controller.GetAll();
            }

            dgvView.DataSource = null;
            dgvView.DataSource = list;
        }

        private void dgvView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvView.Rows[e.RowIndex];

                // Gán giá trị lên TextBox
              
                txtName.Text = row.Cells["Name"].Value?.ToString();
                txtPhone.Text = row.Cells["Phone"].Value?.ToString();
                cmbSex.Text = row.Cells["Sex"].Value?.ToString();
                txtAddress.Text = row.Cells["Address"].Value?.ToString();
                txtSalary.Text = row.Cells["Salary"].Value?.ToString();
                txtPassword.Text = row.Cells["password"].Value?.ToString();
                if(row.Cells["Status"].Value != null)
                {
                    if (row.Cells["Status"].Value.ToString() == "Active")
                    {
                        btnBlock.Text = "Block";
                    }
                    else
                    {
                        btnBlock.Text = "Unblock";
                    }
                }
                else
                {
                    btnBlock.Text = "Block";
                }

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
            if (employee == null) return;
            if (controller.IsPhoneExists(txtPhone.Text.Trim(), id))
            {
                MessageBox.Show("Số điện thoại đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Cập nhật thông tin vào các trường nhập
            employee.Name = txtName.Text;
            employee.Phone = txtPhone.Text;
            employee.Sex = cmbSex.Text;
            employee.Address = txtAddress.Text;
            employee.Salary = txtSalary.Text;
            employee.Password = txtPassword.Text;

            controller.UpdateEmployee(employee);
            MessageBox.Show("Chỉnh sửa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshGrid();
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            if (dgvView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần khoá.", "Chưa chọn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Chuyển đổi id sang kiểu int
            int id = Convert.ToInt32(dgvView.SelectedRows[0].Cells["Id"].Value);
            var current = dgvView.SelectedRows[0].Cells["Status"].Value;
            if (current.ToString() == "Inactive")
            {
               
                controller.UnblockEmployee(id); // Cập nhật trạng thái nhân viên thành Inactive
                RefreshGrid();  // Cập nhật lại Grid
                MessageBox.Show("Đã mở khoá nhân viên!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
              
                controller.BlockEmployee(id); // Cập nhật trạng thái nhân viên thành Inactive
                RefreshGrid();  // Cập nhật lại Grid
                MessageBox.Show("Đã khoá nhân viên!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
           
        }

        private void txt_custormer_address_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSalary_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
