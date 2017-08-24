using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Factorial
    {
        public static void Main()
        {

            Console.Write("Enter Number : ");
            int num  = Int32.Parse(Console.ReadLine());

            int fact = 1;
            for (int i = 2; i <= num; i++)
                fact *= i;

            Console.WriteLine("Factorial of {0} is {1}", num, fact);

        }
    }
}
