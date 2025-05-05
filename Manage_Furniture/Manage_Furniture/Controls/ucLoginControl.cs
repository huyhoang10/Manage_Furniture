using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manage_Furniture.Models;

namespace Manage_Furniture.Controls
{
    internal class ucLoginControl
    {
        private UserModel userModel = new UserModel();

        public string Login(string username, string password, string role)
        {
            return userModel.CheckLogin(username, password, role);
        }
    }
}
