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
using System.Windows.Forms.DataVisualization.Charting;

namespace Manage_Furniture.Forms
{
    public partial class ucOverview : UserControl
    {
        private ucOverviewControl _ucOverviewControl; // gọi đúng control của mình
        public ucOverview()
        {
            InitializeComponent();
            dgvRecentOrder.RowHeadersVisible = false;
            _ucOverviewControl = new ucOverviewControl(); // khởi tạo
            Loaddata();
        }

        private void Loaddata()
        {
            SetupDataGridView();
            StyleDataGridView(dgvRecentOrder);

            // --- Revenue ---
            decimal currentRevenue = _ucOverviewControl.GetCurrentRevenue();
            lblRevenue.Text = $"{currentRevenue:N2} $";

            lblRevenue.Left = (pnlRevenue.Width - lblRevenue.Width) / 2;
            lblRevenue.Top = (pnlRevenue.Height - lblRevenue.Height) / 2;

            decimal percentChange = _ucOverviewControl.GetPercentChange();
            if (percentChange >= 0)
            {
                lblPercentChange.Text = $"Increase {percentChange:N1}%";
                lblPercentChange.ForeColor = Color.LimeGreen;
            }
            else
            {
                lblPercentChange.Text = $"Decrease {Math.Abs(percentChange):N1}%";
                lblPercentChange.ForeColor = Color.Red;
            }

            // Căn giữa lblPercentChange
            lblPercentChange.Left = (pnlRevenue.Width - lblPercentChange.Width) / 2;
            // Cho nó nằm dưới lblRevenue khoảng 20px
            lblPercentChange.Top = lblRevenue.Bottom + 80;


            // --- Chart Revenue ---
            var monthlyRevenue = _ucOverviewControl.GetMonthlyRevenue();
            chartRevenue.Series.Clear();
            Series series = new Series
            {
                Name = "Revenue",
                ChartType = SeriesChartType.Column
            };
            chartRevenue.Series.Add(series);

            for (int month = 1; month <= 12; month++)
            {
                decimal revenue = monthlyRevenue.FirstOrDefault(m => m.Month == month)?.TotalRevenue ?? 0;
                series.Points.AddXY(month, revenue);
            }

            StyleChart(chartRevenue);

            // --- Recently Orders ---
            dgvRecentOrder.Rows.Clear(); // chỉ Rows.Clear khi setup = tay
            var recentOrders = _ucOverviewControl.GetTop4RecentOrders();
            if (recentOrders.Count == 0)
            {
                MessageBox.Show("No recent orders to display.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                foreach (var order in recentOrders)
                {
                    dgvRecentOrder.Rows.Add(
                        order.Id,
                        order.CustomerName,
                        order.ProductName,
                        order.Quantity,
                        order.DatePurchase.ToShortDateString(),
                        order.Money,
                        order.Note
                    );
                }
            }
        }

        private void SetupDataGridView()
        {
            dgvRecentOrder.Columns.Clear();
            dgvRecentOrder.Columns.Add("id_order", "ID");
            dgvRecentOrder.Columns.Add("name", "Customer Name");
            dgvRecentOrder.Columns.Add("name", "Product Name");
            dgvRecentOrder.Columns.Add("quantity", "Quantity");
            dgvRecentOrder.Columns.Add("date_purchase", "Date Purchase");
            dgvRecentOrder.Columns.Add("money", "Money");
            dgvRecentOrder.Columns.Add("note", "Note");

            foreach (DataGridViewColumn col in dgvRecentOrder.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void StyleDataGridView(DataGridView dgv)
        {
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.SaddleBrown;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Montserrat", 12, FontStyle.Bold);
            dgv.DefaultCellStyle.Font = new Font("Montserrat", 10, FontStyle.Regular);
            dgv.ColumnHeadersHeight = 40;
            dgv.RowTemplate.Height = 35;
            dgv.DefaultCellStyle.SelectionBackColor = Color.LightGray;
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.GridColor = Color.LightGray;
        }

        private void StyleChart(Chart chart)
        {
            chart.BackColor = Color.White;
            chart.ChartAreas[0].BackColor = Color.White;
            chart.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Montserrat", 10, FontStyle.Bold);
            chart.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Montserrat", 10, FontStyle.Bold);
            chart.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            chart.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            chart.Series[0].Color = Color.SaddleBrown;
            chart.Series[0].BorderWidth = 3;

            // Thêm dòng này để XÓA legend
            chart.Legends.Clear();

            // Center chart trong Panel
            chart.Left = (chart.Parent.Width - chart.Width) / 2;
            chart.Top = (chart.Parent.Height - chart.Height) / 2;
        }


    }
}
