using LiteCommerce.BusinessLayers;
using LiteCommerce.DomainModels;
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
                SearchValue = searchValue,
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
                Supplier newSupplier = new Supplier();
                newSupplier.SupplierID = 0;
                return View(newSupplier);
            }
            else
            {
                ViewBag.Title = "Edit Supplier";
                ViewBag.ConfirmButton = "Save";

                Supplier editSupplier = CatalogBLL.Supplier_Get(Convert.ToInt32(id));
                if (editSupplier == null)
                {
                    return RedirectToAction("Index");
                }
                return View(editSupplier);
            }
        }
    }
}