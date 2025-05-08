using Manage_Furniture.ADO;
using Manage_Furniture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace Manage_Furniture.Controls
{
    internal class ucWarehouseControls
    {
        connectDatabase connectDB = new connectDatabase();
        List<Suppliers> listSuppliers = new List<Suppliers>();

        public void LoadSuppliers()
        {
            listSuppliers = connectDB.GetSuppliers();
        }

        public List<string> LoadCmbSuppliers()
        {
            LoadSuppliers();
            List<string> dataCmbSupplier = new List<string>();
            foreach (var item in listSuppliers)
            {
                string id_nameSupplier = item.Id.ToString() + " - " + item.Name;
                dataCmbSupplier.Add(id_nameSupplier);
            }
            return dataCmbSupplier;
        }

        public bool isExistSupplier(int id)
        {
            for (int i = 0; i < listSuppliers.Count; i++)
            {
                if (listSuppliers[i].Id == id)
                {
                    return true;
                }
            }
            return false;
        }

        public List<string> LoadcmbSubCategory()
        {
            List<string> furnitureCategories = new List<string>
            {
                "Armchair",
                "Bed",
                "Bench",
                "Bookshelf",
                "Cabinet",
                "Chair",
                "Coffee Table",
                "Console Table",
                "Cupboard",
                "Desk",
                "Dining Table",
                "Dresser",
                "Nightstand",
                "Recliner",
                "Sideboard",
                "Sofa",
                "Stool",
                "Table",
                "TV Stand",
                "Wardrobe"
            };

            return furnitureCategories;
        }
        public bool AddProductToWarehouse(string name, string supplier, string subcategory, string price, string quantity, string brand)
        {
            Random random = new Random();

            if (name == "")
            {
                MessageBox.Show("Please fill name the fields", "Error");
                return false;
            }
            if (supplier != "")
            {
                string[] idSupplier = supplier.Split('-');
                supplier = idSupplier[0].Trim();
            }
            else
            {
                MessageBox.Show("Please choose supplier", "Error");
                return false;
            }
            if (float.TryParse(price, out float priceValue) == false)
            {
                MessageBox.Show("Please enter valid price", "Error");
                return false;
            }
            while (true)
            {
                int id = random.Next(10000, 99999);
                if (!isExistSupplier(id))
                {
                    connectDB.AddProductToWarehouse(id, name, Int32.Parse(supplier), priceValue, brand, subcategory, Int32.Parse(quantity));
                    return true;
                }
            }

        }
        public void DeleteProductFromWarehouse(string id)
        {
            if (id != "")
            {
                connectDB.DeleteProductToWarehouse(Int32.Parse(id));
                return;
            }
            else
                MessageBox.Show("Please choose product.", "Error");
        }
        public bool EditProductInWarehouse(string id, string name, string supplier, string subcategory, string price, string quantity, string brand)
        {
            if (id != "")
            {
                if (name == "")
                {
                    MessageBox.Show("Please fill name the fields", "Error");
                    return false;
                }
                if (supplier != "")
                {
                    string[] idSupplier = supplier.Split('-');
                    supplier = idSupplier[0].Trim();
                }
                else
                {
                    MessageBox.Show("Please choose supplier", "Error");
                    return false;
                }
                if (float.TryParse(price, out float priceValue) == false)
                {
                    MessageBox.Show("Please enter valid price", "Error");
                    return false;
                }
                connectDB.EditProductToWarehouse(Int32.Parse(id), name, Int32.Parse(supplier), priceValue, subcategory, brand, Int32.Parse(quantity));
                return true;
            }
            else
                MessageBox.Show("Please choose Product", "Error");
            return false;
        }

        public List<Products> DisplayInformation()
        {
            return connectDB.getProductToWarehouse();
        }

        public List<Products> SearchProducts(string key)
        {
            return connectDB.SearchProducts(key);
        }
    }
}
