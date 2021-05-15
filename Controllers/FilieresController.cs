using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Asp.net_MVC_Code_First;

namespace Asp.net_MVC_Code_First.Controllers
{
    public class FilieresController : Controller
    {
        private StagiaireDbContext db = new StagiaireDbContext();

        // GET: Filieres
        public ActionResult Index()
        {
            return View(db.modules.ToList());
        }

        // GET: Filieres/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Filiere filiere = db.modules.Find(id);
            if (filiere == null)
            {
                return HttpNotFound();
            }
            return View(filiere);
        }

        // GET: Filieres/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Filieres/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nom")] Filiere filiere)
        {
            if (ModelState.IsValid)
            {
                db.modules.Add(filiere);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(filiere);
        }

        // GET: Filieres/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Filiere filiere = db.modules.Find(id);
            if (filiere == null)
            {
                return HttpNotFound();
            }
            return View(filiere);
        }

        // POST: Filieres/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nom")] Filiere filiere)
        {
            if (ModelState.IsValid)
            {
                db.Entry(filiere).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(filiere);
        }

        // GET: Filieres/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Filiere filiere = db.modules.Find(id);
            if (filiere == null)
            {
                return HttpNotFound();
            }
            return View(filiere);
        }

        // POST: Filieres/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Filiere filiere = db.modules.Find(id);
            db.modules.Remove(filiere);
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
