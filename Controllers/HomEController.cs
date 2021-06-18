using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Praktika.Models;
using System.Data.Entity;
using System.Net;


namespace Praktika.Controllers
{
    public class HomEController : Controller
    {
        // GET: Home
        //    private fff db = new fff();
        public ActionResult Index()
        {
            return View();
        }
        //    public ActionResult Create()
        //    {
        //        return View();
        //    }

        //    [HttpPost]
        //    public ActionResult Index(StatusViewModel obj, FormCollection fobj)
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            using (var db = new Model11())
        //            {

        //                obj.StatusName = fobj["hidden1"].ToString();
        //                db.StatusViewModels.Add(obj);
        //                db.SaveChanges();
        //                return RedirectToAction("Index");
        //            }
        //        }
        //        return View();
        //    }
        //    [HttpPost]
        //    [ValidateAntiForgeryToken]
        //    //public ActionResult Create([Bind(Include = "ID, NamE, Adress, Phone, PriceDostavki, StatusName")] StatusViewModel statusViewModel)
        //    //{
        //    //    if (ModelState.IsValid)
        //    //    {
        //    //        db.StatusViewModels.Add(statusViewModel);
        //    //        db.SaveChanges();
        //    //        return RedirectToAction("Index");
        //    //    }

        //    //    return View(statusViewModel);
        //    //}


        //    //public ActionResult Order(int? id)
        //    //{
        //    //    if (id == null)
        //    //    {
        //    //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    //    }
        //    //    Status status = db.Statuses.Find(id);
        //    //    if (status == null)
        //    //    {
        //    //        return HttpNotFound();
        //    //    }
        //    //    return View(status);
        //    //}

        //    public ActionResult Update(int? id)
        //    {
        //        if (id == null)
        //        {
        //            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //        }
        //        StatusViewModel statusViewModel = db.StatusViewModels.Find(id);

        //        if (statusViewModel == null)
        //        {
        //            return HttpNotFound();
        //        }
        //        return View(statusViewModel);
        //    }
        //    [HttpPost]
        //    [ValidateAntiForgeryToken]
        //    public ActionResult Update([Bind(Include = "ID, NamE, Adress, Phone, PriceDostavki, StatusName")] StatusViewModel statusViewModel)
        //    {
        //        ViewBag.ss = new SelectList(db.StatusViewModels, "StatusId", "StatusName");

        //        if (ModelState.IsValid)
        //        {
        //            db.Entry(statusViewModel).State = EntityState.Modified;
        //            db.SaveChanges();
        //            return RedirectToAction("Index");
        //        }
        //        return View(statusViewModel);
        //    }


        //    public ActionResult Delete(int? id)
        //    {
        //        if (id == null)
        //        {
        //            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //        }
        //        StatusViewModel statusViewModel = db.Dostavkas.Find(id);
        //        if (statusViewModel == null)
        //        {
        //            return HttpNotFound();
        //        }
        //        return View(statusViewModel);
        //    }
        //    [HttpPost, ActionName("Delete")]
        //    [ValidateAntiForgeryToken]
        //    public ActionResult DeleteConfirmed(int id)
        //    {
        //        StatusViewModel statusViewModel = db.StatusViewModels.Find(id);
        //        db.StatusViewModels.Remove(statusViewModel);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    protected override void Dispose(bool disposing)
        //    {
        //        if (disposing)
        //        {
        //            db.Dispose();
        //        }
        //        base.Dispose(disposing);
        //    }


    }
}

