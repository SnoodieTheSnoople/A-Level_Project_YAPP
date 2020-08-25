using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MySQL_LoginForm_PROTOTYPE
{
    class DbConn
    {

        /*
         * Create new MySQL user for connecting to the server.
         * MUST ADD:-
         * - Update() in case user wants to update password/email
         * - Delete() to remove account
         * - Hashing algorithm for password
         */

        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public DbConn()
        {
            Initialise();
        }

        private void Initialise()
        {
            server = "localhost";
            database = "db";
            uid = "username";
            password = "password";
            string connectionString = $"SERVER = {server}; DATABASE = {database}; UID = {uid}; PASSWORD = {password};";

            connection = new MySqlConnection(connectionString);
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                //MessageBox.Show("Connected.");
                return true;
            }
            catch(MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.", "Yapp! ERROR");
                        break;

                    case 1:
                        MessageBox.Show("Invalid username/password.", "Yapp! ERROR");
                        break;
                }
                return false;
            }
        }

        private bool CloseConnection()
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

        public bool Insert(string email, string username, string password)
        {
            string query = $"INSERT INTO tablename (email, username, password) VALUES (@email, @username, @password);";
            var cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            //Checks if the connection is open
            //TRUE
            if (OpenConnection())
            {
                try
                {
                    cmd.ExecuteNonQuery();
                    CloseConnection();
                    return true;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message, "Yapp! Error");
                    CloseConnection();
                }
                return false;
            }
            return false;
        }

        //Compares the SELECT query with the parameters given by the user from the login page
        //PREVENT USER LOGGING IN WITH SAME EMAIL
        public bool Select(string email, string username, string password)
        {
            string query = "SELECT email, username, password FROM tablename WHERE email = @email AND username = @username AND password = @password";
            var cmd = new MySqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            if (OpenConnection())
            {
                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string qEmail = reader.GetString(0);
                    string qUname = reader.GetString(1);
                    string qPassword = reader.GetString(2);

                    if (qEmail == email && qUname == username && qPassword == password)
                    {
                        CloseConnection();
                        return true;
                    }
                    else
                    {
                        CloseConnection();
                        return false;
                    }
                }
            }
            CloseConnection();
            return false;
        }
    }
}
