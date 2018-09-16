using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Repository;

namespace BLL
{
   public class CourseManager
    {
        CourseRepository _courseRepository=new CourseRepository();

        public bool Add(Course course)
        {
            bool isAdded=_courseRepository.Add(course);
            return isAdded;
        }

        public bool Update(Course course)
        {
            bool isUpdate = _courseRepository.Update(course);
            return isUpdate;
        }
        public bool Delete(Course course)
        {
            course.IsDeleted = true;
            bool isdelete = _courseRepository.Update(course);
            return isdelete;
        }

        public List<Course> GetAll()
        {
            List<Course> courses = _courseRepository.GetAll();
            return courses;
        }
    }
}
