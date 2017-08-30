using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    abstract class Employee
    {
        protected int empno;
        protected string name;
        protected int salary;

        public Employee(int empno, string name, int salary)
        {
            this.empno = empno;
            this.name = name;
            if (salary < 0)
                throw new ArgumentException("Invalid Salary. Must be >= 0");

            this.salary = salary;
        }

        public virtual void Print()
        {
            Console.WriteLine(empno);
            Console.WriteLine(name);
            Console.WriteLine(salary);
        }

        public abstract int GetNetSalary();
    }

    class Programmer : Employee
    {
        protected string technology;

        public Programmer(int empno, string name, int salary, string technology)
              : base(empno, name, salary)
        {
            this.technology = technology;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine(technology);
        }

        public string Technology
        {
            get
            {
                return technology;
            }
            set
            {
                this.technology = value;
            }
        }

        public override int GetNetSalary()
        {
            return salary + salary * 20 / 100;
        }
    }

    class OnsiteProgrammer : Programmer
    {
        protected string location;

        public OnsiteProgrammer(int empno, string name, int salary, string technology, string location)
              : base(empno, name, salary, technology)
        {
            this.location = location;
        }

        public new void Print()
        {
            base.Print();
            Console.WriteLine(location);
        }

        public override int GetNetSalary()
        {
            return base.GetNetSalary() + salary * 30 / 100;
        }

    }

    class TestEmployee
    {
        public static void Main()
        {
            Employee e;

            e = new OnsiteProgrammer(1, "Mr. Scott", 59099,"MS.NET","London");
            e.Print();  // Runtime poly
            Console.WriteLine(e.GetNetSalary());  // runtime poly


            e = new Programmer(2, "Mr. Bill", -10000, "MS.NET");  
            e.Print();  // Runtime Polymorphism
            Console.WriteLine(e.GetNetSalary()); // runtime poly

        }
    }
}
