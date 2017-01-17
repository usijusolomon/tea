using ObjectClass;
using System.Data.Entity;

namespace DataBase
{
    public class CourseDataBaseConnection : DbContext
    {
        public CourseDataBaseConnection(): base("name=TeaDb")
        {
        }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Level> Levels { get; set; }
    }
}
