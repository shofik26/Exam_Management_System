using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using BLL;
using ExamManagementSystem.Models;
using Models;
using Models.ViewModels;

namespace ExamManagementSystem.Controllers
{
    public class CourseController : Controller
    {
        CourseManager _courseManager =new CourseManager();
        OrganizationManager _orgnanizationManager = new OrganizationManager();
        LookUp _lookUp = new LookUp();


        public ActionResult Index()
        {
            var model = _courseManager.GetAll();
            return View(model);
        }

        // GET: Course



        public ActionResult Entry()
        {
            var model = new CourseEntryVM();
            model.OrganizationLookUps = _lookUp.GetOrganizations();;
            return View(model);
        }
        
        //Save course
        [HttpPost]
        public ActionResult Entry(CourseEntryVM model )
        {
            if (ModelState.IsValid)
            {
               var course =  Mapper.Map<Course>(model);
               bool isAdded =  _courseManager.Add(course);
                if (isAdded)
                {
                    return RedirectToAction("Index");

                }
            } 
            
            model.OrganizationLookUps = _lookUp.GetOrganizations();
            return View(model);
        }
        //Edit course
        [HttpPost]
        public ActionResult Edit(int id)
        {
        Course course = new Course()
            ;
            if (id>0)
            {
                course = _courseManager.GetById(id);
            }
            List<Organization> organizations = _orgnanizationManager.GetAllorganization();

        }
    }
}