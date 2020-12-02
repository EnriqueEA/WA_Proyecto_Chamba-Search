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
    public class tiposerviciosController : Controller
    {
        private DB_ChambaSearchEntities db = new DB_ChambaSearchEntities();

        // GET: tiposervicios
        public ActionResult Index()
        {
            return View(db.tiposervicio.ToList());
        }

        // GET: tiposervicios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tiposervicio tiposervicio = db.tiposervicio.Find(id);
            if (tiposervicio == null)
            {
                return HttpNotFound();
            }
            return View(tiposervicio);
        }

        // GET: tiposervicios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tiposervicios/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idtipoServicio,nombreTipoServicio")] tiposervicio tiposervicio)
        {
            if (ModelState.IsValid)
            {
                db.tiposervicio.Add(tiposervicio);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tiposervicio);
        }

        // GET: tiposervicios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tiposervicio tiposervicio = db.tiposervicio.Find(id);
            if (tiposervicio == null)
            {
                return HttpNotFound();
            }
            return View(tiposervicio);
        }

        // POST: tiposervicios/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idtipoServicio,nombreTipoServicio")] tiposervicio tiposervicio)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tiposervicio).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tiposervicio);
        }

        // GET: tiposervicios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tiposervicio tiposervicio = db.tiposervicio.Find(id);
            if (tiposervicio == null)
            {
                return HttpNotFound();
            }
            return View(tiposervicio);
        }

        // POST: tiposervicios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tiposervicio tiposervicio = db.tiposervicio.Find(id);
            db.tiposervicio.Remove(tiposervicio);
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
