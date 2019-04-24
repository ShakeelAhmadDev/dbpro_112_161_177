using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IMS_DBMS.Controllers
{
    public class CoursesController : Controller
    {
        // GET: Courses
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Viewcourses()
        {
            return View();
        }
    }
}