using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace DBconnect
{
    internal class ChooseCategory 
    {
        public void ChooseCat()
        {

            // Categories of books
            Console.WriteLine("Choose category of your book");
            Console.WriteLine("1 Technology Books");
            Console.WriteLine("2 Motivational Books");
            Console.WriteLine("3 Story books");
            Console.WriteLine("4 Science books");
            Console.WriteLine("5 History books");

        }
    }
}
