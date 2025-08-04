using Manage_Furniture.ADO;
using Manage_Furniture.Controls;
using Manage_Furniture.Models;
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
            LoadCmbFilter();
        }

        private void LoadDgvView()
        {
            dgvView.DataSource = warehouseControls.DisplayInformation();
        }
        

        private void LoadCmbFilter()
        {
            List<string> dataCmbFilter = warehouseControls.LoadcmbSubCategory();
            foreach (var item in dataCmbFilter)
            {
                cmbFilter.Items.Add(item);
            }
        }
        

        

        

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            cmbFilter.Text = "All";
            dgvView.DataSource = warehouseControls.SearchProducts(txtSearch.Text);
            
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Excel_Click(object sender, EventArgs e)
        {
            List<Products> listProducts = warehouseControls.DisplayInformation();
            warehouseControls.ExportProductsToExcel(listProducts);

        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            FReportWarehouse fReportWarehouse = new FReportWarehouse();
            fReportWarehouse.ShowDialog();
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvView.DataSource = warehouseControls.FilterProduct(cmbFilter.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FProduct fProduct = new FProduct();
            fProduct.ShowDialog();
        }
    }
}
