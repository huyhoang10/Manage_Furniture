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
            if(!DesignMode)
            {
                SetAllButton();
                if(CurrentUserSession.Vaitro == "Role_KeToan")
                {
                    MessageBox.Show("Bạn đang đăng nhập", CurrentUserSession.Vaitro);
                    SetAllButton();
                    btnHopDong.FillColor = Color.FromArgb(94, 148, 255);
                    ucHistory1.BringToFront();
                    ucHistory1_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Bạn đang đăng nhập", CurrentUserSession.Vaitro);
                    btnNhanVien.FillColor = Color.FromArgb(94, 148, 255);
                    ucHR2.BringToFront();
                    ucHR1_Load(sender, e);
                }

            }
            MessageBox.Show("Bạn đang đăng nhập", CurrentUserSession.Vaitro);
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
            btnChamCong.FillColor = Color.FromArgb(94, 148, 255);
            ucChamCong1.BringToFront();
            ucCustomer1_Load(sender, e);

        }

        protected void btnOrder_Click(object sender, EventArgs e)
        {
            SetAllButton();
            btnTaiKhoan.FillColor = Color.FromArgb(94, 148, 255 );
            ucTaiKhoan1.BringToFront();
            ucOrder1_Load(sender, e);
        }

        protected virtual void btnWarehouse_Click(object sender, EventArgs e)
        {
            SetAllButton();
            btnBangLuong.FillColor = Color.FromArgb(94, 148, 255);
            ucBangLuong1.BringToFront();
            ucWarehouse1_Load(sender, e);


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
            btnHopDong.FillColor = Color.FromArgb(94, 148, 255);
            ucHopDong1.BringToFront();
            ucHistory1_Load(sender, e);
        }

        private void ucHistory1_Load(object sender, EventArgs e)
        {

        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            SetAllButton();
            btnNhanVien.FillColor = Color.FromArgb(94, 148, 255);
            ucHR2.BringToFront();



        }

        private void btnChucVuvaVaiTro_Click(object sender, EventArgs e)
        {
            try
            {
                SetAllButton();
                btnChucVuvaVaiTro.FillColor = Color.FromArgb(94, 148, 255);
                ucChucVuVaiTro2.BringToFront();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }



        }

        private void ucHR1_Load(object sender, EventArgs e)
        {

        }

        private void ucWarehouse1_Load(object sender, EventArgs e)
        {

        }

        private void ucCustomer1_Load(object sender, EventArgs e)
        {

        }

        private void ucOrder1_Load(object sender, EventArgs e)
        {

        }

        private void btnTrangchu_Click(object sender, EventArgs e)
        {
            SetAllButton();
            btnTrangchu.FillColor = Color.FromArgb(94, 148, 255);
            ucTrangChu1.BringToFront();
            
            
        }
    }
}
