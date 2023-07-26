using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_1
{
    internal class ElectricityBill
    {


        private int unitsConsumed;
        private double billAmount;

        public void EnterReading()
        {
            Console.Write("Enter the  reading: ");

            unitsConsumed = Convert.ToInt32(Console.ReadLine());
        }

        public void CalculateBill()
        {
            if (unitsConsumed <= 100)
            {
                billAmount = unitsConsumed * 1.5;
            }
            else if (unitsConsumed > 100 && unitsConsumed <= 200)
            {
                billAmount = (100 * 1.5) + ((unitsConsumed - 100) * 2.5);
            }
            else if (unitsConsumed > 200 && unitsConsumed <= 500)
            {
                billAmount = (100 * 1.5) + (100 * 2.5) + ((unitsConsumed - 200) * 4);
            }
            else
            {
                billAmount = (100 * 1.5) + (100 * 2.5) + (300 * 4) + ((unitsConsumed - 500) * 6);
            }


            Console.WriteLine($"Bill amount: {billAmount}");

        }

    }
}
