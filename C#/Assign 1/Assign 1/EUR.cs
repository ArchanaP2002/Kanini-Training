using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_1
{
    internal class EUR
    {
        public EUR() 
        {
            Double Euro, rupe, valu;
            Console.WriteLine("Enter the Euro Amount :");
            Euro = Convert.ToDouble(Console.ReadLine());

            valu = 0.011;
            rupe = Euro * valu;
         
            Console.WriteLine("Euro= " + rupe);
        }
    }
}
