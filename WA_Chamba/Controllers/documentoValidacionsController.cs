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
    public class documentoValidacionsController : Controller
    {
        private DB_ChambaSearchEntities db = new DB_ChambaSearchEntities();

        // GET: documentoValidacions
        public ActionResult Index()
        {
            var documentoValidacion = db.documentoValidacion.Include(d => d.documento).Include(d => d.persona);
            return View(documentoValidacion.ToList());
        }

        // GET: documentoValidacions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            documentoValidacion documentoValidacion = db.documentoValidacion.Find(id);
            if (documentoValidacion == null)
            {
                return HttpNotFound();
            }
            return View(documentoValidacion);
        }

        // GET: documentoValidacions/Create
        public ActionResult Create()
        {
            ViewBag.idDocumento = new SelectList(db.documento, "idDocumento", "descripcion");
            ViewBag.idpersona = new SelectList(db.persona, "idpersona", "idDistrito");
            return View();
        }

        // POST: documentoValidacions/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idDocumentoValidacion,idpersona,idDocumento,estadoDocumento")] documentoValidacion documentoValidacion)
        {
            if (ModelState.IsValid)
            {
                db.documentoValidacion.Add(documentoValidacion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idDocumento = new SelectList(db.documento, "idDocumento", "descripcion", documentoValidacion.idDocumento);
            ViewBag.idpersona = new SelectList(db.persona, "idpersona", "idDistrito", documentoValidacion.idpersona);
            return View(documentoValidacion);
        }

        // GET: documentoValidacions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            documentoValidacion documentoValidacion = db.documentoValidacion.Find(id);
            if (documentoValidacion == null)
            {
                return HttpNotFound();
            }
            ViewBag.idDocumento = new SelectList(db.documento, "idDocumento", "descripcion", documentoValidacion.idDocumento);
            ViewBag.idpersona = new SelectList(db.persona, "idpersona", "idDistrito", documentoValidacion.idpersona);
            return View(documentoValidacion);
        }

        // POST: documentoValidacions/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idDocumentoValidacion,idpersona,idDocumento,estadoDocumento")] documentoValidacion documentoValidacion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(documentoValidacion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idDocumento = new SelectList(db.documento, "idDocumento", "descripcion", documentoValidacion.idDocumento);
            ViewBag.idpersona = new SelectList(db.persona, "idpersona", "idDistrito", documentoValidacion.idpersona);
            return View(documentoValidacion);
        }

        // GET: documentoValidacions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            documentoValidacion documentoValidacion = db.documentoValidacion.Find(id);
            if (documentoValidacion == null)
            {
                return HttpNotFound();
            }
            return View(documentoValidacion);
        }

        // POST: documentoValidacions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            documentoValidacion documentoValidacion = db.documentoValidacion.Find(id);
            db.documentoValidacion.Remove(documentoValidacion);
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
