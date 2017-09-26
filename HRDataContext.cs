using System.Data.Linq;

namespace ConsoleApp
{
    class HRDataContext : DataContext
    {
        public HRDataContext() : 
            base(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=msdb;Integrated Security=True")
        {

        }

        public Table<Department>  Departments
        {
            get
            {
                return GetTable<Department>();
            }
        }

    }
}
