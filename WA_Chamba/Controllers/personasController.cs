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
    public class personasController : Controller
    {
        private DB_ChambaSearchEntities db = new DB_ChambaSearchEntities();

        // GET: personas
        public ActionResult Index()
        {
            var persona = db.persona.Include(p => p.distrito).Include(p => p.tipoCuenta);
            return View(persona.ToList());
        }

        // GET: personas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            persona persona = db.persona.Find(id);
            if (persona == null)
            {
                return HttpNotFound();
            }
            return View(persona);
        }

        // GET: personas/Create
        public ActionResult Create()
        {
            ViewBag.idDistrito = new SelectList(db.distrito, "idDistrito", "idprovincia");
            ViewBag.idtipoCuenta = new SelectList(db.tipoCuenta, "idtipoCuenta", "nombreTipoCuenta");
            return View();
        }

        // POST: personas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idpersona,idDistrito,nombres,apePaterno,apeMaterno,fechaNacimiento,sexo,dni,celular,email,imagenPerfil,idtipoCuenta,nom_usuario,password,fechaRegistrado,estadoCuenta")] persona persona)
        {
            if (ModelState.IsValid)
            {
                db.persona.Add(persona);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idDistrito = new SelectList(db.distrito, "idDistrito", "idprovincia", persona.idDistrito);
            ViewBag.idtipoCuenta = new SelectList(db.tipoCuenta, "idtipoCuenta", "nombreTipoCuenta", persona.idtipoCuenta);
            return View(persona);
        }

        // GET: personas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            persona persona = db.persona.Find(id);
            if (persona == null)
            {
                return HttpNotFound();
            }
            ViewBag.idDistrito = new SelectList(db.distrito, "idDistrito", "idprovincia", persona.idDistrito);
            ViewBag.idtipoCuenta = new SelectList(db.tipoCuenta, "idtipoCuenta", "nombreTipoCuenta", persona.idtipoCuenta);
            return View(persona);
        }

        // POST: personas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idpersona,idDistrito,nombres,apePaterno,apeMaterno,fechaNacimiento,sexo,dni,celular,email,imagenPerfil,idtipoCuenta,nom_usuario,password,fechaRegistrado,estadoCuenta")] persona persona)
        {
            if (ModelState.IsValid)
            {
                db.Entry(persona).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idDistrito = new SelectList(db.distrito, "idDistrito", "idprovincia", persona.idDistrito);
            ViewBag.idtipoCuenta = new SelectList(db.tipoCuenta, "idtipoCuenta", "nombreTipoCuenta", persona.idtipoCuenta);
            return View(persona);
        }

        // GET: personas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            persona persona = db.persona.Find(id);
            if (persona == null)
            {
                return HttpNotFound();
            }
            return View(persona);
        }

        // POST: personas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            persona persona = db.persona.Find(id);
            db.persona.Remove(persona);
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
