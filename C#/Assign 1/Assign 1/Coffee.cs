using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_1
{
    internal class Coffee
    {
        private int cups;

        public int Cups { get => cups; set => cups = value; }

        public static int TotalCups(int n)
        {
            // Calculate the number of sets of 6 cups
            int setsOfSix = n / 6;

            // Calculate the number of free cups
            int freeCups = setsOfSix;

            // Calculate the total number of cups
            int totalCups = n + freeCups;

            return totalCups;
        }

    }
}
