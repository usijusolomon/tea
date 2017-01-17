using ObjectClass;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class LevelDataBaseConnection : DbContext
    {
        public LevelDataBaseConnection(): base("name=TeaDb")
        {

        }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Level> Levels { get; set; }
    }
}
