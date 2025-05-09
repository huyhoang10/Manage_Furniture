using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manage_Furniture.ADO;
using Manage_Furniture.Controls;

namespace Manage_Furniture.Forms
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }

        private void FLogin_Load(object sender, EventArgs e)
        {
            txt_username.Focus();
        }

        private void phide_Click(object sender, EventArgs e)
        {
            if (txt_passwd.PasswordChar == '*')
            {
                pshow.BringToFront();
                txt_passwd.PasswordChar = '\0';
            }

        }
        private void pshow_Click(object sender, EventArgs e)
        {
            if (txt_passwd.PasswordChar == '\0')
            {
                phide.BringToFront();
                txt_passwd.PasswordChar = '*';
            }   
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            var uclogin_control = new ucLoginControl();

            string username = txt_username.Text.Trim();
            string password = txt_passwd.Text;

            string role = rbtn_admin.Checked ? "admin" : "employee";

            if (!string.IsNullOrEmpty(role))
            {
                string loginRole = uclogin_control.Login(username, password, role);

                if (loginRole != null)
                {
                    if (loginRole == "employee")
                    {
                        if (uclogin_control.CheckActive(username))
                            MessageBox.Show("Login successful!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                        {
                            MessageBox.Show("Your account is inactive. Please contact the administrator.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    if (loginRole == "admin")
                    {
                        FManager fManager = new FManager();
                        fManager.ShowDialog();
                    }
                    else if (loginRole == "employee")
                    {
                        FEmployee fEmployee = new FEmployee();
                        fEmployee.ShowDialog();
                    }

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a role (Admin or Employee).", "Role Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
