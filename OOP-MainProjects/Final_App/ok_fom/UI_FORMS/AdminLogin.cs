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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void pictureBox_Return_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage page = new MainPage();
            page.Show();
        }

        // clear username and password int text boxes

        private void btn_CLear_Click(object sender, EventArgs e)
        {
            txtbx_Username.Text = "";
            txtbx_Password.Text = "";
            txtbx_Username.Focus();
        }

        // sign in if credentials are valid

        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            string username = txtbx_Username.Text;
            string password = txtbx_Password.Text;
            AdminMenu.passUsername(username);
            AdminBL admin = new AdminBL(username, password);
            bool test = AdminDL.checkAdmin(admin);
            if (username == "" || password == "")
            {
                MessageBox.Show("Username Or Password Is Empty ... !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (test == true)
            {
                MessageBox.Show("Signed In Successfully ... !", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                AdminMenu menu = new AdminMenu();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Credentials Not Found ... !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void lbl_Password_Click(object sender, EventArgs e)
        {

        }

        private void txtbx_Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_showPassword.Checked == true)
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
