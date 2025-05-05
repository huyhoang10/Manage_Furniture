using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manage_Furniture.ADO;
using Manage_Furniture.Forms;

namespace Manage_Furniture.Models
{
    internal class Order
    {
        manager_furnitureDataContext db = connectDatabase.GetContext();

        public class OrderView
        {
            public int ID { get; set; }
            public string Product { get; set; }
            public int Quantity { get; set; }
            public DateTime DatePurchase { get; set; }
            public decimal Money { get; set; }
            public string Note { get; set; }
            public int ProductID { get; set; }
        }



    }
}
