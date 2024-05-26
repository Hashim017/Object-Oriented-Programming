using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ok_fom
{
    class CustomerDL
    {
        public static List<CustomerBL> AllUsers = new List<CustomerBL>();

        public static void addUser(CustomerBL user)
        {
            AllUsers.Add(user);
        }
        
        // function for getting specific user

        public static CustomerBL getUser(string username, string pass)
        {
            CustomerBL user = null;
            for (int x = 0; x < AllUsers.Count; x++)
            {
                if (AllUsers[x].Username == username && AllUsers[x].Password == pass)
                {
                    user = AllUsers[x];
                }
            }
            return user;
        }

        // store all users credentials into file

        public static void storeUsers()
        {
            StreamWriter file = new StreamWriter("Users.txt");
            foreach (var f in AllUsers)
            {
                file.WriteLine(f.Username + "," + f.Password);
            }
            file.Close();
        }

        // load all users credentials from file

        public static void loadUsers()
        {
            string record = "";
            StreamReader data = new StreamReader("Users.txt");
            while ((record = data.ReadLine()) != null)
            {
                string username = (findData(record, 1));
                string password = (findData(record, 2));
                CustomerBL user = new CustomerBL(username, password);
                CustomerDL.addUser(user);
            }
            data.Close();
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

        // store user bought flights int file

        public static void storeUserFlights()
        {
            StreamWriter file = new StreamWriter("UserFlights.txt");
            foreach (var f in AllUsers)
            {
                foreach (var i in f.UserFlights)
                {
                    file.WriteLine(i.FlightName + "," + i.FlightTime + "," + i.FlightRoute + "," + i.FlightPrice + "," + i.Tickets);
                }
            }
            file.Close();
        }

        // load user bought flights from file

        public static void loadUserFlights()
        {
            string record = "";
            StreamReader data = new StreamReader("UserFlights.txt");
            while ((record = data.ReadLine()) != null)
            {
                string flightName = (findData(record, 1));
                string flightTime = (findData(record, 2));
                string flightRoute = (findData(record, 3));
                string flightPrice = (findData(record, 4));
                string userTickets = (findData(record, 5));
                FlightsDataBL flight = new FlightsDataBL(flightName, flightTime, flightRoute, flightPrice);
                UserFlightsBL userFlight = new UserFlightsBL(userTickets, flight);
                //User.addUserFlight(userFlight);
            }
            data.Close();
        }

        // check if user credentials are valid

        public static bool checkUser(CustomerBL user)
        {
            bool check = false;
            for (int x = 0; x < AllUsers.Count; x++)
            {
                if (AllUsers[x].Username == user.Username && AllUsers[x].Password == user.Password)
                {
                    check = true;
                }
            }
            return check;
        }
    }
}
