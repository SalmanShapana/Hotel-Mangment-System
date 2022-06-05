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
    public partial class ReservationDetails : Form
    {
        public ReservationDetails()
        {
            InitializeComponent();
        }

        //Establishing the MySQL server connection
        public static string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=hotel_system";
        public static MySqlConnection databaseConnection = new MySqlConnection(connectionString);
        MySqlDataReader reader;

        string reservationID;
        string customerName;
        string customerPersonalID;
        string employeeUsername;

        reserveRoom reserveRoom_form = new reserveRoom();
        processSelectionForm processSelection_form = new processSelectionForm();
        EditReservation editReservation_form = new EditReservation();

        private void ReservationDetails_Load(object sender, EventArgs e)
        {
            try
            {
                databaseConnection.Open();
                //string signIn_query = "select reservation_id ,customer_name,customer_ID,employee_username from reservations WHERE employee_username ='" + reserveRoom_form.employee_username_input + "'";
                string getDetails_query = "select reservation_id ,customer_name,customer_ID,employee_username from reservations ORDER BY reservation_id DESC LIMIT 1";
                
                //MessageBox.Show(reserveRoom_form.employee_username_input);
                MySqlCommand signIncommandDatabase = new MySqlCommand(getDetails_query, databaseConnection);
                signIncommandDatabase.CommandTimeout = 60;
                reader = signIncommandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        reservationID = reader["reservation_id"].ToString();
                        customerName = reader["customer_name"].ToString();
                        customerPersonalID = reader["customer_ID"].ToString();
                        employeeUsername = reader["employee_username"].ToString();
                    }
                    reserv_id.Text = reservationID;
                    reserv_name.Text = customerName;
                    reserv_cust_id.Text = customerPersonalID;
                    reserv_username.Text = employeeUsername;
                }
                else
                {
                    MessageBox.Show("No Data To Fetch!", "Information");
                }
                databaseConnection.Close();
            }
            catch (Exception z)
            {
                MessageBox.Show("Something Went Wrong!" + z , "Information");

            }
        }

        private void Done_btn_Click(object sender, EventArgs e)
        {
            databaseConnection.Close();
            this.Hide();
            processSelection_form.Show();
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            databaseConnection.Close();
            this.Hide();
            editReservation_form.Show();
        }
    }
}
