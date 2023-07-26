using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_1
{


    class Customer
    {
        private string name;
        private string address;
        private string phone;

        public Customer(string name, string address, string phone)
        {
            Name = name;
            Address = address;
            Phone = phone;
        }

        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Phone { get => phone; set => phone = value; }

        public void Display()
        {
            Console.WriteLine("Customer Name: " + Name);
            Console.WriteLine("Customer Address: " + Address);
            Console.WriteLine("Customer Phone: " + Phone);
        }
    }



}
        
