using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseContext;
using Models;

namespace Repository
{
    public class CourseRepository
    {
        OnlineExamDbContext db = new OnlineExamDbContext();

        public bool Add(Course course)
        {
            db.Courses.Add(course);
            return db.SaveChanges() > 0;
        }

        public bool Update(Course course)
        {
            db.Entry(course).State = EntityState.Modified;
            return db.SaveChanges() > 0;
        }

        public Course GetById(int id)
        {
            return db.Courses.FirstOrDefault(c => c.Id == id);
        }
        public List<Course> GetAll()
        {
            return db.Courses.Where(c=>!c.IsDeleted).ToList();
        }
    }
}

