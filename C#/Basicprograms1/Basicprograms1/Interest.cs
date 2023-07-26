using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basicprograms1
{
    internal class Interest : Bank_details
    {
        public double interestpercentage;
        public Interest( double interestpercentage, int accno,  string accname, double balance,
            double intamt) :base(accno, accname,balance,intamt)
        {
            this.Interestpercentage = interestpercentage;
        }

        public double Interestpercentage { get => interestpercentage; set => interestpercentage = value; }
        public override double CalculateInterest()
        {
            Intamt = Balance * 1 * (Interestpercentage / 100);
            return Intamt;
        }
    }
}
