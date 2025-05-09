using Manage_Furniture.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manage_Furniture.Forms
{
    public partial class ucWarehouse : UserControl
    {
        ucWarehouseControls warehouseControls = new ucWarehouseControls();
        public ucWarehouse()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void ucWarehouse_Load(object sender, EventArgs e)
        {
            LoadDgvView();
            LoadCmbSuppliers();
            LoadCmbSubCategory();
            btnAdd.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false; btnAdd.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void LoadDgvView()
        {
            dgvView.DataSource = warehouseControls.DisplayInformation();
        }
        private void LoadCmbSuppliers() {
            List<string> dataCmbSupplier = warehouseControls.LoadCmbSuppliers();
            foreach (var item in dataCmbSupplier)
            {
                cmbSuppliers.Items.Add(item);
            }
        }

        private void LoadCmbSubCategory()
        {
            List<string> dataCmbSubCategory = warehouseControls.LoadcmbSubCategory();
            foreach (var item in dataCmbSubCategory)
            {
                cmbSubcategory.Items.Add(item);
            }
        }

        private void dgvView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAdd.Enabled = false;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            if (e.RowIndex >=0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = this.dgvView.Rows[e.RowIndex];
                txtId.Text = row.Cells["col_Id"].Value.ToString();
                txtName.Text = row.Cells["col_Name"].Value.ToString();
                txtPrice.Text = row.Cells["col_Price"].Value.ToString();
                nmrQuantity.Text = row.Cells["col_Quantity"].Value.ToString();
                cmbSuppliers.Text = row.Cells["col_Supplier"].Value.ToString();
                cmbSubcategory.Text = row.Cells["col_SubCategory"].Value.ToString();
                txtBrand.Text = row.Cells["col_Brand"].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this Product?", "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;
            warehouseControls.DeleteProductFromWarehouse(txtId.Text);
            LoadDgvView(); 
            txtId.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
            txtBrand.Text = "";
            cmbSubcategory.Text = "";
            cmbSuppliers.Text = "";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvView.Rows)
            {
                if (row.Cells["col_Name"].Value.ToString() == txtName.Text)
                {
                    if (MessageBox.Show("Name product already exists in the warehouse.\nDo you want to continue edit?", "Warming", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    {
                        txtId.Text = row.Cells["col_Id"].Value.ToString();
                        txtName.Text = row.Cells["col_Name"].Value.ToString();
                        txtPrice.Text = row.Cells["col_Price"].Value.ToString();
                        nmrQuantity.Text = row.Cells["col_Quantity"].Value.ToString();
                        cmbSuppliers.Text = row.Cells["col_Supplier"].Value.ToString();
                        cmbSubcategory.Text = row.Cells["col_SubCategory"].Value.ToString();
                        txtBrand.Text = row.Cells["col_Brand"].Value.ToString();
                        return;
                    }
                    else
                    {
                        if (warehouseControls.EditProductInWarehouse(txtId.Text, txtName.Text, cmbSuppliers.Text, cmbSubcategory.Text, txtPrice.Text, nmrQuantity.Text, txtBrand.Text) == true)
                        {
                            LoadDgvView();
                            txtId.Text = "";
                            txtName.Text = "";
                            txtPrice.Text = "";
                            txtBrand.Text = "";
                            cmbSubcategory.Text = "";
                            cmbSuppliers.Text = "";
                        }
                        return;
                    }
                }
            }
            if (warehouseControls.EditProductInWarehouse(txtId.Text, txtName.Text, cmbSuppliers.Text, cmbSubcategory.Text, txtPrice.Text, nmrQuantity.Text, txtBrand.Text) == true)
            {
                LoadDgvView();
                txtId.Text = "";
                txtName.Text = "";
                txtPrice.Text = "";
                txtBrand.Text = "";
                cmbSubcategory.Text = "";
                cmbSuppliers.Text = "";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvView.Rows)
            {
                if (row.Cells["col_Name"].Value.ToString() == txtName.Text)
                {
                    if (MessageBox.Show("This product already exists in the warehouse.\nDo you want to add more?", "Warming", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    {
                        txtId.Text = row.Cells["col_Id"].Value.ToString();
                        txtName.Text = row.Cells["col_Name"].Value.ToString();
                        txtPrice.Text = row.Cells["col_Price"].Value.ToString();
                        nmrQuantity.Text = row.Cells["col_Quantity"].Value.ToString();
                        cmbSuppliers.Text = row.Cells["col_Supplier"].Value.ToString();
                        cmbSubcategory.Text = row.Cells["col_SubCategory"].Value.ToString();
                        txtBrand.Text = row.Cells["col_Brand"].Value.ToString();
                        return;
                    }
                    else
                    {
                        if (warehouseControls.AddProductToWarehouse(txtName.Text, cmbSuppliers.Text, cmbSubcategory.Text, txtPrice.Text, nmrQuantity.Text, txtBrand.Text) == true)
                        {
                            LoadDgvView();
                            txtId.Text = "";
                            txtName.Text = "";
                            txtPrice.Text = "";
                            txtBrand.Text = "";
                            cmbSubcategory.Text = "";
                            cmbSuppliers.Text = "";  
                        }
                        return;
                    }
                }
            }
            if(warehouseControls.AddProductToWarehouse(txtName.Text, cmbSuppliers.Text, cmbSubcategory.Text, txtPrice.Text, nmrQuantity.Text, txtBrand.Text)==true)
            {
                LoadDgvView();
                txtId.Text = "";
                txtName.Text = "";
                txtPrice.Text = "";
                txtBrand.Text = "";
                cmbSubcategory.Text = "";
                cmbSuppliers.Text = "";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            LoadDgvView();
            txtId.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
            txtBrand.Text = "";
            cmbSubcategory.Text = "";
            cmbSuppliers.Text = "";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvView.DataSource = warehouseControls.SearchProducts(txtSearch.Text);
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
