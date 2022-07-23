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


        public static void kontostand(string query, MySqlConnection connection)
        {
                query = "SELECT SUM(ROUND(Preis, 2)) FROM Buchung JOIN chipkarte USING(chip_id) JOIN drink USING(drink_id) WHERE chip_id = 1";
                float cond;
                //Command line
                MySqlCommand command = new MySqlCommand(query, connection);
                command.CommandTimeout = 60;
                //Reading data
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    //save data
                    while (reader.Read())
                    {
                        cond = reader.GetFloat(0);
                        //output the data
                        Console.WriteLine("Deine Biere Schulden beträgt: {0} €", cond);
                }
                }
                else { Console.WriteLine("Table has no rows"); }  //If the table is empty

                //close Reading
                reader.Close();
        }

        public static void history(string query, MySqlConnection connection)
        {
            query = "SELECT bez , datum  FROM buchung JOIN chipkarte USING(chip_id) JOIN drink USING(drink_id) WHERE chip_id = 1";
            string cond;
            //Command line
            MySqlCommand command = new MySqlCommand(query, connection);
            command.CommandTimeout = 60;
            //Reading data
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                Console.WriteLine("Getränk:          Datum:");
                while (reader.Read())
                {
                    cond = reader.GetString(0);
                    //output the data
                    Console.WriteLine("{0}, {1}", cond, reader["datum"]);

                }
            }
            else { Console.WriteLine("Table has no rows"); }  //If the table is empty

            //close Reading
            reader.Close();
        }

        public static void insert_freiberger(string query, MySqlConnection connection)
        {
            query = "INSERT INTO Buchung VALUES (5, 1, 1, date '2022-07-22')";
         
            MySqlCommand command = new MySqlCommand(query, connection);
            command.CommandTimeout = 60;
            //Reading data
            command.ExecuteNonQuery();

            Console.WriteLine(Environment.NewLine + "Inserting Data...");
            Console.WriteLine("Done!");
        }



        public static void insert_oeti(string query, MySqlConnection connection)
        {
            query = "INSERT INTO Buchung VALUES (6, 2, 1, date '2022-07-22')";

            MySqlCommand command = new MySqlCommand(query, connection);
            command.CommandTimeout = 60;
            //Reading data
            command.ExecuteNonQuery();

            Console.WriteLine(Environment.NewLine + "Inserting Data...");
            Console.WriteLine("Done!");

        }






        static void Main()
        {

            
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=Chipkarte_system;";

            try
            {
                //Get the connection
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    //open connection
                    connection.Open();

                    //to get query
                    string query = "";

                    Console.WriteLine(Environment.NewLine + "Getting Data from Database...");
                    Console.WriteLine("Done!");


                    //Execution Funk
                    //kontostand(query, connection);

                    //history(query, connection);
                    insert_oeti(query, connection);

                    //And close the connection
                    connection.Close();

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Expection: " + ex.Message);
            }

        }

    }
}




