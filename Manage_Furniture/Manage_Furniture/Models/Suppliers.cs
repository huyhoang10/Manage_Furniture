using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Furniture.Models
{
    internal class Suppliers
    {
        private int id;
        private string name;
        private string contact;
        private string address;
        private string note;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Contact
        {
            get { return contact; }
            set { contact = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Note
        {
            get { return note; }
            set { note = value; }
        }

        public int RandomID() {
            Random random = new Random();
            int randomNumber = random.Next(10000, 99999);
            return randomNumber;
        }
    }
}
