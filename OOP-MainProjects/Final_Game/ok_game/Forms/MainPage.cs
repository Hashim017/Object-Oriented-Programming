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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btn_StartGame_Click(object sender, EventArgs e)
        {
            Game.counter = 0;
            Level1 level = new Level1();
            level.startGame();
            level.Show();
        }

        private void btn_LoadGame_Click(object sender, EventArgs e)
        {
            Level1 level = new Level1();
            level.loadData();
            level.Show();
        }

        private void btn_Instructions_Click(object sender, EventArgs e)
        {
            Instructions inst = new Instructions();
            inst.Show();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks For Playing Game ... !", "THANK YOU", MessageBoxButtons.OK, MessageBoxIcon.None);
            this.Close();
        }
    }
}
