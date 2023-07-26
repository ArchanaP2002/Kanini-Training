//LAPTOP-PKS4NBKU\SQLEXPRESS sql server name
//using System;
 
using Ado.net;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;
 
 
class program : ConfigurationSection
{
    public static void  Main(string[] args)
    {
        //Dinner dinner = new Dinner();
        //dinner.OpenConn();
        //dinner.CreateTable();
        //dinner.InsertTable();
        //dinner.TotalAmount();
        //dinner.count();
        //dinner.MostPurchased();
        //dinner.TotalItem();
        //dinner.Points();

        //Console.WriteLine(
        //   ConfigurationManager.AppSettings["key1"]);
        //Console.WriteLine(
        //   ConfigurationManager.AppSettings["key2"]);






        //------------------------------
        //SqlConnection conn = new 
        //    SqlConnection("data source=LAPTOP-PKS4NBKU\\SQLEXPRESS; " +
        //    "database=student;" +
        //    "integrated security=SSPI");
        //conn.Open();
        //Console.WriteLine("open");

        //SqlCommand cmd = new SqlCommand("create" +
        //    " table stud_details(rno int, " +
        //    "name nvarchar(20))",conn);
        //cmd.ExecuteNonQuery();
        //Console.WriteLine("Table created");
        //conn.Close();
        //--------------------------------


        //DB db = new DB();
        // db.CreateTable();
        // db.OpenConn();
        // db.InsertTable();
        // db.CloseCnn();
        // db.UpdateTable();
        //db.DeleteTable();
        // db.ReadTable();

        //StringBuilder cnnstr = new StringBuilder("data source=");
        //Console.WriteLine("Enter Data Source");
        //cnnstr.Append(Console.ReadLine());
        //cnnstr.Append(";Initial Catalog=");
        //Console.WriteLine("Enter Database name");
        //cnnstr.Append(Console.ReadLine());
        //cnnstr.Append(";integrated Security= SSPI;");
        //Console.WriteLine(cnnstr);

        //DB db = new DB();
        //db.OpenConn(cnnstr.ToString());

    }
}

