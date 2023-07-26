using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class LE
    {
        public void evennum()
        {
            List<int> num= new List<int>()
            {
                10,4,5,6,7,8,9,10,11,12,13,14,15
            };
            List<int> evennum = num.FindAll(n => ((n % 2) != 0));
            //num.Select();



            foreach(int n in evennum)
            {
                Console.WriteLine(n);
            }


        }

        
    }
}
