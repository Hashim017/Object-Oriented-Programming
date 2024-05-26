using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ok_fom
{
    class CustomerBL : PersonBL
    {
        public List<UserFlightsBL> UserFlights;

        public CustomerBL(string name, string pass)
        {
            Username = name;
            Password = pass;
            UserFlights = new List<UserFlightsBL>();
        }

        public CustomerBL(string name, string pass, UserFlightsBL user)
        {
            Username = name;
            Password = pass;
            UserFlights.Add(user);
        }

        public void addUserFlight(UserFlightsBL flight)
        {
            UserFlights.Add(flight);
        }
    }
}
