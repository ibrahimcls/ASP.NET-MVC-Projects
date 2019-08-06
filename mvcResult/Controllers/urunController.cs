﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using mvcResult;

namespace mvcResult.Controllers
{
    public class urunController : Controller
    {
        private verilerEntities1 db = new verilerEntities1();

        // GET: urun
        public ActionResult Index()
        {
            var urun = db.urun.Include(u => u.musteri);
            return View(urun.ToList());
        }

        // GET: urun/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            urun urun = db.urun.Find(id);
            if (urun == null)
            {
                return HttpNotFound();
            }
            return View(urun);
        }

        // GET: urun/Create
        public ActionResult Create()
        {
            ViewBag.musteriID = new SelectList(db.musteri, "musteriID", "musteriAdi");
            return View();
        }

        // POST: urun/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "urunID,urunAdi,urunFiyati,musteriID")] urun urun)
        {
            if (ModelState.IsValid)
            {
                db.urun.Add(urun);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.musteriID = new SelectList(db.musteri, "musteriID", "musteriAdi", urun.musteriID);
            return View(urun);
        }

        // GET: urun/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            urun urun = db.urun.Find(id);
            if (urun == null)
            {
                return HttpNotFound();
            }
            ViewBag.musteriID = new SelectList(db.musteri, "musteriID", "musteriAdi", urun.musteriID);
            return View(urun);
        }

        // POST: urun/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "urunID,urunAdi,urunFiyati,musteriID")] urun urun)
        {
            if (ModelState.IsValid)
            {
                db.Entry(urun).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.musteriID = new SelectList(db.musteri, "musteriID", "musteriAdi", urun.musteriID);
            return View(urun);
        }

        // GET: urun/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            urun urun = db.urun.Find(id);
            if (urun == null)
            {
                return HttpNotFound();
            }
            return View(urun);
        }

        // POST: urun/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            urun urun = db.urun.Find(id);
            db.urun.Remove(urun);
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
