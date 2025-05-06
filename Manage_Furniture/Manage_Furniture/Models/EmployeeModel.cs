using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Furniture.Models
{
    public class EmployeeModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Sex { get; set; }
        public string Address { get; set; }
        public string Salary { get; set; }
        public string Status { get; set; }

        public EmployeeModel(string id, string name, string phone, string sex, string address, string salary, string status)
        {
            Id = id;
            Name = name;
            Phone = phone;
            Sex = sex;
            Address = address;
            Salary = salary;
            Status = status;
        }
    }

}
