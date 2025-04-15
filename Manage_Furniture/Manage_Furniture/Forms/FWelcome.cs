using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manage_Furniture.Forms;

namespace Manage_Furniture
{
    public partial class FWelcome : Form
    {
        public FWelcome()
        {
            InitializeComponent();
        }

        private void FWelcome_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            FEmployee fEmployee = new FEmployee();
            fEmployee.ShowDialog();
        }
    }
}
