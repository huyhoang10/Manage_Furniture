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
    public partial class FReportEmployee : Form
    {
        HRControl hc = new HRControl();
        Helper h = new Helper();
        public FReportEmployee()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            List<EmployeeModel> tbl = hc.GetAll();
            // 1) Tạo DataTable từ danh sách
            DataTable employeeTable = h.ConvertToDataTable(tbl);
            // 2) Đổ vào DataSet
            var ds = new dtsHR();
            ds.Tables["employee"].Merge(employeeTable);
            crvHR rpt = new crvHR();       // lớp report được tạo từ Crystal
            rpt.SetDataSource(ds);
            // 4) Hiển thị
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
