using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ship_task.BL
{
    class Angle
    {
        public int latDegrees;
        public float latMinutes;
        public char latDirection;
        public int lonDegrees;
        public float lonMinutes;
        public char lonDirection;

        public Angle(int latdegrees, float latminutes, char latdirection, int londegrees, float lonminutes, char londirection)
        {
            latDegrees = latdegrees;
            latMinutes = latminutes;
            latDirection = latdirection;
            lonDegrees = londegrees;
            lonMinutes = lonminutes;
            lonDirection = londirection;
        }

        public void changeAngle(int latdegrees, float latminutes, char latdirection, int londegrees, float lonminutes, char londirection)
        {
            latDegrees = latdegrees;
            latMinutes = latminutes;
            latDirection = latdirection;
            lonDegrees = londegrees;
            lonMinutes = lonminutes;
            lonDirection = londirection;
        }

        public void displayAngle()
        {
            Console.Write("Ship Latitude: ");
            Console.WriteLine(latDegrees + "\u00b0" + latMinutes + "'" + latDirection);
            Console.Write("Ship Longitude: ");
            Console.WriteLine(lonDegrees + "\u00b0" + lonMinutes + "'" + lonDirection);
        }

        public Angle()
        {

        }

    }
}
