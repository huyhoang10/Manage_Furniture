using Manage_Furniture.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manage_Furniture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            FEmployee fEmployee = new FEmployee();
            fEmployee.ShowDialog();

        }

        private void btnM_Click(object sender, EventArgs e)
        {
            FManager fManager = new FManager();
            fManager.ShowDialog();
        }
    }
}
