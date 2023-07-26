using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
      
namespace BasicPrograms
{
    internal class ExceptionHandling
    {
        int n1, n2, sum;

        public int N1 { get => n1; set => n1 = value; }
        public int N2 { get => n2; set => n2 = value; }
        public int Sum { get => sum; set => sum = value; }

        public ExceptionHandling(int n1, int n2, int sum)
        {
            this.N1 = n1;
            this.N2 = n2;
            this.Sum = sum;
        }
        public int add()
        {
           this.Sum= this.N1+this.N2;
            return this.sum;


        }
        public int mul()
        {
            this.Sum = this.N1 * this.N2;
            return this.sum;

        }
        public int div()
        {
            try
            {
                this.Sum = this.N1 / this.N2;
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Dont give 0" + "in the dinomination");
            } 
            finally 
            {
                Console.WriteLine("Over");
            }
            return this.Sum;         

        }
        public void Check(int val)
        {
            if (val < 0)
            {
                throw new ArgumentException(
                    "Dont pass 0");
            }
            else if (val < 18)
            {
                throw new ArithmeticException("Val should be >18");
            }
            else
            {
                Console.WriteLine("Ok");
            }
        }


    }
}
