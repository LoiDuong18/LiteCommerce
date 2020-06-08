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
    public class ProductController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(int page = 1, string searchValue = "", string categoryId = "")
        {
            var model = new Models.ProductPaginationResult()
            {
                Page = page,
                PageSize = AppSettings.DefaultPageSize,
                RowCount = CatalogBLL.Product_Count(searchValue,categoryId),
                Data = CatalogBLL.Product_List(page, AppSettings.DefaultPageSize, searchValue, categoryId),
                SearchValue = searchValue,
                CategoryID = categoryId
            };
            return View(model);
        }
        /// <summary>
        /// Hiển thị form thêm/sửa Product
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Input(string id = "")
        {
            if (string.IsNullOrEmpty(id))
            {
                ViewBag.Title = "Add New Product";
                ViewBag.ConfirmButton = "Add";
            }
            else
            {
                ViewBag.Title = "Edit Product";
                ViewBag.ConfirmButton = "Save";
            }
            return View();
        }
    }
}