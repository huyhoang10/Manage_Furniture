using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using System.Xml.Linq;
using Manage_Furniture.Models;

namespace Manage_Furniture.ADO
{
    internal class connectDatabase
    {
        public static manager_furnitureDataContext db = new manager_furnitureDataContext();

        public List<Suppliers> GetSuppliers()
        {
            List<Suppliers> listSuppliers = new List<Suppliers>();
            var suppliers = db.suppliers.ToList();
            for (int i = 0; i < suppliers.Count; i++)
            {
                Suppliers supplier = new Suppliers();
                supplier.Id = suppliers[i].id;
                supplier.Name = suppliers[i].name;
                supplier.Contact = suppliers[i].contact;
                supplier.Address = suppliers[i].address;
                supplier.Note = suppliers[i].note;
                listSuppliers.Add(supplier);
            }
            return listSuppliers;
        }
        public void AddSuppliers(int id, string name, string contact, string address, string note)
        {
            supplier newSupplier = new supplier();
            newSupplier.id = id;
            newSupplier.name = name;
            newSupplier.contact = contact;
            newSupplier.address = address;
            newSupplier.note = note;
            db.suppliers.InsertOnSubmit(newSupplier);
            db.SubmitChanges();
        }

        public void EditSuppliers(int id, string name, string contact, string address, string note)
        {
            var supplier = db.suppliers.Where(x => x.id == id).FirstOrDefault();
            {
                if (supplier != null)
                {
                    supplier.name = name;
                    supplier.contact = contact;
                    supplier.address = address;
                    supplier.note = note;
                    db.SubmitChanges();
                }
            }
        }

        
        public void DeleteSuppliers(int id)
        {
            var supplier = db.suppliers.Where(x => x.id == id).FirstOrDefault();
            {
                if (supplier != null)
                {
                    db.suppliers.DeleteOnSubmit(supplier);
                    db.SubmitChanges();
                }
            }
        }

        public List<Suppliers> SearchSuppliers(string key)
        {
            var suppliers = db.suppliers.Where(x => x.name.Contains(key)).ToList();
            List<Suppliers> listSuppliers = new List<Suppliers>();
            for (int i = 0; i < suppliers.Count; i++)
            {
                Suppliers supplier = new Suppliers();
                supplier.Id = suppliers[i].id;
                supplier.Name = suppliers[i].name;
                supplier.Contact = suppliers[i].contact;
                supplier.Address = suppliers[i].address;
                supplier.Note = suppliers[i].note;
                listSuppliers.Add(supplier);
            }
            return listSuppliers;
        }

        public List<Products> GetProducts()
        {
            List<Products> listProducts = new List<Products>();
            var products = db.products.ToList();
            for (int i = 0; i < products.Count; i++)
            {
                Products product = new Products();
                product.Id = products[i].id;
                product.Name = products[i].name;
                product.Supplier = products[i].supplier.ToString();
                product.Brand = products[i].brand;
                product.Subcategory = products[i].subcategory;
                product.Price = (float)products[i].price;
                listProducts.Add(product);
            }
            return listProducts;
        }

        

        public List<Products> SearchProducts(string key)
        {
            var products = db.products.Where(x => x.name.Contains(key)).ToList();
            List<Products> listProducts = new List<Products>();
            for (int i = 0; i < products.Count; i++)
            {
                Products product = new Products();
                product.Id = products[i].id;
                product.Name = products[i].name;
                product.Brand = products[i].brand;
                product.Subcategory = products[i].subcategory;
                product.Price = (float)products[i].price;
                var name_supplier = db.suppliers.Where(x => x.id == products[i].supplier).FirstOrDefault().name;
                product.Supplier = products[i].supplier.ToString()+" - "+name_supplier;
                product.Quantity = (int)db.warehouses.Where(x => x.id_product == products[i].id).FirstOrDefault().quantity;
                listProducts.Add(product);
            }
            return listProducts;
        }

       
        public void AddProductToWarehouse(int id, string name, int idsupplier, float price, string brand, string subcategory, int quantity)
        {
            product newProduct = new product();
            newProduct.id = id;
            newProduct.name = name;
            newProduct.subcategory = subcategory;
            newProduct.supplier = idsupplier;
            newProduct.brand = brand;
            newProduct.price = (decimal)price;
            db.products.InsertOnSubmit(newProduct);
            warehouse newWarehouse = new warehouse();
            newWarehouse.id_product = id;
            newWarehouse.quantity = quantity;
            db.warehouses.InsertOnSubmit(newWarehouse);
            db.SubmitChanges();
        }

        public void EditProductToWarehouse(int idproduct, string name_product, int id_supplier, float price,string subcategory,string brand,int quantity)
        {
            var warehouse = db.warehouses.Where(x => x.id_product == idproduct).FirstOrDefault();
            {
                if (warehouse != null)
                {
                    warehouse.quantity = quantity;
                    db.SubmitChanges();
                }
            }
            var product = db.products.Where(x => x.id == idproduct).FirstOrDefault();
            {
                if (product != null)
                {
                    product.name = name_product;
                    product.supplier = id_supplier;
                    product.brand = brand;
                    product.subcategory = subcategory;
                    product.price = (decimal)price;
                    db.SubmitChanges();
                }
            }
        }

        public void DeleteProductToWarehouse(int idproduct)
        {
            var product = db.products.Where(x => x.id == idproduct).FirstOrDefault();
            {
                if (product != null)
                {
                    db.products.DeleteOnSubmit(product);
                    db.SubmitChanges();
                }
            }
            var warehouse = db.warehouses.Where(x => x.id_product == idproduct).FirstOrDefault();
            {
                if (warehouse != null)
                {
                    db.warehouses.DeleteOnSubmit(warehouse);
                    db.SubmitChanges();
                }
            }
        }

        public List<Products> getProductToWarehouse()
        {
            List<Products> listProducts = new List<Products>();
            var result = from p in db.products
                         join w in db.warehouses
                         on p.id equals w.id_product
                         select new
                         {   p.id,
                             p.name,
                             p.supplier,
                             p.price,
                             p.subcategory,
                             p.brand,
                             w.quantity
                         };
            foreach(var item in result)
            {
                Products product = new Products();
                product.Id = item.id;
                product.Name = item.name;
                product.Brand = item.brand;
                product.Subcategory = item.subcategory;
                product.Price = (float)item.price;
                product.Quantity = (int)item.quantity;
                int IdSupplier = (int)item.supplier;
                var supllier = db.suppliers.Where(x => x.id == IdSupplier).FirstOrDefault();
                product.Supplier = IdSupplier.ToString() + " - " + supllier.name;
                listProducts.Add(product);
            }
            return listProducts;
        }

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

        // Top 5 sản phẩm order gần đây nhất    
        public static List<RecentOrder> GetTop5RecentOrders()
        {
            var orders = (
                from b in db.bills
                join o in db.orders on b.id_order equals o.id_order
                join c in db.customers on o.id_customer equals c.id
                group new { b, o, c } by b.id_order into g
                let first = g.FirstOrDefault()
                orderby first.o.date_purchase descending
                select new RecentOrder
                {
                    Id = first.b.id_order,
                    CustomerName = first.c.name,
                    DatePurchase = first.o.date_purchase.Value,
                    Money = first.b.money ?? 0,
                    Note = first.o.note
                }).Take(5).ToList();
            return orders;
        }

        public static List<RecentOrder> GetAllOrders()
        {
            var orders = (
                from b in db.bills
                join o in db.orders on b.id_order equals o.id_order
                join c in db.customers on o.id_customer equals c.id
                group new { b, o, c } by b.id_order into g
                let first = g.FirstOrDefault()
                orderby first.o.date_purchase descending
                select new RecentOrder
                {
                    Id = first.b.id_order,
                    CustomerName = first.c.name,
                    DatePurchase = first.o.date_purchase.Value,
                    Money = first.b.money ?? 0,
                    Note = first.o.note
                }).ToList();
            return orders;
        }

        //public static List<Order> GetInfoOrders(int idbill) { 
        //    var orders = new List<Order>();
        //    var list_product_order = db.orders.Where(x => x.id_order == idbill).ToList();
        //    foreach (var item in list_product_order)
        //    {
        //        Order order = new Order();
        //        order.Id = item.id_order;
        //        order.Id_customer = (int)item.id_customer;
        //        order.Id_product = (int)item.id_product;
        //        order.Quantity = (int)item.quantity;
        //        order.Date_purchase = (DateTime)item.date_purchase;
        //        order.Money = (decimal)item.money;
        //        order.Note = item.note;
        //        orders.Add(order);
        //    }
        //    return orders;
        //}
        public static List<OrderInfo> GetInfoOrders(int idbill)
        {
            var query = from o in db.orders
                        join p in db.products on o.id_product equals p.id
                        where o.id_order == idbill
                        select new OrderInfo
                        {
                            IdOrder = o.id_order,
                            ProductName = p.name,
                            Quantity = (int)o.quantity,
                            Price = (decimal)p.price,
                            Money = (decimal)o.money
                        };

            return query.ToList();
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
        public string CustomerName { get; set; } 
        public DateTime DatePurchase { get; set; }
        public decimal Money { get; set; }
        public string Note { get; set; }
    }

    public class OrderInfo
    {
        public int IdOrder { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Money { get; set; }
    }
}