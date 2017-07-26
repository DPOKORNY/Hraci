using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Hraci.Models;

namespace Hraci.Controllers
{
    [Authorize(Roles ="admin")]
    public class SoupiskaController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Soupiska
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View(db.Soupiskas.ToList());
        }

        // GET: Soupiska/Details/5
        [AllowAnonymous]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Soupiska soupiska = db.Soupiskas.Find(id);
            if (soupiska == null)
            {
                return HttpNotFound();
            }
            return View(soupiska);
        }

        // GET: Soupiska/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Soupiska/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Jmeno,Prijmeni,Narodnost,Post,Popis")] Soupiska soupiska)
        {
            if (ModelState.IsValid)
            {
                db.Soupiskas.Add(soupiska);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(soupiska);
        }

        // GET: Soupiska/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Soupiska soupiska = db.Soupiskas.Find(id);
            if (soupiska == null)
            {
                return HttpNotFound();
            }
            return View(soupiska);
        }

        // POST: Soupiska/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Jmeno,Prijmeni,Narodnost,Post,Popis")] Soupiska soupiska)
        {
            if (ModelState.IsValid)
            {
                db.Entry(soupiska).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(soupiska);
        }

        // GET: Soupiska/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Soupiska soupiska = db.Soupiskas.Find(id);
            if (soupiska == null)
            {
                return HttpNotFound();
            }
            return View(soupiska);
        }

        // POST: Soupiska/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Soupiska soupiska = db.Soupiskas.Find(id);
            db.Soupiskas.Remove(soupiska);
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
