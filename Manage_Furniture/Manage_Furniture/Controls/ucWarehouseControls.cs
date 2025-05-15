using Manage_Furniture.ADO;
using Manage_Furniture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;
using System.Windows.Forms;
using System.Data;


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

        public List<Products> FilterProduct(string key)
        {
            if(key == "All")
            {
                return connectDB.getProductToWarehouse();
            }
            else
            {
                return connectDB.FilterSubcategory(key);
            }
        }

        public void ExportProductsToExcel(List<Products> products)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Warehouse");

                // Tiêu đề cột
                worksheet.Cell(1, 1).Value = "ID";
                worksheet.Cell(1, 2).Value = "Name";
                worksheet.Cell(1, 3).Value = "Supplier ID";
                worksheet.Cell(1, 4).Value = "Price";
                worksheet.Cell(1, 5).Value = "Brand";
                worksheet.Cell(1, 6).Value = "Category";
                worksheet.Cell(1, 7).Value = "Quantity";

                // Dữ liệu
                for (int i = 0; i < products.Count; i++)
                {
                    var p = products[i];
                    worksheet.Cell(i + 2, 1).Value = p.Id;
                    worksheet.Cell(i + 2, 2).Value = p.Name;
                    worksheet.Cell(i + 2, 3).Value = p.Supplier;
                    worksheet.Cell(i + 2, 4).Value = p.Price;
                    worksheet.Cell(i + 2, 5).Value = p.Brand;
                    worksheet.Cell(i + 2, 6).Value = p.Subcategory;
                    worksheet.Cell(i + 2, 7).Value = p.Quantity;
                }

                worksheet.Columns().AdjustToContents();

                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel Workbook (*.xlsx)|*.xlsx",
                    Title = "Save Warehouse Product List"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        workbook.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("Export successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error while saving Excel: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        public DataTable CreateProductsDataTable(List<Products> products)
        {
            // Tạo DataTable và định nghĩa các cột
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("Product", typeof(string));
            dt.Columns.Add("Supplier", typeof(int));  // Hoặc có thể sử dụng string nếu muốn lấy tên nhà cung cấp
            dt.Columns.Add("Price", typeof(decimal));
            dt.Columns.Add("Brand", typeof(string));
            dt.Columns.Add("Subcategory", typeof(string));
            dt.Columns.Add("Quantity", typeof(int));

            // Thêm dữ liệu vào DataTable từ danh sách products
            foreach (var product in products)
            {
                DataRow row = dt.NewRow();
                row["ID"] = product.Id.ToString();
                row["Product"] = product.Name;
                string[] parts = product.Supplier.Split('-');
                if (parts.Length > 0 && int.TryParse(parts[0].Trim(), out int supplierId))
                {
                    row["Supplier"] = supplierId;
                }
                else
                {
                    row["Supplier"] = DBNull.Value;  // hoặc xử lý lỗi phù hợp
                } // Nếu cần lấy tên nhà cung cấp thay vì ID, bạn sẽ cần truy vấn thêm từ bảng Supplier
                row["Price"] = product.Price;
                row["Brand"] = product.Brand;
                row["Subcategory"] = product.Subcategory;
                row["Quantity"] = product.Quantity;

                dt.Rows.Add(row);
            }

            return dt;
        }
    }
}
