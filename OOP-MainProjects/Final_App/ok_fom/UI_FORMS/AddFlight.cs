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
    public partial class AddFlight : Form
    {
        public AddFlight()
        {
            InitializeComponent();
        }

        private void btn_CLear_Click(object sender, EventArgs e)
        {
            txtbx_FlightName.Text = "";
            txtbx_FlightPrice.Text = "";
            txtbx_FlightTime.Text = "";
            txtbx_FlightRoute.Text = "";
            txtbx_TicketsQuantity.Text = "";
            txtbx_FlightName.Focus();
        }

        private void lbl_FlightRoute_Click(object sender, EventArgs e)
        {

        }

        private void txtbx_FlightTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_FlightTime_Click(object sender, EventArgs e)
        {

        }

        private void txtbx_FlightPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbx_FlightName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbx_FlightRoute_TextChanged(object sender, EventArgs e)
        {

        }

        // validation function for getting right input

        public static bool checkvalid(string testQuantity)
        {
            string x = testQuantity;
            for (int z = 0; z < x.Length; z++)
            {
                if (testQuantity[z] != '0' && testQuantity[z] != '1' && testQuantity[z] != '2' && testQuantity[z] != '3' && testQuantity[z] != '4' && testQuantity[z] != '5' && testQuantity[z] != '6' && testQuantity[z] != '7' && testQuantity[z] != '8' && testQuantity[z] != '9' && testQuantity[z] != '.')
                {
                    return false;
                }
            }
            return true;
        }

        private void btn_FlightAdd_Click(object sender, EventArgs e)
        {
            if(txtbx_FlightName.Text == "" || txtbx_FlightPrice.Text == "" || txtbx_FlightTime.Text == ""|| txtbx_FlightRoute.Text == "" || txtbx_TicketsQuantity.Text == "")
            {
                MessageBox.Show("Flight Information Is Missing ... !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                string flightName = txtbx_FlightName.Text;
                string flightPrice = txtbx_FlightPrice.Text;
                string flightTime = txtbx_FlightTime.Text;
                string flightRoute = txtbx_FlightRoute.Text;
                string tickets = txtbx_TicketsQuantity.Text;
                FlightsDataBL flight = new FlightsDataBL(flightName, flightTime, flightRoute, flightPrice, tickets);
                ViewFlights obj = new ViewFlights();
                if (!checkvalid(flightPrice) || !checkvalid(tickets))
                {
                    MessageBox.Show("Invalid Entered Price Or Tickets Quantity... !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    FlightsDataDL.addFlight(flight);
                    MessageBox.Show("Flight Added Successfully ... !", "Congratualtions", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void lbl_FlightPrice_Click(object sender, EventArgs e)
        {

        }

        private void lbl_FlightName_Click(object sender, EventArgs e)
        {

        }

        private void AddFlight_Load(object sender, EventArgs e)
        {

        }
    }
}
