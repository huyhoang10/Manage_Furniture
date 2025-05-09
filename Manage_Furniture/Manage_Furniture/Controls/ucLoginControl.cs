using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manage_Furniture.ADO;
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

        public bool CheckActive(string phone)
        {
            var db = new manager_furnitureDataContext();
            var user = db.employees.FirstOrDefault(u => u.phone == phone);
            if (user != null)
            {
                return user.status == "Active";
            }
            return false;
        }
    }
}
