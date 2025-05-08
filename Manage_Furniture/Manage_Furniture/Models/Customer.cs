using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manage_Furniture.ADO;

namespace Manage_Furniture.Models
{
    internal class Customerclass
    {
        public static manager_furnitureDataContext db = new manager_furnitureDataContext();
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Sex { get; set; } 
        public string Address { get; set; }
        public string Type { get; set; }

        public List<customer> GetAllCustomers()
        {
            return db.customers.ToList();
        }


        public List<customer> SearchCustomersByPhone(string PhoneNumber)
        {
            return db.customers
                          .Where(c => c.phone != null && c.phone.StartsWith(PhoneNumber))
                          .ToList();
        }


    }

}
