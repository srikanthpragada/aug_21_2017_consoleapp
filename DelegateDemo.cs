using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class DelegateDemo
    {
        delegate void PrintDelegate(string s);

        static void Main(string[] args)
        {
            Action a1 = new Action(Print);
            a1();

            Action<string> a2 = Display;  // Method group conversion 
            a2("Second Delegate");

            Action<string> a3 =
                delegate (string msg)
                {
                   Console.WriteLine(msg);
                };

            a3("Anonymous Method");

            Action<string> a4 = (string s) => Console.WriteLine(s);
            a4("Lambda Expression");

            Action<string> a5 = (string s) =>
                {
                    for (int i = 1; i <= 5; i++)
                        Console.WriteLine(s);
                };

            a5("Lambda");
        }

        public static void Print()
        {
            Console.WriteLine("In Print()");
        }

        public static void Display(string message)
        {
            Console.WriteLine(message);
        }
    }
}
