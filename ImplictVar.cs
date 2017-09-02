using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class ImplictVar
    {
        public static void Main()
        {
     
            var prices = new int[] { 10, 20, 30 };

            var time = new Time { Hours = 10, Mins = 10, Secs = 20 };

            var person = new { Name = "Bill", Age = 60 };  // Anonymous Type 
            
            // String interpolation 
            Console.WriteLine( $"Name = {person.Name}, Age  = {person.Age}");








        }
    }
}
