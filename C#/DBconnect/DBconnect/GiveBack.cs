using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBconnect
{
    internal class GiveBack : DB
    {
        SqlCommand command;
        SqlParameter param;

        public SqlConnection Conn { get; private set; }

        // Return the borrowed book
        public void ReturnBook()
        {
            Console.Write("Enter your borrowid: ");
            int bid = Convert.ToInt32(Console.ReadLine());

            SqlCommand command = new SqlCommand("dbo.ReturnBook", Conn);
            command.CommandType = CommandType.StoredProcedure;

            param = command.Parameters.Add("@Borrowid", SqlDbType.Int);
            param.Value = bid;

         
            Console.WriteLine("==================Book returned====================");
            Console.WriteLine();
        }

       
    }
}
