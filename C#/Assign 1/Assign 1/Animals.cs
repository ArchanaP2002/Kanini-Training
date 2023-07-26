using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_1
{
    public class Animals
    {
        
           public int chickens;
        public int cows;
        public int pigs;

            public Animals(int chickens, int cows, int pigs)
            {
                Chickens = chickens;
                Cows = cows;
                Pigs = pigs;
            }

            public int Chickens { get => chickens; set => chickens = value; }
            public int Cows { get => cows; set => cows = value; }
            public int Pigs { get => pigs; set => pigs = value; }

            public int count_legs()
            {
                int result = (this.Chickens * 2) + (this.Cows * 4) + (this.Pigs * 4);
                return result;
            }
        }
    }


