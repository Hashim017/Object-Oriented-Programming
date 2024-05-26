using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD___3__App_
{
    class flightrecords
    {

        public string flightName;
        public int flightPrice;
        public string flightTime;
        public int flightQuantity;


        public void updateTime(string time)
        {
            flightTime = time;
        }

        public void cancelFlight()
        {
            flightName = "!";
        }

        public void addTickets(int tickets)
        {
            flightQuantity = flightQuantity + tickets;
        }

        public flightrecords(string name, int price, string time, int quantity)
        {
            flightName = name;
            flightPrice = price;
            flightTime = time;
            flightQuantity = quantity;
        }

    }
}
