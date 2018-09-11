using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class QuestionAndAnswer
    {
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public int CourseId { get; set; }
        public int ExamId { get; set; }
        public float Marks { get; set; }
        public int OuestionOrder { get; set; }
        public string Option { get; set; }
        public string OptionType { get; set; }
    }
}
