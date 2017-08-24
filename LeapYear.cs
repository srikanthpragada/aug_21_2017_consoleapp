using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class LeapYear
    {
        static void Main()
        {
            int year;


            Console.Write("Enter year : ");
            year =  Int32.Parse(Console.ReadLine());

            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                Console.WriteLine("Leap Year");
            else
                Console.WriteLine("Not a leap year");
        }
    }
}
