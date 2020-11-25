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
    public class comentariosController : Controller
    {
        private DB_ChambaSearchEntities db = new DB_ChambaSearchEntities();

        // GET: comentarios
        public ActionResult Index()
        {
            var comentario = db.comentario.Include(c => c.detalleServicio).Include(c => c.persona);
            return View(comentario.ToList());
        }

        // GET: comentarios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            comentario comentario = db.comentario.Find(id);
            if (comentario == null)
            {
                return HttpNotFound();
            }
            return View(comentario);
        }

        // GET: comentarios/Create
        public ActionResult Create()
        {
            ViewBag.idDetalleServicio = new SelectList(db.detalleServicio, "idDetalleServicio", "idDetalleServicio");
            ViewBag.idpersona = new SelectList(db.persona, "idpersona", "idDistrito");
            return View();
        }

        // POST: comentarios/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idcomentario,idpersona,idDetalleServicio,titulo,contenido,likes,dislikes")] comentario comentario)
        {
            if (ModelState.IsValid)
            {
                db.comentario.Add(comentario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idDetalleServicio = new SelectList(db.detalleServicio, "idDetalleServicio", "idDetalleServicio", comentario.idDetalleServicio);
            ViewBag.idpersona = new SelectList(db.persona, "idpersona", "idDistrito", comentario.idpersona);
            return View(comentario);
        }

        // GET: comentarios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            comentario comentario = db.comentario.Find(id);
            if (comentario == null)
            {
                return HttpNotFound();
            }
            ViewBag.idDetalleServicio = new SelectList(db.detalleServicio, "idDetalleServicio", "idDetalleServicio", comentario.idDetalleServicio);
            ViewBag.idpersona = new SelectList(db.persona, "idpersona", "idDistrito", comentario.idpersona);
            return View(comentario);
        }

        // POST: comentarios/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idcomentario,idpersona,idDetalleServicio,titulo,contenido,likes,dislikes")] comentario comentario)
        {
            if (ModelState.IsValid)
            {
                db.Entry(comentario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idDetalleServicio = new SelectList(db.detalleServicio, "idDetalleServicio", "idDetalleServicio", comentario.idDetalleServicio);
            ViewBag.idpersona = new SelectList(db.persona, "idpersona", "idDistrito", comentario.idpersona);
            return View(comentario);
        }

        // GET: comentarios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            comentario comentario = db.comentario.Find(id);
            if (comentario == null)
            {
                return HttpNotFound();
            }
            return View(comentario);
        }

        // POST: comentarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            comentario comentario = db.comentario.Find(id);
            db.comentario.Remove(comentario);
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
