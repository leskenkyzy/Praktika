using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Praktika.Models;
namespace Praktika.Controllers
{
    public class ProductController : Controller
    {
        private fff db = new fff();
        public ActionResult Index()
        {
            var result = from d in Dostavka
                         join s in Status on s.StatusId equals d.StatID
                         select new { Name = d.NamE, AdresS = d.Adress, PhonE = d.Phone, StatusNamE = s.StatusName };
            return View(result );
        }

        public ActionResult Create()
        {
            StatusViewModel statusView = new StatusViewModel();
            statusView.Status = PopulateStatuses();

            return View(statusView);
        }

        private static List<SelectListItem> PopulateStatuses()
        {
            fff db = new fff();
            List<SelectListItem> selectListItems = new List<SelectListItem>();
            var statuslists = db.Statuses;
            foreach (var statuslist in statuslists) {
                selectListItems.Add(new SelectListItem()
                {
                    Text = statuslist.StatusName,
                    Value = statuslist.StatusId.ToString()
                });
            }
            return selectListItems;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(StatusViewModel statusView)
        {
            Dostavka dostavka = new Dostavka();
            if (ModelState.IsValid)
            {
                dostavka.NamE = statusView.NamE;
                dostavka.Phone = statusView.Phone;
                dostavka.PriceDostavki = statusView.PriceDostavki;
                dostavka.StatID = statusView.StatusId;
                db.Dostavkas.Add(dostavka);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dostavka);
        }


        public ActionResult Order(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
           Dostavka dostavka = db.Dostavkas.Find(id);
            if (dostavka == null)
            {
                return HttpNotFound();
            }
            return View(dostavka);
        }

        public ActionResult Update(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dostavka dostavka = db.Dostavkas.Find(id);

            if (dostavka == null)
            {
                return HttpNotFound();
            }
            return View(dostavka);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(StatusViewModel statusView)
        {
           ViewBag.state = new SelectList(db.Statuses, "StatusId","StatusName");
            
            if (ModelState.IsValid)
            {
                db.Entry(statusView).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(statusView);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dostavka dostavka = db.Dostavkas.Find(id);
            if (dostavka == null)
            {
                return HttpNotFound();
            }
            return View(dostavka);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Dostavka status = db.Dostavkas.Find(id);
            db.Dostavkas.Remove(status);
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