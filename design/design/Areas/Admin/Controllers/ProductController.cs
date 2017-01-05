using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using design.Models;
using System.IO;

namespace design.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        private Entities db = new Entities();

        // GET: Admin/Product
        public ActionResult Index()
        {
            var t_Shop_Product = db.T_Shop_Product.Include(t => t.T_Shop_ProductCategory);
            return View(t_Shop_Product.ToList());
        }

        // GET: Admin/Product/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            T_Shop_Product t_Shop_Product = db.T_Shop_Product.Find(id);
            if (t_Shop_Product == null)
            {
                return HttpNotFound();
            }
            return View(t_Shop_Product);
        }

        // GET: Admin/Product/Create
        public ActionResult Create()
        {
            ViewBag.CategoryId = new SelectList(db.T_Shop_ProductCategory, "Id", "Name");
            return View();
        }

        // POST: Admin/Product/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Price,Decription,Stock,MothSells,Pic,CategoryId")] T_Shop_Product t_Shop_Product)
        {
            if (ModelState.IsValid)
            {

                var myfile1 = Request.Files["Pic"];
                   if (myfile1 != null)
                   {
                     myfile1.SaveAs(Path.Combine(Request.MapPath("~/Upload"), Path.GetFileName(myfile1.FileName)));
                    t_Shop_Product.Pic = Path.GetFileName(myfile1.FileName);
                }

              
                db.T_Shop_Product.Add(t_Shop_Product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CategoryId = new SelectList(db.T_Shop_ProductCategory, "Id", "Name", t_Shop_Product.CategoryId);
            return View(t_Shop_Product);
        }

        // GET: Admin/Product/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            T_Shop_Product t_Shop_Product = db.T_Shop_Product.Find(id);
            if (t_Shop_Product == null)
            {
                return HttpNotFound();
            }
            ViewBag.CategoryId = new SelectList(db.T_Shop_ProductCategory, "Id", "Name", t_Shop_Product.CategoryId);
            return View(t_Shop_Product);
        }

        // POST: Admin/Product/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Price,Decription,Stock,MothSells,Pic,CategoryId")] T_Shop_Product t_Shop_Product)
        {
            if (ModelState.IsValid)
            {
                db.Entry(t_Shop_Product).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CategoryId = new SelectList(db.T_Shop_ProductCategory, "Id", "Name", t_Shop_Product.CategoryId);
            return View(t_Shop_Product);
        }

        // GET: Admin/Product/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            T_Shop_Product t_Shop_Product = db.T_Shop_Product.Find(id);
            if (t_Shop_Product == null)
            {
                return HttpNotFound();
            }
            return View(t_Shop_Product);
        }

        // POST: Admin/Product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            T_Shop_Product t_Shop_Product = db.T_Shop_Product.Find(id);
            db.T_Shop_Product.Remove(t_Shop_Product);
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
