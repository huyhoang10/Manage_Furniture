using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Furniture.ADO
{
    internal class connectDatabase
    {
        private static manager_furnitureDataContext db;

        public static manager_furnitureDataContext GetContext()
        {
            if (db == null)
                db = new manager_furnitureDataContext();
            return db;
        }
    }
}
