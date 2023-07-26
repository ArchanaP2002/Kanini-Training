using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_1
{
    internal class Pakistan
    {
        public Pakistan()
        {
            Double pak, rupe, valu;
            Console.WriteLine("Enter the  Amount :");
            pak = Convert.ToDouble
                (Console.ReadLine());

            valu = 3.51;
            rupe = pak* valu;

            Console.WriteLine("Pakistan = " + rupe);
        }
    }
}
