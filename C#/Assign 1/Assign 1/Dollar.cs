﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_1
{
    internal class Dollar
    {
        public Dollar() 
        {
            Double dollar, rupee, val;
            Console.WriteLine("Enter the USD Amount :");
            dollar = Convert.ToDouble(Console.ReadLine());  
            val = 1.18;
            rupee = dollar * val;
           // Console.WriteLine("{0} Dollar Equals {1} Rupees", dollar, rupee);
            Console.WriteLine("USD = "+ rupee);
        }
    }
}
