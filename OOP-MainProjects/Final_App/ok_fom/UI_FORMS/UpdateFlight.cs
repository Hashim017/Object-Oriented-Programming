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
    public partial class UpdateFlight : Form
    {
        public UpdateFlight()
        {
            InitializeComponent();
        }

        private void UpdateFlight_Load(object sender, EventArgs e)
        {
            listView_Flights.Columns.Add("Flight Name", 100);
            listView_Flights.Columns.Add("Flight Time", 100);
            listView_Flights.Columns.Add("Flight Price", 90);
            listView_Flights.Columns.Add("Flight Route", 165);
            listView_Flights.Columns.Add("Flight Tickets", 100);

            for (int x = 0; x < FlightsDataDL.Flights.Count; x++)
            {
                string name = FlightsDataDL.Flights[x].FlightName;
                string time = FlightsDataDL.Flights[x].FlightTime;
                string price = FlightsDataDL.Flights[x].FlightPrice;
                string route = FlightsDataDL.Flights[x].FlightRoute;
                string tickets = FlightsDataDL.Flights[x].FlightTickets;
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
            if (listView_Flights.SelectedItems.Count > 0)
            {
                txtbx_FlightName.Text = listView_Flights.SelectedItems[0].SubItems[0].Text;
                txtbx_FlightTime.Text = listView_Flights.SelectedItems[0].SubItems[1].Text;
                txtbx_FlightPrice.Text = listView_Flights.SelectedItems[0].SubItems[2].Text;
                txtbx_FlightRoute.Text = listView_Flights.SelectedItems[0].SubItems[3].Text;
                txtbx_TicketsQuantity.Text = listView_Flights.SelectedItems[0].SubItems[4].Text;
            }
        }

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

        // update selected flight data

        private void btn_Update_Click(object sender, EventArgs e)
        {
            int test = 0;

            if (txtbx_FlightName.Text == "" || txtbx_FlightTime.Text == "" || txtbx_FlightPrice.Text == "" || txtbx_FlightRoute.Text == "" || txtbx_TicketsQuantity.Text == "")
            {
                MessageBox.Show("Flight Information Is Missing ... !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                for (int x = 0; x < FlightsDataDL.Flights.Count; x++)
                {
                    if (FlightsDataDL.Flights[x].FlightName == txtbx_FlightName.Text)
                    {
                        test = x;
                        break;
                    }
                }
                if (!checkvalid(txtbx_FlightPrice.Text) || !checkvalid(txtbx_TicketsQuantity.Text))
                {
                    MessageBox.Show("Invalid Entered Price Or Tickets Quantity... !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    listView_Flights.SelectedItems[0].SubItems[0].Text = txtbx_FlightName.Text;
                    listView_Flights.SelectedItems[0].SubItems[1].Text = txtbx_FlightTime.Text;
                    listView_Flights.SelectedItems[0].SubItems[2].Text = txtbx_FlightPrice.Text;
                    listView_Flights.SelectedItems[0].SubItems[3].Text = txtbx_FlightRoute.Text;
                    listView_Flights.SelectedItems[0].SubItems[4].Text = txtbx_TicketsQuantity.Text;

                    FlightsDataDL.Flights[test].FlightName = txtbx_FlightName.Text;
                    FlightsDataDL.Flights[test].FlightTime = txtbx_FlightTime.Text;
                    FlightsDataDL.Flights[test].FlightPrice = txtbx_FlightPrice.Text;
                    FlightsDataDL.Flights[test].FlightRoute = txtbx_FlightRoute.Text;
                    FlightsDataDL.Flights[test].FlightTickets = txtbx_TicketsQuantity.Text;

                    MessageBox.Show("Flight Updated Successfully ... !", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.None);

                }

            }
        }
    }
}
