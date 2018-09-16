using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using AutoMapper;
using Models;
using Models.ViewModels;

namespace ExamManagementSystem
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            ConfigAutomapper();
        }

        private void ConfigAutomapper()
        {
            Mapper.Initialize(config =>
            {
                config.CreateMap<CourseEntryVM, Course>();
                config.CreateMap<Course, CourseEntryVM>();

            });
        }
    }
}
