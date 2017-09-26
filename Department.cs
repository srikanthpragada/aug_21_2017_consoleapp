using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    [Table(Name ="Departments")]
    class Department
    {
        [Column (Name ="DepartmentId", IsPrimaryKey = true)]
        public int DepartmentId { get; set; }

        [Column(Name = "DepartmentName")]
        public string DepartmentName { get; set; }
    }


}
