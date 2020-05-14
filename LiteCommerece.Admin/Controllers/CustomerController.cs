using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LiteCommerece.Admin.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Input(String id = "")
        {
            if (string.IsNullOrEmpty(id))
            {

                ViewBag.Tittle = "Add New Customers";
            }
            else
            {
                ViewBag.Title = " Edit Customers";
            }
            return View();

        }
    }
}