using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class UseDelegate
    {
        static void Main(string[] args)
        {
            string[] names = { "Bill Gates", "Larry Page", "Michael Dell", "Elon Musk", "Sergy Brin","Mark Zukerberg" };

            Person[] people = new Person[]
            {
                new Person { Name = "Bill", Age = 60},
                new Person { Name = "Steve", Age = 45},
                new Person { Name = "Mark", Age = 40},
                new Person { Name = "Ben", Age = 30},
            };

            Array.Sort(people, (p1, p2) => p1.Age - p2.Age);

            var selpeople = Array.FindAll(people, p => p.Age > 40);

            selpeople = Array.FindAll(people, p => p.Name.Contains("B"));

            foreach (Person p in selpeople)
            {
                   Console.WriteLine(p.ToString());
            }

            //Array.Sort(names);

            //foreach (string n in names)
            //    Console.WriteLine(n);


            // Array.Sort(names, new Comparison<string>(CompareByLength));
            // Array.Sort(names, CompareByLength);
            Array.Sort(names, (s1,s2) => s1.Length - s2.Length);

            //foreach (string n in names)
            //    Console.WriteLine(n);
        }

        public static int CompareByLength(string s1, string s2)
        {
            return s1.Length - s2.Length;
        }
    }
}
