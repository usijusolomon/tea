using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectClass
{
    public class Department
    {
        public long DepartmentId { get; set; }
        public string Name { get; set; }
        public long FacultyId { get; set; }
        [ForeignKey("FacultyId")]
        public virtual Faculty Faculty { get; set; }
        public IEnumerable<Course> Course { get; set; }
    }
}
