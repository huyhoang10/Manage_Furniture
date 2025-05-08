using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using Manage_Furniture.ADO;
using Manage_Furniture.Controls;
namespace Manage_Furniture.Forms
{
    public partial class UCBill : Form
    {
        public UCBill()
        {
            InitializeComponent();
        }

        public class BillItemDTO
        {
            public string IDOrder { get; set; }
            public string CustomerName { get; set; }
            public string PhoneCustomer { get; set; }
            public string AddressCustomer { get; set; }
            public string Sex { get; set; }
            public string CustomerType { get; set; }

            public string ProductName { get; set; }
            public int Quantity { get; set; }
            public decimal Price { get; set; }
            public decimal Money { get; set; }

            public string EmployeeName { get; set; }
            public DateTime DatePurchase { get; set; }
            public string Note { get; set; }

            public decimal GrandTotal { get; set; }
        }

        private List<BillItemDTO> GetBillData(int orderid)
        {
            using (var db = new manager_furnitureDataContext())
            {
                var query = from o in db.orders
                            join c in db.customers on o.id_customer equals c.id
                            join p in db.products on o.id_product equals p.id
                            join b in db.bills on o.id_order equals b.id_order
                            //join e in db.employees on /* điều kiện nhân viên phù hợp */ true equals true
                            where o.id_order == orderid
                            select new BillItemDTO
                            {
                                IDOrder = o.id_order.ToString(),
                                CustomerName = c.name,
                                PhoneCustomer = c.phone,
                                AddressCustomer = c.address,
                                Sex = c.sex,
                                CustomerType = c.type,

                                ProductName = p.name,
                                Quantity = (int)o.quantity,
                                Price = (decimal)p.price,
                                Money = (decimal)o.money,

                                //EmployeeName = e.name, // nếu có liên kết cụ thể
                                DatePurchase = (DateTime)o.date_purchase,
                                Note = o.note,

                                GrandTotal = (decimal)b.money
                            };

                return query.ToList();
            }
        }
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            int orderid = ucOrderControl.global_orderID;
            try
            {
                var data = GetBillData(orderid);

                // crvBill là lớp report đã được add vào project (tạo từ crvBill.rpt)
                crvBill report = new crvBill();

                // Gán dữ liệu cho report
                report.SetDataSource(data);

                // Gán report cho viewer
                crystalReportViewer1.ReportSource = report;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải báo cáo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
