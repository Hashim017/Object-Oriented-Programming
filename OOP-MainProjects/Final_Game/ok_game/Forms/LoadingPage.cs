using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ok_game
{
    public partial class LoadingPage : Form
    {
        public LoadingPage()
        {
            InitializeComponent();
        }

        private void LoadingPage_Load(object sender, EventArgs e)
        {
            pnl_Loading.Width = 0;
            this.Opacity = 0;
        }

        int i = 0;
        private void timer_Loading_Tick(object sender, EventArgs e)
        {
            if(pnl_Loading.Width < 314)
            {
                pnl_Loading.Width += 12;
                this.Opacity += 10;
                lbl_Percentage.Text = i + " %";
                i += 4;
            }
            if(pnl_Loading.Width>=314)
            {
                this.Close();
            }
        }

        private void pnl_Loading_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
