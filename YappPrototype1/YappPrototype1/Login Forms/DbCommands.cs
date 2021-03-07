using MySql.Data.MySqlClient;
using Renci.SshNet.Messages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace YappPrototype1
{
    class DbCommands
    {
        private MySqlConnection connect;
        private string server;
        private string database;
        private string uid;
        private string password;

        public DbCommands()
        {
            server = ConfigurationManager.AppSettings.Get("serverName");
            database = ConfigurationManager.AppSettings.Get("db");
            uid = ConfigurationManager.AppSettings.Get("userID");
            password = ConfigurationManager.AppSettings.Get("password");

            StartConnection();
        }

        private void StartConnection()
        {
            //server = "localhost";
            //database = "testlogin";
            //uid = "yapp";
            //password = "password";


            string connectionString = $"SERVER = {server}; DATABASE = {database}; UID = {uid}; PASSWORD = {password};";
            connect = new MySqlConnection(connectionString);
        }

        private bool OpenConnection()
        {
            try
            {
                connect.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to the server.", "Yapp! Error");
                        break;

                    case 1:
                        MessageBox.Show("Invalid username/password.", "Yapp! Error");
                        break;
                }
                return false;
            } 
        }

        private bool CloseConnection()
        {
            try
            {
                connect.Close();
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
            string query = $"INSERT INTO login (email, username, password) VALUES (@email, @username, @password)";
            var cmd = new MySqlCommand(query, connect);

            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            if (OpenConnection())
            {
                try
                {
                    cmd.ExecuteNonQuery();
                    CloseConnection();

                    MessageBox.Show("Successfully created an account!", "Yapp!");

                    return true;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message, "Yapp! Error");
                    return false;
                }
            }
            return false;
        }

        //ONLY USED WHEN LOGGING IN
        public bool Select(string email, string username, string password)
        {
            string query = "SELECT email, username, password FROM login WHERE email = @email AND username = @username AND password = @password";
            var cmd = new MySqlCommand(query, connect);

            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            if (OpenConnection())
            {
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string queryEmail = reader.GetString(0);
                    string queryUsername = reader.GetString(1);
                    string queryPassword = reader.GetString(2);

                    if (queryEmail == email && queryUsername == username && queryPassword == password)
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

        //Below used only for the ConfirmAccount form. Literally a copy of the Select() method.
        //This only takes the email and username. It will not be used later on other than in this prototype.
        public bool ConfirmDetails(string email, string username)
        {
            string query = "SELECT email, username FROM login WHERE email = @email AND username = @username";
            var cmd = new MySqlCommand(query, connect);

            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@username", username);

            if (OpenConnection())
            {
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string queryEmail = reader.GetString(0);
                    string queryUsername = reader.GetString(1);

                    if (queryEmail == email && queryUsername == username)
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
            return false;
        }

        //Below is only used to update passwords.
        //When an appropriate method to verify the user, this method will be used.
        public bool UpdatePassword(string email, string password)
        {
            string query = "UPDATE login SET password = @password WHERE email = @email";

            var cmd = new MySqlCommand();
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@email", email);

            if (OpenConnection())
            {
                try
                {
                    cmd.CommandText = query;
                    cmd.Connection = connect;
                    cmd.ExecuteNonQuery();

                    CloseConnection();
                    MessageBox.Show("Password updated!", "Yapp!");
                    return true;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message, "Yapp! Error");
                    CloseConnection();
                    return false;
                }
                
            }
            return false;
        }

        public bool DeleteAcc(string email, string username)
        {
            string query = "DELETE FROM login WHERE email = @email AND username = @username";
            var cmd = new MySqlCommand();
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@username", username);

            if (OpenConnection())
            {
                try
                {
                    cmd.CommandText = query;
                    cmd.Connection = connect;

                    cmd.ExecuteNonQuery();
                    CloseConnection();
                    return true;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message, "Yapp! Error");
                    CloseConnection();
                    return false;
                }
            }
            CloseConnection();
            return false;
        }
    }
}
