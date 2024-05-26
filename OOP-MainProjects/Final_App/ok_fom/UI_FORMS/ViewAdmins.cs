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
    public partial class ViewAdmins : Form
    {
        public ViewAdmins()
        {
            InitializeComponent();
        }

        private void ViewAdmins_Load(object sender, EventArgs e)
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

        public void addIntoViewList(string username, string password)
        {
            ListViewItem item = new ListViewItem(username);
            item.SubItems.Add(password);
            listView_Admins.Items.Add(item);
        }
    }
}
