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
    public partial class reserveRoom : Form
    {
        public reserveRoom()
        {
            InitializeComponent();
        }

        //Establishing the MySQL server connection
        public static string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=hotel_system";
        public static MySqlConnection databaseConnection = new MySqlConnection(connectionString);
        MySqlDataReader reader;

        string customerName;
        string customerID;

        public string employee_username_input;
        string check_in_date;
        string check_out_date;

        bool breakfast_service;
        bool launch_service;
        bool dinner_service;
        bool Internet_service;
        bool privateBeach_service;

        bool room1;
        bool room2;
        bool room3;
        bool room4;
        bool room5;
        bool room6;

        string childrensCount;
        string adultsCount;

        processSelectionForm processSelection_form2 = new processSelectionForm();
        Users user = new Users();

        private void labelPriceRoom3_Click(object sender, EventArgs e)
        {

        }
        
        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (adultCount_inp.Text != "" && childrenCount_inp.Text != "" && customer_name.Text != "" && customer_id_no.Text!= "")
                {

                    customerName = customer_name.Text;
                    customerID = customer_id_no.Text;

                    employee_username_input = employee_username_inp.Text;

                    check_in_date = dateTimePickerCheckInDate.Value.ToString("yyyy/MM/dd ");
                    check_out_date = dateTimePickerCheckOutDate.Value.ToString("yyyy/MM/dd ");

                    if (checkBoxBooking1.CheckState == CheckState.Checked) room1 = true;
                    else room1 = false;
                    if (checkBoxBooking2.CheckState == CheckState.Checked) room2 = true;
                    else room2 = false;
                    if (checkBoxBooking3.CheckState == CheckState.Checked) room3 = true;
                    else room3 = false;
                    if (checkBoxBooking4.CheckState == CheckState.Checked) room4 = true;
                    else room4 = false;
                    if (checkBoxBooking5.CheckState == CheckState.Checked) room5 = true;
                    else room5 = false;
                    if (checkBoxBooking6.CheckState == CheckState.Checked) room6 = true;
                    else room6 = false;

                    if (checkBoxBreakfast.CheckState == CheckState.Checked) breakfast_service = true;
                    else breakfast_service = false;
                    if (checkBoxLaunch.CheckState == CheckState.Checked) launch_service = true;
                    else launch_service = false;
                    if (checkBoxDinner.CheckState == CheckState.Checked) dinner_service = true;
                    else dinner_service = false;
                    if (checkBoxInternet.CheckState == CheckState.Checked) Internet_service = true;
                    else Internet_service = false;
                    if (checkBoxPrivateBeach.CheckState == CheckState.Checked) privateBeach_service = true;
                    else privateBeach_service = false;

                    childrensCount = adultCount_inp.Text;
                    adultsCount = childrenCount_inp.Text;

                    if (user.isExistingUser(employee_username_input) == true)
                    {
                        databaseConnection.Open();
                        //QUERY EXAMPLE:    "INSERT INTO reservations (reservation_id, employee_username, employee_password, room1_reserved, room2_reserved, room3_reserved, room4_reserved, room5_reserved, room6_reserved, breakfast_service, launch_service, dinner_service, , internet_service, beach_service, check_in_date, check_out_date, adults_counts, childrens_count) VALUES (...)
                        string reservationQuery = "INSERT INTO reservations (customer_name, customer_ID, employee_username, room1_reserved, room2_reserved, room3_reserved, room4_reserved, room5_reserved, room6_reserved, breakfast_service, launch_service, dinner_service, internet_service, beach_service, check_in_date, check_out_date, adults_count, childrens_count) VALUES ('" + customerName + "', '" + customerID + "', '" + employee_username_input + "', '" + room1.ToString() + "', '" + room2.ToString() + "', '" + room3.ToString() + "', '" + room4.ToString() + "', '" + room5.ToString() + "', '" + room6.ToString() + "', '" + breakfast_service.ToString() + "', '" + launch_service + "', '" + dinner_service + "', '" + Internet_service + "', '" + privateBeach_service + "', '" + check_in_date + "', '" + check_out_date + "', " + adultsCount + ", " + childrensCount + ")";
                        //string reservationQuery = "INSERT INTO reservations (employee_username) VALUES ('" + "ahmed')";

                        MySqlCommand reservationQuerycommandDatabase = new MySqlCommand(reservationQuery, databaseConnection);
                        reservationQuerycommandDatabase.CommandTimeout = 60;
                        reader = reservationQuerycommandDatabase.ExecuteReader();
                        //show the receipt form
                        this.Hide();
                        ReservationDetails reservationDetails_form = new ReservationDetails();
                        reservationDetails_form.Show();
                    }
                    else MessageBox.Show("This Employee Username not exists!", "Information");
                    
                }
                else MessageBox.Show("Please enter all the needed data", "Missing Information");
                databaseConnection.Close();
            }

            catch (Exception y)
            {
                MessageBox.Show("Error submitting your reservation" + y, "Ops!");
            }

        }

        private void cancel_reservation_btn_Click(object sender, EventArgs e)
        {
            databaseConnection.Close();
            this.Hide();
            processSelection_form2.Show();
        }
    }
}
