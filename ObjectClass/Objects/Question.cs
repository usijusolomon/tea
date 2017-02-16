using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectClass
{
    public class Question
    {
        public long QuestionId { get; set; }
        public long CourseId { get; set; }
        [ForeignKey("CourseId")]
        public Course Course { get; set; }
        public string AskedQuestion { get; set; }
        public int QuestionNumber { get; set; }
        public string Image { get; set; }
        public IEnumerable<Answer> Answers { get; set; }
    }
}
