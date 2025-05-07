using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Furniture.Models
{
    internal class Products
    {
        int id;
        string name;
        string subcategory;
        string supplier;
        string brand;
        float price;
        int quantity;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Subcategory { get => subcategory; set => subcategory = value; }
        public string Supplier { get => supplier; set => supplier = value; }
        public string Brand { get => brand; set => brand = value; }
        public float Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int RandomID()
        {
            Random random = new Random();
            int randomNumber = random.Next(10000, 99999);
            return randomNumber;
        }
    }
}
