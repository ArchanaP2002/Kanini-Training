using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basicprograms1
{
    internal class Admin_staff: College
    {
        private int eid;
        private string name;
        private double salary;
        public Admin_staff( string collegename,string address, int pincode, int eid, string name, double salary)
            :base( collegename , address , pincode)
        {
            this.Eid = eid;
            this.Name = name;
            this.Salary = salary;
        }

        public int Eid { get => eid; set => eid = value; }
        public string Name { get => name; set => name = value; }
        public double Salary { get => salary; set => salary = value; }

        public double Calculatesalary()
        {
            double da = 0.3;
            double hra = 0.15;
            double allowances = (salary * da) + (salary * hra);
            double pf = 0.2;
            double deductions = salary * pf;
            double netsalary = salary + allowances - deductions;
            return netsalary;

        }
    }
    
}
