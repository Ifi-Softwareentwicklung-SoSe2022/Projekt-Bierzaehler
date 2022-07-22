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

            string cond;



            try
            {
                //(vlt Mysqlconnection)
                using (MySqlConnection connection = new MySqlConnection(connectionString)) //use the variable to connect -> connection (vlt Mysqlconnection)
                {
                    //Create the command
                    string query = "SELECT bez , datum  FROM buchung JOIN chipkarte USING(chip_id) JOIN drink USING(drink_id) WHERE chip_id = 2";
                                                            



                                                            
                    //Auch vllt Mysqlcommand
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.CommandTimeout = 60; //weiß ich nicht wofuer

                    //open connection
                    connection.Open();

                    //execute the SQL-Command
                    MySqlDataReader reader = command.ExecuteReader();

                    Console.WriteLine(Environment.NewLine + "Getting Data from Database..." + Environment.NewLine);
                    Console.WriteLine("Done!");


                    //check the Rows in the table
                    if (reader.HasRows)    
                    {
                        Console.WriteLine("Getränk:          Datum:");
                        //Speicher the data
                        while (reader.Read())
                        {
                            cond = reader.GetString(0);

                            //output the data
                            
                            Console.WriteLine("{0}, {1}", cond, reader["datum"]);

                        }
                    }
                    else { Console.WriteLine("Table has no rows"); }  //If the table is empty

                    //Close the execution
                    reader.Close();
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