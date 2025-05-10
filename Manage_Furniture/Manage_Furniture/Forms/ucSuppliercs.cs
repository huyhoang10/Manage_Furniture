using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manage_Furniture.Models;
using Manage_Furniture.Controls;

namespace Manage_Furniture.Forms
{
    public partial class ucSuppliercs : UserControl
    {
        ucSuppliersControls suppliersControls = new ucSuppliersControls();
        public ucSuppliercs()
        {
            InitializeComponent();
        }

        private void pnlOverview_Paint(object sender, PaintEventArgs e)
        {

        }

        public void ucSuppliercs_Load(object sender, EventArgs e)
        {
            LoadDgvView();
            btnAdd.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void LoadDgvView()
        {
            dgvView.DataSource = suppliersControls.DisplaySuppliers();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvView.Rows)
            {
                if (row.Cells["col_Name"].Value.ToString() == txtName.Text)
                {
                    if (MessageBox.Show("This supplier already exists.\nDo you want to add more?", "Warming", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    {
                        txtID.Text = row.Cells["col_Id"].Value.ToString();
                        txtName.Text = row.Cells["col_Name"].Value.ToString();
                        txtAddress.Text = row.Cells["col_Address"].Value.ToString();
                        txtContact.Text = row.Cells["col_Contact"].Value.ToString();
                        txtNote.Text = row.Cells["col_Note"].Value.ToString();
                        return;
                    }
                    else
                    {
                        suppliersControls.AddSupplier(txtName.Text, txtAddress.Text, txtContact.Text, txtNote.Text);
                        LoadDgvView();
                        txtID.Text = "";
                        txtName.Text = "";
                        txtContact.Text = "";
                        txtAddress.Text = "";
                        txtNote.Text = "";
                        return;
                    }
                }
            }
            MessageBox.Show("chua ton tai!");
            //if(suppliersControls.AddSupplier(txtName.Text, txtAddress.Text, txtContact.Text, txtNote.Text) == true)
            //{
            //    LoadDgvView();
            //    txtID.Text = "";
            //    txtName.Text = "";
            //    txtContact.Text = "";
            //    txtAddress.Text = "";
            //    txtNote.Text = "";
            //}
            
        }

        private void dgvView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAdd.Enabled = false;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            if (e.RowIndex>=0 && e.ColumnIndex >= 0)
            {
                txtID.Text = dgvView.Rows[e.RowIndex].Cells["col_Id"].Value.ToString();
                txtName.Text = dgvView.Rows[e.RowIndex].Cells["col_Name"].Value.ToString();
                txtContact.Text = dgvView.Rows[e.RowIndex].Cells["col_Contact"].Value.ToString();
                txtAddress.Text = dgvView.Rows[e.RowIndex].Cells["col_Address"].Value.ToString();
                txtNote.Text = dgvView.Rows[e.RowIndex].Cells["col_Note"].Value.ToString();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            suppliersControls.EditSupplier(txtID.Text,txtName.Text,txtAddress.Text,txtContact.Text,txtNote.Text);
            LoadDgvView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this supplier?", "Delete Supplier", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;
            suppliersControls.DeleteSupplier(txtID.Text);
            LoadDgvView();
            txtID.Text = "";
            txtName.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
            txtNote.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvView.DataSource = suppliersControls.SearchSupplier(txtSearch.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            LoadDgvView();
            txtID.Text = "";
            txtName.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
            txtNote.Text = "";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvView.DataSource = suppliersControls.SearchSupplier(txtSearch.Text);
        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Excel_Click(object sender, EventArgs e)
        {
            List<Suppliers> listSuppliers = suppliersControls.DisplaySuppliers();
            suppliersControls.ExportSuppliersToExcel(listSuppliers);
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            FReportSupplier fReportSupplier = new FReportSupplier();
            fReportSupplier.ShowDialog();
        }
    }
}
