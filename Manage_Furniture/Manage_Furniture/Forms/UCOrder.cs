using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Manage_Furniture.Controls;

namespace Manage_Furniture.Forms
{
    public partial class UCOrder : UserControl
    {
        ucOrderControl ucorder_control = new ucOrderControl();
        public UCOrder()
        {
            InitializeComponent();
        }

    }
}
