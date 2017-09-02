using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class dynamicdemo
    {
        public static void Main()
        {
            dynamic objref;

            objref = new Person { Name = "Scott", Age = 55 };
            Console.WriteLine(objref.Name);


            objref = new Time { Hours = 10, Mins = 10, Secs = 20 };
            Console.WriteLine(objref.Hours);

            Console.WriteLine(objref.Hour);  // Runtime Error 

        }
    }
}
