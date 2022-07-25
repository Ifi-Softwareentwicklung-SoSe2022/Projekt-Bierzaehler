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

        //Bierschulden
        public static void bier_schulden(string query, MySqlConnection connection)
        {
            //Getting the ID
            Console.WriteLine("Enter ID:");
            string input = Console.ReadLine();


            query = "SELECT SUM(ROUND(Preis, 2)) FROM Buchung JOIN chipkarte USING(chip_id) JOIN drink USING(drink_id) WHERE chip_id = " + input + "";
            float cond;
            //Command line
            MySqlCommand command = new MySqlCommand(query, connection);
            command.CommandTimeout = 60;
            //Reading data
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows) //if the table not empty
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

            //close the reading
            reader.Close();
        }


        //Getrunkene Bier Zahlen
        public static void bier_zahler(string query, MySqlConnection connection)
        {
            Console.WriteLine("Enter ID:");
            string input = Console.ReadLine();
            query = "SELECT COUNT(*) FROM Buchung WHERE chip_id = " + input + ""; //Namen reinpacken, um zu überprüfen
            int count;
            //Command line
            MySqlCommand command = new MySqlCommand(query, connection);
            command.CommandTimeout = 60;
            //Reading data
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {

                while (reader.Read())
                {
                    count = reader.GetInt32(0);
                    //output the data
                    Console.WriteLine("Du hast bisher " + count.ToString() + " Bier getrunken");

                }
            }
            else { Console.WriteLine("Table has no rows"); }  //If the table is empty

            //close Reading
            reader.Close();
        }

        //Insert Freiberger
        public static void insert_freiberger(string query, MySqlConnection connection)
        {
            Console.WriteLine("Enter ID:");
            string input = Console.ReadLine();
            query = "INSERT INTO Buchung VALUES (NULL, " + input + ", 1)";

            MySqlCommand command = new MySqlCommand(query, connection);
            command.CommandTimeout = 60;
            //Reading data
            command.ExecuteNonQuery();

            Console.WriteLine(Environment.NewLine + "Inserting Data...");
            Console.WriteLine("Done!");
        }


        //insert Öti
        public static void insert_oeti(string query, MySqlConnection connection)
        {
            Console.WriteLine("Enter ID:");
            string input = Console.ReadLine();
            query = "INSERT INTO Buchung VALUES (NULL, " + input + ", 1)";

            MySqlCommand command = new MySqlCommand(query, connection);
            command.CommandTimeout = 60;
            //Reading data
            command.ExecuteNonQuery();

            Console.WriteLine(Environment.NewLine + "Inserting Data...");
            Console.WriteLine("Done!");

        }






        static void Main()
        {

            //Connection string
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=Chipkarte_system;";

            try
            {
                //Get the connection
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    //open connection
                    connection.Open();




                    //get the query
                    string query = "";

                    Console.WriteLine("1.Aktueller Bierschulden");
                    Console.WriteLine("2.Getrunkene Bier");
                    Console.WriteLine("3.Freiberger");
                    Console.WriteLine("4.Öti" + Environment.NewLine);


                    //Getting input
                    Console.WriteLine("Bitte die Auswahl hier eingeben: ");
                    int i = Convert.ToInt32(Console.ReadLine());


                    Console.WriteLine(Environment.NewLine + "Getting Data from Database...");
                    Console.WriteLine("Done!" + Environment.NewLine);


                    //The small App
                    while (i != 0)
                    {
                        Console.WriteLine("Alkoholkonsumcheck!! Bitte die Auswahl nochmal eingeben oder  "); //controling drunk peaple ^^
                        Console.WriteLine("Drücke 0 um zu beenden" + Environment.NewLine);
                        i = Convert.ToInt32(Console.ReadLine());

                        if (i == 1)
                        {
                            bier_schulden(query, connection);
                        }
                        else if (i == 2)
                        {
                            bier_zahler(query, connection);
                        }
                        else if (i == 3)
                        {
                            insert_freiberger(query, connection);
                        }
                        else if (i == 4)
                        {
                            insert_oeti(query, connection);
                        }
                    }
                    //End the App by pressing 0

                    connection.Close();

                }

            }
            //If error, then give me the Exception
            catch (Exception ex)
            {
                Console.WriteLine("Expection: " + ex.Message);
            }

        }

    }
}
