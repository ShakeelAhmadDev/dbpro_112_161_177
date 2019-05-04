using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IMS_DBMS.Models;

namespace IMS_DBMS.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        public ActionResult Index()
        {
            DB47Entities1 db = new DB47Entities1();
            List<Course> list = db.Courses.ToList();
            List<Addcourse> viewList = new List<Addcourse>();
            foreach (Course c in list)
            {
                Addcourse a = new Addcourse();
                a.CId = c.CId;
                a.Credits = c.Credits;
                a.Duration = c.Duration;
                a.EndTime = c.EndTime;
                a.Fee = c.Fee;
                a.StartTime = c.StartTime;
                a.Term = c.Term;
                a.Title = c.Title;
                viewList.Add(a);
            }
            return View(viewList);
        }

        // GET: Course/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Course/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Course/Create
        [HttpPost]
        public ActionResult Create(Addcourse obj)
        {
            try
            {
                // TODO: Add insert logic here
                Course a = new Course();
                a.Title = obj.Title;
                a.Term = obj.Term;
                a.StartTime = obj.StartTime;
                a.Fee = obj.Fee;
                a.EndTime = obj.EndTime;
                a.Duration = obj.Duration;
                a.Credits = obj.Credits;

                DB47Entities1 db = new DB47Entities1();
                db.Courses.Add(a);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        // GET: Course/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Course/Edit/5
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

        // GET: Course/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Course/Delete/5
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
