using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class AverageOfNumbers
    {
         public static void Main()
        {
            int sum = 0, count = 0;

            while(true)
            {
                Console.Write("Enter a number [0 to stop] :");
                try
                {
                    int num = Int32.Parse(Console.ReadLine());

                    if (num == 0)
                        break;

                    count++;
                    sum += num;
                }
                catch(FormatException ex)
                {
                    Console.WriteLine("Invalid Number!");
                }
                finally
                {
                    Console.WriteLine("Done");
                }
            }

            Console.WriteLine("Average : {0}", sum / count);


        }
    }
}
