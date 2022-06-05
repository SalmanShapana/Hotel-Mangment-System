using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hotel_Management_System
{
    class Users
    {
        processSelectionForm processSelection_form = new processSelectionForm();

        private string username;
        private string id;
        private string firstName;
        private string lastName;
        private string password;
        private string address;

        public bool isLoggedIn;

        //Establishing the MySQL server connection
        public static string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=hotel_system";
        public static MySqlConnection databaseConnection = new MySqlConnection(connectionString);
        MySqlDataReader reader;

        public Users()
        {

        }

        public Users(string entered_username, string enterd_password)
        {
            try
            {
                if (entered_username != "" && enterd_password != "")
                {

                    databaseConnection.Open();
                    string signIn_query = "select id,username,password,first_name,last_name,address from users WHERE username ='" + entered_username + "' AND password ='" + enterd_password + "'";
                    MySqlCommand signIncommandDatabase = new MySqlCommand(signIn_query, databaseConnection);
                    signIncommandDatabase.CommandTimeout = 60;
                    reader = signIncommandDatabase.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            id = reader["id"].ToString();
                            username = reader["username"].ToString();
                            password = reader["password"].ToString();
                            firstName = reader["first_name"].ToString();
                            lastName = reader["last_name"].ToString();
                            address = reader["address"].ToString();
                        }
                        //MessageBox.Show("Data found your name is " + firstName + " " + lastName + " " + " and your address at " + address);
                        isLoggedIn = true;
                        processSelection_form.Show();
                    }
                    else
                    {
                        isLoggedIn = false;
                        MessageBox.Show("Wrong Username or Password", "Information");
                    }
                }
                else
                {
                    isLoggedIn = false;
                    MessageBox.Show("Username or Password is empty", "Information");
                }
                databaseConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Connection Error" + e, "Information");
            }
        }

        public bool isExistingUser(string employee_username)
        {
            databaseConnection.Open();
            //QUERY EXAMPLE:    select id,username, from users WHERE username ='Ahmed Ibrahim' AND password ='123'
            string isExistingUser_query = "select id,username from users WHERE username ='" + employee_username + "'";
            MySqlCommand isExistingQueryCommand = new MySqlCommand(isExistingUser_query, databaseConnection);
            isExistingQueryCommand.CommandTimeout = 60;
            reader = isExistingQueryCommand.ExecuteReader();


            //If there's an existing user with the same username. pop up a message box to the employee and say "this username is already available"
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    id = reader["id"].ToString();
                    username = reader["username"].ToString();
                }
                databaseConnection.Close();
                return true;
            }
            else
            {
                databaseConnection.Close();
                return false;
            }
        }
    }
}
