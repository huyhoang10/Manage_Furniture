using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manage_Furniture.Models;
using Manage_Furniture.ADO;
using System.Windows.Forms;
namespace Manage_Furniture.Controls
{
    internal class ucSuppliersControls
    {
        connectDatabase connectDB = new connectDatabase();
        public List<Suppliers> listSuppliers = new List<Suppliers>();


        public Suppliers suppliers = new Suppliers();

        public void LoadSuppliers()
        {
            listSuppliers = connectDB.GetSuppliers();
        }

        public List<Suppliers> DisplaySuppliers()
        {
            LoadSuppliers();
            return listSuppliers;
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
        public bool AddSupplier(string name, string address, string contact, string note)
        {
            if (name == "")
            {
                MessageBox.Show("Please fill name the fields", "Error");
                return false;
            }
            
            while (true)
            {
                int id = suppliers.RandomID();
                if (!isExistSupplier(id))
                {
                    connectDB.AddSuppliers(id, name, contact, address, note);
                    return true;
                }
            }

        }

        public void EditSupplier(string id, string name, string address, string contact, string note)
        {
            if (id != "")
            {
                connectDB.EditSuppliers(Int32.Parse(id), name, contact, address, note);
                return;
            }
            else
                MessageBox.Show("Please choose supplier", "Error");
        }

        public void DeleteSupplier(string id)
        {
            if (id != "")
            {
                connectDB.DeleteSuppliers(Int32.Parse(id));
                return;
            }
            else
                MessageBox.Show("Please choose supplier", "Error");
        }

        public List<Suppliers> SearchSupplier(string key)
        {
            return connectDB.SearchSuppliers(key);
        }
    }
}
