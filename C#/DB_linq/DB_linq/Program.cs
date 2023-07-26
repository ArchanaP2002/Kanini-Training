using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudClsDataContext stucontext = new StudClsDataContext();
            var res = from st in stucontext.stud_details
                      where st.rno < 8
                      select st;

            foreach (var n in res)
            {
                Console.WriteLine(n.rno + " " + n.name);
            }

            Console.ReadLine();
        }
    }
}
