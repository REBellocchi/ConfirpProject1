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
    public class FuncionarioController : Controller
    {
        private ConfirpProjectDBEntities db = new ConfirpProjectDBEntities();

        // GET: Funcionario
        public ActionResult Index()
        {
            return View(db.T_FUNCIONARIO.ToList());
        }

        // GET: Funcionario/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            T_FUNCIONARIO t_FUNCIONARIO = db.T_FUNCIONARIO.Find(id);
            if (t_FUNCIONARIO == null)
            {
                return HttpNotFound();
            }
            return View(t_FUNCIONARIO);
        }

        // GET: Funcionario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Funcionario/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_funcionario,nm_funcionario,dt_nascimento")] T_FUNCIONARIO t_FUNCIONARIO)
        {
            if (ModelState.IsValid)
            {
                db.T_FUNCIONARIO.Add(t_FUNCIONARIO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(t_FUNCIONARIO);
        }

        // GET: Funcionario/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            T_FUNCIONARIO t_FUNCIONARIO = db.T_FUNCIONARIO.Find(id);
            if (t_FUNCIONARIO == null)
            {
                return HttpNotFound();
            }
            return View(t_FUNCIONARIO);
        }

        // POST: Funcionario/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_funcionario,nm_funcionario,dt_nascimento")] T_FUNCIONARIO t_FUNCIONARIO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(t_FUNCIONARIO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(t_FUNCIONARIO);
        }

        // GET: Funcionario/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            T_FUNCIONARIO t_FUNCIONARIO = db.T_FUNCIONARIO.Find(id);
            if (t_FUNCIONARIO == null)
            {
                return HttpNotFound();
            }
            return View(t_FUNCIONARIO);
        }

        // POST: Funcionario/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            T_FUNCIONARIO t_FUNCIONARIO = db.T_FUNCIONARIO.Find(id);
            db.T_FUNCIONARIO.Remove(t_FUNCIONARIO);
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
