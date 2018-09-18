﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseContext;
using Models;

namespace Repository
{

   public class OrganizationRepository
    {
       OnlineExamDbContext _dbCoctext = new OnlineExamDbContext();

        public bool Add(Organization organization)
        {
            _dbCoctext.Organizations.Add(organization);
            return _dbCoctext.SaveChanges() > 0;
        }

       public bool Update(Organization organization)
       {
           _dbCoctext.Entry(organization).State = EntityState.Modified;
           return _dbCoctext.SaveChanges() > 0;
       }

       public bool Delete(Organization organization)
       {
           organization.isDelete = true;
           bool isUpdate = Update(organization);
           return isUpdate;
       }
       public List<Organization> GetAll()
       {
           return _dbCoctext.Organizations.ToList();
       }

       public List<Organization> GetAllOrganization()
       {
           List<Organization> organizations = _dbCoctext.Organizations.ToList();
           return organizations;

       }
    }
}
