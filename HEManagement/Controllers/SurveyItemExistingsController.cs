using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HEManagement.Models;

namespace HEManagement.Controllers
{
    public class SurveyItemExistingsController : Controller
    {
        private SurveyItemExistingDBContext db = new SurveyItemExistingDBContext();

        // GET: SurveyItemExistings
        public ActionResult Index()
        {
            return View(db.SurveyItemExisting.ToList());
        }

        // GET: SurveyItemExistings/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SurveyItemExisting surveyItemExisting = db.SurveyItemExisting.Find(id);
            if (surveyItemExisting == null)
            {
                return HttpNotFound();
            }
            return View(surveyItemExisting);
        }

        // GET: SurveyItemExistings/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SurveyItemExistings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SurveyItemExistingID,ItemLocation,CeilingHeight,HardwireOrPlugLoad,InteriorOrExterior,Quantity,ExistingFixtureType,FixtureBaseType,PostInstallQuantityRecommended")] SurveyItemExisting surveyItemExisting)
        {
            if (ModelState.IsValid)
            {
                surveyItemExisting.SurveyItemExistingID = Guid.NewGuid();
                db.SurveyItemExisting.Add(surveyItemExisting);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(surveyItemExisting);
        }

        // GET: SurveyItemExistings/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SurveyItemExisting surveyItemExisting = db.SurveyItemExisting.Find(id);
            if (surveyItemExisting == null)
            {
                return HttpNotFound();
            }
            return View(surveyItemExisting);
        }

        // POST: SurveyItemExistings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SurveyItemExistingID,ItemLocation,CeilingHeight,HardwireOrPlugLoad,InteriorOrExterior,Quantity,ExistingFixtureType,FixtureBaseType,PostInstallQuantityRecommended")] SurveyItemExisting surveyItemExisting)
        {
            if (ModelState.IsValid)
            {
                db.Entry(surveyItemExisting).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(surveyItemExisting);
        }

        // GET: SurveyItemExistings/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SurveyItemExisting surveyItemExisting = db.SurveyItemExisting.Find(id);
            if (surveyItemExisting == null)
            {
                return HttpNotFound();
            }
            return View(surveyItemExisting);
        }

        // POST: SurveyItemExistings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            SurveyItemExisting surveyItemExisting = db.SurveyItemExisting.Find(id);
            db.SurveyItemExisting.Remove(surveyItemExisting);
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
