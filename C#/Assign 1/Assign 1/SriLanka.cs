using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_1
{
    internal class SriLanka
    {
        public SriLanka()
        {
            Double sri, rupe, valu;
            Console.WriteLine("Enter the Amount :");
            sri = Convert.ToDouble(Console.ReadLine());

            valu = 3.90;
            rupe = sri * valu;

            Console.WriteLine("SriLanka = " + rupe);
        }
    }
}
