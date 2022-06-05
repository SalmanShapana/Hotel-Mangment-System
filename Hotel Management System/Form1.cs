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

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Hotel_Management_System
{
    public partial class Form1 : Form
    {
        signUp signUp_form = new signUp();

        //Establishing the MySQL server connection
        public static string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=hotel_system;";
        public static MySqlConnection databaseConnection = new MySqlConnection(connectionString);
        MySqlDataReader reader;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void deleteUser()
        {
            string deleteUserQuery = "SELECT * FROM user";

            MySqlCommand commandDatabase = new MySqlCommand(deleteUserQuery, databaseConnection);
            commandDatabase.CommandTimeout = 60;
        }

        private void getAllUsers()
        {
            string getAllUsersQuery = "SELECT * FROM user";

            MySqlCommand commandDatabase = new MySqlCommand(getAllUsersQuery, databaseConnection);
            commandDatabase.CommandTimeout = 60;
        }

        private void addNewUser()
        {
            string addNewUserQuery = "SELECT * FROM user";

            MySqlCommand commandDatabase = new MySqlCommand(addNewUserQuery, databaseConnection);
            commandDatabase.CommandTimeout = 60;
        }
        
        
        //when the employee click on the sign up form, show up the sign up form on the screen.
        private void signUp_button_Click(object sender, EventArgs e)
        {
            signUp_form.Show();
        }

        //when the employee click on the sign in form, call the user constructor to sign him/her in.
        private void signIn_button_Click(object sender, EventArgs e)
        {
            Users currentUser = new Users(username_textBox.Text, password_textBox.Text);
            if (currentUser.isLoggedIn == true) this.Hide();
        }

    }

}
