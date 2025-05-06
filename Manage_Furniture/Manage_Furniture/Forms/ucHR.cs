using System;
using System.Windows.Forms;
using Manage_Furniture.Models;
using System.Linq;
using Manage_Furniture.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Manage_Furniture.Forms;
using System.Drawing;

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
            dgvView.DataSource = controller.GetAll();
            var employees = controller.GetAll();

            // Tuỳ chỉnh header cột (nếu cần)
            var activeEmployees = employees.Where(e => e.Status == "Active").ToList();
            var inactiveEmployees = employees.Where(e => e.Status == "Inactive").ToList();
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
                "Active" // Mặc định trạng thái là Active

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

            string id = dgvView.SelectedRows[0].Cells["Id"].Value.ToString();
            controller.DeleteEmployee(id);
            RefreshGrid();
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

        // Các event khác (nếu bạn cần giữ nguyên có thể để trống)
        

        private void btnActive_Click(object sender, EventArgs e)
        {
            btnActive.FillColor = Color.Green;  // Thay đổi màu nền
            btnInactive.FillColor = Color.White;  // Thay đổi màu chữ
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
            var results = controller.SearchEmployees(keyword);
            dgvView.DataSource = null;
            dgvView.DataSource = results;
        }

      

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = cmbFilter.SelectedItem.ToString();
            cmbFilter.SelectedIndex = 0;
            if (selected == "Man" || selected == "Female")
            {
                var list = controller.GetAll().Where(emp =>
                    emp.Sex.Equals(selected, StringComparison.OrdinalIgnoreCase)
                ).ToList();

                dgvView.DataSource = list;
            }
        }

        private void txtTotalE_TextChanged(object sender, EventArgs e)
        {

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
                txtId.Enabled = false;
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            btnAll.FillColor = Color.Green;  // Thay đổi màu nền
            btnActive.FillColor = Color.White;
            btnInactive.FillColor = Color.White;
            var inactiveEmployees = controller.GetAll();
            dgvView.DataSource = null;
            dgvView.DataSource = inactiveEmployees;
        }
    }
}
