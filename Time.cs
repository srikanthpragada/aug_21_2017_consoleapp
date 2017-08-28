using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Time
    {
        /*
        private int hours;

        public int Hours
        {
            get
            {
                return hours;
            }
            set
            {
                hours = value; 
            }
        }
        */

        // Automatically implmented property
        public int Hours { get; set; }
        public int Mins { get; set; }
        public int Secs { get; set; }
        public int TotalSeconds
        {
            get
            {
                return Hours * 3600 + Mins * 60 + Secs;
            }
        }
    }

    class TestTime
    {
        public static void Main()
        {
            // Object initialization 
            Time t1 = new Time { Hours = 10};
            Time t2 = new Time { Hours = 1, Mins = 1, Secs = 1 };

            Console.WriteLine("{0}:{1}:{2}", t1.Hours, t1.Mins, t1.Secs);



        }
    }
}
