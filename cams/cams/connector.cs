using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace cams
{
    public class connector
    {
        string server;
        string database;
        string userName;
        string password;
        public MySqlConnection connection;
        public connector()
        {
            server = "localhost";
            database = "cams_database";
            userName = "root";
            password = "";

            string connectionString = "SERVER= " + server + "DATABASE= " + database + ";UID=" + userName + ";PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
        }

        public bool openConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException e)
            {
                Console.Write("Invalid connection");
                return false;
            }
        }

        public bool closeConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException e)
            {
                Console.Write("Invalid connection");
                return false;
            }
        }
    }
}
