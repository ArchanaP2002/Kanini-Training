using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.net
{
    internal class DBdiscnt
    {
        SqlConnection conn; 
        SqlDataAdapter adapter;
        DataSet ds;
        public void OpenConn(string cnnstr)
        {
            conn = new
        SqlConnection("data source=LAPTOP-PKS4NBKU\\SQLEXPRESS; " +
        "Initial Catalog =student;" +
        "integrated security=SSPI");
            try
            {
                conn.Open();
                Console.WriteLine("open");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                // Console.WriteLine(ex.InnerException);
                Console.WriteLine("Connection not established");
            }


        }

        internal void OpenConn()
        {
            throw new NotImplementedException();
        }
    }
}
