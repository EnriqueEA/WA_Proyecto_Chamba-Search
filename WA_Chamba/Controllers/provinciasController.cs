using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WA_Chamba;

namespace WA_Chamba.Controllers
{
    public class provinciasController : Controller
    {
        private DB_ChambaSearchEntities db = new DB_ChambaSearchEntities();

        // GET: provincias
        public ActionResult Index()
        {
            var provincia = db.provincia.Include(p => p.departamento);
            return View(provincia.ToList());
        }

        // GET: provincias/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            provincia provincia = db.provincia.Find(id);
            if (provincia == null)
            {
                return HttpNotFound();
            }
            return View(provincia);
        }

        // GET: provincias/Create
        public ActionResult Create()
        {
            ViewBag.idDepartamento = new SelectList(db.departamento, "idDepartamento", "nombreDepartamento");
            return View();
        }

        // POST: provincias/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idprovincia,idDepartamento,nombreProvincia")] provincia provincia)
        {
            if (ModelState.IsValid)
            {
                db.provincia.Add(provincia);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idDepartamento = new SelectList(db.departamento, "idDepartamento", "nombreDepartamento", provincia.idDepartamento);
            return View(provincia);
        }

        // GET: provincias/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            provincia provincia = db.provincia.Find(id);
            if (provincia == null)
            {
                return HttpNotFound();
            }
            ViewBag.idDepartamento = new SelectList(db.departamento, "idDepartamento", "nombreDepartamento", provincia.idDepartamento);
            return View(provincia);
        }

        // POST: provincias/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idprovincia,idDepartamento,nombreProvincia")] provincia provincia)
        {
            if (ModelState.IsValid)
            {
                db.Entry(provincia).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idDepartamento = new SelectList(db.departamento, "idDepartamento", "nombreDepartamento", provincia.idDepartamento);
            return View(provincia);
        }

        // GET: provincias/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            provincia provincia = db.provincia.Find(id);
            if (provincia == null)
            {
                return HttpNotFound();
            }
            return View(provincia);
        }

        // POST: provincias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            provincia provincia = db.provincia.Find(id);
            db.provincia.Remove(provincia);
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
