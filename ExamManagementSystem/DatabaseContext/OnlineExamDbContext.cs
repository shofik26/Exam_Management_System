using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DatabaseContext
{
   public class OnlineExamDbContext:DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Organization> Organizations { get; set; }

    }

}
