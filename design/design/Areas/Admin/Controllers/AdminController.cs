using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using design.Models;

namespace design.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        private Entities db = new Entities();

        // GET: Admin/Admin
        public ActionResult Index()
        {
            return View(db.T_Shop_Admin.ToList());
        }

        // GET: Admin/Admin/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            T_Shop_Admin t_Shop_Admin = db.T_Shop_Admin.Find(id);
            if (t_Shop_Admin == null)
            {
                return HttpNotFound();
            }
            return View(t_Shop_Admin);
        }

        // GET: Admin/Admin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Admin/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,LoginName,PWD,Status")] T_Shop_Admin t_Shop_Admin)
        {
            if (ModelState.IsValid)
            {
                db.T_Shop_Admin.Add(t_Shop_Admin);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(t_Shop_Admin);
        }

        // GET: Admin/Admin/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            T_Shop_Admin t_Shop_Admin = db.T_Shop_Admin.Find(id);
            if (t_Shop_Admin == null)
            {
                return HttpNotFound();
            }
            return View(t_Shop_Admin);
        }

        // POST: Admin/Admin/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,LoginName,PWD,Status")] T_Shop_Admin t_Shop_Admin)
        {
            if (ModelState.IsValid)
            {
                db.Entry(t_Shop_Admin).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(t_Shop_Admin);
        }

        // GET: Admin/Admin/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            T_Shop_Admin t_Shop_Admin = db.T_Shop_Admin.Find(id);
            if (t_Shop_Admin == null)
            {
                return HttpNotFound();
            }
            return View(t_Shop_Admin);
        }

        // POST: Admin/Admin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            T_Shop_Admin t_Shop_Admin = db.T_Shop_Admin.Find(id);
            db.T_Shop_Admin.Remove(t_Shop_Admin);
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
