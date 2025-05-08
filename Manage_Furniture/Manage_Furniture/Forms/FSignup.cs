using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manage_Furniture.Forms
{
    public partial class FSignup : Form
    {
        public FSignup()
        {
            InitializeComponent();
        }

        private void FSignup_Load(object sender, EventArgs e)
        {
            txt_username.Focus();
        }

        private void lbl_login_Click(object sender, EventArgs e)
        {
            
        }

        private void pshow_Click(object sender, EventArgs e)
        {
            if (txt_passwd.PasswordChar == '\0')
            {
                phide.BringToFront();
                txt_passwd.PasswordChar = '*';
            }
        }

        private void phide_Click(object sender, EventArgs e)
        {
            if (txt_passwd.PasswordChar == '*')
            {
                pshow.BringToFront();
                txt_passwd.PasswordChar = '\0';
            }
        }
    }
}
