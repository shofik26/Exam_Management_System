using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using Models;
using Models.ViewModels;

namespace ExamManagementSystem.Controllers
{
    public class CourseController : Controller
    {
        CourseManager _courseManager =new CourseManager();
        OrganizationManager _orgnanizationManager = new OrganizationManager();

        // GET: Course
        public ActionResult Entry()
        {
            var organizationLookups =
                _orgnanizationManager.GetAll()
                    .Select(c => new SelectListItem() {Value = c.Id.ToString(), Text = c.Name});

            var model = new CourseEntryVM();
            model.OrganizationLookUps = organizationLookups.ToList();
            return View(model);
        }
        [HttpPost]
        public ActionResult Entry(CourseEntryVM model )
        {
            return View();
        }
    }
}