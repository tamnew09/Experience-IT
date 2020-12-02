using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MidtermVersion.Models;
using System.Data.Entity;

namespace MidtermVersion.Controllers
{
    public class CoursesController : Controller
    {
        // GET: Course
        public ActionResult List()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            var courses = db.Course.ToList();

            return View(courses);
        }

        // GET: Course/Delete
        public ActionResult Delete()
        {
            return View();
        }
       // GET: Course/Edit
        public ActionResult Edit()
        {
            return View();
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
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Course/Edit/5
        public ActionResult Edit(int id)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            var course = db.Course.Where(x => x.Id == id).FirstOrDefault();

            return View(course);
            
        }

        // POST: Course/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                ApplicationDbContext db = new ApplicationDbContext();
                var courses = db.Course.Where(x => x.Id == id).FirstOrDefault();

                db.Course.Remove(courses);
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
