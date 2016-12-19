using ObjectClass;
using System.Data.Entity;

namespace DataBase
{
    public class CourseDataBaseContext : DbContext
    {
        public CourseDataBaseContext(): base("name=Tea")
        {
        }
        public virtual DbSet<Course> Courses { get; set; }
    }
}
