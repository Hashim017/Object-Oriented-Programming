using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineSystem
{
    class FlightsDataBL
    {
        public string FlightName { get; set; }
        public string FlightTime { get; set; }
        public string FlightRoute { get; set; }
        public double FlightPrice { get; set; }
        public int FlightTickets { get; set; }

        public FlightsDataBL(string name, string time, string route, double price, int tickets)
        {
            FlightName = name;
            FlightTime = time;
            FlightRoute = route;
            FlightTickets = tickets;
            FlightPrice = price;
        }
    }
}
