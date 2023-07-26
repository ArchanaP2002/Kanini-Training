using System;
using DBconnect;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBconnect
{
    internal class Add : DB
    {
        String sql;
        SqlCommand command;

        public SqlConnection Conn { get; private set; }

        public void AddBook()
        {
            sql = "INSERT INTO Bookses (Categoryid, Title, Author, ISBN, Publisher, Edition, Language) " +
                "VALUES (@Categoryid, @Title, @Author, @ISBN, @Publisher, @Edition, @Language)";
            command = new SqlCommand(sql, Conn);

            Console.Write("Enter Category id: ");
            command.Parameters.Add(new SqlParameter("@Categoryid", Console.ReadLine()));


            Console.Write("Enter book title: ");
            command.Parameters.Add(new SqlParameter("@Title", Console.ReadLine()));


            Console.Write("Enter Author name: ");
            command.Parameters.Add(new SqlParameter("@Author", Console.ReadLine()));


            Console.Write("Enter ISBN No : ");
            command.Parameters.Add(new SqlParameter("@ISBN", Console.ReadLine()));


            Console.Write("Enter publisher: ");
            command.Parameters.Add(new SqlParameter("@Publisher", Console.ReadLine()));


            Console.Write("Enter Edition: ");
            command.Parameters.Add(new SqlParameter("@Edition", Console.ReadLine()));


            Console.Write("Enter language: ");
            command.Parameters.Add(new SqlParameter("@Language", Console.ReadLine()));


            
            Console.WriteLine();
            Console.WriteLine("=================Your Book is inserted===================");
        }

     
             
        }
    
}
