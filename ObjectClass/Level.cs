using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectClass
{
    public class Level
    {
        public string LevelId { get; set; }
        public string Name { get; set; }
        public string DepartmentId { get; set; }
        public IEnumerable<Course> Courses { get; set; }
        public IEnumerable<Department> Department { get; set; }
    }
}
