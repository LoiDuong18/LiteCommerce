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
<<<<<<< HEAD
        public ActionResult Index(int page = 1, string searchValue = "")
        {
            var model = new Models.CategoryPaginationResult()
            { 
=======
        public ActionResult Index(string searchValue = "")
        {
            var model = new Models.CategoryResult
            {
>>>>>>> 35b67c81760d8837aeec833336546907ae9df09d
                RowCount = CatalogBLL.Category_Count(searchValue),
                Data = CatalogBLL.Category_List(searchValue),
            };
            //var listOfSuppliers = CatalogBLL.Supplier_List(page, 10, searchValue);
            //int rowCount = CatalogBLL.Supplier_Count(searchValue);
            //ViewBag.rc = rowCount;
<<<<<<< HEAD
            //ViewBag.searchValue = searchValue;
=======
>>>>>>> 35b67c81760d8837aeec833336546907ae9df09d
            return View(model);
        }
        /// <summary>
        /// Hiển thị form thêm/sửa category
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
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
<<<<<<< HEAD

=======
>>>>>>> 35b67c81760d8837aeec833336546907ae9df09d
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
<<<<<<< HEAD
            }   
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Input(Category model)
        {
            try
            {
                //Validate dữ liệu
                if (string.IsNullOrEmpty(model.CategoryName))
                {
                    ModelState.AddModelError("CategoryName", "CategoryName is required");
                }
                if (string.IsNullOrEmpty(model.Description))
                {
                    model.Description = "";
                }

                if (!ModelState.IsValid)
                {
                    if (model.CategoryID == 0)
                    {
                        ViewBag.Title = "Add New Shipper";
                        ViewBag.ConfirmButton = "Add";
                    }
                    else
                    {
                        ViewBag.Title = "Edit New Shipper";
                        ViewBag.ConfirmButton = "Save";
                    }
                    return View(model);
                }
                //Đưa dữ liệu vào CSDL
                if (model.CategoryID == 0)
                {
                    int shipperID = CatalogBLL.Category_Add(model);
                    return RedirectToAction("Index");
                }
                else
                {
                    bool rs = CatalogBLL.Category_Update(model);
                    return RedirectToAction("Index");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return View(model);
=======
>>>>>>> 35b67c81760d8837aeec833336546907ae9df09d
            }
        }
        /// <summary>
        /// 
        /// </summary>
<<<<<<< HEAD
=======
        /// <returns></returns>
        [HttpPost]
        public ActionResult Input(Category model)
        {
            try
            {
                if (string.IsNullOrEmpty(model.Description))
                {
                    model.Description = "";
                }

                if (!ModelState.IsValid)
                {
                    if (model.CategoryID == 0)
                    {
                        ViewBag.Title = "Add New Shipper";
                        ViewBag.ConfirmButton = "Add";
                    }
                    else
                    {
                        ViewBag.Title = "Edit New Shipper";
                        ViewBag.ConfirmButton = "Save";
                    }
                    return View(model);
                }
                //Đưa dữ liệu vào CSDL
                if (model.CategoryID == 0)
                {
                    int shipperID = CatalogBLL.Category_Add(model);
                    return RedirectToAction("Index");
                }
                else
                {
                    bool rs = CatalogBLL.Category_Update(model);
                    return RedirectToAction("Index");
                }
            }
            catch (Exception e)
            {
                return View(model);
            }
        }
        /// <summary>
        /// 
        /// </summary>
>>>>>>> 35b67c81760d8837aeec833336546907ae9df09d
        /// <param name="categoryIDs"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Delete(int[] categoryIDs)
        {
            if (categoryIDs != null)
                CatalogBLL.Category_Delete(categoryIDs);
            return RedirectToAction("Index");
        }
    }
}