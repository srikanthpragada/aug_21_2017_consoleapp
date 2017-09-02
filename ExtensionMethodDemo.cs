using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class ExtensionMethodDemo
    {
        public static void Main()
        {
            Person p = new Person { Name = "Scott", Age = 30 };
            p.Print();

            String st = "Visual Studio from Microsoft";
            Console.WriteLine("U is present : {0}", st.FindCount("o"));
        }
    }

    static class MyExtensionMethods
    {
        // Adding extension method Print to Person class 
        public static void Print(this Person p)
        {
            Console.WriteLine(p.Name);
            Console.WriteLine(p.Age);
        }

        public static void Vertical(this String st)
        {
            for (int i = 0; i < st.Length; i++)
                Console.WriteLine(st[i]);
        }

        public static int FindCount(this String main, String sub)
        {
            int pos = -1, count = 0;

            while (true)
            {
                pos = main.IndexOf(sub, pos + 1);
                if (pos > 0)
                    count++;
                else
                    break;
            }

            return count;
        }
    }
}
