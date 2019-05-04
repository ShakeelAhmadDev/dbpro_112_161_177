using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IMS_DBMS.Models;

namespace IMS_DBMS.Controllers
{
    public class EnrollStudentController : Controller
    {
        // GET: EnrollStudent
        public ActionResult Index()
        {
            DB47Entities1 db = new DB47Entities1();
            List<StudentEnrolled> list = db.StudentEnrolleds.ToList();
            List<enrollStudent> viewList = new List<enrollStudent>();
            foreach (StudentEnrolled e in list)
            {
                enrollStudent s = new enrollStudent();
                s.CTitle = e.CTitle;
                s.EId = e.EId;
                s.SName = e.SName;
                viewList.Add(s);
            }
            return View(viewList);
        }

        // GET: EnrollStudent/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EnrollStudent/Create
        public ActionResult Create()
        {
            enrollStudent e = new enrollStudent();
            using (DB47Entities1 db = new DB47Entities1())
            {
                e.PersonCollection = db.People.ToList<Person>();
                e.CourseCollection = db.Courses.ToList<Course>();

            }
            return View(e);
        }

        // POST: EnrollStudent/Create
        [HttpPost]
        public ActionResult Create(enrollStudent obj)
        {
            try
            {
                // TODO: Add insert logic here
                StudentEnrolled s = new StudentEnrolled();
                s.CTitle = obj.CTitle;
                s.EId = obj.EId;
                s.SName = obj.SName;
                DB47Entities1 db = new DB47Entities1();
                db.StudentEnrolleds.Add(s);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: EnrollStudent/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EnrollStudent/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: EnrollStudent/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EnrollStudent/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
