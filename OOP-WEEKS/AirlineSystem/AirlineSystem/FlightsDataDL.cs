using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineSystem
{
    class FlightsDataDL
    {
        public static List<FlightsDataBL> Flights = new List<FlightsDataBL>();

        public static void addFlight(FlightsDataBL flight)
        {
            Flights.Add(flight);
        }

        public static FlightsDataBL checkFlight(int num)
        {
            FlightsDataBL dummy = new FlightsDataBL("undefined", "undefined", "undefined", 0, 0);
            for (int x = 0; x < Flights.Count; x++)
            {
                if(num - 1 == x)
                {
                    dummy = Flights[x];
                    break;
                }
            }
            return dummy;
        }

        public static FlightsDataBL checkFlight(string name)
        {
            FlightsDataBL dummy = new FlightsDataBL("undefined", "undefined", "undefined", 0, 0);
            for (int x = 0; x < Flights.Count; x++)
            {
                if (name == Flights[x].FlightName)
                {
                    dummy = Flights[x];
                    break;
                }
            }
            return dummy;
        }

        public static bool checkValidity(int num)
        {
            bool test = false;
            if(num <= Flights.Count && num > 0)
            {
                test = true;
            }
            return test;
        }

        public static void updatePrice(FlightsDataBL flight, double price)
        {
            flight.FlightPrice = price;   
        }
        public static void updateTime(FlightsDataBL flight, string time)
        {
            flight.FlightTime = time;
        }
        public static void updateRoute(FlightsDataBL flight, string route)
        {
            flight.FlightRoute = route;
        }

        public static void updateQuantity(FlightsDataBL flight, int quantity)
        {
            flight.FlightTickets = flight.FlightTickets + quantity;
        }

        public static void cancelFlight(int num)
        {
            Flights.RemoveAt(num - 1);
        }

        public static void decrementTickets(int tickets, FlightsDataBL flight)
        {
            flight.FlightTickets = flight.FlightTickets - tickets;
        }

        public static void incrementTickets(int tickets, FlightsDataBL flight)
        {
            flight.FlightTickets = flight.FlightTickets + tickets;
        }

        public static bool checkTickets(int tickets, FlightsDataBL flight)
        {
            bool check = false;
            if(tickets <= flight.FlightTickets)
            {
                check = true;
            }
            return check;
        }
    }
}
