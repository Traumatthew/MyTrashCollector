using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MyTrashCollector.Models;

namespace MyTrashCollector.Controllers
{
    public class ZipCodesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ZipCodes
        public ActionResult Index()
        {
            return View(db.ZipCodes.ToList());
        }

        // GET: ZipCodes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ZipCodes zipCodes = db.ZipCodes.Find(id);
            if (zipCodes == null)
            {
                return HttpNotFound();
            }
            return View(zipCodes);
        }

        // GET: ZipCodes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ZipCodes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ZipCodeId,ZipCodeNumber")] ZipCodes zipCodes)
        {
            if (ModelState.IsValid)
            {
                db.ZipCodes.Add(zipCodes);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(zipCodes);
        }

        // GET: ZipCodes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ZipCodes zipCodes = db.ZipCodes.Find(id);
            if (zipCodes == null)
            {
                return HttpNotFound();
            }
            return View(zipCodes);
        }

        // POST: ZipCodes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ZipCodeId,ZipCodeNumber")] ZipCodes zipCodes)
        {
            if (ModelState.IsValid)
            {
                db.Entry(zipCodes).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(zipCodes);
        }

        // GET: ZipCodes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ZipCodes zipCodes = db.ZipCodes.Find(id);
            if (zipCodes == null)
            {
                return HttpNotFound();
            }
            return View(zipCodes);
        }

        // POST: ZipCodes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ZipCodes zipCodes = db.ZipCodes.Find(id);
            db.ZipCodes.Remove(zipCodes);
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
