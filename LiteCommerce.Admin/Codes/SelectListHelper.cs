using LiteCommerce.BusinessLayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LiteCommerce.Admin
{
    public class SelectListHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
<<<<<<< HEAD
        public static List<SelectListItem> ListOfCountries()
        {
=======
        public static List<SelectListItem> ListOfCountries() {
>>>>>>> 35b67c81760d8837aeec833336546907ae9df09d
            List<SelectListItem> listCountries = new List<SelectListItem>();
            listCountries.Add(new SelectListItem() { Value = "USA", Text = "United State" });
            listCountries.Add(new SelectListItem() { Value = "UK", Text = "England" });
            listCountries.Add(new SelectListItem() { Value = "CN", Text = "China" });
            listCountries.Add(new SelectListItem() { Value = "VN", Text = "Vietnam" });
            return listCountries;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<SelectListItem> ListOfCategories()
        {
            List<SelectListItem> listCategory = new List<SelectListItem>();
<<<<<<< HEAD
            foreach (var item in CatalogBLL.Category_List(""))
            {
                listCategory.Add(new SelectListItem() { Value = Convert.ToString(item.CategoryID), Text = item.CategoryName });
=======
            foreach(var item in CatalogBLL.Category_List(""))
            {
                listCategory.Add(new SelectListItem() { Value = Convert.ToString(item.CategoryID), Text = item.CategoryName});
>>>>>>> 35b67c81760d8837aeec833336546907ae9df09d
            }
            return listCategory;
        }
    }
}