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
using Manage_Furniture.Models;

namespace Manage_Furniture.Forms
{
   
    public partial class FLogin : Form
    {
        public static EmployeeModel  userLogin = new EmployeeModel();
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

            string role = rbtn_admin.Checked ? "Admin" : "Employee";

            if (!string.IsNullOrEmpty(role))
            {
                string loginRole = uclogin_control.Login(username, password, role);

                if (loginRole != null)
                {
                    if (loginRole == "Employee")
                    {
                        if (!uclogin_control.CheckActive(username))
                        //    MessageBox.Show("Login successful!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //else
                        {
                            MessageBox.Show("Your account is inactive. Please contact the administrator.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    
                    if (loginRole == "Admin")
                    {
                        txt_username.Text = "";
                        txt_passwd.Text = "";
                        userLogin.Name = "Admin";
                        //FManager fManager = new FManager();
                        //fManager.ShowDialog();
                        this.Hide(); // Ẩn FormA

                        var fManager = new FManager();
                        fManager.Show();

                        fManager.FormClosed += (s, args) =>
                        {
                            // Khi formB đóng thì thoát chương trình
                            Application.Exit();
                        };
                    }
                    else if (loginRole == "Employee")
                    {
                        txt_username.Text = "";
                        txt_passwd.Text = "";
                        userLogin = uclogin_control.GetEmployee(username);
                        //employeeModel = uclogin_control.GetEmployee(username);
                        //FEmployee fEmployee = new FEmployee();
                        //fEmployee.ShowInTaskbar = false;
                        //fEmployee.ShowDialog();
                        this.Hide(); // Ẩn FormA

                        var fEmployee = new FEmployee();
                        fEmployee.Show();

                        fEmployee.FormClosed += (s, args) =>
                        {
                            // Khi formB đóng thì thoát chương trình
                            Application.Exit();
                        };
                    }
                    
                    //this.Hide();
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
