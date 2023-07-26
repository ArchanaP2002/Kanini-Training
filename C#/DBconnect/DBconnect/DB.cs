using System.Data.SqlClient;

namespace DBconnect
{
    internal class DB
    {
        // Connection to database
        SqlConnection conn;

        public SqlConnection Conn { get => conn; set => conn = value; }

        public void OpenConn(string connect)
        {
            Conn = new SqlConnection(connect);
            try
            {
                Conn.Open();
                Console.WriteLine("Connection established");
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Connection not established");
            }
        }

        public void CloseConn()
        {
            if (Conn != null && Conn.State == System.Data.ConnectionState.Open)
            {
                Conn.Close();
                Console.WriteLine("Connection closed");
            }
        }
    }
}