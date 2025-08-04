using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manage_Furniture.Controls;

namespace Manage_Furniture.Forms
{
    public partial class FProduct : Form
    {
        public FProduct()
        {
            InitializeComponent();
        }

        FProductControl productControl = new FProductControl();

        private void btnAddPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif",
                Title = "Select a Picture"
            };
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    picProduct.Image = Image.FromFile(openFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            byte[] imageBytes = productControl.ConvertImageToByteArray(picProduct.Image);
            productControl.AddProductToWarehouse(
                txtNameProduct.Text,
                txtCategory.Text,
                txtPrice.Text,
                txtQuantity.Text,
                txtBrand.Text,
                txtColor.Text,
                txtMaterial.Text,
                imageBytes
            );
        }
    }
}
