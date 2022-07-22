using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source = 24e6b0c39456\\MySQL ; Initial Catalog = Chipkarte_system; User ID = root; Password=Riadr555";

            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                Console.WriteLine("The database has been opened!");
                Console.WriteLine("Connection State: " + connection.State.ToString());

                connection.Close();
                Console.WriteLine("The database has been closed!");

                connection.Dispose();
                Console.WriteLine("The database connection has been disposed!");
                Console.WriteLine("Connection State: " + connection.State.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("There's an error connecting to the database!\n" + ex.Message);
            }

            Console.ReadLine();
        }
    }
}

