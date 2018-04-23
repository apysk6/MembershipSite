using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Memberships.Entities;
using Memberships.Models;

namespace Memberships.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ProductLinkTextController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Admin/ProductLinkText
        public ActionResult Index()
        {
            return View(db.ProductLinkTexts.ToList());
        }

        // GET: Admin/ProductLinkText/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductLinkText productLinkText = db.ProductLinkTexts.Find(id);
            if (productLinkText == null)
            {
                return HttpNotFound();
            }
            return View(productLinkText);
        }

        // GET: Admin/ProductLinkText/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/ProductLinkText/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title")] ProductLinkText productLinkText)
        {
            if (ModelState.IsValid)
            {
                db.ProductLinkTexts.Add(productLinkText);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(productLinkText);
        }

        // GET: Admin/ProductLinkText/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductLinkText productLinkText = db.ProductLinkTexts.Find(id);
            if (productLinkText == null)
            {
                return HttpNotFound();
            }
            return View(productLinkText);
        }

        // POST: Admin/ProductLinkText/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title")] ProductLinkText productLinkText)
        {
            if (ModelState.IsValid)
            {
                db.Entry(productLinkText).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(productLinkText);
        }

        // GET: Admin/ProductLinkText/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductLinkText productLinkText = db.ProductLinkTexts.Find(id);
            if (productLinkText == null)
            {
                return HttpNotFound();
            }
            return View(productLinkText);
        }

        // POST: Admin/ProductLinkText/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ProductLinkText productLinkText = db.ProductLinkTexts.Find(id);
            db.ProductLinkTexts.Remove(productLinkText);
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
