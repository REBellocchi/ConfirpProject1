using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ConfirpProject1;

namespace ConfirpProject1.Controllers
{
    public class DependenteController : Controller
    {
        private ConfirpProjectDBEntities db = new ConfirpProjectDBEntities();

        // GET: Dependente
        public ActionResult Index()
        {
            var t_DEPENDENTE = db.T_DEPENDENTE.Include(t => t.T_FUNCIONARIO);
            return View(t_DEPENDENTE.ToList());
        }

        // GET: Dependente/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            T_DEPENDENTE t_DEPENDENTE = db.T_DEPENDENTE.Find(id);
            if (t_DEPENDENTE == null)
            {
                return HttpNotFound();
            }
            return View(t_DEPENDENTE);
        }

        // GET: Dependente/Create
        public ActionResult Create()
        {
            ViewBag.id_funcionario = new SelectList(db.T_FUNCIONARIO, "id_funcionario", "nm_funcionario");
            return View();
        }

        // POST: Dependente/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_dependente,nm_dependente,dt_nascimento,id_funcionario")] T_DEPENDENTE t_DEPENDENTE)
        {
            if (ModelState.IsValid)
            {
                db.T_DEPENDENTE.Add(t_DEPENDENTE);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_funcionario = new SelectList(db.T_FUNCIONARIO, "id_funcionario", "nm_funcionario", t_DEPENDENTE.id_funcionario);
            return View(t_DEPENDENTE);
        }

        // GET: Dependente/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            T_DEPENDENTE t_DEPENDENTE = db.T_DEPENDENTE.Find(id);
            if (t_DEPENDENTE == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_funcionario = new SelectList(db.T_FUNCIONARIO, "id_funcionario", "nm_funcionario", t_DEPENDENTE.id_funcionario);
            return View(t_DEPENDENTE);
        }

        // POST: Dependente/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_dependente,nm_dependente,dt_nascimento,id_funcionario")] T_DEPENDENTE t_DEPENDENTE)
        {
            if (ModelState.IsValid)
            {
                db.Entry(t_DEPENDENTE).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_funcionario = new SelectList(db.T_FUNCIONARIO, "id_funcionario", "nm_funcionario", t_DEPENDENTE.id_funcionario);
            return View(t_DEPENDENTE);
        }

        // GET: Dependente/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            T_DEPENDENTE t_DEPENDENTE = db.T_DEPENDENTE.Find(id);
            if (t_DEPENDENTE == null)
            {
                return HttpNotFound();
            }
            return View(t_DEPENDENTE);
        }

        // POST: Dependente/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            T_DEPENDENTE t_DEPENDENTE = db.T_DEPENDENTE.Find(id);
            db.T_DEPENDENTE.Remove(t_DEPENDENTE);
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
