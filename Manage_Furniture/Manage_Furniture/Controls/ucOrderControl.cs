using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manage_Furniture.ADO;
using Manage_Furniture.Forms;
using Manage_Furniture.Models;
using static Manage_Furniture.Forms.UCBill;

namespace Manage_Furniture.Controls
{
    internal class ucOrderControl
    {
        public  manager_furnitureDataContext db = new manager_furnitureDataContext(); //connectDatabase.GetContext();
        public static int global_orderID = 0;

        public List<product> GetAllProducts()
        {
            return db.products.ToList();
        }

        public product GetProductById(int id)
        {
            return db.products.FirstOrDefault(p => p.id == id);
        }

        // Check Phone?=exist
        public bool IsPhoneNumberExists(string phone)
        {
            var customer = db.customers.FirstOrDefault(c => c.phone == phone);
            return customer != null;
        }

        public customer GetCustomerByPhone(string phone)
        {
            return db.customers.FirstOrDefault(c => c.phone == phone);
        }

        public List<order> GetAllOrders()
        {
            return db.orders.ToList();
        }

        // Warehouse
        public warehouse GetAllWarehouse(int id_product)
        {
            return db.warehouses.FirstOrDefault(p => p.id_product == id_product);
        }

        public int GetWarehouseQuantity(int id_product)
        {
            int totalQuantity = (int)db.warehouses
                                  .Where(w => w.id_product == id_product) 
                                  .Sum(w => w.quantity);

            return totalQuantity;
        }

        // Update Quantiy of Product in Warehouse when ordered
        public void UpdateWarehouseQuantity(int id_product, int quantitySold)
        {
            var warehouse = db.warehouses.FirstOrDefault(w => w.id_product == id_product);
            if (warehouse != null && warehouse.quantity > 0)
            {
                warehouse.quantity -= quantitySold;
                db.SubmitChanges();
            }
        }

        public void AddOrder(order newOrder)
        {
            newOrder.date_purchase = DateTime.Now;
            db.orders.InsertOnSubmit(newOrder);
            db.SubmitChanges();  
        }

        public void AddCustomer(customer newCustomer)
        {
            db.customers.InsertOnSubmit(newCustomer);
            db.SubmitChanges();
        }

        public void AddOrderAndCustomer(string customer_name, string sex, string phone, string address,
                                           string type, string note, decimal totalMoney, DataGridView dgv_orders)
        {
            int customerId = new Random().Next(10000, 99999);
            int orderId;
            do
            {
                orderId = new Random().Next(10000, 100000);
            } while (orderId == customerId);

            try
            {
                var newCustomer = new customer
                {
                    id = customerId,
                    name = customer_name,
                    sex = sex,
                    phone = phone,
                    address = address,
                    type = type
                };

                AddCustomer(newCustomer);

                foreach (DataGridViewRow row in dgv_orders.Rows)
                {
                    if (row.IsNewRow || row.Cells["col_product"].Value == null)
                        continue;

                    string productValue = row.Cells["col_product"].Value.ToString();
                    string[] parts = productValue.Split('-');

                    if (parts.Length < 2 || !int.TryParse(parts[0], out int id_product))
                        continue;

                    if (!int.TryParse(row.Cells["col_quantity"].Value?.ToString(), out int quantity) || quantity <= 0)
                        quantity = 1;

                    var product = GetProductById(id_product);
                    if (product == null) continue;

                    var newOrder = new order
                    {
                        id_order = orderId,
                        id_customer = customerId,
                        id_product = id_product,
                        quantity = quantity,
                        date_purchase = DateTime.Now,
                        money = product.price * quantity,
                        note = note
                    };
                    global_orderID = orderId;
                    AddOrder(newOrder);
                    UpdateWarehouseQuantity(product.id, quantity);
                }
                AddBill(orderId, customerId);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void AddBill(int orderId, decimal totalMoney)
        {
            var newBill = new bill
            {
                id_order = orderId,
                money = totalMoney
            };

            db.bills.InsertOnSubmit(newBill);
            db.SubmitChanges();
        }
    }
}

