using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_1
{
    class SavingsAccount : Customer
    {
        private int accNo;
        private decimal amount;
        private string branchName;
        private string ifscCode;

        public SavingsAccount(string name, string address, string phone, int accNo, decimal amount, string branchName, string ifscCode)
            : base(name, address, phone)
        {
            this.accNo = accNo;
            this.amount = amount;
            this.branchName = branchName;
            this.ifscCode = ifscCode;
        }

        public new void Display()
        {
            base.Display();
            Console.WriteLine("Savings Account Number: " + accNo);
            Console.WriteLine("Amount: " + amount);
            Console.WriteLine("Branch Name: " + branchName);
            Console.WriteLine("IFSC Code: " + ifscCode);
        }
    }

}
