using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manage_Furniture.Models;
using Manage_Furniture.ADO;
using System.Windows.Forms;
using ClosedXML.Excel;
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

        public bool EditSupplier(string id, string name, string address, string contact, string note)
        {
            if (id != "")
            {
                connectDB.EditSuppliers(Int32.Parse(id), name, contact, address, note);
                return true;
            }
            else
                MessageBox.Show("Please choose supplier", "Error");
            return false;
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
        public void ExportSuppliersToExcel(List<Suppliers> suppliers)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Suppliers");

                // Header
                worksheet.Cell(1, 1).Value = "ID";
                worksheet.Cell(1, 2).Value = "Name";
                worksheet.Cell(1, 3).Value = "Contact";
                worksheet.Cell(1, 4).Value = "Address";
                worksheet.Cell(1, 5).Value = "Note";

                // Dữ liệu
                for (int i = 0; i < suppliers.Count; i++)
                {
                    var s = suppliers[i];
                    worksheet.Cell(i + 2, 1).Value = s.Id;
                    worksheet.Cell(i + 2, 2).Value = s.Name;
                    worksheet.Cell(i + 2, 3).Value = s.Contact;
                    worksheet.Cell(i + 2, 4).Value = s.Address;
                    worksheet.Cell(i + 2, 5).Value = s.Note;
                }

                worksheet.Columns().AdjustToContents();

                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel Workbook (*.xlsx)|*.xlsx",
                    Title = "Save Suppliers Excel File"
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
    }
}
