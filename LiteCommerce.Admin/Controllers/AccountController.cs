using LiteCommerce.BusinessLayers;
using LiteCommerce.DomainModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
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
            HttpCookie requestCookies = Request.Cookies["userInfo"];
            string email = Convert.ToString(requestCookies["Email"]);
            Employee model = AccountBLL.Account_Get(email);
            return View(model);
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
                var newUser = AccountBLL.Account_Login(email, password);
                if (newUser!=null)
                {
                    Account account = AccountBLL.Account_Login(email, password);
                    FormsAuthentication.SetAuthCookie(account.AccountID.ToString(), false);
                    HttpCookie userInfo = new HttpCookie("userInfo");
                    userInfo["AccountID"] = account.AccountID.ToString();
                    userInfo["FullName"] = Server.UrlEncode(account.LastName +" "+ account.FirstName);
                    userInfo["Email"] = account.Email;
                    userInfo["PhotoPath"] = account.PhotoPath;
                    userInfo.Expires = DateTime.Now.AddDays(1);
                    Response.Cookies.Add(userInfo);
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
        [HttpGet]
        public ActionResult Edit()
        {
            HttpCookie requestCookies = Request.Cookies["userInfo"];
            string email = Convert.ToString(requestCookies["Email"]);
            Employee model = AccountBLL.Account_Get(email);
            return View(model);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Edit(Employee model)
        {
            if (string.IsNullOrEmpty(model.Email))
            {
                ModelState.AddModelError("Email", "Email is required");
            }
            if (string.IsNullOrEmpty(model.HomePhone))
            {
                ModelState.AddModelError("HomePhone", "Phone is required");
            }
            if (string.IsNullOrEmpty(model.Address))
            {
                ModelState.AddModelError("Address", "Address is required");
            }
            if (string.IsNullOrEmpty(model.Country))
            {
                ModelState.AddModelError("Country", "Country is required");
            }
            if (string.IsNullOrEmpty(model.City))
            {
                ModelState.AddModelError("City", "City is required");
            }
            if (string.IsNullOrEmpty(model.Notes))
            {
                model.Notes = "";
            }
            HttpCookie requestCookies = Request.Cookies["userInfo"];
            model.EmployeeID = Convert.ToInt32(requestCookies["AccountID"]);
            if (!HumanResourceBLL.Employee_CheckEmail(model.EmployeeID, model.Email, "update"))
            {
                ModelState.AddModelError("Email", "Email ready exist");
            }
            //Kiểm tra có tồn tại bất kỳ lỗi nào hay không
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            
            try
            {
                bool rs = HumanResourceBLL.Employee_Update(model);
                requestCookies.Values["Email"] = model.Email;
                Response.SetCookie(requestCookies);
                return RedirectToAction("Index");                               
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message + ":" + e.StackTrace);
                return View(model);
            }            
        }
    }
}