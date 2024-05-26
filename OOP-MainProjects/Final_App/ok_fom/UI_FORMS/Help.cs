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
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            if (txtbx_Firstname.Text == "" || txtbx_Lastname.Text == "" || txtbx_Email.Text == "" || txtbx_Moblie.Text == "" || txtbx_Message.Text == "")
            {
                MessageBox.Show("Information Is Missing ... !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                MessageBox.Show("Message Send Successfully ... !", "THANK YOU", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void txtbx_Message_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_TicketsQuantity_Click(object sender, EventArgs e)
        {

        }

        private void txtbx_Moblie_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Moblie_Click(object sender, EventArgs e)
        {

        }

        private void txtbx_Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Email_Click(object sender, EventArgs e)
        {

        }

        private void txtbx_Lastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbx_Firstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_lastname_Click(object sender, EventArgs e)
        {

        }

        private void lbl_FirstName_Click(object sender, EventArgs e)
        {

        }

        private void lbl_help_Click(object sender, EventArgs e)
        {

        }
    }
}
