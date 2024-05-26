using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class FireTrucks
    {
        public Ladder ladder;
        public FireFighter firefighter;

        public FireTrucks(int length, string clr, string name, int age)
        {
            ladder = new Ladder(length, clr);
            firefighter = new FireFighter(name, age);
        }
        
    }
}
