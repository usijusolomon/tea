using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectClass
{
    public class Answer
    {
        public long AnswerId { get; set; }
        public long QuestionId { get; set; }
        [ForeignKey("QuestionId")]
        public Question Question { get; set; }
        public string QuestionAnswer { get; set; }
        public bool RightAnswer { get; set; }
        public string Label { get; set; }
    }
}
