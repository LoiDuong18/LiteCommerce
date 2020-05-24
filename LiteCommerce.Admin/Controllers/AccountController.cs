using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace LiteCommerce.Admin.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Authorize]
    public class AccountController : Controller
    {
        /// <summary>
        /// Giao diện thông tin người dùng
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// Thay đổi mật khẩu
        /// </summary>
        /// <returns></returns>
        public ActionResult ChangePwd()
        {
            return View();
        }
        /// <summary>
        /// Đăng xuất
        /// </summary>
        /// <returns></returns>
        public ActionResult SignOut()
        {
            Session.Abandon();
            Session.Clear();
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Account");
        }
        /// <summary>
        /// Đăng nhập người dùng
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        public ActionResult Login(string email = "",string password = "")
        {
            if(Request.HttpMethod == "GET")
            {
                return View();
            }
            else
            {
                //TODO : Kiểm tra thông tin đăng nhập thông qua CSDL
                if(email == "admin@abc.com" && password == "admin")
                {
                    FormsAuthentication.SetAuthCookie(email,false);
                    return RedirectToAction("Index", "Dashboard");
                }
                else
                {
                    ModelState.AddModelError("error", "Đăng nhập thất bại");
                    ViewBag.email = email;
                    return View();
                }
            }            
        }
        /// <summary>
        /// Quên mật khẩu
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        public ActionResult ForgotPassword()
        {
            return null;
        }
        /// <summary>
        /// Hiển thị form chỉnh sửa thông tin người dùng
        /// </summary>
        /// <returns></returns>
        public ActionResult Edit()
        {
            return View();
        }
    }
}