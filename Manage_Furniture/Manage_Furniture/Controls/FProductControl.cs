using Manage_Furniture.ADO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manage_Furniture.Models;

namespace Manage_Furniture.Controls
{
    internal class FProductControl
    {
        connectDatabase connectDB = new connectDatabase();
        bool isIdProductExist(int id)
        {
            var products = connectDatabase.db.products.Where(p => p.id == id).FirstOrDefault();
            if (products != null)
                return true;
            return false;
        }

        public byte[] ConvertImageToByteArray(System.Drawing.Image image)
        {
            using (var ms = new System.IO.MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
        public bool AddProductToWarehouse(string name, string subcategory, string price, string quantity, string brand,string color, string material, byte[] image)
        {
            Random random = new Random();

            if (name == "")
            {
                MessageBox.Show("Please fill name the fields", "Error");
                return false;
            }
            if (float.TryParse(price, out float priceValue) == false)
            {
                MessageBox.Show("Please enter valid price", "Error");
                return false;
            }
            if (float.Parse(price) == 0)
            {
                MessageBox.Show("Price must be greater than zero.", "Invalid Price");
                return false;
            }
            while (true)
            {
                int id = random.Next(10000, 99999);
                if (!isIdProductExist(id))
                {
                    connectDB.AddProductToWarehouse(id, name, priceValue, brand, subcategory, Int32.Parse(quantity),color,material,image);
                    return true;
                }
            }



        }

        public bool EditProductInWarehouse(string id, string name, string supplier, string subcategory, string price, string quantity, string brand, string color, string material, byte[] image)
        {
            if (id != "")
            {
                if (name == "")
                {
                    MessageBox.Show("Please fill name the fields", "Error");
                    return false;
                }
               
                if (float.TryParse(price, out float priceValue) == false)
                {
                    MessageBox.Show("Please enter valid price", "Error");
                    return false;
                }
                if (float.Parse(price) == 0)
                {
                    MessageBox.Show("Price must be greater than zero.", "Invalid Price");
                    return false;
                }
                connectDB.EditProductToWarehouse(Int32.Parse(id), name, Int32.Parse(supplier), priceValue, subcategory, brand, Int32.Parse(quantity), color, material, image);
                return true;
            }
            else
                MessageBox.Show("Please choose Product", "Error");
            return false;
        }
    }
}
