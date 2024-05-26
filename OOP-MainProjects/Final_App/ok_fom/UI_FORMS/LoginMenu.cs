using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ok_fom
{
    public partial class LoginMenu : Form
    {
        public LoginMenu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LoginMenu_Load(object sender, EventArgs e)
        {
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpMenu menu = new SignUpMenu();
            menu.Show();
        }

        // clear username and password int text boxes

        private void btn_CLear_Click(object sender, EventArgs e)
        {
            txtbx_Username.Text = "";
            txtbx_Password.Text = "";
            txtbx_Username.Focus();
        }

        private void btn_SignIn_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox_Return_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage page = new MainPage();
            page.Show();
        }

        private void pictureBox_Return_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MainPage page = new MainPage();
            page.Show();
        }

        // sign in if credentials are valid 

        private void btn_SignIn_Click_1(object sender, EventArgs e)
        {
            string username = txtbx_Username.Text;
            string password = txtbx_Password.Text;
            CustomerMenu.passUsename(username);
            CustomerBL customer = null;
            customer = CustomerDL.getUser(username, password);
            if (username == "" || password == "")
            {
                MessageBox.Show("Username Or Password Is Empty ... !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (customer!= null)
            {
                ViewUserFlights.passUser(customer);
                SearchFlight.passUser(customer);
                RefundTickets.passUser(customer);
                //CustomerDL.loadUserFlights();
                MessageBox.Show("Signed In Successfully ... !", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                CustomerMenu menu = new CustomerMenu();
                menu.Show();
            }
            else
            {
                MessageBox.Show("User Not Found, Kindly Sign Up First ... !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btn_CLear_Click_1(object sender, EventArgs e)
        {
            txtbx_Username.Text = "";
            txtbx_Password.Text = "";
            txtbx_Username.Focus();
        }

        private void txtbx_Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_showPassword.Checked == true)
            {
                txtbx_Password.UseSystemPasswordChar = true;
            }
            else
            {
                txtbx_Password.UseSystemPasswordChar = false;
            }
        }
    }
}
