using ObjectClass;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class DepartmentDataBaseConnection : DbContext
    {
        public DepartmentDataBaseConnection(): base("name=TeaDb")
        {

        }
        public virtual DbSet<Faculty> Faculty { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Level> Levels { get; set; }
        public virtual DbSet<Course> Courses { get; set; } 
    }
}
