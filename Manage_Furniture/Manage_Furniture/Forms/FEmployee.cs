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
            SetAllButton();
            btnCustomer.FillColor = Color.FromArgb(197, 166, 158);
        }

        protected virtual void SetAllButton()
        {
            btnCustomer.FillColor = Color.White;
            btnOrder.FillColor = Color.White;
            btnWarehouse.FillColor = Color.White;
            btnSupplier.FillColor = Color.White;
        }

        protected void btnCustomer_Click(object sender, EventArgs e)
        {
            SetAllButton();
            btnCustomer.FillColor = Color.FromArgb(197, 166, 158);
        }

        protected void btnOrder_Click(object sender, EventArgs e)
        {
            SetAllButton();
            btnOrder.FillColor = Color.FromArgb(197, 166, 158);
        }

        protected virtual void btnWarehouse_Click(object sender, EventArgs e)
        {
            SetAllButton();
            btnWarehouse.FillColor = Color.FromArgb(197, 166, 158);
            ucWarehouse1.BringToFront();
        }

        protected void btnSupplier_Click(object sender, EventArgs e)
        {
            SetAllButton();
            btnSupplier.FillColor = Color.FromArgb(197, 166, 158);
            ucSuppliercs1.BringToFront();
        }
    }
}
