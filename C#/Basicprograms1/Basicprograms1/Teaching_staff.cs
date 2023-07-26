using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basicprograms1
{
    internal class Teaching_staff:College
    {
        private int eid;
        private string name, dept, favsub;
        private double salary;

        public Teaching_staff(string collegename, string address,
            int pincode,int eid, string name,string dept, string favsub, double salary)
            :base(collegename ,address, pincode)
        {
            this.Eid = eid;
            this.Name = name;
            this.Dept = dept;
            this.Favsub = favsub;
            this.Salary = salary;
        }

        public int Eid { get => eid; set => eid = value; }
        public string Name { get => name; set => name = value; }
        public string Dept { get => dept; set => dept = value; }
        public string Favsub { get => favsub; set => favsub = value; }
        public double Salary { get => salary; set => salary = value; }

        public double Calculatesalary()
        {
            double da = 0.4;
            double hra = 0.2;
            double allowances =(Salary*da)+(Salary*hra);
            double pf = 0.25;
            double deductions = Salary*pf;
            double netsalary = Salary + allowances - deductions;
            return netsalary;
        
        }
    }
}
