using LiteCommerce.BusinessLayers;
<<<<<<< HEAD
=======
using LiteCommerce.DomainModels;
>>>>>>> 35b67c81760d8837aeec833336546907ae9df09d
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
<<<<<<< HEAD
=======
            List<Product> data = new List<Product>();
            try
            {
                data = CatalogBLL.Product_List(page, AppSettings.DefaultPageSize, searchValue, categoryId);
            }
            catch (Exception e)
            {
                return RedirectToAction("Index");
            }
>>>>>>> 35b67c81760d8837aeec833336546907ae9df09d
            var model = new Models.ProductPaginationResult()
            {
                Page = page,
                PageSize = AppSettings.DefaultPageSize,
<<<<<<< HEAD
                RowCount = CatalogBLL.Product_Count(searchValue, categoryId),
                Data = CatalogBLL.Product_List(page, AppSettings.DefaultPageSize, searchValue, categoryId),
=======
                RowCount = CatalogBLL.Product_Count(searchValue,categoryId),
                Data = data,
>>>>>>> 35b67c81760d8837aeec833336546907ae9df09d
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Detail(string id = "")
        {
            return View();
        }
    }
}