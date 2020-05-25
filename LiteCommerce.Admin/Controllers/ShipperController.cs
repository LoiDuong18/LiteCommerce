using LiteCommerce.BusinessLayers;
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
    public class ShipperController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(string searchValue = "")
        {
            var model = new Models.ShipperResult
            {
                RowCount = CatalogBLL.Shipper_Count(searchValue),
                Data = CatalogBLL.Shipper_List(searchValue),
            };
            //var listOfSuppliers = CatalogBLL.Supplier_List(page, 10, searchValue);
            //int rowCount = CatalogBLL.Supplier_Count(searchValue);
            //ViewBag.rc = rowCount;
            return View(model);
        }
        /// <summary>
        /// Hiển thị form thêm/sửa Shipper
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Input(string id = "")
        {
            if (string.IsNullOrEmpty(id))
            {
                ViewBag.Title = "Add New Shipper";
                ViewBag.ConfirmButton = "Add";
            }
            else
            {
                ViewBag.Title = "Edit Shipper";
                ViewBag.ConfirmButton = "Save";
            }
            return View();
        }
    }
}