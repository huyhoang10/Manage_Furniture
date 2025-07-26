using Manage_Furniture.ADO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manage_Furniture.Models;

namespace Manage_Furniture.Controls
{
    internal class ucHistoryControls
    {
        public List<RecentOrder> GetAllOrders()
        {
            return connectDatabase.GetAllOrders();
        }

        public List<OrderInfo> GetInforOrder(string id)
        {
            var orderInfos = connectDatabase.GetInfoOrders(Int32.Parse(id));
            return orderInfos;
        }
    }
}
