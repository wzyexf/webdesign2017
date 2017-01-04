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
    public class T_Shop_OrderController : Controller
    {
        private Entities db = new Entities();

        // GET: Admin/T_Shop_Order
        public ActionResult Index()
        {
            var t_Shop_Order = db.T_Shop_Order.Include(t => t.T_Shop_Buyer);
            return View(t_Shop_Order.ToList());
        }

        // GET: Admin/T_Shop_Order/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            T_Shop_Order t_Shop_Order = db.T_Shop_Order.Find(id);
            if (t_Shop_Order == null)
            {
                return HttpNotFound();
            }
            return View(t_Shop_Order);
        }

        // GET: Admin/T_Shop_Order/Create
        public ActionResult Create()
        {
            ViewBag.BuyerId = new SelectList(db.T_Shop_Buyer, "Id", "LoginName");
            return View();
        }

        // POST: Admin/T_Shop_Order/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ConnectorName,ConnectorAddress,ConnectorPhone,TotalMoney,Status,BuyerId")] T_Shop_Order t_Shop_Order)
        {
            if (ModelState.IsValid)
            {
                db.T_Shop_Order.Add(t_Shop_Order);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.BuyerId = new SelectList(db.T_Shop_Buyer, "Id", "LoginName", t_Shop_Order.BuyerId);
            return View(t_Shop_Order);
        }

        // GET: Admin/T_Shop_Order/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            T_Shop_Order t_Shop_Order = db.T_Shop_Order.Find(id);
            if (t_Shop_Order == null)
            {
                return HttpNotFound();
            }
            ViewBag.BuyerId = new SelectList(db.T_Shop_Buyer, "Id", "LoginName", t_Shop_Order.BuyerId);
            return View(t_Shop_Order);
        }

        // POST: Admin/T_Shop_Order/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ConnectorName,ConnectorAddress,ConnectorPhone,TotalMoney,Status,BuyerId")] T_Shop_Order t_Shop_Order)
        {
            if (ModelState.IsValid)
            {
                db.Entry(t_Shop_Order).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.BuyerId = new SelectList(db.T_Shop_Buyer, "Id", "LoginName", t_Shop_Order.BuyerId);
            return View(t_Shop_Order);
        }

        // GET: Admin/T_Shop_Order/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            T_Shop_Order t_Shop_Order = db.T_Shop_Order.Find(id);
            if (t_Shop_Order == null)
            {
                return HttpNotFound();
            }
            return View(t_Shop_Order);
        }

        // POST: Admin/T_Shop_Order/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            T_Shop_Order t_Shop_Order = db.T_Shop_Order.Find(id);
            db.T_Shop_Order.Remove(t_Shop_Order);
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
