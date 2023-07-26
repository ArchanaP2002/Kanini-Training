using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ado.net
{
    internal class Dinner
    {
        SqlConnection conn;

        public void OpenConn()
        {
            conn = new
        SqlConnection("data source=LAPTOP-PKS4NBKU\\SQLEXPRESS; " +
        "database= student;" +
        "integrated security=SSPI;");
            try
            {
                conn.Open();
                
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
        
            }


        }
        public void CreateTable()
        {
            SqlCommand cmd;

            cmd = new SqlCommand("create table Sales" +
              "(SaleID int PRIMARY KEY, CustomerID int NOT NULL, ItemID int NOT NULL," +
              " Price decimal(18,2) NOT NULL, Date date NOT NULL)", conn);
            cmd.ExecuteNonQuery();

            cmd = new SqlCommand("create table  Menus(ItemID int PRIMARY KEY, ItemName varchar(50) NOT NULL," +
               " ItemPrice decimal(18,2) NOT NULL) ", conn);

            cmd = new SqlCommand("create table  Member(CustomerID int primary key,MemberName nvarchar(50) NOT NULL,MemberEmail nvarchar(50) NOT NULL)",conn);
            cmd.ExecuteNonQuery();


            Console.WriteLine("Table created");

        }

        public void InsertTable()
        {
            SqlCommand cmd;
          cmd = new SqlCommand("insert into Sales values( 1,10,01,1000,'2022/01/01'),( 2,11,02,1600,'2007/05/04'),( 3,12,03,2020,'2008/'12/12)", conn);
        
            cmd = new SqlCommand("insert into Menus values(1,'sushi',300),(2,'curry',500),(3,'ramen',400)", conn);

           cmd = new SqlCommand("insert into Members values(10,'A','abc@gmail.com'),(11,'B','abc@gmail.com'),(12,'C','abc@gmail.com')", conn);
            cmd.ExecuteNonQuery();
            

            Console.WriteLine("Row inserted");
        }


        public void CloseCnn()
        {
            conn.Close();
        }


     
        public void TotalAmount()
        {

            SqlCommand cmd = new SqlCommand("SELECT SUM(m.ItemPrice),s.CustomerID FROM Sales s JOIN Menus  m ON s.ItemID = m.ItemID GROUP BY CustomerID; ", conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            if (!sdr.HasRows)
            {
                Console.WriteLine("empty");
            }
            else
            {

                while (sdr.Read())
                {
                    Console.WriteLine(sdr["CustomerID"] + " " + sdr[0]);
                    
                }
            }
            Console.WriteLine();
            sdr.Close();
     
        }

        public void count()
        {
            SqlCommand cmd = new SqlCommand(" Select count(distinct(Date)), CustomerID from Sales GROUP BY CustomerID; ", conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            if (!sdr.HasRows)
            {
                Console.WriteLine("empty");
            }
            else
            {

                while (sdr.Read())
                {
                    Console.WriteLine(sdr["CustomerID  no of Purchase"] + " " + sdr[0]);

                }
            }
            Console.WriteLine();
            sdr.Close();
        }

        public void MostPurchased()
        {
            SqlCommand cmd = new SqlCommand("Select top 1 ItemID , count(ItemID) As Count  from Sales group by ItemID order by  ItemID desc;", conn);
                     SqlDataReader sdr = cmd.ExecuteReader();
            if (!sdr.HasRows)
            {
                Console.WriteLine("empty");
            }
            else
            {

                while (sdr.Read())
                {
                    Console.WriteLine(sdr["ItemID"] + " " + sdr[0]);

                }
            }
            Console.WriteLine();
            sdr.Close();
        }

        public void TotalItem()
        {
            SqlCommand cmd = new SqlCommand("Select S.CustomerID , count(S.ItemID) Noofproducts, SUM(M.ItemPrice) As Amount from Sales S join Menus M ON S.ItemID = M.ItemID group by  CustomerID;", conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            if (!sdr.HasRows)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine("CustomerId  Cost");
                while (sdr.Read())
                {
                    Console.WriteLine(sdr["CustomerID"] + " " + sdr[1] + sdr[2]);

                }
            }
            Console.WriteLine();
            sdr.Close();
        }

        public void Points()
        {
            SqlCommand cmd = new SqlCommand("Select S.CustomerID , sum(ItemPrice)*10 As Points  from Sales S join Menus M on S.ItemID = M.ItemID group by S.CustomerID;", conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            if (!sdr.HasRows)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine("CustomerId  points");
                while (sdr.Read())
                {
                    Console.WriteLine(sdr["CustomerID"] + " " + sdr[1] );

                }
            }
            Console.WriteLine();
            sdr.Close();
        }
    }
}
