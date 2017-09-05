using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class SortedDirectory
    {
        static void Main(string[] args)
        {
            var phones = new SortedDictionary<string, string>();

            using (StreamReader sr = new StreamReader(@"f:\classroom\phonedirectory.txt"))
            {
                while (true)
                {
                    string line = sr.ReadLine();
                    if (line == null)
                        break;

                    string[] parts = line.Split(':');
                    if ( parts.Length > 1)
                        phones.Add(parts[0], parts[1]);
                }
            }

            foreach (string n in phones.Keys)
                Console.WriteLine("{0} - {1}",n, phones[n]);
        }
    }
}
