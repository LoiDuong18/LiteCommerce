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
    public class ShipperController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
<<<<<<< HEAD
        public ActionResult Index(int page = 1, string searchValue = "")
        {
           var model = new Models.ShipperPaginationResult()
            {
                
                RowCount = CatalogBLL.Shipper_Count(searchValue),
                Data = CatalogBLL.Shipper_List(page, AppSettings.DefaultPageSize, searchValue),
=======
        public ActionResult Index(string searchValue = "")
        {
            var model = new Models.ShipperResult
            {
                RowCount = CatalogBLL.Shipper_Count(searchValue),
                Data = CatalogBLL.Shipper_List(searchValue),
>>>>>>> 35b67c81760d8837aeec833336546907ae9df09d
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
        /// Hiển thị form thêm/sửa Shipper
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Input(string id = "")
        {
            if (string.IsNullOrEmpty(id))
            {
                ViewBag.Title = "Add New Shipper";
                ViewBag.ConfirmButton = "Add";

                Shipper newShipper = new Shipper();
                newShipper.ShipperID = 0;
                return View(newShipper);
            }
            else
            {
                ViewBag.Title = "Edit Shipper";
                ViewBag.ConfirmButton = "Save";
                try
                {
                    Shipper editShipper = CatalogBLL.Shipper_Get(Convert.ToInt32(id));
                    if (editShipper == null)
                    {
                        return RedirectToAction("Index");
                    }
                    return View(editShipper);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return RedirectToAction("Index");
                }
<<<<<<< HEAD
            }         
=======
            }
>>>>>>> 35b67c81760d8837aeec833336546907ae9df09d
        }
        /// <summary>
        /// 
        /// </summary>
<<<<<<< HEAD
        /// <param name="method"></param>
=======
>>>>>>> 35b67c81760d8837aeec833336546907ae9df09d
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Input(Shipper model)
        {
            try
            {
<<<<<<< HEAD
                //Validation dữ liệu
                if (string.IsNullOrEmpty(model.CompanyName))
                {
                    ModelState.AddModelError("CompanyName", "CompanyName is required");
                }
                if (string.IsNullOrEmpty(model.Phone))
                {
                    ModelState.AddModelError("Phone", "Phone is required");
                }
                //Kiểm tra có tồn tại bất kỳ lỗi nào hay không
                if (!ModelState.IsValid)
                {
                    if (model.ShipperID == 0)
=======

                if (!ModelState.IsValid)
                {
                    if(model.ShipperID == 0)
>>>>>>> 35b67c81760d8837aeec833336546907ae9df09d
                    {
                        ViewBag.Title = "Add New Shipper";
                        ViewBag.ConfirmButton = "Add";
                    }
                    else
                    {
<<<<<<< HEAD
                        ViewBag.Title = "Edit New Shipper";
=======
                        ViewBag.Title = "Edit Shipper";
>>>>>>> 35b67c81760d8837aeec833336546907ae9df09d
                        ViewBag.ConfirmButton = "Save";
                    }
                    return View(model);
                }
                //Đưa dữ liệu vào CSDL
                if (model.ShipperID == 0)
                {
<<<<<<< HEAD
                    int ShipperID = CatalogBLL.Shipper_Add(model);
=======
                    int shipperID = CatalogBLL.Shipper_Add(model);
>>>>>>> 35b67c81760d8837aeec833336546907ae9df09d
                    return RedirectToAction("Index");
                }
                else
                {
                    bool rs = CatalogBLL.Shipper_Update(model);
                    return RedirectToAction("Index");
                }
            }
<<<<<<< HEAD
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message + ":" + ex.StackTrace);
=======
            catch (Exception e)
            {
>>>>>>> 35b67c81760d8837aeec833336546907ae9df09d
                return View(model);
            }
        }
        /// <summary>
        /// 
        /// </summary>
<<<<<<< HEAD
        /// <param name="method"></param>
=======
>>>>>>> 35b67c81760d8837aeec833336546907ae9df09d
        /// <param name="shipperIDs"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Delete(int[] shipperIDs)
        {
            if (shipperIDs != null)
            {
                CatalogBLL.Shipper_Delete(shipperIDs);
            }
            return RedirectToAction("Index");
        }
    }
}