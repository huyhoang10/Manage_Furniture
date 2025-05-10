using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
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
            EntryLock();
            dgv_orders.EditMode = DataGridViewEditMode.EditOnEnter;
        }

        private void EntryAllow() { 
            txt_customer_name.Enabled = true;
            //txt_customer_phone.Enabled = true;
            txt_custormer_address.Enabled = true;
            cmb_customer_sex.Enabled = true;
            cmb_customer_type.Enabled = true;
        }

        private void EntryLock()
        {
            txt_customer_name.Enabled = false;
            txt_customer_phone.Enabled = false;
            txt_custormer_address.Enabled = false;
            cmb_customer_sex.Enabled = false;
            cmb_customer_type.Enabled = false;
        }

        public void LoadProduct()
        {
            var products = orderControl.GetAllProducts()
                .Select(p => new
                {
                    id_name = $"{p.id}-{p.name}",
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

                var selectedProducts = dgv_orders.Rows.Cast<DataGridViewRow>()
                    .Where(r => !r.IsNewRow && r.Index != dgv_orders.CurrentCell.RowIndex)
                    .Select(r => r.Cells["col_product"].Value?.ToString())
                    .Where(v => !string.IsNullOrEmpty(v))
                    .ToList();

                var allProducts = orderControl.GetAllProducts()
                    .Select(p => new
                    {
                        id_name = $"{p.id}-{p.name}",
                        name = p.name,
                        price = p.price
                    })
                    .ToList();

                var currentValue = dgv_orders.CurrentCell.Value?.ToString();
                var availableProducts = allProducts
                    .Where(p => !selectedProducts.Contains(p.id_name) || p.id_name == currentValue)
                    .ToList();

                cb.DataSource = availableProducts;
                cb.DisplayMember = "id_name";
                cb.ValueMember = "id_name";
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
                    .FirstOrDefault(p => $"{p.id}-{p.name}" == selectedProductId);

                if (product != null)
                {
                    if (row.Cells["col_id"].Value == null || string.IsNullOrEmpty(row.Cells["col_id"].Value.ToString()))
                    {
                        row.Cells["col_id"].Value = tempOrderId++;
                    }
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
                    .FirstOrDefault(p => $"{p.id}-{p.name}" == selectedProductId);

                if (product != null && decimal.TryParse(quantityStr, out decimal qty))
                {

                    int warehouseQuantity = orderControl.GetWarehouseQuantity(product.id);
                    if (qty > warehouseQuantity && qty!=0 )
                    {
                        MessageBox.Show($"The requested quantity for {product.name} exceeds the available stock. " +
                                        $"Only {warehouseQuantity} items are available in stock.",
                                        "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        row.Cells["col_quantity"].Value = warehouseQuantity;
                        qty = warehouseQuantity;
                    }
                    else if(warehouseQuantity == 0)
                    {
                        MessageBox.Show("This out of stock!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        row.DefaultCellStyle.BackColor = Color.Red;
                        row.Cells["col_total"].Value = (0).ToString("C");
                        qty = 0;
                        return;

                    }    
                    else if (qty < 0) {
                        MessageBox.Show("Quantity must be greater than 0.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = dgv_orders.DefaultCellStyle.BackColor;
                    }

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


        // Update No in Orders
        private void dgv_orders_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            UpdateTempOrderId();
        }
        private void UpdateTempOrderId()
        {

            int id = 1;
            foreach (DataGridViewRow row in dgv_orders.Rows)
            {
                if (row.Cells["col_id"].Value != null)
                {
                    row.Cells["col_id"].Value = id++;
                }
            }

            if (dgv_orders.Rows.Count > 0)
            {
                //tempOrderId = dgv_orders.Rows.Cast<DataGridViewRow>()
                //    .Where(r => r.Cells["col_id"].Value != null)
                //    .Max(r => (int)r.Cells["col_id"].Value) + 1;
                tempOrderId = dgv_orders.Rows.Cast<DataGridViewRow>()
                    .Where(r => r.Cells["col_id"].Value != null && int.TryParse(r.Cells["col_id"].Value.ToString(), out _))
                    .Select(r => Convert.ToInt32(r.Cells["col_id"].Value))
                    .DefaultIfEmpty(0)
                    .Max() + 1;
            }
            else
            {
                tempOrderId = 1;
            }
        }

        // Check Invalid Phone 
        private void txt_customer_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                MessageBox.Show("Invalid Phone Format!\nPlease enter digits only (0-9) for the phone number.", "Error Format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (!char.IsControl(e.KeyChar) && txt_customer_phone.Text.Length >= 10)
            {
                e.Handled = true;
                MessageBox.Show("Phone number cannot exceed 10 digits.", "Error Format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Check Invalid Name
        private void txt_customer_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                MessageBox.Show("Invalid Name Format!\nPlease enter letters only (A-Z, a-z) for the name.", "Error Format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void InitializeDataGridViewEvents()
        {
            dgv_orders.EditingControlShowing += dgv_orders_EditingControlShowing;
            dgv_orders.CellValueChanged += dgv_orders_CellValueChanged;
            dgv_orders.RowLeave += dgv_orders_RowLeave;
        }

        //  Order 
        private void btn_order_Click(object sender, EventArgs e)
        {
            string customer_name = txt_customer_name.Text.Trim();
            string sex = cmb_customer_sex.Text;
            string phone = txt_customer_phone.Text.Trim();
            string address = txt_custormer_address.Text.Trim();
            string type = cmb_customer_type.Text;
            string note = txt_order_note.Text.Trim();


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

            var existingCustomer = orderControl.GetCustomerByPhone(phone);

            orderControl.AddOrderAndCustomer(customer_name, sex, phone, address, type, note, totalMoney, dgv_orders);
            MessageBox.Show("Order added successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        private void btn_export_Click(object sender, EventArgs e)
        {
            int order_id = ucOrderControl.global_orderID;
            UCBill ucBill = new UCBill();
            ucBill.ShowDialog();

        }
        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_customer_name.ResetText();
            cmb_customer_sex.SelectedIndex = 0;
            txt_customer_phone.ResetText();
            txt_custormer_address.ResetText();
            cmb_customer_type.SelectedIndex = 0;
            txt_order_note.ResetText();
            txt_order_note.ResetText();
            txt_search_phone.ResetText();
            txt_sum.Text = "";
            dgv_orders.Rows.Clear();
            tempOrderId = 1;
            EntryLock();
        }

        private void txt_search_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                MessageBox.Show("Invalid Phone Format!\nPlease enter digits only (0-9) for the phone number.", "Error Format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (!char.IsControl(e.KeyChar) && txt_search_phone.Text.Length >= 10)
            {
                e.Handled = true;
                MessageBox.Show("Phone number cannot exceed 10 digits!", "Error Format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Check Invalid Phone in Search bar
        private void btn_search_Click(object sender, EventArgs e)
        {

            var phone = txt_search_phone.Text.Trim();
            if (string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Please enter a phone number to search!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (phone.Length < 10)
            {
                MessageBox.Show("Phone number must be at least 10 digits!", "Error Format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                DialogResult result = MessageBox.Show("Customer is not in database yet, do you want to add?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                EntryAllow();
                txt_customer_name.ResetText();
                cmb_customer_sex.SelectedIndex = 0;
                txt_customer_phone.ResetText();
                txt_custormer_address.ResetText();
                cmb_customer_type.SelectedIndex = 0;
                txt_order_note.ResetText();
                if (result == DialogResult.Yes)
                {
                    txt_customer_phone.Text = txt_search_phone.Text;
                }
            }
        }
    }
}