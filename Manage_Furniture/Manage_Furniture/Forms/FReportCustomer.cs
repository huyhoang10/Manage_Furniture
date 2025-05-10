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
using Manage_Furniture.ADO;
using Manage_Furniture.Controls;
using DocumentFormat.OpenXml.Drawing;

namespace Manage_Furniture.Forms
{
    public partial class FReportCustomer : Form
    {
        Customerclass cc = new Customerclass();
        Helper h = new Helper();
        public FReportCustomer()
        {
            InitializeComponent();
        }


        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            List<customer> tbl = cc.GetAllCustomers();

            DataTable customerTable = h.ConvertToDataTable(tbl);
            // 2) Đổ vào DataSet
            var ds = new dtsCustomer();
            ds.Tables["customer"].Merge(customerTable);

            // 3) Gán cho ReportDocument
            var rpt = new crvCustomer();       // lớp report được tạo từ Crystal
            rpt.SetDataSource(ds);

            // 4) Hiển thị
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
