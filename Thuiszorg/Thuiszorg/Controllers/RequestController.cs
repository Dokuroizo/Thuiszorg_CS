using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Thuiszorg.Models;

namespace Thuiszorg.Controllers
{
    public class RequestController : Controller
    {
        private versie01Context db = new versie01Context();

        //
        // GET: /Request/

        public ActionResult Index()
        {
            return View(db.Requests.ToList());
        }

        //
        // GET: /Request/Details/5

        public ActionResult Details(int id = 0)
        {
            Request request = db.Requests.Find(id);
            if (request == null)
            {
                return HttpNotFound();
            }
            return View(request);
        }

        //
        // GET: /Request/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Request/Create

        [HttpPost]
        public ActionResult Create(Request request)
        {
            if (ModelState.IsValid)
            {
                request.dateAndTimeAdded = DateTime.Now;
                db.Requests.Add(request);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(request);
        }

        //
        // GET: /Request/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Request request = db.Requests.Find(id);
            if (request == null)
            {
                return HttpNotFound();
            }
            return View(request);
        }

        //
        // POST: /Request/Edit/5

        [HttpPost]
        public ActionResult Edit(Request request)
        {
            if (ModelState.IsValid)
            {
                db.Entry(request).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(request);
        }

        //
        // GET: /Request/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Request request = db.Requests.Find(id);
            if (request == null)
            {
                return HttpNotFound();
            }
            return View(request);
        }

        //
        // POST: /Request/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Request request = db.Requests.Find(id);
            db.Requests.Remove(request);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Accept(int id =0)
        {
            Request request = db.Requests.Find(id);
            request.accept = true;
            db.SaveChanges();
            return RedirectToAction("Index", request);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}