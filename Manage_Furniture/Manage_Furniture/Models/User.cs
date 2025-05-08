using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manage_Furniture.ADO;

namespace Manage_Furniture.Models
{
    public class UserModel
    {
        public string CheckLogin(string username, string password, string role)
        {
            var db = new manager_furnitureDataContext();// connectDatabase.GetContext();

            var user = db.users.FirstOrDefault(u =>
                u.phone == username &&
                u.password == password &&
                u.role == role);

            return user?.role;
        }

    }
}
