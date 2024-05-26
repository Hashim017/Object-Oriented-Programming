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
    partial class ViewUserFlights : Form
    {
        static CustomerBL User;
        public ViewUserFlights()
        {
            InitializeComponent();
        }

        private void ViewUserFlights_Load(object sender, EventArgs e)
        {
            listView_Flights.Clear();

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
        public static void passUser(CustomerBL user)
        {
            User = user;
        }
    }
}
