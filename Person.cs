using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Person : IComparable<Person>
    {
        public String Name { get; set; }
        public int Age { get; set; }

        // 0   this == other 
        // >0  this > other
        public int CompareTo(Person other)
        {
            return this.Name.CompareTo(other.Name);
        }

        public override bool Equals(object obj)
        {
            Person other = obj as Person;
            return this.Name == other.Name && this.Age == other.Age;
        }

        public override string ToString()
        {
            return Name + " : " + Age;
        }
    }

    class TestPerson
    {
        public static void Main()
        {
            Person[] people = {
                new Person { Name = "Elon Musk", Age = 40 },
                new Person { Name = "Bill Gates", Age = 60 },
                new Person { Name = "Larry Ellison", Age = 65 },
                new Person { Name = "Andy Gore", Age = 55 }
            };


            foreach (Person p in people)
                Console.WriteLine(p);  // p.ToString()

            Array.Sort(people);


            foreach (Person p in people)
                Console.WriteLine(p);  // p.ToString()
        }

    }
}
