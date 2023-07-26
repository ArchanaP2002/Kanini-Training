using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_1
{
    internal class Person
    {
        private int age;

        public Person()
        {
        }

        public Person(int age)
        {
            this.age = age;
        }

        public int Age{ get => age; set => age = value; }



        public void CheckEligibility(int age)
        {
            if (age < 18 || age > 120)
            {
                throw new AgeNotEligibleException("Age not eligible to vote");
            }
            else
            {
                Console.WriteLine("Age eligible to vote");
            }
        }
    }
}
