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
    public partial class LoadingPage : Form
    {
        public LoadingPage()
        {
            InitializeComponent();
            pnl_Loading.Width = 0;
            this.Opacity = 0;
            label_Loading.Text = "";
        }
        int i = 0;
        private void timer_Loading_Tick(object sender, EventArgs e)
        {
            if(pnl_Loading.Width<282)
            {
                pnl_Loading.Width += 11;
                i += 4;
                label_Loading.Text = i +" %";
                this.Opacity += 10;
            }
            if(pnl_Loading.Width>=282)
            {
                this.Close();
            }
        }

        private void pnl_pictureContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label_Loading_Click(object sender, EventArgs e)
        {

        }

        private void pnl_Loading_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadingPage_Load(object sender, EventArgs e)
        {

        }
    }
}
