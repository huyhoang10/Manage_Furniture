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
            btnHome.Visible = true;
            btnHR.Visible = true;
            btnSupplier.Visible = true;
            SetAllButton();
            btnHome.FillColor = Color.FromArgb(197, 166, 158);
            ucOverview1.BringToFront();
        }

        protected override void SetAllButton()
        {
            base.SetAllButton();
            btnHome.FillColor = Color.White;
            btnHR.FillColor = Color.White;
        }
    }
}
