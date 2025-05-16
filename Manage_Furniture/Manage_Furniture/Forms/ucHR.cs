



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
using Microsoft.VisualBasic;
using DocumentFormat.OpenXml.Spreadsheet;

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
            dgvView.AutoGenerateColumns = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnVerify.Visible = false;
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
            foreach (DataGridViewRow row in dgvView.Rows)
            {
                if (row.Cells["Role"].Value.ToString() == "Admin")
                {
                    row.Cells["Salary"].Value = "0";
                   
                    

                }
            }
            var activeEmployees = employees.Where(e => e.Status == "Active").ToList();
            var inactiveEmployees = employees.Where(e => e.Status == "Inactive").ToList();

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
            while (controller.IsEmployeeIdExists(id));
            return id;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string generatedId = GenerateUniqueId();

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter the employee's name.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text) || !txtPhone.Text.All(char.IsDigit) || txtPhone.Text.Length < 9)
            {
                MessageBox.Show("Invalid phone number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (controller.IsPhoneExists(txtPhone.Text.Trim()))
            {
                MessageBox.Show("Phone number already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(cmbSex.Text) || (cmbSex.Text != "Male" && cmbSex.Text != "Female"))
            {
                MessageBox.Show("Please select a gender.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Please enter the address.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtSalary.Text.Replace(",", ""), out decimal salary) || salary <= 0)
            {
                MessageBox.Show("Salary must be a valid positive number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text) || txtPassword.Text.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Please enter the email.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
            {
                MessageBox.Show("Invalid email format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (controller.IsEmailExists(txtEmail.Text.Trim()))
            {
                MessageBox.Show("Email already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            EmployeeModel newEmp = new EmployeeModel(
                generatedId,
                txtName.Text,
                txtPhone.Text,
                cmbSex.Text,
                txtAddress.Text,
                salary.ToString("N0"),
                txtPassword.Text,
                "Active",
                false,
                txtEmail.Text,
                "Employee",
                DateTime.Now
            );

            controller.AddEmployee(newEmp);
            RefreshGrid();
            ClearInputs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an employee to delete.", "Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dgvView.SelectedRows[0].Cells["Id"].Value);
            string email = dgvView.SelectedRows[0].Cells["Email"].Value.ToString();
            controller.DeleteEmployee(id);
            controller.SendEmailNotification("Your account has been locked. Please contact admin for more details.", email);
            RefreshGrid();
            MessageBox.Show("Employee deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            var results = controller.SearchEmployees(keyword);
            dgvView.DataSource = null;
            dgvView.DataSource = results;
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = cmbFilter.SelectedItem.ToString();
            List<EmployeeModel> list = controller.GetAll();

            if (selected == "Male" || selected == "Female")
            {
                list = list.Where(emp => emp.Sex.Equals(selected, StringComparison.OrdinalIgnoreCase)).ToList();
            }
            else if (selected == "Active")
            {
                list = list.Where(emp => emp.Status.Equals("Active", StringComparison.OrdinalIgnoreCase)).ToList();
            }
            else if (selected == "Inactive")
            {
                list = list.Where(emp => emp.Status.Equals("Inactive", StringComparison.OrdinalIgnoreCase)).ToList();
            }

            dgvView.DataSource = null;
            dgvView.DataSource = list;
        }

        private void dgvView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
          

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvView.Rows[e.RowIndex];

                txtName.Text = row.Cells["Name"].Value?.ToString();
                txtPhone.Text = row.Cells["Phone"].Value?.ToString();
                txtPhone.ReadOnly = true;
                txtPhone.FillColor = System.Drawing.Color.LightGray;
                cmbSex.Text = row.Cells["Sex"].Value?.ToString();
                txtCreateTime.Text = row.Cells["CreatedAt"].Value?.ToString();
                txtAddress.Text = row.Cells["Address"].Value?.ToString();
                txtSalary.Text = row.Cells["Salary"].Value?.ToString();
                txtPassword.Text = row.Cells["password"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();
                btnBlock.Text = row.Cells["Status"].Value?.ToString() == "Active" ? "Block" : "Unblock";
                if (row.Cells["Role"].Value?.ToString() == "Admin")
                {
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnVerify.Visible = true;
                    txtSalary.ReadOnly = true;
                    txtPassword.ReadOnly = true;
                    txtEmail.ReadOnly = true;
                    txtPhone.ReadOnly = true;
                    btnBlock.Enabled = false;
                    btnBlock.Text = "Admin";

                    System.Drawing.Color grayColor = System.Drawing.Color.LightGray;
                    txtSalary.FillColor = grayColor;
                    txtPassword.FillColor = grayColor;
                    txtEmail.FillColor = grayColor;
                    txtPhone.FillColor = grayColor;
                }
                else
                {
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                    btnVerify.Visible = false;
                    txtSalary.ReadOnly = false;
                    txtPassword.ReadOnly = false;
                    txtEmail.ReadOnly = false;
                   
                    btnBlock.Enabled = true;
                    btnBlock.Text = row.Cells["Status"].Value?.ToString() == "Active" ? "Block" : "Unblock";

                    System.Drawing.Color normalColor = System.Drawing.Color.FromArgb(255, 248, 227);
                    txtSalary.FillColor = normalColor;
                    txtPassword.FillColor = normalColor;
                    txtEmail.FillColor = normalColor;
                   
                }


            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an employee to edit.", "Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string id = dgvView.SelectedRows[0].Cells["Id"].Value.ToString();
            var employee = controller.GetAll().FirstOrDefault(ee => ee.Id.ToString() == id);
            if (employee == null) return;

            if (controller.IsPhoneExists(txtPhone.Text.Trim(), id))
            {
                MessageBox.Show("Phone number already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(txtEmail.Text.Trim() != employee.Email)
            {
                if (controller.IsEmailExists(txtEmail.Text, id))
                {
                    MessageBox.Show("Email already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            
            string content = $"Employee Update Summary:\n\n" +
                "Before Update:\n" +
                $"Name: {employee.Name}\n" +
                $"Sex: {employee.Sex}\n" +
                $"Address: {employee.Address}\n" +
                $"Salary: {employee.Salary}\n" +
                $"Password: {employee.Password}\n" +
                $"Email: {employee.Email}\n\n" +
                "After Update:\n" +
                $"Name: {txtName.Text}\n" +
                $"Sex: {cmbSex.Text}\n" +
                $"Address: {txtAddress.Text}\n" +
                $"Salary: {txtSalary.Text}\n" +
                $"Password: {txtPassword.Text}\n" +
                $"Email: {txtEmail.Text}";

            employee.Name = txtName.Text;
            employee.Sex = cmbSex.Text;
            employee.Address = txtAddress.Text;
            employee.Salary = txtSalary.Text;
            employee.Password = txtPassword.Text;
            employee.Email = txtEmail.Text;

            bool check = controller.UpdateEmployee(employee);

            if (check)
            {
                controller.SendEmailNotification(content, employee.Email);
                MessageBox.Show("Update successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Update failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            RefreshGrid();
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            if (dgvView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an employee to block/unblock.", "Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dgvView.SelectedRows[0].Cells["Id"].Value);
            var current = dgvView.SelectedRows[0].Cells["Status"].Value;

            if (current.ToString() == "Inactive")
            {
                controller.UnblockEmployee(id);
                controller.SendEmailNotification("Your account has been unlocked.", controller.GetAll().FirstOrDefault(ee => ee.Id.ToString() == id.ToString()).Email);
                MessageBox.Show("Employee unblocked successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                controller.BlockEmployee(id);
                controller.SendEmailNotification("Your account has been locked. Please contact admin to unlock it.", controller.GetAll().FirstOrDefault(ee => ee.Id.ToString() == id.ToString()).Email);
                MessageBox.Show("Employee blocked successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            RefreshGrid();
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

                Point[] triangle = sortAscending
                    ? new Point[] { new Point(x, y + 6), new Point(x + 6, y + 6), new Point(x + 3, y) }
                    : new Point[] { new Point(x, y), new Point(x + 6, y), new Point(x + 3, y + 6) };

                e.Graphics.FillPolygon(Brushes.White, triangle);
                e.Handled = true;
            }
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtPhone.ReadOnly = false;
            btnDelete.Enabled = false;
            txtPhone.FillColor = System.Drawing.Color.FromArgb(255, 248, 227);
            btnEdit.Enabled = false;
            txtName.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            txtPassword.Text = "";
            txtEmail.Text = "";
            txtSalary.Text = "";


        }
        public string GenerateOtp()
        {
            Random rnd = new Random();
            return rnd.Next(100000, 999999).ToString();
        }
       

        private string currentOtp = ""; // Khai báo toàn cục nếu cần

        private void btnVerify_Click(object sender, EventArgs e)
        {
            // 1. Gửi OTP
            currentOtp = GenerateOtp();
            var admin = controller.GetAll().FirstOrDefault(ee => ee.Role == "Admin");

            if (admin == null)
            {
                MessageBox.Show("No found admin account!");
                return;
            }

            controller.SendEmailNotification(
                $"Your OTP code to change admin password is: {currentOtp}",
                admin.Email
            );

            MessageBox.Show("OTP has been sent.\nPlease enter the confirmation code");

            // 2. Nhập OTP
            string inputOtp = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter the OTP code just sent to email:", "Confirm OTP", "");

            if (inputOtp == currentOtp)
            {

                btnEdit.Enabled = true;
                btnDelete.Enabled = false;

                txtSalary.ReadOnly = false;
                txtPassword.ReadOnly = false;
                txtEmail.ReadOnly = false;
               
                btnBlock.Enabled = false;


                System.Drawing.Color normalColor = System.Drawing.Color.FromArgb(255, 248, 227);
                txtSalary.FillColor = normalColor;
                txtPassword.FillColor = normalColor;
                txtEmail.FillColor = normalColor;
             

            }
            else
            {
                MessageBox.Show("OTP is incorrect. Please try again!");
            }
        }


    }
}
