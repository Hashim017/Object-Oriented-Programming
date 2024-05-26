using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ship_task.BL
{
    class Ship
    {
        public string ShipNumber;
        public Angle Angles = new Angle();

        public Ship()
        {

        }

        public Ship(string number, Angle angles)
        {
            ShipNumber = number;
            Angles = angles;
        }

        public void printLocation()
        {

        }
    }

    
}
