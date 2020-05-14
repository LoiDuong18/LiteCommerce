using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace LiteCommerece.Admin.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class AccountController : Controller
    {
        /// <summary>
        /// Trang Quản lý tin của user 
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ChangePwd()
        {
            return View();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult Signout()
        {
            Session.Abandon();
            Session.Clear();
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Account");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
      [AllowAnonymous]
        public ActionResult Login(string email = " ", string password = " ")
        {
            if (Request.HttpMethod == "GET")
            {
                return View();
            }
            else
            {
                //TODO: Kiểm tra thông tin đăng nhập thông qua CSDL
                if (email== "admin@abc.com" && password =="admin")
                {
                    System.Web.Security.FormsAuthentication.SetAuthCookie(email, false);
                    return RedirectToAction("Index", "Dashboard");
                }
                else
                {
                    ModelState.AddModelError("", "Đăng nhập thất bại");
                    ViewBag.Email = email;
                    return View();
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        public ActionResult ForgotPwd()
        {
            return View();
        }
    }
}