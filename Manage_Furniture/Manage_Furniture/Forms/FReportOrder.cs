using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manage_Furniture.ADO;
using Manage_Furniture.Controls;

namespace Manage_Furniture.Forms
{
    public partial class FReportOrder : Form
    {
        ucOrderControl oc = new ucOrderControl();
        Helper h = new Helper();
        public FReportOrder()
        {
            InitializeComponent();
        }

        private void FReportOrder_Load(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            List<order> tbl = oc.GetAllOrders();

            DataTable orderTable = h.ConvertToDataTable(tbl);
            // 2) Đổ vào DataSet
            var ds = new dtOrder();
            ds.Tables["orders"].Merge(orderTable);

            // 3) Gán cho ReportDocument
            var rpt = new crvOrder();       // lớp report được tạo từ Crystal
            rpt.SetDataSource(ds);

            // 4) Hiển thị
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
