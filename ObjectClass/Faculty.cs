using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectClass
{
    public class Faculty 
    {
        public string FacultyId { get; set; }
        public string Name { get; set; }
        public IEnumerable<Department> Department { get; set; }
    }
}
