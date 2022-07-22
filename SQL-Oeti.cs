using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MySqlConnector;


namespace Testapp_Select
{
    class Program
    {
        static void Main()
        {
            //create variable to connect
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=Chipkarte_system;";
            //use the variables to store the data (result)

            float cond;


            try
            {
                //(vlt Mysqlconnection)
                using (MySqlConnection connection = new MySqlConnection(connectionString)) //use the variable to connect -> connection (vlt Mysqlconnection)
                {
                    //Create the command
                    string query = "INSERT INTO Buchung VALUES (5, 1, 2, date '2022-07-22')"; //Oeti





                    //connecting with SQL
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.CommandTimeout = 60; //weiß ich nicht wofuer

                    //open connection
                    connection.Open();

                    command.ExecuteNonQuery();
                    //execute the SQL-Command
                    //MySqlDataReader reader = command.ExecuteReader();

                    Console.WriteLine(Environment.NewLine + "Inserting Data..." + Environment.NewLine);
                    Console.WriteLine("Done!");


                    //check the Rows in the table
                } 
            }


            catch (Exception ex)
            {
                Console.WriteLine("Expection: " + ex.Message);
            }




        }


    }
}