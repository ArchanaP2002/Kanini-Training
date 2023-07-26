using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basicprograms1
{
    internal class Static_Demo
    {
        static int cno = 123, pre = 10000, curr = 12000;
        static double amt;
      //static cal();

        public static int Cno { get => cno; set => cno = value; }
        public static int Pre { get => pre; set => pre = value; }
        public static int Curr { get => curr; set => curr = value; }
        
        public static double Amt2 { get => amt; set => amt = value; }
        public static  int Amt { get; private set; }

        public static void cal()
        {
            Amt = (Curr - Pre) * 3;
        }
    }
}
