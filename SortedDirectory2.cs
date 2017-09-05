using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class SortedDirectory2
    {
        static void Main(string[] args)
        {
            var phones = new SortedDictionary<string, HashSet<string>>();

            using (StreamReader sr = new StreamReader(@"f:\classroom\phonedirectory.txt"))
            {
                while (true)
                {
                    string line = sr.ReadLine();
                    if (line == null)
                        break;

                    string[] parts = line.Split(':');
                    if (parts.Length > 1)
                    {
                        string name = parts[0];
                        string phone = parts[1];

                        // find out whether name is present 
                        if ( phones.ContainsKey(name))
                        {
                            phones[name].Add(phone);
                        }
                        else
                        {
                            phones.Add(name, new HashSet<string>() { phone });
                        }
                    }
                }
            }

            foreach (string n in phones.Keys)
            {
                Console.WriteLine(n);

                foreach (string phone in phones[n])
                {
                    Console.WriteLine("    {0}", phone);
                }
            }
        }
    }
}
