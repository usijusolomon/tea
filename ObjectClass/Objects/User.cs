using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectClass
{
    public class User
    {
        public long UserId { get; set; }
        public string UserPassword { get; set; }
        public string ConfirmPassword { get; set; }
        public string UserMatric { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string UserType { get; set; }
        public long? LevelId { get; set; }
        [ForeignKey ("LevelId")]
        public Level Level { get; set; }
        public long? DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }
        public long? FacultyId { get; set; }
        [ForeignKey("FacultyId")]
        public Faculty Faculty { get; set; }


    }
}
