using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class Exam
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int OrganizationId { get; set; }
        public string ExamType { get; set; }
        public string Code { get; set; }
        public string Topic { get; set; }
        public float FullMarks { get; set; }
        public DateTime Duration { get; set; }

    }
}
