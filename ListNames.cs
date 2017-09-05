using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class ListNames
    {
        static void Main(string[] args)
        {
            var  names = new List<string>();

            names.Add("Ronaldo");
            names.Add("Messi");
            names.Insert(0, "Ronney");
           

            foreach (string n in names)
                Console.WriteLine(n);

        }
    }
}
