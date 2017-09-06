using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class TupleDemo
    {
        static void Main(string[] args)
        {
            var t1 = Tuple.Create("abc", "bbc");

            Tuple<int,double> t2 = Tuple.Create(10,10.20);

        }
    }
}
