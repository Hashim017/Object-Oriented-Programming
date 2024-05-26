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
    public partial class RemoveFlight : Form
    {
        public RemoveFlight()
        {
            InitializeComponent();
        }

        private void RemoveFlight_Load(object sender, EventArgs e)
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

        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            string test = listView_Flights.SelectedItems[0].SubItems[0].Text;
            listView_Flights.SelectedItems[0].SubItems.Clear();
            for(int x = 0; x < FlightsDataDL.Flights.Count; x++)
            {
                if (FlightsDataDL.Flights[x].FlightName == test)
                {
                    FlightsDataDL.Flights.RemoveAt(x);
                }
            }

            MessageBox.Show("Flight Removed Successfully ... !", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
    }
}
