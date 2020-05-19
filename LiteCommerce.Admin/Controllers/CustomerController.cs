using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LiteCommerce.Admin.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Authorize]
    public class CustomerController : Controller
    {
        /// <summary>
        /// Hiển thị danh sách khách hàng
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// Hiển thị form thêm/sửa thông tin Khách hàng
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Input(string id = "")
        {
            if (string.IsNullOrEmpty(id))
            {
                ViewBag.Title = "Add New Customer";
                ViewBag.ConfirmButton = "Add";
            }
            else
            {
                ViewBag.Title = "Edit Customer";
                ViewBag.ConfirmButton = "Save";
            }
            return View();
        }

        
    }
}