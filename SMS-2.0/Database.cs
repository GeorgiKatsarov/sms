using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SMS_2._0
{
    internal class Database
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public Database()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            database = "sms";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }
        /// <summary>
        /// This methood is for opening connection to the database.
        /// </summary>
        /// <returns></returns>
        //open connection to database
        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException)
            {

                MessageBox.Show("Cannot connect to server.  Contact administrator");
                return false;

            }
        }

        /// <summary>
        /// This method is for closing connection to the database.
        /// </summary>
        /// <returns></returns>
        //Close connection
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// This method is used for the admin to log into the system.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pass"></param>

        public bool AdminCheckIn(string name, string pass)
        {

            string query = $"select * from sms.admin where adminName = '{name}' and adminPassword = '{pass}'";
            //Open connection
            if (this.OpenConnection() == true)
            {
                try
                {
                    // Create Command
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    //Create a data reader and Execute the command
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    //Read the data and store them in the list
                    if (dataReader.Read())
                    {
                        MessageBox.Show("Welcome, admin!", "Successfully logged", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Wrong given information! Please, try again!", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    //close Data Reader
                    dataReader.Close();

                    //close Connection
                    this.CloseConnection();

                    //return value
                    return true;

                }
                catch (Exception)
                {
                    return false;
                    MessageBox.Show("Wrong given information! Please, try again!", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                return false;
                MessageBox.Show("Invalid inputs! Please, try again!", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
       
        /// <summary>
        /// This method is used for running different queries.
        /// </summary>

        public void RunQuery(string query)
        {
            //Open connection
            if (this.OpenConnection() == true)
            {
                try
                {
                    // Create Command
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    //Create a data reader and Execute the command
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    //close Data Reader
                    dataReader.Close();
                    //close Connection
                    this.CloseConnection();
                }
                catch (Exception)
                {
                    MessageBox.Show("Could not reach server", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Could not reach server", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}



