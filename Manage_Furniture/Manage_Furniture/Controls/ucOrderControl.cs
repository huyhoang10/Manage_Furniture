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
                var existingCustomer = db.customers.FirstOrDefault(c => c.phone == phone);

                if (existingCustomer != null)
                {
                    DialogResult result = MessageBox.Show("Customer already exists! Would you like to create a new order for this customer?",
                                                          "Customer Found", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                        return; 
                    customerId = existingCustomer.id;
                }
                else
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
                }

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

                var newBill = new bill
                {
                    id_order = orderId,
                    money = totalMoney
                };

                db.bills.InsertOnSubmit(newBill);
                db.SubmitChanges();

                MessageBox.Show("Order and bill added successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MessageBox.Show("Order added successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //public void CreateBill(bill newBill)
        //{
        //    newBill.id_order = ;
        //    db.bills.InsertOnSubmit(newBill);
        //}
    }
}

