using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ObjectClass;

namespace DataBase
{
    public class FacultyDataBaseConnection : DbContext
    {
        public FacultyDataBaseConnection(): base("name=Tea")
        {

        }
        public virtual DbSet<Faculty> Faculties { get; set; }
        public virtual DbSet<Department> Departments{ get; set; }

    }
}
