using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_1
{
    internal class Drinks
    {
        private int age;
        private bool isBreakTime;

        public int Age { get => age; set => age = value; }
        public bool IsBreakTime { get => isBreakTime; set => isBreakTime = value; }

        public static bool ShouldServeDrinks(int age, bool isBreakTime)
        {
            if (age >= 18 && !isBreakTime)
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
