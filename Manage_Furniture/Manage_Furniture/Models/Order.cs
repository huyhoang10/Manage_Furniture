using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Manage_Furniture.ADO;
using Manage_Furniture.Controls;
using Manage_Furniture.Forms;

namespace Manage_Furniture.Models
{
    internal class Order
    {
        public int Id { get; set; }   
        public int Id_customer { get; set; } 
        public int Id_product { get; set; } 
        public int Quantity { get; set; }  
        public DateTime Date_purchase { get; set; }
        public decimal Money { get; set; }   
        public string Note { get; set; }

    }
}
