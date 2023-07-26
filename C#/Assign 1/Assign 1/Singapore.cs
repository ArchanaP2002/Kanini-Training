using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_1
{
    internal class Singapore
    {
        public Singapore()
        {
            Double sin, rupe, valu;
            Console.WriteLine("Enter the  Amount :");
            sin = Convert.ToDouble(Console.ReadLine());

            valu = 0.016;
            rupe = sin * valu;

            Console.WriteLine("Singapore = " + rupe);
        }
    }
}
