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
    partial class RefundTickets : Form
    {
        static CustomerBL User;

        public RefundTickets()
        {
            InitializeComponent();
        }

        private void lbl_TotalAmount_Click(object sender, EventArgs e)
        {

        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            string name = listView_Flights.SelectedItems[0].SubItems[0].Text;
            string time = listView_Flights.SelectedItems[0].SubItems[1].Text;
            string price = listView_Flights.SelectedItems[0].SubItems[2].Text;
            string route = listView_Flights.SelectedItems[0].SubItems[3].Text;
            string userTickets = txtbx_Quantity.Text;
            FlightsDataBL flight = new FlightsDataBL(name, time, route, price, userTickets);
            UserFlightsBL userFlight = new UserFlightsBL(userTickets, flight);

            int flightIndex = 0;
            string tickets = "";
            bool ticketsCount = false;
            for (int x = 0; x < User.UserFlights.Count; x++)
            {
                if (name == User.UserFlights[x].FlightName)
                {
                    tickets = User.UserFlights[x].Tickets;
                    flightIndex = x;
                }
            }
            if (int.Parse(txtbx_Quantity.Text) > int.Parse(User.UserFlights[flightIndex].Tickets))
            {
                ticketsCount = true;
            }
            if (ticketsCount)
            {
                MessageBox.Show("Sorry Bought Tickets Are " + tickets + " ... !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int refundTickets = int.Parse(User.UserFlights[flightIndex].Tickets) - int.Parse(txtbx_Quantity.Text);
                User.UserFlights[flightIndex].Tickets = refundTickets + "";

                if (int.Parse(txtbx_Quantity.Text) > 1)
                {
                    listView_Flights.SelectedItems[0].SubItems[4].Text = refundTickets + "";
                    FlightsDataDL.Flights[flightIndex].FlightTickets = int.Parse(FlightsDataDL.Flights[flightIndex].FlightTickets) + int.Parse(txtbx_Quantity.Text) + "";
                    if(int.Parse(User.UserFlights[flightIndex].Tickets) <= 0)
                    {
                        listView_Flights.SelectedItems[0].SubItems[0].Text = "";
                        listView_Flights.SelectedItems[0].SubItems[1].Text = "";
                        listView_Flights.SelectedItems[0].SubItems[2].Text = "";
                        listView_Flights.SelectedItems[0].SubItems[3].Text = "";
                        txtbx_Quantity.Text = "";
                    }
                    MessageBox.Show("Tickets Refunded Successfully ... !", "THANK YOU", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else if (int.Parse(txtbx_Quantity.Text) == 1)
                {
                    FlightsDataDL.Flights[flightIndex].FlightTickets = int.Parse(FlightsDataDL.Flights[flightIndex].FlightTickets) + int.Parse(txtbx_Quantity.Text) + "";
                    MessageBox.Show("Ticket Refunded Successfully ... !", "THANK YOU", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Amount_Click(object sender, EventArgs e)
        {

        }

        private void lbl_EnterTickets_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Selection_Click(object sender, EventArgs e)
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

        private void btn_Proceed_Click(object sender, EventArgs e)
        {
            if (txtbx_Quantity.Text == "")
            {
                MessageBox.Show("Kindly Enter Quantity ... !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                if (txtbx_Quantity.Text == "")
                {
                    MessageBox.Show("Kindly Enter Quantity ... !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    if (!checkvalid(txtbx_Quantity.Text))
                    {
                        MessageBox.Show("Invalid Entered Quantity ... !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    else
                    {

                        lbl_TotalAmount.Visible = true;
                        lbl_Amount.Visible = true;
                        btn_Confirm.Visible = true;
                        btn_Exit.Visible = true;
                        string price = listView_Flights.SelectedItems[0].SubItems[2].Text;
                        int amountRefund = int.Parse(price) * int.Parse(txtbx_Quantity.Text);
                        lbl_Amount.Text = amountRefund + " $";

                    }

                }
            }
        }

        private void txtbx_Quantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView_Flights_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RefundTickets_Load(object sender, EventArgs e)
        {
            btn_Proceed.Visible = false;
            btn_Exit.Visible = false;
            lbl_TotalAmount.Visible = false;
            lbl_Amount.Visible = false;
            btn_Confirm.Visible = false;
            lbl_EnterTickets.Visible = false;
            txtbx_Quantity.Visible = false;

            listView_Flights.Columns.Add("Flight Name", 100);
            listView_Flights.Columns.Add("Flight Time", 100);
            listView_Flights.Columns.Add("Flight Price", 90);
            listView_Flights.Columns.Add("Flight Route", 165);
            listView_Flights.Columns.Add("Tickets Bought", 110);

            for (int x = 0; x < User.UserFlights.Count; x++)
            {
                string name = User.UserFlights[x].FlightName;
                string time = User.UserFlights[x].FlightTime;
                string price = User.UserFlights[x].FlightPrice;
                string route = User.UserFlights[x].FlightRoute;
                string tickets = User.UserFlights[x].Tickets;
                ListViewItem item = new ListViewItem(name);
                item.SubItems.Add(time);
                item.SubItems.Add(price);
                item.SubItems.Add(route);
                item.SubItems.Add(tickets);
                listView_Flights.Items.Add(item);
            }
        }

        private void listView_Flights_Click(object sender, EventArgs e)
        {

            btn_Proceed.Visible = true;
            txtbx_Quantity.Visible = true;
            lbl_EnterTickets.Visible = true;
        }

        public static void passUser(CustomerBL user)
        {
            User = user;
        }
    }
}
