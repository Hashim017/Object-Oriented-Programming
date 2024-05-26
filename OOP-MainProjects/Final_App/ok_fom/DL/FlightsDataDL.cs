using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ok_fom
{
    class FlightsDataDL
    {
        public static List<FlightsDataBL> Flights = new List<FlightsDataBL>();

        public static void addFlight(FlightsDataBL flight)
        {
            Flights.Add(flight);
        }

        // check if flight information is valid

        public static FlightsDataBL checkFlight(string name)
        {
            FlightsDataBL dummy = new FlightsDataBL("undefined", "undefined", "undefined", "undefined", "undefined");
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

        // store all flights data into file

        public static void storeFlights()
        {
            StreamWriter file = new StreamWriter("FlightsData.txt");
            for (int x = 0; x < Flights.Count; x++)
            {
                file.Write(Flights[x].FlightName + "," + Flights[x].FlightTime + "," + Flights[x].FlightRoute + "," + Flights[x].FlightPrice + "," + Flights[x].FlightTickets);
                file.WriteLine();

            }
            file.Close();
        }

        // load all flights data from file

        public static void loadFlights()
        {
            string record = "";

            StreamReader file = new StreamReader("FlightsData.txt");
            while ((record = file.ReadLine()) != null)
            {
                string flightName = (findData(record, 1));
                string flightTime = (findData(record, 2));
                string flightRoute = (findData(record, 3));
                string flightPrice = (findData(record, 4));
                string flightTickets = (findData(record, 5));
                FlightsDataBL flight = new FlightsDataBL(flightName, flightTime, flightRoute, flightPrice, flightTickets);
                addFlight(flight);
            }
            file.Close();
        }

        static string findData(string record, int field)
        {
            int comma = 1;
            string item = "";

            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    comma++;
                }

                else if (comma == field)
                {
                    item = item + record[x];
                }
            }
            return item;
        }
    }
}
