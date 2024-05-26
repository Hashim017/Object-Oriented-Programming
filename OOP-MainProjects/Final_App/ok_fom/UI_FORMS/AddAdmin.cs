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
    public partial class AddAdmin : Form
    {
        public AddAdmin()
        {
            InitializeComponent();
        }

        private void btn_AddAdmin_Click(object sender, EventArgs e)
        {
            if (txtbx_Username.Text == "" || txtbx_Password.Text == "")
            {
                MessageBox.Show("Username Or Password Is Missing ... !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                string username = txtbx_Username.Text;
                string password = txtbx_Password.Text;
                AdminBL admin = new AdminBL(username,password);
                bool test = AdminDL.checkAdmin(admin);
                if(test)
                {
                    MessageBox.Show("Credentials Already Exists, Try Different Username Or Password ... !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    AdminDL.addAdmin(admin); 
                    MessageBox.Show("Credentials Added Successfully ... !", "Congratualtions", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void btn_CLear_Click(object sender, EventArgs e)
        {
            txtbx_Username.Text = "";
            txtbx_Password.Text = "";
            txtbx_Username.Focus();
        }

        private void AddAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
