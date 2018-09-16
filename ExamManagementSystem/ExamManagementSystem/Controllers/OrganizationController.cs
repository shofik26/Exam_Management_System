using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using Models;

namespace ExamManagementSystem.Controllers
{
    public class OrganizationController : Controller
    {
        // GET: Organization
        OrganizationManager _organizationManager= new OrganizationManager();

        public ActionResult Entry()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Entry(Organization organization)
        {
            if (ModelState.IsValid)
            {
                _organizationManager.Add(organization);

            }
            return View();
        }
    }
}