using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class EnumDemo
    {
        enum Colors
        {
            Red,
            Green,
            Yellow,
            Blue
        }

       //public static void Main(string[] args)
       // {
       //     Colors
       // }
       public void Display()
        {
            Colors Col1 = Colors.Red;
            Colors Col2 = Colors.Green;
            Colors Col3 = Colors.Yellow;
            Colors Col4 = Colors.Blue;

            Console.WriteLine(Col1);
        }
    }
}
