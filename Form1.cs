using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using MySqlConnector;

namespace BierzaehlerUI
{
    public partial class Form1 : Form
    {

        MySqlConnection connection = new MySqlConnection();
        MySqlCommand command = new MySqlCommand();
        
        public Form1()
        {
            InitializeComponent();
            connection.ConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=Chipkarte_system;";
            //string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=Freiberger1;database=Chipkarte_system;";
            //MySqlConnection connection = new MySqlConnection(connectionString);
        }



        //Aktueller Stand
        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            string query = "SELECT SUM(ROUND(Preis, 2)) FROM Buchung JOIN chipkarte USING(chip_id) JOIN drink USING(drink_id) WHERE chip_id =  " + textBox1.Text + "";


            MySqlCommand command = new MySqlCommand(query, connection);
            command.CommandTimeout = 60;

            MySqlDataReader reader = command.ExecuteReader();
            Console.WriteLine(Environment.NewLine + "Getting Data from Database..." + Environment.NewLine);
            Console.WriteLine("Done!");
            float cond;

            if (reader.HasRows)
            {
                //Speicher the data
                while (reader.Read())
                {
                    cond = reader.GetFloat(0);

                    //output the data
                    MessageBox.Show("Deine Bierschulden betragen: "+ cond.ToString() +"€");

                }
            }
            else { Console.WriteLine("Table has no rows"); }  //If the table is empty


            reader.Close();



            connection.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            String UserInputText = this.textBox1.Text;

        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }




        private void button2_Click(object sender, EventArgs e)
        {
           
          
            connection.Open();
            string query = "SELECT COUNT(*) FROM Buchung WHERE chip_id = "+textBox1.Text+";";
            int count;
            


            MySqlCommand command = new MySqlCommand(query, connection);
            command.CommandTimeout = 60;

            MySqlDataReader reader = command.ExecuteReader();
            Console.WriteLine(Environment.NewLine + "Getting Data from Database..." + Environment.NewLine);
            Console.WriteLine("Done!");


            if (reader.HasRows)
            {

                //Speicher the data
                while (reader.Read())
                {
                    count = reader.GetInt32(0);

                    //output the data

                    MessageBox.Show("Du hast bisher " +  count.ToString() +  " Bier getrunken");

                }
            }
            else { Console.WriteLine("Table has no rows"); }  //If the table is empty


            reader.Close();



            connection.Close();



        }







        //INSERT Freiberger
        private void button3_Click(object sender, EventArgs e)
        {
            connection.Open();
            string query = "INSERT INTO Buchung VALUES (NULL,"+textBox1.Text+", 2)";

            MySqlCommand command = new MySqlCommand(query, connection);
            command.CommandTimeout = 60;
            //Reading data
            command.ExecuteNonQuery();

            Console.WriteLine(Environment.NewLine + "Inserting Data...");
            MessageBox.Show("Done!");

            connection.Close();
        }

        //Insert Oeti
        private void button4_Click(object sender, EventArgs e)
        {
            connection.Open();
            string query = "INSERT INTO Buchung VALUES (NULL," +textBox1.Text+", 1)";

            MySqlCommand command = new MySqlCommand(query, connection);
            command.CommandTimeout = 60;
            //Reading data
            command.ExecuteNonQuery();

            Console.WriteLine(Environment.NewLine + "Inserting Data...");
            MessageBox.Show("Done!");

            connection.Close();

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
