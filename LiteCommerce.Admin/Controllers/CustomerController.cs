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
    public class CustomerController : Controller
    {
        /// <summary>
        /// Hiển thị danh sách khách hàng
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(int page = 1, string searchValue = "")
        {
            var model = new Models.CustomerPaginationResult()
            {
                Page = page,
                PageSize = AppSettings.DefaultPageSize,
                RowCount = CatalogBLL.Customer_Count(searchValue),
                Data = CatalogBLL.Customer_List(page, AppSettings.DefaultPageSize, searchValue),
            };
            return View(model);
        }
        /// <summary>
        /// Hiển thị form thêm/sửa thông tin Khách hàng
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Input(string id = "")
        {
            if (string.IsNullOrEmpty(id))
            {
                ViewBag.Title = "Add New Customer";
                ViewBag.ConfirmButton = "Add";
                ViewBag.Method = "add";

                Customer newCustomer = new Customer();
                newCustomer.CustomerID = "";
                return View(newCustomer);
            }
            else
            {
                ViewBag.Title = "Edit Customer";
                ViewBag.ConfirmButton = "Save";
                ViewBag.Method = "update";
                try
                {
                    Customer editCustomer = CatalogBLL.Customer_Get(id);
                    if (editCustomer == null)
                    {
                        return RedirectToAction("Index");
                    }
                    return View(editCustomer);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return RedirectToAction("Index");
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Input(Customer model,string method)
        {
            try
            {
                //Nếu không có trường method thì chuyển hướng về Index
                if (string.IsNullOrEmpty(method))
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    //Validation dữ liệu
                    if (string.IsNullOrEmpty(model.CustomerID))
                    {
                        ModelState.AddModelError("CustomerID", "CustomerID is required");
                    }
                    if (string.IsNullOrEmpty(model.CompanyName))
                    {
                        ModelState.AddModelError("CompanyName", "CompanyName is required");
                    }
                    if (string.IsNullOrEmpty(model.ContactName))
                    {
                        ModelState.AddModelError("ContactName", "ContactName is required");
                    }
                    if (string.IsNullOrEmpty(model.ContactTitle))
                    {
                        ModelState.AddModelError("ContactTitle", "ContactTitle is required");
                    }
                    if (string.IsNullOrEmpty(model.Address))
                    {
                        ModelState.AddModelError("Address", "Address is required");
                    }
                    if (string.IsNullOrEmpty(model.Country))
                    {
                        ModelState.AddModelError("Country", "Country is required");
                    }
                    if (string.IsNullOrEmpty(model.City))
                    {
                        ModelState.AddModelError("City", "City is required");
                    }
                    if (string.IsNullOrEmpty(model.Phone))
                    {
                        ModelState.AddModelError("Phone", "Phone is required");
                    }
                    if (string.IsNullOrEmpty(model.Fax))
                    {
                        model.Fax = "";
                    }

                    //Kiểm tra có tồn tại bất kỳ lỗi nào hay không
                    if (!ModelState.IsValid)
                    {
                        if (method=="add")
                        {
                            ViewBag.Title = "Add New Supplier";
                            ViewBag.ConfirmButton = "Add";
                            ViewBag.Method = "add";
                            return View(model);
                        }
                        else
                        {
                            ViewBag.Title = "Edit New Supplier";
                            ViewBag.ConfirmButton = "Save";
                            ViewBag.Method = "update";
                            return View(model);
                        }
                        
                    }
                    //Đưa dữ liệu vào CSDL
                    if (method== "add")
                    {
                        int customerID = CatalogBLL.Customer_Add(model);                        
                    }
                    else if(method == "update")
                    {
                        bool rs = CatalogBLL.Customer_Update(model);
                    }
                    return RedirectToAction("Index");
                }
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message + ":" + e.StackTrace);
                return View(model);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="customerIDs"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Delete(string[] customerIDs)
        {
            if (customerIDs != null)
                CatalogBLL.Customer_Delete(customerIDs);
            return RedirectToAction("Index");
        }
    }
}