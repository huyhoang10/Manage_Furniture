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
    public partial class FManager : FEmployee
    {
        public FManager()
        {
            InitializeComponent();
            
        }

        protected void FManager_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to the Manager's Dashboard!");
            SetAllButton();
            pnltest.BringToFront();
            //btnHome.FillColor = Color.FromArgb(197, 166, 158);
        }

        protected override void SetAllButton()
        {
            base.SetAllButton();
            //btnHome.FillColor = Color.White;
            //btnHR.FillColor = Color.White;
        }

        //private void btnHome_Click(object sender, EventArgs e)
        //{
        //    SetAllButton();
        //    btnHome.FillColor = Color.FromArgb(197, 166, 158);
        //}

        //private void btnHR_Click(object sender, EventArgs e)
        //{
        //    SetAllButton();
        //    btnHR.FillColor = Color.FromArgb(197, 166, 158);
        //}
    }
}
