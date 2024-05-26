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
    partial class SearchFlight : Form
    {
        static CustomerBL User;
        
        public SearchFlight()
        {
            InitializeComponent();
        }

        private void SearchFlight_Load(object sender, EventArgs e)
        {
            listView_Flights.Visible = false;
            lbl_Selection.Visible = false;
            txtbx_Quantity.Visible = false;
            btn_Proceed.Visible = false;
            btn_Exit.Visible = false;
            lbl_TotalAmount.Visible = false;
            lbl_Amount.Visible = false;
            btn_Confirm.Visible = false;
            lbl_EnterTickets.Visible = false;

        }

        // search for available flights 

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string nameSearch = txtbx_SearchFlight.Text;
            if (nameSearch == "")
            {
                MessageBox.Show("Search Box Is Empty ... !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                int count = 0;
                listView_Flights.Items.Clear();
                listView_Flights.Columns.Clear();
                listView_Flights.Columns.Add("Flight Name", 100);
                listView_Flights.Columns.Add("Flight Time", 100);
                listView_Flights.Columns.Add("Flight Price", 90);
                listView_Flights.Columns.Add("Flight Route", 165);

                for (int x = 0; x < FlightsDataDL.Flights.Count; x++)
                {
                    if (FlightsDataDL.Flights[x].FlightRoute == nameSearch)
                    {
                        listView_Flights.Visible = true;
                        lbl_Selection.Visible = true;
                        string name = FlightsDataDL.Flights[x].FlightName;
                        string time = FlightsDataDL.Flights[x].FlightTime;
                        string price = FlightsDataDL.Flights[x].FlightPrice;
                        string route = FlightsDataDL.Flights[x].FlightRoute;
                        ListViewItem item = new ListViewItem(name);
                        item.SubItems.Add(time);
                        item.SubItems.Add(price);
                        item.SubItems.Add(route);
                        listView_Flights.Items.Add(item);
                        count = 1;
                    }
                }
                if(count == 0)
                {
                    MessageBox.Show("Unfortunately No Flights Are Available ... !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
        }

        private void listView_Flights_Click(object sender, EventArgs e)
        {
            btn_Proceed.Visible = true;
            txtbx_Quantity.Visible = true;
            lbl_EnterTickets.Visible = true;
        }

        private void txtbx_Quantity_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Selection_Click(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks For Using Our System ... !", "THANK YOU", MessageBoxButtons.OK, MessageBoxIcon.None);

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

        // confirm tickets 

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            string name = listView_Flights.SelectedItems[0].SubItems[0].Text;
            string time = listView_Flights.SelectedItems[0].SubItems[1].Text;
            string price = listView_Flights.SelectedItems[0].SubItems[2].Text;
            string route = listView_Flights.SelectedItems[0].SubItems[3].Text;
            string userTickets = txtbx_Quantity.Text;
            if (!checkvalid(txtbx_Quantity.Text) || int.Parse(txtbx_Quantity.Text) <= 0)
            {
                MessageBox.Show("Invalid Entered Price Or Tickets Quantity... !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                int flightIndex = 0;
                bool ticketsCount = false;
                string tickets = "";
                for(int x = 0; x< FlightsDataDL.Flights.Count; x++)
                {
                    if (name == FlightsDataDL.Flights[x].FlightName)
                    {
                        tickets = FlightsDataDL.Flights[x].FlightTickets;
                        flightIndex = x;
                    }
                }
                if(int.Parse(txtbx_Quantity.Text) > int.Parse(FlightsDataDL.Flights[flightIndex].FlightTickets))
                {
                    ticketsCount = true;
                }
                if (ticketsCount)
                {
                    MessageBox.Show("Sorry Available Tickets Are " + tickets + " ... !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    FlightsDataBL flight = new FlightsDataBL(name, time, route, price, userTickets);
                    UserFlightsBL userFlight = new UserFlightsBL(userTickets, flight);
                    int count = 0;
                    for (int x = 0; x < User.UserFlights.Count; x++)
                    {
                        if (name == User.UserFlights[x].FlightName)
                        {
                            int addTickets = int.Parse(txtbx_Quantity.Text) + int.Parse(User.UserFlights[x].Tickets);
                            User.UserFlights[x].Tickets = addTickets + "";
                            count = 1;
                        }
                    }
                    if (count == 0)
                    {
                        User.addUserFlight(userFlight);
                    }
                    if (int.Parse(txtbx_Quantity.Text) > 1)
                    {
                        CustomerDL.addUser(User);
                        FlightsDataDL.Flights[flightIndex].FlightTickets = int.Parse(FlightsDataDL.Flights[flightIndex].FlightTickets) - int.Parse(txtbx_Quantity.Text) + "";
                        MessageBox.Show("Tickets Bought Successfully, Have A Safe Journey ... !", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    else if (int.Parse(txtbx_Quantity.Text) == 1)
                    {
                        CustomerDL.addUser(User);
                        FlightsDataDL.Flights[flightIndex].FlightTickets = int.Parse(FlightsDataDL.Flights[flightIndex].FlightTickets) - int.Parse(txtbx_Quantity.Text) + "";
                        MessageBox.Show("Ticket Bought Successfully, Have A Safe Journey ... !", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                }
            }
        }

        private void btn_Proceed_Click(object sender, EventArgs e)
        {
            if(txtbx_Quantity.Text == "")
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
                    string priceS = listView_Flights.SelectedItems[0].SubItems[2].Text;
                    int amount = int.Parse(priceS) * int.Parse(txtbx_Quantity.Text);
                    lbl_Amount.Text = amount + " $";
                }
                
            }
        }

        public static void passUser(CustomerBL user)
        {
            User = user;
        }

        
    }
}
