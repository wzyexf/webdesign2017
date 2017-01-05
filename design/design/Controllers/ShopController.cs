using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace design.Controllers
{
    public class ShopController : Controller
    {
       public  design.Models.Entities shopDb = new Models.Entities();
        // GET: Shop
        /// <summary>
        /// 购物首页
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            #region 处理

            //Models.DB db = new Models.DB();

            //ViewBag.lst = db.lst;


            
            ViewBag.lst = shopDb.T_Shop_Product.ToList();

            return View("/views/shop/index.cshtml");
            #endregion
        

    }

        public ActionResult AddBasket(int ProductId,int Amount)
        {
            if (Session["person"] == null)
            {
                return Redirect("/person/buyer/login");

            }
            design.Models.T_Shop_Product product= shopDb.T_Shop_Product.Find(ProductId);

            design.Models.T_Shop_Basket basket = new Models.T_Shop_Basket();
            basket.BuyerId = ((design.Models.T_Shop_Buyer)Session["person"]).Id;
            basket.Price = product.Price;
            basket.ProductId = product.Id;
            basket.Amount = Amount;
            shopDb.T_Shop_Basket.Add(basket);
            shopDb.SaveChanges();
            return Redirect("/Basket/index");
        }
        /// <summary>
        /// 产品分类展示页面
        /// </summary>
        /// <returns></returns>
        public ActionResult Category()
        {
            return View();
        }
        /// <summary>
        /// 产品详情页
        /// </summary>
        /// <returns></returns>
        public ActionResult Product(int id)
        {
            design.Models.T_Shop_Product product=  shopDb.T_Shop_Product.Find(id);
            ViewBag.product = product;


            return View();
        }
        /// <summary>
        /// 购物篮
        /// </summary>
        /// <returns></returns>
        

       
    }
}