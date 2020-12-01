using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MidtermVersion.Models;

namespace MidtermVersion.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Student
        public ActionResult List()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            var students = db.Student.ToList();

            return View(students);
        }


        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
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

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            var student = db.Student.Where(x => x.Id == id).FirstOrDefault();
            return View(student);
        }

        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                ApplicationDbContext db = new ApplicationDbContext();
                var student = db.Student.Where(x => x.Id == id).FirstOrDefault();
                db.Entry(student).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            var student = db.Student.Where(x => x.Id == id).FirstOrDefault();

            db.Student.Remove(student);

            return View();
        }

        // POST: Student/Delete/5
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



