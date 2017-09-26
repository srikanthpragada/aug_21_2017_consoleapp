using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class LinqDepartments
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
            HRDataContext ctx = new HRDataContext();
            ctx.Log = Console.Out;

            var dept = (from d in ctx.Departments
                        where d.DepartmentId == 100
                        select d).SingleOrDefault();

            if (dept == null)
                Console.WriteLine("Sorry! Department not found!");
            else
            {
                ctx.Departments.DeleteOnSubmit(dept);
                ctx.SubmitChanges();
                Console.WriteLine("Deleted Successfully!");
            }
        }

        private static void UpdateDepartment()
        {
            HRDataContext ctx = new HRDataContext();
            ctx.Log = Console.Out;

            //var dept = (from d in ctx.Departments
            //           where d.DepartmentId == 50
            //           select d).SingleOrDefault();

            var dept = ctx.Departments.Where(d => d.DepartmentId == 50).SingleOrDefault();

            if (dept == null)
                Console.WriteLine("Sorry! Department not found!");
            else
            {
                dept.DepartmentName = "Sports & Fitness";
                ctx.SubmitChanges();
                Console.WriteLine("Updated Successfully!");
            }


        }

        private static void AddDepartment()
        {
            HRDataContext ctx = new HRDataContext();
            ctx.Log = Console.Out;

            Department dept = new Department { DepartmentId = 50,
                                               DepartmentName = "Sports" };
            ctx.Departments.InsertOnSubmit(dept);

            Console.ReadLine(); 

            ctx.SubmitChanges();

            Console.WriteLine("Added Dept!");


        }

        static void ListDepartments()
        {
            HRDataContext ctx = new HRDataContext();
            ctx.Log = Console.Out;

            // var depts = ctx.Departments.Where(dept => dept.DepartmentName.Length > 5);

            var depts = from dept in ctx.Departments
                        // where dept.DepartmentName.Length <= 5
                        orderby dept.DepartmentName
                        select dept; 

            foreach (Department dept in  depts)
            {
                Console.WriteLine("{0} - {1}", dept.DepartmentId, dept.DepartmentName);
            }

        }
    }


}
