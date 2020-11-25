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
    public class distritoesController : Controller
    {
        private DB_ChambaSearchEntities db = new DB_ChambaSearchEntities();

        // GET: distritoes
        public ActionResult Index()
        {
            var distrito = db.distrito.Include(d => d.provincia);
            return View(distrito.ToList());
        }

        // GET: distritoes/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            distrito distrito = db.distrito.Find(id);
            if (distrito == null)
            {
                return HttpNotFound();
            }
            return View(distrito);
        }

        // GET: distritoes/Create
        public ActionResult Create()
        {
            ViewBag.idprovincia = new SelectList(db.provincia, "idprovincia", "idDepartamento");
            return View();
        }

        // POST: distritoes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idDistrito,idprovincia,nombreDistrito")] distrito distrito)
        {
            if (ModelState.IsValid)
            {
                db.distrito.Add(distrito);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idprovincia = new SelectList(db.provincia, "idprovincia", "idDepartamento", distrito.idprovincia);
            return View(distrito);
        }

        // GET: distritoes/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            distrito distrito = db.distrito.Find(id);
            if (distrito == null)
            {
                return HttpNotFound();
            }
            ViewBag.idprovincia = new SelectList(db.provincia, "idprovincia", "idDepartamento", distrito.idprovincia);
            return View(distrito);
        }

        // POST: distritoes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idDistrito,idprovincia,nombreDistrito")] distrito distrito)
        {
            if (ModelState.IsValid)
            {
                db.Entry(distrito).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idprovincia = new SelectList(db.provincia, "idprovincia", "idDepartamento", distrito.idprovincia);
            return View(distrito);
        }

        // GET: distritoes/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            distrito distrito = db.distrito.Find(id);
            if (distrito == null)
            {
                return HttpNotFound();
            }
            return View(distrito);
        }

        // POST: distritoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            distrito distrito = db.distrito.Find(id);
            db.distrito.Remove(distrito);
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
