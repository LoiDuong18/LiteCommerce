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
    public class CategoryController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(int page = 1, string searchValue = "")
        {
            var model = new Models.CategoryPaginationResult()
            { 
                RowCount = CatalogBLL.Category_Count(searchValue),
                Data = CatalogBLL.Category_List(page, AppSettings.DefaultPageSize, searchValue),
            };
            //var listOfSuppliers = CatalogBLL.Supplier_List(page, 10, searchValue);
            //int rowCount = CatalogBLL.Supplier_Count(searchValue);
            //ViewBag.rc = rowCount;
            //ViewBag.searchValue = searchValue;
            return View(model);
        }
        /// <summary>
        /// Hiển thị form thêm/sửa category
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Input(string id = "")
        {
            if (string.IsNullOrEmpty(id))
            {
                ViewBag.Title = "Add New Category";
                ViewBag.ConfirmButton = "Add";

                Category newCategory = new Category();
                newCategory.CategoryID = 0;
                return View(newCategory);
            }
            else
            {
                ViewBag.Title = "Edit Category";
                ViewBag.ConfirmButton = "Save";

                try
                {
                    Category editCategory = CatalogBLL.Category_Get(Convert.ToInt32(id));
                    if (editCategory == null)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        return View(editCategory);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return RedirectToAction("Index");
                }
            }
            return View();
        }
    }
}