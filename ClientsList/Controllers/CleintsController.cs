using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ClientsList.DAL;
using ClientsList.Models;

namespace ClientsList.Controllers
{
    public class CleintsController : Controller
    {
        private ClientContext db = new ClientContext();

        // GET: Cleints


        public ActionResult ClientListIndex(string searchString)
        {
            var art = db.Cleints.OrderByDescending(m => m.ClientID).Take(50);



            if (!String.IsNullOrEmpty(searchString))
            {
                art = art.Where(m => m.PhoneNo.Contains(searchString) || m.ProductModel.Contains(searchString)) ;
                return View(art);
            }
            else
            {
                return Content("Your has no Client");
            }

        }

      
        public ActionResult Index( )
        {

            return View(db.Cleints.ToList());
        }

        // GET: Cleints/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cleint cleint = db.Cleints.Find(id);
            if (cleint == null)
            {
                return HttpNotFound();
            }
            return View(cleint);
        }

        // GET: Cleints/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cleints/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ClientID,ClientName,Address,PhoneNo,SetupDate,OldServiceDate,ServiceDate,NextServiceDate,ProductModel")] Cleint cleint)
        {
            if (ModelState.IsValid)
            {
                db.Cleints.Add(cleint);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cleint);
        }

        // GET: Cleints/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cleint cleint = db.Cleints.Find(id);
            if (cleint == null)
            {
                return HttpNotFound();
            }
            return View(cleint);
        }

        // POST: Cleints/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ClientID,ClientName,Address,PhoneNo,SetupDate,OldServiceDate,ServiceDate,NextServiceDate,ProductModel")] Cleint cleint)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cleint).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cleint);
        }

        // GET: Cleints/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cleint cleint = db.Cleints.Find(id);
            if (cleint == null)
            {
                return HttpNotFound();
            }
            return View(cleint);
        }

        // POST: Cleints/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cleint cleint = db.Cleints.Find(id);
            db.Cleints.Remove(cleint);
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
