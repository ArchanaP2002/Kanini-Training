using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_1
{
    internal class Box
    {
        int n;

        public int N { get => n; set => n = value; }

        public static int CountStackedBoxes(int n)
        {
            // Each level of boxes has an area of n^2
            // The total number of boxes is the sum of squares of 1 to n
            int totalBoxes = 0;

            for (int i = 1; i <= n; i++)
            {
                totalBoxes += i * i;
            }

            return totalBoxes;
        }

    }
}
