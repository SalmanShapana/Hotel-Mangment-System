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
    public partial class EditReservation : Form
    {
        public EditReservation()
        {
            InitializeComponent();
        }
        processSelectionForm processSelection_form = new processSelectionForm();

        //Establishing the MySQL server connection
        public static string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=hotel_system";
        public static MySqlConnection databaseConnection = new MySqlConnection(connectionString);
        MySqlDataReader reader;

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            //UPDATE reservations SET customer_name = 'Lopez' WHERE reservation_id = 4;
            try
            {
                databaseConnection.Open();
                //string signIn_query = "select reservation_id ,customer_name,customer_ID,employee_username from reservations WHERE employee_username ='" + reserveRoom_form.employee_username_input + "'";
                string updateReserv_query = "UPDATE reservations SET customer_name = '" + customer_name.Text + "' ORDER BY reservation_id DESC LIMIT 1";

                //MessageBox.Show(reserveRoom_form.employee_username_input);
                MySqlCommand updateReservcommandDatabase = new MySqlCommand(updateReserv_query, databaseConnection);
                updateReservcommandDatabase.CommandTimeout = 60;
                reader = updateReservcommandDatabase.ExecuteReader();
                
                databaseConnection.Close();
                this.Hide();
                processSelection_form.Show();
            }
            catch (Exception z)
            {
                MessageBox.Show("Something Went Wrong!" + z, "Information");
            }
        }

        private void EditReservation_Load(object sender, EventArgs e)
        {
            try
            {
                databaseConnection.Open();
                //string signIn_query = "select reservation_id ,customer_name,customer_ID,employee_username from reservations WHERE employee_username ='" + reserveRoom_form.employee_username_input + "'";
                string editGet_query = "select adults_count, childrens_count, customer_name, customer_ID ,employee_username  from reservations ORDER BY reservation_id DESC LIMIT 1";

                //MessageBox.Show(reserveRoom_form.employee_username_input);
                MySqlCommand signIncommandDatabase = new MySqlCommand(editGet_query, databaseConnection);
                signIncommandDatabase.CommandTimeout = 60;
                reader = signIncommandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        adultCount_inp_edit.Text = reader["adults_count"].ToString();
                        childrenCount_inp.Text = reader["childrens_count"].ToString();
                        customer_name.Text = reader["customer_name"].ToString();
                        customer_id_no.Text = reader["customer_ID"].ToString();
                        employee_username_inp.Text = reader["employee_username"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("No Data To Fetch!", "Information");
                }
                databaseConnection.Close();
            }
            catch (Exception z)
            {
                MessageBox.Show("Something Went Wrong!" + z, "Information");

            }
        }
    }
}
