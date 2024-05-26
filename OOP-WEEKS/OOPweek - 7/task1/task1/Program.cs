using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            DayScholar std = new DayScholar();
            std.name = "Ahmad";
            std.busNo = 1;
            Console.WriteLine(std.name + " is Allocated Bus " + std.busNo) ;
            Console.ReadKey() ;

            Hostalite st = new Hostalite();
            st.name = "Ahmad";
            st.RoomNumber = 12;
            Console.WriteLine(st.name + " is Allocated Room " + st. RoomNumber);
            Console.ReadKey() ;

        }
    }
}
