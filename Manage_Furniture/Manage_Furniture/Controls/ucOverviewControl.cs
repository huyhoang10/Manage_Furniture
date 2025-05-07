using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manage_Furniture.ADO;

namespace Manage_Furniture.Controls
{
    internal class ucOverviewControl
    {
        public decimal GetCurrentRevenue()
        {
            return connectDatabase.GetCurrentMonthRevenue();
        }

        public decimal GetPercentChange()
        {
            decimal current = connectDatabase.GetCurrentMonthRevenue();
            decimal last = connectDatabase.GetLastMonthRevenue();

            if (last == 0) return 100; // Nếu tháng trước ko có doanh thu, thì tăng 100%
            return ((current - last) / last) * 100;
        }

        public List<RevenuePerMonth> GetMonthlyRevenue()
        {
            return connectDatabase.GetRevenueByMonth();
        }

        public List<RecentOrder> GetTop4RecentOrders()
        {
            return connectDatabase.GetTop4RecentOrders();
        }

    }
}
