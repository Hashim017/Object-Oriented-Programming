using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineSystem
{
    class UserFlightsDL
    {
        public static List<UserFlightsBL> UserFlights = new List<UserFlightsBL>();

        public static void addUserFlight(UserFlightsBL flight)
        {
            UserFlights.Add(flight);
        }

        public static UserFlightsBL checkFlight(UserFlightsBL flight)
        {
            FlightsDataBL dummy = new FlightsDataBL("undefined", "undefined", "undefined", 0, 0);
            UserFlightsBL dummyFlight = new UserFlightsBL(0, dummy);
            for(int x = 0; x < UserFlights.Count; x++)
            {
                if(UserFlights[x].FlightName == flight.FlightName)
                {
                    dummyFlight = UserFlights[x];
                    break;
                }
            }
            return dummyFlight;
        }

        public static bool checkValid(UserFlightsBL flight)
        {
            bool test = false;
            for (int x = 0; x < UserFlights.Count; x++)
            {
                if (UserFlights[x].FlightName == flight.FlightName)
                {
                    test = true;
                    break;
                }
            }
            return test;
        }

        public static void addTickets(int tickets, UserFlightsBL flight)
        {
            flight.Tickets = flight.Tickets + tickets;
        }

        public static void decrementBoughtTickets(int tickets, UserFlightsBL flight)
        {
            flight.Tickets = flight.Tickets - tickets;
        }

        public static bool checkValidity(int num)
        {
            bool test = false;
            if (num <= UserFlights.Count && num > 0)
            {
                test = true;
            }
            return test;
        }

        public static void removeUserFlight(int num, int tickets)
        {
            if(tickets <= 0)
            {
                UserFlights.RemoveAt(num - 1);
            }
        }

        public static bool checkBoughtTickets(int tickets, int boughtTickets)
        {
            bool test = true;
            if(tickets > boughtTickets)
            {
                test = false;
            }
            return test;
        }

        public static UserFlightsBL checkFlight(int num)
        {
            FlightsDataBL dummy = new FlightsDataBL("undefined", "undefined", "undefined", 0, 0);
            UserFlightsBL dummyFlight = new UserFlightsBL(0, dummy);
            for (int x = 0; x < UserFlights.Count; x++)
            {
                if (num - 1 == x)
                {
                    dummyFlight = UserFlights[x];
                    break;
                }
            }
            return dummyFlight;
        }

        public static void refundTickets(int tickets, UserFlightsBL flight)
        {
            flight.FlightTickets = flight.FlightTickets - tickets;
        }


    }
}
