using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class QuestionOption
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public string QuestionOps { get; set; }
        public string QuestionOrder { get; set; }
    }
}
