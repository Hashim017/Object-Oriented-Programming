using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class MountainBike : Bicycle
    {
        protected int seatHeight;

        public MountainBike(int height, int cadence, int speed, int gear) : base(cadence, speed, gear)
        {
            seatHeight = height;
        }

        public void setSeatHeight(int seatHeight)
        {
            this.seatHeight = seatHeight;
        }
    }
}
