using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace design.Controllers
{
    public class ShopController : Controller
    {
        // GET: Shop
        /// <summary>
        /// 购物首页
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
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
        public ActionResult Product()
        {
            return View();
        }
        /// <summary>
        /// 购物篮
        /// </summary>
        /// <returns></returns>
        public ActionResult Basket()
        {
            return View();
        }

    }
}