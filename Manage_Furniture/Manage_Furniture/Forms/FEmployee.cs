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
    public partial class FEmployee : Form
    {
        public FEmployee()
        {
            InitializeComponent();
        }


        protected void FEmployee_Load(object sender, EventArgs e)
        {
            btnHome.Visible = false;
            btnHR.Visible = false;
            btnSupplier.Visible = false;
            SetAllButton();
            btnOrder.FillColor = Color.FromArgb(197, 166, 158);
            ucOrder1.BringToFront();
            btnUser.Text = "Hi! "+FLogin.userLogin.Name;
        }

        protected virtual void SetAllButton()
        {
            btnHome.FillColor = Color.White;
            btnOrder.FillColor = Color.White;
            btnCustomer.FillColor = Color.White;
            btnWarehouse.FillColor = Color.White;
            btnSupplier.FillColor = Color.White;
            btnHR.FillColor = Color.White;
            btnHistory.FillColor = Color.White;
        }

        protected void btnCustomer_Click(object sender, EventArgs e)
        {
            SetAllButton();
            btnCustomer.FillColor = Color.FromArgb(197, 166, 158);
            ucCustomer1.BringToFront();
            ucCustomer1.UCCustomer_Load(sender, e);
        }

        protected void btnOrder_Click(object sender, EventArgs e)
        {
            SetAllButton();
            btnOrder.FillColor = Color.FromArgb(197, 166, 158);
            ucOrder1.BringToFront();
        }

        protected virtual void btnWarehouse_Click(object sender, EventArgs e)
        {
            SetAllButton();
            btnWarehouse.FillColor = Color.FromArgb(197, 166, 158);
            ucWarehouse1.BringToFront();
            ucWarehouse1.ucWarehouse_Load(sender, e);
        }

        protected void btnSupplier_Click(object sender, EventArgs e)
        {
            SetAllButton();
            btnSupplier.FillColor = Color.FromArgb(197, 166, 158);
            ucSuppliercs1.BringToFront();
            ucSuppliercs1.ucSuppliercs_Load(sender, e);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            SetAllButton();
            btnHome.FillColor = Color.FromArgb(197, 166, 158);
            ucOverview1.BringToFront();
            ucOverview1.Loaddata();
        }

        private void btnHR_Click(object sender, EventArgs e)
        {
            SetAllButton();
            btnHR.FillColor = Color.FromArgb(197, 166, 158);
            ucHR1.BringToFront();
            ucHR1.ucHumanResourceManagement_Load(sender, e);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FLogin.userLogin.Name = "";
                FLogin.userLogin.Phone = "";
                FLogin loginForm = new FLogin();
                loginForm.Show();
                this.Close();
            }
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            SetAllButton();
            btnHistory.FillColor = Color.FromArgb(197, 166, 158);
            ucHistory1.BringToFront();
            ucHistory1.ucHistory_Load(sender, e);
        }
    }
}
