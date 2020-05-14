using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LiteCommerece.Admin.Controllers
{
    public class SupplierController : Controller
    {
        /// <summary>
        /// Trang hiển thị : danh sách suppliers, các " liên kết" đến các chức năng liên quan
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Input(String id= "")
        {
            if (string.IsNullOrEmpty(id))
            {

                ViewBag.Tittle = "Add New Supplier";
            }
            else
            {
                ViewBag.Title = " Edit Supplier";
            }
            return View();

        }
    }
}