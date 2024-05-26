using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ok_fom;

namespace ok_fom
{
    public partial class SignUpMenu : Form
    {
        public SignUpMenu()
        {
            InitializeComponent();
        }

        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginMenu menu = new LoginMenu();
            menu.Show();
        }

        // clear username and password int text boxes

        private void btn_CLear_Click(object sender, EventArgs e)
        {
            txtbx_Username.Text = "";
            txtbx_Password.Text = "";
            txtbx_ConfirmPassword.Text = "";
            txtbx_Username.Focus();
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
           
        }

        private void SignUpMenu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox_Return_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage page = new MainPage();
            page.Show();
        }

        // clear username and password int text boxes

        private void btn_CLear_Click_1(object sender, EventArgs e)
        {
            txtbx_Username.Text = "";
            txtbx_Password.Text = "";
            txtbx_ConfirmPassword.Text = "";
            txtbx_Username.Focus();
        }

        // sign up if credentials are valid

        private void btn_SignUp_Click_1(object sender, EventArgs e)
        {
            string username = txtbx_Username.Text;
            string password = txtbx_Password.Text;
            string confirmPass = txtbx_ConfirmPassword.Text;
            if (username == "" || password == "" || confirmPass == "")
            {
                MessageBox.Show("Username Or Password Is Empty ... !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (password == confirmPass)
            {
                CustomerBL customer = new CustomerBL(username, password);
                bool test = CustomerDL.checkUser(customer);
                if(test)
                {
                    MessageBox.Show("User Already Exists, Try Different Username Or Password ... !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    CustomerDL.addUser(customer);
                    MessageBox.Show("Signed Up Successfully ... !", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            else
            {
                MessageBox.Show("Password Does Not Match ... !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_showPassword.Checked == true)
            {
                txtbx_Password.UseSystemPasswordChar = true;
                txtbx_ConfirmPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtbx_Password.UseSystemPasswordChar = false;
                txtbx_ConfirmPassword.UseSystemPasswordChar = false;
            }
        }
    }
}
