using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IMS_DBMS.Models;
namespace IMS_DBMS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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
        public ActionResult Login(PersonViewModel m)
        {
            DB47Entities1 db = new DB47Entities1();
            List<Person> list = db.People.ToList();
            foreach (Person p in list)
            {
                if ((p.Email == m.Email)&&(p.Password == m.Password))
                {
                    return RedirectToAction("Student");
                }else if ((p.Email == "admin@gmail.com")&&(p.Password == "123456"))
                {
                    return RedirectToAction("Admin");
                }

                else
                {
                    m.LoginErrorMessage = "Wrong Login or Password.";
                }
            }
            return View();
        }
        public ActionResult Student()
        {
            /*DB47Entities1 db = new DB47Entities1();
            var getstudent = db.People.ToList();
            SelectList list = new SelectList(getstudent, "PId", "Name");
            ViewBag.StudentListName = list;

            var getcourse = db.Courses.ToList();
            SelectList list1 = new SelectList(getcourse, "CId", "Title");
            ViewBag.CourseListName = list1;*/
             
            return View();
        }
        public ActionResult Admin()
        {
            return View();
        }

    }
}