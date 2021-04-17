using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ATOM.Models;

namespace ATOM.Controllers
{
    public class IntershipsController : Controller
    {
        private IntershipContext db = new IntershipContext();

        // GET: Interships
        public ActionResult Index()
        {
            return View(db.Interships.Include(t=> t.DictStateIntership).OrderByDescending(d => d.DateCreate).ToList());
        }

        // GET: Interships/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Intership intership = db.Interships.Include(t => t.DictStateIntership).FirstOrDefault(t => t.ID == id);
            if (intership == null)
            {
                return HttpNotFound();
            }
            return View(intership);
        }

        // GET: Interships/Create
        public ActionResult Create()
        {
            ViewBag.Stations = db.DictStateInterships.ToList();
            return View();
        }

        // POST: Interships/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Intership_MVC_Model model)
        {
            if (ModelState.IsValid)
            {
                var intership = new Intership
                {
                    DictStateIntership = db.DictStateInterships.FirstOrDefault(t=> t.ID == model.ID),
                    DateCreate = DateTime.Now,
                    DateEdit = DateTime.Now,
                    ID_Employer = 1, //TODO исправить после привязки
                    ImproverPosition = model.ImproverPosition,
                    IntershipFullDescription = model.IntershipFullDescription,
                    IntershipName = model.IntershipName,
                    IntershipShortDescription = model.IntershipShortDescription
                };
                db.Interships.Add(intership);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(model);
        }

        // GET: Interships/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Intership intership = db.Interships.Include(t => t.IntershipFullDescription).FirstOrDefault(t => t.ID == id);
            if (intership == null)
            {
                return HttpNotFound();
            }
            ViewBag.Stations = db.DictStateInterships.ToList();
            var model = new Intership_MVC_Model
            {
                ID = intership.ID,
                IntershipFullDescription = intership.IntershipFullDescription,
                DictStateIntership_ID = intership.DictStateIntership.ID,
                IntershipShortDescription = intership.IntershipShortDescription,
                IntershipName = intership.IntershipName,
                DateCreate = intership.DateCreate,
                DateEdit = intership.DateEdit,
                ID_Employer = intership.ID_Employer,
                ImproverPosition = intership.ImproverPosition
            };

            return View(model);
        }

        // POST: Interships/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Intership_MVC_Model model)
        {
            if (ModelState.IsValid)
            {
                var intership = db.Interships.FirstOrDefault(t => t.ID == model.ID);
                intership = new Intership
                {
                    ID = model.ID,
                    DictStateIntership = db.DictStateInterships.FirstOrDefault(t => t.ID == model.ID),
                    DateCreate = DateTime.Now,
                    DateEdit = DateTime.Now,
                    ID_Employer = 1, //TODO исправить после привязки
                    ImproverPosition = model.ImproverPosition,
                    IntershipFullDescription = model.IntershipFullDescription,
                    IntershipName = model.IntershipName,
                    IntershipShortDescription = model.IntershipShortDescription
                };
                db.Entry(intership).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        // GET: Interships/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Intership intership = db.Interships.Find(id);
            if (intership == null)
            {
                return HttpNotFound();
            }
            return View(intership);
        }

        // POST: Interships/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Intership intership = db.Interships.Find(id);
            db.Interships.Remove(intership);
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
