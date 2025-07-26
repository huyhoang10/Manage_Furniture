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
    public partial class FReportSupplier : Form
    {
        ucSuppliersControls ucSuppliersControls = new ucSuppliersControls();
        Helper h = new Helper();
        public FReportSupplier()
        {
            InitializeComponent();
        }

        private void FReportSupplier_Load(object sender, EventArgs e)
        {
            List<Suppliers> tbl = ucSuppliersControls.DisplaySuppliers();
            // 1) Tạo DataTable từ danh sách
            DataTable supplierTable = h.ConvertToDataTable(tbl);
            // 2) Đổ vào DataSet
            var ds = new dtsSupplier();
            ds.Tables["supplier"].Merge(supplierTable);
            crvSupplier rpt = new crvSupplier();       // lớp report được tạo từ Crystal
            rpt.SetDataSource(ds);
            // 4) Hiển thị
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
