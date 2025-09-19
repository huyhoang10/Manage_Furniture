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
    public partial class FAdmin : Form
    {
        public FAdmin()
        {
            InitializeComponent();
        }


        protected void FEmployee_Load(object sender, EventArgs e)
        {
          
            SetAllButton();
            btnTaiKhoan.FillColor = Color.FromArgb(142, 209, 194);
            ucOrder1.BringToFront();
            //btnUser.Text = "Hi! "+FLogin.userLogin.Name;
        }

        protected virtual void SetAllButton()
        {
            btnNhanVien.FillColor = Color.White;
            btnTaiKhoan.FillColor = Color.White;
            btnChamCong.FillColor = Color.White;
            btnBangLuong.FillColor = Color.White;
            btnChucVuvaVaiTro.FillColor = Color.White;
           
            btnHopDong.FillColor = Color.White;
        }

        protected void btnCustomer_Click(object sender, EventArgs e)
        {
            SetAllButton();
            btnChamCong.FillColor = Color.FromArgb(142, 209, 194);
            ucCustomer1.BringToFront();
            
        }

        protected void btnOrder_Click(object sender, EventArgs e)
        {
            SetAllButton();
            btnTaiKhoan.FillColor = Color.FromArgb(142, 209, 194);
            ucOverview1.BringToFront();
        }

        protected virtual void btnWarehouse_Click(object sender, EventArgs e)
        {
            SetAllButton();
            btnBangLuong.FillColor = Color.FromArgb(142, 209, 194);
            ucWarehouse1.BringToFront();
          
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //FLogin.userLogin.Name = "";
                //FLogin.userLogin.Phone = "";
                FLogin loginForm = new FLogin();
                loginForm.Show();
                this.Close();
            }
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            SetAllButton();
            btnHopDong.FillColor = Color.FromArgb(197, 166, 158);
            ucHistory1.BringToFront();
            ucHistory1_Load(sender, e);
        }

        private void ucHistory1_Load(object sender, EventArgs e)
        {

        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            SetAllButton();
            btnNhanVien.FillColor = Color.FromArgb(142, 209, 194);
            ucHR1.BringToFront();
            ucHistory1_Load(sender,e);



        }

        private void btnChucVuvaVaiTro_Click(object sender, EventArgs e)
        {
            SetAllButton();
            btnChucVuvaVaiTro.FillColor = Color.FromArgb(142, 209, 194);
            ucSuppliercs1
                .BringToFront();
           

        }
    }
}
