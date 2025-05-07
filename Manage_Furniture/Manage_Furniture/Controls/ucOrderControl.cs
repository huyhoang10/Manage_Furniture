using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manage_Furniture.ADO;
using Manage_Furniture.Forms;
using Manage_Furniture.Models;

namespace Manage_Furniture.Controls
{
    internal class ucOrderControl
    {
        manager_furnitureDataContext db = connectDatabase.GetContext();
        public List<product> GetAllProducts()
        {
            return db.products.ToList();
        }

        public product GetProductById(int id)
        {
            return db.products.FirstOrDefault(p => p.id == id);
        }

        public List<order> GetAllOrders()
        {
            return db.orders.ToList();
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
            int customerId = new Random().Next(1000, 9999);

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

                int orderId = new Random().Next(1000, 9999);
                foreach (DataGridViewRow row in dgv_orders.Rows)
                {
                    if (row.IsNewRow || row.Cells["col_product"].Value == null)
                        continue;

                    string productValue = row.Cells["col_product"].Value.ToString();
                    string[] parts = productValue.Split('_');

                    if (parts.Length < 2 || !int.TryParse(parts[0], out int id_product))
                        continue;

                    if (!int.TryParse(row.Cells["col_quantity"].Value?.ToString(), out int quantity) || quantity <= 0)
                        quantity = 1;

                    var newOrder = new order
                    {
                        id_order = orderId,
                        id_customer = customerId,
                        id_product = id_product,
                        quantity = quantity,
                        date_purchase = DateTime.Now,
                        money = totalMoney,
                        note = note
                    };

                    AddOrder(newOrder);
                }

                MessageBox.Show("Order added successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CreateBill(bill newBill)
        {
            newBill.id_order = new Random().Next(1000,9999);
            db.bills.InsertOnSubmit(newBill); 
        }
    }
}

