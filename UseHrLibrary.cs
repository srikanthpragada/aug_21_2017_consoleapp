using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// make sure you added a reference to HrLibrary.dll 
using HrLibrary;

namespace ConsoleApp
{
    class UseHrLibrary
    {
        static void Main(string[] args)
        {
            var e = new HrLibrary.Employee { Id = 1, Name = "Abc", Salary = 10000 };
            var j = new Job { Id = "prog", Title = "Programmer" };

            j.Print(); 
        }
    }

    static class HrExtensionMethods
    {
        public static void  Print(this Job job)
        {
            Console.WriteLine(job.Id);
            Console.WriteLine(job.Title);
        }
    }
}
