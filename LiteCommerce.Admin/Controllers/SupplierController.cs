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
    public class SupplierController : Controller
    {
        /// <summary>
        /// Trang hiển thị : danh sách suppliers, các "liên kết đến" các chức năng liên quan
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(int page = 1, string searchValue = "")
        {          
            var model = new Models.SupplierPaginationResult()
            {
                Page = page,
                PageSize = AppSettings.DefaultPageSize,
                RowCount = CatalogBLL.Supplier_Count(searchValue),
                Data = CatalogBLL.Supplier_List(page, AppSettings.DefaultPageSize, searchValue),
            };
            //var listOfSuppliers = CatalogBLL.Supplier_List(page, 10, searchValue);
            //int rowCount = CatalogBLL.Supplier_Count(searchValue);
            //ViewBag.rc = rowCount;
            //ViewBag.searchValue = searchValue;
            return View(model);

        }
        /// <summary>
        /// Add or Edit
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Input(string id = "")
        {
            if (string.IsNullOrEmpty(id))
            {
                ViewBag.Title = "Add New Supplier";
                ViewBag.ConfirmButton = "Add";
            }
            else
            {
                ViewBag.Title = "Edit Supplier";
                ViewBag.ConfirmButton = "Save";
            }

            return View();
        }

    }
}