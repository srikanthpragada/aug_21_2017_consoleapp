using System;
using System.Collections.Generic;
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
            ListDepartments();
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

            Department dept = new Department { DepartmentId = 150,
                                               DepartmentName = "Customer Support" };

            ctx.Departments.Add(dept);
            Console.ReadLine();
            ctx.SaveChanges();
            Console.WriteLine("Added Dept!");
        }


        static void ListDepartments()
        {
            HREntities ctx = new HREntities();
            ctx.Database.Log = Console.WriteLine;

            var depts = from dept in ctx.Departments.Include("Employees")
                        select dept; 

            foreach (Department dept in  depts)
            {
                Console.WriteLine("{0} - {1}",
                    dept.DepartmentId, dept.DepartmentName);

                foreach (Employee e in dept.Employees)
                    Console.WriteLine("*** {0}", e.EmployeeName);
            }

        }
    }


}
