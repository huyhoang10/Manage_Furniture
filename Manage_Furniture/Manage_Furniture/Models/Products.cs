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
        string brand;
        float price;
        int quantity;
        string material;
        byte[] image; // Assuming Image is stored as byte array

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Brand { get => brand; set => brand = value; }
        public float Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public string Material { get => material; set => material = value; }
        public byte[] Image { get => image; set => image = value; }
        public int RandomID()
        {
            Random random = new Random();
            int randomNumber = random.Next(10000, 99999);
            return randomNumber;
        }
    }
}
