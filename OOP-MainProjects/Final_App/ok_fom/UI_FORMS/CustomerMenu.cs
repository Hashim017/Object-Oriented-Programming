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
    public partial class CustomerMenu : Form
    {
        static string Username;
        bool sideBarExpand;

        public CustomerMenu()
        {
            InitializeComponent();
        }

        public static void passUsename(string username)
        {
            Username = username;
        }

        private void CustomerMenu_Load(object sender, EventArgs e)
        {
            lbl_username.Text = Username;
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            sideBarTimer.Start();
        }

        // timer for side menu bar expander 

        private void sideBarTimer_Tick(object sender, EventArgs e)
        {

            if (sideBarExpand)
            {
                pnl_MenuContainer.Width -= 10;
                if (pnl_MenuContainer.Width == pnl_MenuContainer.MinimumSize.Width)
                {
                    sideBarExpand = false;
                    sideBarTimer.Stop();
                }
            }
            else
            {
                pnl_MenuContainer.Width += 10;
                if (pnl_MenuContainer.Width == pnl_MenuContainer.MaximumSize.Width)
                {
                    sideBarExpand = true;
                    sideBarTimer.Stop();
                }
            }
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage page = new MainPage();
            page.Show();
        }

        private void btn_SearchFlight_Click(object sender, EventArgs e)
        {
            btn_SearchFlight.BackColor = Color.FromArgb(46, 51, 73);

            lbl_Title.Text = "Search Flight";
            this.pnl_FormLoader.Controls.Clear();
            SearchFlight flight = new SearchFlight() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            flight.FormBorderStyle = FormBorderStyle.None;
            this.pnl_FormLoader.Controls.Add(flight);
            flight.Show();
        }

        private void btn_ViewBoughtFlights_Click(object sender, EventArgs e)
        {
            btn_SearchFlight.BackColor = Color.FromArgb(46, 51, 73);

            lbl_Title.Text = "View Flights";
            this.pnl_FormLoader.Controls.Clear();
            ViewUserFlights flight = new ViewUserFlights() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            flight.FormBorderStyle = FormBorderStyle.None;
            this.pnl_FormLoader.Controls.Add(flight);
            flight.Show();
        }

        private void pnl_MenuContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_UpdateFlight_Click(object sender, EventArgs e)
        {
            btn_SearchFlight.BackColor = Color.FromArgb(46, 51, 73);

            lbl_Title.Text = "Refund Tickets";
            this.pnl_FormLoader.Controls.Clear();
            RefundTickets flight = new RefundTickets() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            flight.FormBorderStyle = FormBorderStyle.None;
            this.pnl_FormLoader.Controls.Add(flight);
            flight.Show();
        }

        private void pnl_FormLoader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_About_Click(object sender, EventArgs e)
        {
            btn_About.BackColor = Color.FromArgb(46, 51, 73);

            lbl_Title.Text = "About Us";
            this.pnl_FormLoader.Controls.Clear();
            AboutUs about = new AboutUs() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            about.FormBorderStyle = FormBorderStyle.None;
            this.pnl_FormLoader.Controls.Add(about);
            about.Show();
        }

        private void btn_Help_Click(object sender, EventArgs e)
        {
            btn_Help.BackColor = Color.FromArgb(46, 51, 73);

            lbl_Title.Text = "Help";
            this.pnl_FormLoader.Controls.Clear();
            Help help = new Help() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            help.FormBorderStyle = FormBorderStyle.None;
            this.pnl_FormLoader.Controls.Add(help);
            help.Show();
        }
    }
}
