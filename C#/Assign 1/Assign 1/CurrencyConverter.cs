using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_1
{
    public class CurrencyConverter
    {
        public double Convert(string fromCurrency, string toCurrency, double amount)
        {
            double convertedAmount = 0.0;
            switch (fromCurrency.ToLower())
            {
                case "usd":
                    switch (toCurrency.ToLower())

                    {
                        case "eur":
                            convertedAmount = amount * 0.85;
                            break;
                        case "gbp":
                            convertedAmount = amount * 0.72;
                            break;
                        case "jpy":
                            convertedAmount = amount * 110.13;
                            break;
                        case "cad":
                            convertedAmount = amount * 1.25;
                            break;
                        case "inr":
                            convertedAmount = amount * 74.99;
                            break;
                        default:
                            Console.WriteLine("Invalid currency");
                            break;
                    }
                    break;
                // Add cases for other currencies here
                default:
                    Console.WriteLine("Invalid currency");
                    break;
            }
            return convertedAmount;
        }
    }

}
