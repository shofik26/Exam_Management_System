using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Models.ViewModels
{
    public class CourseEntryVM
    {
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string CourseDuration { get; set; }
        public string Credit { get; set; }
        public string Outline { get; set; }
        public string Tags { get; set; }
        public bool IsDeleted { get; set; }

        public List<SelectListItem> OrganizationLookUps { get; set; } 
    }
}
