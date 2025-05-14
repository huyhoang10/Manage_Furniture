using System;
using System.Windows.Forms;
using Manage_Furniture.Models;
using System.Linq;
using Manage_Furniture.Controls;
using Manage_Furniture.ADO;
using System.Drawing;
using System.Collections.Generic;
using Manage_Furniture.Forms;
using System.Runtime.CompilerServices;
using DocumentFormat.OpenXml.Bibliography;

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
            dgvView.AutoGenerateColumns = false; // Đảm bảo tự động tạo cột bị tắt
                                                 
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
            dgvView.Columns["Salary"].SortMode = DataGridViewColumnSortMode.Programmatic;

            cmbSex.DrawItem += (s, e) =>
            {
                if (e.Index < 0) return;
                e.DrawBackground();
                string text = cmbSex.Items[e.Index].ToString();
                e.Graphics.DrawString(text, cmbSex.Font, Brushes.Black, e.Bounds);
                e.DrawFocusRectangle();
            };
            dgvView.DataSource = null;
            dgvView.DataSource = controller.GetAll(); 
            
            var employees = controller.GetAll();
            dgvView.CellPainting += dgvView_CellPainting;
            dgvView.ColumnHeaderMouseClick += dgvView_ColumnHeaderMouseClick;
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
            if(string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập email.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                "Active",
                false,
                txtEmail.Text,
                "Employee" // Mặc định là Employee
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
            string email = (dgvView.SelectedRows[0].Cells["Email"].Value).ToString();
            controller.DeleteEmployee(id);  // Cập nhật trạng thái nhân viên thành Inactive
            controller.SendEmailNotification("Your account has been locked, you should contact admin to know the reason.", email);
            RefreshGrid();  // Cập nhật lại Grid
            MessageBox.Show("Đã xoá nhân viên!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ClearInputs()
        {
            
            txtName.Clear();
            txtPhone.Clear();
            cmbSex.Refresh();
            txtAddress.Clear();
            txtPassword.Clear();
            txtEmail.Clear();

            txtSalary.Clear();
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
            List<EmployeeModel> list = controller.GetAll();

            if (selected == "Male" || selected == "Female")
            {
                list = list.Where(emp =>
                    emp.Sex.Equals(selected, StringComparison.OrdinalIgnoreCase)
                ).ToList();
            }
            else if (selected == "Active")
            {
                list = list.Where(emp =>
                    emp.Status.Equals("Active", StringComparison.OrdinalIgnoreCase)
                ).ToList();
            }
            else if (selected == "Inactive")
            {
                list = list.Where(emp =>
                    emp.Status.Equals("Inactive", StringComparison.OrdinalIgnoreCase)
                ).ToList();
            }
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
                txtPhone.ReadOnly = true;
                txtPhone.FillColor = Color.LightGray;
                cmbSex.Text = row.Cells["Sex"].Value?.ToString();
                txtAddress.Text = row.Cells["Address"].Value?.ToString();
                txtSalary.Text = row.Cells["Salary"].Value?.ToString();
                txtPassword.Text = row.Cells["password"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();
                if (row.Cells["Status"].Value != null)
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
            string content = $"Employee Update Summary:\n\n" +
                 "Before Update:\n" +
                 $"Name: {txtName.Text}\n" +
                 
                 $"Sex: {cmbSex.Text}\n" +
                 $"Address: {txtAddress.Text}\n" +
                 $"Salary: {txtSalary.Text}\n" +
                 $"Password: {txtPassword.Text}\n" +
                 $"Email: {txtEmail.Text}\n\n" +
                 "After Update:\n" +
                 $"Name: {employee.Name}\n" +
                
                 $"Sex: {employee.Sex}\n" +
                 $"Address: {employee.Address}\n" +
                 $"Salary: {employee.Salary}\n" +
                 $"Password: {employee.Password}\n" +
                 $"Email: {employee.Email}";

            // Cập nhật thông tin vào các trường nhập
            employee.Name = txtName.Text;
        
            employee.Sex = cmbSex.Text;
            employee.Address = txtAddress.Text;
            employee.Salary = txtSalary.Text;
            employee.Password = txtPassword.Text;
            employee.Email = txtEmail.Text;
            var check = controller.UpdateEmployee(employee);
           
            if (check)

            {
                var email = employee.Email;
                controller.SendEmailNotification(content, email);
                MessageBox.Show("Cập nhật thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
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
                controller.SendEmailNotification("Your account is unlocked", controller.GetAll().FirstOrDefault(ee => ee.Id.ToString() == id.ToString()).Email);
                RefreshGrid();  // Cập nhật lại Grid
                MessageBox.Show("Đã mở khoá nhân viên!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
              
                controller.BlockEmployee(id); // Cập nhật trạng thái nhân viên thành Inactive
                controller.SendEmailNotification("Your account is locked, you should contact admin to unlock it.", controller.GetAll().FirstOrDefault(ee => ee.Id.ToString() == id.ToString()).Email);
                RefreshGrid();  // Cập nhật lại Grid
                MessageBox.Show("Đã khoá nhân viên!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
           
        }

        private void btn_Excel_Click(object sender, EventArgs e)
        {
            List<EmployeeModel> employees = controller.GetAll();
            controller.ExportEmployeesToExcel(employees);
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            FReportEmployee report = new FReportEmployee();
            report.ShowDialog();
        }
        public bool sortAscending = false;
        private string sortedColumn = "salary";

        private void dgvView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string columnName = dgvView.Columns[e.ColumnIndex].Name;

            if (columnName == sortedColumn)
                sortAscending = !sortAscending;
            else
            {
                sortedColumn = columnName;
                sortAscending = true;
            }

            // Gọi sort trong controller
            if (columnName == "salary")
            {
                var sorted = controller.SortBySalary(sortAscending ? "asc" : "desc");
                dgvView.DataSource = null;
                dgvView.DataSource = sorted;
            }

            dgvView.Invalidate();
        }

        private void dgvView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0 && dgvView.Columns[e.ColumnIndex].Name == sortedColumn)
            {
                e.PaintBackground(e.CellBounds, true);
                e.PaintContent(e.CellBounds);

                int x = e.CellBounds.Right - 20;
                int y = e.CellBounds.Top + (e.CellBounds.Height / 2) - 5;

                Point[] triangle;

                if (sortAscending)
                {
                    triangle = new Point[]
                    {
                new Point(x, y + 6),
                new Point(x + 6, y + 6),
                new Point(x + 3, y)
                    };
                }
                else
                {
                    triangle = new Point[]
                    {
                new Point(x, y),
                new Point(x + 6, y),
                new Point(x + 3, y + 6)
                    };
                }

                e.Graphics.FillPolygon(Brushes.White, triangle);
                e.Handled = true;
            }
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }

}
