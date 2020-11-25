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
    public class detalleServiciosController : Controller
    {
        private DB_ChambaSearchEntities db = new DB_ChambaSearchEntities();

        // GET: detalleServicios
        public ActionResult Index()
        {
            var detalleServicio = db.detalleServicio.Include(d => d.imagen).Include(d => d.persona).Include(d => d.servicio);
            return View(detalleServicio.ToList());
        }

        // GET: detalleServicios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            detalleServicio detalleServicio = db.detalleServicio.Find(id);
            if (detalleServicio == null)
            {
                return HttpNotFound();
            }
            return View(detalleServicio);
        }

        // GET: detalleServicios/Create
        public ActionResult Create()
        {
            ViewBag.idimagen = new SelectList(db.imagen, "idimagen", "ruta");
            ViewBag.idpersona = new SelectList(db.persona, "idpersona", "idDistrito");
            ViewBag.idservicio = new SelectList(db.servicio, "idservicio", "nombreServicio");
            return View();
        }

        // POST: detalleServicios/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idDetalleServicio,idpersona,idservicio,idimagen,cantidadcomentario")] detalleServicio detalleServicio)
        {
            if (ModelState.IsValid)
            {
                db.detalleServicio.Add(detalleServicio);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idimagen = new SelectList(db.imagen, "idimagen", "ruta", detalleServicio.idimagen);
            ViewBag.idpersona = new SelectList(db.persona, "idpersona", "idDistrito", detalleServicio.idpersona);
            ViewBag.idservicio = new SelectList(db.servicio, "idservicio", "nombreServicio", detalleServicio.idservicio);
            return View(detalleServicio);
        }

        // GET: detalleServicios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            detalleServicio detalleServicio = db.detalleServicio.Find(id);
            if (detalleServicio == null)
            {
                return HttpNotFound();
            }
            ViewBag.idimagen = new SelectList(db.imagen, "idimagen", "ruta", detalleServicio.idimagen);
            ViewBag.idpersona = new SelectList(db.persona, "idpersona", "idDistrito", detalleServicio.idpersona);
            ViewBag.idservicio = new SelectList(db.servicio, "idservicio", "nombreServicio", detalleServicio.idservicio);
            return View(detalleServicio);
        }

        // POST: detalleServicios/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idDetalleServicio,idpersona,idservicio,idimagen,cantidadcomentario")] detalleServicio detalleServicio)
        {
            if (ModelState.IsValid)
            {
                db.Entry(detalleServicio).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idimagen = new SelectList(db.imagen, "idimagen", "ruta", detalleServicio.idimagen);
            ViewBag.idpersona = new SelectList(db.persona, "idpersona", "idDistrito", detalleServicio.idpersona);
            ViewBag.idservicio = new SelectList(db.servicio, "idservicio", "nombreServicio", detalleServicio.idservicio);
            return View(detalleServicio);
        }

        // GET: detalleServicios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            detalleServicio detalleServicio = db.detalleServicio.Find(id);
            if (detalleServicio == null)
            {
                return HttpNotFound();
            }
            return View(detalleServicio);
        }

        // POST: detalleServicios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            detalleServicio detalleServicio = db.detalleServicio.Find(id);
            db.detalleServicio.Remove(detalleServicio);
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
