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
        public FacultyDataBaseConnection(): base("name=TeaDb")
        {

        }
        public virtual DbSet<Faculty> Faculties { get; set; }
        public virtual DbSet<Department> Departments{ get; set; }
        public virtual DbSet<Level> Levels { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Answer> Answers { get; set; }

    }
}
