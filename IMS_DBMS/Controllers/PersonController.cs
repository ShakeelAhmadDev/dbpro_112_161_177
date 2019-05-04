using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IMS_DBMS.Models;

namespace IMS_DBMS.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            DB47Entities1 db = new DB47Entities1();
            List<Person> list = db.People.ToList();
            List<PersonViewModel> viewList = new List<PersonViewModel>();
            foreach(Person p in list)
            {
                PersonViewModel m = new PersonViewModel();
                m.ConfirmPassword = p.ConfirmPassword;
                m.ContactNo = p.ContactNo;
                m.Email = p.Email;
                m.Name = p.Name;
                m.Password = p.Password;
                m.PId = p.PId;
                viewList.Add(m);
            }
            return View(viewList);
        }

        // GET: Person/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Person/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Person/Create
        [HttpPost]
        public ActionResult Create(PersonViewModel m)
        {
            try
            {
                // TODO: Add insert logic here
                Person p = new Person();
                p.PId = m.PId;
                p.Password = m.Password;
                p.Name = m.Name;
                p.Email = m.Email;
                p.ContactNo = m.ContactNo;
                p.ConfirmPassword = m.ConfirmPassword;

                DB47Entities1 db = new DB47Entities1();
                db.People.Add(p);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        // GET: Person/Edit/5
        public ActionResult Edit(int id)
        {
            DB47Entities1 db = new DB47Entities1();
            var s = db.People.Where(x => x.PId == id).First();
            PersonViewModel m = new PersonViewModel();
            //m.PId = s.PId;
            m.Password = s.Password;
            m.Name = s.Name;
            m.Email = s.Email;
            m.ContactNo = s.ContactNo;
            m.ConfirmPassword = s.ConfirmPassword;
            return View(m);
        }

        // POST: Person/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, PersonViewModel obj)
        {
            try
            {
                // TODO: Add update logic here
                DB47Entities1 db = new DB47Entities1();
                var cs = db.People.Where(x => x.PId == id).First();
                List<Person> list = db.People.ToList();
                //cs.PId = obj.PId;
                cs.Password = obj.Password;
                cs.Name = obj.Name;
                cs.Email = obj.Email;
                cs.ContactNo = obj.ContactNo;
                cs.ConfirmPassword = obj.ConfirmPassword;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        // GET: Person/Delete/5
        public ActionResult Delete(int id)
        {
            DB47Entities1 db = new DB47Entities1();
            var s = db.People.Where(x => x.PId == id).First();
            PersonViewModel m = new PersonViewModel();
            //m.PId = s.PId;
            m.Password = s.Password;
            m.Name = s.Name;
            m.Email = s.Email;
            m.ContactNo = s.ContactNo;
            m.ConfirmPassword = s.ConfirmPassword;
            return View(m);
        }

        // POST: Person/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, PersonViewModel obj)
        {
            try
            {
                // TODO: Add delete logic here
                DB47Entities1 db = new DB47Entities1();
                var cs = db.People.Where(x => x.PId == id).First();
                List<Person> list = db.People.ToList();
                //cs.PId = obj.PId;
                cs.Password = obj.Password;
                cs.Name = obj.Name;
                cs.Email = obj.Email;
                cs.ContactNo = obj.ContactNo;
                cs.ConfirmPassword = obj.ConfirmPassword;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
