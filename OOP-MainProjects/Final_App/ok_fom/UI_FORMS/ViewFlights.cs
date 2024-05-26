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
    public partial class ViewFlights : Form
    {
        public ViewFlights()
        {
            InitializeComponent();
        }

        private void lbl_FName_Click(object sender, EventArgs e)
        {

        }

        private void ViewFlights_Load(object sender, EventArgs e)
        {
            listView_Flights.Clear();

            listView_Flights.Columns.Add("Flight Name", 100);
            listView_Flights.Columns.Add("Flight Time", 100);
            listView_Flights.Columns.Add("Flight Price", 90);
            listView_Flights.Columns.Add("Flight Route", 165);
            listView_Flights.Columns.Add("Flight Tickets", 100);

            for(int x = 0; x < FlightsDataDL.Flights.Count; x++)
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

        public void addIntoViewList(string name, string time, string price, string route, string tickets)
        {
            ListViewItem item = new ListViewItem(name);
            item.SubItems.Add(time);
            item.SubItems.Add(price);
            item.SubItems.Add(route);
            item.SubItems.Add(tickets);
            listView_Flights.Items.Add(item);
        }

        private void txtbx_FlightRoute_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbx_TicketsQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {

        }

        private void lbl_TicketsQuantity_Click(object sender, EventArgs e)
        {

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

        private void listView_Flights_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_FlightAdd_Click(object sender, EventArgs e)
        {

        }

        private void lbl_FlightPrice_Click(object sender, EventArgs e)
        {

        }

        private void lbl_FlightName_Click(object sender, EventArgs e)
        {

        }
    }
}
