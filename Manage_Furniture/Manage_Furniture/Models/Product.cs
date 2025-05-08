using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manage_Furniture.ADO;

namespace Manage_Furniture.Models
{
    internal class Product
    {
        manager_furnitureDataContext db = new manager_furnitureDataContext(); //connectDatabase.GetContext();
        public int Id { get; set; }            
        public string Name { get; set; }     
        public string Brand { get; set; }     
        public decimal Price { get; set; }
        //public int SupplierId { get; set; }

        //public List<product> GetAllProducts()
        //{
        //    return db.products.ToList();
        //}
    }
}
