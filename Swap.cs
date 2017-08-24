using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class SwapDemo
    {
        public static void Main()
        {

            int n1 = 10, n2 = 20;

            Swap(ref n1, ref n2);  // Pass by reference 

            Console.WriteLine("{0} {1}", n1, n2);
        }

        public static void Swap(ref int v1, ref int v2)
        {
            int temp = v1;
            v1 = v2;
            v2 = temp; 
        }
    }
}
