using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace design.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        /// <summary>
        /// 登录
        /// </summary>
        /// <returns></returns>
        public ActionResult Login()
        {
            return View();
        }
        /// <summary>
        /// 注册
        /// </summary>
        /// <returns></returns>
        public ActionResult Register()
        {
            return View();
        }
        /// <summary>
        /// 个人中心-密码修改
        /// </summary>
        /// <returns></returns>
        public ActionResult Password()
        {
            return View();
        }
        /// <summary>
        /// 个人中心-个人资料修改
        /// </summary>
        /// <returns></returns>
        public ActionResult Profile()
        {
            return View();
        }
        /// <summary>
        /// 个人中心-订单列表
        /// </summary>
        /// <returns></returns>
        public ActionResult OrderList()
        {
            return View();
        }
    }
}