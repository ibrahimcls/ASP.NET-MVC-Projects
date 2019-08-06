using System;
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
    public class musteriController : Controller
    {
        private verilerEntities1 db = new verilerEntities1();

        // GET: musteri
        public ActionResult Index()
        {
            return View(db.musteri.ToList());
        }

        // GET: musteri/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            musteri musteri = db.musteri.Find(id);
            if (musteri == null)
            {
                return HttpNotFound();
            }
            return View(musteri);
        }

        // GET: musteri/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: musteri/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "musteriID,musteriAdi,musteriSoyadi,musteriEmail,musteriYas")] musteri musteri)
        {
            if (ModelState.IsValid)
            {
                db.musteri.Add(musteri);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(musteri);
        }

        // GET: musteri/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            musteri musteri = db.musteri.Find(id);
            if (musteri == null)
            {
                return HttpNotFound();
            }
            return View(musteri);
        }

        // POST: musteri/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "musteriID,musteriAdi,musteriSoyadi,musteriEmail,musteriYas")] musteri musteri)
        {
            if (ModelState.IsValid)
            {
                db.Entry(musteri).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(musteri);
        }

        // GET: musteri/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            musteri musteri = db.musteri.Find(id);
            if (musteri == null)
            {
                return HttpNotFound();
            }
            return View(musteri);
        }

        // POST: musteri/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            musteri musteri = db.musteri.Find(id);
            db.musteri.Remove(musteri);
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
