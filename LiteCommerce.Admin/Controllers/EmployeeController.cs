using LiteCommerce.BusinessLayers;
using LiteCommerce.DomainModels;
using System;
using System.Collections.Generic;
using System.IO;
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
                SearchValue = searchValue,
            };
            return View(model);
        }
        /// <summary>
        /// Hiển thị form thêm/sửa Employee
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Input(string id = "")
        {
            if (string.IsNullOrEmpty(id))
            {
                ViewBag.Title = "Add New Employee";
                ViewBag.ConfirmButton = "Add";

                Employee newEmployee = new Employee();
                newEmployee.EmployeeID = 0;
                return View(newEmployee);
            }
            else
            {
                ViewBag.Title = "Edit Employee";
                ViewBag.ConfirmButton = "Save";
                try
                {
                    Employee editEmployee = HumanResourceBLL.Employee_Get(Convert.ToInt32(id));
                    if (editEmployee == null)
                    {
                        return RedirectToAction("Index");
                    }
                    return View(editEmployee);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                    return RedirectToAction("Index");
                }
            }
        }
        [HttpPost]
        public ActionResult Input(Employee model,HttpPostedFileBase uploadPhoto)
        {
            try
            {
                //Validate dữ liệu
                if (string.IsNullOrEmpty(model.FirstName))
                {
                    ModelState.AddModelError("FirstName", "FirstName is required");
                }
                if (string.IsNullOrEmpty(model.LastName))
                {
                    ModelState.AddModelError("LastName", "LastName is required");
                }
                if (string.IsNullOrEmpty(model.Title))
                {
                    ModelState.AddModelError("Title", "Title is required");
                }
                //if (string.IsNullOrEmpty(model.BirthDate))
                //{
                //    ModelState.AddModelError("BirthDate", "BirthDate is required");
                //}
                //if (string.IsNullOrEmpty(model.HireDate))
                //{
                //    ModelState.AddModelError("HireDate", "HireDate is required");
                //}
                if (string.IsNullOrEmpty(model.HomePhone))
                {
                    ModelState.AddModelError("HomePhone", "HomePhone is required");
                }
                if (string.IsNullOrEmpty(model.Email))
                {
                    ModelState.AddModelError("Email", "Email is required");
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
                if (string.IsNullOrEmpty(model.Notes))
                {
                    model.Notes = "";
                }
                //Upload ảnh
                if(uploadPhoto != null && uploadPhoto.ContentLength > 0)
                {
                    string filePath = Path.Combine(Server.MapPath("~/Images"), uploadPhoto.FileName);
                    uploadPhoto.SaveAs(filePath);
                    model.PhotoPath = "Images/"+uploadPhoto.FileName;
                }
                else if(model.PhotoPath == null)
                {
                    model.PhotoPath = "";
                }
                if (!ModelState.IsValid)
                {
                    if (model.EmployeeID == 0)
                    {
                        ViewBag.Title = "Add New Employee";
                        ViewBag.ConfirmButton = "Add";
                    }
                    else
                    {
                        ViewBag.Title = "Edit New Employee";
                        ViewBag.ConfirmButton = "Save";
                    }
                    return View(model);
                }
                //Đưa dữ liệu vào CSDL
                if (model.EmployeeID == 0)
                {
                    int shipperID = HumanResourceBLL.Employee_Add(model);
                    return RedirectToAction("Index");
                }
                else
                {
                    bool rs = HumanResourceBLL.Employee_Update(model);
                    return RedirectToAction("Index");
                }
            }
            catch (Exception e)
            {
                return View(model);
            }
        }
    }
}