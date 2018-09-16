using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;

namespace ExamManagementSystem.Models
{
    public class LookUp
    {
        OrganizationManager _organizationManager = new OrganizationManager();

        public List<SelectListItem> GetOrganizations()
        {
            return _organizationManager.GetAll()
                   .Select(c => new SelectListItem() { Value = c.Id.ToString(), Text = c.Name }).ToList();


        }
    }
}