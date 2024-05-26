using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Bicycle
    {
        protected int Cadence;
        protected int Gear;
        protected int Speed;

        public Bicycle(int cadence, int gear, int speed)
        {
            Cadence = cadence;
            Gear = gear;
            Speed = speed;
        }

        public void setCadence(int cadence)
        {
            Cadence = cadence;
        }

        public void setGear(int gear)
        {
            Gear = gear;
        }

        public void applyBrake(int decrement)
        {
            Speed = Speed - decrement;
        }

        public void speedUp(int increment)
        {
            Speed = Speed + increment;
        }
    }
}
