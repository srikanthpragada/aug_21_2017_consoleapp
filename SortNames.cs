using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class SortNames
    {
        static void Main(string[] args)
        {
            var names = new SortedSet<string>();
            using (StreamReader sr = new StreamReader(@"f:\classroom\names2.txt"))
            {
                while (true)
                {
                    string line = sr.ReadLine();
                    if (line == null)
                        break;

                    string[] parts = line.Split(',', ';', ':');
                    foreach(string p in parts)
                      names.Add(p);
                }
            }

            foreach (string n in names)
                Console.WriteLine(n);
            
        }
    }
}
