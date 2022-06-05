using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class signUp : Form
    {
        public signUp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void signUp_button_Click(object sender, EventArgs e)
        {
            //Users currentUser = new Users(signUpUsrNam_in.Text, signUpPass_in.Text, signUpFrstName_in.Text, signUpLstName_in.Text, signUpAddrs_in.Text);
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Parent = null;
        }
    }
}
