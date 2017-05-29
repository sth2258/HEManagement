using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HEManagement.Models;
using System.Web.Routing;

namespace HEManagement.Controllers
{
    public class SurveysController : Controller
    {
        private SurveyDBContext db = new SurveyDBContext();

        // GET: Surveys
        public ActionResult Index()
        {
            
            return View(db.Survey.ToList());
        }

        // GET: Surveys/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Survey survey = db.Survey.Find(id);
            if (survey == null)
            {
                return HttpNotFound();
            }
            ViewBag.SurveyID = id;
            ViewBag.CustomerName = (new CustomerDBContext()).Customers.Single(m => m.CustomerID == survey.CustomerID).CustomerName;
            return View(survey);
        }

        // GET: Surveys/Create
        public ActionResult Create()
        {
            List<SelectListItem> tmp = new List<SelectListItem>();
            CustomerDBContext context = new CustomerDBContext();
            int cnt = 0;
            foreach(Customer a in context.Customers)
            {
                tmp.Add(new SelectListItem { Text = a.CustomerName, Value = a.CustomerID.ToString() });
                cnt++;
            }

            if(cnt== 0)
            {
                tmp.Add(new SelectListItem { Text = "No Customers Found", Value = "N/a" });
            }
            ViewBag.Items = tmp;
            return View();
        }

        // POST: Surveys/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SurveyID,SurveyDateTime,CustomerID,CeilingHeight")] Survey survey)
        {
            if (ModelState.IsValid)
            {
                survey.SurveyID = Guid.NewGuid();
                db.Survey.Add(survey);
                db.SaveChanges();
                return RedirectToAction("Create", new RouteValueDictionary(
    new { controller = "SurveyItemExistings", action = "Create", SurveyID = survey.SurveyID }));
            }

            return View(survey);
        }

        // GET: Surveys/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Survey survey = db.Survey.Find(id);
            if (survey == null)
            {
                return HttpNotFound();
            }
            List<SelectListItem> tmp = new List<SelectListItem>();
            CustomerDBContext context = new CustomerDBContext();
            int cnt = 0;
            foreach (Customer a in context.Customers)
            {
                if (a.CustomerID == survey.CustomerID)
                {
                    tmp.Add(new SelectListItem { Text = a.CustomerName, Value = a.CustomerID.ToString(), Selected = true });

                }
                else {
                    tmp.Add(new SelectListItem { Text = a.CustomerName, Value = a.CustomerID.ToString() });
                }
                cnt++;
            }
            ViewBag.Items = tmp;
            return View(survey);
        }

        // POST: Surveys/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SurveyID,SurveyDateTime,CustomerID,CeilingHeight")] Survey survey, IEnumerable<HttpPostedFile> files)
        {
            if (ModelState.IsValid)
            {
                db.Entry(survey).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            List<SelectListItem> tmp = new List<SelectListItem>();
            CustomerDBContext context = new CustomerDBContext();
            int cnt = 0;

            foreach (var file in files)
            {
                if (file.ContentLength > 0)
                {
                    //var fileName = Path.GetFileName(file.FileName);
                    //var path = Path.Combine(Server.MapPath("~/App_Data/uploads"), fileName);
                    //file.SaveAs(path);
                }
            }
            foreach (Customer a in context.Customers)
            {
                if (a.CustomerID == survey.CustomerID)
                {
                    tmp.Add(new SelectListItem { Text = a.CustomerName, Value = a.CustomerID.ToString(), Selected = true });

                }
                else
                {
                    tmp.Add(new SelectListItem { Text = a.CustomerName, Value = a.CustomerID.ToString() });
                }
                cnt++;
            }
            ViewBag.Items = tmp;
            return View(survey);
        }

        // GET: Surveys/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Survey survey = db.Survey.Find(id);
            if (survey == null)
            {
                return HttpNotFound();
            }
            return View(survey);
        }

        // POST: Surveys/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            Survey survey = db.Survey.Find(id);
            db.Survey.Remove(survey);
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
