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
    public class CategoryController : Controller
    {
        private Entities db = new Entities();

        // GET: Admin/Category
        public ActionResult Index()
        {
            return View(db.T_Shop_ProductCategory.ToList());
        }

        // GET: Admin/Category/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            T_Shop_ProductCategory t_Shop_ProductCategory = db.T_Shop_ProductCategory.Find(id);
            if (t_Shop_ProductCategory == null)
            {
                return HttpNotFound();
            }
            return View(t_Shop_ProductCategory);
        }

        // GET: Admin/Category/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Category/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Description")] T_Shop_ProductCategory t_Shop_ProductCategory)
        {
            if (ModelState.IsValid)
            {
                db.T_Shop_ProductCategory.Add(t_Shop_ProductCategory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(t_Shop_ProductCategory);
        }

        // GET: Admin/Category/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            T_Shop_ProductCategory t_Shop_ProductCategory = db.T_Shop_ProductCategory.Find(id);
            if (t_Shop_ProductCategory == null)
            {
                return HttpNotFound();
            }
            return View(t_Shop_ProductCategory);
        }

        // POST: Admin/Category/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Description")] T_Shop_ProductCategory t_Shop_ProductCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(t_Shop_ProductCategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(t_Shop_ProductCategory);
        }

        // GET: Admin/Category/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            T_Shop_ProductCategory t_Shop_ProductCategory = db.T_Shop_ProductCategory.Find(id);
            if (t_Shop_ProductCategory == null)
            {
                return HttpNotFound();
            }
            return View(t_Shop_ProductCategory);
        }

        // POST: Admin/Category/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            T_Shop_ProductCategory t_Shop_ProductCategory = db.T_Shop_ProductCategory.Find(id);
            db.T_Shop_ProductCategory.Remove(t_Shop_ProductCategory);
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
