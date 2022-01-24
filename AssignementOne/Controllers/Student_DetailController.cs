using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AssignementOne.Models;

namespace AssignementOne.Controllers
{
    public class Student_DetailController : Controller
    {
        private Assignemen1Entities db = new Assignemen1Entities();

        // GET: Student_Detail
        public ActionResult Index()
        {
            return View(db.Student_Detail.ToList());
        }

        // GET: Student_Detail/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student_Detail student_Detail = db.Student_Detail.Find(id);
            if (student_Detail == null)
            {
                return HttpNotFound();
            }
            return View(student_Detail);
        }

        // GET: Student_Detail/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student_Detail/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "student_id,full_name,dob,class_name")] Student_Detail student_Detail)
        {
            if (ModelState.IsValid)
            {
                db.Student_Detail.Add(student_Detail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(student_Detail);
        }

        // GET: Student_Detail/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student_Detail student_Detail = db.Student_Detail.Find(id);
            if (student_Detail == null)
            {
                return HttpNotFound();
            }
            return View(student_Detail);
        }

        // POST: Student_Detail/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "student_id,full_name,dob,class_name")] Student_Detail student_Detail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(student_Detail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student_Detail);
        }

        // GET: Student_Detail/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student_Detail student_Detail = db.Student_Detail.Find(id);
            if (student_Detail == null)
            {
                return HttpNotFound();
            }
            return View(student_Detail);
        }

        // POST: Student_Detail/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Student_Detail student_Detail = db.Student_Detail.Find(id);
            db.Student_Detail.Remove(student_Detail);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
