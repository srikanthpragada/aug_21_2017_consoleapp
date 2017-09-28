using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class EFDepartments
    {
        static void Main(string[] args)
        {
            // AddDepartment();
            // UpdateDepartment();
            // DeleteDepartment();
            // FindThenUpdateDepartment();
            // TwoContextProblem();

            LoadTwice();
            // ListDepartments();

            
        }

        private static void LoadTwice()
        {
            HREntities ctx1 = new HREntities();
            ctx1.Database.Log = Console.WriteLine;

            var dept = ctx1.Departments.Find(50);
            dept.DepartmentName = "Sportsssss";

            // ctx1.Entry(dept).State = EntityState.Detached;

            var dept2 = ctx1.Departments.Find(50);
            Console.WriteLine(dept2.DepartmentName);


            Console.WriteLine(dept == dept2);

        }

        private static void TwoContextProblem()
        {
            HREntities ctx1 = new HREntities();
            ctx1.Database.Log = Console.WriteLine;

            var dept = ctx1.Departments.Find(50);
            Console.WriteLine("Before change {0}", ctx1.Entry(dept).State);

            dept.DepartmentName = "New Sports";

            Console.WriteLine("After change {0}", ctx1.Entry(dept).State);

            ctx1.Dispose();

            // dept is detached 

            Console.WriteLine("First context is closed!");

            HREntities ctx2 = new HREntities();
            ctx2.Database.Log = Console.WriteLine;

            ctx2.Departments.Attach(dept);
            Console.WriteLine("After attached {0}", ctx2.Entry(dept).State);
            ctx2.Entry(dept).State = EntityState.Modified;
            Console.WriteLine("After change  {0}", ctx2.Entry(dept).State);

            ctx2.SaveChanges();

        }

        private static void DeleteDepartment()
        {
            HREntities ctx = new HREntities();
            ctx.Database.Log = Console.WriteLine;

            var dept = (from d in ctx.Departments
                        where d.DepartmentId == 150
                        select d).SingleOrDefault();

            if (dept == null)
                Console.WriteLine("Sorry! Department not found!");
            else
            {
                ctx.Departments.Remove(dept);
                ctx.SaveChanges();
                Console.WriteLine("Deleted Successfully!");
            }
        }

        private static void FindThenUpdateDepartment()
        {
            HREntities ctx = new HREntities();
            ctx.Database.Log = Console.WriteLine;

            var dept = ctx.Departments.Find(50);
            if (dept == null)
                Console.WriteLine("Sorry! Department not found!");
            else
            {

                dept.DepartmentName = "Sports";
                ctx.SaveChanges();
                Console.WriteLine("Updated Successfully!");
            }
        }

        private static void UpdateDepartment()
        {
            HREntities ctx = new HREntities();
            ctx.Database.Log = Console.WriteLine;


            var dept = ctx.Departments.Where(d => d.DepartmentId == 150).SingleOrDefault();
            Console.WriteLine("Retrieved object from db");
            if (dept == null)
                Console.WriteLine("Sorry! Department not found!");
            else
            {

                dept.DepartmentName = "Customer Help";
                Console.WriteLine("About to save changes! Press enter to continue..");
                Console.ReadLine();
                ctx.SaveChanges();
                Console.WriteLine("Updated Successfully!");
            }


        }

        private static void AddDepartment()
        {
            HREntities ctx = new HREntities();
            ctx.Database.Log = Console.WriteLine;

            Department dept = new Department
            {
                DepartmentId = 150,
                DepartmentName = "Customer Support"
            };

            // dept is detached 

            ctx.Departments.Add(dept);

            // dept is added 

            Console.ReadLine();
            ctx.SaveChanges(); // Insert 
            Console.WriteLine("Added Dept!");
        }


        static void ListDepartments()
        {
            HREntities ctx = new HREntities();
            ctx.Database.Log = Console.WriteLine;

            var depts = from dept in ctx.Departments
                        select dept;

            foreach (Department dept in depts)
            {
                Console.WriteLine("{0} - {1}",
                    dept.DepartmentId, dept.DepartmentName);

                foreach (Employee e in dept.Employees)
                    Console.WriteLine("*** {0}", e.EmployeeName);
            }

        }
    }


}
