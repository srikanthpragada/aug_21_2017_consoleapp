using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class FormatDemo
    {
        static void Main(string[] args)
        {
            var price = 3928911;

            Console.WriteLine("{0:c}", price);
            Console.WriteLine( String.Format("{0:c}",price));
            Console.WriteLine( price.ToString("c"));

            Console.WriteLine("{0:#######.00}", price);

            DateTime now = DateTime.Now;
            Console.WriteLine("{0:F}", now);
            Console.WriteLine("{0:dd-MM-yyyy HH:mm:ss}", now);

            CultureInfo incu = new System.Globalization.CultureInfo("fr-fr");
            Thread.CurrentThread.CurrentCulture = incu;

            Console.WriteLine("{0:d}", now);



        }
    }
}
