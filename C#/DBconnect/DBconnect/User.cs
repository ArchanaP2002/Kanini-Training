using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBconnect
{
    internal class User : DB
    {
        String sql;
        SqlCommand command;
        SqlParameter param;
        object email;

        public SqlConnection Conn { get; private set; }

        public void UserDetails()
        {
            String sql = "Insert into Users1(FirstName, LastName, Email, Phone, Address, City, State_1, Gender,UserType) values (@FirstName, @LastName, @Email, @Phone, @Address, @City, @State_1, @Gender, @UserType)";
            command = new SqlCommand(sql, Conn);

            Console.Write("Enter your firstname: ");
            command.Parameters.Add(new SqlParameter("@FirstName", Console.ReadLine()));

            Console.Write("Enter your Lastname: ");
            command.Parameters.Add(new SqlParameter("@LastName", Console.ReadLine()));

            Console.Write("Enter your Email: ");
            email = Console.ReadLine();
            command.Parameters.Add(new SqlParameter("@Email", email));

            Console.Write("Enter your Phone: ");
            command.Parameters.Add(new SqlParameter("@Phone", Console.ReadLine()));

            Console.Write("Enter your address: ");
            command.Parameters.Add(new SqlParameter("@Address", Console.ReadLine()));

            Console.Write("Enter your city: ");
            command.Parameters.Add(new SqlParameter("@City", Console.ReadLine()));

            Console.Write("Enter your state: ");
            command.Parameters.Add(new SqlParameter("@State_1", Console.ReadLine()));

            Console.Write("Enter your Gender: ");
            command.Parameters.Add(new SqlParameter("@Gender", Console.ReadLine()));

            Console.Write("Enter mode of accessing books(Physical or Online): ");
            string mode = Convert.ToString(Console.ReadLine());
            command.Parameters.Add(new SqlParameter("@UserType", mode));
 
            Console.WriteLine();
            Console.WriteLine("*****You are now a member****** ");

            if (mode == "Online")
            {
                SqlCommand command = new SqlCommand("dbo.CheckOnlineInsert", Conn);
                command.CommandType = CommandType.StoredProcedure;
                param = command.Parameters.Add("@Email", SqlDbType.NVarChar, 20);
                param.Value = email;

            
                Console.WriteLine();
                Console.WriteLine("****You are now a subscribed user*****");
            }
        }

       
    }
}
