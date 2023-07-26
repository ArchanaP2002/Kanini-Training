using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ado.net
{
    internal class DB
    {
        SqlConnection conn;
        public void OpenConn(string cnnstr)
        {
           conn = new
       SqlConnection("data source=LAPTOP-PKS4NBKU\\SQLEXPRESS; " +
       "database=student;" +
       "integrated security=SSPI");
            try
            {
                conn.Open ();
                Console.WriteLine("open");
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
               // Console.WriteLine(ex.InnerException);
               Console.WriteLine("Connection not established");
            }
           
          
        }
        public void CreateTable()
        {
         

            SqlCommand cmd = new SqlCommand("create" +
                " table stud_details(rno int, " +
                "name nvarchar(20))", conn);
            cmd.ExecuteNonQuery();
            Console.WriteLine("Table created");
            
        }

        public void CloseCnn()
        {
            conn.Close();
        }
        public void InsertTable() 
        {
            SqlCommand cmd = new SqlCommand("insert" +
                " into stud_details values( 12,'CCC')", conn);
            cmd.ExecuteNonQuery();
            Console.WriteLine("Row inserted");
        }

        public void UpdateTable()
        {
            SqlCommand cmd = new SqlCommand("update" +
              "  stud_details set rno=101 where name='AAA'", conn);
            cmd.ExecuteNonQuery();
            Console.WriteLine("Row updated");
        }

        public void DeleteTable()
        {
            SqlCommand cmd = new SqlCommand("delete from stud_details ",conn);
            cmd.ExecuteNonQuery();
            Console.WriteLine("Row deleted");
        }

        public void ReadTable()
        {

            SqlCommand cmd = new SqlCommand("select *  from stud_details ", conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            Console.WriteLine (sdr.HasRows);

            while (sdr.Read())
            {
                Console.WriteLine(sdr[0]+" "+ sdr["name"]);

            }
            Console.WriteLine("Row readed");
        }
    }
}
