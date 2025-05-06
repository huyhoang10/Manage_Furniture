using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Furniture.ADO
{
    internal class connectDatabase
    {
        private static manager_furnitureDataContext db = new manager_furnitureDataContext();

        // Tổng doanh thu tháng hiện tại    
        public static decimal GetCurrentMonthRevenue()
        {
            var now = DateTime.Now;
            var revenue = db.orders
                            .Where(o => o.date_purchase.HasValue && o.date_purchase.Value.Month == now.Month && o.date_purchase.Value.Year == now.Year)
                            .Sum(o => (decimal?)o.money) ?? 0;
            return revenue;
        }

        // Tổng doanh thu tháng trước    
        public static decimal GetLastMonthRevenue()
        {
            var now = DateTime.Now;
            var lastMonth = now.AddMonths(-1);
            var revenue = db.orders
                            .Where(o => o.date_purchase.HasValue && o.date_purchase.Value.Month == lastMonth.Month && o.date_purchase.Value.Year == lastMonth.Year)
                            .Sum(o => (decimal?)o.money) ?? 0;
            return revenue;
        }

        // Danh sách doanh thu từng tháng trong năm    
        public static List<RevenuePerMonth> GetRevenueByMonth()
        {
            var now = DateTime.Now;
            var data = db.orders
                        .Where(o => o.date_purchase.HasValue && o.date_purchase.Value.Year == now.Year)
                        .GroupBy(o => o.date_purchase.Value.Month)
                        .Select(g => new RevenuePerMonth
                        {
                            Month = g.Key,
                            TotalRevenue = g.Sum(x => (decimal?)x.money) ?? 0 // Explicitly cast to decimal? and handle null    
                        })
                        .ToList();

            return data;
        }

        // Top 3 sản phẩm order gần đây nhất    
        public static List<RecentOrder> GetTop3RecentOrders()
        {
            var orders = (from o in db.orders
                          join p in db.products on o.id_product equals p.id
                          select new RecentOrder
                          {
                              Id = o.id,
                              IdCustomer = o.id_customer.Value,
                              IdProduct = o.id_product.Value,
                              Quantity = o.quantity.Value,
                              DatePurchase = o.date_purchase.Value,
                              Money = o.money ?? 0,
                              Note = o.note
                          }).Take(3).ToList();
            return orders;
        }
    }

    public class RevenuePerMonth
    {
        public int Month { get; set; }
        public decimal TotalRevenue { get; set; }
    }

    public class RecentOrder
    {
        public int Id { get; set; }
        public int IdCustomer { get; set; }
        public int IdProduct { get; set; }
        public int Quantity { get; set; }
        public DateTime DatePurchase { get; set; }
        public decimal Money { get; set; }
        public string Note { get; set; }
    }
}
