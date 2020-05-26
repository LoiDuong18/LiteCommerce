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
    public class EmployeeController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(int page = 1, string searchValue = "")
        {
            var model = new Models.EmployeePaginationResult()
            {
                Page = page,
                PageSize = AppSettings.DefaultPageSize,
                RowCount = HumanResourceBLL.Employee_Count(searchValue),
                Data = HumanResourceBLL.Employee_List(page, AppSettings.DefaultPageSize, searchValue),
            };
            //var listOfCustomers = CatalogBLL.Customer_List(page, 10, searchValue);
            //int rowCount = CatalogBLL.Customer_Count(searchValue);
            //ViewBag.rc = rowCount;
            //ViewBag.searchValue = searchValue;
            return View(model);
        }
        /// <summary>
        /// Hiển thị form thêm/sửa Employee
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Input(string id = "")
        {
            if (string.IsNullOrEmpty(id))
            {
                ViewBag.Title = "Add New Employee";
                ViewBag.ConfirmButton = "Add";

                Employee newSupplier = new Employee();
                newSupplier.EmployeeID = 0;
                return View(newSupplier);
            }
            else
            {
                ViewBag.Title = "Edit Employee";
                ViewBag.ConfirmButton = "Save";

                Employee editEmployee = HumanResourceBLL.Employee_Get(Convert.ToInt32(id));
                if (editEmployee == null)
                {
                    return RedirectToAction("Index");
                }
                return View(editEmployee);
            }
            
        }
    }
}