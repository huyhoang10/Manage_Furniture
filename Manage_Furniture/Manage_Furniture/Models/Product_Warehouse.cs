using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Furniture.Models
{
    internal class Product_Warehouse
    {
        Products product = new Products();
        int quantity;

        public Products Product
        {
            get { return product; }
            set { product = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
    }
}
