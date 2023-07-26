using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_1
{
    internal class Game
    {
        private double prob;
        private int prize;
        private int pay;

        public double Prob { get => prob; set => prob = value; }
        public int Prize { get => prize; set => prize = value; }
        public int Pay { get => pay; set => pay = value; }


        public static bool CalculateProfitable(double prob, double prize, double pay)
        {
            double expectedValue = prob * prize;

            if (expectedValue > pay)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
