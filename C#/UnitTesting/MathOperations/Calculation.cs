using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    public class Calculation
    {
        private int n1 = 0;
        private int n2=0;

 

        public Calculation(int n1, int n2 ) 
        {
            this.N1 = n1;
            this.N2 = n2;
         
        }

        public int N1 { get => n1; set => n1 = value; }
        public int N2 { get => n2; set => n2 = value; }
 
        public int Add()
        {
            return N1+N2; 
        }
        public int Sub()
        {
            return N1 - N2;
        }
        public int Mul()
        {
            return N1 * N2;
        }
    }
}
