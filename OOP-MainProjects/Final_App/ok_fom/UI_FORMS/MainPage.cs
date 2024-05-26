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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Admin_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLogin menu = new AdminLogin();
            menu.Show();
        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginMenu menu = new LoginMenu();
            menu.Show();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks For Using Airline System ... !", "THANK YOU", MessageBoxButtons.OK, MessageBoxIcon.None);
            AdminDL.storeAdmins();
            CustomerDL.storeUsers();
            FlightsDataDL.storeFlights();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
