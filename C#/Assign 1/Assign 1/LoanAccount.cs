using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_1
{
    class LoanAccount : Customer
    {
        private int loanAccNo;
        private decimal loanAmount;
        private int loanTenureInYrs;

        public LoanAccount(string name, string address, string phone, int loanAccNo, decimal loanAmount, int loanTenureInYrs)
            : base(name, address, phone)
        {
            this.loanAccNo = loanAccNo;
            this.loanAmount = loanAmount;
            this.loanTenureInYrs = loanTenureInYrs;
        }

        public new void Display()
        {
            base.Display();
            Console.WriteLine("Loan Account Number: " + loanAccNo);
            Console.WriteLine("Loan Amount: " + loanAmount);
            Console.WriteLine("Loan Tenure in Years: " + loanTenureInYrs);
        }
    }

}
