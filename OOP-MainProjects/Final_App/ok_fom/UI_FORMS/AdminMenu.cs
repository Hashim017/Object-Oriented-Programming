using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace ok_fom
{
    public partial class AdminMenu : Form
    {
        bool sideBarExpand;
        static string Username;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nleftRect, int nTopRect, int nightRect, int nBottomRect, int widthEllipse, int neightEllipse);


        public AdminMenu()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            
        }

        public static void passUsername(string username)
        {
            Username = username;
        }

        private void btn_AddFlight_Click(object sender, EventArgs e)
        {
            btn_AddFlight.BackColor = Color.FromArgb(46, 51, 73);

            lbl_Title.Text = "Add Flight";
            this.pnl_FormLoader.Controls.Clear();
            AddFlight flight = new AddFlight() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            flight.FormBorderStyle = FormBorderStyle.None;
            this.pnl_FormLoader.Controls.Add(flight);
            flight.Show();
        }

        private void btn_ViewFlights_Click(object sender, EventArgs e)
        {
            btn_ViewFlights.BackColor = Color.FromArgb(46, 51, 73);
            
            lbl_Title.Text = "View Flights";
            this.pnl_FormLoader.Controls.Clear();
            ViewFlights flight = new ViewFlights() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            flight.FormBorderStyle = FormBorderStyle.None;
            this.pnl_FormLoader.Controls.Add(flight);
            flight.Show();
        }

        private void btn_RemoveFlight_Click(object sender, EventArgs e)
        {
            btn_RemoveFlight.BackColor = Color.FromArgb(46, 51, 73);

            lbl_Title.Text = "Remove" +
                " Flights";
            this.pnl_FormLoader.Controls.Clear();
            RemoveFlight flight = new RemoveFlight() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            flight.FormBorderStyle = FormBorderStyle.None;
            this.pnl_FormLoader.Controls.Add(flight);
            flight.Show();
        }

        private void btn_AddFlight_Leave(object sender, EventArgs e)
        {
            btn_AddFlight.BackColor = Color.FromArgb(35, 40, 45);
        }

        private void btn_RemoveFlight_Leave(object sender, EventArgs e)
        {
            btn_RemoveFlight.BackColor = Color.FromArgb(35, 40, 45);
        }

        private void btn_ViewFlights_Leave(object sender, EventArgs e)
        {
            btn_ViewFlights.BackColor = Color.FromArgb(35, 40, 45);
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

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_username.Text = Username;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void updateFlightTimer_Tick(object sender, EventArgs e)
        {
            
        }

        private void btn_UpdateFlight_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_UpdateFlight_Leave(object sender, EventArgs e)
        {
            btn_UpdateFlight.BackColor = Color.FromArgb(35, 40, 45);
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage page = new MainPage();
            page.Show();
        }

        private void txtbx_Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_ConfirmPassword_Click(object sender, EventArgs e)
        {

        }

        private void txtbx_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbx_ConfirmPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_CLear_Click(object sender, EventArgs e)
        {
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Password_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Username_Click(object sender, EventArgs e)
        {

        }

        private void lbl_LoginMenu_Click(object sender, EventArgs e)
        {

        }

        private void pnl_FormLoader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_UpdateFlight_Click_1(object sender, EventArgs e)
        {
            btn_UpdateFlight.BackColor = Color.FromArgb(46, 51, 73);

            lbl_Title.Text = "Update Flights";
            this.pnl_FormLoader.Controls.Clear();
            UpdateFlight flight = new UpdateFlight() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            flight.FormBorderStyle = FormBorderStyle.None;
            this.pnl_FormLoader.Controls.Add(flight);
            flight.Show();

        }

        private void btn_UpdateFlight_Leave_1(object sender, EventArgs e)
        {
            btn_UpdateFlight.BackColor = Color.FromArgb(35, 40, 45);
        }

        private void btn_AddAdmin_Click(object sender, EventArgs e)
        {
            btn_UpdateFlight.BackColor = Color.FromArgb(46, 51, 73);

            lbl_Title.Text = "Add Admin";
            this.pnl_FormLoader.Controls.Clear();
            AddAdmin flight = new AddAdmin() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            flight.FormBorderStyle = FormBorderStyle.None;
            this.pnl_FormLoader.Controls.Add(flight);
            flight.Show();
        }

        private void btn_ViewAdmins_Click(object sender, EventArgs e)
        {
            btn_UpdateFlight.BackColor = Color.FromArgb(46, 51, 73);

            lbl_Title.Text = "View Admins";
            this.pnl_FormLoader.Controls.Clear();
            ViewAdmins flight = new ViewAdmins() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            flight.FormBorderStyle = FormBorderStyle.None;
            this.pnl_FormLoader.Controls.Add(flight);
            flight.Show();
        }

        private void btn_UpdateAdmins_Click(object sender, EventArgs e)
        {
            btn_UpdateFlight.BackColor = Color.FromArgb(46, 51, 73);

            lbl_Title.Text = "View Admins";
            this.pnl_FormLoader.Controls.Clear();
            UpdateAdmin flight = new UpdateAdmin() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            flight.FormBorderStyle = FormBorderStyle.None;
            this.pnl_FormLoader.Controls.Add(flight);
            flight.Show();
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
    }
}
