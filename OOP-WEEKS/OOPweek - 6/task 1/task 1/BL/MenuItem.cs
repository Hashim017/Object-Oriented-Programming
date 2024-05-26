using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    class MenuItem
    {
        public string ItemName;
        public string ItemType;
        public int ItemPrice;

        public MenuItem()
        {

        }

        public MenuItem(string itemname, string itemtype, int itemprice)
        {
            ItemName = itemname;
            ItemType = itemtype;
            ItemPrice = itemprice;
        }

        
    }
}
