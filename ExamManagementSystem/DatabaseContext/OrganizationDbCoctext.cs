using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseContext
{
   public class OrganizationDbCoctext:DbContext
    {
        public DbSet<Organization> organizations { get; set; }
    }
}
