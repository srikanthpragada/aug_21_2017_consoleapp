using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class SwitchDemo
    {
        public static void Main()
        {
            int code = 1;


            switch(code)
            {
                case 1: Console.WriteLine("First"); break;
                case 2:
                case 3: Console.WriteLine("Second");
                        goto case 4;
                case 4: Console.WriteLine("Second"); break;
            }
        } 
    }
}
