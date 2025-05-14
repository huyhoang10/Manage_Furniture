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
    public partial class ucHistory : UserControl
    {
        public ucHistory()
        {
            InitializeComponent();
        }

        ucHistoryControls ucHistoryControls = new ucHistoryControls();
        public void ucHistory_Load(object sender, EventArgs e)
        {
            dgvHistoryOrder.DataSource = ucHistoryControls.GetAllOrders();
            dgvOderDetail.DataSource = null;
        }

        private void dgvHistoryOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0 && e.ColumnIndex>=0)
            {   
                string id = dgvHistoryOrder.Rows[e.RowIndex].Cells["col_id"].Value.ToString();
                dgvOderDetail.DataSource = ucHistoryControls.GetInforOrder(id);
                txtTotal.Text = dgvHistoryOrder.Rows[e.RowIndex].Cells["col_money"].Value.ToString();
            }
        }
    }
}
