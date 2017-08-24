using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class SumOfDigits
    {
        public static void Main(string [] args)
        {

            int num = Int32.Parse(args[0]);
            int sum = 0;

            while (num > 0)
            {
                int d = num % 10;
                sum += d;
                num /= 10;
            }

            Console.WriteLine(sum);
        }
    }
}
