using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class DateDemo
    {
        public static void Main()
        {
            DateTime ct = DateTime.Now;
            DateTime et = ct.AddDays(30);

            Console.WriteLine(et);

            TimeSpan  period = et.Subtract(ct);

            Console.WriteLine(period.Days);

            DateTime boy = DateTime.Parse("1/1/2017");
            TimeSpan days = ct.Subtract(boy);
            Console.WriteLine(days.ToString());
                


        }
    }
}
