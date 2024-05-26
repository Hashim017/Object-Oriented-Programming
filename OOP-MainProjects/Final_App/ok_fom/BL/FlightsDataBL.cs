using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ok_fom
{
    class FlightsDataBL
    {
        public string FlightName;
        public string FlightTime;
        public string FlightRoute;
        public string FlightPrice;
        public string FlightTickets;

        public FlightsDataBL(string name, string time, string route, string price, string tickets)
        {
            FlightName = name;
            FlightTime = time;
            FlightRoute = route;
            FlightTickets = tickets;
            FlightPrice = price;
        }

        public FlightsDataBL(string name, string time, string route, string price)
        {
            FlightName = name;
            FlightTime = time;
            FlightRoute = route;
            FlightPrice = price;
            FlightTickets = "0";
        }
    }
}

