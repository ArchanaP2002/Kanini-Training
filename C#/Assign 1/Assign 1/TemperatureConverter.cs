using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_1
{
    internal class TemperatureConverter
    {
        public static double CelToFa(double cel)
        {
            return (cel * 9 / 5) + 32;
        }

        public static double FaToCel(double fa)
        {
            return (fa - 32) * 5 / 9;
        }
    }
}
