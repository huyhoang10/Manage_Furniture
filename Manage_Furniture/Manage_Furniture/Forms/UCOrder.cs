using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Manage_Furniture.ADO;
using Manage_Furniture.Controls;

namespace Manage_Furniture.Forms
{
    public partial class UCOrder : UserControl
    {
        private ucOrderControl orderControl = new ucOrderControl();
        private Random random = new Random();
        private int tempOrderId = 1;

        public UCOrder()
        {
            InitializeComponent();
            LoadProduct();
            InitializeDataGridViewEvents();
        }

        public void LoadProduct()
        {
            var products = orderControl.GetAllProducts()
                .Select(p => new
                {
                    id_name = $"{p.id}_{p.name}",
                    name = p.name,
                    price = p.price
                }).ToList();

            var productColumn = dgv_orders.Columns["col_product"] as DataGridViewComboBoxColumn;
            if (productColumn != null)
            {
                productColumn.DataSource = products;
                productColumn.DisplayMember = "id_name";
                productColumn.ValueMember = "id_name";
            }
        }

        private void dgv_orders_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgv_orders.CurrentCell.ColumnIndex == dgv_orders.Columns["col_product"].Index && e.Control is ComboBox cb)
            {
                cb.SelectedIndexChanged -= ComboBox_SelectedIndexChanged;
                cb.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            }
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (sender is ComboBox comboBox && comboBox.SelectedValue != null)
            {
                int rowIndex = dgv_orders.CurrentCell.RowIndex;
                var row = dgv_orders.Rows[rowIndex];

                string selectedProductId = comboBox.SelectedValue.ToString();
                var product = orderControl.GetAllProducts()
                    .FirstOrDefault(p => $"{p.id}_{p.name}" == selectedProductId);

                if (product != null)
                {
                    row.Cells["col_id"].Value = tempOrderId++;
                    row.Cells["col_date_purchase"].Value = DateTime.Now.ToString("yyyy-MM-dd");
                    row.Cells["col_money"].Value = ((int)product.price).ToString("C");

                    var quantityStr = row.Cells["col_quantity"].Value?.ToString();
                    if (!string.IsNullOrEmpty(quantityStr) && decimal.TryParse(quantityStr, out decimal qty))
                    {
                        decimal total = (int)product.price * qty;
                        row.Cells["col_total"].Value = total.ToString("C");
                    }
                    else
                    {
                        row.Cells["col_total"].Value = null;
                    }
                }
            }
        }

        private void dgv_orders_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_orders.Columns["col_quantity"] != null && e.ColumnIndex == dgv_orders.Columns["col_quantity"].Index)
            {
                UpdateOrderRow(e.RowIndex);
            }
        }

        private void UpdateOrderRow(int rowIndex)
        {
            if (rowIndex < 0 || rowIndex >= dgv_orders.Rows.Count)
                return;

            var row = dgv_orders.Rows[rowIndex];
            var selectedProductId = row.Cells["col_product"].Value?.ToString();
            var quantityStr = row.Cells["col_quantity"].Value?.ToString();

            if (!string.IsNullOrEmpty(selectedProductId) && !string.IsNullOrEmpty(quantityStr))
            {
                var product = orderControl.GetAllProducts()
                    .FirstOrDefault(p => $"{p.id}_{p.name}" == selectedProductId);

                if (product != null && decimal.TryParse(quantityStr, out decimal qty))
                {
                    decimal total = (int)product.price * qty;
                    row.Cells["col_total"].Value = total.ToString("C");
                }

                // Sum of Orders
                decimal sum = 0;
                foreach (DataGridViewRow r in dgv_orders.Rows)
                {
                    if (r.Cells["col_total"].Value != null &&
                        Decimal.TryParse(r.Cells["col_total"].Value.ToString(), System.Globalization.NumberStyles.Currency, null, out decimal t))
                    {
                        sum += t;
                    }
                }
                txt_sum.Text = sum.ToString("C");
            }
        }

        private void txt_customer_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Invalid Phone Format!", "Error Format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void InitializeDataGridViewEvents()
        {
            dgv_orders.EditingControlShowing += dgv_orders_EditingControlShowing;
            dgv_orders.CellValueChanged += dgv_orders_CellValueChanged;
        }


        private void btn_order_Click(object sender, EventArgs e)
        {
            string customer_name = txt_customer_name.Text;
            string sex = cmb_customer_sex.Text;
            string phone = txt_customer_phone.Text;
            string address = txt_custormer_address.Text;
            string type = cmb_customer_type.Text;
            string note = txt_order_note.Text;


            // Check Row dgv_orders ?=null
            if (!dgv_orders.Rows.Cast<DataGridViewRow>().Any(r => !r.IsNewRow && r.Cells["col_product"].Value != null))
            {
                MessageBox.Show("No product to order!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check textbox Customer
            else if (string.IsNullOrEmpty(customer_name) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Please fill in all customer fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check totalMoney
            if (!decimal.TryParse(txt_sum.Text, System.Globalization.NumberStyles.Currency, null, out decimal totalMoney))
            {
                MessageBox.Show("Invalid money format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            orderControl.AddOrderAndCustomer(customer_name, sex, phone, address, type, note, totalMoney, dgv_orders);

        }


        private void btn_search_Click(object sender, EventArgs e)
        {
            var phone = txt_search_phone.Text.Trim();
            if (string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Please enter a phone number to search!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (orderControl.IsPhoneNumberExists(phone))
            {
                var customer = orderControl.GetCustomerByPhone(phone);

                txt_customer_name.Text = customer.name;
                cmb_customer_sex.SelectedItem = customer.sex;
                txt_customer_phone.Text = customer.phone;
                txt_custormer_address.Text = customer.address;
                cmb_customer_type.SelectedItem = customer.type;
            }
            else
            {
                MessageBox.Show("Customer is not in database yet, do you want to add?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            txt_customer_name.ResetText();
            cmb_customer_sex.SelectedIndex = 0;  
            txt_customer_phone.ResetText();
            txt_custormer_address.ResetText();
            cmb_customer_type.SelectedIndex = 0;
            txt_order_note.ResetText();
            txt_search_phone.ResetText();
            txt_sum.Text = "";
            dgv_orders.Rows.Clear();
            tempOrderId = 1;
        }

        
    }
}
