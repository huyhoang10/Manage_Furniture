using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manage_Furniture.ADO;
using Manage_Furniture.Models;
using Manage_Furniture.Controls;
using Guna.UI2.WinForms;
using Guna.UI2.AnimatorNS;
using System.Xml.Linq;

namespace Manage_Furniture.Controls
{
 
    public partial class UCCustomer : UserControl
    {
        public UCCustomer()
        {
            InitializeComponent();
        }

        private void UCCustomer_Load(object sender, EventArgs e)
        {
            LoadData();
            txt_ID.Enabled = false;
            btn_Update.Enabled = false;
            cmb_FillterType.SelectedIndex = 0;
        }
     

        private void LoadData()
        {
            Customerclass cc = new Customerclass();
            dgv_Customer.DataSource = cc.GetAllCustomers();
        }

        private void dgv_Customer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UCCustomerController ct = new UCCustomerController();
            // Make sure the click is on a valid row, not the header
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_Customer.Rows[e.RowIndex];

                Customerclass customer = ct.GetCustomerFromRow(row);

                txt_ID.Text = customer.Id.ToString();
                txt_Name.Text = customer.Name;
                txt_Phone.Text = customer.Phone;
                txt_Sex.Text = customer.Sex;
                txt_Address.Text = customer.Address;
                txt_Type.Text = customer.Type;
                btn_Update.Enabled = true;
            }
        }
        
        private void btn_Update_Click(object sender, EventArgs e)
        {
            UCCustomerController ct = new UCCustomerController();
            try
            {
                Customerclass updatedCustomer = new Customerclass
                {
                    Id = int.Parse(txt_ID.Text),
                    Name = txt_Name.Text.Trim(),
                    Phone = txt_Phone.Text.Trim(),
                    Sex = txt_Sex.Text.Trim(),
                    Address = txt_Address.Text.Trim(),
                    Type = txt_Type.Text.Trim()
                };

                string message;
                bool success = ct.UpdateCustomer(updatedCustomer, out message);

                MessageBox.Show(message, success ? "Thành công" : "Lỗi", MessageBoxButtons.OK,
                                success ? MessageBoxIcon.Information : MessageBoxIcon.Error);

                if (success)
                {
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            // Ép kiểu trực tiếp sang Guna2TextBox
            Guna.UI2.WinForms.Guna2TextBox txtSearch = (Guna.UI2.WinForms.Guna2TextBox)sender;

            // Giờ bạn có thể sử dụng txtSearch thay vì TextBox
            UCCustomerController controller = new UCCustomerController();
            controller.SearchCustomersByPhone(txtSearch.Text, dgv_Customer);
        }

        private void cmb_FillterType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedType = cmb_FillterType.SelectedItem.ToString();
            UCCustomerController controller = new UCCustomerController();
            Customerclass cc = new Customerclass();
            if (selectedType == "All")
            {
                dgv_Customer.DataSource =  cc.GetAllCustomers();
            }
            else
            {
                dgv_Customer.DataSource = controller.FilterCustomers(
                    txt_Name.Text.Trim(),
                    txt_Phone.Text.Trim(),
                    txt_Sex.Text,
                    txt_Address.Text.Trim(),
                    selectedType
                );
            }
        }
    }
}
