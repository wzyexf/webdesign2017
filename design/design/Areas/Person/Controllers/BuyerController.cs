using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using design.Models;

namespace design.Areas.Person.Controllers
{
    public class BuyerController : Controller
    {
        private Entities db = new Entities();

        // GET: Person/Buyer
        public ActionResult Index()
        {
            return View(db.T_Shop_Buyer.ToList());
        }

        // GET: Person/Buyer/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            T_Shop_Buyer t_Shop_Buyer = db.T_Shop_Buyer.Find(id);
            if (t_Shop_Buyer == null)
            {
                return HttpNotFound();
            }
            return View(t_Shop_Buyer);
        }

        // GET: Person/Buyer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Person/Buyer/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,LoginName,PWD,Sex,Birthday,Status")] T_Shop_Buyer t_Shop_Buyer)
        {
            if (ModelState.IsValid)
            {
                db.T_Shop_Buyer.Add(t_Shop_Buyer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(t_Shop_Buyer);
        }

        // GET: Person/Buyer/Edit/5
        public ActionResult Edit(int? id=1)
        {
            
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            T_Shop_Buyer t_Shop_Buyer = db.T_Shop_Buyer.Find(id);
            if (t_Shop_Buyer == null)
            {
                return HttpNotFound();
            }
            return View(t_Shop_Buyer);
        }

        // POST: Person/Buyer/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,LoginName,PWD,Sex,Birthday,Status")] T_Shop_Buyer t_Shop_Buyer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(t_Shop_Buyer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(t_Shop_Buyer);
        }

        // GET: Person/Buyer/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            T_Shop_Buyer t_Shop_Buyer = db.T_Shop_Buyer.Find(id);
            if (t_Shop_Buyer == null)
            {
                return HttpNotFound();
            }
            return View(t_Shop_Buyer);
        }

        // POST: Person/Buyer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            T_Shop_Buyer t_Shop_Buyer = db.T_Shop_Buyer.Find(id);
            db.T_Shop_Buyer.Remove(t_Shop_Buyer);
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
