//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Basicprograms1
{
    internal class Addition
    {
        private int num1, num2;
        //private double v;

        //public Addition(double v)
        //{
        //    this.v = v;
        //}

        private Addition(int num1,int num2)
        {
        
            this.Num1 = num1;
            this.Num2 = num2;
        }
         
        public int Num1 { get => num1; set => num1 = value; }
        public int Num2 { get => num2; set => num2 = value; }

        //internal int Add()
        //{
        //    throw new NotImplementedException();
        //}

        internal class Add
        {
            internal int add(int num1,int num2)
            {
                int ans = num1 + num2;
                return ans;
            }
        }
       
    }
}
