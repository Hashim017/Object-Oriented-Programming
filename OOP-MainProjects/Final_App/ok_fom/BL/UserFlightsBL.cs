using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ok_fom
{
    class UserFlightsBL : FlightsDataBL
    {
        public string Tickets;

        public UserFlightsBL(string tickets, FlightsDataBL flight) : base(flight.FlightName, flight.FlightTime, flight.FlightRoute, flight.FlightPrice, flight.FlightTickets)
        {
            Tickets = tickets;
        }
    }
}
