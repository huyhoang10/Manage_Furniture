using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Contexts;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using System.Xml.Linq;
using Manage_Furniture.Models;

namespace Manage_Furniture.ADO
{
    internal class connectDatabase
    {
        public static manager_furnitureDataContext db = new manager_furnitureDataContext();

        public List<Suppliers> GetSuppliers()
        {
            List<Suppliers> listSuppliers = new List<Suppliers>();
            var suppliers = db.suppliers.ToList();
            for (int i = 0; i < suppliers.Count; i++)
            {
                Suppliers supplier = new Suppliers();
                supplier.Id = suppliers[i].id;
                supplier.Name = suppliers[i].name;
                supplier.Contact = suppliers[i].contact;
                supplier.Address = suppliers[i].address;
                supplier.Note = suppliers[i].note;
                listSuppliers.Add(supplier);
            }
            return listSuppliers;
        }
        public void AddSuppliers(int id, string name, string contact, string address, string note)
        {
            supplier newSupplier = new supplier();
            newSupplier.id = id;
            newSupplier.name = name;
            newSupplier.contact = contact;
            newSupplier.address = address;
            newSupplier.note = note;
            db.suppliers.InsertOnSubmit(newSupplier);
            db.SubmitChanges();
        }

        public void EditSuppliers(int id, string name, string contact, string address, string note)
        {
            var supplier = db.suppliers.Where(x => x.id == id).FirstOrDefault();
            {
                if (supplier != null)
                {
                    supplier.name = name;
                    supplier.contact = contact;
                    supplier.address = address;
                    supplier.note = note;
                    db.SubmitChanges();
                }
            }
        }

        
        public void DeleteSuppliers(int id)
        {
            var supplier = db.suppliers.Where(x => x.id == id).FirstOrDefault();
            {
                if (supplier != null)
                {
                    db.suppliers.DeleteOnSubmit(supplier);
                    db.SubmitChanges();
                }
            }
        }

        public List<Suppliers> SearchSuppliers(string key)
        {
            var suppliers = db.suppliers.Where(x => x.name.Contains(key)).ToList();
            List<Suppliers> listSuppliers = new List<Suppliers>();
            for (int i = 0; i < suppliers.Count; i++)
            {
                Suppliers supplier = new Suppliers();
                supplier.Id = suppliers[i].id;
                supplier.Name = suppliers[i].name;
                supplier.Contact = suppliers[i].contact;
                supplier.Address = suppliers[i].address;
                supplier.Note = suppliers[i].note;
                listSuppliers.Add(supplier);
            }
            return listSuppliers;
        }

        public List<Products> GetProducts()
        {
            List<Products> listProducts = new List<Products>();
            var products = db.products.ToList();
            for (int i = 0; i < products.Count; i++)
            {
                Products product = new Products();
                product.Id = products[i].id;
                product.Name = products[i].name;
                product.Supplier = products[i].supplier.ToString();
                product.Brand = products[i].brand;
                product.Subcategory = products[i].subcategory;
                product.Price = (float)products[i].price;
                listProducts.Add(product);
            }
            return listProducts;
        }

        

        public List<Products> SearchProducts(string key)
        {
            var products = db.products.Where(x => x.name.Contains(key)).ToList();
            List<Products> listProducts = new List<Products>();
            for (int i = 0; i < products.Count; i++)
            {
                Products product = new Products();
                product.Id = products[i].id;
                product.Name = products[i].name;
                product.Supplier = products[i].supplier.ToString();
                product.Brand = products[i].brand;
                product.Subcategory = products[i].subcategory;
                product.Price = (float)products[i].price;
                listProducts.Add(product);
            }
            return listProducts;
        }

        
        public void DeleteProducts(int id)
        {
            var product = db.products.Where(x => x.id == id).FirstOrDefault();
            {
                if (product != null)
                {
                    db.products.DeleteOnSubmit(product);
                    db.SubmitChanges();
                }
            }
        }

        //public void AddProducts(int id, string name, int idsupplier, float price, string brand, string subcategory, int quantity)
        //{
        //    product newProduct = new product();
        //    newProduct.id = id;
        //    newProduct.name = name;
        //    newProduct.subcategory = subcategory;
        //    newProduct.supplier = idsupplier;
        //    newProduct.brand = brand;
        //    newProduct.price = (decimal)price;
        //    db.products.InsertOnSubmit(newProduct);
        //    //warehouse addProduct = new warehouse();
        //    //addProduct.id_product = id;
        //    //addProduct.quantity = quantity;
        //    //db.warehouses.InsertOnSubmit(addProduct);
        //    db.SubmitChanges();
        //}
        public void AddProductToWarehouse(int id, string name, int idsupplier, float price, string brand, string subcategory, int quantity)
        {
            product newProduct = new product();
            newProduct.id = id;
            newProduct.name = name;
            newProduct.subcategory = subcategory;
            newProduct.supplier = idsupplier;
            newProduct.brand = brand;
            newProduct.price = (decimal)price;
            db.products.InsertOnSubmit(newProduct);
            warehouse newWarehouse = new warehouse();
            newWarehouse.id_product = id;
            newWarehouse.quantity = quantity;
            db.warehouses.InsertOnSubmit(newWarehouse);
            db.SubmitChanges();
        }

        public void EditProductToWarehouse(int idproduct, string name_product, int id_supplier, float price,string subcategory,string brand,int quantity)
        {
            var warehouse = db.warehouses.Where(x => x.id_product == idproduct).FirstOrDefault();
            {
                if (warehouse != null)
                {
                    warehouse.quantity = quantity;
                    db.SubmitChanges();
                }
            }
            var product = db.products.Where(x => x.id == idproduct).FirstOrDefault();
            {
                if (product != null)
                {
                    product.name = name_product;
                    product.supplier = id_supplier;
                    product.brand = brand;
                    product.subcategory = subcategory;
                    product.price = (decimal)price;
                    db.SubmitChanges();
                }
            }
        }

        public void DeleteProductToWarehouse(int idproduct)
        {
            var warehouse = db.warehouses.Where(x => x.id_product == idproduct).FirstOrDefault();
            {
                if (warehouse != null)
                {
                    db.warehouses.DeleteOnSubmit(warehouse);
                    db.SubmitChanges();
                }
            }
        }

        public List<Products> getProductToWarehouse()
        {
            List<Products> listProducts = new List<Products>();
            var result = from p in db.products
                         join w in db.warehouses
                         on p.id equals w.id_product
                         select new
                         {   p.id,
                             p.name,
                             p.supplier,
                             p.price,
                             p.subcategory,
                             p.brand,
                             w.quantity
                         };
            foreach(var item in result)
            {
                Products product = new Products();
                product.Id = item.id;
                product.Name = item.name;
                product.Brand = item.brand;
                product.Subcategory = item.subcategory;
                product.Price = (float)item.price;
                product.Quantity = (int)item.quantity;
                int IdSupplier = (int)item.supplier;
                var supllier = db.suppliers.Where(x => x.id == IdSupplier).FirstOrDefault();
                product.Supplier = IdSupplier.ToString() + " - " + supllier.name;
                listProducts.Add(product);
            }
            return listProducts;
        }
    }
}