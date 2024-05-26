using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineSystem
{
    class UserFlightsBL : FlightsDataBL
    {
        public int Tickets { get; set; }

        public UserFlightsBL(int tickets, FlightsDataBL flight):base(flight.FlightName, flight.FlightTime, flight.FlightRoute, flight.FlightPrice, flight.FlightTickets)
        {
            Tickets = tickets;
        }
    }
}
