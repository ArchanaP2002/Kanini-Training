using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_1
{
    internal class Arrange
    {
        public static int SwitchArrangements(int n)
        {
            // The number of possible arrangements of n switches is 2^n
            int arrangements = (int)Math.Pow(2, n);

            return arrangements;
        }

    }
}
