using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class Course
    {
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string CourseDuration { get; set; }
        public string Credit { get; set; }
        public string Outline { get; set; }
        public string Tags { get; set; }
    }
}
