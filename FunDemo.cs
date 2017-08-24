using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class FunDemo
    {
        public static void Main()
        {
            Print("Hi"); //  Hi! World
            Print();
            Print("Hello", "Anders"); // positional parameter
            Print(m2 : "Anders");  // Named parameter 

            Console.WriteLine(Sum(10,20,30,40));
            Console.WriteLine(Sum(10, 20));
        }

        public static void Print(string m1 = "Hello", string m2 = "world" )
        {
            Console.WriteLine(m1 + " " + m2);
        }

        public static int Sum(params int [] values)
        {
            int sum = 0; 
            foreach(int v in values)
            {
                sum += v;
            }

            return sum; 
        }
    }
}
