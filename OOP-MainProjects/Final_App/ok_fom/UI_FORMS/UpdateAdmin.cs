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
    public partial class UpdateAdmin : Form
    {
        public UpdateAdmin()
        {
            InitializeComponent();
        }

        private void UpdateAdmin_Load(object sender, EventArgs e)
        {
            listView_Admins.Columns.Add("Username", 100);
            listView_Admins.Columns.Add("Password", 100);


            for (int x = 0; x < AdminDL.AllAdmins.Count; x++)
            {
                string username = AdminDL.AllAdmins[x].Username;
                string password = AdminDL.AllAdmins[x].Password;

                ListViewItem item = new ListViewItem(username);
                item.SubItems.Add(password);
                listView_Admins.Items.Add(item);
            }
        }

        private void listView_Admins_Click(object sender, EventArgs e)
        {
            if (listView_Admins.SelectedItems.Count > 0)
            {
                txtbx_Username.Text = listView_Admins.SelectedItems[0].SubItems[0].Text;
                txtbx_Password.Text = listView_Admins.SelectedItems[0].SubItems[1].Text;
            }
        }

        // update selected admin credentials

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (txtbx_Username.Text == "" || txtbx_Password.Text == "")
            {
                MessageBox.Show("Username Or Password Is Missing ... !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                int test = 0;
                for(int x = 0; x< AdminDL.AllAdmins.Count; x++)
                {
                    if (AdminDL.AllAdmins[x].Username == txtbx_Username.Text)
                    {
                        test = x;
                        break;
                    }
                }
                listView_Admins.SelectedItems[0].SubItems[0].Text = txtbx_Username.Text;
                listView_Admins.SelectedItems[0].SubItems[1].Text = txtbx_Password.Text;

                AdminDL.AllAdmins[test].Username = txtbx_Username.Text;
                AdminDL.AllAdmins[test].Password = txtbx_Password.Text;
                MessageBox.Show("Credentials Updated Successfully ... !", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.None);

            }
        }
    }
}
