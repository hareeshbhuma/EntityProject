using DBSample.DAL;
using DBSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DBSample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            SchoolContext school = new SchoolContext();
            //Student s = new Student();
            //s.FirstMidName = "gg";
            //s.LastName = "j";
            //s.ID = 1;
            //s.EnrollmentDate = DateTime.Parse("2005-09-01");
            //school.Students.Add(s);
            //school.SaveChanges();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}