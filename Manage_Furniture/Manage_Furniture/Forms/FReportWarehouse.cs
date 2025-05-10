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
using Manage_Furniture.Models;

namespace Manage_Furniture.Forms
{
    public partial class FReportWarehouse : Form
    {
        ucWarehouseControls ucWarehouse = new ucWarehouseControls();
        public FReportWarehouse()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            List<Products> productList = ucWarehouse.DisplayInformation();

            // Tạo DataTable từ danh sách
            DataTable warehouseTable = ucWarehouse.CreateProductsDataTable(productList);

            // Tạo instance của DataSet đã thiết kế sẵn (dtsWarehouse.xsd)
            dtsWarehouse ds = new dtsWarehouse();

            ds.Tables["warehouse"].Clear();
            foreach (DataRow row in warehouseTable.Rows)
            {
                ds.Tables["warehouse"].ImportRow(row);  // tránh lỗi kiểu dữ liệu khi dùng Merge
            }

            // Tạo và gán Crystal Report
            crvWarehouse rpt = new crvWarehouse(); // rptWarehouse.rpt là báo cáo bạn đã thiết kế
            rpt.SetDataSource(ds);

            // Gán cho CrystalReportViewer
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
